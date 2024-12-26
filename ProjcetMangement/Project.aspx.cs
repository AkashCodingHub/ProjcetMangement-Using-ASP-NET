using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace ProjcetMangement
{
    public partial class Project1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TechnologyRegister();
            }
            //clsProjectManagement fetchTechnology = new clsProjectManagement();
            //DataTable dt = new DataTable();
            //dt = fetchTechnology.TechnologyRegister();
            //if (dt.Rows.Count < 0)
            //{

            //}
            //else
            //{
            //    drplstTech.DataSource = dt;
            //    drplstTech.DataTextField = "TechnologyName";
            //    drplstTech.DataValueField = "TechnologyId";
            //    drplstTech.DataBind();
            //}

        }

        public void TechnologyRegister()
        {
            clsProjectManagement fetchTechnology = new clsProjectManagement();
            DataTable dt = new DataTable();
            dt = fetchTechnology.TechnologyRegister();
            if (dt.Rows.Count < 0)
            {

            }
            else
            {
                drplstTech.DataSource = dt;
                drplstTech.DataTextField = "TechnologyName";
                drplstTech.DataValueField = "TechnologyId";
                drplstTech.DataBind();
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            clsProjectManagement obj = new clsProjectManagement();
           obj.TechnologyId = Convert.ToInt32(drplstTech.SelectedValue.ToString());
            obj.ProjectName = txtProjectName.Text;
            obj.StartDate = txtStartDate.Text;
            obj.EndDate = txtEndDate.Text;
            obj.ProjectRegister();
            Response.Write("<script>alert('Register Successfully...')</script>");
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtProjectName.Text = "";
            txtStartDate.Text = "";
            txtEndDate.Text = "";
            drplstTech.SelectedIndex = 0;
          
        }
    }
}