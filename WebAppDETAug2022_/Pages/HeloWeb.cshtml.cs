using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppDETAug2022_.Pages
{
    public class HeloWebModel : PageModel
    {
        public string Message { get; set; }
        public int Discount { get; set; }
        public void OnGet()
        {
            Message = "ASP.Net Core is Rocking";
            Discount = 15;
        }
    }
}
