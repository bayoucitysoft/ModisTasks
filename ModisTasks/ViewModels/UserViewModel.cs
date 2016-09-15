using ModisTasks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModisTasks.ViewModels
{
    public class UserViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }

        public UserViewModel()
        {

        }

        public UserViewModel(UserModel model)
        {
            FirstName = model.FirstName;
            LastName = model.LastName;
            FullName = FirstName + " " + LastName;
        }
    }
}