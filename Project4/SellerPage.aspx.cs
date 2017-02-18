using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project4
{
    public partial class SellerPage : System.Web.UI.Page
    {
        AuctionSvcOnline.Ebay pxy = new AuctionSvcOnline.Ebay();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void EndDateCalendar_SelectionChanged(object sender, EventArgs e)
        {
            lblDate.Text = EndDateCalendar.SelectedDate.ToShortDateString();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            pxy.AddProduct(txtDescription.Text, ddlCategory.SelectedValue, double.Parse(txtReservePrice.Text), EndDateCalendar.SelectedDate);
            lblSuccess.Visible = true;
        }
    }
}