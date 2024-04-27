using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Muntakim_P00194964_Booking
{
    public partial class frmGuide : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Booking.mdf;Integrated Security=True");
        DataSet ds;
        public frmGuide()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlContent.Visible = true;
        }

        private void GV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Using Try & Catch 
            try
            {
                switch (e.ColumnIndex)
                {
                    //Data will Edit here

                    case 4:
                        pnlContent.Visible = true;
                        btnInsert.Text = "Update";

                        txtID.Text = GV.Rows[e.RowIndex].Cells[0].Value.ToString();
                        int idn = Int32.Parse(txtID.Text);

                        SqlCommand cmd1 = new SqlCommand("Select * from tblGuide where id=" + idn, conn);
                        conn.Open();
                        SqlDataReader rd = cmd1.ExecuteReader();
                        if (rd.Read())
                        {
                            txtGuidename.Text = rd.GetString(1);
                            txtDetails.Text = rd.GetString(2);
                            txtCharge.Text = rd.GetValue(3).ToString();

                        }
                        conn.Close();


                        break;

                    //Data will Delete here

                    case 5:
                        txtID.Text = GV.Rows[e.RowIndex].Cells[0].Value.ToString();
                        int iddel = Int32.Parse(txtID.Text);
                        DialogResult dg = MessageBox.Show("Are you sure want to delete this record", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dg == DialogResult.Yes)
                        {
                            SqlCommand cmd2 = new SqlCommand("Delete from tblGuide where id=" + iddel, conn);
                            conn.Open();
                            cmd2.ExecuteNonQuery();
                            conn.Close();

                            LoadData();

                            MessageBox.Show("Data deleted succecfully");
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show("Error" + ex1);

            }
        }

        private void lblGuide_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmGuide_Load(object sender, EventArgs e)
        {
            pnlContent.Visible = false;

            LoadData();

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //Data Insert Button
            if (btnInsert.Text == "Insert")
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO tblGuide VALUES(@name,@details,@charge)", conn);
                    cmd.Parameters.AddWithValue("name", txtGuidename.Text);
                    cmd.Parameters.AddWithValue("details", txtDetails.Text);
                    cmd.Parameters.AddWithValue("charge", txtCharge.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    clearFields();

                    MessageBox.Show("Data Inserted Successfully", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                catch (Exception ex1)
                {

                    MessageBox.Show(ex1.Message);
                    conn.Close();
                }

            }
            else
            {

                int idedit = Int32.Parse(txtID.Text);

                SqlCommand cmd = new SqlCommand("Update tblGuide SET name=@name,details=@details,charge=@charge where id=" + idedit, conn);
                cmd.Parameters.AddWithValue("name", txtGuidename.Text);
                cmd.Parameters.AddWithValue("details", txtDetails.Text);
                cmd.Parameters.AddWithValue("charge", txtCharge.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                clearFields();

                MessageBox.Show("Data Updated Successfully", "update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }

            pnlContent.Visible = false;
        }

        private void LoadData()
        {
            //Grid Load Data

            SqlCommand cmd1 = new SqlCommand("Select * from tblGuide", conn);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            conn.Close();

            GV.AutoGenerateColumns = false;

            GV.Columns[0].DataPropertyName = "ID";
            GV.Columns[1].DataPropertyName = "name";
            GV.Columns[2].DataPropertyName = "details";
            GV.Columns[3].DataPropertyName = "charge";

            GV.DataSource = dt;
            GV.AllowUserToAddRows = false;
        }
        private void clearFields()
        {
            txtID.Text = "";
            txtGuidename.Text = "";
            txtDetails.Text = "";
            txtCharge.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlContent.Visible = false;
        }

        private void txtGuidename_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Data Search By Name
            try
            {
                string ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|Booking.mdf; Integrated Security = True";
                SqlConnection conn = new SqlConnection(ConnectionString);

                string SearchData = txtSearch.Text;
                string Query = "Select * from tblGuide where Name like '%" + SearchData + "%' OR Details like '%" + SearchData + "%'  OR Charge like '%" + SearchData + "%'";
                SqlCommand cmd1 = new SqlCommand(Query, conn);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                conn.Close();

                GV.DataSource = dt;
                conn.Close();

            }
            catch (Exception ex1)
            {
                MessageBox.Show("Error" + ex1);
                conn.Close();
            }
        }
    }
}
