using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjcetMangement
{
    public partial class AssignProject : System.Web.UI.Page
    {
        private object e;

        public object Assign { get; private set; }

        public int RegistrationIdAd { get; set; }   
        public int ProjectId { get; set; }  

        public int RegistrationId { get; set; } 

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                {
                fetchManager();
                AllrecordAdminPage();
                chkSelect_CheckedChanged(sender,e);
                cmbbxProjectManager_SelectedIndexChanged(sender,e);
                //AddCheckBoxColumn();


            }
            if (Session["UserId3"] != null)
            {
                RegistrationIdAd = Convert.ToInt32(Session["UserId3"]);
            }
        }

        //private void AddCheckBoxColumn()
        //{
        //    TemplateField checkboxField = new TemplateField();
        //    checkboxField.HeaderText = "Select";
        //    checkboxField.ItemTemplate = new CheckBoxTemplate();

        //    grdAsign.Columns.Add(checkboxField);
        //}

        public class CheckBoxTemplate : ITemplate
        {
            public void InstantiateIn(Control container)
            {
                CheckBox chk = new CheckBox();
                chk.ID = "chkSelect";
                container.Controls.Add(chk);
            }
        }
        public void fetchManager()
        { 
            clsProjectManagement fetchproject = new clsProjectManagement();
            DataTable dt2 = new DataTable();
            dt2 = fetchproject.fetchManager();
            cmbbxProjectManager.DataSource = dt2;
            cmbbxProjectManager.DataTextField = "Name";
            cmbbxProjectManager.DataValueField = "RegistrationId";
            cmbbxProjectManager.DataBind();
        
          }

        public void AllrecordAdminPage()
        {
        clsProjectManagement objAllrecordAdminPage = new clsProjectManagement();
        DataTable dt = new DataTable();
        dt = objAllrecordAdminPage.AllrecordAdminPage();
        grdAsign.DataSource = dt;
        grdAsign.DataBind();

        }


        //protected void btnAssign_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(cmbbxProjectManager.SelectedValue))
        //    {
        //        Response.Write("<script>alert('Please select a Project Manager!');</script>");
        //        return;
        //    }

        //    bool isAnyProjectSelected = false;
        //    clsProjectManagement Assign = new clsProjectManagement();
        //    int registrationId = Convert.ToInt32(cmbbxProjectManager.SelectedValue);
        //    int RegistrationIdAd = GetRegistrationIdAd(); 

        //    foreach (GridViewRow row in grdAsign.Rows)
        //    {
        //        CheckBox chk = (CheckBox)row.FindControl("chkSelect");
        //        if (chk != null && chk.Checked)
        //        {
              
        //            isAnyProjectSelected = true;

        //            string ProjectId = row.Cells[1].Text;

     
        //            Assign.AssignToManager(registrationId, Convert.ToInt32(ProjectId), RegistrationIdAd);

                  
          
        //        }
        //    }

        //    if (!isAnyProjectSelected)
        //    {
        //        Response.Write("<script>alert('Please select at least one project to assign!');</script>");
        //    }
        //    else
        //    {
                
        //        BindGridView(); 
        //        Response.Write("<script>alert('Project Manager Assigned Successfully');</script>");
        //    }


        //    void BindGridView()
        //    {
           
        //        grdAsign.DataBind();
        //    }

         


        //}

        protected void btnAssign_Click(object sender, EventArgs e)
        {

            clsProjectManagement Assign = new clsProjectManagement();
            foreach (GridViewRow row in grdAsign.Rows)
            {
                CheckBox chk = (CheckBox)row.FindControl("chkSelect");
                if (chk != null && chk.Checked)
                {

                    string ProjectId = row.Cells[1].Text;
                    string RegistrationId = cmbbxProjectManager.SelectedValue.ToString();


                    Assign.AssignToManager(Convert.ToInt32(RegistrationId), Convert.ToInt32(ProjectId), RegistrationIdAd);
                    Response.Write("<script>alert('Project Manager Leader Assigned Successfully')</script>");
                }

            }
        }





        protected void chkAll_CheckedChanged(object sender, EventArgs e)
            {
               
            
            }
         
        protected void chkSelect_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        protected void cmbbxProjectManager_SelectedIndexChanged(object sender, EventArgs e)
        {

            clsProjectManagement obj = new clsProjectManagement();
            int RegistrationId = Convert.ToInt32(cmbbxProjectManager.SelectedValue.ToString());

            DataTable dt = obj.fetchManagerDetails(RegistrationId);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                lblEmail.Text = row["Email"].ToString();
                lblPhone.Text = row["Phone"].ToString();
            }
            else
            {
                lblEmail.Text = "No Data Found";
                lblPhone.Text = "No Data Found";
            }

        }
    }
    }
    






