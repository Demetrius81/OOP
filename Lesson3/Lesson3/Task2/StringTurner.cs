using Microsoft.VisualBasic;

namespace Lesson3.Task2
{
    internal static class StringTurner
    {
        //Реализовать метод, который в качестве входного параметра принимает строку string,
        //возвращает строку типа string, буквы в которой идут в обратном порядке.
        //Протестировать метод.

        /// <summary>
        /// Метод переворота строки (длинный)
        /// </summary>
        /// <param name="message">строка</param>
        /// <returns>перевернутая строка</returns>
        public static string StringReverseWithCycle(string message)
        {
            string result;

            char[] charMessage = new char[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                charMessage[i] = message[(message.Length - 1) - i];
            }

            result = new string(charMessage);

            return result;
        }

        /// <summary>
        /// Метод переворота строки (короткий)
        /// </summary>
        /// <param name="message">строка</param>
        /// <returns>перевернутая строка</returns>
        public static string StringReverse(string message) => Strings.StrReverse(message);
    }
}
