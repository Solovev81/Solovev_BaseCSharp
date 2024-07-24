using System;
using System.Collections.Generic;
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
        }

        public void PrintAllSimpleNumsInRange()
        {

        }
    }
}