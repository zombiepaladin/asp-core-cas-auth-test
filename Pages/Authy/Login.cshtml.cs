using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorCasExample.Pages.Auth
{
    public class LoginModel : PageModel
    {
        const string AUTH_SERVICE_HOST = "https://bricolage.cs.ksu.edu/auth/";
        const string AUTH_CAS_HOST = "https://signin.k-state.edu/WebISO/";

	public string URL {get; set;}

        public IActionResult OnGet()
        {
            string url = $"{AUTH_CAS_HOST}/login?service={Uri.EscapeDataString(AUTH_SERVICE_HOST)}ticket";
	    URL=url;
            return Redirect(url);
        }
    }
}

