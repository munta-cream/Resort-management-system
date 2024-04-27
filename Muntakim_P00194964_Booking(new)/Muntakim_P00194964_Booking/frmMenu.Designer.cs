namespace Muntakim_P00194964_Booking
{
    partial class frmMenu
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReview = new System.Windows.Forms.Button();
            this.btnGuide = new System.Windows.Forms.Button();
            this.btnRide = new System.Windows.Forms.Button();
            this.btnResort = new System.Windows.Forms.Button();
            this.btnRestaurant = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 79);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTop_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTitle.ForeColor = System.Drawing.Color.Gold;
            this.lblTitle.Location = new System.Drawing.Point(30, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(394, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Booking Management System";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Red;
            this.pnlMenu.Controls.Add(this.btnExit);
            this.pnlMenu.Controls.Add(this.btnHome);
            this.pnlMenu.Controls.Add(this.btnLogout);
            this.pnlMenu.Controls.Add(this.btnReview);
            this.pnlMenu.Controls.Add(this.btnGuide);
            this.pnlMenu.Controls.Add(this.btnRide);
            this.pnlMenu.Controls.Add(this.btnResort);
            this.pnlMenu.Controls.Add(this.btnRestaurant);
            this.pnlMenu.Controls.Add(this.btnFood);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 79);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 371);
            this.pnlMenu.TabIndex = 1;
            this.pnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenu_Paint);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnHome.Location = new System.Drawing.Point(33, 40);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(127, 29);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLogout.Location = new System.Drawing.Point(33, 303);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(127, 29);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReview
            // 
            this.btnReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnReview.Location = new System.Drawing.Point(33, 264);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(127, 29);
            this.btnReview.TabIndex = 5;
            this.btnReview.Text = "Review";
            this.btnReview.UseVisualStyleBackColor = true;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // btnGuide
            // 
            this.btnGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGuide.Location = new System.Drawing.Point(33, 226);
            this.btnGuide.Name = "btnGuide";
            this.btnGuide.Size = new System.Drawing.Size(127, 29);
            this.btnGuide.TabIndex = 4;
            this.btnGuide.Text = "Guide";
            this.btnGuide.UseVisualStyleBackColor = true;
            this.btnGuide.Click += new System.EventHandler(this.btnGuide_Click);
            // 
            // btnRide
            // 
            this.btnRide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRide.Location = new System.Drawing.Point(33, 187);
            this.btnRide.Name = "btnRide";
            this.btnRide.Size = new System.Drawing.Size(127, 29);
            this.btnRide.TabIndex = 3;
            this.btnRide.Text = "Ride";
            this.btnRide.UseVisualStyleBackColor = true;
            this.btnRide.Click += new System.EventHandler(this.btnRide_Click);
            // 
            // btnResort
            // 
            this.btnResort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnResort.Location = new System.Drawing.Point(33, 149);
            this.btnResort.Name = "btnResort";
            this.btnResort.Size = new System.Drawing.Size(127, 29);
            this.btnResort.TabIndex = 2;
            this.btnResort.Text = "Resort";
            this.btnResort.UseVisualStyleBackColor = true;
            this.btnResort.Click += new System.EventHandler(this.btnResort_Click);
            // 
            // btnRestaurant
            // 
            this.btnRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRestaurant.Location = new System.Drawing.Point(33, 114);
            this.btnRestaurant.Name = "btnRestaurant";
            this.btnRestaurant.Size = new System.Drawing.Size(127, 29);
            this.btnRestaurant.TabIndex = 1;
            this.btnRestaurant.Text = "Restaurants ";
            this.btnRestaurant.UseVisualStyleBackColor = true;
            this.btnRestaurant.Click += new System.EventHandler(this.btnRestaurant_Click);
            // 
            // btnFood
            // 
            this.btnFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFood.Location = new System.Drawing.Point(33, 79);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(127, 29);
            this.btnFood.TabIndex = 0;
            this.btnFood.Text = "Food";
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(200, 79);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(600, 371);
            this.pnlContainer.TabIndex = 2;
            this.pnlContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContainer_Paint);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(33, 338);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 33);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Button btnRestaurant;
        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.Button btnGuide;
        private System.Windows.Forms.Button btnRide;
        private System.Windows.Forms.Button btnResort;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnExit;
    }
}