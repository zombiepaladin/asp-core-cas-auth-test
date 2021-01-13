using System;
using System.IO;
using System.Net;
using System.Linq;
using System.Xml.Linq;
using System.Security.Claims;
using System.Security.Authentication;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace AuthExample
{

   [AllowAnonymous]
   [Route("Auth")]
   public class AuthController : Controller
   {
       const string AUTH_SERVICE_HOST = "https://bricolage.cs.ksu.edu/auth/";
       const string AUTH_CAS_HOST = "https://signin.k-state.edu/WebISO/";

       [Route("Login")]
       public async Task<IActionResult> Login(string returnUrl = null)
       {
           string url = $"{AUTH_CAS_HOST}/login?service={Uri.EscapeDataString(AUTH_SERVICE_HOST)}ticket";
           return Redirect(url);           
       }

       [Route("Logout")]
       public async Task<IActionResult> Logout()
       {
           await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
           return Redirect("/"); 
       }

       [Route("Ticket")]
       public async Task<IActionResult> Ticket(string ticket)
        {
            var url = $"{AUTH_CAS_HOST}serviceValidate?ticket={ticket}&service={Uri.EscapeDataString(AUTH_SERVICE_HOST)}ticket";
            WebRequest request = WebRequest.Create(url);

            using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string body = await reader.ReadToEndAsync();
			
                        XDocument doc = XDocument.Parse(body);
                        var element = doc.Descendants("{http://www.yale.edu/tp/cas}user").FirstOrDefault();
                        if(element != null)
                        {
                            string eid = element.Value;
                            var userClaims = new List<Claim>()
                            {
                                new Claim(ClaimTypes.Name, eid),
                                new Claim(ClaimTypes.Email, $"{eid}@ksu.edu")
                            };
                            var userIdentity = new ClaimsIdentity(userClaims, "User Identity");
                            var userPrinciple = new ClaimsPrincipal(new[] { userIdentity });
                            await HttpContext.SignInAsync(
                                CookieAuthenticationDefaults.AuthenticationScheme,
                                userPrinciple);

                            return Redirect("/");
                        }
                    }
                }
            }

            return StatusCode(403);
        }
   }
}
