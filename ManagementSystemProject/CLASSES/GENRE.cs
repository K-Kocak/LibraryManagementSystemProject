using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace ManagementSystemProject.CLASSES
{
    internal class GENRE
    {
        THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();
        public bool addGenre(string name)
        {
            // adds a new genre to the database, id is automatically made
            string query = "INSERT INTO `genres`(`name`) VALUES (@genre_name)"; 
            MySqlParameter[] parameter = new MySqlParameter[1];
            parameter[0] = new MySqlParameter("@genre_name", MySqlDbType.VarChar);
            parameter[0].Value = name;
            return db.setData(query, parameter) == 1;   
        }

        public bool editGenre(int id, string name)
        {
            // update a genre entry by going to the passed-in id and editing the name entry with the given name
            string query = "UPDATE `genres` SET `name`=@genre_name WHERE `id`=@id";
            MySqlParameter[] parameter = new MySqlParameter[2];
            parameter[0] = new MySqlParameter("@genre_name", MySqlDbType.VarChar);
            parameter[0].Value = name;
            parameter[1] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameter[1].Value = id;
            return db.setData(query, parameter) == 1;
        }
        public bool removeGenre(int id) 
        {
            // removes a genre from the table genres with the given id
            string query = "DELETE FROM `genres` WHERE `id`=@id";
            MySqlParameter[] parameter = new MySqlParameter[1];
            parameter[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameter[0].Value = id;
            // return true if successful, false otherwise
            return db.setData(query, parameter) == 1;
        }
        public DataTable GenresList()
        {
            // retrieves all the data from the table genres
            DataTable table = new DataTable();
            table = db.getData("SELECT * FROM `genres`", null);
            return table;
        }
    }
}
