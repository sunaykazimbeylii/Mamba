using Mamba.DAL;
using Mamba.Models;
using Mamba.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Mamba.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
           _context = context;
        }
        public async Task<IActionResult> Index()
        {
           HomeVM homeVM = new HomeVM { 
           Employees=_context.Employees.ToList(),
           Positions=_context.Positions.ToList(),

           };
            return View(homeVM);
        }
    }
}
