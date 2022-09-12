using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCDemo.Models;
using MVCDemo.Services;

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
        public IActionResult List(int Id)
        {
            List<Friend> friends = FriendService.GetAll();
            return View(friends);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Friend f)
        {
            //Pizza p = new Pizza { Id = Id, Name = Name, Size = (PizzaSize)Size, IsGlutenFree = IsGlutenFree, Price = Price };
            FriendService.Add(f);
            return RedirectToAction("List");
        }

        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(Friend f)
        {
            //Pizza p = new Pizza { Id = Id, Name = Name, Size = (PizzaSize)Size, IsGlutenFree = IsGlutenFree, Price = Price };
            FriendService.Update(f);
            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            Friend f = FriendService.Get(id);
            if (f != null)
                return View(f);
            else
                return RedirectToAction("List");
        }


        [HttpPost]
        public IActionResult Delete(Friend f)
        {
            FriendService.Delete(f.FriendID);
            return RedirectToAction("List");
        }

    }
}
