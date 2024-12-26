using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjcetMangement
{
    public partial class ProjectAll : System.Web.UI.Page
    {
        public int UserId { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            clsProjectManagement objAllrecordAdminPage = new clsProjectManagement();
            DataTable dt = new DataTable();
            dt = objAllrecordAdminPage.AllrecordAdminPage();
            grdAllRecord.DataSource = dt;
            grdAllRecord.DataBind();

            if (Session["UserId3"] != null)
            {
                UserId = Convert.ToInt32(Session["UserId3"]);
            }
        }

        protected void grdAllRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }
    }
}