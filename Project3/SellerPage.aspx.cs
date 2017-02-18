using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using TicketLibrary;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace Project3
{
    public partial class SellerPage : System.Web.UI.Page
    {
        ArrayList ticketList = new ArrayList();
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();

        
        protected void Page_Load(object sender, EventArgs e)
        {
            //hides controls on first page load
            if(!IsPostBack)
            {
                hideControls();
                lblSucess.Visible = false;
            }
        }

        //add a ticket to database when clicked
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            addTicket();
            hideControls();
            lblSucess.Visible = true;
        }

        //add ticket to databse
        public void addTicket()
        {
            Ticket objTicket = new Ticket();
            objTicket.EventName = txtEventName.Text;
            objTicket.EventType = ddlEventType.SelectedValue;
            objTicket.EventDate = eventCalendar.SelectedDate;
            objTicket.Price = double.Parse(txtPrice.Text);
            string userName = (string)Session["UserName"];

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "insertTicket";

            SqlParameter inputParameter = new SqlParameter("@eventName", txtEventName.Text);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@eventType", ddlEventType.SelectedValue);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@eventDate", eventCalendar.SelectedDate);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Date;
            objCommand.Parameters.Add(inputParameter);


            inputParameter = new SqlParameter("@price", Double.Parse(txtPrice.Text));
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Money;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@userName", userName);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            objDB.DoUpdateUsingCmdObj(objCommand);
        }

        //displays controls when clicked sell ticket button is clicked
        protected void btnSellTicket_Click(object sender, EventArgs e)
        {
            lblEventInformation.Visible = true; 
            lblEventName.Visible = true;
            lblEventType.Visible = true;
            lblEventDate.Visible = true;
            lblPrice.Visible = true;
            txtEventName.Visible = true;
            ddlEventType.Visible = true;
            eventCalendar.Visible = true;
            txtPrice.Visible = true;
            btnSubmit.Visible = true;
        }

        //hides controls
        public void hideControls()
        {
            lblEventInformation.Visible = false;
            lblEventName.Visible = false;
            lblEventType.Visible = false;
            lblEventDate.Visible = false;
            lblPrice.Visible = false;
            txtEventName.Visible = false;
            ddlEventType.Visible = false;
            eventCalendar.Visible = false;
            txtPrice.Visible = false;
            btnSubmit.Visible = false;
        }

        //view tickets owned by user
        protected void btnViewTickets_Click(object sender, EventArgs e)
        {
            viewMyTickets();
        }

        //gets tickets from database belonging to the user and binds it to a gridview
        public void viewMyTickets()
        {
            string userName = (string)Session["UserName"];
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "queryTicketByUser";

            SqlParameter inputParameter = new SqlParameter("@userName", userName);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            gvTickets.DataSource = objDB.GetDataSetUsingCmdObj(objCommand);
            gvTickets.DataBind();

            hideControls();
        }


    }
}