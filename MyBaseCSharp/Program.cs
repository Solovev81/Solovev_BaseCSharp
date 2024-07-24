//---------- Task1_job5
using MyBaseCSharp.Task1;

TaskJob5 taskJob5 = new TaskJob5();
taskJob5.StartInstallation();
//----------



// Создать консольное приложение “Корзина”, в “Корзину” можно добавлять
// продукты а затем выводить их все в консоль.
// List<string> products = new List<string>() {"apple","milk","meat"};

// Basket basket1 = new Basket();
// Basket basket2 = new Basket();

// basket1.PrintAllProducts();
//System.Console.WriteLine();

// foreach(var prod in products)
// {
//     basket2.AddNewProduct(prod);
// }

// basket2.PrintAllProducts();

// class Basket {
//     private List<string> _productsBasket = new List<string>();

//     public void AddNewProduct (string newProd)
//     {
//         _productsBasket.Add(newProd);
//         System.Console.WriteLine($"Вы добавили {newProd}");
//     }

//     public void PrintAllProducts()
//     {
//         if (!_productsBasket.Any())
//         {
//             System.Console.WriteLine("Амбар пуст, Милорд");
//         }
//         else
//         {
//             System.Console.WriteLine("Запасы провизии пополняются, Сэр");
//             foreach (var prod in _productsBasket)
//             {
//                 System.Console.WriteLine(prod);
//             }
//             System.Console.WriteLine("Люди любят вас, мой Лорд");
//         }
//     }
// }

// Создать консольное приложение, в котором можно задать минимальное
// и максимальное число (тип int), после чего в консоль выводятся все
// простые числа в указанном промежутке.