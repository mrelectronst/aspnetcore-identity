using System.Diagnostics;
using identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace identity.Controllers
{
    public class AdminController: Controller
    {
        private readonly ILogger<AdminController> _logger;
        private readonly UserManager<AppUser> _userManager;

        public AdminController(ILogger<AdminController> logger,UserManager<AppUser> userManager)
    {
        _logger = logger;
            this._userManager = userManager;
        }

    public IActionResult Index()
    {
        return View(_userManager.Users.ToList());
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    }
}