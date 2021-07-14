using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EfficientEnergyEmployees.BusinessLayer
{
    public class Manager
    {
        public int manID { get; set; }
        public string manFirst { get; set; }
        public string manLast { get; set; }
        public DateTime manDOB { get; set; }
        public string manPhoneNo { get; set; }
        public double manSalary { get; set; }

        public EfficientEnergyEmployees.DataLayer.DataAccess da;

        public Manager()
        {
            da = new DataLayer.DataAccess();
        }

        public List<Manager> GetManagers()
        {
            return da.GetManagers();
        }

        public void InsertManager(int manID, string manFirst, string manLast, DateTime? manDOB, string manPhoneNo, double manSalary)
        {
            da.InsertManager( manID,  manFirst,  manLast, manDOB,  manPhoneNo,  manSalary);
        }

    }
}