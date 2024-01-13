//#define ClASS_WORK
//#define QUERY_AUTHOR_WITH_BOOKS
#define INSERT_FROM_USER
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Remoting.Contexts;


namespace Introduction_to_ADO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string connection_string = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryPD_212;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connection_string);    //Создаём соединение с сервером. При создании оно неактивно

#if ClASS_WORK
            ///////////////////////////////////////////////// ВСТАВКА: ////////////////////////////////////////////////////
            connection.Open(); //Открываем соединение, поскольку автоматически оно не открывается
            //string insert_string = @"INSERT INTO Authors (first_name, last_name) VALUES ('Steven','Hocking')";
            string insert_string = @"INSERT INTO Books (author, title, price, pages) VALUES (4,'The Steven Hawkings Universe',160,850)";
            SqlCommand cmd = new SqlCommand(insert_string, connection);
            //cmd.ExecuteNonQuery(); //INSERT, UPDATE, DELETE

            /////////////////////////////////////////////// ВЫБОРКА: //////////////////////////////////////////////////////

            string select_string = @"SELECT * FROM Authors";
            cmd.CommandText = select_string;

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            { 
                Console.WriteLine($"{rdr[0]} {rdr[1]} {rdr[2]}");
            }


            
            connection.Close(); //Соединение обязательно нужно закрывать
#endif
#if QUERY_AUTHOR_WITH_BOOKS
            connection.Open();
            string select_string = @"
                SELECT 
                    first_name,
                    last_name,
                    Books.Title                
                FROM Authors, Books
                WHERE Authors.id = Books.author
            ";
            SqlCommand cmd = new SqlCommand(select_string, connection);
            cmd.CommandText = select_string;

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine($"{rdr[0]} {rdr[1]} {rdr[2]}");
            }
            connection.Close(); //Соединение обязательно нужно закрывать
#endif
#if INSERT_FROM_USER
            Console.WriteLine("Выберите желаемое действие: \n1 - Добавить автора\n2 - Добавить книгу\n3 - Показать всех авторов\n4 - Показать все книги\nEscape - выход");
            ConsoleKey key = Console.ReadKey().Key;
            //string insert_string;
            while (key != ConsoleKey.Escape)
            {
                if (key == ConsoleKey.D1)
                {
                    Console.WriteLine();
                    connection.Open();
                    string first_name,last_name;
                    Console.WriteLine("Введите имя автора:");
                    first_name = Console.ReadLine();
                    Console.WriteLine("Введите фамилию автора:");
                    last_name = Console.ReadLine();
                    string insert_string = String.Format("INSERT INTO Authors (first_name, last_name) VALUES ('{0}', '{1}')", first_name, last_name);
                    SqlCommand cmd = new SqlCommand(insert_string, connection);
                    cmd.ExecuteNonQuery(); //INSERT, UPDATE, DELETE
                    connection.Close();
                }
                if (key == ConsoleKey.D2)
                {
                    Console.WriteLine();
                    connection.Open();
                    int author_id, price, pages;
                    string title;
                    Console.WriteLine("Введите id автора:");
                    author_id = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Введите название книги:");
                    title = Console.ReadLine();
                    Console.WriteLine("Введите стоимость книги:");
                    price = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Введите количество страниц в книге:");
                    pages = Int32.Parse(Console.ReadLine());
                    string insert_string = String.Format("INSERT INTO Books (author, title, price, pages) VALUES ({0}, '{1}', {2} , {3})", author_id, title, price, pages);
                    SqlCommand cmd = new SqlCommand(insert_string, connection);
                    cmd.ExecuteNonQuery(); //INSERT, UPDATE, DELETE
                    connection.Close();
                }

                if (key == ConsoleKey.D3)
                {
                    connection.Open();
                    Console.WriteLine("\n");
                    string select_string = @"SELECT * FROM Authors";
                    SqlCommand cmd = new SqlCommand(select_string, connection);
                    cmd.CommandText = select_string;
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Console.WriteLine($"{rdr[0]} {rdr[1]} {rdr[2]}");
                    }
                    connection.Close();
                }
               if (key == ConsoleKey.D4)
                {
                    connection.Open();
                    Console.WriteLine("\n");
                    string select_string = @"SELECT * FROM Books";
                    SqlCommand cmd = new SqlCommand(select_string, connection);
                    cmd.CommandText = select_string;
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Console.WriteLine($"{rdr[0]} {rdr[1]} {rdr[2]}");
                    }
                connection.Close();
                }
                key = Console.ReadKey().Key;
            }

#endif
        }
    }
}

