using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_lesson3._4
{
    class Program
    {
        static void Main(string[] args)
        {

            //do循环

            double balance, interestRate, targetBalance;
            Console.WriteLine("What's your current balance?");
            balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What's your current annual interest rate (in %)?");
            interestRate = 1 + Convert.ToDouble(Console.ReadLine()) / 100.0;
            Console.WriteLine("What balance would you like to have ?");
            targetBalance = Convert.ToDouble(Console.ReadLine());

            int totalYears = 0;
            do
            {
                balance *= interestRate;
                ++totalYears;
            }
            while (balance < targetBalance);
            Console.WriteLine("In {0} year{1} you'll have a balance of {2}.", 
                totalYears, totalYears == 1? "" : "s", balance);  //1?"":s三元运算，1时空，！=1时s 
            Console.ReadKey();



            //do循环至少要执行1次,下面while表达式
            /*
             * int totalYears = 0;
               while (balance < targetBalance)
               {
                 balance *= interestRate;
                ++totalYears;
               }
               Console.WriteLine("In {0} year{1} you'll have a balance of {2}.",
               totalYears, totalYears == 1 ? "" : "s", balance);
               Console.ReadKey();
               
                 */
        }

    }
}
