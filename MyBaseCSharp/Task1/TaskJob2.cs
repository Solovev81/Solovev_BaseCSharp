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
            Valadation();
        }

        private void Valadation()
        {
            if (!((FirstNum is int && SecondNum is int)
            || (FirstNum is float && SecondNum is float)
            || (FirstNum is double && SecondNum is double)))
            {
                throw new Exception("Доступны только простые типы int,float,double");
            }
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