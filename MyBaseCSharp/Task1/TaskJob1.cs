using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBaseCSharp.Task1
{
    public class TaskJob1
    {
        // Вывести переменные в консоль (максимальное и минимальное значения
        // для примитивов). Ожидаются переменные типов bool, byte, int, long,
        // float, double, char, string. Также необходимо вывести в консоль
        // массив int-чисел (Array<int>) и тип object.
        public void GetAllMaxMinValueOfTypes()
        {
            Console.WriteLine($"bool Минимальное значение: {false} Максимальное значение: {true}");
            Console.WriteLine($"byte Минимальное значение: {byte.MinValue} Максимальное значение: {byte.MaxValue}");
            Console.WriteLine($"int Минимальное значение: {int.MinValue} Максимальное значение: {int.MaxValue}");
            Console.WriteLine($"long Минимальное значение: {long.MinValue} Максимальное значение: {long.MaxValue}");
            Console.WriteLine($"float Минимальное значение: {float.MinValue} Максимальное значение: {float.MaxValue}");
            Console.WriteLine($"double Минимальное значение: {double.MinValue} Максимальное значение: {double.MaxValue}");
            Console.WriteLine($"char Минимальное значение: {char.MinValue} Максимальное значение: {char.MaxValue}");
            Console.WriteLine("string Минимальное значение: 0 or null Максимальное значение: {-}");

            int[] myInt = { 1, 2, 3, 4 };
            List<int> myArray = new List<int>();
            object myObject = new object();

            foreach (int i in myInt)
            {
                myArray.Add(i);
                Console.WriteLine(i);
                Console.WriteLine();
            }

            foreach (int i in myArray)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(myObject.GetType());
        }
    }
}