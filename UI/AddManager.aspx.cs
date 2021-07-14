using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EfficientEnergyEmployees.UI
{
    public partial class AddManager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void IDC_btnAddManager_Click(object sender, EventArgs e)
        {
            new EfficientEnergyEmployees.BusinessLayer.Manager().InsertManager(
                Convert.ToInt32(IDC_txtManID.Text),
                IDC_txtManFirst.Text,
                IDC_txtManLast.Text,
                Convert.ToDateTime(IDC_txtManDOB.Text),
                IDC_txtManPhone.Text,
                Convert.ToDouble(IDC_txtManSalary.Text)
                );
        }
    }
}