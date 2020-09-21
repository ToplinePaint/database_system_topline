namespace database_app_test
{
    partial class Orders
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
            this.closeOrders = new FontAwesome.Sharp.IconButton();
            this.orderViewer = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.orderslabel1 = new System.Windows.Forms.Label();
            this.cbxSupplier = new System.Windows.Forms.ComboBox();
            this.orderslabel2 = new System.Windows.Forms.Label();
            this.cbxMaterial = new System.Windows.Forms.ComboBox();
            this.orderslabel3 = new System.Windows.Forms.Label();
            this.orderslabel4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.orderViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // closeOrders
            // 
            this.closeOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeOrders.FlatAppearance.BorderSize = 0;
            this.closeOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeOrders.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.closeOrders.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.closeOrders.IconColor = System.Drawing.Color.Black;
            this.closeOrders.IconSize = 30;
            this.closeOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeOrders.Location = new System.Drawing.Point(0, 0);
            this.closeOrders.Name = "closeOrders";
            this.closeOrders.Rotation = 0D;
            this.closeOrders.Size = new System.Drawing.Size(30, 31);
            this.closeOrders.TabIndex = 0;
            this.closeOrders.UseVisualStyleBackColor = true;
            this.closeOrders.Click += new System.EventHandler(this.closeOrders_Click);
            // 
            // orderViewer
            // 
            this.orderViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderViewer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.orderViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderViewer.Location = new System.Drawing.Point(12, 288);
            this.orderViewer.Name = "orderViewer";
            this.orderViewer.Size = new System.Drawing.Size(526, 150);
            this.orderViewer.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.textBox1.Location = new System.Drawing.Point(12, 208);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(526, 58);
            this.textBox1.TabIndex = 2;
            // 
            // orderslabel1
            // 
            this.orderslabel1.AutoSize = true;
            this.orderslabel1.Location = new System.Drawing.Point(13, 269);
            this.orderslabel1.Name = "orderslabel1";
            this.orderslabel1.Size = new System.Drawing.Size(58, 13);
            this.orderslabel1.TabIndex = 3;
            this.orderslabel1.Text = "Final Order";
            // 
            // cbxSupplier
            // 
            this.cbxSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.cbxSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.cbxSupplier.FormattingEnabled = true;
            this.cbxSupplier.Location = new System.Drawing.Point(12, 65);
            this.cbxSupplier.Name = "cbxSupplier";
            this.cbxSupplier.Size = new System.Drawing.Size(144, 21);
            this.cbxSupplier.TabIndex = 4;
            this.cbxSupplier.SelectedIndexChanged += new System.EventHandler(this.cbxSupplier_SelectedIndexChanged);
            // 
            // orderslabel2
            // 
            this.orderslabel2.AutoSize = true;
            this.orderslabel2.Location = new System.Drawing.Point(159, 49);
            this.orderslabel2.Name = "orderslabel2";
            this.orderslabel2.Size = new System.Drawing.Size(83, 13);
            this.orderslabel2.TabIndex = 5;
            this.orderslabel2.Text = "Choose Material";
            // 
            // cbxMaterial
            // 
            this.cbxMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.cbxMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxMaterial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.cbxMaterial.FormattingEnabled = true;
            this.cbxMaterial.Location = new System.Drawing.Point(162, 65);
            this.cbxMaterial.Name = "cbxMaterial";
            this.cbxMaterial.Size = new System.Drawing.Size(376, 21);
            this.cbxMaterial.TabIndex = 6;
            // 
            // orderslabel3
            // 
            this.orderslabel3.AutoSize = true;
            this.orderslabel3.Location = new System.Drawing.Point(12, 49);
            this.orderslabel3.Name = "orderslabel3";
            this.orderslabel3.Size = new System.Drawing.Size(84, 13);
            this.orderslabel3.TabIndex = 9;
            this.orderslabel3.Text = "Choose Supplier";
            // 
            // orderslabel4
            // 
            this.orderslabel4.AutoSize = true;
            this.orderslabel4.Location = new System.Drawing.Point(13, 192);
            this.orderslabel4.Name = "orderslabel4";
            this.orderslabel4.Size = new System.Drawing.Size(64, 13);
            this.orderslabel4.TabIndex = 10;
            this.orderslabel4.Text = "Order Notes";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 130);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.orderslabel4);
            this.Controls.Add(this.orderslabel3);
            this.Controls.Add(this.cbxMaterial);
            this.Controls.Add(this.orderslabel2);
            this.Controls.Add(this.cbxSupplier);
            this.Controls.Add(this.orderslabel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.orderViewer);
            this.Controls.Add(this.closeOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Orders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton closeOrders;
        private System.Windows.Forms.DataGridView orderViewer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label orderslabel1;
        private System.Windows.Forms.ComboBox cbxSupplier;
        private System.Windows.Forms.Label orderslabel2;
        private System.Windows.Forms.ComboBox cbxMaterial;
        private System.Windows.Forms.Label orderslabel3;
        private System.Windows.Forms.Label orderslabel4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}