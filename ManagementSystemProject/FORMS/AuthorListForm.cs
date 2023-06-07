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
    public partial class AuthorListForm : Form
    {
        private ManageBooksForm mngBooks = null;
        public AuthorListForm(ManageBooksForm sourceForm)
        {
            mngBooks = sourceForm as ManageBooksForm;
            InitializeComponent();
        }

        
        private void closeWindow1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AuthorListForm_Load(object sender, EventArgs e)
        {
            CLASSES.AUTHOR author = new CLASSES.AUTHOR();
            listBoxAuthors.DataSource = author.AuthorList(true);
            listBoxAuthors.DisplayMember = "fullname";
            listBoxAuthors.ValueMember = "id";

            
        }

        private void selectAuthorAndCloseButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView drv = (DataRowView)listBoxAuthors.SelectedItem;
                string fullname = drv["fullname"].ToString();
                string id = drv["id"].ToString();
                mngBooks.authorTextbox.Text = fullname;
                mngBooks.authorIDbox.Text = id;

                mngBooks.authorEditTextbox.Text = fullname;
                mngBooks.anotherIDEdit.Text = id;
            } catch(Exception ex)
            {
                MessageBox.Show("No Author Selected." + ex.Message);
            }
            

            
            this.Close();
        }
    }
}
