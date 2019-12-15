using System;

namespace hm_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ");
            char simvol = Convert.ToChar(Console.ReadLine());
            if(simvol == 'W')
            {
                Console.WriteLine("Фигура переместилась вверх");
            }
            if (simvol == 'S')
            {
                Console.WriteLine("Фигура переместилась вниз");
            }
            if (simvol == 'A')
            {
                Console.WriteLine("Фигура переместилась влево");
            }
            if (simvol == 'D')
            {
                Console.WriteLine("Фигура переместилась вправо");
            }
            if(simvol != 'W' && simvol!='A' && simvol!='S' && simvol!='D' )
            {
                Console.WriteLine("Нет необходимости перемещения");
            }


                
        }
    }
}
