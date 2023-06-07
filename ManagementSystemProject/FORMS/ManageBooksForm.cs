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
    public partial class ManageBooksForm : Form
    {
        public ManageBooksForm()
        {
            InitializeComponent();
        }

        CLASSES.BOOKS book = new CLASSES.BOOKS();
        CLASSES.GENRE genre = new CLASSES.GENRE();
        CLASSES.AUTHOR author = new CLASSES.AUTHOR();
        private void closeWindow1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageBooksForm_Load(object sender, EventArgs e)
        {
            addButton1.Image = Image.FromFile("../../IMAGES/addbutton.png");
            editButton1.Image = Image.FromFile("../../IMAGES/editbutton.png");
            removeButton1.Image = Image.FromFile("../../IMAGES/deletebutton.png");
            coverPicturebox.Image = Image.FromFile("../../IMAGES/randombookcover.png");
            coverEditPictureBox.Image = Image.FromFile("../../IMAGES/randombookcover.png");

            CLASSES.GENRE genre = new CLASSES.GENRE();
            genreCombobox.DataSource = genre.GenresList();
            genreCombobox.DisplayMember = "name";
            genreCombobox.ValueMember = "id";
            bookCountLabel.Text = book.BookList().Rows.Count.ToString() + " Books";
            panelAdd.BringToFront();




        }

        private void selectCoverButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*png;*.gif)|*.jpg;*png;*.gif";

            if(opf.ShowDialog() == DialogResult.OK)
            {
                coverPicturebox.Image = Image.FromFile(opf.FileName);
            }

        }

        private void editPictureCover_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*png;*.gif)|*.jpg;*png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                coverEditPictureBox.Image = Image.FromFile(opf.FileName);
            }
        }

        private void selectAuthorButton_Click(object sender, EventArgs e)
        {
            AuthorListForm autLiFo = new AuthorListForm(this);
            autLiFo.Show();
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            
            int authorID;
            int genreID;
            int quantity;
            double price;

            string isbn = ISBNTextbox.Text;
            string title = titleTextbox.Text;
            string publisher = publisherTextbox.Text;
            string about = aboutRichTextbox.Text;
            DateTime dateReceived = dateReceivedDateTimePicker.Value;

            MemoryStream ms = new MemoryStream();
            coverPicturebox.Image.Save(ms, coverPicturebox.Image.RawFormat);
            byte[] bookCover = ms.ToArray();

            try
            {
                
                authorID = Convert.ToInt32(authorIDbox.Text);
                genreID = Convert.ToInt32(genreCombobox.SelectedValue);
                quantity = Convert.ToInt32(numericUpDownQuantity.Value);
                price = Convert.ToDouble(priceTextbox.Text);

                if(!book.isISBNExists(isbn, 0))
                {
                    if(!book.isTitleExists(title, 0))
                    {
                        if (book.addBook(isbn, title, authorID, genreID, quantity, price, publisher, dateReceived, about, bookCover))
                        {
                            MessageBox.Show("New Book has been added.", "New Book", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            bookCountLabel.Text = book.BookList().Rows.Count.ToString() + " Books";
                        }
                        else
                        {
                            MessageBox.Show("Book Not Added", "Add Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This Book title already exists.", "Title Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    
                }
                else
                {
                    MessageBox.Show("ISBN already exists.", "Duplicate ISBN", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach(var control in panelAdd.Controls)
            {
                if(control.GetType() == typeof(TextBox))
                {
                    TextBox tb = (TextBox)control;
                    tb.Text = "";
                }
            }

            int numberOfBooks = book.BookList().Rows.Count + 1;
            int theLastBookId = 0;
            if(numberOfBooks > 1)
            {
                theLastBookId = Convert.ToInt32((book.BookList().Rows.Count+1).ToString());
            }
            idTextbox.Text = Convert.ToString(theLastBookId);
            aboutRichTextbox.Text = "";
            authorIDbox.Text = "ID";
            genreCombobox.SelectedIndex = 0;
            numericUpDownQuantity.Value = 0;
            dateReceivedDateTimePicker.Value = DateTime.Now;
            coverPicturebox.ImageLocation = "../../IMAGES/randombookcover.png";
        }

        private void addButton1_Click(object sender, EventArgs e)
        {
            panelAdd.BringToFront();
            authorTextbox.Text = "";
            authorIDbox.Text = "ID:";
        }

        private void editButton1_Click(object sender, EventArgs e)
        {
            panelEdit.BringToFront();
            genreEditCombobox.DataSource = genre.GenresList();
            genreEditCombobox.DisplayMember = "name";
            genreEditCombobox.ValueMember = "id";
            authorEditTextbox.Text = "";
            anotherIDEdit.Text = "ID:";
        }

        

        private void searchIDButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDEditTextbox.Text);
            DataTable data = book.searchByIDOrISBN("id", id, "");
            if(data.Rows.Count > 0)
            {
                DisplayData(data);

              
            }
            else
            {
                MessageBox.Show("This Book ISBN does not exist.", "No ISBN Found", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void searchISBNButton_Click(object sender, EventArgs e)
        {
            string isbn = ISBNEditTextbox.Text;
            DataTable data = book.searchByIDOrISBN("isbn", 00, isbn);
            if (data.Rows.Count > 0)
            {

                DisplayData(data);
                
            }
            else
            {
                MessageBox.Show("This Book ID does not exist.", "No ID Found", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void selectAuthorEdit_Click(object sender, EventArgs e)
        {
            AuthorListForm autLiFo = new AuthorListForm(this);
            autLiFo.Show();
        }

        private void editBookButton_Click(object sender, EventArgs e)
        {
            int id;
            int authorID;
            int genreID;
            int quantity;
            double price;

            string isbn = ISBNEditTextbox.Text;
            string title = TitleEditTextbox.Text;
            string publisher = publisherEditTextbox.Text;
            string about = EditrichTextbox.Text;
            DateTime dateReceived = editDateTimePicker.Value;

            MemoryStream ms = new MemoryStream();
            coverEditPictureBox.Image.Save(ms, coverEditPictureBox.Image.RawFormat);
            byte[] bookCover = ms.ToArray();

            try
            {
                id = Convert.ToInt32(IDEditTextbox.Text);
                authorID = Convert.ToInt32(anotherIDEdit.Text);
                genreID = Convert.ToInt32(genreEditCombobox.SelectedValue);
                quantity = Convert.ToInt32(numericUpDownQuantityEdit.Value);
                price = Convert.ToDouble(priceEditTextbox.Text);

                if (!book.isISBNExists(isbn, id))
                {
                    if (!book.isTitleExists(title, id))
                    {
                        if (book.editBook(id, isbn, title, authorID, genreID, quantity, price, publisher, dateReceived, about, bookCover))
                        {
                            MessageBox.Show("Book data has been changed.", "Edit Book", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            bookCountLabel.Text = book.BookList().Rows.Count.ToString() + " Books";
                        }
                        else
                        {
                            MessageBox.Show("Book unchanged.", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This Book title already exists.", "Title Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }

                }
                else
                {
                    MessageBox.Show("ISBN already exists.", "Duplicate ISBN", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DisplayData(DataTable data)
        {
            IDEditTextbox.Text = data.Rows[0][0].ToString();
            ISBNEditTextbox.Text = data.Rows[0][1].ToString();
            TitleEditTextbox.Text = data.Rows[0][2].ToString();

            int authorID = Convert.ToInt32(data.Rows[0][3].ToString());
            DataTable authorData = author.getAuthorByID(authorID);
            //firstname                             //surname
            authorEditTextbox.Text = authorData.Rows[0][1].ToString() + " " + authorData.Rows[0][2].ToString();

            anotherIDEdit.Text = data.Rows[0][3].ToString();
            priceEditTextbox.Text = data.Rows[0][6].ToString();
            publisherEditTextbox.Text = data.Rows[0][7].ToString();
            aboutRichTextbox.Text = data.Rows[0][9].ToString();
            numericUpDownQuantityEdit.Value = Convert.ToInt32(data.Rows[0][5].ToString());
            genreEditCombobox.SelectedValue = data.Rows[0][4].ToString();
            editDateTimePicker.Value = (DateTime)data.Rows[0][8];

            byte[] cover = (byte[])data.Rows[0][10];
            MemoryStream ms = new MemoryStream(cover);
            coverEditPictureBox.Image = Image.FromStream(ms);
        }

        private void showBookListButton_Click(object sender, EventArgs e)
        {
            panelShowBooks.BringToFront();

            dataGridViewBookList.RowTemplate.Height = 50;

            dataGridViewBookList.DataSource = book.BookList();

            DataGridViewImageColumn dvgImgCol = new DataGridViewImageColumn();
            dvgImgCol = (DataGridViewImageColumn)dataGridViewBookList.Columns[10];
            dvgImgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridViewBookList.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridViewBookList.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridViewBookList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewBookList.EnableHeadersVisualStyles = false;

            

        }

        private void removeButton1_Click(object sender, EventArgs e)
        {
            RemoveBookForm reBoFo = new RemoveBookForm();
            reBoFo.Show();
        }

        private void buttonEditBookData_Click(object sender, EventArgs e)
        {
            panelEdit.BringToFront();

            genreEditCombobox.DataSource = genre.GenresList();
            genreEditCombobox.DisplayMember = "name";
            genreEditCombobox.ValueMember = "id";

            int id = Convert.ToInt32(dataGridViewBookList.CurrentRow.Cells[0].Value);
            DataTable data = book.searchByIDOrISBN("id", id, "");
            if (data.Rows.Count > 0)
            {
                DisplayData(data);


            }
            else
            {
                MessageBox.Show("This Book ISBN does not exist.", "No ISBN Found", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void buttonExportBooks_Click(object sender, EventArgs e)
        {

            showBookListButton.PerformClick();

            if (!Directory.Exists("../books"))
            {
                Directory.CreateDirectory("../books");
            }

            string filePath = "../books/booklist.txt";

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
                MessageBox.Show("File created.");
            }

            TextWriter writer = new StreamWriter(filePath);

            string id;
            string isbn;
            string title;
            

            for (int i = 0; i < dataGridViewBookList.Rows.Count; i++)
            {
                /*for(int j = 0; j < dataGridViewAuthors.Columns.Count; j++)
                {
                    writer.Write(dataGridViewAuthors.Rows[i].Cells[j].Value.ToString());

                }*/

                id = dataGridViewBookList.Rows[i].Cells[0].Value.ToString();
                isbn = dataGridViewBookList.Rows[i].Cells[1].Value.ToString();
                title = dataGridViewBookList.Rows[i].Cells[2].Value.ToString();
                
                writer.Write(id + " - " + isbn + " - " + title);
                writer.WriteLine("");
                writer.WriteLine("-------------------------------------");
            }

            writer.Close();
            MessageBox.Show("Data exported.");
        }

        private void buttonRemoveBookData_Click(object sender, EventArgs e)
        {
            try
            {
                int bookID = Convert.ToInt32(dataGridViewBookList.CurrentRow.Cells[0].Value);
                if (MessageBox.Show("Do you really want to delete this Book?", "Confirmation Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (book.deleteBook(bookID))
                    {
                        MessageBox.Show("Book has been removed.", "Removed Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Book has not been removed.", "Remove Book", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("No book is selected. | " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }
    }
}
