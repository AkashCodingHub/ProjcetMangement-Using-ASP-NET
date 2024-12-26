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
    public partial class Login : System.Web.UI.Page
    {
        private string name;
        private string email;

        public string Email { get; private set; }
        public int PositionId { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack)
            {
                ShowPositionAPB();
                btnRegister_Click(sender, e);
            }
        }

        public void ShowPositionAPB()
        {
            clsProjectManagement FetchPosition = new clsProjectManagement();
            DataTable dt1 = new DataTable();
            dt1 = FetchPosition.ShowPositionAPB();
            drplstPosition.DataSource = dt1;
            drplstPosition.DataTextField = "PositionName";
            drplstPosition.DataValueField = "PositionId";
            drplstPosition.DataBind();
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            clsProjectManagement Login = new clsProjectManagement();
            Login.Email = txtEmail.Text;
            Login.Password = txtPassword.Text;
            clsProjectManagement Login2 = new clsProjectManagement(Login);
            DataTable dt = new DataTable();
            dt = Login2.Login();
            if (dt.Rows.Count < 0 || dt.Rows.Count == 0)
            {
                Response.Write("<script>alert('Wrong Details');</script>");
                return;

            }
            else
            {
                String Position;
                Position = dt.Rows[0]["PositionId"].ToString();
                if (Position == "1")
                {
                    String UserName = dt.Rows[0]["Name"].ToString();
                    String UserId = dt.Rows[0]["RegistrationId"].ToString();
                    Session["UName"] = UserName;
                    Session["UId"] = UserId; 
                    Response.Redirect("ProjectAll.aspx");
                    Response.Write("<script>alert('Login Successful');</script>");
                    return;
                }

                if (Position == "2")
                {
                    Application["UUid"] = dt.Rows[0]["RegistrationId"].ToString();


                    String UserName = dt.Rows[0]["Name"].ToString();
                    String UserId = dt.Rows[0]["RegistrationId"].ToString();

                    Session["UName"] = UserName;
                    Session["UId"] = UserId;


                   Response.Redirect("frmProjectManager.aspx");

                    Response.Write("<script>alert('Login Successful');</script>");

                    return;

                }


                if (Position == "3")
                {
                    Application["UUid"] = dt.Rows[0]["RegistrationId"].ToString();


                    String UserName = dt.Rows[0]["Name"].ToString();
                    String UserId = dt.Rows[0]["RegistrationId"].ToString();

                    Session["UName"] = UserName;
                    Session["UId"] = UserId;


                   // Response.Redirect("frmTLpage.aspx");

                    Response.Write("<script>alert('Login Successful');</script>");

                    return;
          

            }
        }
}

        protected void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}



