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
            connection.Open(); //Открываем соединение, поскольку автоматически оно не открывается

            ///////////////////////////////////////////////// ВСТАВКА: ////////////////////////////////////////////////////
            
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
        }
    }
}
