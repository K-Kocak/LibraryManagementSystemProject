using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ManagementSystemProject.CLASSES
{
    internal class ISSUEBOOK
    {
        THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();
        CLASSES.BOOKS book = new CLASSES.BOOKS();
        public bool IssueBook(int bookID, int memberID, string status, DateTime issueDate, DateTime returnDate, string note)
        {
            /* inserts book into the issueBook database, with the id of the book, the id of the member who has it
             the current status of the book (issued or lost), the date of issue, the return date and any notes*/
            string query = "INSERT INTO `issuebook`(`bookid`, `memberid`, `status`, `issuedate`, `returndate`, `note`) " +
                "VALUES (@bID, @mID, @stat, @issueDa, @returnDa, @note)";
            MySqlParameter[] parameter = new MySqlParameter[6];
            parameter[0] = new MySqlParameter("@bID", MySqlDbType.Int32);
            parameter[0].Value = bookID;
            parameter[1] = new MySqlParameter("@mID", MySqlDbType.Int32);
            parameter[1].Value = memberID;
            parameter[2] = new MySqlParameter("@stat", MySqlDbType.VarChar);
            parameter[2].Value = status;
            parameter[3] = new MySqlParameter("@issueDa", MySqlDbType.Date);
            parameter[3].Value = issueDate;
            parameter[4] = new MySqlParameter("@returnDa", MySqlDbType.Date);
            parameter[4].Value = returnDate;
            parameter[5] = new MySqlParameter("@note", MySqlDbType.VarChar);
            parameter[5].Value = note;

            return db.setData(query, parameter) == 1 ? true : false;

        }
        public int countIssuedCopiesOfThisBook(int bookID)
        {
            // finds all the books from issuebook that has the given book id with status issued
            string query = "SELECT * FROM `issuebook` where `bookID`=@id and status = 'issued'";
            MySqlParameter[] parameter = new MySqlParameter[1];
            parameter[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameter[0].Value = bookID;

            return db.getData(query, parameter).Rows.Count;          
        }
        public Boolean checkBookAvailability(int bookID)
        {   
            int bookQuantity = Convert.ToInt32(book.getBookInfo(bookID)["quantity"].ToString());
            int issuedCopies = countIssuedCopiesOfThisBook(bookID);
            /* checks if the number of books for that book is greater than the total number of books issued
              if so, then a book must be available, else no book is available to issue out*/   
            return bookQuantity > issuedCopies ? true : false;
        }
        public DataTable IssueBookList(string status)
        {
            string query = "SELECT * FROM `issuebook`";
            if (!status.Equals(""))
            {
                query = "SELECT * FROM `issuebook` WHERE `status`='"+status+"'";
            }
            // if a status was parsed in, selects issuebooks which have the status passed in, then returns the data table
            DataTable table = new DataTable();
            return db.getData(query, null);
        }
        public Boolean returnBook(int bookID, int memberID, string status, DateTime issueDate, DateTime returnDate, string note)
        {
            // updates an issued book to either "lost" or "returned" depending on what "status" was passed in
            string query = "UPDATE `issuebook` SET `status`=@stat, `returndate`=@returnDa, `note`=@note where `bookid`=@bId AND `memberID`=@mID AND `issueDate`=@issueDa";
            MySqlParameter[] parameter = new MySqlParameter[6];
            parameter[0] = new MySqlParameter("@stat", MySqlDbType.VarChar);
            parameter[0].Value = status;
            parameter[1] = new MySqlParameter("@returnDa", MySqlDbType.Date);
            parameter[1].Value = returnDate;
            parameter[2] = new MySqlParameter("@note", MySqlDbType.VarChar);
            parameter[2].Value = note;
            parameter[3] = new MySqlParameter("@bID", MySqlDbType.Int32);
            parameter[3].Value = bookID;
            parameter[4] = new MySqlParameter("@mID", MySqlDbType.Int32);
            parameter[4].Value = memberID;
            parameter[5] = new MySqlParameter("@issueDa", MySqlDbType.Date);
            parameter[5].Value = issueDate;

            return db.setData(query, parameter) == 1 ? true : false;
        }
        public Boolean removeBook(int bookID, int memberID, DateTime issueDate)
        {
            // deletes issuebook in table where book id, member id and issuedate equal the value passed in 
            string query = "DELETE FROM `issuebook` WHERE `bookID`=@bookid AND `memberID`=@memberid AND `issueDate`=@issueDa";
            MySqlParameter[] parameter = new MySqlParameter[3];
            parameter[0] = new MySqlParameter("@bookid", MySqlDbType.Int32);
            parameter[0].Value = bookID;
            parameter[1] = new MySqlParameter("@memberid", MySqlDbType.Int32);
            parameter[1].Value = memberID;
            parameter[2] = new MySqlParameter("@issueDa", MySqlDbType.Date);
            parameter[2].Value = issueDate;

            return db.setData(query, parameter) == 1 ? true : false;
        }
        public Boolean isBookStillIssuedByMember(int memberID, int bookID)
        {
            // similar to removeBook, finds if a book issued is still "issued" as status for a given member & book id.
            string query = "SELECT * FROM `issuebook` WHERE `status`=`issued` AND `bookID`=@bookid AND `memberID`=@memberid";
            MySqlParameter[] parameter = new MySqlParameter[2];
            parameter[0] = new MySqlParameter("@bookid", MySqlDbType.Int32);
            parameter[0].Value = bookID;
            parameter[1] = new MySqlParameter("@memberid", MySqlDbType.Int32);
            parameter[1].Value = memberID;
            DataTable table = db.getData(query, parameter);
            // if it finds something, then table rows count will be greater than zero, hence return true
            return table.Rows.Count > 0 ? true : false;
        }
    }
}
