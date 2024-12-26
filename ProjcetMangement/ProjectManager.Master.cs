using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjcetMangement
{
    public partial class ProjectManager : System.Web.UI.MasterPage
    {
        public int EmpId { get;set; }   
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserId1"] != null)
            {
                EmpId = Convert.ToInt32(Session["UserId1"]);
            }
        }
    }
    }
