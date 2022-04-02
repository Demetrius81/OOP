using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson5
{
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

        public bool Equals(Complex a)
        {
            if (a == null)
            {
                return false;
            }
            return a._real == this._real && a._imaginary == this._imaginary;
        }

        private static Complex Sum(Complex a, Complex b)
        {
            CheckIsNull(a, b);

            Complex result = new Complex();

            result._real = a._real + b._real;

            result._imaginary = a._imaginary + b._imaginary;

            return result;
        }

        private static Complex Multiplication(Complex a, Complex b)
        {
            CheckIsNull(a, b);

            Complex res = new Complex();

            res._real = a._real * b._real - a._imaginary * b._imaginary;

            res._imaginary = a._imaginary * b._real + a._real * b._imaginary;

            return res;
        }

        private static Complex Subtract(Complex a, Complex b)
        {
            CheckIsNull(a, b);

            Complex res = new Complex();

            res._real = a._real - b._real;

            res._imaginary = a._imaginary - b._imaginary;

            return res;
        }

        public static Complex operator +(Complex a, Complex b) => Complex.Sum(a, b);

        public static Complex operator -(Complex a, Complex b) => Complex.Subtract(a, b);

        public static Complex operator *(Complex a, Complex b) => Complex.Multiplication(a, b);

        public static bool operator ==(Complex a, Complex b) => a.Equals(b);

        public static bool operator !=(Complex a, Complex b) => !a.Equals(b);

        public override string ToString() => $"{this._real} + i{this._imaginary}";

        private static void CheckIsNull(Complex a)
        {
            if (a is null)
            {
                throw new NullReferenceException();
            }
        }

        private static void CheckIsNull(Complex a, Complex b)
        {
            if (a is null || b is null)
            {
                throw new NullReferenceException();
            }
        }

    }
}
