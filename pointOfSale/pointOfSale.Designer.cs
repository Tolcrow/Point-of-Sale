namespace pointOfSale {
    partial class pointOfSale {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.POSTabs = new System.Windows.Forms.TabControl();
            this.customerTab = new System.Windows.Forms.TabPage();
            this.customerFeedbackLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerAdd = new System.Windows.Forms.Button();
            this.customerPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.customerLastNameTextBox = new System.Windows.Forms.TextBox();
            this.customerFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.orderTab = new System.Windows.Forms.TabPage();
            this.orderGrid = new System.Windows.Forms.DataGridView();
            this.productIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.orderContextMenuPaid = new System.Windows.Forms.ToolStripMenuItem();
            this.orderContextMenuCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.orderContextMenuRefund = new System.Windows.Forms.ToolStripMenuItem();
            this.orderContextMenuUseForOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cancelOrder = new System.Windows.Forms.Button();
            this.completeOrder = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.newOrderPaymentStatusComboBox = new System.Windows.Forms.ComboBox();
            this.newOrderBranchComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.OrderItemNew = new System.Windows.Forms.Button();
            this.newOrderQuantityTextBox = new System.Windows.Forms.TextBox();
            this.newOrderProductComboBox = new System.Windows.Forms.ComboBox();
            this.newOrderDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.orderNew = new System.Windows.Forms.Button();
            this.newOrderCustomerIDTextBox = new System.Windows.Forms.TextBox();
            this.searchTab = new System.Windows.Forms.TabPage();
            this.searchGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.searchType = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.POSTabs.SuspendLayout();
            this.customerTab.SuspendLayout();
            this.orderTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).BeginInit();
            this.orderContextMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.searchTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(761, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 411);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(761, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // POSTabs
            // 
            this.POSTabs.Controls.Add(this.customerTab);
            this.POSTabs.Controls.Add(this.orderTab);
            this.POSTabs.Controls.Add(this.searchTab);
            this.POSTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.POSTabs.Location = new System.Drawing.Point(0, 24);
            this.POSTabs.Name = "POSTabs";
            this.POSTabs.SelectedIndex = 0;
            this.POSTabs.Size = new System.Drawing.Size(761, 387);
            this.POSTabs.TabIndex = 2;
            // 
            // customerTab
            // 
            this.customerTab.Controls.Add(this.customerFeedbackLabel);
            this.customerTab.Controls.Add(this.label4);
            this.customerTab.Controls.Add(this.label3);
            this.customerTab.Controls.Add(this.label2);
            this.customerTab.Controls.Add(this.customerAdd);
            this.customerTab.Controls.Add(this.customerPhoneNumberTextBox);
            this.customerTab.Controls.Add(this.customerLastNameTextBox);
            this.customerTab.Controls.Add(this.customerFirstNameTextBox);
            this.customerTab.Location = new System.Drawing.Point(4, 22);
            this.customerTab.Name = "customerTab";
            this.customerTab.Padding = new System.Windows.Forms.Padding(3);
            this.customerTab.Size = new System.Drawing.Size(753, 361);
            this.customerTab.TabIndex = 0;
            this.customerTab.Text = "Customer";
            this.customerTab.UseVisualStyleBackColor = true;
            // 
            // customerFeedbackLabel
            // 
            this.customerFeedbackLabel.AutoSize = true;
            this.customerFeedbackLabel.ForeColor = System.Drawing.Color.Red;
            this.customerFeedbackLabel.Location = new System.Drawing.Point(16, 186);
            this.customerFeedbackLabel.Name = "customerFeedbackLabel";
            this.customerFeedbackLabel.Size = new System.Drawing.Size(0, 13);
            this.customerFeedbackLabel.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "First Name";
            // 
            // customerAdd
            // 
            this.customerAdd.Location = new System.Drawing.Point(18, 160);
            this.customerAdd.Name = "customerAdd";
            this.customerAdd.Size = new System.Drawing.Size(115, 23);
            this.customerAdd.TabIndex = 21;
            this.customerAdd.Text = "Add New Customer";
            this.customerAdd.UseVisualStyleBackColor = true;
            this.customerAdd.Click += new System.EventHandler(this.customerAdd_Click);
            // 
            // customerPhoneNumberTextBox
            // 
            this.customerPhoneNumberTextBox.Location = new System.Drawing.Point(19, 124);
            this.customerPhoneNumberTextBox.Name = "customerPhoneNumberTextBox";
            this.customerPhoneNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.customerPhoneNumberTextBox.TabIndex = 19;
            // 
            // customerLastNameTextBox
            // 
            this.customerLastNameTextBox.Location = new System.Drawing.Point(19, 78);
            this.customerLastNameTextBox.Name = "customerLastNameTextBox";
            this.customerLastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.customerLastNameTextBox.TabIndex = 18;
            // 
            // customerFirstNameTextBox
            // 
            this.customerFirstNameTextBox.Location = new System.Drawing.Point(19, 33);
            this.customerFirstNameTextBox.Name = "customerFirstNameTextBox";
            this.customerFirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.customerFirstNameTextBox.TabIndex = 17;
            // 
            // orderTab
            // 
            this.orderTab.Controls.Add(this.orderGrid);
            this.orderTab.Controls.Add(this.panel2);
            this.orderTab.Location = new System.Drawing.Point(4, 22);
            this.orderTab.Name = "orderTab";
            this.orderTab.Padding = new System.Windows.Forms.Padding(3);
            this.orderTab.Size = new System.Drawing.Size(753, 361);
            this.orderTab.TabIndex = 1;
            this.orderTab.Text = "Orders";
            this.orderTab.UseVisualStyleBackColor = true;
            // 
            // orderGrid
            // 
            this.orderGrid.AllowUserToAddRows = false;
            this.orderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDColumn,
            this.productColumn,
            this.quantityColumn});
            this.orderGrid.ContextMenuStrip = this.orderContextMenu;
            this.orderGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.orderGrid.Location = new System.Drawing.Point(3, 116);
            this.orderGrid.Name = "orderGrid";
            this.orderGrid.Size = new System.Drawing.Size(747, 242);
            this.orderGrid.TabIndex = 9;
            // 
            // productIDColumn
            // 
            this.productIDColumn.HeaderText = "Product ID";
            this.productIDColumn.Name = "productIDColumn";
            // 
            // productColumn
            // 
            this.productColumn.HeaderText = "Product";
            this.productColumn.Name = "productColumn";
            this.productColumn.Width = 160;
            // 
            // quantityColumn
            // 
            this.quantityColumn.HeaderText = "Quantity";
            this.quantityColumn.Name = "quantityColumn";
            // 
            // orderContextMenu
            // 
            this.orderContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderContextMenuPaid,
            this.orderContextMenuCancel,
            this.orderContextMenuRefund,
            this.orderContextMenuUseForOrder});
            this.orderContextMenu.Name = "orderContextMenu";
            this.orderContextMenu.Size = new System.Drawing.Size(143, 92);
            // 
            // orderContextMenuPaid
            // 
            this.orderContextMenuPaid.Name = "orderContextMenuPaid";
            this.orderContextMenuPaid.Size = new System.Drawing.Size(142, 22);
            this.orderContextMenuPaid.Text = "Paid";
            // 
            // orderContextMenuCancel
            // 
            this.orderContextMenuCancel.Name = "orderContextMenuCancel";
            this.orderContextMenuCancel.Size = new System.Drawing.Size(142, 22);
            this.orderContextMenuCancel.Text = "Cancel";
            // 
            // orderContextMenuRefund
            // 
            this.orderContextMenuRefund.Name = "orderContextMenuRefund";
            this.orderContextMenuRefund.Size = new System.Drawing.Size(142, 22);
            this.orderContextMenuRefund.Text = "Refund";
            // 
            // orderContextMenuUseForOrder
            // 
            this.orderContextMenuUseForOrder.Name = "orderContextMenuUseForOrder";
            this.orderContextMenuUseForOrder.Size = new System.Drawing.Size(142, 22);
            this.orderContextMenuUseForOrder.Text = "Use for order";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cancelOrder);
            this.panel2.Controls.Add(this.completeOrder);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.newOrderPaymentStatusComboBox);
            this.panel2.Controls.Add(this.newOrderBranchComboBox);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.OrderItemNew);
            this.panel2.Controls.Add(this.newOrderQuantityTextBox);
            this.panel2.Controls.Add(this.newOrderProductComboBox);
            this.panel2.Controls.Add(this.newOrderDateTimePicker);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.orderNew);
            this.panel2.Controls.Add(this.newOrderCustomerIDTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(747, 113);
            this.panel2.TabIndex = 8;
            // 
            // cancelOrder
            // 
            this.cancelOrder.Enabled = false;
            this.cancelOrder.Location = new System.Drawing.Point(456, 74);
            this.cancelOrder.Name = "cancelOrder";
            this.cancelOrder.Size = new System.Drawing.Size(89, 23);
            this.cancelOrder.TabIndex = 29;
            this.cancelOrder.Text = "Cancel Order";
            this.cancelOrder.UseVisualStyleBackColor = true;
            this.cancelOrder.Click += new System.EventHandler(this.cancelOrder_Click);
            // 
            // completeOrder
            // 
            this.completeOrder.Enabled = false;
            this.completeOrder.Location = new System.Drawing.Point(551, 74);
            this.completeOrder.Name = "completeOrder";
            this.completeOrder.Size = new System.Drawing.Size(115, 23);
            this.completeOrder.TabIndex = 28;
            this.completeOrder.Text = "Complete Order";
            this.completeOrder.UseVisualStyleBackColor = true;
            this.completeOrder.Click += new System.EventHandler(this.completeOrder_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(424, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Payment Status";
            // 
            // newOrderPaymentStatusComboBox
            // 
            this.newOrderPaymentStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newOrderPaymentStatusComboBox.FormattingEnabled = true;
            this.newOrderPaymentStatusComboBox.Items.AddRange(new object[] {
            "PAID",
            "PEND"});
            this.newOrderPaymentStatusComboBox.Location = new System.Drawing.Point(424, 25);
            this.newOrderPaymentStatusComboBox.Name = "newOrderPaymentStatusComboBox";
            this.newOrderPaymentStatusComboBox.Size = new System.Drawing.Size(121, 21);
            this.newOrderPaymentStatusComboBox.TabIndex = 26;
            // 
            // newOrderBranchComboBox
            // 
            this.newOrderBranchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newOrderBranchComboBox.FormattingEnabled = true;
            this.newOrderBranchComboBox.Items.AddRange(new object[] {
            "Sports World",
            "Cambridge Mall",
            "St. Jacobs"});
            this.newOrderBranchComboBox.Location = new System.Drawing.Point(112, 25);
            this.newOrderBranchComboBox.Name = "newOrderBranchComboBox";
            this.newOrderBranchComboBox.Size = new System.Drawing.Size(100, 21);
            this.newOrderBranchComboBox.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(215, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(190, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Product";
            // 
            // OrderItemNew
            // 
            this.OrderItemNew.Enabled = false;
            this.OrderItemNew.Location = new System.Drawing.Point(299, 74);
            this.OrderItemNew.Name = "OrderItemNew";
            this.OrderItemNew.Size = new System.Drawing.Size(115, 23);
            this.OrderItemNew.TabIndex = 20;
            this.OrderItemNew.Text = "Add Item to Order";
            this.OrderItemNew.UseVisualStyleBackColor = true;
            this.OrderItemNew.Click += new System.EventHandler(this.OrderItemNew_Click);
            // 
            // newOrderQuantityTextBox
            // 
            this.newOrderQuantityTextBox.Enabled = false;
            this.newOrderQuantityTextBox.Location = new System.Drawing.Point(193, 77);
            this.newOrderQuantityTextBox.Name = "newOrderQuantityTextBox";
            this.newOrderQuantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.newOrderQuantityTextBox.TabIndex = 19;
            // 
            // newOrderProductComboBox
            // 
            this.newOrderProductComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newOrderProductComboBox.Enabled = false;
            this.newOrderProductComboBox.FormattingEnabled = true;
            this.newOrderProductComboBox.Items.AddRange(new object[] {
            "Disco Queen Wallpaper (roll)",
            "Countryside Wallpaper (roll)",
            "Victorian Lace Wallpaper (roll)",
            "Drywall Tape (roll)",
            "Drywall Tape (pkg 10)",
            "Drywall Repair Compound (tube)"});
            this.newOrderProductComboBox.Location = new System.Drawing.Point(6, 76);
            this.newOrderProductComboBox.Name = "newOrderProductComboBox";
            this.newOrderProductComboBox.Size = new System.Drawing.Size(181, 21);
            this.newOrderProductComboBox.TabIndex = 18;
            // 
            // newOrderDateTimePicker
            // 
            this.newOrderDateTimePicker.CausesValidation = false;
            this.newOrderDateTimePicker.Location = new System.Drawing.Point(218, 26);
            this.newOrderDateTimePicker.Name = "newOrderDateTimePicker";
            this.newOrderDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.newOrderDateTimePicker.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Branch";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Customer ID";
            // 
            // orderNew
            // 
            this.orderNew.Location = new System.Drawing.Point(551, 23);
            this.orderNew.Name = "orderNew";
            this.orderNew.Size = new System.Drawing.Size(115, 23);
            this.orderNew.TabIndex = 11;
            this.orderNew.Text = "Add New Order";
            this.orderNew.UseVisualStyleBackColor = true;
            this.orderNew.Click += new System.EventHandler(this.orderNew_Click);
            // 
            // newOrderCustomerIDTextBox
            // 
            this.newOrderCustomerIDTextBox.Location = new System.Drawing.Point(6, 26);
            this.newOrderCustomerIDTextBox.Name = "newOrderCustomerIDTextBox";
            this.newOrderCustomerIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.newOrderCustomerIDTextBox.TabIndex = 7;
            // 
            // searchTab
            // 
            this.searchTab.Controls.Add(this.searchGridView);
            this.searchTab.Controls.Add(this.panel3);
            this.searchTab.Location = new System.Drawing.Point(4, 22);
            this.searchTab.Name = "searchTab";
            this.searchTab.Size = new System.Drawing.Size(753, 361);
            this.searchTab.TabIndex = 2;
            this.searchTab.Text = "Search";
            this.searchTab.UseVisualStyleBackColor = true;
            // 
            // searchGridView
            // 
            this.searchGridView.AllowUserToAddRows = false;
            this.searchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.searchGridView.Location = new System.Drawing.Point(0, 59);
            this.searchGridView.Name = "searchGridView";
            this.searchGridView.Size = new System.Drawing.Size(753, 302);
            this.searchGridView.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.searchType);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.search);
            this.panel3.Controls.Add(this.ID);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(753, 59);
            this.panel3.TabIndex = 9;
            // 
            // searchType
            // 
            this.searchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchType.FormattingEnabled = true;
            this.searchType.Items.AddRange(new object[] {
            "Customer ID",
            "Customer Last Name",
            "Customer Phone Number",
            "Orders ID",
            "Product levels"});
            this.searchType.Location = new System.Drawing.Point(195, 22);
            this.searchType.Name = "searchType";
            this.searchType.Size = new System.Drawing.Size(121, 21);
            this.searchType.TabIndex = 14;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 8);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(18, 13);
            this.label20.TabIndex = 12;
            this.label20.Text = "ID";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(114, 22);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 10;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(8, 24);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 20);
            this.ID.TabIndex = 6;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // pointOfSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 433);
            this.Controls.Add(this.POSTabs);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "pointOfSale";
            this.Text = "Point of Sale";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.POSTabs.ResumeLayout(false);
            this.customerTab.ResumeLayout(false);
            this.customerTab.PerformLayout();
            this.orderTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).EndInit();
            this.orderContextMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.searchTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TabControl POSTabs;
        private System.Windows.Forms.TabPage customerTab;
        private System.Windows.Forms.TabPage orderTab;
        private System.Windows.Forms.DataGridView orderGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker newOrderDateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button orderNew;
        private System.Windows.Forms.TextBox newOrderCustomerIDTextBox;
        private System.Windows.Forms.ComboBox newOrderBranchComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button OrderItemNew;
        private System.Windows.Forms.TextBox newOrderQuantityTextBox;
        private System.Windows.Forms.ComboBox newOrderProductComboBox;
        private System.Windows.Forms.ComboBox newOrderPaymentStatusComboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip orderContextMenu;
        private System.Windows.Forms.ToolStripMenuItem orderContextMenuPaid;
        private System.Windows.Forms.TabPage searchTab;
        private System.Windows.Forms.DataGridView searchGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.ToolStripMenuItem orderContextMenuCancel;
        private System.Windows.Forms.ComboBox searchType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button customerAdd;
        private System.Windows.Forms.TextBox customerPhoneNumberTextBox;
        private System.Windows.Forms.TextBox customerLastNameTextBox;
        private System.Windows.Forms.TextBox customerFirstNameTextBox;
        private System.Windows.Forms.Button completeOrder;
        private System.Windows.Forms.Button cancelOrder;
        private System.Windows.Forms.ToolStripMenuItem orderContextMenuRefund;
        private System.Windows.Forms.Label customerFeedbackLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
        private System.Windows.Forms.ToolStripMenuItem orderContextMenuUseForOrder;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
    }
}

