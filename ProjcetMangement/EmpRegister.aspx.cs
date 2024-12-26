using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjcetMangement
{
    public partial class EmpRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowPositionAPB();
                FetchCountry();
                drplstCountry_SelectedIndexChanged(sender, e);
                btnRegister_Click(sender, e);
            }

        }
        public void ShowPositionAPB()
            {
                clsProjectManagement FetchPosition = new clsProjectManagement();
            DataTable dt1 = new DataTable();
            dt1 = FetchPosition.ShowPositionAPB();
            drplstPositon.DataSource = dt1;
            drplstPositon.DataTextField = "PositionName";
            drplstPositon.DataValueField = "PositionId";
            drplstPositon.DataBind();
            }

            public void FetchCountry()
            { 
            clsProjectManagement FetchCountry1 = new clsProjectManagement();
            DataTable dt = new DataTable();
            dt = FetchCountry1.FetchCountry();
            drplstCountry.DataSource = dt;
            drplstCountry.DataTextField = "CountryName";
            drplstCountry.DataValueField = "CountryId";
            drplstCountry.DataBind();
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            clsProjectManagement obj = new clsProjectManagement();
            obj.PositionId = Convert.ToInt32(drplstPositon.SelectedValue.ToString());
            obj.Name = txtName.Text;
            obj.Email = txtEmail.Text;
            obj.Phone = txtphone.Text;
            obj.CountryId = Convert.ToInt32(drplstCountry.SelectedValue.ToString());
            obj.StateId = Convert.ToInt32(drplstState.SelectedValue.ToString());
            obj.Password = txtPassword.Text;
            Response.Write("<script>alert('Register Successfully...')</script>");
            obj.EmployeeRegister();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtName.Text = "";
            txtPassword.Text = "";
            txtphone.Text = "";
            drplstCountry.SelectedIndex = 0;
            drplstState.SelectedIndex = 0;
        }

        protected void drplstCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CountryId = Convert.ToInt32(drplstCountry.SelectedValue.ToString());
            clsProjectManagement FetchState = new clsProjectManagement();
            FetchState.CountryId = CountryId;
            DataTable dt1 = new DataTable();
            dt1 = FetchState.FetchState();
            drplstState.DataSource = dt1;
            drplstState.DataTextField = "StateName";
            drplstState.DataValueField = "StateId";
            drplstState.DataBind();
        }
    }
}