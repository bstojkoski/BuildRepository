using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace ASW.Bootcamp.WebApp.Pages {
    public class IndexModel : PageModel {
        IConfiguration configuration;
        public string color;
        public IndexModel(IConfiguration configuration) {
            this.configuration = configuration;
        }
        public void OnGet() {
            ViewData["Color"] = configuration.GetValue<string>("TextColor") ?? "black";
        }
    }
}
