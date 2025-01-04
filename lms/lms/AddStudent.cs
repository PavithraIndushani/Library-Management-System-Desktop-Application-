using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lms
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtEnrollement.Clear();
            txtDepartment.Clear();
            txtSemester.Clear();
            txtContact.Clear();
            txtEmail.Text = " ";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtEnrollement.Text != "" && txtDepartment.Text != "" && txtSemester.Text != "" && txtContact.Text != "" && txtEmail.Text != "")
            {
                String name = txtName.Text;
                String enroll = txtEnrollement.Text;
                String dep = txtDepartment.Text;
                String sem = txtSemester.Text;
                Int64 mobile = Int64.Parse(txtContact.Text);
                String email = txtEmail.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-O46DRTP\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True"; // Corrected connection string
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into NewStudent(sname, enroll, dep, sem, contact, email) values ('" + name + "','" + enroll + "','" + dep + "','" + sem + "', " + mobile + ", '" + email + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please Fill Empty Fields", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
