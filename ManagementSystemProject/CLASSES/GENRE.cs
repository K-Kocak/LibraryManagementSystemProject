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
            string query = "INSERT INTO `genres`(`name`) VALUES (@genre_name)"; 
            MySqlParameter[] parameter = new MySqlParameter[1];
            parameter[0] = new MySqlParameter("@genre_name", MySqlDbType.VarChar);
            parameter[0].Value = name;

            if(db.setData(query, parameter) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }         
        }

        public bool editGenre(int id, string name)
        {
            string query = "UPDATE `genres` SET `name`=@genre_name WHERE `id`=@id";
            MySqlParameter[] parameter = new MySqlParameter[2];
            parameter[0] = new MySqlParameter("@genre_name", MySqlDbType.VarChar);
            parameter[0].Value = name;
            parameter[1] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameter[1].Value = id;

            if (db.setData(query, parameter) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool removeGenre(int id) 
        {
            string query = "DELETE FROM `genres` WHERE `id`=@id";
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
        public DataTable GenresList()
        {
            DataTable table = new DataTable();
            table = db.getData("SELECT * FROM `genres`", null);
            return table;
        }
    }
}
