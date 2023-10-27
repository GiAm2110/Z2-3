using L2.DAL;
using L2.DAL.Interfaces;
using L2.Domain;
using L2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace L2.Controllers
{
    public class HomeController : Controller
    {

        private readonly IBaseRepository<Cars> _carsRepository;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IBaseRepository<Cars> carsRepository)
        {
            _logger = logger;
            _carsRepository = carsRepository;
        }

        public IActionResult Index()
        {
            //var resault = _appDbContext.Cars;
            var cars = _carsRepository.GetAll();
            return View();
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