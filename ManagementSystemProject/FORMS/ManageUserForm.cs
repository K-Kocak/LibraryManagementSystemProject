using System;
using System.Drawing;
using System.Windows.Forms;
namespace ManagementSystemProject.FORMS
{
    public partial class ManageUserForm : Form
    {
        CLASSES.USERS users = new CLASSES.USERS();
        public ManageUserForm()
        {
            InitializeComponent();
        }
        private void closeWindow1_Click(object sender, EventArgs e)
        {
            // close form
            this.Close();
        }
        private void ManageUserForm_Load(object sender, EventArgs e)
        {
            // grabs images that will be loaded in by default, gives some styles
            buttonAdd.Image = Image.FromFile("../../IMAGES/addbutton.png");
            buttonEdit.Image = Image.FromFile("../../IMAGES/editbutton.png");
            buttonDelete.Image = Image.FromFile("../../IMAGES/deletebutton.png");
            dataGridViewUsers.DataSource = users.UsersList();
            dataGridViewUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridViewUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);
            dataGridViewUsers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewUsers.EnableHeadersVisualStyles = false;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // when adding a new user, grabs the values inside some of the fields
            string fname = labelFirstname.Text;
            string sname = labelSurname.Text;
            string username = labelUsername.Text;
            string password = labelPassword.Text;  
            // by default, usertype is "user", but if the admin checkbox is ticked, changes usertype to admin
            string userType = "user";
            if (checkBoxAdmin.Checked)
            {
                userType = "admin";
            }

            if(verify())
            {
                if (users.IsUsernameExist(username, 00))
                {
                    MessageBox.Show("This username already exists.", "Duplicate username", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (users.AddUser(fname, sname, username, password, userType))
                    {
                        MessageBox.Show("User Added Succesfully.", "User Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridViewUsers.DataSource = users.UsersList();
                    }
                    else
                    {
                        MessageBox.Show("User Not Added.", "Add Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }              
            }
            else
            {
                MessageBox.Show("Please fill in the fields correctly.", "Add Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }           
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int id;
            string fname = labelFirstname.Text;
            string sname = labelSurname.Text;
            string username = labelUsername.Text;
            string password = labelPassword.Text;
            string userType = checkBoxAdmin.Checked ? "admin" : "user";

            // checking if the fields arent empty and password equals the re-entered password
            if (verify())
            {
                try
                {
                    id = Convert.ToInt32(labelID.Text);
                    //returns a boolean if it finds > 0 entries of a given username + id. (true if > 0, false otherwise)
                    if (users.IsUsernameExist(username, id))
                    {
                        MessageBox.Show("This username already exists.", "Duplicate username", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        //it will try to edit the user, if succesful then returns true
                        if (users.EditUser(id, fname, sname, username, password, userType))
                        {
                            MessageBox.Show("User Data Edited Succesfully.", "User Edited", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataGridViewUsers.DataSource = users.UsersList();
                        }
                        else
                        {
                            MessageBox.Show("User Not Edited.", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    
                }catch(Exception ex)
                {
                    // if ID is null or undefined because no ID was selected
                    MessageBox.Show("Enter the User ID by selecting it from the Table. | " + ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                // if something was not done correctly when filling in the fields + re-entering password
                MessageBox.Show("Please fill in the fields correctly.", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(labelID.Text);
                // confirmation box to check if the user really wants to delete a chosen user
                if (MessageBox.Show("Do you really want to delete this User?", "Confirmation Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // returns true if it was able to delete the user
                    if (users.RemoveUser(id))
                    {
                        // resets text of input fields once a user has been removed
                        MessageBox.Show("User has been removed.", "Removed User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        labelID.Text = "";
                        labelFirstname.Text = "";
                        labelSurname.Text = "";
                        labelUsername.Text = "";
                        labelPassword.Text = "";
                        labelPassword2.Text = "";
                        checkBoxAdmin.Checked = false;
                        dataGridViewUsers.DataSource = users.UsersList();
                        
                    }
                    else
                    {
                        MessageBox.Show("User has not been removed.", "Remove User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid ID");
            }
        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // if a cell in the table is clicked, retrieves the values on that row and fills in the input fields automatically
            labelID.Text = dataGridViewUsers.CurrentRow.Cells[0].Value.ToString();
            labelFirstname.Text = dataGridViewUsers.CurrentRow.Cells[1].Value.ToString();
            labelSurname.Text = dataGridViewUsers.CurrentRow.Cells[2].Value.ToString();
            labelUsername.Text = dataGridViewUsers.CurrentRow.Cells[3].Value.ToString();
            labelPassword.Text = dataGridViewUsers.CurrentRow.Cells[4].Value.ToString();
            labelPassword2.Text = dataGridViewUsers.CurrentRow.Cells[4].Value.ToString();
            string userType = dataGridViewUsers.CurrentRow.Cells[5].Value.ToString();
            // if user type is admin, check the admin box.
            checkBoxAdmin.Checked = userType.Equals("admin") ? true : false;
        }

        public Boolean verify()
        {
            string fname = labelFirstname.Text.Trim();
            string sname = labelSurname.Text.Trim();
            string username = labelUsername.Text.Trim();
            string password = labelPassword.Text.Trim();
            string repassword = labelPassword2.Text.Trim();
            // if any fields were empty, return false
            if (fname.Equals("") || sname.Equals("") || username.Equals("") || password.Equals(""))
            {
                return false;
            }
            else if (!repassword.Equals(password))
            {
                // if re-enterpassword != password..
                return false;
            }
            else
            {
                // return true if previous two IF statements were false
                return true;
            }
        }          
    }

}

