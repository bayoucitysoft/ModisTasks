using ModisTasks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModisTasks.ViewModels
{
    public class StatusViewModel
    {
        public string Status { get; set; }

        public StatusViewModel()
        {
        }

        public StatusViewModel(string status)
        {
            Status = status;
        }

        public StatusViewModel(StatusModel model)
        {
            Status = model.Status; 
        }
    }
}