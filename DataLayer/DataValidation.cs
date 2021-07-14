using EfficientEnergyEmployees.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace EfficientEnergyEmployees.DataLayer
{
    public class DataValidation
    {
        private readonly string connectionString;

        public DataValidation()
        {
            connectionString = ConfigurationManager.ConnectionStrings["EfficentEnergyConnectionString"].ConnectionString;
        }

        // If there is a Row, then return false
        public bool ValidateEmpID(int empID)
        {
            bool isValid = true;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }               
                    string strSQL = "SELECT * FROM [dbo].[Employee] WHERE [empID] = @empID;";

                    SqlCommand cmd = new SqlCommand(strSQL, conn);

                    cmd.Parameters.AddWithValue("@empID", empID);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if(reader.HasRows == true)
                    {
                        isValid = false;
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine("ValidateUser - Exception " + ex.Message);
            }
            System.Diagnostics.Debug.WriteLine("Validate EmpID: " + isValid);
            return isValid;
        }
        public bool ValidateEmpName(string empName)
        {
            var regexItem = new Regex("^[a-zA-Z]+$");
            bool isValid = true;

            if (empName.Length >= 15)
            {
                isValid = false;
            }
            if(!regexItem.IsMatch(empName))
            {
                isValid = false;
            }
            
            System.Diagnostics.Debug.WriteLine("Validate empName: " + isValid);
            return isValid;
        }
        public bool ValidateEmpLast(string empLast)
        {
            var regexItem = new Regex("^[a-zA-Z]+$");
            bool isValid = true;

            if (empLast.Length >= 15)
            {
                isValid = false;
            }
            if (!regexItem.IsMatch(empLast))
            {
                isValid = false;
            }

            System.Diagnostics.Debug.WriteLine("Validate empLast: " + isValid);
            return isValid;
        }
        public bool ValidateEmpDOB(string empDOB)
        {
            bool isValid = true;

            var regexItem = new Regex("^\\d{4}\\-(0?[1-9]|1[012])\\-(0?[1-9]|[12][0-9]|3[01])$");

            if(!regexItem.IsMatch(empDOB))
            {
                isValid = false;
            }
            return isValid;
        }
        public bool ValidateEmpAddress(string empAddress)
        {
            var regexItem = new Regex("^[A-Za-z0-9 _]*[A-Za-z0-9][A-Za-z0-9 _]*$");
            bool isValid = true;

            if (empAddress.Length >= 50)
            {
                isValid = false;
            }
            if (!regexItem.IsMatch(empAddress))
            {
                isValid = false;
            }

            System.Diagnostics.Debug.WriteLine("Validate empAddress: " + isValid);
            return isValid;
        }
        public bool ValidateEmpSalary(string empSalary)
        {
            var regexItem = new Regex("^[0-9]*$");
            bool isValid = true;

            if (empSalary.Length <= 0)
            {
                isValid = false;
            }
            if (!regexItem.IsMatch(empSalary))
            {
                isValid = false;
            }

            System.Diagnostics.Debug.WriteLine("Validate empSalary: " + isValid);
            return isValid;
        }
        public bool ValidateEmpDeptID(string deptID)
        {
            bool isValid = true;
            var regexItem = new Regex("^[0-9]*$");

            if (!regexItem.IsMatch(deptID))
            {
                isValid = false;
                System.Diagnostics.Debug.WriteLine("0 - ValidateDeptID on Regex: " + isValid);
            }
            else
            {
                Convert.ToInt32(deptID);
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        if (conn.State == System.Data.ConnectionState.Closed)
                        {
                            conn.Open();
                        }
                        string strSQL = "SELECT * FROM [dbo].[Department] WHERE [deptID] = @deptID;";

                        SqlCommand cmd = new SqlCommand(strSQL, conn);

                        cmd.Parameters.AddWithValue("@deptID", deptID);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows == false)
                        {
                            isValid = false;
                        }

                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Trace.WriteLine("ValidateDeptID on Employee: - Exception " + ex.Message);
                }
                System.Diagnostics.Debug.WriteLine("1 - ValidateDeptID on Employee: " + isValid);
            }
            System.Diagnostics.Debug.WriteLine("2 - ValidateDeptID on Employee: " + isValid);
            return isValid;
        }
    }

}