using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lesson_4.Pages
{
    public class IndexModel : PageModel
    {
        public static int Count = 0;
        public DateTime CurrentTime { get; set; }

        public string MyMessage { get; set; }
        public void OnGet()
        {
            // runs when someone requests page

            CurrentTime = DateTime.Now;
            MyMessage = "don't go so damn fast!";
        }
    }
}
