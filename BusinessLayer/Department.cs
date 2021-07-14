using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EfficientEnergyEmployees.BusinessLayer
{
    public class Department
    {
        public int deptID;
        public string deptName;
        public string deptAddress;
        public int manID;

        public EfficientEnergyEmployees.DataLayer.DataAccess da;

        public Department()
        {
            da = new DataLayer.DataAccess();
        }

        public List<Department> GetDepartments()
        {
            return da.GetDepartments();
        }

        public void InsertDepartment(int deptID, string deptName, string deptAddress, int manID)
        {
            da.InsertDepartment(deptID, deptName, deptAddress, manID);
        }
    }
}