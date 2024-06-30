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
        private readonly IWebHostEnvironment _env;


        public HomeController(ILogger<HomeController> logger, IArticleService<Article> articleService,IWebHostEnvironment env)
        {
            _logger = logger;
            _articleService = articleService;
            _env = env;
        }

        public IActionResult Index()
        {
            var articles = _articleService.GetArticles();
            return View(articles);
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
        public IActionResult FormArticle(Article article)
        {
            if (ModelState.IsValid)
            {
                var a = new Article
                {
                    Name = article.Name,
                    Price = article.Price,
                    Description = article.Description,
                    CoverImg = article.CoverImg,

                };
                _articleService.CreateArticle(article);
                string uploads = Path.Combine(_env.WebRootPath, "images");

                if(article.CoverImg != null)
                {
                    string FilePath = Path.ChangeExtension(Path.Combine(uploads, article.Id.ToString()), "jpg");
                    using (var FileStream = new FileStream(FilePath, FileMode.Create))
                    {
                        article.CoverImg.CopyTo(FileStream);
                    }
                }

                return RedirectToAction("Index");
            }
            return View(article);
   
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
