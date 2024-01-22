using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ломает_инкапсуляцию
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cart cart = new Cart();
            cart.ShowProduct();
            List<Product> products = new List<Product>();
            for(int i = 0; i < cart.GetProductsCount(); i++) // цикл по велечине 
            {
                products.Add(cart.GetProductByIndex(i));

            }
            Console.WriteLine("");
            products.RemoveAt(0);
            Console.WriteLine("Перезаписанная лист продуктов без 1 значения");
            foreach(Product product in products) 
            {Console.WriteLine(product.Name);
            }
        }
    }
    class Cart
    {
        private List<Product> _products = new List<Product>();
        public Cart()
        {
            _products.Add(new Product("Яблоко"));
            _products.Add(new Product("Банан"));
            _products.Add(new Product("Апельсин"));
            _products.Add(new Product("Груша"));
        }
        public void ShowProduct()
        {
            foreach(var product in _products) 
            { 
                Console.WriteLine(product.Name);
            }
        }
        public Product GetProductByIndex(int index) // возвращение значения в list по индексу
        {
            return _products.ElementAt(index);
            
        }
        public int GetProductsCount()//возращение размера list
        {
            return _products.Count();
        }
    }
    class Product
    {
        public string Name { get; private set; }
        public Product(string name) 
        {
        Name = name;
        }
    }
}
