using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBaseCSharp.Task1
{
    public class TaskJob4 //Basket
    {
        // Создать консольное приложение “Корзина”, в “Корзину” можно добавлять
        // продукты а затем выводить их все в консоль.

        private List<string> _productsBasket = new List<string>();

        public void AddNewProduct(string newProd)
        {
            _productsBasket.Add(newProd);
            Console.WriteLine($"Вы добавили {newProd}");
        }

        public void PrintAllProducts()
        {
            if (!_productsBasket.Any())
            {
                Console.WriteLine("Амбар пуст, Милорд");
            }
            else
            {
                Console.WriteLine("Запасы провизии пополняются, Сэр");
                foreach (var prod in _productsBasket)
                {
                    Console.WriteLine(prod);
                }
                Console.WriteLine("Люди любят вас, мой Лорд");
            }
        }

    }
}