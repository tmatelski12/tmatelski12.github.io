//----------------------------------------------------------------------------
// This program takes my start hiring date and calculates on what day you will
// get a bonus on your paycheck.
//----------------------------------------------------------------------------
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime hireDate = new DateTime(2022, 01, 24);
            DateTime birthday = new DateTime(1984, 12, 04);
            DateTime today = DateTime.Now;
            DateTime bonus1 = hireDate.AddDays(90);
            DateTime bonus2 = hireDate.AddDays(180);
            DateTime bonus3 = hireDate.AddDays(270);
            DateTime bonus4 = hireDate.AddDays(365);
            


            Console.WriteLine("HireDate: {0:M/dd/yyyy}", hireDate);
            Console.WriteLine("Todays Date: " + today);
            Console.WriteLine("Todays Date W/ Format: {0:M/dd/yyyy}", today);
            Console.WriteLine("Bonus1 date is: {0:M/dd/yyyy}", bonus1);
            Console.WriteLine("Bonus2 date is: {0:M/dd/yyyy}", bonus2);
            Console.WriteLine("Bonus3 date is: {0:M/dd/yyyy}", bonus3);
            Console.WriteLine("One year Bonus date is: {0:M/dd/yyyy}", bonus4);
            Console.WriteLine("My birthday is: {0:MM/dd/yyyy}", birthday);

            DateTime countdown = today.AddDays(811);
            Console.WriteLine("Countdown: {0:M/dd/yyyy}", countdown);

            double a = 40;
            double b = 23.50;
            double c = 1.5;
            double d = 5;
            double regPay = a * b;
            double OTpay = b * c;
            double totPay = regPay + (OTpay * d);

            Console.WriteLine("Regular Hours: " + a);
            Console.WriteLine("Regular Pay is: " + regPay);
            Console.WriteLine("Overtime pay is: " + OTpay);
            Console.WriteLine("My Pay with OT is: " + totPay.ToString("$###.##"));


            Console.ReadKey();
        }   
    }
}
