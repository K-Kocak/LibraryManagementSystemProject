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

            if (db.setData(query, parameter) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool editAuthor(int id, string fname, string sname, string edu, string about)
        {
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

            if (db.setData(query, parameter) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool removeAuthor(int id)
        {
            string query = "DELETE FROM `authors` WHERE `id`=@id";
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

        public DataTable AuthorList(Boolean displayFullName)
        {
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
