using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EfficientEnergyEmployees.UI
{
    public partial class AddDepartment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ICD_btnAddDept_Click(object sender, EventArgs e)
        {
            new EfficientEnergyEmployees.BusinessLayer.Department().InsertDepartment(
                Convert.ToInt32(ICD_txtDeptID.Text.Trim()),
                ICD_txtDeptName.Text.Trim(),
                ICD_txtDeptAddress.Text.Trim(),
                Convert.ToInt32(ICD_txtDeptManID.Text.Trim())
                );
        }
    }
}