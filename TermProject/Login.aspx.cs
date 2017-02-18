using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarServiceLibrary;

namespace TermProject
{
    public partial class Login : System.Web.UI.Page
    {
        CarSVC.CarService pxy = new CarSVC.CarService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Request.Cookies["CIS3342_Cookie"] != null)
            {
                HttpCookie cookie = Request.Cookies["CIS3342_Cookie"];
                txtLoginID.Text = cookie.Values["LoginID"].ToString();
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Customer objCustomer = new Customer();
            CarSVC.Customer CustomerOBJ = new CarSVC.Customer();
            CustomerOBJ.ID = txtLoginID.Text;

            int checkLogin = objCustomer.CheckLogin(txtLoginID.Text, txtPassword.Text);
            if(checkLogin == 1)
            {
                if(chkStoreCookie.Checked == true)
                {
                    HttpCookie myCookie = new HttpCookie("CIS3342_Cookie");
                    myCookie.Values["LoginID"] = txtLoginID.Text;
                    myCookie.Expires = new DateTime(2025, 1, 1);
                    Response.Cookies.Add(myCookie);
                }
                if(chkDeleteCookie.Checked == true)
                {
                    HttpCookie myCookie = new HttpCookie("CIS3342_Cookie");
                    myCookie.Values["LoginID"] = "";
                    Response.Cookies.Add(myCookie);
                }
                string status = "loggedin";
                Session["LoggedIn"] = status;
                //string name =  objCustomer.GetCustomerName(txtLoginID.Text);

                //Session["CustomerName"] = name;
                Session["LoginID"] = txtLoginID.Text;
                Response.Redirect("HomePage.aspx");
            }
            else
            {
                lblWarning.Visible = true;  
                txtPassword.Focus();
            }
        }
    }
}