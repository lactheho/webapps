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
    public partial class ExistingUser : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();

        //hide warning label 
        protected void Page_Load(object sender, EventArgs e)
        {
            lblWarning.Visible = false;
        }

        //checks if the user exists is in the database
        //warning label will appear if they don't exist, otherwise it will take them to seller/buyer page
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Session["UserName"] = txtUserName.Text;
            if (rblUserType.SelectedValue == "Buyer")
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "checkBuyer";

                SqlParameter outputParameter = new SqlParameter("@ID", SqlDbType.Int, 9);
                outputParameter.Direction = ParameterDirection.Output;
                objCommand.Parameters.Add(outputParameter);

                SqlParameter inputParameter = new SqlParameter("@UserName", txtUserName.Text);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.VarChar;
                objCommand.Parameters.Add(inputParameter);

                objDB.GetDataSetUsingCmdObj(objCommand);
                if (txtID.Text == objCommand.Parameters["@ID"].Value.ToString())
                {
                    Response.Redirect("BuyerPage.aspx");
                }
                else
                {
                    txtID.Focus();
                    lblWarning.Visible = true;
                }

            }
            else if (rblUserType.SelectedValue == "Seller")
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "checkSeller";

                SqlParameter outputParameter = new SqlParameter("@ID", SqlDbType.Int, 9);
                outputParameter.Direction = ParameterDirection.Output;
                objCommand.Parameters.Add(outputParameter);

                SqlParameter inputParameter = new SqlParameter("@UserName", txtUserName.Text);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.VarChar;
                objCommand.Parameters.Add(inputParameter);

                objDB.GetDataSetUsingCmdObj(objCommand);
                if (txtID.Text == objCommand.Parameters["@ID"].Value.ToString())
                {
                    Response.Redirect("SellerPage.aspx");
                }
                else
                {
                    txtID.Focus();
                    lblWarning.Visible = true;
                }
            }
        }


    }
}