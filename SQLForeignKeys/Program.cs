using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;

namespace SQLForeignKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the file name: ");
            string FileName = Console.ReadLine();
            var file = new StreamReader(FileName);
            string line;
            while ((line = file.ReadLine()) != null){
                var split = line.Split("\t");
                var key = new ForeignKey()
                {
                    localTable = split[0].Split(".")[0],
                    localColumn = split[0].Split(".")[1],
                    foreignTable = split[1].Split(".")[0],
                    foreignColumn = split[1].Split(".")[1]
                };
                Console.WriteLine("ALTER TABLE {0} ADD FOREIGN KEY ({1}) REFERENCES {2}({3});", key.localTable, key.localColumn, key.foreignTable, key.foreignColumn);
            }
            Console.ReadLine();
        }
    }

    class ForeignKey
    {
        public string localTable { get; set; }
        public string localColumn { get; set; }
        public string foreignTable { get; set; }
        public string foreignColumn { get; set; }

    }
}
