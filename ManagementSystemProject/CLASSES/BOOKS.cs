using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace ManagementSystemProject.CLASSES
{
    internal class BOOKS
    {
        THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();

        public bool addBook(string isbn, string title, int authorID, int genreID, 
            int quantity, double price, string publisher, DateTime dateReceived, string about, byte[] cover)
        {
            // takes in several parameters inside the UI and passes them into this function, uses this data to create a new entry in the books database
            string query = "INSERT INTO `books`(`isbn`, `title`, `authorID`, `genreID`, `quantity`, " +
                "`price`, `publisher`, `dateReceived`, `about`, `cover`) VALUES (@isbn, @title, @author, @genre, " +
                "@qty, @price, @publisher, @drecv, @abo, @img)";
            MySqlParameter[] parameter = new MySqlParameter[10];           
            parameter[0] = new MySqlParameter("@isbn", MySqlDbType.VarChar);
            parameter[0].Value = isbn;
            parameter[1] = new MySqlParameter("@title", MySqlDbType.VarChar);
            parameter[1].Value = title;
            parameter[2] = new MySqlParameter("@author", MySqlDbType.Int32);
            parameter[2].Value = authorID;
            parameter[3] = new MySqlParameter("@genre", MySqlDbType.Int32);
            parameter[3].Value = genreID;
            parameter[4] = new MySqlParameter("@qty", MySqlDbType.Int32);
            parameter[4].Value = quantity;
            parameter[5] = new MySqlParameter("@price", MySqlDbType.Double);
            parameter[5].Value = price;
            parameter[6] = new MySqlParameter("@publisher", MySqlDbType.VarChar);
            parameter[6].Value = publisher;
            parameter[7] = new MySqlParameter("@drecv", MySqlDbType.Date);
            parameter[7].Value = dateReceived;
            parameter[8] = new MySqlParameter("@abo", MySqlDbType.VarChar);
            parameter[8].Value = about;
            parameter[9] = new MySqlParameter("@img", MySqlDbType.Blob);
            parameter[9].Value = cover;
            // return true if it was able to successfully insert the new book
            if (db.setData(query, parameter) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool editBook(int id, string isbn, string title, int authorID, int genreID,
            int quantity, double price, string publisher, DateTime dateReceived, string about, byte[] cover)
        {
            // similar to add book, finds the book with selected ID and changes all the parameters appropriately as given
            string query = "UPDATE `books` SET `isbn`=@isbn, `title`=@title, `authorID`=@author, `genreID`=@genre, `quantity`=@qty, `price`=@price, " +
                "`publisher`=@publisher, `dateReceived`=@drecv, `about`=@abo, `cover`=@img WHERE `id`=@id";
            MySqlParameter[] parameter = new MySqlParameter[11];
            parameter[0] = new MySqlParameter("@isbn", MySqlDbType.VarChar);
            parameter[0].Value = isbn;
            parameter[1] = new MySqlParameter("@title", MySqlDbType.VarChar);
            parameter[1].Value = title;
            parameter[2] = new MySqlParameter("@author", MySqlDbType.Int32);
            parameter[2].Value = authorID;
            parameter[3] = new MySqlParameter("@genre", MySqlDbType.Int32);
            parameter[3].Value = genreID;
            parameter[4] = new MySqlParameter("@qty", MySqlDbType.Int32);
            parameter[4].Value = quantity;
            parameter[5] = new MySqlParameter("@price", MySqlDbType.Double);
            parameter[5].Value = price;
            parameter[6] = new MySqlParameter("@publisher", MySqlDbType.VarChar);
            parameter[6].Value = publisher;
            parameter[7] = new MySqlParameter("@drecv", MySqlDbType.Date);
            parameter[7].Value = dateReceived;
            parameter[8] = new MySqlParameter("@abo", MySqlDbType.VarChar);
            parameter[8].Value = about;
            parameter[9] = new MySqlParameter("@img", MySqlDbType.Blob);
            parameter[9].Value = cover;
            parameter[10] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameter[10].Value = id;

            if (db.setData(query, parameter) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool deleteBook(int id)
        {
            // finds book with given ID, removes from database
            string query = "DELETE FROM `books` WHERE `id`=@id";
            MySqlParameter[] parameter = new MySqlParameter[1];
            parameter[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameter[0].Value = id;
            if (db.setData(query, parameter) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable BookList()
        {
            // selects all books in the database, ordered descending by ID
            string query = "SELECT * FROM `books` ORDER BY id DESC";
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table;
        }

        public DataTable authorBooks(int authorID)
        {
            // select all the books where its author ID matches the passed in author ID
            string query = "SELECT * FROM `books` WHERE `authorID`=@authorID";
            MySqlParameter[] parameters = new MySqlParameter[1];
            parameters[0] = new MySqlParameter("@authorID", MySqlDbType.Int32);
            parameters[0].Value = authorID;            
            DataTable table = new DataTable();
            table = db.getData(query, parameters);

            return table;
        }

        public Boolean isISBNExists(string isbn, int id) 
        {
            // selects all books where the isbn matches 
            string query = "SELECT * FROM `books` WHERE `isbn`=@isbn AND id <> @id";
            MySqlParameter[] parameters = new MySqlParameter[2];
            parameters[0] = new MySqlParameter("@isbn", MySqlDbType.VarChar);
            parameters[0].Value = isbn;
            parameters[1] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameters[1].Value = id;

            DataTable table = new DataTable();
            table = db.getData(query, parameters);
            if(table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean isTitleExists(string title, int id)
        {
            // same as ISBN
            string query = "SELECT * FROM `books` WHERE `title`=@title AND id <> @id";
            MySqlParameter[] parameters = new MySqlParameter[2];
            parameters[0] = new MySqlParameter("@title", MySqlDbType.VarChar);
            parameters[0].Value = title;
            parameters[1] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameters[1].Value = id;

            DataTable table = new DataTable();
            table = db.getData(query, parameters);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable searchByIDOrISBN(string idOrISBN, int id, string isbn)
        {
            //checks if idorISBN is the id, finds book where id is equal, else find isbn that is equal
            string query;
            MySqlParameter[] parameters = new MySqlParameter[1];
            if (idOrISBN.Equals("id"))
            {             
                query = "SELECT * FROM `books` WHERE `id`=@id";
                parameters[0] = new MySqlParameter("@id", MySqlDbType.Int32);
                parameters[0].Value = id;
            }
            else
            {
                query = "SELECT * FROM `books` WHERE `isbn`=@isbn";
                parameters[0] = new MySqlParameter("@isbn", MySqlDbType.VarChar);
                parameters[0].Value = isbn;
            }
            DataTable table = new DataTable();
            table = db.getData(query, parameters);
            return table;
        }
        public DataRow getBookInfo(int bookID)
        {
            string query = "SELECT b.id, `isbn`, `title`, concat(a.firstname, ' ', a.surname) as author, " +
                "g.name as genre, `quantity`, `price`, `publisher`, `dateReceived`, b.about, `cover` " +
                "FROM books b, authors a, genres g WHERE b.authorID = a.id and b.genreID = g.id and b.id = @id";
            MySqlParameter[] parameters = new MySqlParameter[1];
            parameters[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameters[0].Value = bookID;
            DataTable table = new DataTable();
            table = db.getData(query, parameters);
            return table.Rows[0];
        }


        public bool bookQuantityMinusOne(int bookID)
        {
            string query = "UPDATE `books` SET `quantity`=quantity-1 WHERE `id`=@bID";
            MySqlParameter[] parameter = new MySqlParameter[1];

            parameter[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameter[0].Value = bookID;

            if (db.setData(query, parameter) == 1)
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
