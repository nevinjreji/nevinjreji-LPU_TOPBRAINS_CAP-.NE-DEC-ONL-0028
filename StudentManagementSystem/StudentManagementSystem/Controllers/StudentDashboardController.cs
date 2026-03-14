using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Data;

namespace StudentManagementSystem.Controllers
{
	public class StudentDashboardController : Controller
	{
		private readonly ApplicationDbContext _context;

		public StudentDashboardController(ApplicationDbContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			return View();
		}
	}
}