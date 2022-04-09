using System;

namespace Lesson5
{
    /// <summary>
    /// Класс рациональных чисел
    /// </summary>
    public class Fractions
    {

        /*
         
         
         V Создать класс рациональных чисел.
         V В классе два поля – числитель и знаменатель.
         V Предусмотреть конструктор. 
           Определить операторы 
         V ==,!= 
         V (метод Equals()), 
         V <, >, 
         V <=, >=, 
         V +, –,
         V ++, --. 
         V Переопределить метод ToString() для вывода дроби.
         V Определить операторы преобразования типов между типом дробь,float, 
         V int. 
         V Определить операторы *, /, 
       ??? % ??? При делении двух рациональных чисел остатка от деления не образуется!!!
                   Я конечно переопределил, но это глупость!

        */

        #region Fields and properties

        private int _numerator;

        private int _denominator;

        /// <summary>
        /// Числитель
        /// </summary>
        public int Numerator { get => _numerator; set => _numerator = value; }

        /// <summary>
        /// Знаменатель
        /// </summary>
        public int Denominator { get => _denominator; set => _denominator = value; }

        #endregion

        #region Ctors

        public Fractions()
        {
            _numerator = 0;
            _denominator = 1;
        }

        public Fractions(int numerator)
        {
            _numerator = numerator;
            _denominator = 1;
        }

        public Fractions(int numerator, int denominator)
        {
            if (denominator <= 0)
            {
                throw new ArgumentException("Знаменатель рационального числа должен быть натуральным числом");
            }
            else
            {
                _numerator = numerator;

                _denominator = denominator;
            }
        }

        #endregion

        /// <summary>
        /// Метод для нахождения наибольшего общего делителя
        /// </summary>
        /// <param name="numerator">Числитель</param>
        /// <param name="denominator">Знаменатель</param>
        /// <returns>Наибольший общий делитель</returns>
        private static int CalculatingTheGreatestCommonDivisor(int numerator, int denominator)
        {
            int GreatestCommonDivisor = 1;

            int temp;

            if (numerator == 0)
            {
                return denominator;
            }
            if (denominator == 0)
            {
                return numerator;
            }
            if (numerator == denominator)
            {
                return numerator;
            }
            if (numerator == 1 || denominator == 1)
            {
                return 1;
            }
            while (numerator != 0 && denominator != 0)
            {
                if (numerator % 2 == 0 && denominator % 2 == 0)
                {
                    GreatestCommonDivisor *= 2;

                    numerator /= 2;

                    denominator /= 2;

                    continue;
                }
                if (numerator % 2 == 0 && denominator % 2 != 0)
                {
                    numerator /= 2;

                    continue;
                }
                if (numerator % 2 != 0 && denominator % 2 == 0)
                {
                    denominator /= 2;

                    continue;
                }
                if (numerator > denominator)
                {
                    temp = numerator;

                    numerator = denominator;

                    denominator = temp;
                }
                temp = numerator;

                numerator = (denominator - numerator) / 2;

                denominator = temp;
            }
            if (numerator == 0)
            {
                return GreatestCommonDivisor * denominator;
            }
            else
            {
                return GreatestCommonDivisor * numerator;
            }
        }

        /// <summary>
        /// Метод сокращения рационального числа
        /// </summary>
        /// <param name="fraction">Число</param>
        private static void FractionReduction(Fractions fraction)
        {
            CheckIsNull(fraction);

            int GreatestCommonDivisor = CalculatingTheGreatestCommonDivisor(fraction._numerator, fraction._denominator);

            fraction._numerator /= GreatestCommonDivisor;

            fraction._denominator /= GreatestCommonDivisor;
        }

        /// <summary>
        /// Метод приведения к общему знаменателю двух рациональных чисел
        /// </summary>
        /// <param name="fraction1">Число</param>
        /// <param name="fraction2">Число</param>
        private static void ToACommonDenominator(Fractions fraction1, Fractions fraction2)
        {
            CheckIsNull(fraction1, fraction2);

            int temp = fraction2._denominator;

            fraction2._numerator *= fraction1._denominator;

            fraction2._denominator *= fraction1._denominator;

            fraction1._numerator *= temp;

            fraction1._denominator *= temp;
        }

        /// <summary>
        /// Переопределение метода Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is null)
            {
                return false;
            }            
            var fraction = obj as Fractions;

            if (fraction is null)
            {
                return false;
            }
            var thisFraction = this;

            ToACommonDenominator(thisFraction, fraction);

            bool isTrue = fraction._numerator == thisFraction._numerator && 
                fraction._denominator == thisFraction._denominator;

            FractionReduction(fraction);

            FractionReduction(thisFraction);

