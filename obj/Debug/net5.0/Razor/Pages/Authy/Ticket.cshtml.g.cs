#pragma checksum "/home/nhbean/auth-test/Pages/Authy/Ticket.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d63b39e9f281157144f27f455c061e09035b13ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(auth_test.Pages.Authy.Pages_Authy_Ticket), @"mvc.1.0.razor-page", @"/Pages/Authy/Ticket.cshtml")]
namespace auth_test.Pages.Authy
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/home/nhbean/auth-test/Pages/_ViewImports.cshtml"
using auth_test;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d63b39e9f281157144f27f455c061e09035b13ea", @"/Pages/Authy/Ticket.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5689e6c4cc7b5d1a2087313ae0bbadf482bc3feb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Authy_Ticket : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h1>Login Ticket</h1>\n");
#nullable restore
#line 7 "/home/nhbean/auth-test/Pages/Authy/Ticket.cshtml"
Write(Model.Ticket);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorCasExample.Pages.Auth.TicketModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorCasExample.Pages.Auth.TicketModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorCasExample.Pages.Auth.TicketModel>)PageContext?.ViewData;
        public RazorCasExample.Pages.Auth.TicketModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591