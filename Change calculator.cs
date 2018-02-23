using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public static void CalcChange(double salesPrice, double tender)
        {
            double quarters = .25;
            double dimes = .10;
            double nickels = .05;
            double penny = .01;
            int quarterCnt = 0;
            int dimeCnt = 0;
            int nickelCnt = 0;
            int pennyCnt = 0;
            double remChange = 0;


            double change = tender - salesPrice;
            int dollarBills = (int)change;
            double cents = change % 1;

            

            if (cents % quarters == 0)
            {
                quarterCnt = (int)(cents / quarters);

            }
            else
            {
                quarterCnt = (int)(cents / quarters);
                remChange = cents - (quarterCnt * quarters);
            }

            if (remChange % dimes == 0)
            {
                dimeCnt = (int)(remChange / dimes);
            }
            else
            {
                dimeCnt = (int)(remChange / dimes);
                remChange = remChange - (dimeCnt * dimes);
            }
            if (remChange % nickels == 0)
            {

                nickelCnt = (int)(remChange / nickels);
            }
            else if (remChange >= .05)
            {
                nickelCnt = (int)(remChange / nickels);
                remChange = remChange - (nickelCnt * nickels);
                pennyCnt = (int)Math.Round((remChange*100));
            }
            else
            {
                pennyCnt = (int)Math.Round((remChange*100));
            }
            Console.WriteLine("Change due is {0} dollars, {1} quarters, {2} dimes, {3} nickels, {4} pennies",dollarBills, quarterCnt, dimeCnt, nickelCnt, pennyCnt);
            Console.WriteLine("");
            Console.WriteLine("Thank you for using the change calculator!");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Sales Price");
            double sales = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter cash paid");
            double cashPaid = double.Parse(Console.ReadLine());

            
            CalcChange(sales, cashPaid);
        }
    }
}
