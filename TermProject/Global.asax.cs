using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Utilities;

namespace TermProject
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["Email"] = "";
            Application["Password"] = "";
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            DBConnect objDB = new DBConnect();
            string strSQL = "SELECT * FROM Customer ";
            Session["DS"] = objDB.GetDataSet(strSQL);
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            Session["DS"] = null;
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}