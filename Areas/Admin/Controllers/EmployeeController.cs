using Mamba.DAL;
using Mamba.Models;
using Mamba.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Mamba.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmployeeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IHostEnvironment _env;

        public EmployeeController(AppDbContext context,IHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Employee> employees = await _context.Employees.Include(e=>e.Position).ToListAsync();
            return View(employees);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async IActionResult Create(CreateEmployeeVM employeeVM)
        {
            if (!ModelState.IsValid) return View();
          
          
            return View();
        }
      
    }
}
