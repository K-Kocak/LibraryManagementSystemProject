using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace ManagementSystemProject.FORMS
{
    public partial class BookInfoCardForm : Form
    {

        int bookID;
        readonly CLASSES.BOOKS book = new CLASSES.BOOKS();
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
                // UI Improvements
                // Gets info on specified book, and fills out text boxes with the data from that book
                DataRow data = book.GetBookInfo(bookID);
                labelISBN.Text = "ISBN : " + data["isbn"].ToString();
                labelTitle.Text = "Title : " + data["title"].ToString();
                labelAuthor.Text = "Author : " + data["author"].ToString();
                labelGenre.Text = "Genre : " + data["genre"].ToString();
                int qty = Convert.ToInt32(data["quantity"].ToString());
                // qty == 0 meaning no books
                if(qty == 0)
                {
                    labelQuantity.BackColor = Color.Red;
                }
                labelQuantity.Text = data["quantity"].ToString();
                labelPrice.Text = "Price : " + data["price"].ToString();
                labelPublisher.Text = "Publisher : " + data["publisher"].ToString();
                labelDateAdded.Text = "Date Added : " + data["dateReceived"].ToString();
                richTextBoxDescription.Text = data["about"].ToString();
                // display the cover of the book on the form
                byte[] cover = (byte[])data["cover"];
                MemoryStream ms = new MemoryStream(cover);
                pictureBoxBookCover.Image = Image.FromStream(ms);
                pictureBoxBookCover.BackgroundImageLayout = ImageLayout.Stretch;
            } 
            catch(Exception ex)
            {
                MessageBox.Show("No Book To Show: " + ex.Message);
                // bug fix
                this.Close();
                labelQuantity.Visible = false;
            }
            
        }
    }
}
