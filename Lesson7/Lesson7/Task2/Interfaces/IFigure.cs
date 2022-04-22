using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7.Task2
{
    internal interface IFigure
    {
        /// <summary>
        /// Цвет фигуры
        /// </summary>
        public FigureColor Color { get; set; }

        /// <summary>
        /// Состояние фигуры (видимый/невидимый)
        /// </summary>
        public bool Visible { get; set; }

        /// <summary>
        /// Координата Х на плоскости
        /// </summary>
        public int PositionX { get; set; }

        /// <summary>
        /// Координата Y на плоскости
        /// </summary>
        public int PositionY { get; set; }

        /// <summary>
        /// Метод передвижения по горизонтали
        /// </summary>
        /// <param name="distance"></param>
        void HorisontalMove(int distance);

        /// <summary>
        /// Метод движения по вертикали
        /// </summary>
        /// <param name="distance"></param>
        void VerticalMove(int distance);

        /// <summary>
        /// Метод изменения цвета
        /// </summary>
        /// <param name="color"></param>
        void ChangeColor(FigureColor color);

        /// <summary>
        /// Метод вывода состояния фигуры
        /// </summary>
        /// <returns></returns>
        bool IsFigureVisible();

        /// <summary>
        /// Метод вывода на экран
        /// </summary>
        void PrintFigure();
    }
}
