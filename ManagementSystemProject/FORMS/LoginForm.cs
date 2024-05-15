using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace ManagementSystemProject.FORMS
{
    public partial class LoginForm : Form
    {
        private DashboardForm dashF = null;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Loads images
            pictureUser.Image = Image.FromFile("../../IMAGES/userimage.png");
            pictureUser.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLock.Image = Image.FromFile("../../IMAGES/lockimage.png");
            pictureLock.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void closeLoginWindow_MouseEnter(object sender, EventArgs e)
        {
            // Changes the X button (for closing the window) to white when the mouse hovers over it
            closeLoginWindow.ForeColor = Color.White;
        }

        private void closeLoginWindow_MouseLeave(object sender, EventArgs e)
        {
            // Back to black when mouse no longer hovers over it
            closeLoginWindow.ForeColor = Color.Black;
        }

        private void closeLoginWindow_Click(object sender, EventArgs e)
        {          
            Application.Exit();
        }
      
        public LoginForm(DashboardForm SourceForm)
        {
            dashF = SourceForm as DashboardForm;
            InitializeComponent();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
            // Upon clicking login, creates a db object
            THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();

            // grabs entered username + password
            string username = textboxUsername.Text;
            string password = textboxPassword.Text;

            // looks for the user in the database
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `app_users` WHERE `username`=@usn AND `password`=@pass", db.GetConnection());
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                if (table.Rows[0][5].ToString().Equals("owner"))
                {
                    // if the user found is an owner, enables the dashboard and closes login form
                    dashF.Enabled = true;
                    this.Close();
                }
                else if (table.Rows[0][5].ToString().Equals("admin"))
                {
                    // same as owner, but can't access user form
                    dashF.Enabled = true;
                    dashF.userButton.Enabled = false;
                    this.Close();
                }
                else if (table.Rows[0][5].ToString().Equals("user"))
                {
                    // same as admin, but can't access circulation form
                    dashF.Enabled = true;
                    dashF.userButton.Enabled = false;
                    dashF.circulationButton.Enabled = false;
                    this.Close();
                }
            }
            else
            {
                // goes here if username+password combination isn't in the database
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
