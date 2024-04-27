using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muntakim_P00194964_Booking
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            openChildForm(new frmFood());
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            openChildForm(new frmHome());
        }   
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;    
            pnlContainer.Controls.Add(childForm);
            pnlContainer.Tag = childForm;
            childForm.BringToFront();

            childForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
        }

        private void btnRestaurant_Click(object sender, EventArgs e)
        {
            openChildForm(new frmRestaurant());
        }

        private void btnResort_Click(object sender, EventArgs e)
        {
            openChildForm(new frmResort());
        }

        private void btnRide_Click(object sender, EventArgs e)
        {
            openChildForm(new frmRide());
        }

        private void btnGuide_Click(object sender, EventArgs e)
        {
            openChildForm(new frmGuide());
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            openChildForm(new frmReview());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            openChildForm(new frmHome());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
