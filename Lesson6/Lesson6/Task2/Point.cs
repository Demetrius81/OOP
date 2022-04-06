using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6.Task2
{
    /*
    V Создать класс Point(точка) как потомок геометрической фигуры.
    */

    /// <summary>
    /// Класс Point
    /// </summary>
    internal class Point : Figure
    {
        #region Constructors

        /// <summary>
        /// Конструктор класса точка
        /// </summary>
        /// <param name="x">int координата X</param>
        /// <param name="y">int координата Y</param> 
        public Point(int x, int y) : base(x, y) { }

        /// <summary>
        /// Конструктор класса точка
        /// </summary>
        /// <param name="x">int координата X</param>
        /// <param name="y">int координата Y</param>
        /// <param name="isVisible">bool видима или нет</param>
        /// <param name="color">FigureColor цвет фигуры</param>
        public Point(int x, int y, bool isVisible, FigureColor color) : base(x, y, isVisible, color) { }

        #endregion

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
