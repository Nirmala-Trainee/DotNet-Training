using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Accounts
{
    class Accounts_Inheritance
    {
        public int Account_No;
        public string Customer_Name;
        public string Account_Type;
        public string Transaction_Type;
        public int amount;
        public int balance;

        public Accounts_Inheritance(int account_no, string customer_name, string account_type)
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
    internal class Balance : Accounts_Inheritance
    {
        public Balance(int account_no, string customer_name, string account_type) : base(account_no, customer_name, account_type)
        {

        }
        public int Credit(int amount)
        {
            balance = balance + amount;
            return balance;
        }
        public int Debit(int amount)
        {
            balance = balance - amount;
            return balance;
        }
        public void Update_Balance(string transac_type)
        {
            if (transac_type == "c" || transac_type == "C")
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
            Console.WriteLine($"Account Number : {Account_No}");
            Console.WriteLine($"Customer Name : {Customer_Name}");
            Console.WriteLine($"Account Type : {Account_Type}");
            Console.WriteLine($"Transaction Type : {Transaction_Type}");
            Console.WriteLine($"Amount : {amount}");
            Console.WriteLine($"Balance : {balance}");
        }
    }
    class Inheritance1
    {
        public static void Main()
        {
            Console.WriteLine("Enter the account number : ");
            int acc_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the customer name : ");
            string customer_name = Console.ReadLine();
            Console.WriteLine("Enter the account type : ");
            string acc_type = Console.ReadLine();


            Balance ob = new Balance(acc_no, customer_name, acc_type);


            Console.WriteLine("Enter the transaction type : ");
            string trans_type = Console.ReadLine();
            Console.WriteLine("Enter the amount : ");
            int amo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the balance : ");
            int bal = Convert.ToInt32(Console.ReadLine());

            ob.Set_Data(trans_type, amo, bal);
            ob.Update_Balance(trans_type);

            Console.WriteLine("-------------------Details of the customer-----------------");
            ob.Show_Data();

            Console.ReadLine();
        }
    }
}

