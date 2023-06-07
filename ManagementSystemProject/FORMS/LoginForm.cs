using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ManagementSystemProject.FORMS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            pictureUser.Image = Image.FromFile("../../IMAGES/userimage.png");
            pictureUser.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLock.Image = Image.FromFile("../../IMAGES/lockimage.png");
            pictureLock.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void closeLoginWindow_MouseEnter(object sender, EventArgs e)
        {
            closeLoginWindow.ForeColor = Color.White;
        }

        private void closeLoginWindow_MouseLeave(object sender, EventArgs e)
        {
            closeLoginWindow.ForeColor = Color.Black;
        }

        private void closeLoginWindow_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private DashboardForm dashF = null;
        public LoginForm(DashboardForm SourceForm)
        {
            dashF = SourceForm as DashboardForm;
            InitializeComponent();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            

            THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();

            string username = textboxUsername.Text;
            string password = textboxPassword.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `app_users` WHERE `username`=@usn AND `password`=@pass", db.getConnection());
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                if (table.Rows[0][5].ToString().Equals("owner"))
                {
                    dashF.Enabled = true;
                    this.Close();
                }
                else if (table.Rows[0][5].ToString().Equals("admin"))
                {
                    dashF.Enabled = true;
                    dashF.userButton.Enabled = false;
                    this.Close();
                }
                else if (table.Rows[0][5].ToString().Equals("user"))
                {
                    dashF.Enabled = true;
                    dashF.userButton.Enabled = false;
                    dashF.circulationButton.Enabled = false;
                    this.Close();
                }
            }
            else
            {
                if(username.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your username to login.","Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if(password.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your password to login.", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Incorrect username or password.", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
