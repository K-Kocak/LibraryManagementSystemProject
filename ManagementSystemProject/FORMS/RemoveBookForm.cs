using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSystemProject.FORMS
{
    public partial class RemoveBookForm : Form
    {
        public RemoveBookForm()
        {
            InitializeComponent();
        }

        CLASSES.BOOKS books  = new CLASSES.BOOKS();
        private void closeWindow1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchByIDButton_Click(object sender, EventArgs e)
        {
            int bookID = (int)numericUpDownBookID.Value;
            if (MessageBox.Show("Do you really want to delete this Book?", "Confirmation Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (books.deleteBook(bookID))
                {
                    MessageBox.Show("Book has been removed.", "Removed Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Book has not been removed.", "Remove Book", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
