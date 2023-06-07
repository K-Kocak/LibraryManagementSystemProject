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
    public partial class MemberInfoCard : Form
    {

        int memberID;
        public MemberInfoCard(int id)
        {
            InitializeComponent();
            memberID = id;
        }

        CLASSES.BOOKS book = new CLASSES.BOOKS();
        CLASSES.AUTHOR author = new CLASSES.AUTHOR();
        CLASSES.MEMBER member = new CLASSES.MEMBER();

        private void closeWindow1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void MemberInfoCard_Load(object sender, EventArgs e)
        {
            try
            {
                DataRow data = member.getMemberByID(memberID);
                labelID.Text = data["id"].ToString();
                labelFullname.Text = data["firstname"].ToString() + " " + data["surname"].ToString();
                labelGender.Text = data["gender"].ToString();
                labelPhone.Text = data["phone"].ToString();
                labelEmail.Text = data["email"].ToString();


                byte[] cover = (byte[])data["picture"];
                MemoryStream ms = new MemoryStream(cover);
                pictureBoxMemberPic.Image = Image.FromStream(ms);
            }catch(Exception ex)
            {
                MessageBox.Show("No Member To Show: " + ex.Message);
            }
        }
    }
}
