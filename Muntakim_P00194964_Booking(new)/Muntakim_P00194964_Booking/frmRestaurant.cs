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
    

    public partial class frmRestaurant : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Booking.mdf;Integrated Security=True");
        public frmRestaurant()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Using Try & Catch

            try
            {
                switch (e.ColumnIndex)
                {
                    //Data will Edit here

                    case 3:
                        pnlContent.Visible = true;
                        btninsert.Text = "Update";

                        txtID.Text = gv1.Rows[e.RowIndex].Cells[0].Value.ToString();
                        int idn = Int32.Parse(txtID.Text);

                        SqlCommand cmd1 = new SqlCommand("Select * from tblRestaurant where id=" + idn, conn);
                        conn.Open();
                        SqlDataReader rd = cmd1.ExecuteReader();
                        if (rd.Read())
                        {
                            txtTable.Text = rd.GetString(1);
                            txtCharge.Text = rd.GetValue(2).ToString();

                        }
                        conn.Close();


                        break;

                        //Data will Delete here

                    case 4:
                        txtID.Text = gv1.Rows[e.RowIndex].Cells[0].Value.ToString();
                        int iddel = Int32.Parse(txtID.Text);

                        DialogResult dg = MessageBox.Show("Are you sure you want to delete this record.?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dg != DialogResult.Yes) ;
                        {
                            SqlCommand cmd2 = new SqlCommand("Delete from tblRestaurant where id=" + iddel, conn);
                            conn.Open();
                            cmd2.ExecuteNonQuery();
                            conn.Close();

                            load_data();

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

        private void frmRestaurant_Load(object sender, EventArgs e)
        {
            pnlContent.Visible = false;
            load_data();
        }

        private void load_data()
        {
            //Gride Load Data

            SqlCommand cmd1 = new SqlCommand("Select * from tblRestaurant", conn);
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            conn.Close();

            gv1.AutoGenerateColumns = false;

            gv1.Columns[0].DataPropertyName = "Id";
            gv1.Columns[1].DataPropertyName = "table_size";
            gv1.Columns[2].DataPropertyName = "charge";

            gv1.DataSource = dt;
            gv1.AllowUserToAddRows = false;



        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            //Using If & Else

            if (btninsert.Text == "Insert")
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO tblRestaurant VALUES(@table,@charge)", conn);
                cmd.Parameters.AddWithValue("table", txtTable.Text);
                cmd.Parameters.AddWithValue("charge", txtCharge.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                clearFields();

                MessageBox.Show("Data Inserted Successfully", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();

            }
            else
            {

                int idedit = Int32.Parse(txtID.Text);

                SqlCommand cmd = new SqlCommand("Update tblRestaurant SET table_size=@table,charge=@charge where id=" + idedit, conn);
                cmd.Parameters.AddWithValue("table", txtTable.Text);
                cmd.Parameters.AddWithValue("charge", txtCharge.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                clearFields();

                MessageBox.Show("Data Updated Successfully", "update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();
               

            }

            pnlContent.Visible = false;
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlContent.Visible = true;
        }

        private void clearFields()
        {
            txtID.Text = "";
            txtTable.Text = "";
            txtCharge.Text = "";
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            pnlContent.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Data Search with Name

            try
            {
                string ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|Booking.mdf; Integrated Security = True";
                SqlConnection conn = new SqlConnection(ConnectionString);

                string SearchData = txtSearch.Text;
                string Query = "Select * from tblRestaurant where Table_size like '%" + SearchData + "%' OR Charge like '%" + SearchData + "%'";
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
