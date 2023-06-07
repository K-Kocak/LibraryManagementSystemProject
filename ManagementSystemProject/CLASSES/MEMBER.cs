using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ManagementSystemProject.CLASSES
{
    internal class MEMBER
    {
        THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();

        public bool addMember(string fname, string sname, string gender, string phone, string email, byte[] picture)
        {
            string query = "INSERT INTO `members`(`firstname`, `surname`, `gender`, `phone`, `email`, `picture`) VALUES (@fn, @ln, @gen, @pho, @email, @pic)";
            MySqlParameter[] parameter = new MySqlParameter[6];
            parameter[0] = new MySqlParameter("@fn", MySqlDbType.VarChar);
            parameter[0].Value = fname;
            parameter[1] = new MySqlParameter("@ln", MySqlDbType.VarChar);
            parameter[1].Value = sname;
            parameter[2] = new MySqlParameter("@gen", MySqlDbType.VarChar);
            parameter[2].Value = gender;
            parameter[3] = new MySqlParameter("@pho", MySqlDbType.VarChar);
            parameter[3].Value = phone;
            parameter[4] = new MySqlParameter("@email", MySqlDbType.VarChar);
            parameter[4].Value = email;
            parameter[5] = new MySqlParameter("@pic", MySqlDbType.Blob);
            parameter[5].Value = picture;

            if (db.setData(query, parameter) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool editMember(int id, string fname, string sname, string gender, string phone, string email, byte[] picture)
        {
            string query = "UPDATE `members` SET `firstname`=@fn, `surname`=@sn, `gender`=@gen, `phone`=@pho, `email`=@email, `picture`=@pic  WHERE `id`=@id";
            MySqlParameter[] parameter = new MySqlParameter[7];
            
            parameter[0] = new MySqlParameter("@fn", MySqlDbType.VarChar);
            parameter[0].Value = fname;
            parameter[1] = new MySqlParameter("@sn", MySqlDbType.VarChar);
            parameter[1].Value = sname;
            parameter[2] = new MySqlParameter("@gen", MySqlDbType.VarChar);
            parameter[2].Value = gender;
            parameter[3] = new MySqlParameter("@pho", MySqlDbType.VarChar);
            parameter[3].Value = phone;
            parameter[4] = new MySqlParameter("@email", MySqlDbType.VarChar);
            parameter[4].Value = email;
            parameter[5] = new MySqlParameter("@pic", MySqlDbType.Blob);
            parameter[5].Value = picture;
            parameter[6] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameter[6].Value = id;


            if (db.setData(query, parameter) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool removeMember(int id)
        {
            string query = "DELETE FROM `members` WHERE `id`=@id";
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

        public DataTable MemberList(Boolean displayFullName)
        {
            string query = "SELECT * FROM `members`";
            if (displayFullName)
            {
                query = "SELECT `id`, Concat(`firstname`,'-', `surname`) as fullname, `gender`, `phone`, `email`, `picture` FROM `members`";
            }
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table;
        }


        public DataRow getMemberByID(int id)
        {
            string query = "SELECT * FROM `members` WHERE `id`=@id";

            MySqlParameter[] parameter = new MySqlParameter[1];

            parameter[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameter[0].Value = id;

            DataTable table = new DataTable();
            table = db.getData(query, parameter);

            DataRow dr = null;

            if(table.Rows.Count > 0)
            {
                dr = table.Rows[0];
            }

            
            return dr;
        }


    }
}
