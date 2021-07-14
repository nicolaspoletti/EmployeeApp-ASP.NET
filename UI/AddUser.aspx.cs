using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EfficientEnergyEmployees.UI
{
    public partial class AddUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void IDC_btn_User_Add_Click(object sender, EventArgs e)
        {
            new EfficientEnergyEmployees.BusinessLayer.User().InsertUser(IDC_txtUserName.Text.Trim(), IDC_txtUserPw.Text.Trim(), IDC_radAdmin.Checked? "admin" : "user");
            Page.ClientScript.RegisterStartupScript(
            this.GetType(), "OpenWindow", "window.open('./User.aspx','_blanc');", true);
        }
    }
}