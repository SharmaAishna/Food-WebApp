using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorFirstApp.Pages.Checkout
{
  
    [BindProperties(SupportsGet =true)]
    public class CheckoutModel : PageModel
    {
        public string BurgerName { get; set; }
        public float BurgerPrice { get; set; }
        public string ImageTitle { get; set; }
        public void OnGet()
        {
            if(string.IsNullOrWhiteSpace(BurgerName))
            {
                BurgerName = "Custom";
            }
            if(string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "BurgerDelivery";
            }
                
    }
    }
}
