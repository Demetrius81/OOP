using System;

namespace Lesson5
{
    /// <summary>
    /// Класс комплексных чисел
    /// </summary>
    public class Complex
    {
        /*
           На перегрузку операторов. 
         V Описать класс комплексных чисел. 
         V Реализовать операцию сложения, 
         V умножения,
         V вычитания, 
         V проверку на равенство двух комплексных чисел. 
         V Переопределить метод ToString() для комплексного числа. 
         V Протестировать на простом примере.

        */

        #region Fields and properties

        private double _real;

        private double _imaginary;

        /// <summary>
        /// Действительная часть комплексного числа
        /// </summary>
        public double Real { get => _real; set => _real = value; }

        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        public double Imaginary { get => _imaginary; set => _imaginary = value; }

        #endregion

        #region Ctors

        public Complex()
        {
            _real = 0.0;

            _imaginary = 0.0;
        }

        public Complex(double real, double imaginary)
        {
            _real = real;

            _imaginary = imaginary;
        }

        #endregion

        /// <summary>
        /// Переопределение метода Equals
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Complex a = obj as Complex;

            if (a == null)
            {
                return false;
            }
            return a._real == this._real && a._imaginary == this._imaginary;
        }

        /// <summary>
        /// Перегрузка метода Equals
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool Equals(Complex a)
        {
            if (a == null)
            {
                return false;
            }
            return a._real == this._real && a._imaginary == this._imaginary;
        }

        /// <summary>
        /// Переопределение метода ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"{this._real} + i{this._imaginary}";

        /// <summary>
        /// Переопределение метода GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode() => _real.GetHashCode() ^ _imaginary.GetHashCode();

        /// <summary>
        /// Метод сложения комплексных чисел
        /// </summary>
        /// <param name="a">Комплексное число</param>
        /// <param name="b">Комплексное число</param>
        /// <returns>Результат</returns>
        private static Complex Sum(Complex a, Complex b)
        {
            CheckIsNull(a, b);

            Complex result = new Complex();

            result._real = a._real + b._real;

            result._imaginary = a._imaginary + b._imaginary;

            return result;
        }

        /// <summary>
        /// Метод умножения комплексных чисел
        /// </summary>
        /// <param name="a">Комплексное число</param>
        /// <param name="b">Комплексное число</param>
        /// <returns>Результат</returns>
        private static Complex Multiplication(Complex a, Complex b)
        {
            CheckIsNull(a, b);

            Complex res = new Complex();

            res._real = a._real * b._real - a._imaginary * b._imaginary;

            res._imaginary = a._imaginary * b._real + a._real * b._imaginary;

            return res;
        }

        /// <summary>
        /// Метод вычитания из комплексного числа a числа b
        /// </summary>
        /// <param name="a">Комплексное число</param>
        /// <param name="b">Комплексное число</param>
        /// <returns>Результат</returns>
        private static Complex Subtract(Complex a, Complex b)
        {
            CheckIsNull(a, b);

            Complex res = new Complex();

            res._real = a._real - b._real;

            res._imaginary = a._imaginary - b._imaginary;

            return res;
        }

        /// <summary>
        /// Перегрузка оператора != для комплексных чисел
        /// </summary>
        /// <param name="a">Комплексное число</param>
        /// <param name="b">Комплексное число</param>
        /// <returns>Результат</returns>
        public static Complex operator +(Complex a, Complex b) => Complex.Sum(a, b);

        /// <summary>
        /// Перегрузка оператора != для комплексных чисел
        /// </summary>
        /// <param name="a">Комплексное число</param>
        /// <param name="b">Комплексное число</param>
        /// <returns>Результат</returns>
        public static Complex operator -(Complex a, Complex b) => Complex.Subtract(a, b);

        /// <summary>
        /// Перегрузка оператора != для комплексных чисел
        /// </summary>
        /// <param name="a">Комплексное число</param>
        /// <param name="b">Комплексное число</param>
        /// <returns>Результат</returns>
        public static Complex operator *(Complex a, Complex b) => Complex.Multiplication(a, b);

        /// <summary>
        /// Перегрузка оператора != для комплексных чисел
        /// </summary>
        /// <param name="a">Комплексное число</param>
        /// <param name="b">Комплексное число</param>
        /// <returns>Результат</returns>
        public static bool operator ==(Complex a, Complex b) => a.Equals(b);

        /// <summary>
        /// Перегрузка оператора != для комплексных чисел
        /// </summary>
        /// <param name="a">Комплексное число</param>
        /// <param name="b">Комплексное число</param>
        /// <returns>Результат</returns>
        public static bool operator !=(Complex a, Complex b) => !a.Equals(b);

        /// <summary>
        /// Метод проверяет аргументы на null
        /// </summary>
        /// <param name="a">Число a</param>
        /// <param name="b">Число b</param>
        /// <exception cref="NullReferenceException">Генерируется исключение</exception>
        private static void CheckIsNull(Complex a, Complex b)
        {
            if (a is null || b is null)
            {
                throw new NullReferenceException();
            }
        }

    }
}
