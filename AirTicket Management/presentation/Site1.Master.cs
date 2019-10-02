using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace presentation
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string filename = Path.GetFileName(Request.PhysicalPath);
            if (filename != "LoginPage.aspx")
            {
                if (Session["User"] == null)
                {
                    Response.Redirect("LoginPage.aspx");
                }
            
            
            }
        
        }
    }
}