using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Accounts
    {
        public int Account_No;
        public string Customer_Name;
        public string Account_Type;
        public string Transaction_Type;
        public double amount;
        public double balance;
        public Accounts(int account_no, string customer_name, string account_type)
        {
            Account_No = account_no;

            Customer_Name = customer_name;

            Account_Type = account_type;
        }
        public void Set_Data(string trans_type, int amo, int bal)
        {
            Transaction_Type = trans_type;
            amount = amo;
            balance = bal;
        }
    }
    internal class Balance : Accounts
    {
        public Balance(int account_no, string customer_name, string account_type) : base(account_no, customer_name, account_type)
        {

        }
        public void Credit(double amount)
        {
            balance = balance + amount;
        }
        public void Debit(double amount)
        {
            balance = balance - amount;
        }
        public void Update_Balance(string transac_type)
        {
            if (transac_type == "d" || transac_type == "D")
            {
                Credit(amount);
            }
            else if (transac_type == "w" || transac_type == "W")
            {
                Debit(amount);
            }
        }
        public void Show_Data()
        {

            Console.WriteLine($"Account Number:{Account_No}");
            Console.WriteLine($"Customer Name:{Customer_Name}");
            Console.WriteLine($"Account Type:{Account_Type}");
            Console.WriteLine($"Transaction Type:{Transaction_Type}");
            Console.WriteLine($"Amount:{amount}");
            Console.WriteLine($"Balance:{balance}");

        }
    }
    class Accounts1
    {
        public static void Main()
        {
            Console.WriteLine("Enter the Account number:");
            int acc_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Customer name:");
            string customer_name = Console.ReadLine();
            Console.WriteLine("Enter the Account type:");
            string acc_type = Console.ReadLine();
            Balance ob = new Balance(acc_no, customer_name, acc_type);
            Console.WriteLine("Enter the Transaction type:");
            string trans_type = Console.ReadLine();
            Console.WriteLine("Enter the Amount:");
            int amo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Balance:");
            int bal = Convert.ToInt32(Console.ReadLine());
            ob.Set_Data(trans_type, amo, bal);
            ob.Update_Balance(trans_type);
            ob.Show_Data();
            Console.Read();
        }
    }
}
