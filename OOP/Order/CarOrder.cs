using OOP.Deliver;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class CarOrder<T> : Order
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


        public CarOrder(T number)
        {
            Number = number;
        }



        override public void PrintOrder()
        {
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine($"Номер заказа: {Number.ToString()}\n");
            Console.WriteLine($"Название машины: {NameProduct}");
            Console.WriteLine($"Цена: {Price}");
            Console.WriteLine($"Дата заказа:{Date}");
            Delivery.PrintDelivery();
            Console.WriteLine("Описание:");
            Console.WriteLine(Description);
            Console.WriteLine("---------------------------------------------------------------------");
        }

        override public void CreateOrder()
        {
            string[] nameCar = Data.GetNameCar();
            string workWithUser;
            int choose;
            bool flagCycle;

            Console.WriteLine("Cписок машин");

            for (int i = 0; i < nameCar.Length; i++)
            {
                Console.WriteLine($"{i + 1} : {nameCar[i]}");
            }

            do
            {
                Console.Write("Выберите машину:");
                workWithUser = Console.ReadLine();
                flagCycle = Verification.StrToInt(workWithUser, out choose);
                if (flagCycle)
                {
                    flagCycle = Verification.IntMoreZero(choose);
                }
                if (flagCycle)
                {
                    flagCycle = choose <= nameCar.Length && choose > 0 ? true : false;
                }
            }
            while (!flagCycle);

            nameProduct = nameCar[int.Parse(workWithUser) - 1];
            characteristics = Data.GetCharacteristicsCar(nameProduct);
            Price = Data.GetPriceCar(nameProduct);
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


            Console.WriteLine("Выберите вид доставки:");
            Console.WriteLine("1) На дом");
            Console.WriteLine("2) Самовывоз");

            do
            {
                workWithUser = Console.ReadLine();
                flagCycle = Verification.StrToInt(workWithUser, out choose);
                if (flagCycle)
                {
                    flagCycle = Verification.IntMoreZero(choose);
                }
                if (flagCycle)
                {
                    flagCycle = choose <= 2 && choose > 0 ? true : false;
                }
            }
            while (!flagCycle);

            switch (workWithUser)
            {
                case "1":
                    delivery = new Deliver.HomeDelivery();
                    break;
                case "2":
                    delivery = new Deliver.ShopDelivery("Car");
                    break;
                default:
                    delivery = null;
                    break;
            }
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
