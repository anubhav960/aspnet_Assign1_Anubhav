using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112Assign1.Controllers
{
    public class GreetingController : ApiController
    {
        //Response- api/Greeting

        public string Post()
        {

            return ("Hello World!");

        }


        // question no. 4

        //Response: api/Greeting/{id}

        public string Get(int id)
        {

            return ("Greetings to " + id.ToString() + " people!");

        }
    }
}
