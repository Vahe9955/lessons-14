using System;

namespace lessons_14
{
    class Butterfly
    {
        public string name;
        public void Fly()
        {

            for (int i = 0; i < 10; i++)
                Console.WriteLine($"{name} Fly!");
        }
    }
    class Program
    {
        public static void swap(int a, int b)
        {
            a = a - b;
            b = a + b;
            a = b - a;
        }
        static void Main()
        {
            Butterfly mahon = new Butterfly();
            mahon.name = "Admiral";
            mahon.Fly();
            mahon.name = "dfghj";
            mahon.Fly();
            Butterfly b2 = new Butterfly
            {
                name = "Vardan"
            };
            b2.Fly();
        }
    }
} 