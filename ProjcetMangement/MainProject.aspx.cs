using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjcetMangement
{
    public partial class MainProject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TechnologyRegister();
                btnRegister_Click(sender, e);   
            }
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
            // Basic validation
            if (string.IsNullOrWhiteSpace(txtProjectName.Text) ||
                string.IsNullOrWhiteSpace(txtStartDate.Text) ||
                string.IsNullOrWhiteSpace(txtEndDate.Text) ||
                string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                Response.Write("<script>alert('All fields are required!');</script>");
                return;
            }

            // Date validation (ensure valid date format and logical date range)
            DateTime startDate, endDate;
            if (!DateTime.TryParse(txtStartDate.Text, out startDate))
            {
                Response.Write("<script>alert('Please enter a valid start date!');</script>");
                return;
            }

            if (!DateTime.TryParse(txtEndDate.Text, out endDate))
            {
                Response.Write("<script>alert('Please enter a valid end date!');</script>");
                return;
            }

            if (startDate > endDate)
            {
                Response.Write("<script>alert('Start date cannot be later than the end date!');</script>");
                return;
            }

            // Amount validation (must be a valid positive number)
            int amount;
            if (!int.TryParse(txtAmount.Text, out amount) || amount <= 0)
            {
                Response.Write("<script>alert('Please enter a valid amount greater than zero!');</script>");
                return;
            }

            // Create object and proceed with registration
            clsProjectManagement obj = new clsProjectManagement();
            obj.TechnologyId = Convert.ToInt32(drplstTech.SelectedValue.ToString());
            obj.ProjectName = txtProjectName.Text;
            obj.StartDate = startDate.ToString("yyyy-MM-dd");
            obj.EndDate = endDate.ToString("yyyy-MM-dd");
            obj.Amount = amount;

            // Registration logic
            obj.ProjectRegister();

            // Notify the user of successful registration
            Response.Write("<script>alert('Project Registered Successfully');</script>");
        }


        //protected void btnRegister_Click(object sender, EventArgs e)
        //{
        //    clsProjectManagement obj = new clsProjectManagement();
        //    obj.TechnologyId = Convert.ToInt32(drplstTech.SelectedValue.ToString());
        //    obj.ProjectName = txtProjectName.Text;
        //    obj.StartDate = txtStartDate.Text;
        //    obj.EndDate = txtEndDate.Text;
        //    obj.Amount = Convert.ToInt32(txtAmount.Text);
        //    obj.ProjectRegister();

        //    Response.Write("<script>alert('Register Successfully...')</script>");
        //}

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtProjectName.Text = "";
            txtStartDate.Text = "";
            txtEndDate.Text = "";
            drplstTech.SelectedIndex = 0;
        }
    }
} 