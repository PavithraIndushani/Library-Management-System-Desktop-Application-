using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace lms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you Sure You want to Exit ?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
               Application.Exit();
            }
           
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBooks abs = new AddBooks();
            abs.Show();
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBook vb = new ViewBook();
            vb.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent ast = new AddStudent();
            ast.Show();
        }

        private void viewStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudentInformation vsi = new ViewStudentInformation();
            vsi.Show();
        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBooks id = new IssueBooks();
            id.Show();
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBook rb =new ReturnBook();
            rb.Show();
        }

        private void completeBooksDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompleteBookDetails cbd = new CompleteBookDetails();
            cbd.Show();
        }
    }
}
