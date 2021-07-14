using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EfficientEnergyEmployees.UI
{
    public partial class AddEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void IDC_btnEmpAdd_Click(object sender, EventArgs e)
        {
            if (!new EfficientEnergyEmployees.BusinessLayer.Employee().ValidateEmpID(Convert.ToInt32(IDC_txtEmpID.Text.Trim())))
            {
                Response.Write("<script>alert('Invalid ID')</script>");
            }
            else if (!new EfficientEnergyEmployees.BusinessLayer.Employee().ValidateEmpName(IDC_txtEmpName.Text.Trim()))
            {
                Response.Write("<script>alert('Invalid NAME')</script>");
            }
            else if (!new EfficientEnergyEmployees.BusinessLayer.Employee().ValidateEmpLast(IDC_txtEmpLast.Text.Trim()))
            {
                Response.Write("<script>alert('Invalid LAST NAME')</script>");
            }
            else if (!new EfficientEnergyEmployees.BusinessLayer.Employee().ValidateEmpDOB(IDC_txtEmpDOB.Text.Trim()))
            {
                Response.Write("<script>alert('Invalid DOB')</script>");
            }
            else if (!new EfficientEnergyEmployees.BusinessLayer.Employee().ValidateEmpAddress(IDC_txtEmpAddress.Text.Trim()))
            {
                Response.Write("<script>alert('Invalid Address')</script>");
            }
            else if (!new EfficientEnergyEmployees.BusinessLayer.Employee().ValidateEmpSalary(IDC_txtEmpSalary.Text.Trim()))
            {
                Response.Write("<script>alert('Invalid salary')</script>");
            }
            else if (!new EfficientEnergyEmployees.BusinessLayer.Employee().ValidateEmpDeptID(IDC_txtEmpDeptID.Text.Trim()))
            {
                Response.Write("<script>alert('Invalid DEPARTMENT')</script>");
            }
            else
            {
                new EfficientEnergyEmployees.BusinessLayer.Employee().InsertEmployee(
                Convert.ToInt32(IDC_txtEmpID.Text.Trim()),
                IDC_txtEmpName.Text.Trim(),
                IDC_txtEmpLast.Text.Trim(),
                Convert.ToDateTime(IDC_txtEmpDOB.Text.Trim()),
                IDC_txtEmpAddress.Text.Trim(),
                IDC_radCasual.Checked? "Casual" : "Fulltime",
                IDC_txtEmpPhone.Text.Trim(),
                Convert.ToDouble(IDC_txtEmpSalary.Text.Trim()),
                Convert.ToInt32(IDC_txtEmpDeptID.Text.Trim())
                );
            }
        }

        public void IDC_txtEmpID_TextChanged(object sender, EventArgs e)
        {
            if (!new EfficientEnergyEmployees.BusinessLayer.Employee().ValidateEmpID(Convert.ToInt32(IDC_txtEmpID.Text.Trim())))
            {
                IDC_lblValidID.Text = "Existent ID, try again.";
            }
            else
            {
                IDC_lblValidID.Text = "";
            }
        }

        protected void IDC_txtEmpName_TextChanged(object sender, EventArgs e)
        {
            if (!new EfficientEnergyEmployees.BusinessLayer.Employee().ValidateEmpName((IDC_txtEmpName.Text.Trim())))
            {
                IDC_lblValidName.Text = "Name must contain only letters.";
            }
            else
            {
                IDC_lblValidName.Text = "";
            }
        }

        protected void IDC_txtEmpLast_TextChanged(object sender, EventArgs e)
        {
            if (!new EfficientEnergyEmployees.BusinessLayer.Employee().ValidateEmpLast((IDC_txtEmpLast.Text.Trim())))
            {
                IDC_lblValidSurname.Text = "Surname must contain only letters.";
            }
            else
            {
                IDC_lblValidSurname.Text = "";
            }
        }

        protected void IDC_txtEmpDOB_TextChanged(object sender, EventArgs e)
        {
            if (!new EfficientEnergyEmployees.BusinessLayer.Employee().ValidateEmpDOB(IDC_txtEmpDOB.Text.Trim()))
            {
                IDC_lblValidDOB.Text = "Invalid DOB, please use format dd-mm-yyyy";
            }
            else
            {
                IDC_lblValidDOB.Text = "";
            }
        }

        protected void IDC_txtEmpAddress_TextChanged(object sender, EventArgs e)
        {
            if (!new EfficientEnergyEmployees.BusinessLayer.Employee().ValidateEmpAddress(IDC_txtEmpAddress.Text.Trim()))
            {
                IDC_lblValidAddress.Text = "Invalid Address, no special characters.";
            }
            else
            {
                IDC_lblValidAddress.Text = "";
            }
        }

        protected void IDC_txtEmpSalary_TextChanged(object sender, EventArgs e)
        {
            if (!new EfficientEnergyEmployees.BusinessLayer.Employee().ValidateEmpSalary(IDC_txtEmpSalary.Text.Trim()))
            {
                IDC_lblValidSalary.Text = "Must constain only numbers";
            }
            else
            {
                IDC_lblValidSalary.Text = "";
            }
        }

        protected void IDC_txtEmpDeptID_TextChanged(object sender, EventArgs e)
        {
            if (!new EfficientEnergyEmployees.BusinessLayer.Employee().ValidateEmpDeptID(IDC_txtEmpDeptID.Text.Trim()))
            {
                IDC_lblValidDeptID.Text = "No department with that ID number.";
            }
            else
            {
                IDC_lblValidDeptID.Text = "";
            }
        }
    }
}