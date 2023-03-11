using Microsoft.AspNetCore.Mvc;
using MvcApiConsume.Models;
using RestSharp;

namespace MvcApiConsume.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            using (var client = new RestClient())
            {
                var request = new RestRequest("https://api.themoviedb.org/3/movie/popular?api_key=837fd3c1b9dffbbe7b69a4a979ab2fe3", Method.Get);
                var result = client.Get<MovieList>(request);

                return View(result.results);
            }
        }

        public IActionResult Detail(int id)
        {
            using (var client = new RestClient())
            {
                var detailRequest = new RestRequest($"https://api.themoviedb.org/3/movie/{id}?api_key=837fd3c1b9dffbbe7b69a4a979ab2fe3", Method.Get);
                var detailResult = client.Get<MovieDetail>(detailRequest);

                var castRequest = new RestRequest($"https://api.themoviedb.org/3/movie/{id}/credits?api_key=837fd3c1b9dffbbe7b69a4a979ab2fe3", Method.Get);
                var castResult = client.Get<CastList>(castRequest);

                detailResult.Cast = castResult.cast;

                return View(detailResult);
            }
        }
    }
}
