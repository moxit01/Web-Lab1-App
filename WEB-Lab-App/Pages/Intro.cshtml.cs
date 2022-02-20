using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WEB_Lab_App.Pages
{
    public class IntroModel : PageModel
    {
        [FromQuery(Name ="Value1")]
        public int Value1 { get; set; }


        [FromQuery(Name = "Value2")]
        public int Value2 { get; set; }


        

        public void OnGet()
        {
        }

        


    }
}
