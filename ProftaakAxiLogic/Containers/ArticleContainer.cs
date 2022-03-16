using System.Collections.Generic;
using ProftaakAXI.Classes;

namespace ProftaakAXI.Containers
{
    public class ArticleContainer
    {
        private List<Article> _articles;

        public ArticleContainer(List<Article> articles)
        {
            _articles = articles;
        }

        public IReadOnlyCollection<Article> GetArticles()
        {
            return _articles;
        }
        
        public void CreateArticle(string name, Category category, string barcode, double price, string img)
        {
            var article = new Article();
            article.SetCategory(category);
            article.SetName(name);
            article.SetBarCode(barcode);
            article.SetPrice(price);
            article.SetImg(img);
           // var response = Toolbox.QueryHandler.InsertStr(Data.Table.Article, List<s> )
            _articles.Add(article);
            var id = 0; //todo replace this placeholder with id from database response
        }

        public void RemoveArticle(Article article)
        {
            _articles.Remove(article);
        }
        
    }
}