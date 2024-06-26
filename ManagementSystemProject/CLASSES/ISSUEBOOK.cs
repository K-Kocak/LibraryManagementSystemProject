﻿using MySql.Data.MySqlClient;
using System;
using System.Data;
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
            return db.SetData(query, parameter) == 1;

        }
        public int CountIssuedCopiesOfThisBook(int bookID)
        {
            // finds all the books from issuebook that has the given book id with status issued
            string query = "SELECT * FROM `issuebook` where `bookID`=@id and status = 'issued'";
            MySqlParameter[] parameter = new MySqlParameter[1];
            parameter[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameter[0].Value = bookID;
            return db.GetData(query, parameter).Rows.Count;          
        }
        public Boolean CheckBookAvailability(int bookID)
        {   
            int bookQuantity = Convert.ToInt32(book.GetBookInfo(bookID)["quantity"].ToString());
            int issuedCopies = CountIssuedCopiesOfThisBook(bookID);
            /* checks if the number of books for that book is greater than the total number of books issued
              if so, then a book must be available, else no book is available to issue out*/   
            return bookQuantity > issuedCopies;
        }
        public DataTable IssueBookList(string status)
        {
            string query = !status.Equals("") ?
                "SELECT * FROM `issuebook` WHERE `status`='" + status + "'"
                :
                "SELECT * FROM `issuebook`";
            //string query = "SELECT * FROM `issuebook`";
            //if (!status.Equals(""))
            //{
            //    query = "SELECT * FROM `issuebook` WHERE `status`='"+status+"'";
            //}
            // if a status was parsed in, selects issuebooks which have the status passed in, then returns the data table
            //DataTable table = new DataTable();
            return db.GetData(query, null);
        }
        public Boolean ReturnBook(int bookID, int memberID, string status, DateTime issueDate, DateTime returnDate, string note)
        {
            // updates an issued book to either "lost" or "returned" depending on what "status" was passed in
            // bug typo fix, bId should be bID, and bookid should be bookID
            string query = "UPDATE `issuebook` SET `status`=@stat, `returndate`=@returnDa, `note`=@note WHERE `bookid`=@bID AND `memberid`=@mID AND `issuedate`=@issueDa";
            MySqlParameter[] parameter = new MySqlParameter[6];
            parameter[2] = new MySqlParameter("@stat", MySqlDbType.VarChar);
            parameter[2].Value = status;
            parameter[4] = new MySqlParameter("@returnDa", MySqlDbType.Date);
            parameter[4].Value = returnDate;
            parameter[5] = new MySqlParameter("@note", MySqlDbType.VarChar);
            parameter[5].Value = note;
            parameter[0] = new MySqlParameter("@bID", MySqlDbType.Int32);
            parameter[0].Value = bookID;
            parameter[1] = new MySqlParameter("@mID", MySqlDbType.Int32);
            parameter[1].Value = memberID;
            parameter[3] = new MySqlParameter("@issueDa", MySqlDbType.Date);
            parameter[3].Value = issueDate;

            return db.SetData(query, parameter) == 1;
        }
        public Boolean RemoveBook(int bookID, int memberID, DateTime issueDate)
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

            return db.SetData(query, parameter) == 1;
        }
        public Boolean IsBookStillIssuedByMember(int memberID, int bookID)
        {
            // similar to removeBook, finds if a book issued is still "issued" as status for a given member & book id.
            // bug fix, typo on query statement
            string query = "SELECT * FROM `issuebook` WHERE status = 'issued' AND `bookID`=@bookid AND `memberID`=@memberid";
            MySqlParameter[] parameter = new MySqlParameter[2];
            parameter[0] = new MySqlParameter("@bookid", MySqlDbType.Int32);
            parameter[0].Value = bookID;
            parameter[1] = new MySqlParameter("@memberid", MySqlDbType.Int32);
            parameter[1].Value = memberID;
            //DataTable table = db.GetData(query, parameter);
            // if it finds something, then table rows count will be greater than zero, hence return true
            //return table.Rows.Count > 0;
            return db.GetData(query, parameter).Rows.Count > 0;
        }
    }
}
