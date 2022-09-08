using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using MVCDemo.Services;

namespace MVCDemo.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> pizzas = PizzaService.GetAll();
            return View(pizzas);
        }

        public IActionResult Detail(int Id)
        {
            Pizza p = PizzaService.Get(Id);
            return View(p);
        }

        public IActionResult List(int Id)
        {
            List<Pizza> pizzas = PizzaService.GetAll();
            return View(pizzas);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Pizza p)
        {
            //Pizza p = new Pizza { Id = Id, Name = Name, Size = (PizzaSize)Size, IsGlutenFree = IsGlutenFree, Price = Price };
            PizzaService.Add(p);
            return RedirectToAction("List");
        }

        public IActionResult Delete(int Id)
        {
            Pizza p = PizzaService.Get(Id);
            if (p != null)
                return View(p);
            else
                return RedirectToAction("List");

        }

        [HttpPost]
        public IActionResult Delete(Pizza p)
        {

            PizzaService.Delete(p.Id);
            return RedirectToAction("List");

        }
    }
}
