﻿using System;
using System.Data;
using MySql.Data.MySqlClient;
namespace ManagementSystemProject.CLASSES
{
    internal class MEMBER
    {
        THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();
        public bool AddMember(string fname, string sname, string gender, string phone, string email, byte[] picture)
        {
            // inserts value into member database with given parameters (from the input elements)
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
            return db.SetData(query, parameter) == 1;         
        }
        public bool EditMember(int id, string fname, string sname, string gender, string phone, string email, byte[] picture)
        {
            // edits member at given ID with values inside input fields
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
            return db.SetData(query, parameter) == 1;
        }

        public bool RemoveMember(int id)
        {
            // deletes member at given ID
            string query = "DELETE FROM `members` WHERE `id`=@id";
            MySqlParameter[] parameter = new MySqlParameter[1];
            parameter[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameter[0].Value = id;
            return db.SetData(query, parameter) == 1;
        }

        public DataTable MemberList(Boolean displayFullName)
        {
            string query = displayFullName ? 
                "SELECT `id`, Concat(`firstname`,'-', `surname`) as fullname, `gender`, `phone`, `email`, `picture` FROM `members`" 
                : 
                "SELECT * FROM `members`";
            //string query = "SELECT * FROM `members`";
            //if (displayFullName)
            //{
            //    query = "SELECT `id`, Concat(`firstname`,'-', `surname`) as fullname, `gender`, `phone`, `email`, `picture` FROM `members`";
            //}
            //DataTable table = new DataTable();
            //table = db.getData(query, null);
            return db.GetData(query, null);
        }


        public DataRow GetMemberByID(int id)
        {
            // finds the member who has the ID passed in
            string query = "SELECT * FROM `members` WHERE `id`=@id";
            MySqlParameter[] parameter = new MySqlParameter[1];
            parameter[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameter[0].Value = id;
            //DataTable table = new DataTable();
            DataTable table = db.GetData(query, parameter);
            return table.Rows.Count > 0 ? table.Rows[0] : null;
            //DataRow dr = null;
            //if(table.Rows.Count > 0)
            //{
            //    return table.Rows[0];
            //    // dr = table.Rows[0];
            //}
            //return dr;
        }


    }
}
