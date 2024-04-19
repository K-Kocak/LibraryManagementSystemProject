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
    public partial class BookInfoCardForm : Form
    {

        int bookID;
        readonly CLASSES.BOOKS book = new CLASSES.BOOKS();
        readonly CLASSES.AUTHOR author = new CLASSES.AUTHOR();
        public BookInfoCardForm(int id)
        {
            InitializeComponent();
            bookID = id;
        }
        private void closeWindow1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BookInfoCardForm_Load(object sender, EventArgs e)
        {
            //int id = 00;
            try
            {
                // Gets info on specified book, and fills out text boxes with the data from that book
                DataRow data = book.getBookInfo(bookID);
                labelISBN.Text = data["isbn"].ToString();
                labelTitle.Text = data["title"].ToString();
                labelAuthor.Text = data["author"].ToString();
                labelGenre.Text = data["genre"].ToString();
                int qty = Convert.ToInt32(data["quantity"].ToString());
                // qty == 0 meaning no books
                if(qty == 0)
                {
                    labelQuantity.BackColor = Color.Red;
                }
                labelQuantity.Text = data["quantity"].ToString();
                labelPrice.Text = data["price"].ToString();
                labelPublisher.Text = data["publisher"].ToString();
                labelDateAdded.Text = data["dateReceived"].ToString();
                richTextBoxDescription.Text = data["about"].ToString();
                // display the cover of the book on the form
                byte[] cover = (byte[])data["cover"];
                MemoryStream ms = new MemoryStream(cover);
                pictureBoxBookCover.Image = Image.FromStream(ms);
                pictureBoxBookCover.BackgroundImageLayout = ImageLayout.Stretch;
            } catch(Exception ex)
            {
                MessageBox.Show("No Book To Show: " + ex.Message);
                labelQuantity.Visible = false;
            }
            
        }
    }
}