            return isTrue;
        }

        /// <summary>
        /// Перегрузка метода Equals
        /// </summary>
        /// <param name="fraction"></param>
        /// <returns></returns>
        public bool Equals(Fractions fraction)
        {
            if (fraction is null)
            {
                return false;
            }
            var thisFraction = this;

            ToACommonDenominator(thisFraction, fraction);

            bool isTrue = fraction._numerator == thisFraction._numerator && 
                fraction._denominator == thisFraction._denominator;

            FractionReduction(fraction);

            FractionReduction(thisFraction);

            return isTrue;
        }

        /// <summary>
        /// Переопределение метода GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode() => _numerator ^ _denominator;

        /// <summary>
        /// Переопределение метода ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"{this._numerator}/{this._denominator}";

        /// <summary>
        /// Перегрузка оператора == для рациональных чисел
        /// </summary>
        /// <param name="fraction1">Рациональное число</param>
        /// <param name="fraction2">Рациональное число</param>
        /// <returns>Результат</returns>
        public static bool operator ==(Fractions fraction1, Fractions fraction2) => fraction1.Equals(fraction2);

        /// <summary>
        /// Перегрузка оператора != для рациональных чисел
        /// </summary>
        /// <param name="fraction1">Рациональное число</param>
        /// <param name="fraction2">Рациональное число</param>
        /// <returns>Результат</returns>
        public static bool operator !=(Fractions fraction1, Fractions fraction2) => !fraction1.Equals(fraction2);

        /// <summary>
        /// Перегрузка оператора < для рациональных чисел
        /// </summary>
        /// <param name="fraction1">Рациональное число</param>
        /// <param name="fraction2">Рациональное число</param>
        /// <returns>Результат</returns>
        public static bool operator <(Fractions fraction1, Fractions fraction2)
        {            
            CheckIsNull(fraction1, fraction2);

            ToACommonDenominator(fraction1, fraction2);

            if (fraction1._numerator < fraction2._numerator)
            {
                FractionReduction(fraction1);

                FractionReduction(fraction2);

                return true;
            }
            FractionReduction(fraction1);

            FractionReduction(fraction2);

            return false;
        }


        /// <summary>
        /// Перегрузка оператора > для рациональных чисел
        /// </summary>
        /// <param name="fraction1">Рациональное число</param>
        /// <param name="fraction2">Рациональное число</param>
        /// <returns>Результат</returns>
        public static bool operator >(Fractions fraction1, Fractions fraction2)
        {
            CheckIsNull(fraction1, fraction2);

            ToACommonDenominator(fraction1, fraction2);

            if (fraction1._numerator > fraction2._numerator)
            {
                FractionReduction(fraction1);

                FractionReduction(fraction2);

                return true;
            }
            FractionReduction(fraction1);

            FractionReduction(fraction2);

            return false;
        }

        /// <summary>
        /// Перегрузка оператора <= для рациональных чисел
        /// </summary>
        /// <param name="fraction1">Рациональное число</param>
        /// <param name="fraction2">Рациональное число</param>
        /// <returns>Результат</returns>
        public static bool operator <=(Fractions fraction1, Fractions fraction2)
        {
            CheckIsNull(fraction1, fraction2);

            ToACommonDenominator(fraction1, fraction2);

            if (fraction1._numerator <= fraction2._numerator)
            {
                FractionReduction(fraction1);

                FractionReduction(fraction2);

                return true;
            }
            FractionReduction(fraction1);

            FractionReduction(fraction2);

            return false;
        }

        /// <summary>
        /// Перегрузка оператора >= для рациональных чисел
        /// </summary>
        /// <param name="fraction1">Рациональное число</param>
        /// <param name="fraction2">Рациональное число</param>
        /// <returns>Результат</returns>
        public static bool operator >=(Fractions fraction1, Fractions fraction2)
        {
            CheckIsNull(fraction1, fraction2);

            ToACommonDenominator(fraction1, fraction2);

            if (fraction1._numerator >= fraction2._numerator)
            {
                FractionReduction(fraction1);

                FractionReduction(fraction2);

                return true;
            }
            FractionReduction(fraction1);

            FractionReduction(fraction2);

            return false;
        }

        /// <summary>
        /// Перегрузка оператора + для рациональных чисел
        /// </summary>
        /// <param name="fraction1">Рациональное число</param>
        /// <param name="fraction2">Рациональное число</param>
        /// <returns>Результат</returns>
        public static Fractions operator +(Fractions fraction1, Fractions fraction2)
        {
            CheckIsNull(fraction1, fraction2);

            Fractions fraction = new Fractions();

            ToACommonDenominator(fraction1, fraction2);

            fraction._numerator = fraction1._numerator + fraction2._numerator;

            fraction._denominator = fraction1._denominator;

            FractionReduction(fraction);

            return fraction;
        }

