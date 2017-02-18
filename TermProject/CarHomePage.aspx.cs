using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using CarServiceLibrary;
namespace TermProject
{
    public partial class CarServicesHomePage : System.Web.UI.Page
    {



        CarSVC.CarService pxyCar = new CarSVC.CarService();
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


        //protected void btnSubmit_Click(object sender, EventArgs e)
        //{
        //    gvCarAgencies.DataSource = pxyCar.GetRentalCarAgencies(ddlCity.SelectedValue, ddlState.SelectedValue);
        //    gvCarAgencies.DataBind();
        //}

        protected void btnSubmit2_Click(object sender, EventArgs e)
        {
            CarSVC.Requirements requirements = new CarSVC.Requirements();

            requirements.FourDoors = cbxFourDoors.Checked;
            requirements.Automatic = cbxAutomatic.Checked;
            requirements.SUV = cbxSUV.Checked;
            requirements.MPGInCity30 = cbx30MPG.Checked;

            int AgencyID = Int32.Parse(gvCarAgencies.SelectedRow.Cells[1].Text);

            gvCars.DataSource = pxyCar.FindCarsByAgency(AgencyID, requirements, ddlCity.SelectedValue, ddlState.SelectedValue);
            gvCars.DataBind();


        }


        protected void gvCarAgencies_SelectedIndexChanged(object sender, EventArgs e)
        {
            int AgencyID = Int32.Parse(gvCarAgencies.SelectedRow.Cells[1].Text);

            gvCars.DataSource = pxyCar.GetCarsByAgency(AgencyID, ddlCity.SelectedValue, ddlState.SelectedValue);
            gvCars.DataBind();
            gvCarAgencies.Visible = false;
            lblDirections2.Visible = true;
            cbxFourDoors.Visible = true;
            cbxAutomatic.Visible = true;
            cbxSUV.Visible = true;
            cbx30MPG.Visible = true;
            btnSubmit2.Visible = true;
            lblDirections3.Visible = true;
            lblDirections4.Visible = false;

        }

        protected void btnGetCarAgencies_Click(object sender, EventArgs e)
        {
            gvCarAgencies.DataSource = pxyCar.GetRentalCarAgencies(ddlCity.SelectedValue, ddlState.SelectedValue);
            gvCarAgencies.DataBind();
            lblDirections4.Visible = true;
        }

        protected void gvCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            string AgencyName = gvCars.SelectedRow.Cells[3].Text;
            string CarName = gvCars.SelectedRow.Cells[6].Text;
            double PricePerDay = double.Parse(gvCars.SelectedRow.Cells[7].Text);
            string customerName = Session["LoginID"].ToString();
            TripItems objTripItem = new TripItems();
            objTripItem.AddTripItem("Car", AgencyName, CarName, PricePerDay, 1, customerName);
            lblDirections3.Text = "You have sucessfully booked " + CarName + " .";
            lblDirections3.ForeColor = System.Drawing.Color.Green;
        }

        protected void btnSignOut_Click(object sender, EventArgs e)
        {
            Session["LoggedIn"] = "";
            Response.Redirect("Login.aspx");
        }

        //protected void gvCars_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    TripItems objTripItem = new TripItems();
        //    string agencyName = gvCars.SelectedRow.Cells[3].Text;
        //    string carName = gvCars.SelectedRow.Cells[6].Text;

        //    objTripItem.AddTripItem("Car Rental Service", agencyName, carName, )
        //}
    }
}