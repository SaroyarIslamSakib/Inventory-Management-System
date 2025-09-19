using System.Diagnostics;
using IMS.Domain;
using IMS.Infrastructure.Data;
using IMS.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace IMS.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IApplicationUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IApplicationUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            //_unitOfWork.ProductRepository.Add(new Domain.Entities.Product
            //{
            //    Id = Guid.NewGuid(),
            //    Name = "Monitor",
            //    Price = 40000
            //});
            //_unitOfWork.Save();
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
