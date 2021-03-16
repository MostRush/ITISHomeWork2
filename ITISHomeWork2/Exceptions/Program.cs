using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;

            try
            {
                result = Divide(10, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(result);

            try
            {
                PrintMessage(null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine(GetValue(-1));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine(DoSomething("asdasd"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        static double Divide(double x, double y)
        {
            if (y == 0)
                throw new DivideByZeroException("На ноль делить нельзя!");

            return x / y;
        }

        static void PrintMessage(string msg)
        {
            if (msg is null)
                throw new ArgumentNullException("Сообщение не может быть null!");

            Console.WriteLine(msg);
        }

        static int GetValue(int index)
        {
            var array = new int[] { 2, 5, 7, 3, 6 };

            if (index > array.Length - 1 && index < 0)
                throw new IndexOutOfRangeException("Выход за пределы массива!");

            return array[index];
        }

        static int DoSomething(object obj)
        {
            return (int)obj;
        }
    }
}
