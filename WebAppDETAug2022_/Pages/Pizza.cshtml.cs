using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppDETAug2022_.Models;
using WebAppDETAug2022_.Service;


namespace WebAppDETAug2022_.Pages
{
    public class PizzaModel : PageModel
    {
        public void OnGet()
        {
            pizzas = PizzaService.GetAll();
        }
        
        public List<Pizza> pizzas = new();

        public string GlutenFreeText(Pizza pizza)
        {
            return pizza.IsGlutenFree ? "Gluten Free" : "Not Gluten Free";
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            PizzaService.Add(NewPizza);
            return RedirectToAction("Get");
        }

        [BindProperty]
        public Pizza NewPizza { get; set; } = new();

        public IActionResult OnPostDelete(int id)
        {
            PizzaService.Delete(id);
            return RedirectToAction("Get");
        }

    } 
    
}
