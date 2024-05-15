using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace ManagementSystemProject.FORMS
{
    public partial class DashboardForm : Form
    {
        CLASSES.BOOKS book = new CLASSES.BOOKS();
        CLASSES.AUTHOR author = new CLASSES.AUTHOR();
        CLASSES.MEMBER member = new CLASSES.MEMBER();
        public DashboardForm()
        {
            InitializeComponent();
        }
        private void DashboardForm_Load(object sender, EventArgs e)
        {
            // Loads the images contained on the Dashboard Form
            pictureCloseButton.Image = Image.FromFile("../../IMAGES/closebuttonimage2.png");
            bookButton.Image = Image.FromFile("../../IMAGES/bookimage.png");
            authorButton.Image = Image.FromFile("../../IMAGES/penimage.png");
            genreButton.Image = Image.FromFile("../../IMAGES/labelimage.png");
            circulationButton.Image = Image.FromFile("../../IMAGES/circulationimage.png");
            userButton.Image = Image.FromFile("../../IMAGES/userimage2.png");    
        }            
        private void pictureCloseButton_Click(object sender, EventArgs e)
        {
            // Close the window if the X button is pressed in the top right
            Application.Exit();
        }

        private void DashboardForm_Shown(object sender, EventArgs e)
        {
            // Upon loading dashboard form, it will disable the window and pop up the login form (to log in)
            this.Enabled = false;
            LoginForm lgf = new LoginForm(this);
            lgf.Show();

            // These are to display the numbers for total Books, Authors and Members in the database
            bookCountDash.Text = book.BookList().Rows.Count.ToString();
            authorCountDash.Text = author.AuthorList(false).Rows.Count.ToString();
            memberCountDash.Text = member.MemberList(false).Rows.Count.ToString();

            // Grabs all the books in the database
            DataTable bookData = book.BookList();
            byte[] img;
            MemoryStream ms;
            int i = 0;
            // This for loop generates the books in the "latest books" section
            foreach (var panelControl in panel7.Controls)
            {
                if(panelControl.GetType() == typeof(Panel))
                {
                    Panel panel = (Panel) panelControl;
                    img = (byte[])bookData.Rows[i][10];
                    ms = new MemoryStream(img);
                    // Sets the image
                    panel.BackgroundImage = Image.FromStream(ms);
                    // Makes it scale to the panel
                    panel.BackgroundImageLayout = ImageLayout.Stretch;

                    // Sets the £ to the book's price
                    foreach(var labelControl in panel.Controls)
                    {
                        if(labelControl.GetType() == typeof(Label))
                        {
                            Label label = (Label) labelControl;
                            label.Text = "£" + bookData.Rows[i][6].ToString();
                        }
                    }
                    i++;
                }
            }
        }
        private void genreButton_Click(object sender, EventArgs e)
        {
            // Upons the genre form
            SelectedButton(genreButton);
            ManageGenresForm mngGnrF = new ManageGenresForm();
            mngGnrF.Show();
        }
        private void authorButton_Click(object sender, EventArgs e)
        {
            // Opens the author form
            SelectedButton(authorButton);
            ManageAuthorsForm mngAutF = new ManageAuthorsForm();
            mngAutF.Show();
        }
        private void bookButton_Click(object sender, EventArgs e)
        {
            // Opens the "books" form

            SelectedButton(bookButton);
            ManageBooksForm mngBookF = new ManageBooksForm();
            mngBookF.Show();
        }
        private void memberButton_Click(object sender, EventArgs e)
        {
            // Opens the "Members" form
            SelectedButton(memberButton);
            ManageMembersForm mngMemF = new ManageMembersForm();
            mngMemF.Show();
        }
        public void SelectedButton(Button btn)
        {
            // Changes the colour of a button when you click on it, while changing the OTHER buttons to a different colour
            foreach(Control control in panelMenu.Controls)
            {
                if(control.GetType() == typeof(Button))
                {
                    Button button = (Button) control;
                    button.BackColor = System.Drawing.Color.FromArgb(128, 128, 128);
                }
            }
            btn.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
        }
        private void circulationButton_Click(object sender, EventArgs e)
        {
            // Circulation form
            SelectedButton(circulationButton);
            ManageCirculationForm mngCirF = new ManageCirculationForm();
            mngCirF.Show();
        }
        private void userButton_Click(object sender, EventArgs e)
        {
            // Users form
            SelectedButton(userButton);
            ManageUserForm MngUsF = new ManageUserForm();
            MngUsF.Show();
        }
    }
}
