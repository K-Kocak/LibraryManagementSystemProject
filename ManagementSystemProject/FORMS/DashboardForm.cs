using ManagementSystemProject.CLASSES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSystemProject.FORMS
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            pictureCloseButton.Image = Image.FromFile("../../IMAGES/closebuttonimage2.png");
            bookButton.Image = Image.FromFile("../../IMAGES/bookimage.png");
            authorButton.Image = Image.FromFile("../../IMAGES/penimage.png");
            genreButton.Image = Image.FromFile("../../IMAGES/labelimage.png");
            circulationButton.Image = Image.FromFile("../../IMAGES/circulationimage.png");
            userButton.Image = Image.FromFile("../../IMAGES/userimage2.png");


            
        }

        CLASSES.BOOKS book = new CLASSES.BOOKS();
        CLASSES.AUTHOR author = new CLASSES.AUTHOR();
        CLASSES.MEMBER member = new CLASSES.MEMBER();
        private void pictureCloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DashboardForm_Shown(object sender, EventArgs e)
        {
            this.Enabled = false;
            LoginForm lgf = new LoginForm(this);
            lgf.Show();

            bookCountDash.Text = book.BookList().Rows.Count.ToString();
            authorCountDash.Text = author.AuthorList(false).Rows.Count.ToString();
            memberCountDash.Text = member.MemberList(false).Rows.Count.ToString();

            DataTable bookData = book.BookList();
            byte[] img;
            MemoryStream ms;
            int i = 0;
            foreach (var panelControl in panel7.Controls)
            {
                if(panelControl.GetType() == typeof(Panel))
                {
                    Panel panel = (Panel) panelControl;
                    img = (byte[])bookData.Rows[i][10];
                    ms = new MemoryStream(img);
                    panel.BackgroundImage = Image.FromStream(ms);
                    panel.BackgroundImageLayout = ImageLayout.Stretch;

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
            SelectedButton(genreButton);
            ManageGenresForm mngGnrF = new ManageGenresForm();
            mngGnrF.Show();
        }

        private void authorButton_Click(object sender, EventArgs e)
        {
            SelectedButton(authorButton);
            ManageAuthorsForm mngAutF = new ManageAuthorsForm();
            mngAutF.Show();
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            SelectedButton(bookButton);
            ManageBooksForm mngBookF = new ManageBooksForm();
            mngBookF.Show();
        }

        private void memberButton_Click(object sender, EventArgs e)
        {
            SelectedButton(memberButton);
            ManageMembersForm mngMemF = new ManageMembersForm();
            mngMemF.Show();
        }

        public void SelectedButton(Button btn)
        {
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
            SelectedButton(circulationButton);
            ManageCirculationForm mngCirF = new ManageCirculationForm();
            mngCirF.Show();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            SelectedButton(userButton);
            ManageUserForm MngUsF = new ManageUserForm();
            MngUsF.Show();
        }
    }
}
