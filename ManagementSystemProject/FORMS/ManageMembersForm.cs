using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace ManagementSystemProject.FORMS
{
    public partial class ManageMembersForm : Form
    {
        CLASSES.MEMBER member = new CLASSES.MEMBER();
        public ManageMembersForm()
        {
            InitializeComponent();
        }       
        private void closeWindow1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ManageMembersForm_Load(object sender, EventArgs e)
        {
            // load images and data grid, with some styles
            addButton1.Image = Image.FromFile("../../IMAGES/addbutton.png");
            editButton1.Image = Image.FromFile("../../IMAGES/editbutton.png");
            removeButton1.Image = Image.FromFile("../../IMAGES/deletebutton.png");
            dataGridViewMembers.RowTemplate.Height = 50;
            dataGridViewMembers.DataSource = member.MemberList(true);           
            dataGridViewMembers.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridViewMembers.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridViewMembers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewMembers.EnableHeadersVisualStyles = false;

            DataGridViewImageColumn dvgImgCol = new DataGridViewImageColumn();
            dvgImgCol = (DataGridViewImageColumn)dataGridViewMembers.Columns[5];
            dvgImgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            memberCountLabel.Text = member.MemberList(false).Rows.Count.ToString() + " Members";
        }
        private void buttonSelectPicture_Click(object sender, EventArgs e)
        {
            // lets user pick a picture for the member
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*png;*.gif)|*.jpg;*png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxMember.Image = Image.FromFile(opf.FileName);
            }
        }
        private void addButton1_Click(object sender, EventArgs e)
        {
            // adds the member to the member database
            string firstname = fnameTextbox.Text;
            string surname = snameTextbox.Text;
            string phone = textBoxPhoneNumber.Text;
            string email = textBoxEmail.Text;
            string gender = radioButtonFemale.Checked ? "Female" : "Male";
            //string gender = "Male";
            //if(radioButtonFemale.Checked)
            //{
            //    gender = "Female";
            //}
            MemoryStream ms = new MemoryStream();
            pictureBoxMember.Image.Save(ms, pictureBoxMember.Image.RawFormat);
            byte[] memberPicture = ms.ToArray();

            if (firstname.Trim().Equals("") || surname.Trim().Equals("") || phone.Trim().Equals(""))
            {
                MessageBox.Show("Enter a first name and surname for the member.", "Empty Member Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (member.AddMember(firstname, surname, gender, phone, email, memberPicture))
                {
                    MessageBox.Show("New Member has been added.", "New Member", MessageBoxButtons.OK, MessageBoxIcon.Information);                
                    memberCountLabel.Text = member.MemberList(false).Rows.Count.ToString() + " Members";
                }
                else
                {
                    MessageBox.Show("Member Not Added", "Add Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        // styling for the gender button
        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonMale.ForeColor = Color.Blue;
            radioButtonFemale.ForeColor = Color.Black;
        }
        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonFemale.ForeColor = Color.Blue;
            radioButtonMale.ForeColor = Color.Black;
        }

        private void editButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // edits a member
                int id;
                string firstname = fnameTextbox.Text;
                string surname = snameTextbox.Text;
                string phone = textBoxPhoneNumber.Text;
                string email = textBoxEmail.Text;
                string gender = radioButtonFemale.Checked ? "Female" : "Male";
                if (!idTextbox.Text.Equals(""))
                {               
                    MemoryStream ms = new MemoryStream();
                    pictureBoxMember.Image.Save(ms, pictureBoxMember.Image.RawFormat);
                    byte[] memberPicture = ms.ToArray();
                    // blank entries
                    if (firstname.Trim().Equals("") || surname.Trim().Equals("") || phone.Trim().Equals(""))
                    {
                        MessageBox.Show("Enter a first name and surname for the member.", "Empty Member Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        id = Convert.ToInt32(idTextbox.Text);
                        // successfully edits the member
                        if (member.EditMember(id, firstname, surname, gender, phone, email, memberPicture))
                        {
                            MessageBox.Show("Member has been changed.", "Member Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                        else
                        {
                            MessageBox.Show("Member Not Changed.", "Change Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Select Member From Table First.", "No ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid ID entered.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void removeButton1_Click(object sender, EventArgs e)
        {
            // function to delete a member
            int id; 
            // checks if theres an id at all entered
            if(!idTextbox.Text.Trim().Equals(""))
            {
                id = Convert.ToInt32(idTextbox.Text);
                // confirmation prompt
                if (MessageBox.Show("Do you really want to delete this Member?", "Confirmation Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // if it removes the member successfully, return true
                    if (member.RemoveMember(id))
                    {
                        MessageBox.Show("Member has been deleted.", "Member removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        buttonClearFields.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Member Not Deleted.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Incorrect ID.", "No ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dataGridViewMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // when a row is clicked on the data table, it will fill various input fields in automatically
            idTextbox.Text = dataGridViewMembers.CurrentRow.Cells[0].Value.ToString();
            string fullname = dataGridViewMembers.CurrentRow.Cells[1].Value.ToString();
            var firstAndLast = fullname.Split('-');
            fnameTextbox.Text = firstAndLast[0];
            snameTextbox.Text = firstAndLast[1];           
            string gender = dataGridViewMembers.CurrentRow.Cells[2].Value.ToString();
            if(gender.Equals("Male"))
            {
                radioButtonMale.Checked = true;
                radioButtonFemale.Checked = false;
            }
            else
            {
                radioButtonFemale.Checked = true;
                radioButtonMale.Checked = false;
            }
            textBoxPhoneNumber.Text = dataGridViewMembers.CurrentRow.Cells[3].Value.ToString();
            textBoxEmail.Text = dataGridViewMembers.CurrentRow.Cells[4].Value.ToString();
            byte[] pic = (byte[])dataGridViewMembers.CurrentRow.Cells[5].Value;
            MemoryStream ms = new MemoryStream(pic);
            pictureBoxMember.Image = Image.FromStream(ms);
        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            // clears all the fields
            idTextbox.Text = "";
            fnameTextbox.Text = "";
            snameTextbox.Text = "";
            textBoxPhoneNumber.Text = "";
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            textBoxEmail.Text = "";
            pictureBoxMember.ImageLocation = "../../IMAGES/userimage.png";
        }

        private void buttonRefreshTable_Click(object sender, EventArgs e)
        {
            // refreshes the data table
            dataGridViewMembers.DataSource = member.MemberList(true);
        }

        private void textBoxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
