using Microsoft.EntityFrameworkCore;
using RazorFirstApp.Models;

namespace RazorFirstApp.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<BurgerOrder> BurgerOrders { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options): base(options)
        {

        }
    }
    
}
