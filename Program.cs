using System.Reflection.PortableExecutable;

namespace ConsoleApp1
{
    public static class Work
    {
        public static void Task1()
        {
            Console.WriteLine("It's easy\r\nto win forgiveness for being wrong; being right is what gets you\r\ninto real trouble.");
        }
        public static void Task2()
        {
            int sum = 0, r = 0, d = 1;
            int max = 0, min = 99999;
            int count = 5;
            int a;
            int[] numbers = new int[count];
            for (int i = 0; i < numbers.Length; i++)
            {
                r = int.Parse(Console.ReadLine());
                sum += r;
                if (r > max)
                {
                    max = r;
                }
                if (r < min)
                {
                    min = r;
                }
                d *= r;
            }
            Console.WriteLine("Sum: ");
            Console.WriteLine(sum);
            Console.WriteLine("Max: ");
            Console.WriteLine(max);
            Console.WriteLine("Min: ");
            Console.WriteLine(min);
            Console.WriteLine("Product: ");
            Console.WriteLine(d);
        }
        public static void Task3()
        {
            int s;
            int c = 6;
            int[] n = new int[c];
            for (int i = 0; i < n.Length; i++)
            {
                s = int.Parse(Console.ReadLine());
                n[i] = s;
            }
            n.Reverse();
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine(n[i]);
            }
        }
        public static void Task4()
        {
            int a = 0, b = 1, s = 0;
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                a = n;
            }
            for (int i = n; n < m; n++)
            {
                a = a + b;
                b++;
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
        }
        public static void Task5()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a < b)
            {
                while (a < b)
                {

                    for (int i = 0; i < a; i++)
                    {
                        Console.Write(a);
                    }
                    a++;
                    Console.WriteLine();
                }
            }
        }
        public static void Task6()
        {
            int l = int.Parse(Console.ReadLine());
            char g = char.Parse(Console.ReadLine());
            for (int i = 0; i < l; i++)
            {
                Console.Write(g);
            }
        }
    }
}