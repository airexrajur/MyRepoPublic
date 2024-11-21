using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal static class Sqltest
    {
       public static void Testconnection()
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = @"Data Source = ARUYASH\SQLEXPRESS;"+
"Initial Catalog = Testdb; User ID = test123;Password = test1234";
                sqlConnection.Open();
                
                Console.WriteLine(sqlConnection.ConnectionString);
                Console.WriteLine(sqlConnection.State);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finnaly");
                
            }
        }
    }
}
