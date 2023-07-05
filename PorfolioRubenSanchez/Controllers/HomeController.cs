using Microsoft.AspNetCore.Mvc;
using PorfolioRubenSanchez.Models;
using PorfolioRubenSanchez.Services;
using System.Diagnostics;

namespace PorfolioRubenSanchez.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProjectsRepo projectsRepo;

        public HomeController(ILogger<HomeController> logger, IProjectsRepo ProjectsRepo)
        {
            _logger = logger;
            this.projectsRepo = ProjectsRepo;
            
        }

        public IActionResult Index()
        {
           
           var projects = projectsRepo.GetProjects().Take(2).ToList();
           
           var model = new HomeIndexViewModel() 
           { 
               Projects = projects
           };
           return View(model);
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