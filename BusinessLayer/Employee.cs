using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EfficientEnergyEmployees.BusinessLayer
{
    public class Employee
    {
        public int empID;
        public string empFirst;
        public string empLast;
        public DateTime empDOB;
        public string empAddress;
        public string empType;
        public string empPhoneNo;
        public double empSalary;
        public int deptID;

        public EfficientEnergyEmployees.DataLayer.DataAccess da;
        public EfficientEnergyEmployees.DataLayer.DataValidation dv;

        public Employee()
        {
            da = new DataLayer.DataAccess();
            dv = new DataLayer.DataValidation();
        }

        public List<Employee> GetEmployees()
        {
            return da.GetEmployees();
        }

        public void InsertEmployee( int empID, string empFirst, string empLast, DateTime empDOB, string empAddress,
            string empType, string empPhoneNo, double empSalary, int deptID)
        {
            da.InsertEmployee(empID, empFirst, empLast, empDOB, empAddress,
            empType, empPhoneNo, empSalary, deptID);
        }

        public bool ValidateEmpID(int empID)
        {
            return dv.ValidateEmpID(empID);
        }
        public bool ValidateEmpName(string empName)
        {
            return dv.ValidateEmpName(empName);
        }
        public bool ValidateEmpLast(string empLast)
        {
            return dv.ValidateEmpLast(empLast);
        }
        public bool ValidateEmpDOB(string empDOB)
        {
            return dv.ValidateEmpDOB(empDOB);
        }
        public bool ValidateEmpAddress(string empAddress)
        {
            return dv.ValidateEmpAddress(empAddress);
        }
        public bool ValidateEmpSalary(string empSalary)
        {
            return dv.ValidateEmpSalary(empSalary);
        }
        public bool ValidateEmpDeptID(string deptID)
        {
            return dv.ValidateEmpDeptID(deptID);
        }
    }
}