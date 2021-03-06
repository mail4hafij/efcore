using Microsoft.AspNetCore.Mvc;
using src.db;
using src.db.repo;
using System.Diagnostics;
using web.Models;

namespace web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILandlordRepository _landlordRepository;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, ILandlordRepository landlordRepository, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _landlordRepository = landlordRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            using (var transaction = _unitOfWork.BeginTransaction())
            {
                try
                {
                    await _landlordRepository.Add(new src.db.data.model.Landlord("BRF stockholm"));
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // Auto rollback
                }           
            }

            var landlord = _landlordRepository.GetLandlord();
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