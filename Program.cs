using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2
{
    internal class Program
    {
        public static void Main()
        {
            //uestion_01();
            //uestion_02();
            Question_03();
        }

        public static void Question_01()
        {
            Console.Write("Nhap so a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap so c = ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"So lon nhat la : {max3nums(a, b, c)}");

            int max2nums(int a, int b)
            {
                return a > b ? a : b;
            }

          int max3nums (int a, int b, int c)
            {
                return max2nums(a, max2nums(b, c));

            }

        }

        public static void Question_02()
        {
            Console.Write("Nhap mot so nguyen khong am x= ");
            long x = long.Parse(Console.ReadLine());

            long factorial(long a)
            {
                if (a <0)
                {
                    a = -a;
                }
                return a == 0 ? 1 : factorial(a - 1) * a;

            }

            long result = factorial(x);
            Console.WriteLine($"The factoria of {x} is {result}");
        }

        public static void Question_03()
        {

        }
    }
}
