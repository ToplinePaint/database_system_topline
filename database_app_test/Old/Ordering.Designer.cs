namespace database_app_test
{
    partial class Ordering
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
            this.orderingHead = new System.Windows.Forms.Panel();
            this.OrderingHeadLabel = new System.Windows.Forms.Label();
            this.closeOrdering = new FontAwesome.Sharp.IconButton();
            this.suppSearcher = new System.Windows.Forms.TextBox();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.supSLabel = new System.Windows.Forms.Label();
            this.cbxSupName = new System.Windows.Forms.ComboBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.orderingHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // orderingHead
            // 
            this.orderingHead.Controls.Add(this.OrderingHeadLabel);
            this.orderingHead.Controls.Add(this.closeOrdering);
            this.orderingHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.orderingHead.Location = new System.Drawing.Point(0, 0);
            this.orderingHead.Name = "orderingHead";
            this.orderingHead.Size = new System.Drawing.Size(822, 60);
            this.orderingHead.TabIndex = 16;
            // 
            // OrderingHeadLabel
            // 
            this.OrderingHeadLabel.AutoSize = true;
            this.OrderingHeadLabel.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.OrderingHeadLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.OrderingHeadLabel.Location = new System.Drawing.Point(319, 9);
            this.OrderingHeadLabel.Name = "OrderingHeadLabel";
            this.OrderingHeadLabel.Size = new System.Drawing.Size(157, 39);
            this.OrderingHeadLabel.TabIndex = 1;
            this.OrderingHeadLabel.Text = "Ordering";
            // 
            // closeOrdering
            // 
            this.closeOrdering.Dock = System.Windows.Forms.DockStyle.Left;
            this.closeOrdering.FlatAppearance.BorderSize = 0;
            this.closeOrdering.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(85)))));
            this.closeOrdering.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeOrdering.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.closeOrdering.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.closeOrdering.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.closeOrdering.IconSize = 28;
            this.closeOrdering.Location = new System.Drawing.Point(0, 0);
            this.closeOrdering.Name = "closeOrdering";
            this.closeOrdering.Rotation = 0D;
            this.closeOrdering.Size = new System.Drawing.Size(70, 60);
            this.closeOrdering.TabIndex = 0;
            this.closeOrdering.UseVisualStyleBackColor = true;
            this.closeOrdering.Click += new System.EventHandler(this.closeOrdering_Click);
            // 
            // suppSearcher
            // 
            this.suppSearcher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(85)))));
            this.suppSearcher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.suppSearcher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.suppSearcher.Location = new System.Drawing.Point(83, 136);
            this.suppSearcher.Name = "suppSearcher";
            this.suppSearcher.Size = new System.Drawing.Size(459, 20);
            this.suppSearcher.TabIndex = 21;
            this.suppSearcher.Text = "Search Materials";
            // 
            // cmdSearch
            // 
            this.cmdSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(85)))));
            this.cmdSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(85)))));
            this.cmdSearch.FlatAppearance.BorderSize = 0;
            this.cmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.cmdSearch.Location = new System.Drawing.Point(548, 118);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(150, 20);
            this.cmdSearch.TabIndex = 20;
            this.cmdSearch.Text = "Get Materials";
            this.cmdSearch.UseVisualStyleBackColor = false;
            // 
            // supSLabel
            // 
            this.supSLabel.AutoSize = true;
            this.supSLabel.BackColor = System.Drawing.Color.Transparent;
            this.supSLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.supSLabel.Location = new System.Drawing.Point(80, 88);
            this.supSLabel.Name = "supSLabel";
            this.supSLabel.Size = new System.Drawing.Size(81, 13);
            this.supSLabel.TabIndex = 19;
            this.supSLabel.Text = "Select Supplier:";
            // 
            // cbxSupName
            // 
            this.cbxSupName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(85)))));
            this.cbxSupName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxSupName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSupName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxSupName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.cbxSupName.FormattingEnabled = true;
            this.cbxSupName.Location = new System.Drawing.Point(83, 104);
            this.cbxSupName.Name = "cbxSupName";
            this.cbxSupName.Size = new System.Drawing.Size(459, 21);
            this.cbxSupName.TabIndex = 18;
            // 
            // dgvData
            // 
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(88)))), ((int)(((byte)(99)))));
            this.dgvData.Location = new System.Drawing.Point(83, 162);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(637, 422);
            this.dgvData.TabIndex = 17;
            // 
            // Ordering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(822, 596);
            this.Controls.Add(this.suppSearcher);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.supSLabel);
            this.Controls.Add(this.cbxSupName);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.orderingHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ordering";
            this.Text = "Ordering";
            this.orderingHead.ResumeLayout(false);
            this.orderingHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel orderingHead;
        private System.Windows.Forms.Label OrderingHeadLabel;
        private FontAwesome.Sharp.IconButton closeOrdering;
        private System.Windows.Forms.TextBox suppSearcher;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.Label supSLabel;
        private System.Windows.Forms.ComboBox cbxSupName;
        private System.Windows.Forms.DataGridView dgvData;
    }
}