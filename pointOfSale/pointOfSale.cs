/**
* \file pointOfSale.cs
* \short INFO2110-Revenge of Wally
* \author Zach Walters
* \date 2016-12-8
* \brief A front-end application for a sql database
*        created before stored procedures were taught
*/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace pointOfSale {
    public partial class pointOfSale : Form {
        
        public static readonly string[] kMonths = { "0", "Jan.", "Feb.", "Mar.", "Apr.", "May", "Jun.",
                                                    "Jul.", "Aug.", "Sept.", "Oct.", "Nov.", "Dec." };

        private string order = string.Empty;
        bool orderOrCustomerOnScreen = false;



        public pointOfSale() {

            InitializeComponent();
            newOrderBranchComboBox.SelectedIndex = 0;
            newOrderPaymentStatusComboBox.SelectedIndex = 0;
            newOrderProductComboBox.SelectedIndex = 0;
            searchType.SelectedIndex = 0;

            this.searchGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.searchGridView_MouseDown);
            this.orderContextMenuPaid.Click += new System.EventHandler(this.orderPaid_Click);
            orderContextMenuCancel.Click += new System.EventHandler(this.orderCancel_Click);
            orderContextMenuRefund.Click += new System.EventHandler(this.orderRefund_Click);
            orderContextMenuUseForOrder.Click += new System.EventHandler(this.orderUseForOrder_Click);
        }



        /**
        * \brief <b>searchGridView_MouseDown</b> - display context menu
        * \details display context menu on right click on the search's DataGridView
        * \param object sender - reference to the object that raised the event.  not used
        * \param EventArgs e - contains event data,  used the get the mouse's location/selected row
        * \return none
        */
        private void searchGridView_MouseDown(object sender, MouseEventArgs e) {

            if (e.Button == MouseButtons.Right) {
                var hti = searchGridView.HitTest(e.X, e.Y);
                if ((hti.RowIndex >= 0) && (orderOrCustomerOnScreen == true)) {
                    searchGridView.ClearSelection();
                    searchGridView.Rows[hti.RowIndex].Selected = true;
                    Point pos = this.PointToClient(Cursor.Position);

                    enableDisableContextMenuItems(searchGridView.Rows[hti.RowIndex].Cells[2].Value.ToString());
                    orderContextMenu.Show(this, pos);
                }
            }
        }



        /**
        * \brief <b>customerAdd_Click</b> - add a customer to the database
        * \details validates the customer fields then builds a sql command to add them the the database then submits it.
        * \param object sender - reference to the object that raised the event.  not used
        * \param EventArgs e - contains event data,  not used
        * \return none
        */
        private void customerAdd_Click(object sender, EventArgs e) {

            if (Regex.IsMatch(customerFirstNameTextBox.Text, @"^[a-zA-Z'-]{1,20}$") == false) {

                customerFeedbackLabel.Text = "First name is invalid.";
            }
            else if (Regex.IsMatch(customerLastNameTextBox.Text, @"^[a-zA-Z'-]{1,20}$") == false) {

                customerFeedbackLabel.Text = "Last name is invalid.";
            }
            else if (Regex.IsMatch(customerPhoneNumberTextBox.Text, @"([() -]?[0-9][() -]?){10}") == false) {

                customerFeedbackLabel.Text = "Phone number is invalid.";
            }
            else {
                customerPhoneNumberTextBox.Text = Regex.Replace(customerPhoneNumberTextBox.Text, "[^0-9]+", "");
                customerPhoneNumberTextBox.Text = customerPhoneNumberTextBox.Text.Insert(6, "-");
                customerPhoneNumberTextBox.Text = customerPhoneNumberTextBox.Text.Insert(3, "-");

                string sqlCmd = string.Format("INSERT INTO customer (FirstName, LastName, PhoneNumber) VALUES ('{0}', '{1}', '{2}');",
                                        customerFirstNameTextBox.Text, customerLastNameTextBox.Text, customerPhoneNumberTextBox.Text);

                orderGrid.DataSource = submitQuerry(sqlCmd);
                StatusLabel.Text = "Customer has been added";
            }
        }



        /**
        * \brief <b>search_Click</b> - search the database
        * \details searches the database and displays what records were found
        * \param object sender - reference to the object that raised the event.  not used
        * \param EventArgs e - contains event data,  not used
        * \return none
        */
        private void search_Click(object sender, EventArgs e) {

            if (searchType.SelectedItem.ToString() == "Customer ID") {
                if (checkForDigits(ID.Text)) {
                    orderOrCustomerOnScreen = true;
                    searchCustomerByID(ID.Text);
                }
            }
            else if (searchType.SelectedItem.ToString() == "Customer Last Name") {

                orderOrCustomerOnScreen = true;
                searchCustomerByLastName(ID.Text);
            }
            else if (searchType.SelectedItem.ToString() == "Customer Phone Number") {

                orderOrCustomerOnScreen = true;
                searchCustomerByPhoneNumber(ID.Text);
            }
            else if (searchType.SelectedItem.ToString() == "Order ID") {
                if (checkForDigits(ID.Text)) {
                    orderOrCustomerOnScreen = true;
                    searchOrderByID(ID.Text);
                }
            }
            else if (searchType.SelectedItem.ToString() == "Product levels") {

                orderOrCustomerOnScreen = false;
                searchProductByID(ID.Text);
            }

        }



        #region Search Context Menu
        /**
        * \brief <b>updateOrder</b> - changes the status on an order
        * \details changes the status on an order, both in the ui and the database
        * \param string newStatus - the status the order is being changed to
        * \return int selectedRow - the row that the user selected, used for further modification by other methods
        */
        private int updateOrder(string newStatus) {

            Int32 selectedRow = searchGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            string ID = searchGridView.Rows[selectedRow].Cells[0].Value.ToString();
            string sqlCmd = string.Format("UPDATE _order SET _status = '{0}' where orderID = {1} limit 1;" +
                "select * from _order where orderID = {1};", newStatus, ID);

            searchGridView.DataSource = submitQuerry(sqlCmd);
            return selectedRow;
        }



        /**
        * \brief <b>checkForDigits</b> - checks if a string contains numbers
        * \details checks if a string contains numbers using regex
        * \param string text - the string to be checked
        * \return bool valid - indicates if the string contains numbers
        * \retval true - the string only contains numbers
        * \retval false -  the string doesn't only contains numbers
        */
        private bool checkForDigits(string text) {

            bool valid = false;

            if ((Regex.IsMatch(text, "^[0-9]?[0-9]?[0-9]?[0-9]?[0-9]$") == true) &&
                (Regex.IsMatch(text, "^0$") == false)) {

                valid = true;
            }

            return valid;
        }



        /**
        * \brief <b>orderPaid_Click</b> - change an order from pending to paid
        * \details change an order from pending to paid
        * \param object sender - reference to the object that raised the event.  not used
        * \param EventArgs e - contains event data,  not used
        * \return none
        */
        private void orderPaid_Click(object sender, EventArgs e) {

            Int32 selectedRow = updateOrder("PAID");
            string ID = searchGridView.Rows[selectedRow].Cells[0].Value.ToString();
            // get all the product that are in this order so I can update their quantity levels
            string getOrderLine = string.Format("select * from orderLine where orderID = {0};", ID);
            DataTable ds = submitQuerry(getOrderLine);

            string cmd = string.Empty;
            for (int i = 0; i < ds.Rows.Count; i++) {
                // update of quantity of products in the database
                cmd = string.Format("UPDATE products SET quantity = (quantity - {0}) where ProductID = '{1}';",
                    ds.Rows[i].Field<int>("quantity").ToString(), ds.Rows[i].Field<int>("ProductID").ToString());
            }
            submitQuerry(cmd);

            salesRecord sr = new salesRecord(createSalesRecord(Int32.Parse(ID)));
            sr.ShowDialog();
        }



        /**
        * \brief <b>orderPaid_Click</b> - change an order from pending to canceled
        * \details change an order from pending to canceled
        * \param object sender - reference to the object that raised the event.  not used
        * \param EventArgs e - contains event data,  not used
        * \return none
        */
        private void orderCancel_Click(object sender, EventArgs e) {
            
            updateOrder("CNCL");
        }



        /**
        * \brief <b>orderPaid_Click</b> - refunds a paid order
        * \details refunds a paid order and modifies the products inventory levels
        * \param object sender - reference to the object that raised the event.  not used
        * \param EventArgs e - contains event data,  not used
        * \return none
        */
        private void orderRefund_Click(object sender, EventArgs e) {

            Int32 selectedRow = searchGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            string ID = searchGridView.Rows[selectedRow].Cells[0].Value.ToString();
            string getOrderLine = string.Format("select * from orderLine where orderID = {0};", ID);

            DataTable ds = submitQuerry(getOrderLine);

            string cmd = string.Format("UPDATE orderLine SET quantity = 0 WHERE orderID = {0};", ID);
            cmd += string.Format("UPDATE _order SET _status = \"RFND\" WHERE orderID = {0};", ID);

            for (int i = 0; i < ds.Rows.Count; i++) {
                
                // update of quantity of products in the database
                cmd += string.Format("UPDATE products SET quantity = (quantity + {0}) WHERE ProductID = '{1}';",
                    ds.Rows[i].Field<int>("quantity").ToString(), ds.Rows[i].Field<int>("ProductID").ToString());
            }
            cmd += string.Format("select * from _order where orderID = {0};", ID);
            searchGridView.DataSource = submitQuerry(cmd);

            salesRecord sr = new salesRecord(createSalesRecord(Int32.Parse(ID)));
            sr.ShowDialog();

        }



        /**
        * \brief <b>orderUseForOrder_Click</b> - use the currently selected customer for a new order
        * \details use the currently selected customer for a new order and go to the order screen
        * \param object sender - reference to the object that raised the event.  not used
        * \param EventArgs e - contains event data,  not used
        * \return none
        */
        private void orderUseForOrder_Click(object sender, EventArgs e) {

            Int32 selectedRow = searchGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            string ID = searchGridView.Rows[selectedRow].Cells[0].Value.ToString();
            newOrderCustomerIDTextBox.Text = ID;
            POSTabs.SelectedIndex = 1;

        }
        #endregion


        
        #region ID Search
        /**
        * \brief <b>searchCustomerByID</b> - Search the database for a customer using their ID
        * \details Search the database for a customer using their ID and displays the results
        * \param string customerID - the customer's ID
        * \return none
        */
        private void searchCustomerByID(string customerID) {
            
            string sqlCmd = string.Format("select * from customer where customerID = {0};", customerID);

            searchGridView.DataSource = submitQuerry(sqlCmd);
        }



        /**
        * \brief <b>searchCustomerByLastName</b> - Search the database for a customer using their last name
        * \details Search the database for a customer using their last name and displays the results
        * \param string LastName - the customer's last name
        * \return none
        */
        private void searchCustomerByLastName(string LastName) {

            string sqlCmd = string.Format("SELECT * FROM customer WHERE LastName = \"{0}\" LIMIT 1;", LastName);

            searchGridView.DataSource = submitQuerry(sqlCmd);
        }



        /**
        * \brief <b>searchCustomerByPhoneNumber</b> - Search the database for a customer using their phone number
        * \details Search the database for a customer using their phone number and displays the results
        * \param string PhoneNumber - the customer's phone number
        * \return none
        */
        private void searchCustomerByPhoneNumber(string PhoneNumber) {

            string sqlCmd = string.Format("SELECT * FROM customer WHERE PhoneNumber = \"{0}\" LIMIT 1;", PhoneNumber);

            searchGridView.DataSource = submitQuerry(sqlCmd);
        }



        /**
        * \brief <b>searchOrderByID</b> - Search the database for a order using its ID
        * \details Search the database for a order using its ID and displays the results
        * \param string orderID - the ID of the order
        * \return none
        */
        private void searchOrderByID(string orderID) {

            string sqlCmd = string.Format("select * from _order where orderID = {0};", orderID);

            searchGridView.DataSource = submitQuerry(sqlCmd);
        }



        /**
        * \brief <b>searchProductByID</b> - Search the database for a order using its ID
        * \details Search the database for a product using its ID and displays the results,
        * if productID is blank it will display all products in the database
        * \param string productID - the ID of the product, can be blank
        * \return none
        */
        private void searchProductByID(string productID) {

            string sqlCmd = string.Format("select ProductName, quantity from products");

            if ((productID != null) && (productID != "")) {

                sqlCmd += string.Format(" where ProductID = {0}", productID);
            }
            sqlCmd += ";";
            searchGridView.DataSource = submitQuerry(sqlCmd);
        }
        #endregion



        #region New Order Buttons
        /**
        * \brief <b>orderNew_Click</b> - create a new order
        * \details create a new order, ready for accepting products
        * \param object sender - reference to the object that raised the event.  not used
        * \param EventArgs e - contains event data,  not used
        * \return none
        */
        private void orderNew_Click(object sender, EventArgs e) {

            newOrderCustomerIDTextBox.Enabled = false;
            newOrderDateTimePicker.Enabled = false;
            newOrderPaymentStatusComboBox.Enabled = false;
            newOrderBranchComboBox.Enabled = false;
            orderNew.Enabled = false;

            newOrderProductComboBox.Enabled = true;
            newOrderQuantityTextBox.Enabled = true;
            OrderItemNew.Enabled = true;
            cancelOrder.Enabled = true;

            order = string.Format("INSERT INTO _order(_date, _status, CustomerID, branchID) VALUES ('{0}', '{1}', {2}, {3});", 
                newOrderDateTimePicker.Value.ToString().Substring(0,10), newOrderPaymentStatusComboBox.SelectedItem.ToString(), 
                newOrderCustomerIDTextBox.Text, newOrderBranchComboBox.SelectedIndex + 1);
        }



        /**
        * \brief <b>OrderItemNew_Click</b> - add an item to the order
        * \details add an item to the order, and checks if there are enough items in the database
        * \param object sender - reference to the object that raised the event.  not used
        * \param EventArgs e - contains event data,  not used
        * \return none
        */
        private void OrderItemNew_Click(object sender, EventArgs e) {

            if (getInventoryLevels((newOrderProductComboBox.SelectedIndex + 1).ToString()) < Int32.Parse(newOrderQuantityTextBox.Text)) {

                order = Regex.Replace(order, @"'PAID'", "'PEND'");
                newOrderPaymentStatusComboBox.SelectedIndex = 1;
                StatusLabel.Text = "Order has been changed to Pending because inventory levels are too low";
            }

            order += string.Format("INSERT INTO orderLine(orderID, ProductID, quantity) VALUES({0}, {1}, {2});",
                "(SELECT COUNT(*) FROM _order)",
                newOrderProductComboBox.SelectedIndex + 1,
                newOrderQuantityTextBox.Text);

            orderGrid.Rows.Add(new object[3] { (newOrderProductComboBox.SelectedIndex + 1).ToString(), newOrderProductComboBox.SelectedItem.ToString(), newOrderQuantityTextBox.Text });
            
            completeOrder.Enabled = true;
        }



        /**
        * \brief <b>completeOrder_Click</b> - completes an order
        * \details completes an order and adds it to the database.  If the order is a paid order then the inventory levels are modified. 
        * \param object sender - reference to the object that raised the event.  not used
        * \param EventArgs e - contains event data,  not used
        * \return none
        */
        private void completeOrder_Click(object sender, EventArgs e) {

            // if order status is set to paid
            if (newOrderPaymentStatusComboBox.SelectedIndex == 0) {

                for (int i = 0; i < orderGrid.RowCount; i++) {

                    order += string.Format("UPDATE products SET quantity = (quantity - {0}) where ProductID = '{1}';", 
                        orderGrid.Rows[i].Cells["quantityColumn"].Value.ToString(), orderGrid.Rows[i].Cells["productIDColumn"].Value.ToString());
                }
            }
            order += string.Format("SELECT orderID FROM _order WHERE customerID = {0} ORDER BY orderID DESC LIMIT 1;", newOrderCustomerIDTextBox.Text);
            DataTable orderID = submitQuerry(order);

            salesRecord sr = new salesRecord(createSalesRecord(orderID.Rows[0].Field<int>("orderID")));
            sr.ShowDialog();

            order = string.Empty;
            orderGrid.Rows.Clear();

            newOrderCustomerIDTextBox.Text = string.Empty;
            newOrderQuantityTextBox.Text = string.Empty;

            newOrderCustomerIDTextBox.Enabled = true;
            newOrderDateTimePicker.Enabled = true;
            newOrderPaymentStatusComboBox.Enabled = true;
            newOrderBranchComboBox.Enabled = true;
            orderNew.Enabled = true;

            newOrderProductComboBox.Enabled = false;
            newOrderQuantityTextBox.Enabled = false;
            OrderItemNew.Enabled = false;
            cancelOrder.Enabled = false;
            completeOrder.Enabled = false;
        }




        /**
        * \brief <b>cancelOrder_Click</b> - cancels an order
        * \details cancels the order that is currently being made
        * \param object sender - reference to the object that raised the event.  not used
        * \param EventArgs e - contains event data,  not used
        * \return none
        */
        private void cancelOrder_Click(object sender, EventArgs e) {

            order = string.Empty;
            orderGrid.Rows.Clear();

            newOrderCustomerIDTextBox.Text = string.Empty;
            newOrderQuantityTextBox.Text = string.Empty;

            newOrderCustomerIDTextBox.Enabled = true;
            newOrderDateTimePicker.Enabled = true;
            newOrderPaymentStatusComboBox.Enabled = true;
            newOrderBranchComboBox.Enabled = true;
            orderNew.Enabled = true;

            newOrderProductComboBox.Enabled = false;
            newOrderQuantityTextBox.Enabled = false;
            OrderItemNew.Enabled = false;
            cancelOrder.Enabled = false;
            completeOrder.Enabled = false;
        }
        #endregion



        #region Utility
        /**
        * \brief <b>submitQuerry</b> - submits a querry to the database
        * \details connects to the database, submits a querry, then returns the result table if there is one.
        * \param string querry - A sql querry for the database
        * \return DataTable - A table containing the results of the querry 
        */
        private DataTable submitQuerry(string querry) {

            const string DB_CONN_STR = "Server=127.0.0.1;Uid=root;Pwd=Conestoga1;Database=ZWWally;";

            MySqlConnection cn = new MySqlConnection(DB_CONN_STR);

            DataTable dt = new DataTable();

            try {

                MySqlDataAdapter adr = new MySqlDataAdapter(querry, cn);
                adr.SelectCommand.CommandType = CommandType.Text;
                adr.Fill(dt);
            }
            catch (Exception ex) {
                Console.WriteLine("{0}", ex.Message);
            }
            finally {
                cn.Dispose();
            }

            return dt;
        }



        /**
        * \brief <b>createSalesRecord</b> - creates a sales record
        * \details creates a sales record based on the provided orderID
        * \param int orderID - the ID of the order
        * \return string salesRecord - a string containing the record of the sale
        */
        private string createSalesRecord(int orderID) {
            // get the meta data on a order including branch and customer information
            string getOrderData = string.Format("select * from _order " +
                                                "inner join customer " +
                                                "on _order.CustomerID = customer.CustomerID " +
                                                "inner join branch " +
                                                "on _order.branchID = branch.branchID " +
                                                "where orderID = {0};", orderID);
            // get all items in the order and product information on each item
            string getOrderLineData = string.Format("select * from orderline " +
                                                    "inner join products " +
                                                    "on orderline.ProductID = products.ProductID " +
                                                    "where orderID = {0};", orderID);

            DataTable orderMetaData = submitQuerry(getOrderData);
            DataTable orderLineData = submitQuerry(getOrderLineData);
            DateTime orderDate = orderMetaData.Rows[0].Field<DateTime>("_date");
            
            // fill in the meta data of the record
            string salesRecord = string.Format("Thank you for shopping at \n" +
                                "Wally’s World {0} \n" +
                                "On {1} {2}, {3}, {4} {5} \n" +
                                "Order ID: {6} \n\n",
                                orderMetaData.Rows[0].Field<string>("branchName"),
                                kMonths[orderDate.Month], orderDate.Day, orderDate.Year,
                                orderMetaData.Rows[0].Field<string>("FirstName"), orderMetaData.Rows[0].Field<string>("LastName"),
                                orderMetaData.Rows[0].Field<int>("orderID").ToString());

            double subtotal = 0;
            // add each item to the record and calculate the subtotal
            for (int i = 0; i < orderLineData.Rows.Count; i++) {

                double price = orderLineData.Rows[i].Field<double>("price");
                int quantity = orderLineData.Rows[i].Field<int>("quantity");

                salesRecord += string.Format("{0} {1} x ${2:0.00} = ${3:0.00} \n",
                    orderLineData.Rows[i].Field<string>("ProductName"),
                    quantity,
                    price,
                    (quantity * price));

                subtotal += (quantity * price);
            }

            salesRecord += string.Format("\nSubtotal = ${0:0.00}\n" +
                                        "HST(13 %) = ${1:0.00}\n" +
                                        "Sale Total = ${2:0.00}\n\n",
                                        subtotal, (subtotal * 0.13), (subtotal * 1.13));

            string status = orderMetaData.Rows[0].Field<string>("_status");

            switch (status) {
                case "PAID":
                    salesRecord += "Paid – Thank you!\n";
                    break;
                case "PEND":
                    salesRecord += "Pending – We’ll contact you soon!\n";
                    break;
                case "RFND":
                    salesRecord += "Refunded – Please come again!\n";
                    break;
            }

            return salesRecord;
        }



        /**
        * \brief <b>enableDisableContextMenuItems</b> - disable or enable items in the context menu
        * \details disable or enable items in the context menu based on the status of the selected order
        * \param string status - the current orders status
        * \return none
        */
        private void enableDisableContextMenuItems(string status) {

            orderContextMenuPaid.Visible = true;
            orderContextMenuCancel.Visible = true;
            orderContextMenuRefund.Visible = true;
            orderContextMenuUseForOrder.Visible = true;

            if (status == "PAID") {

                orderContextMenuPaid.Visible = false;
                orderContextMenuCancel.Visible = false;
                orderContextMenuUseForOrder.Visible = false;
            }
            else if (status == "PEND") {

                orderContextMenuRefund.Visible = false;
                orderContextMenuUseForOrder.Visible = false;
            }
            else if (status == "CNCL") {

                orderContextMenuPaid.Visible = false;
                orderContextMenuCancel.Visible = false;
                orderContextMenuRefund.Visible = false;
                orderContextMenuUseForOrder.Visible = false;
            }
            else if (Regex.IsMatch(status, @"^[a-zA-Z'-]{1,20}$") == true) {

                orderContextMenuPaid.Visible = false;
                orderContextMenuCancel.Visible = false;
                orderContextMenuRefund.Visible = false;
            }

        }



        /**
        * \brief <b>getInventoryLevels</b> - get the quantity level for a product
        * \details returns the quantity level for a productID
        * \param string productID - the ID of the product
        * \return the number of items for the product in the database
        */
        private int getInventoryLevels(string productID) {

            string sqlCmd = string.Format("SELECT quantity FROM products WHERE ProductID = {0}", productID);
            DataTable dt = submitQuerry(sqlCmd);
            
            return dt.Rows[0].Field<int>("quantity");
        }
        #endregion
    }
}
