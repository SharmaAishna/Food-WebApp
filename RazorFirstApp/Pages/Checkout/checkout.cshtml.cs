using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorFirstApp.Data;
using RazorFirstApp.Models;

namespace RazorFirstApp.Pages.Checkout
{
  
    [BindProperties(SupportsGet =true)]
    public class CheckoutModel : PageModel
    {
        public string BurgerName { get; set; }
        public float BurgerPrice { get; set; }
        public string ImageTitle { get; set; }

        private readonly ApplicationDBContext _context;
        public CheckoutModel(ApplicationDBContext context)
        {
            _context = context;     
        }
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
            BurgerOrder order = new BurgerOrder();
            order.BurgerName=BurgerName;
            order.BasePrice=BurgerPrice;
            _context.BurgerOrder.Add(order);
            _context.SaveChanges();
    }
    }
}
