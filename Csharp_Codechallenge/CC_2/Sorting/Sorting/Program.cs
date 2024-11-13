using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Products
    {
        public int Product_Id { get; set; }
        public string Product_Name { get; set; }
        public double Price { get; set; }

        public Products(int productId,string productName,double price)
        {
            Product_Id = productId;
            Product_Name = productName;
            Price = price;

        }
        public override string ToString()
        {
            return $"{Product_Id} -{Product_Name}: ${Price}";
        }
    }

    class Program
    {
        static void Main()
        {
            List<Products> products = new List<Products>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter details for product {i}:");
                Console.WriteLine(" Enter Product ID:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Product Name:");
                String name = Console.ReadLine();
                Console.WriteLine("Enter Price:");
                double price = double.Parse(Console.ReadLine());

                products.Add(new Products(id, name, price));




            }

            var sortedProducts = products.OrderBy(p => p.Price).ToList();


            Console.WriteLine("\nSorted Products by Price:");
            foreach (var product in sortedProducts)
            {
                Console.WriteLine($"Product ID: {product.Product_Id}, Name: {product.Product_Name}, Price: {product.Price}");
                Console.ReadLine();
            }
        }
    }
}
