using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6.Task2
{
    internal class Point : Figure
    {
        public Point(int x, int y) : base(x, y) { }

        public Point(int x, int y, bool isVisible, FigureColor color) : base(x, y, isVisible, color) { }

        /// <summary>
        /// Метод вывода на экран точки
        /// </summary>
        public override void PrintFigure()
        {
            Console.WriteLine($"Точка {Color} цвета");
            Console.WriteLine(Visible ? "Точка видима" : "Точка невидима");
            Console.WriteLine($"Точка имеет координаты ({PositionX}, {PositionY})");
        }
    }
}
