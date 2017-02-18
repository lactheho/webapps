using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project4
{
    public partial class BuyerPage : System.Web.UI.Page
    {
        AuctionSvcOnline.Ebay pxy = new AuctionSvcOnline.Ebay();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (double.Parse(txtBidAmount.Text) <= pxy.GetBidPrice(txtDescription.Text))
            {
                lblValidateBid.Visible = true;
                txtBidAmount.Text = "";
                txtBidAmount.Focus();
            }
            else if (double.Parse(txtBidAmount.Text) == pxy.GetReservePrice(txtDescription.Text))
            {
                pxy.UpdateBid(txtDescription.Text, double.Parse(txtBidAmount.Text));
                gvProducts.DataSource = pxy.GetUnsoldProducts();
                gvProducts.DataBind();
                lblSold.Visible = true;
            }
            else
            {
                pxy.UpdateBid(txtDescription.Text, double.Parse(txtBidAmount.Text));
                gvProducts.DataSource = pxy.GetUnsoldProducts();
                gvProducts.DataBind();
                lblSuccess.Visible = true;
            }
        }

        protected void ddlFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            gvProducts.DataSource = pxy.GetProductsByCategory(ddlCategory.SelectedValue);
            gvProducts.DataBind();
        }

        protected void ddlReservePrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlReservePrice.SelectedValue == "Low to High")
            {
                gvProducts.DataSource = pxy.GetProductByReservePriceAsc();
                gvProducts.DataBind();
            }
            else if(ddlReservePrice.SelectedValue == "High to Low")
            {
                gvProducts.DataSource = pxy.GetProductByReservePriceDesc();
                gvProducts.DataBind();
            }
        }

        protected void ddlBidPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlBidPrice.SelectedValue == "Low to High")
            {
                gvProducts.DataSource = pxy.GetProductsByBidPriceAsc();
                gvProducts.DataBind();
            }
            else if (ddlBidPrice.SelectedValue == "High to Low")
            {
                gvProducts.DataSource = pxy.GetProductsByBidPriceDesc();
                gvProducts.DataBind();
            }
        }
    }
}