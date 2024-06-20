using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace MyFirstWebAPI.Controllers
{
    // ../api/Home
    public class HomeController : ApiController
    {
        private string[] S = { "apple", "Banana", "Orange" };
        public string[] Get()
        {
            return S;
        }
        // ...api/Home/{id}
        public string Get(int id)
        {
            return S[id];
        }
    }
}