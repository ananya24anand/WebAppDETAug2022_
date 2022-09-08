using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppDETAug2022_.Service;

namespace WebAppDETAug2022_.Pages
{
    public class HeloPageModel : PageModel
    {
        public Helo2 ob { get; set; }
        public string Message { get; set; }
        public void OnGet()
        {
            ob = new Helo2();
            Message = ob.SayHelo("Ananya");
        }
    }
}
