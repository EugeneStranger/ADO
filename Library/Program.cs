﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            Console.WriteLine(connectionString);

            Library library = new Library(connectionString);
            library.InsertAuthor("sss", "sss");
            //library.SelectAuthors();
            //Console.WriteLine();
        }
    }
}
