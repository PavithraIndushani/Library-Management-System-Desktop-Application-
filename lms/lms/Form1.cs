using lms;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-O46DRTP\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Password FROM Users WHERE Username = @Username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);

                conn.Open();
                var result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string storedPassword = result.ToString();
                    if (txtPassword.Text == storedPassword)
                    {
                        // Open MainForm if login is successful
                        this.Hide();
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid password.");
                    }
                }
                else
                {
                    MessageBox.Show("User not found.");
                }
            }
        }

     

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtPassword_MouseClick(object sender, MouseEventArgs e)
        {

            txtPassword.PasswordChar ='*';
                    
        }
    }
}