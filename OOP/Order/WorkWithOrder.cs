using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class WorkWithOrder
    {
        public Order ChoseOrder(string numberTypeOrder)
        {
            Random random = new Random();
            switch (numberTypeOrder)
            {
                case "1":
                    return new CarOrder<int>(random.Next(0,2500000));
                case "2":
                    return new RestoranOrder<string>("NH-" + random.Next(100000,999999).ToString());
                default:
                    return null;
            }

        }

    }
}
