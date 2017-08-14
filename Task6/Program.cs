using System;
using static System.Console;

namespace Task6
{
    class Program
    {
        public static double Input(string name) // проверка ввода числа
        {
            double number; // переменная для числа
            bool ok; // показатель корректности ввода
            do
            {
                try
                {
                    WriteLine("Введите число {0}", name);
                    number = Convert.ToDouble(ReadLine());
                    ok = true;
                }
                catch (FormatException)
                {
                    WriteLine("Ошибка при вводе числа");
                    ok = false;
                    number = 0;
                }
                catch (OverflowException)
                {
                    WriteLine("Ошибка при вводе числа");
                    ok = false;
                    number = 0;
                }
            } while (!ok);
            return number;
        }

        public static void Action(double a1, double a2, double a3, int j, double m, double n) // вычисление результата
        {
            while (true)
            {
                var seq = ((double) 3 / 2) * a3 - ((double) 2 / 3) * a2 - ((double) 1 / 3) * a1;
                a1 = a2;
                a2 = a3;
                a3 = seq;
                j++;
                Write(seq + " ");
                if (Math.Abs(seq) < m) continue;
                WriteLine("\n");
                WriteLine(Math.Abs(seq) == m ? "Равенство |aj| = M выполняется" : "Равенство |aj| = M не выполняется");
                WriteLine();
                if (j == n)
                    WriteLine("J равно N");
                else if (j > n)
                    WriteLine("J больше N");
                else
                    WriteLine("J меньше N");
                break;
            }
        }

        public static void Main(string[] args)
        {
            bool okay;
            do
            {
                var a1 = Input("a1"); // ввод числа а1
                var a2 = Input("a2"); // ввод числа а2
                var a3 = Input("a3"); // ввод числа а3
                var m = Input("M"); // ввод числа M
                var n = Input("N"); // ввод числа N
                WriteLine();
                Write("Полученная последовательность: " + a1 + " " + a2 + " " + a3 + " ");
                Action(a1, a2, a3, 4, m, n);
                Read();
                WriteLine("Выйти? y - да/n - нет"); //выход из программы
                var ans = ReadLine();
                okay = ans == "y";
            } while (!okay);
        }
    }
}
