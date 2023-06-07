using ManagementSystemProject.CLASSES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ManagementSystemProject.FORMS
{
    public partial class ManageUserForm : Form
    {
        public ManageUserForm()
        {
            InitializeComponent();
        }

        CLASSES.USERS users = new CLASSES.USERS();

        private void closeWindow1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageUserForm_Load(object sender, EventArgs e)
        {
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
            string fname = labelFirstname.Text;
            string sname = labelSurname.Text;
            string username = labelUsername.Text;
            string password = labelPassword.Text;
            
            string userType = "user";

            if (checkBoxAdmin.Checked)
            {
                userType = "admin";
            }


            if(verify())
            {
                if (users.isUsernameExist(username, 00))
                {
                    MessageBox.Show("This username already exists.", "Duplicate username", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (users.addUser(fname, sname, username, password, userType))
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
            
            string userType = "user";

            if (checkBoxAdmin.Checked)
            {
                userType = "admin";
            }


            if (verify())
            {
                try
                {
                    id = Convert.ToInt32(labelID.Text);
                    if (users.isUsernameExist(username, id))
                    {
                        MessageBox.Show("This username already exists.", "Duplicate username", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (users.editUser(id, fname, sname, username, password, userType))
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
                    MessageBox.Show("Enter the User ID by selecting it from the Table. | " + ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Please fill in the fields correctly.", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(labelID.Text);
                if (MessageBox.Show("Do you really want to delete this User?", "Confirmation Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (users.removeUser(id))
                    {
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
            labelID.Text = dataGridViewUsers.CurrentRow.Cells[0].Value.ToString();
            labelFirstname.Text = dataGridViewUsers.CurrentRow.Cells[1].Value.ToString();
            labelSurname.Text = dataGridViewUsers.CurrentRow.Cells[2].Value.ToString();
            labelUsername.Text = dataGridViewUsers.CurrentRow.Cells[3].Value.ToString();
            labelPassword.Text = dataGridViewUsers.CurrentRow.Cells[4].Value.ToString();
            labelPassword2.Text = dataGridViewUsers.CurrentRow.Cells[4].Value.ToString();
            string userType = dataGridViewUsers.CurrentRow.Cells[5].Value.ToString();
            if (userType.Equals("admin"))
            {
                checkBoxAdmin.Checked = true;
            }
            else
            {
                checkBoxAdmin.Checked = false;
            }
        }

        public Boolean verify()
        {
            string fname = labelFirstname.Text.Trim();
            string sname = labelSurname.Text.Trim();
            string username = labelUsername.Text.Trim();
            string password = labelPassword.Text.Trim();
            string repassword = labelPassword2.Text.Trim();
            if (fname.Equals("") || sname.Equals("") || username.Equals("") || password.Equals(""))
            {
                return false;
            }
            else if (!repassword.Equals(password))
            {
                return false;
            }
            else
            {
                return true;
            }


        }

            
    }

}

