using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaine2
{
    internal class Product
    {
        private decimal price;
        private string name;    
        public Product(string Name, decimal Price)
        {
            name = Name;
            price = Price;
        }
        public string GetInfo()
        {
            return $"Товар: {Name}. Цена: {Price}"; 
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
