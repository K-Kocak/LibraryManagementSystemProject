using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ManagementSystemProject.CLASSES
{
    internal class AUTHOR
    {
        THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();
        public bool addAuthor(string fname, string sname, string edu, string about)
        {
            //Adds author to database of authors, with the authors first and last name, their education and some information about the author
            string query = "INSERT INTO `authors`(`firstname`, `surname`, `education`, `about`) VALUES (@fn, @ln, @edu, @abo)";
            MySqlParameter[] parameter = new MySqlParameter[4];
            parameter[0] = new MySqlParameter("@fn", MySqlDbType.VarChar);
            parameter[0].Value = fname;
            parameter[1] = new MySqlParameter("@ln", MySqlDbType.VarChar);
            parameter[1].Value = sname;
            parameter[2] = new MySqlParameter("@edu", MySqlDbType.VarChar);
            parameter[2].Value = edu;
            parameter[3] = new MySqlParameter("@abo", MySqlDbType.VarChar);
            parameter[3].Value = about;
            // If succesful, returns true to indicate to the user that the author was added succesfully 
            return db.setData(query, parameter) == 1;
        }

        public bool editAuthor(int id, string fname, string sname, string edu, string about)
        {
            // Similar to add, finds the author with the matching id then sets first and last name etc. to the parameters that were passed into this function
            string query = "UPDATE `authors` SET `firstname`=@fn, `surname`=@ln, `education`=@edu, `about`=@abo WHERE `id`=@id";
            MySqlParameter[] parameter = new MySqlParameter[5];
            parameter[0] = new MySqlParameter("@fn", MySqlDbType.VarChar);
            parameter[0].Value = fname;
            parameter[1] = new MySqlParameter("@ln", MySqlDbType.VarChar);
            parameter[1].Value = sname;
            parameter[2] = new MySqlParameter("@edu", MySqlDbType.VarChar);
            parameter[2].Value = edu;
            parameter[3] = new MySqlParameter("@abo", MySqlDbType.VarChar);
            parameter[3].Value = about;
            parameter[4] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameter[4].Value = id;
            // user feedback
            return db.setData(query, parameter) == 1;
        }

        public bool removeAuthor(int id)
        {
            //Finds the given author id in the databse and deletes it
            string query = "DELETE FROM `authors` WHERE `id`=@id";
            MySqlParameter[] parameter = new MySqlParameter[1];
            parameter[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameter[0].Value = id;
            //user feedback
            return db.setData(query, parameter) == 1;
        }

        public DataTable AuthorList(Boolean displayFullName)
        {
            // This gets the list of authors in the database with their first and last name concatenated together
            string query = "SELECT * FROM `authors`";
            if(displayFullName)
            {
                query = "SELECT `id`, Concat(`firstname`,' ', `surname`) as fullname, `education`, `about` FROM `authors`";
            }
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table;
        }

        public DataTable getAuthorByID(int id)
        {
            //Gets the author with the passed in ID
            string query = "SELECT * FROM `authors` WHERE `id`=@id";
            MySqlParameter[] parameters = new MySqlParameter[1];
            parameters[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameters[0].Value = id;
            DataTable table = new DataTable();
            table = db.getData(query, parameters);
            return table;
        }
    }
}
