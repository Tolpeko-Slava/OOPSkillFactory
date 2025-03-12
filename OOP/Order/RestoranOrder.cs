using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class RestoranOrder<T> : Order
    {
        private Dictionary<string, string> characteristics;
        private Deliver.Delivery delivery;
        private string nameProduct;

        public T Number { get; set; }

        override public Dictionary<string, string> Characteristics
        {
            get
            {
                return characteristics;
            }
            set
            {
                characteristics = value;
            }
        }

        override public Deliver.Delivery Delivery
        {
            get
            {
                return delivery;
            }
            set
            {
                delivery = value;
            }
        }

        override public string NameProduct
        {
            get
            {
                return nameProduct;
            }
            set
            {
                nameProduct = value;
            }
        }


        public RestoranOrder(T number)
        {
            Number = number;
        }


        override public void PrintOrder()
        {
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine($"Номер заказа: {Number.ToString()}\n");
            Console.WriteLine($"Название ресторана: {NameProduct}");
            Console.WriteLine($"Цена: {Price}");
            Console.WriteLine($"Дата заказа:{Date}");
            Delivery.PrintDelivery();
            Console.WriteLine("Описание:");
            Console.WriteLine(Description);
            Console.WriteLine("---------------------------------------------------------------------");
        }

        override public void CreateOrder()
        {
            string[] nameRestoran = Data.GetNameRestoran();
            string workWithUser;
            int choose;
            bool flagCycle;

            Console.WriteLine("Cписок ресторанов");

            for (int i = 0; i < nameRestoran.Length; i++)
            {
                Console.WriteLine($"{i + 1} : {nameRestoran[i]}");
            }

            do
            {
                Console.Write("Выберите ресторан:");
                workWithUser = Console.ReadLine();
                flagCycle = Verification.StrToInt(workWithUser, out choose);
                if (flagCycle)
                {
                    flagCycle = Verification.IntMoreZero(choose);
                }
                if (flagCycle)
                {
                    flagCycle = choose <= nameRestoran.Length && choose > 0 ? true : false;
                }
            }
            while (!flagCycle);


            nameProduct = nameRestoran[int.Parse(workWithUser) - 1];
            characteristics = Data.GetCharacteristicsRestoran(nameProduct);
            Price = Data.GetPriceRestoran(nameProduct);
            Date = DateTime.Now;

            Console.WriteLine("Хотите посмотреть характеристики? Да/Нет");
            workWithUser = Console.ReadLine();

            if (workWithUser == "Да")
            {
                foreach (var item in characteristics)
                {
                    Console.WriteLine($"{item.Key} : {item.Value}");

                }
            }


            delivery = new Deliver.ShopDelivery("Restoran");
            delivery.CreateDelivery();



            Console.WriteLine("Хотите хотите оставить описание к заказу? Да/Нет");
            workWithUser = Console.ReadLine();

            if (workWithUser == "Да")
            {
                Console.WriteLine("Введите описание к заказу.");
                Description = Console.ReadLine();
            }

        }
    }
}
