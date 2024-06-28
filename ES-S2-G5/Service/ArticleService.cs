using ES_S2_G5.Entity;
using System.Collections.Generic;

namespace ES_S2_G5.Service
{
    public class ArticleService : IArticleService<Article>
    {
        // Lista statica di articoli
        protected static readonly List<Article> articles = new List<Article>();
        // Ultimo ID assegnato agli articoli
        private static int lastid = 0;

        // Metodo per creare un nuovo articolo
        public void CreateArticle(Article article)
        {
            // Assegna un nuovo ID all'articolo
            article.Id = lastid++;
            // Imposta il flag IsCreated a true
            article.IsCreated = true;
            // Aggiunge l'articolo alla lista
            articles.Add(article);
        }

        // Metodo per eliminare un articolo dato l'ID
        public void DeleteArticle(int id)
        {
            // Cerca l'articolo nella lista tramite l'ID
            var article = articles.FirstOrDefault(x => x.Id == id);
            // Se l'articolo esiste, lo rimuove dalla lista
            if (article != null)
            {
                articles.Remove(article);
            }
        }

        // Metodo per ottenere tutti gli articoli
        public IEnumerable<Article> GetArticles()
        {
            return articles;
        }

        // Metodo per ottenere un articolo dato l'ID
        public Article GetById(int id)
        {
            return articles.SingleOrDefault(a => a.Id == id);
        }
    }
}
