using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaine2
{
    internal class Shop
    {
        private Dictionary<Product, int> products;

        public object Products { get; internal set; }

        public Shop()
        {
            products = new Dictionary<Product, int>();
        }
        public void AddProduct(Product product, int count)
        {
            products.Add(product, count);
        }

        public void CreateProduct(string name, decimal price, int count)
        {
            products.Add(new Product(name, price), count);
        }
        public void WriteAllProducts(ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (var product in products)
            {
                listBox.Items.Add($"{product.Key.GetInfo()}; Количество: {product.Value}");
            }
        }

        public void Sell(Product product, int count)
        {
            if (products.ContainsKey(product))
            {
                if (products[product] == 0)
                {
                    
                }
                else
                {
                    if (count < 0) count *= -1;
                    else if (count == 0) count += 1;
                    products[product] -= count;
                }
            }
            else
            {
               
            }
        }

        public void Sell(string ProductName, int count)
        {
            Product ToSell = FindByName(ProductName);
            if (ToSell != null)
            {
                this.Sell(ToSell, count);
            }
            else
            {
                ;
            }
        }

        public Product FindByName(string name)
        {
            foreach (var product in products.Keys)
            {
                if (product.Name == name)
                {
                    return product;
                }
            }
            return null;
        }
    }
}
