using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace lms
{
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void AddBooks_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text != "" && txtAuthor.Text != "" && txtPublication.Text != "" && txtPrice.Text != "" && txtQuntity.Text != "")
            {
                try
                {
                    String bname = txtBookName.Text;
                    String bauthor = txtAuthor.Text;
                    String publication = txtPublication.Text;
                    String pdate = dateTimePicker1.Text;
                    Int64 price = Int64.Parse(txtPrice.Text);
                    Int64 quan = Int64.Parse(txtQuntity.Text);

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source= DESKTOP-O46DRTP\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    con.Open();
                    cmd.CommandText = "insert into NewBook (bName,bAuthor,bPubl,bPDate,bPrice,bQuan) values(@bname, @bauthor, @publication, @pdate, @price, @quan)";
                    cmd.Parameters.AddWithValue("@bname", bname);
                    cmd.Parameters.AddWithValue("@bauthor", bauthor);
                    cmd.Parameters.AddWithValue("@publication", publication);
                    cmd.Parameters.AddWithValue("@pdate", pdate);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@quan", quan);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBookName.Clear();
                    txtAuthor.Clear();
                    txtPublication.Clear();
                    txtPrice.Clear();
                    txtQuntity.Clear();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Price and Quantity must be numeric values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field textbox NOT Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure ? This Will DELETED Your Unsaved DATA.", "Are You Sure ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                this.Close();
        }
    }
}
