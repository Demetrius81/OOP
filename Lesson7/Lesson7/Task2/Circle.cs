using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7.Task2
{
    /*
    V Создать класс Circle(окружность) как потомок точки.
    V В класс Circle добавить метод, который вычисляет площадь окружности.
    */

    /// <summary>
    /// Класс Circle
    /// </summary>
    internal sealed class Circle : Point
    {
        #region Fields and properties

        private int _radius;

        /// <summary>
        /// Радиус окружности
        /// </summary>
        public int Radius { get => _radius; }

        #endregion

        #region Constructors

        /// <summary>
        /// Конструктор класса Circle
        /// </summary>
        /// <param name="x">int координата X</param>
        /// <param name="y">int координата Y</param>
        /// <param name="rad">int радиус оккужности</param>
        public Circle(int x, int y, int rad) : this(x, y, true, FigureColor.White, rad)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">int координата X</param>
        /// <param name="y">int координата Y</param>
        /// <param name="isVisible">bool видима или нет</param>
        /// <param name="color">FigureColor цвет фигуры</param>       
        /// <param name="rad">int радиус оккужности</param>
        public Circle(int x, int y, bool isVisible, FigureColor color, int rad) : base(x, y, isVisible, color)
        {
            _radius = rad;
        }

        #endregion

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
