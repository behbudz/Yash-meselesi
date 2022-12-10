using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int il, ay, gun;
            Console.Write("anadan oldugunuz ili daxil edin");
            il = Convert.ToInt32(Console.ReadLine());
            Console.Write("anadan oldugunuz ayi daxil edin");
            ay = Convert.ToInt32(Console.ReadLine());
            Console.Write("anadan oldugunuz gunu daxil edin");
            gun = Convert.ToInt32(Console.ReadLine());

            int il1, ay1, gun1;
            Console.Write("hal hazirda oldugunuz ili daxin edin");
            il1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("hal hazirda oldugunuz ayi daxin edin");
            ay1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("hal hazirda oldugunuz gunu daxin edin");
            gun1= Convert.ToInt32(Console.ReadLine());

            int yas;
            yas = il1 - il;
            Console.Write("Sizin yasiniz");
            Console.WriteLine(yas);
        }
    }
}