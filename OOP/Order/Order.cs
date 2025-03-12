using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP
{
    abstract class Order
    {
        private decimal price;
        private DateTime date;
        private string description;

        #region Properties
        abstract public Dictionary<string, string> Characteristics { get; set; }
        abstract public Deliver.Delivery Delivery { get; set; }
        abstract public string NameProduct { get; set; }
        public decimal Price { get { return price; } set { price = value; } }
        public DateTime Date { get { return date; } set { date = value; } }
        public string Description { get { return description; } set { description = value; } }

        #endregion

        abstract public void PrintOrder();
        abstract public void CreateOrder();
    }


}
