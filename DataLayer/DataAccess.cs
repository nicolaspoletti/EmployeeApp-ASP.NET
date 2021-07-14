using EfficientEnergyEmployees.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace EfficientEnergyEmployees.DataLayer
{
    public class DataAccess
    {
        private readonly string connectionString;

        public DataAccess()
        {
            connectionString = ConfigurationManager.ConnectionStrings["EfficentEnergyConnectionString"].ConnectionString;
        }

        // User ----------------------------------------------------------------------------------------------
        public List<User>GetUsers()
        {
            List<User> listUsers = new List<User>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string strSQL = "SELECT * FROM [dbo].[User];";
                    SqlCommand cmd = new SqlCommand(strSQL, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        User user = new User();

                        user.userID = Convert.ToInt32(reader["userID"]);
                        user.userName = reader["userName"].ToString();
                        user.userPw = Encryption.Encryption.Decrypt(reader["userPw"].ToString());

                        listUsers.Add(user);
                    }
                }
            }
            catch(Exception ex)
            {
                System.Diagnostics.Trace.WriteLine("GetUsers() - Exception " + ex.Message);
            }
            return listUsers;
        }
        public void InsertUser(string userName, string userPw, string userType)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string strSQL = "INSERT INTO [User] (userName, userPw, userType) VALUES(@userName, @userPw, @userType); ";
                    SqlCommand comm = new SqlCommand(strSQL, conn);

                    comm.Parameters.Clear();
                    comm.Parameters.AddWithValue("@userName", userName);
                    comm.Parameters.AddWithValue("@userPw", Encryption.Encryption.Encrypt(userPw));
                    //if (String.IsNullOrEmpty(userPw)) comm.Parameters.AddWithValue("@userPw", strPass);
                    //else comm.Parameters.AddWithValue("@userPw", "");
                    comm.Parameters.AddWithValue("@userType", userType);

                    comm.ExecuteNonQuery();

                    comm.Dispose();
                    conn.Close();
                }
            }
            catch(Exception e)
            {
                System.Diagnostics.Trace.WriteLine("GetUsers() - Exception: " + e.Message);
            }
        }
        public void DeleteUser(int userID)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string strSql = "DELETE FROM [dbo].[User] WHERE userID = @userID;";
                SqlCommand cmd = new SqlCommand(strSql, conn);

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@userID", userID);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                System.Diagnostics.Trace.WriteLine("DeleteUser() - Exception:" + ex.Message);
            }
        }

        // Managers ------------------------------------------------------------------------------------------
        public List<Manager> GetManagers()
        {
            List<Manager> listManagers = new List<Manager>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string strSQL = "SELECT * FROM Manager;";
                    SqlCommand cmd = new SqlCommand(strSQL, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Manager man = new Manager();

                        man.manID = Convert.ToInt32(reader["manID"]);
                        man.manFirst = reader["manFirst"].ToString();
                        man.manLast = reader["manLast"].ToString();
                        man.manDOB = Convert.ToDateTime(reader["manDOB"]);
                        man.manPhoneNo = reader["manPhoneNo"].ToString();
                        man.manSalary = Convert.ToDouble(reader["manSalary"]);

                        listManagers.Add(man);
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine("GetManagers() - Exception: " + ex.Message);
            }
            return listManagers;
        }
        public void InsertManager(int manID, string manFirst, string manLast, DateTime? manDOB, string manPhoneNo, double manSalary)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    DateTime? nullDate = null;
                    conn.Open();
                    string strSQL = "INSERT INTO [dbo].[Manager] (manID, manFirst, manLast, manDOB, manPhoneNo, manSalary)";
                    strSQL += " VALUES(@manID, @manFirst, @manLast, @manDOB, @manPhoneNo, @manSalary)";

                    SqlCommand comm = new SqlCommand(strSQL, conn);
                    comm.Parameters.Clear();

                    comm.Parameters.AddWithValue("@manID", manID);
                    comm.Parameters.AddWithValue("@manFirst", !String.IsNullOrEmpty(manFirst) ? manFirst.Trim() : "");
                    comm.Parameters.AddWithValue("@manLast", !String.IsNullOrEmpty(manLast) ? manLast.Trim() : "");
                    comm.Parameters.AddWithValue("@manDOB", manDOB.HasValue ? Convert.ToDateTime(manDOB) : nullDate);
                    comm.Parameters.AddWithValue("@manSalary", manSalary);
                    comm.Parameters.AddWithValue("@manPhoneNo", manPhoneNo);

                    comm.ExecuteNonQuery();

                    comm.Dispose();
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Trace.WriteLine("InsertManager() - Exception: " + e.Message);
            }
        }

        // Departments ---------------------------------------------------------------------------------------
        public List<Department> GetDepartments()
        {
            List<Department> listDepartments = new List<Department>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string strSQL = "SELECT * FROM Department;";
                    SqlCommand cmd = new SqlCommand(strSQL, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Department dept = new Department();

                        dept.deptID = Convert.ToInt32(reader["deptID"]);
                        dept.deptName = reader["deptName"].ToString();
                        dept.deptAddress = reader["deptAddress"].ToString();
                        dept.manID = Convert.ToInt32(reader["manID"]);

                        listDepartments.Add(dept);
                    }

                    conn.Close();
                }
            }
            catch(Exception ex)
            {
                System.Diagnostics.Trace.WriteLine("Exception - " + ex.Message);
            }
            return listDepartments;
        }
        public void InsertDepartment(int deptID, string deptName, string deptAddress, int manID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string strSQL = "INSERT INTO [Department] ([deptID], [deptName], [deptAddress], [manID]) VALUES (@deptID, @deptName, @deptAddress, @manID)";

                    SqlCommand comm = new SqlCommand(strSQL, conn);

                    comm.Parameters.Clear();
                    comm.Parameters.AddWithValue("@deptID", deptID);
                    comm.Parameters.AddWithValue("@deptName", deptName);
                    comm.Parameters.AddWithValue("@deptAddress", deptAddress);
                    comm.Parameters.AddWithValue("@manID", manID);

                    comm.ExecuteNonQuery();

                    comm.Dispose();
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Trace.WriteLine("Exception - " + e.Message);
            }
        }

        // Employees -----------------------------------------------------------------------------------------
        public List<Employee> GetEmployees()
        {
            List<Employee> listEmployee = new List<Employee>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string strSQL = "SELECT * FROM Employee INNER JOIN Department ON Employee.deptID = Department.deptID;";

                    SqlCommand cmd = new SqlCommand(strSQL, conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    DateTime? nullDate = null;

                    while (reader.Read())
                    {
                        Employee emp = new Employee();

                        emp.empID = Convert.ToInt32(reader["empID"]);
                        emp.empFirst = (reader != null && reader["empFirst"] != null && !String.IsNullOrEmpty(reader["empFirst"].ToString())) ? reader["empFirst"].ToString() : null;
                        emp.empLast = (reader != null && reader["empLast"] != null && !String.IsNullOrEmpty(reader["empLast"].ToString())) ? reader["empLast"].ToString() : null;
                        emp.empAddress = (reader != null && reader["empAddress"] != null && !String.IsNullOrEmpty(reader["empAddress"].ToString())) ? reader["empAddress"].ToString() : null;
                        emp.empType = (reader != null && reader["empType"] != null && !String.IsNullOrEmpty(reader["empType"].ToString())) ? reader["empType"].ToString() : null;
                        emp.empPhoneNo = (reader != null && reader["empPhoneNo"] != null && !String.IsNullOrEmpty(reader["empPhoneNo"].ToString())) ? reader["empPhoneNo"].ToString() : null;
                        emp.empSalary = (reader != null && reader["empSalary"] != null) ? Convert.ToDouble(reader["empSalary"]) : 0;
                        emp.empDOB = (DateTime)((reader != null && null != reader["empDOB"]) ? Convert.ToDateTime(reader["empDOB"]) : nullDate);//Convert.ToDateTime("1900-01-01"));
                        emp.deptID = Convert.ToInt32(reader["deptID"]);

                        listEmployee.Add(emp);
                    }

                    conn.Close();
                }
            }
            catch(Exception ex)
            {
                System.Diagnostics.Trace.WriteLine("Exception - " + ex.Message);
            }
            return listEmployee;
        }

        public void InsertEmployee(int empID, string empFirst, string empLast, DateTime empDOB, string empAddress,
            string empType, string empPhoneNo, double empSalary, int deptID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string strSQL = "INSERT INTO [dbo].[Employee] " +
                        "([empID],[empFirst],[empLast],[empDOB],[empAddress],[empType],[empPhoneNo],[empSalary],[deptID]) " +
                        " VALUES (@empID, @empFirst, @empLast, @empDOB, @empAddress, @empType, @empPhoneNo, @empSalary, @deptID)";

                    SqlCommand comm = new SqlCommand(strSQL, conn);

                    comm.Parameters.Clear();

                    comm.Parameters.AddWithValue("@empID", empID);
                    comm.Parameters.AddWithValue("@empFirst", empFirst);
                    comm.Parameters.AddWithValue("@empLast", empLast);
                    comm.Parameters.AddWithValue("@empDOB", empDOB);
                    comm.Parameters.AddWithValue("@empAddress", empAddress);
                    comm.Parameters.AddWithValue("@empType", empType);
                    comm.Parameters.AddWithValue("@empPhoneNo", empPhoneNo);
                    comm.Parameters.AddWithValue("@empSalary", empSalary);
                    comm.Parameters.AddWithValue("@deptID", deptID);

                    comm.ExecuteNonQuery();

                    comm.Dispose();
                    conn.Close();
                }
            }
            catch(Exception ex)
            {
                System.Diagnostics.Trace.WriteLine("Exception - " + ex.Message);
            }
        }
    }
}