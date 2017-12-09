using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace SQLForeignKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a connectionString: ");
            string connectionString = Console.ReadLine();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            var command = new MySqlCommand("SHOW TABLES", connection);
            var reader = command.ExecuteReader();
            var list = new List<String>();
            while (reader.Read())
            {
                list.Add(reader.GetString(0));
            }
            reader.Close();
            foreach(string table in list)
            {
                command = new MySqlCommand("DESCRIBE " + table, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var colName = reader.GetString(0);
                    var keyType = reader.GetString(3);
                    if(colName.Length > 2 && colName.Substring(colName.Length -2) == "ID" && keyType != "PRI")
                    {
                        Console.WriteLine("{0}.{1} Foreign Key Needed", table, colName);
                    }
                }
                reader.Close();

            }
            Console.WriteLine("Finished");
            Console.ReadLine();
        }
    }
}
