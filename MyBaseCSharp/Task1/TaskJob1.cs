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

        int[] _myIntArray = { 1, 2, 3, 4 };
        List<int> _myIntList = new List<int>() { 1, 2, 3, 4, 5 };
        object _myObject = new object();

        public void GetAllMaxMinValueOfTypes()
        {
            Console.WriteLine($"bool Минимальное значение: {false}/0 Максимальное значение: {true}/1");
            Console.WriteLine($"byte Минимальное значение: {byte.MinValue} Максимальное значение: {byte.MaxValue}");
            Console.WriteLine($"int Минимальное значение: {int.MinValue} Максимальное значение: {int.MaxValue}");
            Console.WriteLine($"long Минимальное значение: {long.MinValue} Максимальное значение: {long.MaxValue}");
            Console.WriteLine($"float Минимальное значение: {float.MinValue} Максимальное значение: {float.MaxValue}");
            Console.WriteLine($"double Минимальное значение: {double.MinValue} Максимальное значение: {double.MaxValue}");
            Console.WriteLine($"char Минимальное значение: {char.MinValue} Максимальное значение: {char.MaxValue}");
            Console.WriteLine("string Минимальное значение: 0 or null Максимальное значение: {-}");
            Console.WriteLine(_myObject.GetType());
            Enumerator(_myIntArray);
            Console.WriteLine("-------");
            Enumerator(_myIntList.ToArray());
        }

        private void Enumerator(Array array)
        {
            foreach (var a in array)
            {
                Console.WriteLine(a);
            }
        }
    }
}