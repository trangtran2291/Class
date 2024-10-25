namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Question_02();
            Question_03();

        }
        public static void Question_02()
        {
            Console.WriteLine("x = y^2 + 2y + 1");
            Console.Write("Nhap gia tri cua y = ");
            double y = double.Parse(Console.ReadLine());
            double x = Math.Pow(y, 2) + 2 * y + 1;
            Console.WriteLine($"Gia tri cua x = {x}");
            Console.ReadKey();
        }

        public static void Question_03()
        {
            /*Write a C# Sharp program that takes distance and time (hours, minutes,
seconds) as input and displays speed in kilometers per hour (km/h) and
miles per hour (miles/h).*/

            Console.Write("Nhap quang duong duoc tinh bang km x = ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thoi gian (so gio) = ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thoi gian (so phut) = ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thoi gian (so giay) = ");
            double c = double.Parse(Console.ReadLine());
            Console.ReadKey();

            //chuyen thoi gian y sang gio phut giay
            double y = a + b / 60 + c / 3600;

            //tinh toc do o km/h
            double speedInkmh = x / y;
            Console.WriteLine($"Toc do tinh bang km/h = {speedInkmh:F2}");

            double distanceInmiles = x * 1000;
            Console.WriteLine($"Chuyen quang duong tu km sang m = {distanceInmiles}");

            double speedInmileh = distanceInmiles / y;
            Console.WriteLine($"Toc do tinh bang m/h = {speedInmileh:F2}");
            Console.ReadKey();

        }
    }
}
