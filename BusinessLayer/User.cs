using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EfficientEnergyEmployees.BusinessLayer
{
    public class User
    {
        public int userID { get; set; }
        public string userName { get; set; }
        public string userPw { get; set; }
        public string userType { get; set; }


        public EfficientEnergyEmployees.DataLayer.DataAccess da;
        public EfficientEnergyEmployees.DataLayer.DataValidation dv;


        public User()
        {
            da = new DataLayer.DataAccess();
        }

        public List<User> GetUsers()
        {
            return da.GetUsers();
        }

        public void InsertUser(string userName, string userPw, string userType)
        {
            da.InsertUser(userName, userPw, userType);
        }

        public void DeleteUser(int userID)
        {
            da.DeleteUser(userID);
        }
    }
}