using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorFirstApp.Models;

namespace RazorFirstApp.Pages.forms
{
    public class CustomBurgersModel : PageModel
    {
        [BindProperty]
        public BurgersModels Burgers { get; set; }
        public float BurgerPrice { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            BurgerPrice = Burgers.BasePrice;
            if (Burgers.Tomato) BurgerPrice = +1;
            if (Burgers.Lettuce) BurgerPrice = +1;
            if (Burgers.Cheese) BurgerPrice = +1;
            if (Burgers.Onion) BurgerPrice = +1;
            if (Burgers.Jalepano) BurgerPrice = +1;
            if (Burgers.corns) BurgerPrice = +1;
            return RedirectToPage("/Checkout/checkout", new {Burgers.BurgersName,BurgerPrice});

        }
    }
}
