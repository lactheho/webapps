using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Utilities;
using PizzaLibrary;
using System.Collections;

namespace Project2
{
    public partial class Pizza : System.Web.UI.Page
    {
        //initialize and instantiate objects
        static DBConnect objDB = new DBConnect();                         
        PizzaFunctions pizzaFunctions = new PizzaFunctions(objDB);
        ArrayList arrPizza = new ArrayList();


        //pageload
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                //retrieves PizzaType from database and binds to gridview
                String strSQL = "SELECT PizzaType FROM Pizza";
                gvPizzaInput.DataSource = objDB.GetDataSet(strSQL);
                gvPizzaInput.DataBind();

                //hides labels
                lblValidateCheckbox.Visible = false;
                lblValidateQuantity.Visible = false;
                lblThankYou.Visible = false;
            }
            lblValidateCheckbox.Visible = false;
            lblValidateQuantity.Visible = false;
    
        }

        //retrieves all value inputted by user and stores them in a Pizza object, then added to an arraylist
        public void getValues()
        {
            //init variables
            double basePrice = 0.0;
            String pizzaType = "";
            String size = "";
            int quantity = 0;
            double price = 0.0;
            double totalCost = 0.0;
            PizzaOrder objPizzaOrder;

            //goes through each row of the gridview
            for (int row = 0; row < gvPizzaInput.Rows.Count; row++)
            {
                CheckBox CBox;
                DropDownList DDL;
                TextBox TBox;
                CBox = (CheckBox)gvPizzaInput.Rows[row].FindControl("chkPizzaType");

                //if a pizza type is selected
                if (CBox.Checked)
                {
                    
                        objPizzaOrder = new PizzaOrder();               //instantiate pizzaOrder object
                    
                        //retrieves the pizza type the user selected
                        //String pizzaType = "";
                        pizzaType = gvPizzaInput.Rows[row].Cells[1].Text;
                        String strSQL = "SELECT BasePrice FROM Pizza WHERE PizzaType='" + pizzaType + "'";

                        //retrieves the base price from the db based on selected pizza type
                        DataSet basePriceData = objDB.GetDataSet(strSQL);
                        basePrice = Convert.ToDouble(objDB.GetField("BasePrice", 0));

                        //retrieves the size the user selected from in the gridiview
                        DDL = (DropDownList)gvPizzaInput.Rows[row].FindControl("ddlSize");
                        size = DDL.SelectedValue;

                        //retrieves the quantity the user inputed in the gridview
                        TBox = (TextBox)gvPizzaInput.Rows[row].FindControl("txtQuantity");
                        quantity = Convert.ToInt32(TBox.Text);

                        //calculates price (base price * size)
                        price = pizzaFunctions.computePrice(basePrice, size);

                        //calculates totalCost of the pizza type
                        totalCost = price * quantity;
                        
                        //stores all five element into PizzaOrder object
                        objPizzaOrder.PizzaType = pizzaType;
                        objPizzaOrder.Size = size;
                        objPizzaOrder.Quantity = quantity;
                        objPizzaOrder.Price = price;
                        objPizzaOrder.TotalCost = totalCost;

                        //stores PizzaOrder object into pizza arraylist
                        arrPizza.Add(objPizzaOrder);
                }
            }
        }

        //calculates totals of quantity and cost to put in footer, then binds array to the output gridview
        public void showPizzaOrder()
        {
            int totalQuantity = 0;
            double totalCost = 0;
            PizzaOrder pizzaOrder;
            for (int i = 0; i < arrPizza.Count; i++)
            {
                pizzaOrder = (PizzaOrder)arrPizza[i];
                totalQuantity = totalQuantity + pizzaOrder.Quantity;
                totalCost = totalCost + pizzaOrder.TotalCost;
            }

            gvPizzaOutput.Columns[0].FooterText = "Total";
            gvPizzaOutput.Columns[2].FooterText = totalQuantity.ToString();
            gvPizzaOutput.Columns[4].FooterText = totalCost.ToString();

            gvPizzaOutput.DataSource = arrPizza;
            gvPizzaOutput.DataBind();
        }

        //binds pizzatype, totalquantity, and totalsales from database to the gridview
        public void showManagementReport()
        {
            String strSQL = "SELECT PizzaType, TotalQuantityOrdered, TotalSales FROM Pizza ORDER BY PizzaType DESC";
            gvManagementReport.DataSource = objDB.GetDataSet(strSQL);
            gvManagementReport.DataBind();
        }

        //checks to make sure at least one pizza type is selected
      public bool validateCheckBox()
        {
            bool check = false;
            for (int row = 0; row < gvPizzaInput.Rows.Count; row++)
            {
                CheckBox CBox; 
                CBox = (CheckBox)gvPizzaInput.Rows[row].FindControl("chkPizzaType");

                
                if (CBox.Checked)
                {
                    check = true;
                    break;
                }
            }
                if (check == false)
                {
                lblValidateCheckbox.Text = "Select at least one pizza type.";
                lblValidateCheckbox.Visible = true;
                    return false;
                }
            return true;
        }

        //checks to see if a value is entered in the quantity textbox is the pizza type is selected
        public bool validateQuantity()
        {
            bool check = false; 
            for (int row = 0; row < gvPizzaInput.Rows.Count; row++)
            {
                CheckBox CBox;
                TextBox TBox;
                CBox = (CheckBox)gvPizzaInput.Rows[row].FindControl("chkPizzaType");
                TBox = (TextBox)gvPizzaInput.Rows[row].FindControl("txtQuantity");
                if (CBox.Checked)
                {
                    if(TBox.Text != "")
                    {
                        
                    }
                    else
                    {
                        lblValidateQuantity.Text = "You must enter a quantity for the selected pizza type.";
                        lblValidateQuantity.Visible = true;
                        return false;
                    }
                }
            }
            return true;
        }

        //checks if value in quantity textbox is an integer
        public bool IsInt()
        {
            bool check = false;
            for (int row = 0; row < gvPizzaInput.Rows.Count; row++)
            {
                TextBox Tbox;
                Tbox = (TextBox)gvPizzaInput.Rows[row].FindControl("txtQuantity");
                int num = 0;
                check = Int32.TryParse(Tbox.Text, out num);
                if (check)
                {
                   
                }
                else
                {
                    return false;
                }
            }
            return check;
        }


        //event handler for submit button
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if(Page.IsValid && validateCheckBox() && validateQuantity())
            {
                gvPizzaInput.Visible = false;                   //hides input gridview
                getValues();                                    //gets values and stores them in an arraylist 
                showPizzaOrder();                               //display output gridview
                pizzaFunctions.updateSalesQuantity(arrPizza);   //update database
                showManagementReport();                         //display management report
                lblThankYou.Visible = true;
            }
        }


    }
}