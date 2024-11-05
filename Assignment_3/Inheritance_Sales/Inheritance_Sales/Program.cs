using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Sales
{
    public class Saledetails
    {
        public int Saleno { get; private set; }
        public int Productno { get; private set; }
        public decimal Price { get; private set; }
        public DateTime DateOfSale { get; private set; }
        public int Qty { get; private set; }
        public decimal TotalAmount { get; private set; }

        public Saledetails(int saleno, int productno, decimal price, int qty, DateTime dateOfSale)
        {
            Saleno = saleno;
            Productno = productno;
            Price = price;
            Qty = qty;
            DateOfSale = dateOfSale;
            Sales();
        }

        public void Sales()
        {
            TotalAmount = Qty * Price;
        }

        public static void ShowData(Saledetails sale)
        {
            Console.WriteLine("Sale No: " + sale.Saleno);
            Console.WriteLine("Product No: " + sale.Productno);
            Console.WriteLine("Price: " + sale.Price);
            Console.WriteLine("Quantity: " + sale.Qty);
            Console.WriteLine("Date of Sale: " + sale.DateOfSale.ToShortDateString());
            Console.WriteLine("Total Amount: " + sale.TotalAmount);
        }
    }

    public class Program
    {
        public static void Main()
        {
            Saledetails sale = new Saledetails(5, 55, 100.5m, 2, DateTime.Now);
            Saledetails.ShowData(sale);
            Console.ReadLine();
        }
    }
}
