using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MyBaseCSharp.Task1
{
    public class TaskJob3
    {
        // Создать консольное приложение, в котором можно задать минимальное
        // и максимальное число(тип int), после чего в консоль выводятся все
        // простые числа в указанном промежутке.

        public int MaxValue { get; set; }
        public int MinValue { get; set; }

        public TaskJob3(int maxValue, int minValue)
        {
            MaxValue = maxValue;
            MinValue = minValue;
            // Valadation();
        }

        // private void Valadation()
        // {
        //     if (!(MaxValue is int) || !(MinValue is int))
        //     {
        //         throw new Exception("Это не типа int");
        //     }
        //     PrintAllSimpleNumsInRange();
        // }

        private void PrintAllSimpleNumsInRange()
        {
            for (; MinValue <= MaxValue; MinValue++)
            {
                if (MinValue >= 1)
                {
                    for (int i = 2; i <= Math.Sqrt(MinValue); i++)
                    {
                        if (MinValue % i == 0)
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine(MinValue);
                        }
                    }
                }
            }
        }
    }
}