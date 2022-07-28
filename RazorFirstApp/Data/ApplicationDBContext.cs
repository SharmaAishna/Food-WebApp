using Microsoft.EntityFrameworkCore;
using RazorFirstApp.Models;

namespace RazorFirstApp.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<BurgerOrder> BurgerOrder { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options): base(options)
        {

        }
    }
    
}
