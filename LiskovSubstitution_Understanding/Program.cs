using LiskovSubstitution_Understanding.Implementation;
using System;

namespace LiskovSubstitution_Understanding
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new BracBank();
            Console.WriteLine(bank.BankName());
            Console.WriteLine(bank.BankOwner());

            bank = new UcbBank();
            Console.WriteLine(bank.BankName());
            Console.WriteLine(bank.BankOwner());

            Console.ReadKey();
        }
    }
}
