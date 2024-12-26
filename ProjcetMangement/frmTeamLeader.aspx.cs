using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjcetMangement
{
    public partial class frmTeamLeader : System.Web.UI.Page
    {
        private object frmLogin;

        public string StatusName { get; set; }
        public int ProjectId { get;  set; }
        public int RegistrationIdTA { get;  set; }

        public void iterations()
        {

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               // LoadProjectNames();
            }

            if (Session["UserId2"] != null)
            {
                RegistrationIdTA = Convert.ToInt32(Session["UserId2"]);
            }

            HandleIterationButtons();
        }

        private void HandleIterationButtons()
        {
           
            if (string.IsNullOrEmpty(StatusName))
            {
     
                btnIteration1.Enabled = false;
                btnIteration2.Enabled = false;
                btnIteration3.Enabled = false;
                return;
            }

            // Switch statement for handling different statuses
            switch (StatusName)
            {
                case "Assign":
                    btnIteration1.Enabled = true;
                    btnIteration2.Enabled = false;
                    btnIteration3.Enabled = false;
                    break;
                case "Iteration1":
                    lbl5.Visible = true;
                    btnIteration1.Enabled = false;
                    btnIteration2.Enabled = true;
                    btnIteration3.Enabled = false;
                    break;
                case "Iteration2":
                    lbl5.Visible = true;
                    lbl6.Visible = true;
                    btnIteration1.Enabled = false;
                    btnIteration2.Enabled = false;
                    btnIteration3.Enabled = true;
                    break;
                default:
                    lbl5.Visible = true;
                    lbl6.Visible = true;
                    lbl7.Visible = true;
                    btnIteration1.Enabled = false;
                    btnIteration2.Enabled = false;
                    btnIteration3.Enabled = false;
                    break;
            }
        }

        protected void btnIteration1_Click(object sender, EventArgs e)
        {
      
            if (ValidateIteration())
            {
                UpdateIterationStatus("Iteration1");
                lbl5.Visible = true;
                btnIteration2.Enabled = true;
                btnIteration1.Enabled = false;
                btnIteration3.Enabled = false;
            }
        }

        protected void btnIteration2_Click(object sender, EventArgs e)
        {
            if (ValidateIteration())
            {
                UpdateIterationStatus("Iteration2");
                lbl6.Visible = true;
                btnIteration2.Enabled = false;
                btnIteration3.Enabled = true;
                btnIteration1.Enabled = false;
            }
        }

        protected void btnIteration3_Click(object sender, EventArgs e)
        {
            if (ValidateIteration())
            {
                UpdateIterationStatus("Complete");
                lbl7.Visible = true;
                btnIteration2.Enabled = false;
                btnIteration3.Enabled = false;
                btnIteration1.Enabled = false;
            }
        }

        private bool ValidateIteration()
        {
           
            if (ProjectId == 0 || RegistrationIdTA == 0)
            {

                //lblError.Content = "Project ID or Registration ID is invalid.";
                //lblError.Visibility = Visibility.Visible;

            }
            return true;
        }

        private void UpdateIterationStatus(string status)
        {
       
            if (ValidateIteration())
            {
                clsProjectManagement cpy = new clsProjectManagement
                {
                    AssignId = RegistrationIdTA,
                    ProjectId = ProjectId,
                    Status = status,
                };
                cpy.UpdateIteration(RegistrationIdTA);
            }
        }

        //private void LoadProjectNames()
        //{
        //    clsProjectManagement objReceptionist = new clsProjectManagement();
        //    DataTable dt = objReceptionist.ProjectFetchToTeamLeader();

        //    cmbbxPrjName.DataTextField = "ProjectName";
        //    cmbbxPrjName.DataValueField = "ProjectId";
        //    cmbbxPrjName.DataSource = dt;
        //    cmbbxPrjName.DataBind();
        //}

        //private void HandleIterationButtons()
        //{

        //    if (string.IsNullOrEmpty(StatusName))
        //    {
        //        btnIteration1.Enabled = false;
        //        btnIteration2.Enabled = false;
        //        btnIteration3.Enabled = false;
        //        return;
        //    }

        //    switch (StatusName)
        //    {
        //        case "Assign":
        //            btnIteration1.Enabled = true;
        //            btnIteration2.Enabled = false;
        //            btnIteration3.Enabled = false;
        //            break;
        //        case "Iteration1":
        //            lbl5.Visible = true;
        //            btnIteration1.Enabled = false;
        //            btnIteration2.Enabled = true;
        //            btnIteration3.Enabled = false;
        //            break;
        //        case "Iteration2":
        //            lbl5.Visible = true;
        //            lbl6.Visible = true;
        //            btnIteration1.Enabled = false;
        //            btnIteration2.Enabled = false;
        //            btnIteration3.Enabled = true;
        //            break;
        //        default:
        //            lbl5.Visible = true;
        //            lbl6.Visible = true;
        //            lbl7.Visible = true;
        //            btnIteration1.Enabled = false;
        //            btnIteration2.Enabled = false;
        //            btnIteration3.Enabled = false;
        //            break;
        //    }
        //}

        //protected void btnIteration1_Click(object sender, EventArgs e)
        //{
        //    UpdateIterationStatus("Iteration1");
        //    lbl5.Visible = true;
        //    btnIteration2.Enabled = true;
        //    btnIteration1.Enabled = false;
        //    btnIteration3.Enabled = false;
        //}

        //protected void btnIteration2_Click(object sender, EventArgs e)
        //{
        //    UpdateIterationStatus("Iteration2");
        //    lbl6.Visible = true;
        //    btnIteration2.Enabled = false;
        //    btnIteration3.Enabled = true;
        //    btnIteration1.Enabled = false;
        //}

        //protected void btnIteration3_Click(object sender, EventArgs e)
        //{
        //    UpdateIterationStatus("Complete");
        //    lbl7.Visible = true;
        //    btnIteration2.Enabled = false;
        //    btnIteration3.Enabled = false;
        //    btnIteration1.Enabled = false;
        //}

        //private void UpdateIterationStatus(string status)
        //{

        //    if (ProjectId != 0 && RegistrationIdTA != 0)
        //    {
        //        clsProjectManagement cpy = new clsProjectManagement
        //        {
        //            AssignId = RegistrationIdTA,
        //            ProjectId = ProjectId,
        //            Status = status,
        //        };
        //        cpy.UpdateIteration(RegistrationIdTA);
        //    }
        //}
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    clsProjectManagement objReceptionist = new clsProjectManagement();
        //    DataTable dt = new DataTable();
        //    if (!IsPostBack)
        //    {
        //        dt = objReceptionist.ProjectFetchToTeamLeader();
        //        cmbbxPrjName.DataTextField = "ProjectName";
        //        cmbbxPrjName.DataValueField = "ProjectId";
        //        cmbbxPrjName.DataSourc  e = dt;
        //        cmbbxPrjName.DataBind();
        //    }

        //    if (Session["UserId2"] != null)
        //    {
        //        RegistrationIdTA = Convert.ToInt32(Session["UserId2"]);
        //    }




        //    if (StatusName.Equals("Assign"))
        //    {
        //        btnIteration1.Enabled = true;
        //        btnIteration2.Enabled = false;
        //        btnIteration3.Enabled = false;
        //    }
        //    else if (StatusName.Equals("Iteration1"))
        //    {
        //        lbl5.Visible = true;
        //        btnIteration1.Enabled = false;
        //        btnIteration2.Enabled = true;
        //        btnIteration3.Enabled = false;
        //    }
        //    else if (StatusName.Equals("Iteration2"))
        //    {
        //        lbl5.Visible = true;
        //        lbl6.Visible = true;
        //        btnIteration1.Enabled = false;
        //        btnIteration2.Enabled = false;

        //        btnIteration3.Enabled = true;
        //    }
        //    else
        //    {
        //        lbl5.Visible = true;
        //        lbl6.Visible = true;
        //        lbl7.Visible = true;
        //        btnIteration1.Enabled = false;
        //        btnIteration2.Enabled = false;
        //        btnIteration3.Enabled = false;
        //    }
        //}



        //protected void btnIteration1_Click(object sender, EventArgs e)
        //{
        //    lbl5.Visible = true;
        //    clsProjectManagement cpy = new clsProjectManagement();
        //    cpy.AssignId = RegistrationIdTA;
        //    cpy.ProjectId = ProjectId;
        //    cpy.Status = "Iteration1";
        //    clsProjectManagement cls = new clsProjectManagement(cpy);
        //    cls.UpdateIteration(RegistrationIdTA);
        //    btnIteration2.Enabled = true;
        //    btnIteration1.Enabled = false;
        //    btnIteration3.Enabled = false;
        //}

        //protected void btnIteration2_Click(object sender, EventArgs e)
        //{
        //    lbl6.Visible = true;
        //    clsProjectManagement cpy = new clsProjectManagement();
        //    cpy.AssignId = RegistrationIdTA;
        //    cpy.ProjectId = ProjectId;
        //    cpy.Status = "Iteration2";
        //    clsProjectManagement cls = new clsProjectManagement(cpy);
        //    cls.UpdateIteration(RegistrationIdTA);
        //    btnIteration2.Enabled = false;
        //    btnIteration3.Enabled = true;
        //    btnIteration1.Enabled = false;
        //}

        //protected void btnIteration3_Click(object sender, EventArgs e)
        //{
        //    lbl7.Visible = true;
        //    clsProjectManagement cpy = new clsProjectManagement();
        //    cpy.AssignId = RegistrationIdTA;
        //    cpy.ProjectId = ProjectId;
        //    cpy.Status = "Complete";
        //    clsProjectManagement cls = new clsProjectManagement(cpy);
        //    cls.UpdateIteration(RegistrationIdTA);
        //    btnIteration2.Enabled = false;
        //    btnIteration3.Enabled = false;
        //    btnIteration1.Enabled = false;
        //}

        protected void cmbbxPrjName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainLog.aspx");
        }
    }
}