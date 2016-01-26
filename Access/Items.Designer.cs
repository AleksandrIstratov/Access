namespace WindowsFormsApplication1
{
    partial class Items
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
            this.components = new System.ComponentModel.Container();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.tbOrderPrefix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chbMachineBit = new System.Windows.Forms.CheckBox();
            this.cbProducer = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.picBItem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBItem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.Location = new System.Drawing.Point(387, 440);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(387, 411);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Order prefix";
            // 
            // tbItemName
            // 
            this.tbItemName.Location = new System.Drawing.Point(12, 29);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(161, 20);
            this.tbItemName.TabIndex = 4;
            // 
            // tbOrderPrefix
            // 
            this.tbOrderPrefix.Location = new System.Drawing.Point(12, 81);
            this.tbOrderPrefix.Name = "tbOrderPrefix";
            this.tbOrderPrefix.Size = new System.Drawing.Size(362, 20);
            this.tbOrderPrefix.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Producer";
            // 
            // chbMachineBit
            // 
            this.chbMachineBit.AutoSize = true;
            this.chbMachineBit.Location = new System.Drawing.Point(12, 165);
            this.chbMachineBit.Name = "chbMachineBit";
            this.chbMachineBit.Size = new System.Drawing.Size(67, 17);
            this.chbMachineBit.TabIndex = 7;
            this.chbMachineBit.Text = "Machine";
            this.chbMachineBit.UseVisualStyleBackColor = true;
            // 
            // cbProducer
            // 
            this.cbProducer.FormattingEnabled = true;
            this.cbProducer.Location = new System.Drawing.Point(12, 138);
            this.cbProducer.Name = "cbProducer";
            this.cbProducer.Size = new System.Drawing.Size(362, 21);
            this.cbProducer.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // picBItem
            // 
            this.picBItem.Location = new System.Drawing.Point(12, 188);
            this.picBItem.Name = "picBItem";
            this.picBItem.Size = new System.Drawing.Size(362, 275);
            this.picBItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBItem.TabIndex = 10;
            this.picBItem.TabStop = false;
            this.picBItem.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 475);
            this.Controls.Add(this.picBItem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbProducer);
            this.Controls.Add(this.chbMachineBit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbOrderPrefix);
            this.Controls.Add(this.tbItemName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Name = "Items";
            this.Text = "Items";
            ((System.ComponentModel.ISupportInitialize)(this.picBItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.TextBox tbOrderPrefix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbMachineBit;
        private System.Windows.Forms.ComboBox cbProducer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox picBItem;
    }
}