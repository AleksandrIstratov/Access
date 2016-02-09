namespace WindowsFormsApplication1
{
    partial class FProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lItemName = new System.Windows.Forms.Label();
            this.cbItemName = new System.Windows.Forms.ComboBox();
            this.lSerialNumber = new System.Windows.Forms.Label();
            this.tbSerialNumber = new System.Windows.Forms.TextBox();
            this.lProductionDate = new System.Windows.Forms.Label();
            this.dtProductionDate = new System.Windows.Forms.DateTimePicker();
            this.lPurchaseDate = new System.Windows.Forms.Label();
            this.dtPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(208, 304);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(208, 275);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(13, 13);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(73, 13);
            this.lName.TabIndex = 2;
            this.lName.Text = "Product name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(16, 30);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(209, 20);
            this.tbName.TabIndex = 3;
            // 
            // lItemName
            // 
            this.lItemName.AutoSize = true;
            this.lItemName.Location = new System.Drawing.Point(12, 58);
            this.lItemName.Name = "lItemName";
            this.lItemName.Size = new System.Drawing.Size(56, 13);
            this.lItemName.TabIndex = 4;
            this.lItemName.Text = "Item name";
            // 
            // cbItemName
            // 
            this.cbItemName.FormattingEnabled = true;
            this.cbItemName.Location = new System.Drawing.Point(16, 74);
            this.cbItemName.Name = "cbItemName";
            this.cbItemName.Size = new System.Drawing.Size(209, 21);
            this.cbItemName.TabIndex = 5;
            // 
            // lSerialNumber
            // 
            this.lSerialNumber.AutoSize = true;
            this.lSerialNumber.Location = new System.Drawing.Point(13, 102);
            this.lSerialNumber.Name = "lSerialNumber";
            this.lSerialNumber.Size = new System.Drawing.Size(71, 13);
            this.lSerialNumber.TabIndex = 6;
            this.lSerialNumber.Text = "Serial number";
            // 
            // tbSerialNumber
            // 
            this.tbSerialNumber.Location = new System.Drawing.Point(15, 119);
            this.tbSerialNumber.Name = "tbSerialNumber";
            this.tbSerialNumber.Size = new System.Drawing.Size(210, 20);
            this.tbSerialNumber.TabIndex = 7;
            // 
            // lProductionDate
            // 
            this.lProductionDate.AutoSize = true;
            this.lProductionDate.Location = new System.Drawing.Point(13, 154);
            this.lProductionDate.Name = "lProductionDate";
            this.lProductionDate.Size = new System.Drawing.Size(82, 13);
            this.lProductionDate.TabIndex = 8;
            this.lProductionDate.Text = "Production date";
            // 
            // dtProductionDate
            // 
            this.dtProductionDate.Location = new System.Drawing.Point(13, 171);
            this.dtProductionDate.Name = "dtProductionDate";
            this.dtProductionDate.Size = new System.Drawing.Size(200, 20);
            this.dtProductionDate.TabIndex = 9;
            // 
            // lPurchaseDate
            // 
            this.lPurchaseDate.AutoSize = true;
            this.lPurchaseDate.Location = new System.Drawing.Point(13, 212);
            this.lPurchaseDate.Name = "lPurchaseDate";
            this.lPurchaseDate.Size = new System.Drawing.Size(76, 13);
            this.lPurchaseDate.TabIndex = 10;
            this.lPurchaseDate.Text = "Purchase date";
            // 
            // dtPurchaseDate
            // 
            this.dtPurchaseDate.Location = new System.Drawing.Point(13, 229);
            this.dtPurchaseDate.Name = "dtPurchaseDate";
            this.dtPurchaseDate.Size = new System.Drawing.Size(200, 20);
            this.dtPurchaseDate.TabIndex = 11;
            // 
            // FProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(295, 339);
            this.Controls.Add(this.dtPurchaseDate);
            this.Controls.Add(this.lPurchaseDate);
            this.Controls.Add(this.dtProductionDate);
            this.Controls.Add(this.lProductionDate);
            this.Controls.Add(this.tbSerialNumber);
            this.Controls.Add(this.lSerialNumber);
            this.Controls.Add(this.cbItemName);
            this.Controls.Add(this.lItemName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FProducts";
            this.Text = "FProducts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lItemName;
        private System.Windows.Forms.ComboBox cbItemName;
        private System.Windows.Forms.Label lSerialNumber;
        private System.Windows.Forms.TextBox tbSerialNumber;
        private System.Windows.Forms.Label lProductionDate;
        private System.Windows.Forms.DateTimePicker dtProductionDate;
        private System.Windows.Forms.Label lPurchaseDate;
        private System.Windows.Forms.DateTimePicker dtPurchaseDate;
    }
}