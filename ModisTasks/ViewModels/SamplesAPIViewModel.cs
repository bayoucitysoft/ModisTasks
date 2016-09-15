using ModisTasks.Interfaces;
using ModisTasks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModisTasks.ViewModels
{    
    public class SamplesAPIViewModel
    {
        public string Status { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Barcode { get; set; }
        public string CreatedAt { get; set; }

        public SamplesAPIViewModel()
        {
        }

        public SamplesAPIViewModel(SamplesModel sample, UserViewModel userViewModel, StatusViewModel statusViewModel)
        {
            Barcode = sample.Barcode.ToString();
            CreatedAt = sample.CreatedAt.ToString();
            Status = statusViewModel.Status;
            FirstName = userViewModel.FirstName;
            LastName = userViewModel.LastName;
        }

        public bool Validate()
        {
            long barcode = 0;
            if (string.IsNullOrEmpty(Barcode) | !long.TryParse(Barcode, out barcode))
                return false;
            if (string.IsNullOrEmpty(FirstName))
                return false;
            if (string.IsNullOrEmpty(LastName))
                return false;
            if (string.IsNullOrEmpty(Status))
                return false;
            return true;
        }
    }

    public class DatabaseContext : IModelCollection
    {
        public List<SamplesAPIViewModel> Contents { get; set; }

        public DatabaseContext()
        {
            Contents = new List<SamplesAPIViewModel>();
        }

        /// <summary>
        /// I would create a database view along the lines of 
        /// </summary>
        /// <returns></returns>
        public void Generate()
        {
            StatusModelCollection statusesRaw = new StatusModelCollection();
            statusesRaw.Generate();
            UserModelCollection usersRaw = new UserModelCollection();
            usersRaw.Generate();
            SamplesModelCollection samplesRaw = new SamplesModelCollection();
            samplesRaw.Generate();

            samplesRaw.Contents.ForEach(sample =>
            {
                StatusModel _status = statusesRaw.Contents.Where(status => status.StatusId == sample.StatusId).First();
                UserModel _user = usersRaw.Contents.Where(user => user.UserId == sample.CreatedBy).First();

                SamplesAPIViewModel temp = new SamplesAPIViewModel(sample, new UserViewModel(_user), new StatusViewModel(_status));
                Contents.Add(temp);
            });
        }
    }
}