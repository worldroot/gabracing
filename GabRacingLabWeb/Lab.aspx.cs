using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GabRacingLabWeb
{
    public partial class Lab : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == Settings.Password)
            {
                lblName.Text = Settings.StorageAccountName;
                lblKey.Text = Settings.StorageAccountKey;
            }
        }
    }
}