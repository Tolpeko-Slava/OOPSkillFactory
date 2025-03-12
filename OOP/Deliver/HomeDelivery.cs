using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Deliver
{
    internal class HomeDelivery : Delivery
    {
        private DateTime timeDelivery;
        private string numberPhoneUser;

        public DateTime TimeDelivery { get { return timeDelivery; } set { timeDelivery = value; } }
        public string NumberPhoneUser { get { return numberPhoneUser; } set { numberPhoneUser = value; } }

        override public void CreateDelivery()
        {
            DateTime dateTimeDevivery;

            Console.Write("Введите адрес доставки:");
            Address = Console.ReadLine();
            Console.Write("Введите номер телефона:");
            numberPhoneUser = Console.ReadLine();

            do
            {
                Console.Write("Введите дату доставки (DD.MM.YYYY):");

            } while (!DateTime.TryParse(Console.ReadLine(), out dateTimeDevivery));
            DateDelivery = dateTimeDevivery;


            do
            {
                Console.Write("Введите время доставки (Ч:M)");

            } while (!DateTime.TryParse(Console.ReadLine(), out dateTimeDevivery));
            timeDelivery = dateTimeDevivery;
        }

        override public void PrintDelivery()
        {
            Console.WriteLine($"Адресс доставки: {Address}");
            Console.WriteLine($"Дата доставки: {DateDelivery.ToLongDateString()}");
            Console.WriteLine($"Время доставки: {timeDelivery.ToShortTimeString()}");

        }
    }
}
