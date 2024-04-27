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
    public partial class frmRide : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Booking.mdf;Integrated Security=True");
        DataSet ds;
        public frmRide()
        {
            InitializeComponent();
        }

        private void frmRide_Load(object sender, EventArgs e)
        {
            pnlContent.Visible = false;

            LoadData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (btnInsert.Text == "Insert")
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("INSERT INTO tblRide VALUES(@name,@desc,@time,@charge)", conn);
                    cmd.Parameters.AddWithValue("name", txtRidename.Text);
                    cmd.Parameters.AddWithValue("description", txtDescription.Text);
                    cmd.Parameters.AddWithValue("time", txtTime.Text);

                    cmd.Parameters.AddWithValue("Charge", txtCharge.Text);

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

                SqlCommand cmd = new SqlCommand("Update tblRide SET ridename=@ridename,description=@description,time=@time,charge=@charge where id=" + idedit, conn);
                cmd.Parameters.AddWithValue("ridename", txtRidename.Text);
                cmd.Parameters.AddWithValue("description", txtDescription.Text);
                cmd.Parameters.AddWithValue("time", txtTime.Text);

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
            //Gride Load Data

            SqlCommand cmd1 = new SqlCommand("Select * from tblRide", conn);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            conn.Close();

            gv1.AutoGenerateColumns = false;

            gv1.Columns[0].DataPropertyName = "Id";
            gv1.Columns[1].DataPropertyName = "name";
            gv1.Columns[2].DataPropertyName = "description";
            gv1.Columns[3].DataPropertyName = "time";
            gv1.Columns[4].DataPropertyName = "charge";


            gv1.DataSource = dt;
            gv1.AllowUserToAddRows = false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlContent.Visible = true;

        }
        private void clearFields()
        {
            txtID.Text = "";
            txtRidename.Text = "";
            txtDescription.Text = "";
            txtTime.Text = "";
            txtCharge.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlContent.Visible = false;
        }

        private void GV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btninsert_Click_1(object sender, EventArgs e)
        {
            //Using If & Else

            if (btnInsert.Text == "Insert")
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("INSERT INTO tblRide VALUES(@ridename,@description,@time,@charge)", conn);
                    cmd.Parameters.AddWithValue("ridename", txtRidename.Text);
                    cmd.Parameters.AddWithValue("description", txtDescription.Text);
                    cmd.Parameters.AddWithValue("time", txtTime.Text);

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

                SqlCommand cmd = new SqlCommand("Update tblRide SET name=@name,description=@description,time=@time,charge=@charge where id=" + idedit, conn);
                cmd.Parameters.AddWithValue("ridename", txtRidename.Text);
                cmd.Parameters.AddWithValue("description", txtDescription.Text);
                cmd.Parameters.AddWithValue("time", txtTime.Text);

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

        private void gv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Using Try & Catch

            try
            {
                switch (e.ColumnIndex)
                {
                    //Data will Edit here

                    case 5:
                        pnlContent.Visible = true;
                        btnInsert.Text = "Update";

                        txtID.Text = gv1.Rows[e.RowIndex].Cells[0].Value.ToString();
                        int idn = Int32.Parse(txtID.Text);

                        SqlCommand cmd1 = new SqlCommand("Select * from tblRide where id=" + idn, conn);
                        conn.Open();
                        SqlDataReader rd = cmd1.ExecuteReader();
                        if (rd.Read())
                        {
                            txtRidename.Text = rd.GetString(1);
                            txtDescription.Text = rd.GetString(2);
                            txtTime.Text = rd.GetValue(3).ToString();

                            txtCharge.Text = rd.GetValue(4).ToString();

                        }
                        conn.Close();


                        break;

                    //Data will Delete here

                    case 6:
                        txtID.Text = gv1.Rows[e.RowIndex].Cells[0].Value.ToString();
                        int iddel = Int32.Parse(txtID.Text);
                        DialogResult dg = MessageBox.Show("Are you sure want to delete this record", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dg == DialogResult.Yes)
                        {
                            SqlCommand cmd2 = new SqlCommand("Delete from tblRide where id=" + iddel, conn);
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

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            pnlContent.Visible = true;
        }

        private void btncancel_Click_1(object sender, EventArgs e)
        {
            pnlContent.Visible = false;
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtRidename_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Data Search with Name

            try
            {
                string ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|Booking.mdf; Integrated Security = True";
                SqlConnection conn = new SqlConnection(ConnectionString);

                string SearchData = txtSearch.Text;
                string Query = "Select * from tblRide where Name like '%" + SearchData + "%' OR Description like '%" + SearchData + "%' OR Time like '%" + SearchData + "%' OR Charge like '%" + SearchData + "%'";
                SqlCommand cmd1 = new SqlCommand(Query, conn);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                conn.Close();

                gv1.DataSource = dt;
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
