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
        public Point(int a, int b, char sym )// Функция конструктор, которая вызывается при создании объекта , имя функци конструктора равно имени класса
        {
            x = a;
            y = b;
            c = sym;
        }

        public Point () { }// Функция конструктор, которая вызывается по умолчанию, если нет других конструкторов

    }
}
