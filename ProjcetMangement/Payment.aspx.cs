using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjcetMangement
{
    public partial class Payment : System.Web.UI.Page
    {
        private string dr;

        public string RegId { get;  set; }
        public string Email { get;  set; }
        public string Amt { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                clsProjectManagement objCompleted = new clsProjectManagement();
                DataTable dt = new DataTable();
                dt = objCompleted.CompletePayment();
                grdAsign.DataSource = dt;
                grdAsign.DataBind();
            }
        }

        //public class CheckBoxTemplate : ITemplate
        //{
        //    //public void InstantiateIn(Control container)
        //    //{
        //    //    CheckBox chk = new CheckBox();
        //    //    chk.ID = "chkSelect";
        //    //    container.Controls.Add(chk);
        //    //}
        //}


        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("<(script>alert('CheckOut Successfully');</script>");
            Response.Redirect("MainLog.aspx");
        }

       
    }
}