using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class InsufficientBal_Exception : ApplicationException
    {
        public InsufficientBal_Exception(string msg) : base(msg)
        {

        }
    }
    class ExceptionHandling
    {
        public int Amount;
        public int Balance;
        public string Transaction_type;

        public ExceptionHandling(int Amo, int Bal, string Trans_type)
        {
            Amount = Amo;
            Balance = Bal;
            Transaction_type = Trans_type;
        }
        public void Deposit(int Amount, int Balance)
        {
            Balance = Balance + Amount;
            Console.WriteLine("The Balance after deposit amount{0} is {1}", Amount, Balance);
        }

        public void Withdraw(int Amount, int Balance)
        {
            try
            {
                if (Amount > Balance)
                {
                    throw (new InsufficientBal_Exception("Does not have sufficient balance"));
                }
                else
                {
                    Balance = Balance - Amount;
                    Console.WriteLine("The Balance after withdraw amount{0} is {1}", Amount, Balance);
                }
            }
            catch (InsufficientBal_Exception insufficient_balance)
            {
                Console.WriteLine("Error :" + insufficient_balance.Message);
            }
        }
        public void Update_Balance(string Transc_type)
        {
            if (Transc_type == "d" || Transc_type == "D")
            {
                Deposit(Amount, Balance);
            }
            else if (Transc_type == "w" || Transc_type == "W")
            {
                Withdraw(Amount, Balance);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the balance");
            int Bal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the amount");
            int Amo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Transaction type");
            string Trans_type = Console.ReadLine();

            ExceptionHandling obj = new ExceptionHandling(Amo, Bal, Trans_type);
            obj.Update_Balance(Trans_type);
            Console.Read();
        }

    }
}
