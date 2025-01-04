using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lms
{
    public partial class CompleteBookDetails : Form
    {
        public CompleteBookDetails()
        {
            InitializeComponent();
        }

        private void CompleteBookDetails_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-O46DRTP\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open(); // Open the connection

                // First query
                cmd.CommandText = "Select * from IRBook where book_return_date is null";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                // Second query
                cmd.CommandText = "Select * from IRBook where book_return_date is not null";
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                dataGridView2.DataSource = ds1.Tables[0];

                con.Close(); // Close the connection
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred while connecting to the database: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }
    }
}
