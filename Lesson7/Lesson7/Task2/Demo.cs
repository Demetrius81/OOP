using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7.Task2
{
    internal static class Demo
    {
        public static void TaskDemo()
        {
            Console.Clear();

            Console.WriteLine($"Демонстрация работы второй задачи.");

            Console.WriteLine();
            
            Console.WriteLine("Создаем точку");

            Point point = new Point(3, 11);

            point.PrintFigure();

            Console.WriteLine("Перемещаем точку по горизонтали и вертикали и меняем цвет");

            point.HorisontalMove(-8);

            point.VerticalMove(1);

            point.ChangeColor(FigureColor.Purple);

            point.PrintFigure();

            Console.WriteLine();

            Console.WriteLine("Создаем окружность");

            IFlatFigure circl = new Circle(12, -8, false, FigureColor.Blue, 45);

            Circle circle = circl as Circle;

            circle.PrintFigure();

            Console.WriteLine("Перемещаем окружность по горизонтали и вертикали и меняем цвет");

            circle.HorisontalMove(-30);

            circle.VerticalMove(-80);

            circle.ChangeColor(FigureColor.White);

            circle.PrintFigure();

            Console.WriteLine();

            Console.WriteLine("Создаем прямоугольник");

            IFlatFigure rectangl = new Rectangle(2, 14, 30, 12);

            Rectangle rectangle = (Rectangle)rectangl;

            rectangle.PrintFigure();

            Console.WriteLine("Перемещаем прямоугольник по горизонтали и вертикали");

            rectangle.HorisontalMove(15);

            rectangle.VerticalMove(12);

            rectangle.PrintFigure();

            Console.WriteLine($"To continue press any key...");

            Console.ReadKey();
        }
    }
}
