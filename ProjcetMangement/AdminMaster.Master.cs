using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectManagement
{
    public partial class AdminMaster : System.Web.UI.MasterPage
    {
        public int EmpId { get;  set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserId3"] != null)
            {
                EmpId = Convert.ToInt32(Session["UserId3"]);
            }
        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {

        }
    }
}