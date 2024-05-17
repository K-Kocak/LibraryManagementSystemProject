using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace ManagementSystemProject.FORMS
{
    public partial class ManageCirculationForm : Form
    {
        CLASSES.BOOKS books = new CLASSES.BOOKS();
        CLASSES.MEMBER member = new CLASSES.MEMBER();
        CLASSES.ISSUEBOOK issueBook = new CLASSES.ISSUEBOOK();
        public ManageCirculationForm()
        {
            InitializeComponent();
        } 
        private void closeWindow1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ManageCirculationForm_Load(object sender, EventArgs e)
        {
            // bring the issue panel to front, applies some styles to the data grid
            panelIssue.BringToFront();
            dataGridViewIssuedBook.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridViewIssuedBook.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridViewIssuedBook.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewIssuedBook.EnableHeadersVisualStyles = false;
            // show actual issue book count
            bookCountLabel.Text = issueBook.IssueBookList("").Rows.Count.ToString() + " Issued Books";
        }
        private void buttonSearchBook_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(numericUpDownBookID.Value);
            DataTable table = books.SearchByIDOrISBN("id", id, "");
            // searches for the book, if found (indicated by the number of rows of table being greater than 0)
            // it will start to fill in some fields as appropriate.
            if(table.Rows.Count > 0)
            {
                labelTitle.Text = table.Rows[0][2].ToString();
                labelTitle.ForeColor = Color.DeepSkyBlue;

                if (issueBook.CheckBookAvailability(id))
                {
                    labelAvailability.ForeColor = Color.Green;
                    labelAvailability.Text = "Yes";
                }
                else
                {
                    labelAvailability.ForeColor = Color.Red;
                    labelAvailability.Text = "No";
                }
            }
            else
            {
                labelTitle.Text = "This book does not exist.";
                labelTitle.ForeColor = Color.Red;
            }

        }
        private void buttonSearchMember_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(numericUpDownMemberID.Value);
            DataRow row = member.GetMemberByID(id);
            // searches for the member, if it finds the member (indicated by row != null) sets values appropriately.
            if (row != null)
            {
                labelMember.Text = row["firstname"]+" "+row["surname"].ToString();
                labelMember.ForeColor = Color.DeepSkyBlue;
            }
            else
            {
                labelMember.Text = "This member does not exist.";
                labelMember.ForeColor = Color.Red;
            }
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {
            int bookID = Convert.ToInt32(numericUpDownBookID.Value);
            BookInfoCardForm BookCard = new BookInfoCardForm(bookID);
            BookCard.ShowDialog();
        }

        private void labelTitle_MouseEnter(object sender, EventArgs e)
        {
            labelTitle.Font = new Font(labelTitle.Font.FontFamily, 13, FontStyle.Underline);
        }

        private void labelTitle_MouseLeave(object sender, EventArgs e)
        {
            labelTitle.Font = new Font(labelTitle.Font.FontFamily, 12, FontStyle.Regular);
        }

        private void labelMember_MouseEnter(object sender, EventArgs e)
        {
            labelMember.Font = new Font(labelTitle.Font.FontFamily, 13, FontStyle.Underline);
        }

        private void labelMember_MouseLeave(object sender, EventArgs e)
        {
            labelMember.Font = new Font(labelTitle.Font.FontFamily, 12, FontStyle.Regular);
        }
        private void labelMember_Click(object sender, EventArgs e)
        {
            int memberID = Convert.ToInt32(numericUpDownMemberID.Value);
            MemberInfoCard MemberCard = new MemberInfoCard(memberID);
            MemberCard.ShowDialog();
        }
        private void buttonIssueBook_Click(object sender, EventArgs e)
        {
            // attempts to issue the book
            int bookID = Convert.ToInt32(numericUpDownBookID.Value);
            int memberID = Convert.ToInt32(numericUpDownMemberID.Value);
            DateTime issueDate = dateTimePickerIssue.Value;
            DateTime returnDate = dateTimePickerReturn.Value;
            string note = richTextBoxNote.Text;
            try
            {
                // checks if the specific book is issued to this specific member
                if (issueBook.IsBookStillIssuedByMember(memberID, bookID))
                {
                    MessageBox.Show("A copy of this book is still issued to this member.", "Issued Book", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    // checks if any books are even available to be issued
                    if (issueBook.CheckBookAvailability(bookID))
                    {
                        // checks if return date is later than issue date
                        if (issueDate < returnDate)
                        {
                            // returns true if it succesfully issues the book
                            if (issueBook.IssueBook(bookID, memberID, "Issued", issueDate, returnDate, note))
                            {
                                MessageBox.Show("Book Issued", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("The return date should be after the issue date.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("This book is not available at the moment.", "Not available.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Make sure to enter a valid book and member ID. | " + ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }         
        }

        private void buttonIssue_Click(object sender, EventArgs e)
        {
            panelIssue.BringToFront();
            panelIssue.Visible = true;
            panelReturn.Visible = false;
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            // brings the return panel to the front
            panelReturn.Visible = true;
            panelReturn.BringToFront();
            panelIssue.Visible = false;         
            dataGridViewIssuedBook.DataSource = issueBook.IssueBookList("");          
        }

        private void dataGridViewIssuedBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numericUpDownBookID2.Value = (int)dataGridViewIssuedBook.CurrentRow.Cells[0].Value;
            numericUpDownMemberID2.Value = (int)dataGridViewIssuedBook.CurrentRow.Cells[1].Value;
            dateTimePickerIssueDate2.Value = (DateTime)dataGridViewIssuedBook.CurrentRow.Cells[3].Value;
            dateTimePickerReturnDate2.Value = (DateTime)dataGridViewIssuedBook.CurrentRow.Cells[4].Value;
            richTextBoxNote2.Text = dataGridViewIssuedBook.CurrentRow.Cells[5].Value.ToString();

            int bookID = Convert.ToInt32(numericUpDownBookID2.Value);
            DataRow bookData = books.GetBookInfo(bookID);
            labelTitle2.Text = bookData["title"].ToString();

            int memberID = Convert.ToInt32(numericUpDownMemberID2.Value);
            DataRow row = member.GetMemberByID(memberID);
            labelMember2.Text = row["firstname"] + " " + row["surname"].ToString();
        }

        private void buttonReturnBook_Click(object sender, EventArgs e)
        {
            int bookID = Convert.ToInt32(numericUpDownBookID2.Value);
            int memberID = Convert.ToInt32(numericUpDownMemberID2.Value);
            DateTime issueDate = dateTimePickerIssueDate2.Value;
            DateTime returnDate = dateTimePickerReturnDate2.Value;
            string note = richTextBoxNote2.Text;

            try
            {
                // this just checks if the book id entered actually exists
                if (issueBook.CheckBookAvailability(bookID))
                {
                    // checking if return date is past the issue date
                    if (issueDate < returnDate)
                    {
                        // if it succesfully returns the book
                        if (issueBook.ReturnBook(bookID, memberID, "returned", issueDate, returnDate, note))
                        {
                            MessageBox.Show("Book Returned", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The return date should be after the issue date.");
                    }
                }
                else
                {
                    MessageBox.Show("This book is not available at the moment.", "Not available.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Make sure to enter a valid book and member ID. | " + ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void buttonBookLost_Click(object sender, EventArgs e)
        {
            // function called if the book is lost due to a member
            int bookID = Convert.ToInt32(numericUpDownBookID2.Value);
            int memberID = Convert.ToInt32(numericUpDownMemberID2.Value);
            DateTime issueDate = dateTimePickerIssueDate2.Value;
            DateTime returnDate = dateTimePickerReturnDate2.Value;
            string note = richTextBoxNote2.Text;
            
            if (issueDate < returnDate)
            {
                // book is lost if this function call returns true
                if (issueBook.ReturnBook(bookID, memberID, "lost", issueDate, issueDate, note))
                {
                    MessageBox.Show("Book Lost", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // tries to reduce book quantity of this book by one
                    if (books.BookQuantityMinusOne(bookID))
                    {
                    MessageBox.Show("Book Quantity Updated.", "New Quantity Set", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("The return date should be after the issue date.");
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // attempts to delete a book thats been issued
            int bookID = Convert.ToInt32(numericUpDownBookID2.Value);
            int memberID = Convert.ToInt32(numericUpDownMemberID2.Value);
            DateTime issueDate = dateTimePickerIssueDate2.Value;
            if(issueBook.RemoveBook(bookID, memberID, issueDate))
            {
                MessageBox.Show("Data deleted.", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data failed to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonIssued_Click(object sender, EventArgs e)
        {
            dataGridViewIssuedBook.DataSource = issueBook.IssueBookList("issued");
        }

        private void buttonReturned_Click(object sender, EventArgs e)
        {
            dataGridViewIssuedBook.DataSource = issueBook.IssueBookList("returned");
        }

        private void buttonLost_Click(object sender, EventArgs e)
        {
            dataGridViewIssuedBook.DataSource = issueBook.IssueBookList("lost");
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            dataGridViewIssuedBook.DataSource = issueBook.IssueBookList("");
        }

        private void refreshbutton_Click(object sender, EventArgs e)
        {
            dataGridViewIssuedBook.DataSource = issueBook.IssueBookList("");
        }
    }
}
