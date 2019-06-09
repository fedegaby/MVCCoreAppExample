using Microsoft.EntityFrameworkCore;
using MVCCoreAppExample.Models;
 
namespace MVCCoreAppExample
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {            
        }
 
        public DbSet<Customer> Customers { get; set; }        
    }
}