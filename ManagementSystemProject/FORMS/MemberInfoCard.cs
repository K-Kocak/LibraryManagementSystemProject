using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace ManagementSystemProject.FORMS
{
    public partial class MemberInfoCard : Form
    {
        CLASSES.MEMBER member = new CLASSES.MEMBER();
        int memberID;
        public MemberInfoCard(int id)
        {
            InitializeComponent();
            memberID = id;
        }
        private void closeWindow1_Click(object sender, EventArgs e)
        {
            // close form
            this.Close();
        }

        private void MemberInfoCard_Load(object sender, EventArgs e)
        {
            try
            {
                // loads the card for a particular member, goes into getMemberByID to find this user, once found, uses this data to fill in the fields
                DataRow data = member.GetMemberByID(memberID);
                labelID.Text = data["id"].ToString();
                labelFullname.Text = data["firstname"].ToString() + " " + data["surname"].ToString();
                labelGender.Text = data["gender"].ToString();
                labelPhone.Text = data["phone"].ToString();
                labelEmail.Text = data["email"].ToString();
                byte[] cover = (byte[])data["picture"];
                MemoryStream ms = new MemoryStream(cover);
                pictureBoxMemberPic.Image = Image.FromStream(ms);
            }
            catch(Exception ex)
            {
                // doesnt find a member? throws exception
                MessageBox.Show("No Member To Show: " + ex.Message);
            }
        }
    }
}
