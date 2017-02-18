using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarServiceLibrary;

namespace TermProject
{
    public partial class ActivitiesHomePage : System.Web.UI.Page
    {
        ActivitiesSVC.ActivitiesService pxyActivities = new ActivitiesSVC.ActivitiesService();


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

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            gvActivities.DataSource = pxyActivities.GetActivityAgencies(ddlCity.SelectedValue, ddlState.SelectedValue);
            gvActivities.DataBind();
            lblDirections4.Visible = true;

        }

        protected void gvActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            int AgencyID = Int32.Parse(gvActivities.SelectedRow.Cells[1].Text);
            string city = gvActivities.SelectedRow.Cells[2].Text;
            string state = gvActivities.SelectedRow.Cells[3].Text;
            string name = gvActivities.SelectedRow.Cells[4].Text;
            string address = gvActivities.SelectedRow.Cells[5].Text;
            string zip = gvActivities.SelectedRow.Cells[6].Text;

            ActivitiesSVC.Agency objAgency = new ActivitiesSVC.Agency();
            objAgency.AgencyID = AgencyID;
            objAgency.City = city;
            objAgency.State = state;
            objAgency.Name = name;
            objAgency.Address = address;
            objAgency.Zip = zip;

            gvActiviitesByAgencies.DataSource = pxyActivities.GetActivities(objAgency, ddlCity.SelectedValue, ddlState.SelectedValue);
            gvActiviitesByAgencies.DataBind();

            gvActivities.Visible = false;
            lbldirection2.Visible = true;
            lblDirections4.Visible = false;
        }

        protected void gvActiviitesByAgencies_SelectedIndexChanged(object sender, EventArgs e)
        {
            string agencyID = gvActiviitesByAgencies.SelectedRow.Cells[2].Text;
            string activityName = gvActiviitesByAgencies.SelectedRow.Cells[4].Text;
            double price = double.Parse(gvActiviitesByAgencies.SelectedRow.Cells[5].Text);
            string customerName = Session["LoginID"].ToString();
            TripItems objTripItem = new TripItems();
            objTripItem.AddTripItem("Activity", agencyID, activityName, price, 1, customerName);
            lbldirection2.Text = "You have successfully booked " + activityName + " at agency " + agencyID ;
            lbldirection2.ForeColor = System.Drawing.Color.Green;
        }

        protected void btnSignOut_Click(object sender, EventArgs e)
        {
            Session["LoggedIn"] = "";
            Response.Redirect("Login.aspx");
        }
    }
}