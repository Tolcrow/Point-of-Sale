namespace pointOfSale {
    partial class salesRecord {
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
            this.salesRecordTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // salesRecordTextBox
            // 
            this.salesRecordTextBox.Location = new System.Drawing.Point(12, 12);
            this.salesRecordTextBox.Name = "salesRecordTextBox";
            this.salesRecordTextBox.ReadOnly = true;
            this.salesRecordTextBox.Size = new System.Drawing.Size(338, 479);
            this.salesRecordTextBox.TabIndex = 0;
            this.salesRecordTextBox.Text = "";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(144, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "ok";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // salesRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 532);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.salesRecordTextBox);
            this.Name = "salesRecord";
            this.Text = "Sales Record";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox salesRecordTextBox;
        private System.Windows.Forms.Button button1;
    }
}