using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6.Task2
{
    internal sealed class Rectangle : Point
    {
        private int _height;

        private int _width;

        /// <summary>
        /// Высота прямоугольника
        /// </summary>
        public int Height { get => _height; }

        /// <summary>
        /// Ширина прямоугольника
        /// </summary>
        public int Width { get => _width; }

        public Rectangle(int x, int y, int height, int width) :
            this(x, y, true, FigureColor.Orange, height, width)
        { }
        
        public Rectangle(int x, int y, bool isVisible, FigureColor color, int height, int width) : base(x, y, isVisible, color)
        {
            _width = width;
            _height = height;
        }

        /// <summary>
        /// Метод вывода на экран прямоугольника
        /// </summary>
        public new void PrintFigure()
        {
            Console.WriteLine($"Прямоугольник {Color} цвета");
            Console.WriteLine(Visible ? "Прямоугольник видим" : "Прямоугольник невидим");
            Console.WriteLine($"Прямоугольник имеет координаты центра ({PositionX}, {PositionY})");
            Console.WriteLine($"Площадь прямоугольника высотой {Height} и шириной {Width} равна {SquareCalculate()}");
        }

        /// <summary>
        /// Метод вычисления площади прямоугольника
        /// </summary>
        /// <returns></returns>
        public double SquareCalculate() => _height * _width;
    }
}
