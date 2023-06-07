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

            if (db.setData(query, parameter) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public int countIssuedCopiesOfThisBook(int bookID)
        {
            string query = "SELECT * FROM `issuebook` where `bookID`=@id and status = 'issued'";
            MySqlParameter[] parameter = new MySqlParameter[1];

            parameter[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameter[0].Value = bookID;

            return db.getData(query, parameter).Rows.Count;
            
        }

        public Boolean checkBookAvailability(int bookID)
        {
            Boolean availability;

            int bookQuantity = Convert.ToInt32(book.getBookInfo(bookID)["quantity"].ToString());

            int issuedCopies = countIssuedCopiesOfThisBook(bookID);



            if (bookQuantity > issuedCopies)
            {
                
                availability = true;
            }
            else
            {
                availability = false;
            }
            return availability;
        }

        public DataTable IssueBookList(string status)
        {
            string query = "SELECT * FROM `issuebook`";

            if (!status.Equals(""))
            {
                query = "SELECT * FROM `issuebook` WHERE `status`='"+status+"'";
            }

            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table;
        }

        public Boolean returnBook(int bookID, int memberID, string status, DateTime issueDate, DateTime returnDate, string note)
        {
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

            if (db.setData(query, parameter) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public Boolean removeBook(int bookID, int memberID, DateTime issueDate)
        {
            string query = "DELETE FROM `issuebook` WHERE `bookID`=@bookid AND `memberID`=@memberid AND `issueDate`=@issueDa";
            MySqlParameter[] parameter = new MySqlParameter[3];

            parameter[0] = new MySqlParameter("@bookid", MySqlDbType.Int32);
            parameter[0].Value = bookID;
            parameter[1] = new MySqlParameter("@memberid", MySqlDbType.Int32);
            parameter[1].Value = memberID;

            parameter[2] = new MySqlParameter("@issueDa", MySqlDbType.Date);
            parameter[2].Value = issueDate;

            if (db.setData(query, parameter) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean isBookStillIssuedByMember(int memberID, int bookID)
        {
            string query = "SELECT * FROM `issuebook` WHERE `status`=`issued` AND `bookID`=@bookid AND `memberID`=@memberid";
            MySqlParameter[] parameter = new MySqlParameter[2];

            parameter[0] = new MySqlParameter("@bookid", MySqlDbType.Int32);
            parameter[0].Value = bookID;
            parameter[1] = new MySqlParameter("@memberid", MySqlDbType.Int32);
            parameter[1].Value = memberID;

            DataTable table = db.getData(query, parameter);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }




    }
}
