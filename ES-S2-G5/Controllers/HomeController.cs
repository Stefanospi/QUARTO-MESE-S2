using ES_S2_G5.Entity;
using ES_S2_G5.Models;
using ES_S2_G5.Service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ES_S2_G5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IArticleService<Article> _articleService;

        public HomeController(ILogger<HomeController> logger, IArticleService<Article> articleService)
        {
            _logger = logger;
            _articleService = articleService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult FormArticle()
        {
            return View(new Article());
        }

        [HttpPost]
        public IActionResult Write(Article article)
        {
            _articleService.CreateArticle(article);
            return RedirectToAction("Dettagli");
        }
        public IActionResult Delete(Article article)
        {
            _articleService.DeleteArticle(article.Id);
            return RedirectToAction(nameof(Index));
        }
        

        public IActionResult Dettagli(int id)
        {
            var articles = _articleService.GetById(id);
            return View(articles);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
