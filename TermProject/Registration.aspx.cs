using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Utilities;
using CarServiceLibrary;

namespace TermProject
{
    public partial class Registration : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void rblPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCardNumber.Visible = true;
            txtCardNumber.Visible = true;
            lblExpirationDate.Visible = true;
            calendar.Visible = true;
            lblSecurityCode.Visible = true;
            txtSecurityCode.Visible = true;
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Customer objCustomer = new Customer();
            objCustomer.ID = txtLoginID.Text;
            objCustomer.Name = txtName.Text;
            objCustomer.PhoneNumber = txtPhoneNumber.Text;
            objCustomer.ShippingAddress = txtShipping.Text;
            objCustomer.Password = txtPassword.Text;
            objCustomer.CardNumber = txtCardNumber.Text;
            objCustomer.ExpirationDate = calendar.SelectedDate;
            objCustomer.SecurityCode = Int32.Parse(txtSecurityCode.Text);

            objCustomer.addCustomer(objCustomer);

            if (chkStoreCookie.Checked == true)
            {
                HttpCookie myCookie = new HttpCookie("CIS3342_Cookie");
                myCookie.Values["LoginID"] = txtLoginID.Text;
                myCookie.Expires = new DateTime(2025, 1, 1);
                Response.Cookies.Add(myCookie);
            }
            string status = "loggedin";
            Session["LoggedIn"] = status;
            //string name = objCustomer.GetCustomerName(txtLoginID.Text);

            //Session["CustomerName"] = name;
            Session["LoginID"] = txtLoginID.Text;
            lblSuccess.Visible = true;
            btnLoginPage.Visible = true;
        }

        protected void calendar_SelectionChanged(object sender, EventArgs e)
        {
            lblExpirationDate.Text = "Expiration Date: " + calendar.SelectedDate.ToShortDateString();
        }

        protected void btnLoginPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

    }
}