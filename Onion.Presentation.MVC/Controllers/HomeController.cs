using Microsoft.AspNetCore.Mvc;
using Onion.Application.Contract.AtricaleCategory;
using Onion.Application.Contract.Email;
using Onion.Presentation.MVC.Models;
using System.Diagnostics;

namespace Onion.Presentation.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmailApplication _emailApplication;
        private readonly IArticleCategoryApplication _articleCategoryApplication;

        public HomeController(ILogger<HomeController> logger,
            IEmailApplication emailApplication,
            IArticleCategoryApplication articleCategoryApplication)
        {
            _logger = logger;
            _emailApplication = emailApplication;
            _articleCategoryApplication = articleCategoryApplication;
        }

        public IActionResult Index()
        {
            var email = new EmailSendDTO();
            email.Subject = "Subject";
            email.EmailAddress = "A@a.a";
            email.Content = "MY CONTENT GOES HERE";
            _emailApplication.EmailSendAsync(email);


            var articleCategory = new ArticleCategoryCreateDTO();
            articleCategory.Name = "T1";
            articleCategory.IsActive = true;
            articleCategory.DateTime = "1400/01/01"; 

            _articleCategoryApplication.Create(articleCategory);

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