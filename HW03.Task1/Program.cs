using System;

namespace HW03.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            byte b = (byte) (a + 60); //first example of explicit conversion

            int z = 2;
            short d =(short) (z + 4); //second example of explicit conversion

            double c = 16.34;
            float r =(float) (c + 6); //third example of explicit conversion


            byte x = 7;
            int y = (x + 88); //first example of implicit conversion

            short u = 4;
            float o = (u + 25);//second example of implicit conversion

            float q = 1.01f;
            double v = (q + 24.77); //third example of implicit conversion

            int i = 234;
            object w = i; //boxing

            int l = (int)w;//unboxing





            Console.WriteLine(l);
        }
    }
}
