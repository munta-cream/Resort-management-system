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
    public partial class frmReview : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Booking.mdf;Integrated Security=True");
        public frmReview()
        {
            InitializeComponent();
        }
        
      
        private void btnAdd_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

        }
        private void clearFields()
        {
            txtId.Text = "";
            txtUid.Text = "";
            txtRemarks.Text = "";
            
        }
        private void LoadData()
        {
            //Gride Load Data

            SqlCommand cmd1 = new SqlCommand("Select * from tblReview", conn);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            conn.Close();

            GV.AutoGenerateColumns = false;

            GV.Columns[0].DataPropertyName = "Id";
            GV.Columns[1].DataPropertyName = "Uid";
            GV.Columns[2].DataPropertyName = "Remarks";
            GV.Columns[3].DataPropertyName = "ispublic";
            GV.Columns[4].DataPropertyName = "reviewdate";


            GV.DataSource = dt;
            GV.AllowUserToAddRows = false;
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            //Using If & Else

            if (btnInsert.Text == "Insert")
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("INSERT INTO tblReview VALUES(@Uid,@remarks,@ispublic,@reviewDate)", conn);
                    cmd.Parameters.AddWithValue("Uid", txtUid.Text);
                    cmd.Parameters.AddWithValue("remarks", txtRemarks.Text);
                    cmd.Parameters.AddWithValue("ispublic", chkPublic.Checked);

                    cmd.Parameters.AddWithValue("reviewDate", dateTimePicker1.Value.ToShortDateString());

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

                int idedit = Int32.Parse(txtId.Text);

                SqlCommand cmd = new SqlCommand("Update tblReview SET Uid=@Uid,remarks=@Remarks,ispublic=@ispublic,reviewDate=@reviewDate where id=" + idedit, conn);
                cmd.Parameters.AddWithValue("Uid", txtUid.Text);
                cmd.Parameters.AddWithValue("remarks", txtRemarks.Text);
                cmd.Parameters.AddWithValue("ispublic", chkPublic.Checked);

                cmd.Parameters.AddWithValue("reviewDate", dateTimePicker1.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                clearFields();

                MessageBox.Show("Data Updated Successfully", "update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }

            panel1.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;

        }

        private void GV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Using Try & Catch

            switch (e.ColumnIndex)
                {
                //Data will Edit here

                case 5:
                        panel1.Visible = true;
                        btnInsert.Text = "Update";

                        txtId.Text = GV.Rows[e.RowIndex].Cells[0].Value.ToString();
                        int idn = Int32.Parse(txtId.Text);

                        SqlCommand cmd1 = new SqlCommand("Select * from tblReview where id=" + idn, conn);
                        conn.Open();
                        SqlDataReader rd = cmd1.ExecuteReader();
                        if (rd.Read())
                        {
                            txtUid.Text = rd.GetValue(1).ToString();
                            txtRemarks.Text = rd.GetString(2);
                            chkPublic.Checked = rd.GetBoolean(3);

                           dateTimePicker1.Value = DateTime.Parse( rd.GetString(4)) ;

                        }
                        conn.Close();


                        break;

                //Data will Delete here

                case 6:
                        txtId.Text = GV.Rows[e.RowIndex].Cells[0].Value.ToString();
                        int iddel = Int32.Parse(txtId.Text);
                        DialogResult dg = MessageBox.Show("Are you sure want to delete this record", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dg == DialogResult.Yes)
                        {
                            SqlCommand cmd2 = new SqlCommand("Delete from tblReview where id=" + iddel, conn);
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

        private void frmReview_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            LoadData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
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
                string Query = "Select * from tblReview where Uid like '%" + SearchData + "%' OR Remarks like '%" + SearchData + "%' OR isPublic like '%" + SearchData + "%' OR reviewDate like '%" + SearchData + "%'";
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
