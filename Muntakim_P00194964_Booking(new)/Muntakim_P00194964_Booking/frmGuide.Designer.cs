namespace Muntakim_P00194964_Booking
{
    partial class frmGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuide));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtCharge = new System.Windows.Forms.TextBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.txtGuidename = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblCharge = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            this.lblGuidename = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.GV = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblGuide = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GV)).BeginInit();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(180, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 10;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(208, 185);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 22);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.Control;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.Black;
            this.btnInsert.Location = new System.Drawing.Point(117, 185);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(70, 22);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Insert";
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtCharge
            // 
            this.txtCharge.BackColor = System.Drawing.SystemColors.Control;
            this.txtCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharge.Location = new System.Drawing.Point(195, 144);
            this.txtCharge.Margin = new System.Windows.Forms.Padding(2);
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.Size = new System.Drawing.Size(100, 20);
            this.txtCharge.TabIndex = 7;
            // 
            // txtDetails
            // 
            this.txtDetails.BackColor = System.Drawing.SystemColors.Control;
            this.txtDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.Location = new System.Drawing.Point(195, 107);
            this.txtDetails.Margin = new System.Windows.Forms.Padding(2);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(100, 20);
            this.txtDetails.TabIndex = 6;
            // 
            // txtGuidename
            // 
            this.txtGuidename.BackColor = System.Drawing.SystemColors.Control;
            this.txtGuidename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuidename.Location = new System.Drawing.Point(195, 72);
            this.txtGuidename.Margin = new System.Windows.Forms.Padding(2);
            this.txtGuidename.Name = "txtGuidename";
            this.txtGuidename.Size = new System.Drawing.Size(100, 20);
            this.txtGuidename.TabIndex = 5;
            this.txtGuidename.TextChanged += new System.EventHandler(this.txtGuidename_TextChanged);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Control;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(195, 42);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 4;
            // 
            // lblCharge
            // 
            this.lblCharge.BackColor = System.Drawing.SystemColors.Control;
            this.lblCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharge.ForeColor = System.Drawing.Color.Black;
            this.lblCharge.Location = new System.Drawing.Point(37, 139);
            this.lblCharge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCharge.Name = "lblCharge";
            this.lblCharge.Size = new System.Drawing.Size(141, 27);
            this.lblCharge.TabIndex = 3;
            this.lblCharge.Text = "Charge:";
            this.lblCharge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDetail
            // 
            this.lblDetail.BackColor = System.Drawing.SystemColors.Control;
            this.lblDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetail.ForeColor = System.Drawing.Color.Black;
            this.lblDetail.Location = new System.Drawing.Point(37, 102);
            this.lblDetail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(141, 27);
            this.lblDetail.TabIndex = 2;
            this.lblDetail.Text = "Details :";
            this.lblDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGuidename
            // 
            this.lblGuidename.BackColor = System.Drawing.SystemColors.Control;
            this.lblGuidename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGuidename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuidename.ForeColor = System.Drawing.Color.Black;
            this.lblGuidename.Location = new System.Drawing.Point(37, 67);
            this.lblGuidename.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGuidename.Name = "lblGuidename";
            this.lblGuidename.Size = new System.Drawing.Size(141, 27);
            this.lblGuidename.TabIndex = 1;
            this.lblGuidename.Text = "Guide Name : ";
            this.lblGuidename.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(738, 11);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(38, 29);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.SystemColors.Control;
            this.lblID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Black;
            this.lblID.Location = new System.Drawing.Point(37, 32);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(141, 27);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID : ";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GV
            // 
            this.GV.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.name,
            this.details,
            this.charge,
            this.Edit,
            this.Delete});
            this.GV.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GV.Location = new System.Drawing.Point(-6, 46);
            this.GV.Margin = new System.Windows.Forms.Padding(2);
            this.GV.Name = "GV";
            this.GV.RowHeadersWidth = 62;
            this.GV.RowTemplate.Height = 28;
            this.GV.Size = new System.Drawing.Size(769, 200);
            this.GV.TabIndex = 12;
            this.GV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.Width = 150;
            // 
            // name
            // 
            this.name.HeaderText = "Guide Name";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.Width = 150;
            // 
            // details
            // 
            this.details.HeaderText = "Details";
            this.details.MinimumWidth = 8;
            this.details.Name = "details";
            this.details.Width = 150;
            // 
            // charge
            // 
            this.charge.HeaderText = "Charge";
            this.charge.MinimumWidth = 8;
            this.charge.Name = "charge";
            this.charge.Width = 150;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 8;
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 150;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 8;
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 150;
            // 
            // lblGuide
            // 
            this.lblGuide.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblGuide.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuide.ForeColor = System.Drawing.Color.Firebrick;
            this.lblGuide.Location = new System.Drawing.Point(0, 0);
            this.lblGuide.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGuide.Name = "lblGuide";
            this.lblGuide.Size = new System.Drawing.Size(800, 49);
            this.lblGuide.TabIndex = 11;
            this.lblGuide.Text = "Guide Information";
            this.lblGuide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGuide.Click += new System.EventHandler(this.lblGuide_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.SystemColors.Control;
            this.pnlContent.Controls.Add(this.btnCancel);
            this.pnlContent.Controls.Add(this.btnInsert);
            this.pnlContent.Controls.Add(this.txtCharge);
            this.pnlContent.Controls.Add(this.txtDetails);
            this.pnlContent.Controls.Add(this.txtGuidename);
            this.pnlContent.Controls.Add(this.txtID);
            this.pnlContent.Controls.Add(this.lblCharge);
            this.pnlContent.Controls.Add(this.lblDetail);
            this.pnlContent.Controls.Add(this.lblGuidename);
            this.pnlContent.Controls.Add(this.lblID);
            this.pnlContent.Location = new System.Drawing.Point(164, 250);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(430, 222);
            this.pnlContent.TabIndex = 13;
            this.pnlContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 465);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(0, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 22);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(103, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(105, 20);
            this.txtSearch.TabIndex = 17;
            // 
            // frmGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.GV);
            this.Controls.Add(this.lblGuide);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmGuide";
            this.Text = "frmGuide";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGuide_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtCharge;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.TextBox txtGuidename;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblCharge;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Label lblGuidename;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridView GV;
        private System.Windows.Forms.Label lblGuide;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn details;
        private System.Windows.Forms.DataGridViewTextBoxColumn charge;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}