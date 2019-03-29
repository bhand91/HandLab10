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
        [StringLength(10, MinimumLength = 3)]
        [BindProperty]
        [Required]
        [Display(Name = "First Name")]
        public string FirstName {get; set;}

        
        [StringLength(10, MinimumLength = 3)]
        [Required]
        [Display(Name = "Last Name")]
        [BindProperty]
        public string LastName {get; set;}

        [CreditCard]
        [Required]
        [StringLength(16, MinimumLength = 16)]
        [Display(Name = "Credit Card")]
        [BindProperty]
        public string CreditCard {get; set;}

        public string Display{get; set;}

        private readonly ILogger _log;
        public RazorModel(ILogger<RazorModel> log)
        {
            _log = log;
        }
        public void OnPost()
        {
            _log.LogInformation($"{FirstName} {LastName} {CreditCard}");
        }
        public void OnGet()
        {
            Display = ($"{FirstName} {LastName}");

        }
    }
}