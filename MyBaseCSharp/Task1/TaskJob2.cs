using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace MyBaseCSharp.Task1
{
    public class TaskJob2<T> where T : struct
    {
        // Создать консольное приложение, которое будет принимать 2 любых
        // числа одного типа (int, float, double) и показывать какое больше, а
        // также выводить их сумму.

        public T FirstNum { get; set; }
        public T SecondNum { get; set; }

        public TaskJob2(T firstNum, T secondNum)
        {
            FirstNum = firstNum;
            SecondNum = secondNum;
        }

        private void Sum()
        {
            dynamic sum = (dynamic)FirstNum + SecondNum;
            Console.WriteLine("Сумма: " + sum);
        }

        private void GetMaxNum()
        {
            dynamic maxNum = ((dynamic)FirstNum > SecondNum) ? FirstNum : SecondNum;
            Console.WriteLine("Максимальное: " + maxNum);
        }

        public void Start()
        {
            Sum();
            GetMaxNum();
        }
    }
}