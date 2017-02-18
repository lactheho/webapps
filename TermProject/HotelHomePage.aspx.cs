using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarServiceLibrary;

namespace TermProject
{
    public partial class HotelHomePage : System.Web.UI.Page
    {
        HotelSVC.HotelService pxyHotel = new HotelSVC.HotelService();

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

        protected void btnGetHotels_Click(object sender, EventArgs e)
        {
            gvHotels.DataSource = pxyHotel.GetHotels(ddlCity.SelectedValue, ddlState.SelectedValue);
            gvHotels.DataBind();
            btnFindRoomsByID.Visible = true;
            btnFindRoomsByAmen.Visible = true;
            lblDirections3.Visible = true;
        }

        protected void btnGetRooms_Click(object sender, EventArgs e)
        {
            gvHotelRooms.DataSource = pxyHotel.GetRoomsByHotel(txtHotelID.Text);
            gvHotelRooms.DataBind();
            lblDirections2.Visible = true;
        }

        protected void gvHotelRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            string HotelID = gvHotelRooms.SelectedRow.Cells[2].Text;
            string RoomNumber = gvHotelRooms.SelectedRow.Cells[3].Text;
            double PricePerNight = double.Parse(gvHotelRooms.SelectedRow.Cells[4].Text);
            string customerName = Session["LoginID"].ToString();
            TripItems objTripItem = new TripItems();
            objTripItem.AddTripItem("Hotel", HotelID, RoomNumber, PricePerNight, 1, customerName);
            lblDirections2.Text = "You have successfully booked room " + RoomNumber + " at hotel ID " + HotelID;
            lblDirections2.ForeColor = System.Drawing.Color.Green;

        }

        protected void btnFindRoom_Click(object sender, EventArgs e)
        {
            HotelSVC.Amenities objAmenities = new HotelSVC.Amenities();
            objAmenities.Bathtub = cbxBathTub.Checked;
            objAmenities.NonSmoking = cbxNonSmoking.Checked;
            objAmenities.PetFriendly = cbxNonSmoking.Checked;
            objAmenities.Futon = cbxFulton.Checked;

            gvHotelRooms.DataSource = pxyHotel.FindRoomsByHotel(txtHotelID2.Text, objAmenities);
            gvHotelRooms.DataBind();


            lblDirections2.Visible = true;
        }

        protected void btnFindRoomsByAmen_Click(object sender, EventArgs e)
        {
            lblFindRoom.Visible = true;
            lblRoomAmenities.Visible = true;
            cbxBathTub.Visible = true;
            cbxNonSmoking.Visible = true;
            cbxPetFriendly.Visible = true;
            cbxFulton.Visible = true;
            lblHotelID2.Visible = true;
            txtHotelID2.Visible = true;
            btnFindRoom.Visible = true;
        }

        protected void btnFindRoomsByID_Click(object sender, EventArgs e)
        {
            lblGetRoomByHotel.Visible = true;
            lblHotelID.Visible = true;
            txtHotelID.Visible = true;
            btnGetRooms.Visible = true;
        }

        protected void btnSignOut_Click(object sender, EventArgs e)
        {
            Session["LoggedIn"] = "";
            Response.Redirect("Login.aspx");
        }
    }
}