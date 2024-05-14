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

namespace ManagementSystemProject.FORMS
{
    public partial class ManageGenresForm : Form
    {
        CLASSES.GENRE genre = new CLASSES.GENRE();
        public ManageGenresForm()
        {
            InitializeComponent();
        }     
        private void ManageGenresForm_Load(object sender, EventArgs e)
        {
            // loads images and database for the UI
            addButton.Image = Image.FromFile("../../IMAGES/addbutton.png");
            editButton.Image = Image.FromFile("../../IMAGES/editbutton.png");
            deleteButton.Image = Image.FromFile("../../IMAGES/deletebutton.png");

            dataGridViewGenres.DataSource = genre.GenresList();

            dataGridViewGenres.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridViewGenres.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridViewGenres.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewGenres.EnableHeadersVisualStyles = false;
        }
        private void closeWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameTextbox.Text;           
            if(name.Trim().Equals(""))
            {
                MessageBox.Show("Enter the Genre Name", "Empty Genre Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if(genre.AddGenre(name))
                {
                    MessageBox.Show("New Genre has been added.", "New Genre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewGenres.DataSource = genre.GenresList();
                }
                else
                {
                    MessageBox.Show("Genre Not Added", "Add Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(idTextbox.Text);
                string name = nameTextbox.Text;
                if (name.Trim().Equals(""))
                {
                    MessageBox.Show("Enter the Genre Name", "Empty Genre Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    if (genre.EditGenre(id, name))
                    {
                        MessageBox.Show("Genre name has been updated.", "Updated Genre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridViewGenres.DataSource = genre.GenresList();
                    }
                    else
                    {
                        MessageBox.Show("Genre Not Updated", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Invalid ID");
            }
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(idTextbox.Text);
                if (MessageBox.Show("Do you really want to delete this Author?", "Confirmation Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (genre.RemoveGenre(id))
                    {
                        MessageBox.Show("Genre has been removed.", "Removed Genre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        idTextbox.Text = "";
                        nameTextbox.Text = "";
                        dataGridViewGenres.DataSource = genre.GenresList();
                    }
                    else
                    {
                        MessageBox.Show("Genre has not been removed.", "Remove Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid ID");
            }
        }

        private void dataGridViewGenres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idTextbox.Text = dataGridViewGenres.CurrentRow.Cells[0].Value.ToString();
            nameTextbox.Text = dataGridViewGenres.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
