using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutBank
{
	public class DB
	{
        public SQLiteConnection sqlite_conn;

        public void ConnectToDB()
		{
            sqlite_conn = new SQLiteConnection("Data Source=./DB/database.db;Version=3;New=True;Compress=True;");
            try
            {
                sqlite_conn.Open();
            } catch(Exception e)
            {

            }
            return;
        }

        public void createUser()
        {
            SQLiteCommand command;
            command = sqlite_conn.CreateCommand();
            sqlite_conn.Close();
        }
    }
}

