using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using view_eye.Models;

namespace view_eye.Controllers
{
    public class AnswersController : Controller
    {
        // GET: Answers
        public ActionResult Index()
        {
            // 1-create instance of http client  //هوا المسئول على ارسال requst الى api وبيرجعلى  بresponse
            HttpClient client = new HttpClient();

            //2- Get url 
            client.BaseAddress = new Uri("http://localhost:59484");
            //3- declare the type of data xml/json
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            //4- Get data"
            HttpResponseMessage response = client.GetAsync("api/Answers").Result;
            var answers = response.Content.ReadAsAsync<IEnumerable<Answers>>().Result;
            return View(answers);
        }

        public ActionResult Details(int id)
        {
            // 1- send requst to api and recive response
            HttpClient client = new HttpClient();

            //2- get url
            client.BaseAddress = new Uri("http://localhost:59484");

            //3- declare the type of data xml/json
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            //4-get dat

            var url = "api/Answers" + id;

            HttpResponseMessage response = client.GetAsync(url).Result;
            var answer = response.Content.ReadAsAsync<Answers>().Result;
            return View(answer);

        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Answers answer)
        {
            // 1-create instance of http client  //هوا المسئول على ارسال requst الى api وبيرجعلى  بresponse
            HttpClient client = new HttpClient();

            //2- Get url 
            client.BaseAddress = new Uri("http://localhost:59484");
            //3- declare the type of data xml/json
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            //4- Get data"
            HttpResponseMessage response = client.PostAsJsonAsync("api/Answers", answer).Result;

            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            // 1- send requst to api and recive response
            HttpClient client = new HttpClient();

            //2- get url
            client.BaseAddress = new Uri("http://localhost:59484");

            //3- declare the type of data xml/json
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            //4-get dat

            var url = "api/Answers" + id;

            HttpResponseMessage response = client.GetAsync(url).Result;
            var answer = response.Content.ReadAsAsync<Answers>().Result;
            return View(answer);

        }
        [HttpPost]
        public ActionResult Edit(Answers answer)
        {
            // 1-create instance of http client  //هوا المسئول على ارسال requst الى api وبيرجعلى  بresponse
            HttpClient client = new HttpClient();

            //2- Get url 
            client.BaseAddress = new Uri("http://localhost:59484");
            //3- declare the type of data xml/json
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            //4- Get data"
            HttpResponseMessage response = client.PutAsJsonAsync("api/Answers", answer).Result;

            return RedirectToAction("Index");

        }
        public ActionResult Delete(int id)

        {
            //1- Declare client
            HttpClient client = new HttpClient();
            //2-Get Url
            client.BaseAddress = new Uri("http://localhost:59484");

            //3- declare xml or json
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.
                MediaTypeWithQualityHeaderValue("application/json"));

            var url = "api/Answers/" + id;

            //4- get data

            HttpResponseMessage response = client.DeleteAsync(url).Result;


            return RedirectToAction("Index");
        }
    }
}