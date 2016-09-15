using ModisTasks.Models;
using ModisTasks.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace ModisTasks.Controllers
{
    public class SamplesController : ApiController
    {   
        public DatabaseContext Database { get; set; }

        public SamplesController()
        {
            Database = new DatabaseContext();
            Database.Generate();
        }

        [HttpGet]
        public IHttpActionResult Index()
        {
            IHttpActionResult response = null;
            response = Ok(Database.Contents);
            return response;
        }

        [HttpPost]
        public IHttpActionResult Status(string status)
        {
            IHttpActionResult response = null;
            response = Ok(Database.Contents.Where(x => x.Status == status));
            return response;
        }

        [HttpPost]
        public IHttpActionResult Name(string name)
        {
            IHttpActionResult response = null;
            response = Ok(Database.Contents.Where(x => 
                (x.FirstName.Contains(name) | x.LastName.Contains(name))));
            return response;
        }

        [HttpPost]
        public IHttpActionResult Create(SamplesAPIViewModel input)
        {
            IHttpActionResult response = null;
            bool isValid = input.Validate();
            if (isValid)
            {
                Database.Contents.Add(input);
                response = Ok("Good job!");
            }
            else
                response = NotFound();

            return response;
        }
     }
}
