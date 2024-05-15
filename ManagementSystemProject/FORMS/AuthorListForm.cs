using System;
using System.Data;
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
            // close window button
            this.Close();
        }

        private void AuthorListForm_Load(object sender, EventArgs e)
        {
            // gets the author list names from the database and displays them on the UI
            CLASSES.AUTHOR author = new CLASSES.AUTHOR();
            listBoxAuthors.DataSource = author.AuthorList(true);
            listBoxAuthors.DisplayMember = "fullname";
            listBoxAuthors.ValueMember = "id";       
        }

        private void selectAuthorAndCloseButton_Click(object sender, EventArgs e)
        {
            try
            {
                // it will try to fill in the author name box with the selected author with the respective author id
                DataRowView drv = (DataRowView)listBoxAuthors.SelectedItem;
                string fullname = drv["fullname"].ToString();
                string id = drv["id"].ToString();
                mngBooks.authorTextbox.Text = fullname;
                mngBooks.authorIDbox.Text = id;
                mngBooks.authorEditTextbox.Text = fullname;
                mngBooks.anotherIDEdit.Text = id;
            } 
            catch(Exception ex)
            {
                MessageBox.Show("No Author Selected." + ex.Message);
            }
            

            // close the pick author form
            this.Close();
        }
    }
}
