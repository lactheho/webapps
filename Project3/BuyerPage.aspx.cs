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
    public partial class BuyerPage : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();

        protected void Page_Load(object sender, EventArgs e)
        {
            //hides control on first page load
            if (!IsPostBack)
            {
                lblSucess.Visible = false;
                btnSubmit.Visible = false;
            }
        }

        //displays all tickets available for buying
        protected void btnViewTickets_Click(object sender, EventArgs e)
        {
            btnSubmit.Visible = true;
            displayAllTickets();
        }

        //gets all available tickets from database and binds to gridview
        public void displayAllTickets()
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "queryAllTickets";

            gvTickets.DataSource = objDB.GetDataSetUsingCmdObj(objCommand);
            gvTickets.DataBind();
        }

        //searchs tickets by the event name inputted by user and binds to gridview
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            btnSubmit.Visible = true;
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "queryTicketByName";

            SqlParameter inputParameter = new SqlParameter("@eventName", txtSearchEventName.Text);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            gvTickets.DataSource = objDB.GetDataSetUsingCmdObj(objCommand);
            gvTickets.DataBind();
        }

        //search tickets by event type selected by user and binds to gridview
        public void displayTicketsByEventType(String eventType)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "queryTicketByEventType";

            SqlParameter inputParameter = new SqlParameter("@EventType", eventType);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            gvTickets.DataSource = objDB.GetDataSetUsingCmdObj(objCommand);
            gvTickets.DataBind();
        }

        //displays gridview depending on selected value
        protected void ddlEventType_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSubmit.Visible = true;
            displayTicketsByEventType(ddlEventType.SelectedValue);
        }

        //purchases ticket
        protected void btnSubmit_Click1(object sender, EventArgs e)
        {
            string userName = (string)Session["UserName"];
            for (int row = 0; row < gvTickets.Rows.Count; row++)
            {
                CheckBox CBox;
                CBox = (CheckBox)gvTickets.Rows[row].FindControl("cbxBuyTicket");
                if (CBox.Checked)
                {
                    string eventName = gvTickets.Rows[row].Cells[0].Text;

                    objCommand.CommandType = CommandType.StoredProcedure;
                    objCommand.CommandText = "buyTicket";

                    SqlParameter inputParameter = new SqlParameter("@eventName", eventName);
                    inputParameter.Direction = ParameterDirection.Input;
                    inputParameter.SqlDbType = SqlDbType.VarChar;
                    objCommand.Parameters.Add(inputParameter);

                    inputParameter = new SqlParameter("@userName", userName);
                    inputParameter.Direction = ParameterDirection.Input;
                    inputParameter.SqlDbType = SqlDbType.VarChar;
                    objCommand.Parameters.Add(inputParameter);

                    objDB.DoUpdateUsingCmdObj(objCommand);

                    lblSucess.Visible = true;
                }
            }
        }
    }
}