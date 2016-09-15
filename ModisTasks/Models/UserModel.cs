using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ModisTasks.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public UserModel(int userId, string firstName, string lastName)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
        }
    }

    public class UserModelCollection 
    {
        public List<UserModel> Contents { get; set; }

        public UserModelCollection()
        {
            Contents = new List<UserModel>(); 
        }

        public void Generate()
        {

            Contents.Add(new UserModel(0, "Kristine", "Butler"));
            Contents.Add(new UserModel(1, "Alfred", "McKenzie"));
            Contents.Add(new UserModel(2, "Cora", "Hunt"));
            Contents.Add(new UserModel(3, "Brad", "Huff"));
            Contents.Add(new UserModel(4, "Dewey", "McDonald"));
            Contents.Add(new UserModel(5, "Orlando", "Holt"));
            Contents.Add(new UserModel(6, "Clint", "Reid"));
            Contents.Add(new UserModel(7, "Kim", "Mullins"));
            Contents.Add(new UserModel(8, "Blanche", "Mack"));
            Contents.Add(new UserModel(9, "Dwayne", "Pena"));
        }
    }

}