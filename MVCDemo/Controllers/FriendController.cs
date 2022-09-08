using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class FriendController : Controller
    {
        public List<Friend> friends { get; set; }
        public IActionResult Index()
        {
            friends = new List<Friend>();
            //events.Add(new Booking { Title = "ask CEO", EventDate = DateTime.Today, Qty = 10 });
            return View(friends);
        }
    }
}
