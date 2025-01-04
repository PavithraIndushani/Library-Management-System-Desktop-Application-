using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lms
{
    public partial class ViewStudentInformation : Form
    {
        public ViewStudentInformation()
        {
            InitializeComponent();
        }

        private void txtSerchEnrollement_TextChanged(object sender, EventArgs e)
        {
            UpdateStudentGrid();
        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ViewStudentInformation_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-O46DRTP\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewStudent";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }

        private void UpdateStudentGrid()
        {
           
              
        }
    }
}
