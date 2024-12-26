using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjcetMangement
{
    public partial class frmProjectManager : System.Web.UI.Page
    {
        public int RegistrationIdMA { get; set; }
        public int ProjectId { get;  set; }
        public int RegistrationId { get;  set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            clsProjectManagement objReceptionist = new clsProjectManagement();
            DataTable dt = new DataTable();
            if (!IsPostBack)
            {
                dt = objReceptionist.ProjectFetchToTeamLeader();
                cmbbxProject.DataTextField = "ProjectName";
                cmbbxProject.DataValueField = "ProjectId";
                cmbbxProject.DataSource = dt;
                cmbbxProject.DataBind();

                fetchTeamLeader();
          
                cmbbxTeamLeader_SelectedIndexChanged(sender, e);
            }

            if (Session["UserId1"] != null)
            {
                RegistrationIdMA = Convert.ToInt32(Session["UserId1"]);
            }        
    }

        public void fetchTeamLeader()
        {
            clsProjectManagement fetchproject = new clsProjectManagement();
            DataTable dt2 = new DataTable();
            dt2 = fetchproject.fetchTeamLeader();
            cmbbxTeamLeader.DataSource = dt2;
            cmbbxTeamLeader.DataTextField = "Name";
            cmbbxTeamLeader.DataValueField = "RegistrationId";
            cmbbxTeamLeader.DataBind();

        }

        protected void btnAssign_Click(object sender, EventArgs e)
        {
            clsProjectManagement Assign = new clsProjectManagement();
            if (cmbbxTeamLeader.SelectedValue != null && cmbbxProject.SelectedValue != null)
            {

                Assign.RegistrationId = Convert.ToInt32(cmbbxTeamLeader.SelectedValue.ToString());
                Assign.ProjectId = Convert.ToInt32(cmbbxProject.SelectedValue.ToString());
                Assign.Date = DateTime.Now;
                Assign.AssignToTeamLeader(RegistrationIdMA);

                Response.Write("<script>alert('Project Manager Leader Assigned Successfully')</script>");
            }
            else
            {
                Response.Write("<script>alert('Please select both Project and Team Leader.')</script>");
            }
           }


            protected void cmbbxTeamLeader_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void cmbbxProject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainLog.aspx");
        }
    }
}