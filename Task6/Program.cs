using System;

namespace Task6
{
    class Program
    {
        public static double Input(string name)
        {
            double number;
            bool ok;
            do
            {
                try
                {
                    Console.WriteLine("Введите число {0}", name);
                    number = Convert.ToDouble(Console.ReadLine());
                    ok = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка при вводе числа");
                    ok = false;
                    number = 0;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка при вводе числа");
                    ok = false;
                    number = 0;
                }
            } while (!ok);
            return number;
        }

        public static void Action(double a1, double a2, double a3, int j, double m, double n)
        {
            while (true)
            {
                var seq = ((double) 3 / 2) * a3 - ((double) 2 / 3) * a2 - ((double) 1 / 3) * a1;
                a1 = a2;
                a2 = a3;
                a3 = seq;
                j++;
                Console.Write(seq + " ");
                if (Math.Abs(seq) < m) continue;
                Console.WriteLine("\n");
                Console.WriteLine(Math.Abs(seq) == m ? "Равенство |aj| = M выполняется" : "Равенство |aj| = M не выполняется");
                Console.WriteLine();
                if (j == n)
                    Console.WriteLine("J равно N");
                else if (j > n)
                    Console.WriteLine("J больше N");
                else
                    Console.WriteLine("J меньше N");
                break;
            }
        }

        public static void Main(string[] args)
        {
            var a1 = Input("a1");
            var a2 = Input("a2");
            var a3 = Input("a3");
            var m = Input("M");
            var n = Input("N");
            Console.WriteLine();
            Console.Write("Полученная последовательность: " + a1 + " " + a2 + " " + a3 + " ");
            Action(a1, a2, a3, 4, m, n);
            Console.Read();
        }
    }
}
