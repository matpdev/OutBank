using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Data.Sqlite;


namespace OutBank
{
    public class DB
    {

        SqliteConnection? connection;

        public async void ConnectToDB()
        {
            connection = new SqliteConnection("Data Source=hello.db");
            await connection.OpenAsync();

            return;
        }

        public void LoginUser(String email, String password)
        {
            if (connection == null)
            {
                ConnectToDB();
            }
            else
            {
                return;
            }

            if (connection != null)
            {
                var command = connection?.CreateCommand();

                try
                {
                    command!.CommandText = @"UPDATE user SET email = $email WHERE id = $id;";
                    command!.Parameters.AddWithValue("$email", email);
                    command!.Parameters.AddWithValue("$pass", password);

                    command.ExecuteReader();

                    return;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return;
                }
            }
            else
            {
                return;
            }
        }

        public bool insertUser(String email, String password)
        {
            var command = connection?.CreateCommand();

            try
            {
                command!.CommandText = @"INSERT INTO user(email, password) values($email, $pass)";
                command!.Parameters.AddWithValue("$email", email);
                command!.Parameters.AddWithValue("$pass", password);

                command.ExecuteReader();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public void searchUser(String email, String password)
        {
            var command = connection?.CreateCommand();
            try
            {
                command!.CommandText = @"SELECT * from user WHERE email = $email;";
                command.Parameters.AddWithValue("$email", email);

                var data = command.ExecuteReader();
                if(data.Read() == true)
                {
                    var emailData = data["email"];
                    var passwordData = data["password"];
                    Console.WriteLine("{0}, {1}", emailData, passwordData);
                }

                return;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return;
            }
        }

        public void createUserTable()
        {
            var command = connection.CreateCommand();

            try
            {

                command.CommandText = @"CREATE TABLE user(id INTEGER PRIMARY KEY AUTOINCREMENT, email text unique not null, password text not null);";
                command.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

