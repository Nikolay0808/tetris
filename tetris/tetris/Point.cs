using System;
using System.Collections.Generic;
using System.Text;

namespace tetris
{
    class Point
    {
        public int x; // public чтоб переменная была доступна из вне
        public int y;
        public char c;

        public void Draw()// функция которая выводит символ по заданным координатам
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
    }
}
