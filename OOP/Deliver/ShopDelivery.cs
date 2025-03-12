using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Deliver
{
    internal class ShopDelivery : Delivery
    {
        private DateTime deliveryTimeOpen;
        private DateTime deliveryTimeClose;
        private string typeProduct;

        public DateTime DeliveryTimeOpen { get { return deliveryTimeOpen; } set { deliveryTimeOpen = value; } }
        public DateTime DeliveryTimeClose { get { return deliveryTimeClose; } set { deliveryTimeClose = value; } }


        public ShopDelivery(string typeProduct)
        {
            this.typeProduct = typeProduct;
        }

        override public void CreateDelivery()
        {
            int choose;
            bool flagCycle;
            string workWithUser;
            DateTime dateTimeDevivery;

            switch (typeProduct)
            {
                case "Car":
                    string[] addresCar = Data.GetAddresShopCar();
                    Console.WriteLine("Адрес магазинов:");
                    for (int i = 0; i < addresCar.Length; i++)
                    {
                        Console.WriteLine($"{i + 1} : {addresCar[i]}");
                    }

                    do
                    {
                        Console.WriteLine("Выберите адрес доставки:");
                        workWithUser = Console.ReadLine();
                        flagCycle = Verification.StrToInt(workWithUser, out choose);
                        if (flagCycle)
                        {
                            flagCycle = Verification.IntMoreZero(choose);
                        }
                        if (flagCycle)
                        {
                            flagCycle = choose <= addresCar.Length && choose > 0 ? true : false;
                        }
                    }
                    while (!flagCycle);

                    Address = addresCar[choose - 1];


                    do
                    {
                        Console.Write("Введите дату доставки (DD.MM.YYYY):");

                    } while (!DateTime.TryParse(Console.ReadLine(), out dateTimeDevivery));
                    DateDelivery = dateTimeDevivery;

                    deliveryTimeOpen = DateTime.Parse("08:00:00");
                    deliveryTimeClose = DateTime.Parse("22:00:00");

                    Console.WriteLine($"Магазин работает с {deliveryTimeOpen.ToShortTimeString()} до {deliveryTimeClose.ToShortTimeString()}");

                    break;
                case "Restoran":

                    string[] addresRestoran = Data.GetAddresShopRestoran();
                    Console.WriteLine("Адресса ресторанов:");
                    for (int i = 0; i < addresRestoran.Length; i++)
                    {
                        Console.WriteLine($"{i + 1} : {addresRestoran[i]}");
                    }


                    do
                    {
                        Console.WriteLine("Выберите адрес бронирования:");
                        workWithUser = Console.ReadLine();
                        flagCycle = Verification.StrToInt(workWithUser, out choose);
                        if (flagCycle)
                        {
                            flagCycle = Verification.IntMoreZero(choose);
                        }
                        if (flagCycle)
                        {
                            flagCycle = choose <= addresRestoran.Length && choose > 0 ? true : false;
                        }
                    }
                    while (!flagCycle);

                    Address = addresRestoran[choose - 1];

                    do
                    {
                        Console.Write("Введите дату бронирования (DD.MM.YYYY):");

                    } while (!DateTime.TryParse(Console.ReadLine(), out dateTimeDevivery));
                    DateDelivery = dateTimeDevivery;

                    deliveryTimeOpen = DateTime.Parse("10:00:00");
                    deliveryTimeClose = DateTime.Parse("01:00:00");

                    Console.WriteLine($"Ресторан работает с {deliveryTimeOpen.ToShortTimeString()} до {deliveryTimeClose.ToShortTimeString()}");

                    break;
                default:
                    break;
            }

        }


        override public void PrintDelivery()
        {
            Console.WriteLine($"Адресс: {Address}");
            Console.WriteLine($"Дата: {DateDelivery.ToLongDateString()}");
            Console.WriteLine($"Время работы с {deliveryTimeOpen.ToShortTimeString()} до {deliveryTimeClose.ToShortTimeString()}");
        }
    }
    
}
