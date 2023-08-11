using MenuTables.Data;
using MenuTables.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MenuTables.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataDbContext _context;
        public HomeController(ILogger<HomeController> logger, DataDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
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

        public void Seed()
        {
            List<TblMenu> tblMenus = new List<TblMenu>()
            {
                new TblMenu
                {
                    MenuId=Guid.NewGuid(),
                    ArabicPageTitle="الصفحة الرئيسية",
                    EnglishPageTitle="Home Page",
                    Icon="<i class=\"fas fa-home\"></i>",
                    IsDeleted=false,
                    IsShowInMenu=true,
                    ParnetId=null,
                    Url="/Home/Index"
                },
                 new TblMenu
                {
                    MenuId=Guid.NewGuid(),
                    ArabicPageTitle="نبذة عنا",
                    EnglishPageTitle="About",
                    Icon="<i class=\"fas fa-info-circle\"></i>",
                    IsDeleted=false,
                    IsShowInMenu=true,
                    ParnetId=null,
                    Url="/Home/Private"
                },
            };


            _context.TblMenus.AddRange(tblMenus);
            _context.SaveChanges();
        }
    }
}