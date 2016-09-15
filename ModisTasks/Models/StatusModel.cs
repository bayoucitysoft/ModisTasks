using ModisTasks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModisTasks.Models
{
    public class StatusModel
    {
        public int StatusId { get; set; }
        public string Status { get; set; }

        public StatusModel()
        {

        }

        public StatusModel(int statusId, string status)
        {
            StatusId = statusId;
            Status = status; 
        }
    }

    public class StatusModelCollection : IModelCollection 
    {
        public List<StatusModel> Contents { get; set; }
        public StatusModelCollection()
        {
            //simulating a select * from Statuses
            Contents = new List<StatusModel>();
        }

        public void Generate()
        {
            Contents.Add(new StatusModel(0, "Received"));
            Contents.Add(new StatusModel(1, "Accessioning"));
            Contents.Add(new StatusModel(2, "In Lab"));
            Contents.Add(new StatusModel(3, "Report Generation"));   
        }
    }
}