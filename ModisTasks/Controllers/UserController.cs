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
    public class UsersController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Index()
        {
            IHttpActionResult response = null;
            UserModelCollection userModels = new UserModelCollection();
            userModels.Generate();
            List<UserViewModel> userViewModels = new List<UserViewModel>();
            userModels.Contents.ForEach(model =>
            {
                userViewModels.Add(new UserViewModel(model));
            });
            response = Ok(userViewModels);
            return response;
        }
    }
}
