using System;

namespace tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30); // размер консоли
            Console.SetBufferSize(40, 30);//убирает полоски прокрутки

             
            Point p1 = new Point();
            p1.x = 2;
            p1.y = 3;
            p1.c = '*';
            p1.Draw();

            Point p2 = new Point();
            p2.x = 5;
            p2.y = 10;
            p2.c = '*';
            p2.Draw();



            Console.ReadLine(); // перед закрытием консоли дождется нажатия клавиши
        }

        
    }
}
