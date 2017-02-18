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
    public partial class Login : System.Web.UI.Page
    {
        ArrayList buyerList = new ArrayList();
        ArrayList sellerList = new ArrayList();
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //hides control on first load
                lblInformation.Visible = false;
                lblID.Visible = false;
                txtID.Visible = false;
                lblUserName.Visible = false;
                txtUserName.Visible = false;
                rblUserType.Visible = false;
                btnSubmit.Visible = false;
            }

        }

        //adds a buyer to Buyer table in database
        public void addBuyer()
        {
            Buyer objBuyer = new Buyer();
            objBuyer.ID = Int32.Parse(txtID.Text);
            objBuyer.UserName = txtUserName.Text;
            buyerList.Add(objBuyer);
            Session["UserName"] = txtUserName.Text;

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "insertBuyer";

            SqlParameter inputParameter = new SqlParameter("@ID", Int32.Parse(txtID.Text));
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 3;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@userName", txtUserName.Text);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            objDB.DoUpdateUsingCmdObj(objCommand);
        }

        //adds a seller to Seller table in database
        public void addSeller()
        {
            Seller objSeller = new Seller();
            objSeller.ID = Int32.Parse(txtID.Text);
            objSeller.UserName = txtUserName.Text;
            sellerList.Add(objSeller);
            Session["UserName"] = txtUserName.Text;

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "insertSeller";

            SqlParameter inputParameter = new SqlParameter("@ID", Int32.Parse(txtID.Text));
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 3;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@userName", txtUserName.Text);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            objDB.DoUpdateUsingCmdObj(objCommand);
        }

        //displays controls when user clicks new user
        protected void btnNewUser_Click(object sender, EventArgs e)
        {
            lblInformation.Visible = true;
            lblID.Visible = true;
            txtID.Visible = true;
            lblUserName.Visible = true;
            txtUserName.Visible = true;
            rblUserType.Visible = true;
            btnSubmit.Visible = true;
        }

        //goes to existing user page when button is pressed
        protected void btnExistingUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("ExistingUser.aspx");
        }

        //goes to buyer/seller page depending on selected radio button
        //adds the buyer/seller to database
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (rblUserType.SelectedValue == "Buyer")
            {
                addBuyer();
                Response.Redirect("BuyerPage.aspx");
            }
            else if (rblUserType.SelectedValue == "Seller")
            {
                addSeller();
                Response.Redirect("SellerPage.aspx");
            }
        }
    }
}