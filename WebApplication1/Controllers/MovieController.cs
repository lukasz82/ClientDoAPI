using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MovieController : Controller
    {
        string baseUrl = "https://localhost:44326";
        HttpClient hc = new HttpClient();

        void setHC()
        {
            hc.BaseAddress = new Uri(baseUrl);
            hc.DefaultRequestHeaders.Clear();
            hc.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        //[HttpGet("/Movie")]
        //public async Task<IActionResult> Index()
        //{
        //    setHC();
        //    List<Movie> Filmy = new List<Movie>();
        //    HttpResponseMessage response = null;
        //    response = await hc.GetAsync("api/Movies");

        //    if (response.IsSuccessStatusCode)
        //    {
        //        var movies = response.Content.ReadAsStringAsync().Result;
        //        Filmy = JsonConvert.DeserializeObject<List<Movie>>(movies);
        //    }

        //    return View(Filmy);
        //}



        [HttpGet("/Movie/{MovieId?}")]
        public async Task<IActionResult> Index(int MovieId = 0) // MovieId = 0 to nie jest przypisanie, tylko sprawdzenie czy przekazano parametr, jeśli nie to dopiero przypisuje 0
        {
            Movie Film = new Movie();
            List<Movie> Filmy = new List<Movie>();

            setHC();
            
            HttpResponseMessage response = null;

            if (MovieId == 0)
            {
                response = await hc.GetAsync("api/Movies");
                if (response.IsSuccessStatusCode)
                {
                    var movies = response.Content.ReadAsStringAsync().Result;
                    Filmy = JsonConvert.DeserializeObject<List<Movie>>(movies);
                }
                return View(Filmy);
            }

            if (MovieId > 0)
            {
                response = await hc.GetAsync("api/Movies/" + MovieId);
                if (response.IsSuccessStatusCode)
                {
                    var movie = response.Content.ReadAsStringAsync().Result;
                    Film = JsonConvert.DeserializeObject<Movie>(movie);
                }
                return View("OneMovieView", Film);
            }
            return View();
        }
    }
}