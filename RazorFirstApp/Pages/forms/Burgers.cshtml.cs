using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorFirstApp.Models;

namespace RazorFirstApp.Pages.forms
{
    public class BurgersModel : PageModel
    {
        public List<BurgersModels>  fakeDB=new List<BurgersModels>()                                                                                                     

        {
            new BurgersModels(){ImageTitle="ChickenBurger", BurgerName="ChickenBurger" , BasePrice=2, Tomato=true, Cheese=true, FinalPrice=4},
            new BurgersModels(){ImageTitle="HamBurger", BurgerName="HamBurger" , BasePrice=2, Tomato=true, Cheese=true, Ham=true, FinalPrice=6},
            new BurgersModels(){ImageTitle="LentilBurger", BurgerName="LentilBurger" , BasePrice=2, Tomato=true, Cheese=true, Ham=true, FinalPrice=12},
            new BurgersModels(){ImageTitle="PlantBasedBurger", BurgerName="PlantBasedBurger" , BasePrice=2, Tomato=true, Cheese=true, Ham=true, FinalPrice=8},
            new BurgersModels(){ImageTitle="MosaMeatBurger", BurgerName="MosaMeatBurger" , BasePrice=2, Tomato=true, Cheese=true, Ham=true, FinalPrice=15},

            new BurgersModels(){ImageTitle="HamBurger", BurgerName="HamBurger" , BasePrice=2, Tomato=true, Cheese=true, Ham=true, FinalPrice=6}
        };
        public void OnGet()
        {
        }
    }
}
