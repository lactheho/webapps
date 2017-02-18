using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarServiceLibrary;
namespace TermProject
{
    public partial class AirHomePage : System.Web.UI.Page
    {

        AirSVC.AirService pxyAir = new AirSVC.AirService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoggedIn"] != null)
            {

            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void btnGetAirCarriers_Click(object sender, EventArgs e)
        {
            gvAirCarriers.DataSource = pxyAir.GetAirCarriers(ddlCity.SelectedValue, ddlState.SelectedValue, ddlCity2.SelectedValue, ddlState2.SelectedValue);
            gvAirCarriers.DataBind();
        }


        protected void gvAirCarriers_SelectedIndexChanged(object sender, EventArgs e)
        {
            AirSVC.AirCarrier objAirCarrier = new AirSVC.AirCarrier();
            string carrierName = gvAirCarriers.SelectedRow.Cells[1].Text;

            if(carrierName == "American Airlines")
            {
                objAirCarrier.AirCarrierID = 1;
            }
            else if(carrierName == "Delta Air Lines")
            {
                objAirCarrier.AirCarrierID = 2;
            }
            else
            {
                objAirCarrier.AirCarrierID = 3;
            }
            gvFlights.DataSource = pxyAir.GetFlights(objAirCarrier, ddlCity.SelectedValue, ddlState.SelectedValue, ddlCity2.SelectedValue, ddlState2.SelectedValue);
            gvFlights.DataBind();
            lbldirection2.Visible = true;
            btnFilter.Visible = true;
            ddlSeatingType.Visible = true;
            chkboxNonStop.Visible = true;
            lblDirection3.Visible = true;
            lblSeatingType.Visible = true;
        }

        protected void btnFilter_Click(object sender, EventArgs e)
        {
            AirSVC.AirCarrier objAirCarrier = new AirSVC.AirCarrier();
            string carrierName = gvAirCarriers.SelectedRow.Cells[1].Text;

            if (carrierName == "American Airlines")
            {
                objAirCarrier.AirCarrierID = 1;
            }
            else if (carrierName == "Delta Air Lines")
            {
                objAirCarrier.AirCarrierID = 2;
            }
            else
            {
                objAirCarrier.AirCarrierID = 3;
            }

            AirSVC.FlightRequirement objFlightRequirement = new AirSVC.FlightRequirement();
            objFlightRequirement.Nonstop = chkboxNonStop.Checked;
            objFlightRequirement.SeatingType = ddlSeatingType.SelectedValue;

            gvFlights.DataSource = pxyAir.FilterFlightsByCarrier(objAirCarrier, objFlightRequirement, ddlCity.SelectedValue, ddlState.SelectedValue, ddlCity2.SelectedValue, ddlState2.SelectedValue);
            gvFlights.DataBind();
        }

        protected void gvFlights_SelectedIndexChanged(object sender, EventArgs e)
        {
            string carrierID = gvFlights.SelectedRow.Cells[2].Text;
            string flightNumber = gvFlights.SelectedRow.Cells[1].Text;
            double price = double.Parse(gvFlights.SelectedRow.Cells[9].Text);
            string customerName = Session["LoginID"].ToString();
            TripItems objTripItem = new TripItems();
            objTripItem.AddTripItem("Air", carrierID, flightNumber, price, 1, customerName);
            lblDirection3.Text = "You have sucessfully booked carrierID #" + carrierID  + " on flight " + flightNumber ;
            lblDirection3.ForeColor = System.Drawing.Color.Green;
        }

        protected void btnSignOut_Click(object sender, EventArgs e)
        {
            Session["LoggedIn"] = "";
            Response.Redirect("Login.aspx");
        }
    }
}