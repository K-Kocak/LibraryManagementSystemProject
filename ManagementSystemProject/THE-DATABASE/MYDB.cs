using System.Data;
using MySql.Data.MySqlClient;
namespace ManagementSystemProject.THE_DATABASE
{
    internal class MYDB
    {
        private MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=csharp_msys_db");
        public void OpenConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }
        public DataTable GetData(string query, MySqlParameter[] parameters)
        {
            MySqlCommand command = new MySqlCommand(query, GetConnection());
            if(parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }
        public int SetData(string query, MySqlParameter[] parameters)
        {
            MySqlCommand command = new MySqlCommand(query, GetConnection());
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }
            OpenConnection();
            int commandState = command.ExecuteNonQuery();
            CloseConnection();
            return commandState;
        }

        // ALTER TABLE books ADD CONSTRAINT fk_authorid FOREIGN KEY (authorid) REFERENCES authors(id) on UPDATE CASCADE on DELETE CASCADE;
        // ALTER TABLE books ADD CONSTRAINT fk_genreid FOREIGN KEY (genreid) REFERENCES genres(id) on UPDATE CASCADE on DELETE CASCADE;
        // ALTER TABLE issuebook ADD CONSTRAINT fk_bookid FOREIGN KEY (bookid) REFERENCES books(id) on UPDATE CASCADE on DELETE CASCADE;
        // ALTER TABLE issuebook ADD CONSTRAINT fk_memberid FOREIGN KEY (memberid) REFERENCES members(id) on UPDATE CASCADE on DELETE CASCADE;
    }
}
