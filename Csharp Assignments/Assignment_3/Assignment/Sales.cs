using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class SalesDetails
    {
        public static int Sales_No;
        public static int Product_No;
        public static int Price;
        public static DateTime DateofSale;
        public static int Quantity;
        public static int Total_Amount;
        public SalesDetails(int sales_no, int product_no, int price, int qty, DateTime date_of_sale)
        {
            Sales_No = sales_no;
            Product_No = product_no;
            Price = price;
            Quantity = qty;
            DateofSale = date_of_sale;

        }
        public void Sales(int price, int qty)
        {
            Total_Amount = qty * price;
        }
    }
    class SalesDetails1 : SalesDetails
    {
        public SalesDetails1(int sales_no, int product_no, int price, int qty, DateTime date_of_sale)
            : base(sales_no, product_no, price, qty, date_of_sale)
        {

        }
        public static void Show_Data()
        {
            Console.WriteLine("Sales No:{0}", Sales_No);
            Console.WriteLine("Product No:{0}", Product_No);
            Console.WriteLine("Price:{0}", Price);
            Console.WriteLine("Quantity:{0}", Quantity);
            Console.WriteLine("Date of sale:{0}", DateofSale);
            Console.WriteLine("Total Amount:{0}", Total_Amount);
        }
        public static void Main()
        {
            Console.WriteLine("Enter the Sales Number:");
            int saleno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Product Number:");
            int prod_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Price:");
            int pri = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Quantity:");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Date of sale:");
            DateTime dos = Convert.ToDateTime(Console.ReadLine());
            SalesDetails s = new SalesDetails(saleno, prod_no, pri, quantity, dos);
            s.Sales(pri, quantity);
            Show_Data();
            Console.Read();
        }
    }
}

