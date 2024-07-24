using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MyBaseCSharp.Task1
{
    public class TaskJob3<T> where T : struct
    {
        // Создать консольное приложение, в котором можно задать минимальное
        // и максимальное число(тип int), после чего в консоль выводятся все
        // простые числа в указанном промежутке.

        public T MaxValue { get; set; }
        public T MinValue { get; set; }

        public TaskJob3(T maxValue, T minValue)
        {
            MaxValue = maxValue;
            MinValue = minValue;
            Valadation();
        }

        private void Valadation()
        {
            if (!(MaxValue is int && MinValue is int))
            {
                throw new Exception("Это не типа int");
            }
        }

        private bool SimpleNum(int min)
        {
            if (!(min > 1))
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(min); i++)
            {
                if (min % i == 0)
                    return false;
            }
            return true;
        }

        public void PrintAllSimpleNumsInRange()
        {
            int max = (int)(object)MaxValue;
            int min = (int)(object)MinValue;

            for (; min <= max; min++)
            {
                if (SimpleNum(min))
                {
                    Console.WriteLine(min);
                }
            }
        }
    }
}