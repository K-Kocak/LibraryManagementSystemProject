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
    public partial class BooksListForm : Form
    {
        int authorID;
        string fullname;
        public BooksListForm(int id, string Fullname)
        {
            InitializeComponent();
            this.authorID = id;
            this.fullname = Fullname;
        }

        private void closeLoginWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BooksListForm_Load(object sender, EventArgs e)
        {
            labelAuthor.Text = "Books by: " + fullname; 

            CLASSES.BOOKS book = new CLASSES.BOOKS();
            DataTable bookList = book.authorBooks(authorID);

            ListViewItem[] items = new ListViewItem[bookList.Rows.Count];
            String[] titles = new string[bookList.Rows.Count];

            for(int i = 0; i < bookList.Rows.Count; i++)
            {
                byte[] img = (byte[])bookList.Rows[i][10];
                MemoryStream ms = new MemoryStream(img);

                imageListBookCovers.Images.Add(Image.FromStream(ms));

                titles[i] = bookList.Rows[i][2].ToString();


            }

            listViewBooks.View = View.LargeIcon;
            imageListBookCovers.ImageSize = new Size(200, 250);
            listViewBooks.LargeImageList = imageListBookCovers;

            for(int j = 0; j < imageListBookCovers.Images.Count; j++)
            {
                listViewBooks.Items.Add(new ListViewItem() { Text = titles[j], ImageIndex = j });
            }
        }
    }
}
