using E_commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace E_commerce.Controllers
{
    public class HomeController : Controller
    {
        HttpClient client;
        public HomeController()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:12867/");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
        public ActionResult Index()
        {

            IEnumerable<Categorie> Categories;
            var response = client.GetAsync("api/CategorieService/action1").Result;
            Categories = response.Content.ReadAsAsync<IEnumerable<Categorie>>().Result;
            return View(Categories.ToList());
        }

        public ActionResult Contact()
        {
            return View("Contact");
        }

        public ActionResult About()
        {
            return View("About");
        }

        public ActionResult Mens()
        {
            IEnumerable<Article> Articles;
            var response = client.GetAsync("api/ArticleService/action1").Result;
            Articles = response.Content.ReadAsAsync<IEnumerable<Article>>().Result;
            return View(Articles.ToList());
        }

        public ActionResult GetArticles()
        {
            IEnumerable<Article> Articles;
            var response = client.GetAsync("api/ArticleService/action1").Result;
            Articles = response.Content.ReadAsAsync<IEnumerable<Article>>().Result;
            return View("Mens",Articles.ToList());
        }

        public ActionResult DetailsArticle(int? id)
        {
            Article Article;
            var response = client.GetAsync("api/ArticleService/action2?id=" + id).Result;
            Article = response.Content.ReadAsAsync<Article>().Result;
            return View("Mans",Article);
        }

        public ActionResult Womens()
        {
            return View("Womens");
        }

        public ActionResult Single()
        {
            return View("Single");
        }
    }
}