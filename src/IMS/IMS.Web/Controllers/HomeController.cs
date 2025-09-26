using System.Diagnostics;
using Cortex.Mediator;
using IMS.Application.Features.Inventory.Commands;
using IMS.Application.Features.Inventory.Queries;
using IMS.Domain;
using IMS.Domain.Entities;
using IMS.Infrastructure.Data;
using IMS.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace IMS.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IApplicationUnitOfWork _unitOfWork;
        private readonly IMediator _mediator;

        public HomeController(ILogger<HomeController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var command = new ProductAddCommand
            {
                Name = "Gaming Kits",
                Price = 3000
            };
            var product = await _mediator.SendCommandAsync<ProductAddCommand, Product>(command);

            //var query = new ProductGetQuery { Id = new Guid("43FF2D14-160E-4EF3-8E21-FD87DC9C3964") };
            //var result = await _mediator.SendQueryAsync<ProductGetQuery, Product>(query);
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
