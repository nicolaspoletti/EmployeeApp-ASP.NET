using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EfficientEnergyEmployees.UI
{
    public partial class Home : System.Web.UI.Page
    {
        readonly string strcon = ConfigurationManager.ConnectionStrings["EfficentEnergyConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("userPass: " + Encryption.Encryption.Decrypt("2Blra0CIRA3qNz4ecs4O5w=="));
            //this.IDC_btnLogin.Click += new System.EventHandler(this.IDC_btnLogin_Click);
        }

        protected void IDC_btnLogin_Click(object sender, EventArgs e)
        {
            string userType;
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed) con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM [User] WHERE userName='" + IDC_txtUserName.Text.Trim() + "' AND userPw='" + Encryption.Encryption.Encrypt(IDC_txtUserPw.Text.Trim()) + "';", con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        userType = dr.GetString(3).Trim();

                        System.Diagnostics.Debug.WriteLine("userPass: " + Encryption.Encryption.Decrypt("2Blra0CIRA3qNz4ecs4O5w=="));
                        System.Diagnostics.Debug.WriteLine("Login userType: " + dr.GetString(3).Trim());
                        System.Diagnostics.Debug.WriteLine("Login var userType: " + userType);

                        if (dr.GetString(3).Trim().Equals("admin"))
                        {
                            Response.Write("<script>alert('ADMIN Login accepted');</script>");
                            FormsAuthentication.RedirectFromLoginPage(IDC_txtUserName.Text, false);
                            Page.ClientScript.RegisterStartupScript(
                            this.GetType(), "OpenWindow", "window.open('./User.aspx','_blanc');", true);
                        }
                        else
                        {
                            Response.Write("<script>alert('USER Login accepted');</script>");
                            Page.ClientScript.RegisterStartupScript(
                            this.GetType(), "OpenWindow", "window.open('./Employee.aspx','_blanc');", true);
                        }
                    }
                }
                else
                {
                    Response.Write("<script>alert('LOGIN DENIED');</script>");
                    Page.ClientScript.RegisterStartupScript(
                    this.GetType(), "OpenWindow", "window.open('./Home.aspx','_blanc');", true);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}