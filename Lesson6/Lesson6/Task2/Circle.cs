using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6.Task2
{
    internal sealed class Circle : Point
    {
        private int _radius;

        public int Radius { get => _radius;}

        public Circle(int x, int y, int rad) : this(x, y, true, FigureColor.White, rad)
        {
        }

        public Circle(int x, int y, bool isVisible, FigureColor color, int rad) : base(x, y, isVisible, color)
        {
            _radius = rad;
        }

        /// <summary>
        /// Метод вывода на экран окружности
        /// </summary>
        public new void PrintFigure()
        {
            Console.WriteLine($"Окружность {Color} цвета");
            Console.WriteLine(Visible ? "Окружность видима" : "Окружность невидима");
            Console.WriteLine($"Окружность имеет координаты центра ({PositionX}, {PositionY})");
            Console.WriteLine($"Площадь окружности радиусом {_radius} равна {SquareCalculate()}");
        }
        /// <summary>
        /// Метод вычисляет площадь окружности
        /// </summary>
        /// <returns></returns>
        public double SquareCalculate() => Math.PI * Math.Pow(_radius, 2);
    }
}
