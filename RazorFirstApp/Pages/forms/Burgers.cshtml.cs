using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorFirstApp.Models;

namespace RazorFirstApp.Pages.forms
{
    public class BurgersModel : PageModel
    {
        public List<BurgersModels> FakeDB = new List<BurgersModels>()
        {
            new BurgersModels(){ImageTitle="ChickenBurger", BurgersName="ChickenBurger" , BasePrice=2, Tomato=true, Cheese=true, BurgerPrice=4}
        };
        public void OnGet()
        {
        }
    }
}
