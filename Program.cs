using System; //Виталий Войтов

namespace homework_2._1 //Написать метод, возвращающий минимальное из трёх чисел
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, min;
            Console.WriteLine("Введите три целых числа");
            Console.Write("Первое число ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Второе число ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Третье число ");
            c = Convert.ToInt32(Console.ReadLine());

            if (c < a && c < b)
            {
                min = c;
            }
            else

            {
                if (a < b)
                {
                    min = a;
                }
                else
                {
                    min = b;
                }
            }

            Console.WriteLine("Наименьшее число {0}", min);
            Console.WriteLine("Для выхода из приложения нажмите Enter");

            Console.ReadLine();
        }
    }
}
