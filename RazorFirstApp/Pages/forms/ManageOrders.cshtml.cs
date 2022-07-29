using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorFirstApp.Data;
using RazorFirstApp.Models;

namespace RazorFirstApp.Pages.forms
{
    public class ManageOrdersModel : PageModel
    {
        public List<BurgerOrder> burgerOrders = new List<BurgerOrder>();
        private readonly ApplicationDBContext _context;
        public ManageOrdersModel(ApplicationDBContext context)
        {
            _context=context;
        }
        public void OnGet()
        {
            burgerOrders = _context.BurgerOrder.ToList();
        }
    }
}
