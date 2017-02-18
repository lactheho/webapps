using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarServiceLibrary;

namespace TermProjectWS
{
    public partial class TestPage : System.Web.UI.Page
    {
        CarSvcOnline.CarService pxy = new CarSvcOnline.CarService();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit1_Click(object sender, EventArgs e)
        {
            gvCarAgency.DataSource = pxy.GetRentalCarAgencies("Philadelphia", "PA");
            gvCarAgency.DataBind();
        }

        protected void btnSubmit2_Click(object sender, EventArgs e)
        {
            gvCars.DataSource = pxy.GetCarsByAgency(123, "Philadelphia", "PA");
            gvCars.DataBind();
        }

        protected void btnSubmit3_Click(object sender, EventArgs e)
        {
            CarSvcOnline.Requirements RequirementsOBJ = new CarSvcOnline.Requirements();
            RequirementsOBJ.FourDoors = true;
            RequirementsOBJ.Automatic = true;
            RequirementsOBJ.SUV = false;
            RequirementsOBJ.MPGInCity30 = true;
            gvCarReqs.DataSource = pxy.FindCars(RequirementsOBJ, "Las Vegas", "NV");
            gvCarReqs.DataBind();
        }

        protected void btnSubmit4_Click(object sender, EventArgs e)
        {
            CarSvcOnline.Requirements RequirementsOBJ = new CarSvcOnline.Requirements();
            RequirementsOBJ.FourDoors = true;
            RequirementsOBJ.Automatic = true;
            RequirementsOBJ.SUV = false;
            RequirementsOBJ.MPGInCity30 = true;
            gvCarReqsAgency.DataSource = pxy.FindCarsByAgency(654, RequirementsOBJ, "Las Vegas", "NV");
            gvCarReqsAgency.DataBind();
        }

        protected void btnReserve_Click(object sender, EventArgs e)
        {
            CarSvcOnline.Agency AgencyOBJ = new CarSvcOnline.Agency();
            AgencyOBJ.ID = 123;
            AgencyOBJ.Name = "Enterprise";
            string agencyName = AgencyOBJ.Name;
            CarSvcOnline.Car CarOBJ = new CarSvcOnline.Car();
            CarOBJ.ID = 213;
            CarOBJ.Name = "Ford Mustang";
            string carName = CarOBJ.Name;
            CarSvcOnline.Customer CustomerOBJ = new CarSvcOnline.Customer();
            CustomerOBJ.ID = 999;
            CustomerOBJ.Name = "Jackson";
            string customerName = CustomerOBJ.Name;
            CustomerOBJ.PhoneNumber = "2154566789";
            if (pxy.Reserve(AgencyOBJ, CarOBJ, CustomerOBJ, 456789, "mushybananas"))
            { 
                lblText.Text = "You have reserve a " + carName + " at " + agencyName + " for " + customerName;
            }
        }

        protected void btnFindCustomers_Click(object sender, EventArgs e)
        {
            CarSvcOnline.Customer CustomerOBJ = new CarSvcOnline.Customer();
            CustomerOBJ.Name = "John";
            CustomerOBJ.ID = 956;
            CustomerOBJ.PhoneNumber = "2154566789";
            gvCustomer.DataSource = pxy.FindCustomer(CustomerOBJ, 456789, "mushybananas");
            gvCustomer.DataBind();
        }

        protected void btnView_Click(object sender, EventArgs e)
        {
            Response.Redirect("Description.aspx");
        }
    }
}