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

        public HomeController(ILogger<HomeController> logger, IArticleService<Article> articleService, IWebHostEnvironment env)
        {
            _logger = logger;
            _articleService = articleService;
            _env = env;
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
            if (ModelState.IsValid) 
            {
                var art = new Article
                {
                    Description = article.Description,
                    Name = article.Name,
                    Price = article.Price,
                    CoverImg = article.CoverImg,
                    ImgProduct = article.ImgProduct,
                    ImgProduct2 = article.ImgProduct2
                };
                _articleService.CreateArticle(art);
                string uploads = Path.Combine(_env.WebRootPath, "immagini");
                if (article.CoverImg != null)
                {
                    string filePath = Path.ChangeExtension(Path.Combine(uploads, article.Id.ToString()), "jpg");
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        article.CoverImg.CopyTo(fileStream);
                    }
                }
                if (article.ImgProduct != null)
                {
                    string filePath = Path.ChangeExtension(Path.Combine(uploads, article.Id.ToString() + "1"), "jpg");
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        article.ImgProduct.CopyTo(fileStream);
                    }
                }
                if (article.ImgProduct2 != null)
                {
                    string filePath = Path.ChangeExtension(Path.Combine(uploads, article.Id.ToString() + "2"), "jpg");
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        article.ImgProduct2.CopyTo(fileStream);
                    }
                }
                return RedirectToAction(nameof(Dettagli));
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
