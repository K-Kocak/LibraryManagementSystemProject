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
        CLASSES.BOOKS books = new CLASSES.BOOKS();
        public RemoveBookForm()
        {
            InitializeComponent();
        }      
        private void closeWindow1_Click(object sender, EventArgs e)
        {
            // close this form
            this.Close();
        }
        private void searchByIDButton_Click(object sender, EventArgs e)
        {
            // looks for book with entered ID, but prompts the user if they are sure they want to delete this book
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
