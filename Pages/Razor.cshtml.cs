using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandLab10.Pages
{
    public class RazorModel : PageModel
    {
        [BindProperty]
        [Display(Name = "First Name")]
        public string FirstName {get; set;}

        [BindProperty]
        [Display(Name = "Last Name")]
        public string LastName {get; set;}

        public string Display{get; set;}

        private readonly ILogger _log;
        public RazorModel(ILogger<RazorModel> log)
        {
            _log = log;
        }
        public void OnPost()
        {
            _log.LogInformation($"{FirstName} {LastName}");
        }
        public void OnGet()
        {
            Display = ($"{FirstName} {LastName}");

        }
    }
}