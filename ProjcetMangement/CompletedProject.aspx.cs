using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjcetMangement
{
    public partial class CompletedProject : System.Web.UI.Page
    {
        private string paid;

        public int RegistrationIdADC { get; set; }
        public string RegId { get; private set; }
        public string Email { get; private set; }
        public string Amt { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack) 
            {
                clsProjectManagement objCompleted = new clsProjectManagement();
                DataTable dt = new DataTable();
                dt = objCompleted.CompletedProject();
                grdAsign.DataSource = dt; 
                grdAsign.DataBind();
            }
            if (Session["UserId3"] != null)
            {
                RegistrationIdADC = Convert.ToInt32(Session["UserId3"]);
            }
        }


        //private void AddCheckBoxColumn()
        //{
        //    TemplateField checkboxField = new TemplateField();
        //    checkboxField.HeaderText = "Select";
        //    checkboxField.ItemTemplate = new Che ckBoxTemplate();

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

        protected void grdCompl_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

      
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void grdcompletedProject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void grdAsign_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
            

            protected void Button1_Click(object sender, EventArgs e)
            {
                clsProjectManagement Assign = new clsProjectManagement();
                foreach (GridViewRow row in grdAsign.Rows)
             
            {
                    CheckBox chk = (CheckBox)row.FindControl("chkSelect");

                    if (chk != null && chk.Checked)
                    {
                        string ProjectId = row.Cells[1].Text;
                        string Status = paid;
                        Assign.AssignPayment(RegistrationIdADC, Convert.ToInt32(ProjectId));
                        Response.Write("<script>alert('Payment Done Successfully');</script>");
            
                        Response.Redirect("MainLog.aspx?RegistrationId=" + RegistrationIdADC + "&Email=" + Email + "&Amt=" + Amt);
                        Response.Redirect("Payment.aspx");

                    {
                        Response.Write("<script>alert('Please select at least one project to proceed with the payment!');</script>");
                    }



                }
            }
        }

        }
        }



