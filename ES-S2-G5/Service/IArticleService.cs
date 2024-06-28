using ES_S2_G5.Entity;

namespace ES_S2_G5.Service
{
    public interface IArticleService<Articolo>
    {
        IEnumerable<Article> GetArticles();


        void CreateArticle(Article article);

        void DeleteArticle(int id);

        public Article GetById(int id);

    }
}
