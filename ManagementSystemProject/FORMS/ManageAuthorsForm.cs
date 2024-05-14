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
using System.Xml.Linq;
using System.IO;

namespace ManagementSystemProject.FORMS
{
    public partial class ManageAuthorsForm : Form
    {
        public ManageAuthorsForm()
        {
            InitializeComponent();
        }

        CLASSES.AUTHOR author = new CLASSES.AUTHOR();

        private void ManageAuthorsForm_Load(object sender, EventArgs e)
        {
            addButton1.Image = Image.FromFile("../../IMAGES/addbutton.png");
            editButton1.Image = Image.FromFile("../../IMAGES/editbutton.png");
            removeButton1.Image = Image.FromFile("../../IMAGES/deletebutton.png");

            dataGridViewAuthors.DataSource = author.AuthorList(false);

            dataGridViewAuthors.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridViewAuthors.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridViewAuthors.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewAuthors.EnableHeadersVisualStyles = false;

            authorCountLabel.Text = author.AuthorList(false).Rows.Count.ToString() + " Authors";
        }

        private void closeWindow1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton1_Click(object sender, EventArgs e)
        {
            string firstname = fnameTextbox.Text;
            string surname = snameTextbox.Text;
            string education = educationTextbox.Text;
            string about = aboutRichTextbox.Text;

            if(firstname.Trim().Equals("") || surname.Trim().Equals(""))
            {
                MessageBox.Show("Enter a first name and surname for the Author.", "Empty Author Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (author.AddAuthor(firstname, surname, education, about))
                {
                    MessageBox.Show("New Author has been added.", "New Author", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewAuthors.DataSource = author.AuthorList(false);
                    authorCountLabel.Text = author.AuthorList(false).Rows.Count.ToString() + " Authors";
                }
                else
                {
                    MessageBox.Show("Author Not Added", "Add Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void editButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(idTextbox.Text);
                string firstname = fnameTextbox.Text;
                string surname = snameTextbox.Text;
                string education = educationTextbox.Text;
                string about = aboutRichTextbox.Text;

                if (firstname.Trim().Equals("") || surname.Trim().Equals(""))
                {
                    MessageBox.Show("Enter a first name and surname for the Author.", "Empty Author Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (author.EditAuthor(id, firstname, surname, education, about))
                    {
                        MessageBox.Show("Author has been changed.", "Author Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridViewAuthors.DataSource = author.AuthorList(false);
                    }
                    else
                    {
                        MessageBox.Show("Author Not Changed.", "Change Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid ID entered.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void dataGridViewAuthors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idTextbox.Text = dataGridViewAuthors.CurrentRow.Cells[0].Value.ToString();
            fnameTextbox.Text = dataGridViewAuthors.CurrentRow.Cells[1].Value.ToString();
            snameTextbox.Text = dataGridViewAuthors.CurrentRow.Cells[2].Value.ToString();
            educationTextbox.Text = dataGridViewAuthors.CurrentRow.Cells[3].Value.ToString();
            aboutRichTextbox.Text = dataGridViewAuthors.CurrentRow.Cells[4].Value.ToString();
        }

        private void removeButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(idTextbox.Text);
                if(MessageBox.Show("Do you really want to delete this Author?", "Confirmation Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (author.RemoveAuthor(id))
                    {
                        MessageBox.Show("Author has been removed.", "Removed Author", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        idTextbox.Text = "";
                        fnameTextbox.Text = "";
                        snameTextbox.Text = "";
                        educationTextbox.Text = "";
                        aboutRichTextbox.Text = "";
                        dataGridViewAuthors.DataSource = author.AuthorList(false);
                        authorCountLabel.Text = author.AuthorList(false).Rows.Count.ToString() + " Authors";
                    }
                    else
                    {
                        MessageBox.Show("Author has not been removed.", "Remove Author", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid ID");
            }
        }

        private void showAuthorBooksButton_Click(object sender, EventArgs e)
        {

            int authorID = Convert.ToInt32(dataGridViewAuthors.CurrentRow.Cells[0].Value);
            string fname = dataGridViewAuthors.CurrentRow.Cells[1].Value.ToString();
            string sname = dataGridViewAuthors.CurrentRow.Cells[2].Value.ToString();
            string fullname = fname + " " + sname;
            BooksListForm BkLsFrm = new BooksListForm(authorID, fullname);
            BkLsFrm.Show();
        }

        private void buttonExportAuthors_Click(object sender, EventArgs e)
        {

            if(!Directory.Exists("../authors"))
            {
                Directory.CreateDirectory("../authors");
            }

            string filePath = "../authors/List.txt";

            if(!File.Exists(filePath))
            {
                File.Create(filePath).Close();
                MessageBox.Show("File created.");
            }

            TextWriter writer = new StreamWriter(filePath);

            string id;
            string fname;
            string sname;
            string fullname;

            for(int i = 0; i < dataGridViewAuthors.Rows.Count; i++)
            {
                /*for(int j = 0; j < dataGridViewAuthors.Columns.Count; j++)
                {
                    writer.Write(dataGridViewAuthors.Rows[i].Cells[j].Value.ToString());

                }*/

                id = dataGridViewAuthors.Rows[i].Cells[0].Value.ToString();
                fname = dataGridViewAuthors.Rows[i].Cells[1].Value.ToString();
                sname = dataGridViewAuthors.Rows[i].Cells[2].Value.ToString();
                fullname = fname + " " + sname;
                writer.Write(id + " - " + fullname);
                writer.WriteLine("");
                writer.WriteLine("-------------------------------------");
            }

            writer.Close();
            MessageBox.Show("Data exported.");

        }
    }
}
