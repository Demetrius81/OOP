using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7.Task2
{
    /*
    V Создать класс Rectangle(прямоугольник) как потомок точки,
    V реализовать метод вычисления площади прямоугольника.
    */

    /// <summary>
    /// Класс Rectangle
    /// </summary>
    internal sealed class Rectangle : Point, IFlatFigure
    {
        #region Fields and properties

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

        #endregion

        #region Constructors

        /// <summary>
        /// Конструктор класса Rectangle
        /// </summary>
        /// <param name="x">int координата X</param>
        /// <param name="y">int координата Y</param>
        /// <param name="height"></param>
        /// <param name="width"></param>
        public Rectangle(int x, int y, int height, int width) :
            this(x, y, true, FigureColor.Orange, height, width)
        { }

        /// <summary>
        /// Конструктор класса Rectangle
        /// </summary>
        /// <param name="x">int координата X</param>
        /// <param name="y">int координата Y</param>
        /// <param name="isVisible">bool видим или нет</param>
        /// <param name="color">FigureColor цвет фигуры</param>
        /// <param name="height">int высота прямоугольника</param>
        /// <param name="width">int ширина прямоугольника</param>
        public Rectangle(int x, int y, bool isVisible, FigureColor color, int height, int width) : base(x, y, isVisible, color)
        {
            _width = width;
            _height = height;
        }

        #endregion

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
