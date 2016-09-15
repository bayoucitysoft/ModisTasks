using ModisTasks.Models;
using ModisTasks.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ModisTasks.Controllers
{
    public class StatusController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Index()
        {
            IHttpActionResult result = null;
            StatusModelCollection modelCollection = new StatusModelCollection();
            List<StatusViewModel> viewModelCollection = new List<StatusViewModel>();
            viewModelCollection.Add(new StatusViewModel("Select Status"));
            modelCollection.Generate();
            return result = Ok(modelCollection.Contents);
        }
    }
}
