namespace Muntakim_P00194964_Booking
{
    partial class frmRestaurant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRestaurant));
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btncancel = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.lblCharge = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCharge = new System.Windows.Forms.TextBox();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.gv1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Charge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btnAdd.ImageKey = "(none)";
            this.btnAdd.Location = new System.Drawing.Point(694, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 43);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContent.Controls.Add(this.btncancel);
            this.pnlContent.Controls.Add(this.btninsert);
            this.pnlContent.Controls.Add(this.lblCharge);
            this.pnlContent.Controls.Add(this.lblTable);
            this.pnlContent.Controls.Add(this.label2);
            this.pnlContent.Controls.Add(this.txtCharge);
            this.pnlContent.Controls.Add(this.txtTable);
            this.pnlContent.Controls.Add(this.txtID);
            this.pnlContent.Location = new System.Drawing.Point(229, 207);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(333, 155);
            this.pnlContent.TabIndex = 6;
            this.pnlContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContent_Paint);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(194, 118);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 9;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(32, 118);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 23);
            this.btninsert.TabIndex = 8;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // lblCharge
            // 
            this.lblCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCharge.Location = new System.Drawing.Point(32, 70);
            this.lblCharge.Name = "lblCharge";
            this.lblCharge.Size = new System.Drawing.Size(100, 23);
            this.lblCharge.TabIndex = 7;
            this.lblCharge.Text = "Charge :";
            this.lblCharge.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTable
            // 
            this.lblTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTable.Location = new System.Drawing.Point(32, 40);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(100, 23);
            this.lblTable.TabIndex = 5;
            this.lblTable.Text = "Table Size :";
            this.lblTable.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(32, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCharge
            // 
            this.txtCharge.Location = new System.Drawing.Point(194, 73);
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.Size = new System.Drawing.Size(100, 20);
            this.txtCharge.TabIndex = 3;
            // 
            // txtTable
            // 
            this.txtTable.Location = new System.Drawing.Point(194, 43);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(100, 20);
            this.txtTable.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(194, 11);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 0;
            // 
            // gv1
            // 
            this.gv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TSize,
            this.Charge,
            this.Edit,
            this.Delete});
            this.gv1.Location = new System.Drawing.Point(-3, 67);
            this.gv1.Name = "gv1";
            this.gv1.Size = new System.Drawing.Size(809, 158);
            this.gv1.TabIndex = 5;
            this.gv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // TSize
            // 
            this.TSize.HeaderText = "Table Size";
            this.TSize.Name = "TSize";
            // 
            // Charge
            // 
            this.Charge.HeaderText = "Charge";
            this.Charge.Name = "Charge";
            this.Charge.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 72);
            this.label1.TabIndex = 4;
            this.label1.Text = "Restaurant Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(100, 41);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(7, 41);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // frmRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.gv1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmRestaurant";
            this.Text = "frmRestaurant";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRestaurant_Load);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Label lblCharge;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCharge;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView gv1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Charge;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}