using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCCoreAppExample.Models;

namespace MVCCoreAppExample.Controllers
{    
    public class CustomerController : Controller
    {
        private readonly Context _context;
 
        public CustomerController(Context context)
        {
            _context = context;
        }
 
        public IActionResult Index()
        {
            var customers = _context.Customers;     
 
            return View(customers);
        }
    }
}