        /// <summary>
        /// Перегрузка оператора - для рациональных чисел
        /// </summary>
        /// <param name="fraction1">Рациональное число</param>
        /// <param name="fraction2">Рациональное число</param>
        /// <returns>Результат</returns>
        public static Fractions operator -(Fractions fraction1, Fractions fraction2)
        {
            CheckIsNull(fraction1, fraction2);

            Fractions fraction = new Fractions();

            ToACommonDenominator(fraction1, fraction2);

            fraction._numerator = fraction1._numerator - fraction2._numerator;

            fraction._denominator = fraction1._denominator;

            FractionReduction(fraction);

            return fraction;
        }

        /// <summary>
        /// Перегрузка оператора ++ для рациональных чисел
        /// </summary>
        /// <param name="fraction">Рациональное число</param>        
        /// <returns>Результат</returns>
        public static Fractions operator ++(Fractions fraction)
        {
            CheckIsNull(fraction);

            fraction._numerator += fraction._denominator;

            return fraction;
        }

        /// <summary>
        /// Перегрузка оператора -- для рациональных чисел
        /// </summary>
        /// <param name="fraction">Рациональное число</param>        
        /// <returns>Результат</returns>
        public static Fractions operator --(Fractions fraction)
        {
            CheckIsNull(fraction);

            fraction._numerator -= fraction._denominator;

            return fraction;
        }

        /// <summary>
        /// Перегрузка оператора * для рациональных чисел
        /// </summary>
        /// <param name="fraction1">Рациональное число</param>
        /// <param name="fraction2">Рациональное число</param>
        /// <returns>Результат</returns>
        public static Fractions operator *(Fractions fraction1, Fractions fraction2)
        {
            CheckIsNull(fraction1, fraction2);

            Fractions fraction = new Fractions();

            fraction._numerator = fraction1._numerator * fraction2._numerator;

            fraction._denominator = fraction1._denominator * fraction2._denominator;

            FractionReduction(fraction);

            return fraction;
        }

        /// <summary>
        /// Перегрузка оператора / для рациональных чисел
        /// </summary>
        /// <param name="fraction1">Рациональное число</param>
        /// <param name="fraction2">Рациональное число</param>
        /// <returns>Результат</returns>
        public static Fractions operator /(Fractions fraction1, Fractions fraction2)
        {
            CheckIsNull(fraction1, fraction2);

            Fractions fraction = new Fractions();

            fraction._numerator = fraction1._numerator * fraction2._denominator;

            fraction._denominator = fraction1._denominator * fraction2._numerator;

            FractionReduction(fraction);

            return fraction;
        }

        /// <summary>
        /// Перегрузка оператора % для рациональных чисел
        /// </summary>
        /// <param name="fraction1">Рациональное число</param>
        /// <param name="fraction2">Рациональное число</param>
        /// <returns>Результат</returns>
        public static int operator %(Fractions fraction1, Fractions fraction2)
        {
            CheckIsNull(fraction1, fraction2);

            return fraction1._numerator % fraction2._numerator;
        }

        /// <summary>
        /// Перегрузка оператора неявного приведения для рационального числа
        /// </summary>
        /// <param name="fraction">Рациональное число</param>        
        /// <returns>Результат</returns>
        public static implicit operator float(Fractions fraction)
        {
            CheckIsNull(fraction);

            return fraction._numerator / fraction._denominator;
        }

        /// <summary>
        /// Перегрузка оператора явного приведения для рационального числа
        /// </summary>
        /// <param name="fraction">Рациональное число</param>        
        /// <returns>Результат</returns>
        public static explicit operator int(Fractions fraction)
        {
            CheckIsNull(fraction);

            return (int)(fraction._numerator / fraction._denominator);
        }

        /// <summary>
        /// Метод проверяет аргумент на null
        /// </summary>
        /// <param name="fraction">Рациональное число</param>
        /// <exception cref="NullReferenceException">Генерируется исключение</exception>
        private static void CheckIsNull(Fractions fraction)
        {
            if (fraction is null)
            {
                throw new NullReferenceException();
            }
        }

        /// <summary>
        /// Метод проверяет аргументы на null
        /// </summary>
        /// <param name="a">Рациональное число</param>
        /// <param name="b">Рациональное число</param>
        /// <exception cref="NullReferenceException">Генерируется исключение</exception>
        private static void CheckIsNull(Fractions fraction1, Fractions fraction2)
        {
            if (fraction1 is null || fraction2 is null)
            {
                throw new NullReferenceException();
            }
        }
    }
}
