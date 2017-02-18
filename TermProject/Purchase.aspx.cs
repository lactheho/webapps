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
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections;

namespace TermProject
{
    public partial class Purchase : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (Session["LoggedIn"] != null)
                {
                    int result = 2;

                    string customerName = Session["LoginID"].ToString();

                    objCommand.CommandType = CommandType.StoredProcedure;
                    objCommand.CommandText = "checkVacation";
                    objCommand.Parameters.Clear();

                    objCommand.Parameters.AddWithValue("@CustomerName", customerName);
                    SqlParameter outputParameter = new SqlParameter("@Result", result);
                    outputParameter.Direction = ParameterDirection.Output;
                    outputParameter.SqlDbType = SqlDbType.Int;
                    objCommand.Parameters.Add(outputParameter);

                    objDB.GetDataSetUsingCmdObj(objCommand);

                    result = int.Parse(objCommand.Parameters["@Result"].Value.ToString());

                    if(result == 1)
                    {
                        ShowVacationPackage();
                        btnPurchase.Visible = false;
                        lblDisplay.Text = "You have already purchased a vacation package. Please delete it if you wish to purchase another.";
                        lblDisplay.Visible = true;
                    }
                    else
                    {
                        ShowTripItems();
                    }
                    
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }

            }
        }


        public void ShowTripItems()
        {
            int totalQuantity = 0;
            double total = 0;

            string customerName = Session["LoginID"].ToString();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetTripItems";
            objCommand.Parameters.Clear();

            SqlParameter inputParameter = new SqlParameter("@CustomerName", customerName);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            gvPurchase.DataSource = objDB.GetDataSetUsingCmdObj(objCommand);
            gvPurchase.DataBind();

            for (int i = 0; i < gvPurchase.Rows.Count; i++)
            {
                totalQuantity = totalQuantity + int.Parse(gvPurchase.Rows[i].Cells[4].Text);
                total = total + double.Parse(gvPurchase.Rows[i].Cells[5].Text, NumberStyles.Currency);


                gvPurchase.Columns[0].FooterText = "Totals:";
                gvPurchase.Columns[4].FooterText = totalQuantity.ToString();
                gvPurchase.Columns[5].FooterText = total.ToString("C2");

                gvPurchase.DataBind();
            }
        }

        public void ShowVacationPackage()
        {
            string customerName = Session["LoginID"].ToString();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "getVacation";
            objCommand.Parameters.Clear(); 

            objCommand.Parameters.AddWithValue("@CustomerName", customerName);

            objDB.GetDataSetUsingCmdObj(objCommand);

            if (objDB.GetField("VacationPackage", 0) != System.DBNull.Value)
            {
                Byte[] byteArray = (Byte[])objDB.GetField("VacationPackage", 0);
                BinaryFormatter deSerializer = new BinaryFormatter();
                MemoryStream memStream = new MemoryStream(byteArray);

                Trip objTrip = (Trip)deSerializer.Deserialize(memStream);

                ArrayList arrTrip = new ArrayList();
                arrTrip.Add(objTrip);

                gvVacationPackage.DataSource = arrTrip;
                gvVacationPackage.DataBind();
            }
        }

        protected void btnPurchase_Click(object sender, EventArgs e)
        {
            string customerName = Session["LoginID"].ToString();

            int totalQuantity = 0;
            double total = 0;

            Trip objTrip = new Trip();

            for (int i = 0; i < gvPurchase.Rows.Count; i++)
            {
                if (gvPurchase.Rows[i].Cells[0].Text == "Car")
                {
                    objTrip.CarService = gvPurchase.Rows[i].Cells[1].Text;
                    objTrip.CarServiceDescription = gvPurchase.Rows[i].Cells[2].Text;
                }
                else if (gvPurchase.Rows[i].Cells[0].Text == "Air")
                {
                    objTrip.AirService = gvPurchase.Rows[i].Cells[1].Text;
                    objTrip.AirServiceDescription = gvPurchase.Rows[i].Cells[2].Text;
                }
                else if (gvPurchase.Rows[i].Cells[0].Text == "Hotel")
                {
                    objTrip.HotelService = gvPurchase.Rows[i].Cells[1].Text;
                    objTrip.HotelServiceDescription = gvPurchase.Rows[i].Cells[2].Text;
                }
                else if (gvPurchase.Rows[i].Cells[0].Text == "Activity")
                {
                    objTrip.ActivityService = gvPurchase.Rows[i].Cells[1].Text;
                    objTrip.ActivityServiceDescription = gvPurchase.Rows[i].Cells[2].Text;
                }

                totalQuantity = totalQuantity + int.Parse(gvPurchase.Rows[i].Cells[4].Text);
                total = total + double.Parse(gvPurchase.Rows[i].Cells[5].Text, NumberStyles.Currency);

                objTrip.Quantity = totalQuantity;
                objTrip.TotalSales = total;
                objTrip.CustomerName = customerName;

            }
            BinaryFormatter serializer = new BinaryFormatter();
            MemoryStream memStream = new MemoryStream();
            Byte[] byteArray;
            serializer.Serialize(memStream, objTrip);
            byteArray = memStream.ToArray();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "addVacation";

            objCommand.Parameters.AddWithValue("@CustomerName", customerName);
            objCommand.Parameters.AddWithValue("@VacationPackage", byteArray);


            int retVal = objDB.DoUpdateUsingCmdObj(objCommand);

            if (retVal > 0)
            {
                lblDisplay.Text = "You have successfully purchased a vacation package";
                lblDisplay.Visible = true;
                btnViewPurchase.Visible = true;
                btnPurchase.Visible = false;
                gvPurchase.Visible = false;

                //clears cart
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "clearTripItems";
                objCommand.Parameters.Clear();

                SqlParameter inputParameter = new SqlParameter("@CustomerName", customerName);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.VarChar;
                objCommand.Parameters.Add(inputParameter);

                objDB.DoUpdateUsingCmdObj(objCommand);
            }
            else
            {
                lblDisplay.Text = "Unable to purchase vacation package";
            }


        }

        protected void btnViewPurchase_Click(object sender, EventArgs e)
        {
            ShowVacationPackage();
        }

        protected void gvVacationPackage_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string customerName = Session["LoginID"].ToString();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "deleteVacation";
            objCommand.Parameters.Clear();

            SqlParameter inputParameter = new SqlParameter("@CustomerName", customerName);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            objDB.DoUpdateUsingCmdObj(objCommand);

            lblDisplay.Visible = true;
            lblDisplay.Text = "You have sucessfully deleted your vacation package.";

        }

        protected void btnSignOut_Click(object sender, EventArgs e)
        {
            Session["LoggedIn"] = "";
            Response.Redirect("Login.aspx");
        }
    }
}