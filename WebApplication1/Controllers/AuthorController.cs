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
    public class AuthorController : Controller
    {
        string baseUrl = "https://localhost:44326";
        HttpClient hc = new HttpClient();

        void setHC()
        {
            hc.BaseAddress = new Uri(baseUrl);
            hc.DefaultRequestHeaders.Clear();
            hc.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<IActionResult> Index()
        {
            setHC();
            List<Author> Autorzy = new List<Author>();
            HttpResponseMessage response = await hc.GetAsync("api/Authors");
            if (response.IsSuccessStatusCode)
            {
                var authors = response.Content.ReadAsStringAsync().Result;
                Autorzy = JsonConvert.DeserializeObject<List<Author>>(authors);
            }

            return View(Autorzy);
        }
    }
}