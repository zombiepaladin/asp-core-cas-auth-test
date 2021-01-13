using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorCasExample.Pages.Auth
{
    public class TicketModel : PageModel
    {
        const string AUTH_SERVICE_HOST = "http://localhost:3000/auth/";
        const string AUTH_CAS_HOST = "https://signin.k-state.edu/WebISO/";

        public string Ticket {get; set;}

        public void OnGet(string ticket)
        {
	    this.Ticket = ticket;
        }
    }
}

