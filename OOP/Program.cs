using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static WorkWithOrder workWithOrder;

        static void Main(string[] args)
        {
            workWithOrder = new WorkWithOrder();

            Order order;
            string orderString;
            int choose;
            bool flagCycle;

            Console.WriteLine("Приветствую вы можете сделать заказ:");
            Console.WriteLine("1) На машину");
            Console.WriteLine("2) В ресторан(-е)");

            do
            {
                Console.Write("Выберете какой вид заказа вас интересует:");
                orderString = Console.ReadLine();
                flagCycle = Verification.StrToInt(orderString, out choose);
                if (flagCycle)
                {
                    flagCycle = Verification.IntMoreZero(choose);
                }
                if (flagCycle)
                {
                    flagCycle = choose < 3 && choose > 0 ? true : false;
                }
            }
            while (!flagCycle);


            order = workWithOrder.ChoseOrder(orderString);

            order.CreateOrder();

            order.PrintOrder();
        }

        

    }

}
