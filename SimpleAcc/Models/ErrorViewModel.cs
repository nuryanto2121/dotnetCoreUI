using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Diagnostics;

namespace SimpleAcc.Models
{
    public class ErrorViewModel : PageModel
    {
        //public string RequestId { get; set; }

        //public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public void OnGet()
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
        }
    }
}