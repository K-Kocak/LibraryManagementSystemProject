using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemProject.CLASSES
{
    internal class USERS
    {
        THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();
        public bool addUser(string fname, string sname, string username, string password, string userType)
        {
            // adds new user into app user database with their name, and usual password + username and a user type
            string query = "INSERT INTO `app_users`(`first_name`, `last_name`, `username`, `password`, `user_type`) VALUES (@fn, @ln, @user, @pass, @uType)";
            MySqlParameter[] parameter = new MySqlParameter[5];
            parameter[0] = new MySqlParameter("@fn", MySqlDbType.VarChar);
            parameter[0].Value = fname;
            parameter[1] = new MySqlParameter("@ln", MySqlDbType.VarChar);
            parameter[1].Value = sname;
            parameter[2] = new MySqlParameter("@user", MySqlDbType.VarChar);
            parameter[2].Value = username;
            parameter[3] = new MySqlParameter("@pass", MySqlDbType.VarChar);
            parameter[3].Value = password;
            parameter[4] = new MySqlParameter("@uType", MySqlDbType.VarChar);
            parameter[4].Value = userType;
            return db.setData(query, parameter) == 1;
        }

        public bool editUser(int id, string fname, string lastname, string username, string password, string userType)
        {
            // updates an existing user
            string query = "UPDATE `app_users` SET `first_name`=@fn, `last_name`=@ln, `username`=@user, `password`=@pass, `user_type`=@uType WHERE `id`=@id";
            MySqlParameter[] parameter = new MySqlParameter[6];
            parameter[0] = new MySqlParameter("@fn", MySqlDbType.VarChar);
            parameter[0].Value = fname;
            parameter[1] = new MySqlParameter("@ln", MySqlDbType.VarChar);
            parameter[1].Value = lastname;
            parameter[2] = new MySqlParameter("@user", MySqlDbType.VarChar);
            parameter[2].Value = username;
            parameter[3] = new MySqlParameter("@pass", MySqlDbType.VarChar);
            parameter[3].Value = password;
            parameter[4] = new MySqlParameter("@uType", MySqlDbType.VarChar);
            parameter[4].Value = userType;
            parameter[5] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameter[5].Value = id;
            return db.setData(query, parameter) == 1;
        }

        public bool removeUser(int id)
        {
            // deletes user from user database
            string query = "DELETE FROM `app_users` WHERE `id`=@id";
            MySqlParameter[] parameter = new MySqlParameter[1];
            parameter[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameter[0].Value = id;
            return db.setData(query, parameter) == 1;
        }

        public DataTable UsersList()
        {
            // selects all the users that arent of user type owner
            string query = "SELECT * FROM `app_users` where user_type<> 'owner'";
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table;
        }

        public Boolean isUsernameExist(string username, int id)
        {
            // looks for the user in database, if it exists then table.rows will be > 0 and returns true
            string query = "SELECT * FROM `app_users` WHERE username=@usname AND id<>@id";
            MySqlParameter[] parameter = new MySqlParameter[2];
            parameter[0] = new MySqlParameter("@usname", MySqlDbType.VarChar);
            parameter[0].Value = username;
            parameter[1] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameter[1].Value = id;
            DataTable table = new DataTable();
            table = db.getData(query, parameter);
            return table.Rows.Count > 0; 
        }
    }
}
