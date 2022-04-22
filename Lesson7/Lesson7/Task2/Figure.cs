using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7.Task2
{
    /*
     * Подумать, какие методы можно объявить в интерфейсе, 
     * нужно ли объявлять абстрактный класс, 
     * какие методы и поля будут в абстрактном классе, 
     * какие методы будут виртуальными, какие перегруженными.
     */

    /// <summary>
    /// Класс Figure
    /// </summary>
    internal abstract class Figure : IFigure
    {
        #region Fields and properties

        private FigureColor _color;

        private bool _visible;

        private int _positionX;

        private int _positionY;

        public FigureColor Color { get => _color; set => _color = value; }

        public bool Visible { get => _visible; set => _visible = value; }

        public int PositionX { get => _positionX; set => _positionX = value; }

        public int PositionY { get => _positionY; set => _positionY = value; }

        #endregion

        #region Constructors

        /// <summary>
        /// Конструктор класса Figure
        /// </summary>
        /// <param name="x">int координата X</param>
        /// <param name="y">int координата Y</param>
        /// <param name="isVisible">bool видима или нет</param>
        /// <param name="color">FigureColor цвет фигуры</param>
        public Figure(int x, int y, bool isVisible, FigureColor color)
        {
            _positionX = x;

            _positionY = y;

            _visible = isVisible;

            _color = color;
        }

        /// <summary>
        /// Конструктор класса Figure
        /// </summary>
        /// <param name="x">int координата X</param>
        /// <param name="y">int координата Y</param>        
        public Figure(int x, int y) : this(x, y, true, FigureColor.White) { }

        #endregion
                
        public void ChangeColor(FigureColor color)
        {
            _color = color;
        }

        public void HorisontalMove(int distance)
        {
            _positionX += distance;
        }

        public void VerticalMove(int distance)
        {
            _positionY += distance;
        }

        public bool IsFigureVisible() => _visible;

        public abstract void PrintFigure();
    }
}
