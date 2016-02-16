namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.btnItems = new System.Windows.Forms.Button();
            this.dGW = new System.Windows.Forms.DataGridView();
            this.btnProducers = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnStorages = new System.Windows.Forms.Button();
            this.btnHardwares = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGW)).BeginInit();
            this.SuspendLayout();
            // 
            // btnItems
            // 
            this.btnItems.Location = new System.Drawing.Point(12, 12);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(75, 23);
            this.btnItems.TabIndex = 0;
            this.btnItems.Text = "Items";
            this.btnItems.UseVisualStyleBackColor = true;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // dGW
            // 
            this.dGW.AllowUserToAddRows = false;
            this.dGW.AllowUserToDeleteRows = false;
            this.dGW.AllowUserToResizeRows = false;
            this.dGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGW.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dGW.Location = new System.Drawing.Point(93, 13);
            this.dGW.MultiSelect = false;
            this.dGW.Name = "dGW";
            this.dGW.ReadOnly = true;
            this.dGW.RowHeadersVisible = false;
            this.dGW.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dGW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGW.ShowEditingIcon = false;
            this.dGW.Size = new System.Drawing.Size(552, 473);
            this.dGW.TabIndex = 1;
            // 
            // btnProducers
            // 
            this.btnProducers.Location = new System.Drawing.Point(12, 41);
            this.btnProducers.Name = "btnProducers";
            this.btnProducers.Size = new System.Drawing.Size(75, 23);
            this.btnProducers.TabIndex = 2;
            this.btnProducers.Text = "Producers";
            this.btnProducers.UseVisualStyleBackColor = true;
            this.btnProducers.Click += new System.EventHandler(this.btnProducers_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(651, 463);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(651, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(652, 41);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(652, 71);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnStorages
            // 
            this.btnStorages.Location = new System.Drawing.Point(12, 70);
            this.btnStorages.Name = "btnStorages";
            this.btnStorages.Size = new System.Drawing.Size(75, 23);
            this.btnStorages.TabIndex = 7;
            this.btnStorages.Text = "Storages";
            this.btnStorages.UseVisualStyleBackColor = true;
            this.btnStorages.Click += new System.EventHandler(this.btnStorages_Click);
            // 
            // btnHardwares
            // 
            this.btnHardwares.Location = new System.Drawing.Point(12, 99);
            this.btnHardwares.Name = "btnHardwares";
            this.btnHardwares.Size = new System.Drawing.Size(75, 23);
            this.btnHardwares.TabIndex = 8;
            this.btnHardwares.Text = "Hardwares";
            this.btnHardwares.UseVisualStyleBackColor = true;
            this.btnHardwares.Click += new System.EventHandler(this.btnHardwares_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(12, 128);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(75, 23);
            this.btnProducts.TabIndex = 9;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 498);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnHardwares);
            this.Controls.Add(this.btnStorages);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnProducers);
            this.Controls.Add(this.dGW);
            this.Controls.Add(this.btnItems);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dGW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.DataGridView dGW;
        private System.Windows.Forms.Button btnProducers;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnStorages;
        private System.Windows.Forms.Button btnHardwares;
        private System.Windows.Forms.Button btnProducts;
    }
}

