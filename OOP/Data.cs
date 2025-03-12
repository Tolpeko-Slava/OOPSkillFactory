using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    static class Data
    {

        static public string[] GetNameCar()
        {
            string[] resCar = new string[2];
            resCar[0] = "Toyto";
            resCar[1] = "BYD";

            return resCar;
        }

        static public Dictionary<string, string> GetCharacteristicsCar(string nameCar)
        {
            Dictionary<string, string> characteristics = new Dictionary<string, string>();

            switch(nameCar)
            {
                case "Toyto":
                    characteristics.Add("Двигатель", "ДВС");
                    characteristics.Add("Л.С.", "125");
                    characteristics.Add("КПП", "Механика");
                    break;
                case "BYD":
                    characteristics.Add("Двигатель", "Электро");
                    characteristics.Add("Л.С.", "140");
                    characteristics.Add("КПП", "Автомат");
                    break;
                default:
                    break;
            }


            return characteristics;
        }

        static public decimal GetPriceCar(string nameCar)
        {
            decimal priceCar = decimal.MinValue;
            
            switch (nameCar)
            {
                case "Toyto":
                    priceCar = 2000;
                    break;
                case "BYD":
                    priceCar = 3500;
                    break;
                default:
                    break;
            }

            return priceCar;

        }

        static public string[] GetAddresShopCar()
        {
            string[] res = new string[2];
            res[0] = "Минск,Незовисомостей д.5";
            res[1] = "Минск,Якуба Колоса д.7";

            return res;
        }





        static public string[] GetNameRestoran()
        {
            string[] resRestoran = new string[2];
            resRestoran[0] = "Restoran1";
            resRestoran[1] = "Restoran2";

            return resRestoran;
        }
        static public Dictionary<string, string> GetCharacteristicsRestoran(string nameRestoren)
        {
            Dictionary<string, string> characteristics = new Dictionary<string, string>();

            switch (nameRestoren)
            {
                case "Restoran1":
                    characteristics.Add("Оснавная кухня", "Пан азия");
                    characteristics.Add("Звезд мишлен", "2");
                    characteristics.Add("Поваров", "12");
                    break;
                case "Restoran2":
                    characteristics.Add("Оснавная кухня", "Французкая");
                    characteristics.Add("Звезд мишлен", "3");
                    characteristics.Add("Поваров", "27");
                    break;
                default:
                    break;
            }


            return characteristics;
        }

        static public decimal GetPriceRestoran(string nameRestoran)
        {
            decimal priceRestoran = decimal.MinValue;

            switch (nameRestoran)
            {
                case "Restoran1":
                    priceRestoran = 150;
                    break;
                case "Restoran2":
                    priceRestoran = 420;
                    break;
                default:
                    break;
            }

            return priceRestoran;

        }

        static public string[] GetAddresShopRestoran()
        {
            string[] res = new string[2];
            res[0] = "Минск,Незовисомостей д.1";
            res[1] = "Минск,Немига";

            return res;
        }
    }
}
