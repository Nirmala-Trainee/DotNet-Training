using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ADO_Dotnet
{
    class Program
    {
        public static SqlConnection conn;
        public static SqlCommand cmd;
        static void Main(string[] args)
        {
            insert();
            Console.Read();
        }

        static SqlConnection Connection()
        {
            conn = new SqlConnection("Data Source=DESKTOP-APHM8AE;Initial Catalog=SQL;" +
                "Integrated Security=true;");
            Console.WriteLine("Connected to a database:");
            conn.Open();
            return conn;
        }
        static void insert()
        {
            try
            {
                Connection();
                Console.WriteLine("Connected to database...");

                cmd = new SqlCommand("sp_insert", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                Console.Write("Enter Product name : ");
                string Pname = Console.ReadLine();

                Console.Write("Enter the Product price : ");
                int P_price = Convert.ToInt32(Console.ReadLine());

                int Discount_price = P_price;

                cmd = new SqlCommand("insert into Products_Details values(@ProductName,@Price,@DiscountedPrice)", conn);
                Console.WriteLine();
                Console.WriteLine("Query Executed...");

                cmd.Parameters.AddWithValue("@ProductName", Pname);
                cmd.Parameters.AddWithValue("Price", P_price);
                cmd.Parameters.AddWithValue("@DiscountedPrice", Discount_price);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("*** Product Details inserted Successfully ***");
                }
                else Console.WriteLine("Product details not inserted");
            }
            catch (Exception product)
            {
                Console.WriteLine($"Error {product.Message}");
            }
            finally
            {
                conn.Close();
            }

        }
    }
}



