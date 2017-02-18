using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using Utilities;

namespace Project4
{
    public partial class ReturningCustomer : System.Web.UI.Page
    {

        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (rblUserType.SelectedValue == "Buyer")
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "checkBuyer";

                SqlParameter outputParameter = new SqlParameter("@ID", SqlDbType.Int, 9);
                outputParameter.Direction = ParameterDirection.Output;
                objCommand.Parameters.Add(outputParameter);

                SqlParameter inputParameter = new SqlParameter("@UserName", txtName.Text);
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

                SqlParameter inputParameter = new SqlParameter("@UserName", txtName.Text);
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