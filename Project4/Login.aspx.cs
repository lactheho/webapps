using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Project4
{
    public partial class Login : System.Web.UI.Page
    {
        AuctionSvcOnline.Ebay pxy = new AuctionSvcOnline.Ebay();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            lblName.Visible = true;
            txtName.Visible = true;
            lblID.Visible = true;
            txtID.Visible = true;
            lblCustomerType.Visible = true;
            ddlCustomerType.Visible = true;
            btnSubmit.Visible = true;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ddlCustomerType.SelectedValue == "Buyer")
            {
                pxy.AddBuyer(txtName.Text, Int32.Parse(txtID.Text));
                Response.Redirect("BuyerPage.aspx");
            }
            else if (ddlCustomerType.SelectedValue == "Seller")
            {
                pxy.AddSeller(txtName.Text, Int32.Parse(txtID.Text));
                Response.Redirect("SellerPage.aspx");
            }
            else if(ddlCustomerType.SelectedValue == "Both")
            {
                pxy.AddBuyer(txtName.Text, Int32.Parse(txtID.Text));
                pxy.AddSeller(txtName.Text, Int32.Parse(txtID.Text));
            }
        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ReturningCustomer.aspx");
        }
    }
}