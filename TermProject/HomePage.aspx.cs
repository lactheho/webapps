using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using CarServiceLibrary;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace TermProject
{
    public partial class HomePage : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (Session["LoggedIn"] != null)
                {

                }
                else
                {
                    Response.Redirect("Login.aspx");
                }

            }
        }

        protected void btnViewCart_Click(object sender, EventArgs e)
        {
            ShowTripItems();
            if (gvTripItems.Rows.Count != 0)
            {
                btnClear.Visible = true;
                btnPurchase.Visible = true;
            }
            else
            {
                lblAlert.Visible = true;
                lblAlert.Text = "Your cart is empty. Add items to your car by selecting one of the services.";
            }
        }

        public void ShowTripItems()
        {
            int totalQuantity = 0;
            double total = 0;

            string customerName = Session["LoginID"].ToString();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "getTripItems";
            objCommand.Parameters.Clear();

            SqlParameter inputParameter = new SqlParameter("@CustomerName", customerName);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            gvTripItems.DataSource = objDB.GetDataSetUsingCmdObj(objCommand);
            gvTripItems.DataBind();

            for (int i = 0; i < gvTripItems.Rows.Count; i++)
            {
                totalQuantity = totalQuantity + int.Parse(gvTripItems.Rows[i].Cells[5].Text);
                total = total + double.Parse(gvTripItems.Rows[i].Cells[6].Text, NumberStyles.Currency);
            }

            gvTripItems.Columns[0].FooterText = "Totals:";
            gvTripItems.Columns[5].FooterText = totalQuantity.ToString();
            gvTripItems.Columns[6].FooterText = total.ToString("C2");

            gvTripItems.DataBind();
        }

        protected void gvTripItems_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvTripItems.EditIndex = e.NewEditIndex;
            ShowTripItems();
        }

        protected void gvTripItems_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvTripItems.EditIndex = -1;
            ShowTripItems();
        }

        protected void gvTripItems_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string customerName = gvTripItems.Rows[rowIndex].Cells[0].Text;
            string tripItemName = gvTripItems.Rows[rowIndex].Cells[2].Text;
            string tripItemDescription = gvTripItems.Rows[rowIndex].Cells[3].Text;


            TextBox Tbox;
            Tbox = (TextBox)gvTripItems.Rows[rowIndex].FindControl("txtQtyAdd");
            int quantity = int.Parse(Tbox.Text);

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "updateTripItemQuantity";
     

            SqlParameter inputParameter = new SqlParameter("@Quantity", quantity);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@TripItemName", tripItemName);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@TripItemDescription", tripItemDescription);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@CustomerName", customerName);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            objDB.DoUpdateUsingCmdObj(objCommand);

            lblAlert.Text = "You have successfully updated your cart.";
            lblAlert.ForeColor = System.Drawing.Color.Green;
            lblAlert.Visible = true;

            gvTripItems.EditIndex = -1;
            ShowTripItems();
        }

        protected void gvTripItems_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string customerName = gvTripItems.Rows[rowIndex].Cells[0].Text;
            string tripItemName = gvTripItems.Rows[rowIndex].Cells[2].Text;
            string tripItemDescription = gvTripItems.Rows[rowIndex].Cells[3].Text;

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "DeleteTripItem";
            objCommand.Parameters.Clear();

            SqlParameter inputParameter = new SqlParameter("@TripItemName", tripItemName);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@TripItemDescription", tripItemDescription);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@CustomerName", customerName);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            objDB.DoUpdateUsingCmdObj(objCommand);

            lblAlert.Text = "You have successfully deleted an item in your cart.";
            lblAlert.ForeColor = System.Drawing.Color.Green;
            lblAlert.Visible = true;

            gvTripItems.EditIndex = -1;
            ShowTripItems();
        }

        public void btnClear_Click(object sender, EventArgs e)
        {
            string customerName = Session["LoginID"].ToString();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "clearTripItems";
            
            SqlParameter inputParameter = new SqlParameter("@CustomerName", customerName);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            objDB.DoUpdateUsingCmdObj(objCommand);

            lblAlert.Text = "You have cleared your cart.";
            lblAlert.Visible = true;

            ShowTripItems();
        }

        protected void btnPurchase_Click(object sender, EventArgs e)
        {
            Response.Redirect("Purchase.aspx");
        }

        protected void btnSignOut_Click(object sender, EventArgs e)
        {
            Session["LoggedIn"] = "";
            Response.Redirect("Login.aspx");
        }
    }
}