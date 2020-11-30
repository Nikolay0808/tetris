using System;

namespace tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30); // размер консоли
            Console.SetBufferSize(40, 30);//убирает полоски прокрутки

            int x1 = 2;
            int y1 = 3;
            char c1 = '*';

            Console.SetCursorPosition(x1, y1);//устанавливает курсор в консоле по заданной координате
            Console.Write(c1);// записывает символ в консоле

            int x2 = 2;
            int y2 = 10;
            char c2 = '*';

            Console.SetCursorPosition(x2, y2);//устанавливает курсор в консоле по заданной координате
            Console.Write(c2);// записывает символ в консоле


            Console.ReadLine(); // перед закрытием консоли дождется нажатия клавиши
        }
    }
}
