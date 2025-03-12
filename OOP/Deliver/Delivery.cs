using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Deliver
{
    abstract class Delivery
    {
        private string address;
        private DateTime dateDelivery;

        public string Address { get { return address; } set { address = value; } }
        public DateTime DateDelivery { get { return dateDelivery; } set { dateDelivery = value; } }

        abstract public void CreateDelivery();

        abstract public void PrintDelivery();
    }

}
