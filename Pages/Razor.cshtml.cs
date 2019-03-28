using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace HandLab10.Pages
{
    public class RazorModel : PageModel
    {
        private readonly ILogger _log;
        public RazorModel(ILogger<RazorModel> log)
        {
            _log = log;
        }
        public void OnPost()
        {
            _log.LogInformation("OnPost() Called");
        }
        public void OnGet()
        {

        }
    }
}