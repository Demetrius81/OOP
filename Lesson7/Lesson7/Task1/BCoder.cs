using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7.Task1
{
    /*
     V Создать класс BCoder, реализующий интерфейс ICoder. 
     V Класс шифрует строку, выполняя замену каждой буквы, 
       стоящей в алфавите на i-й позиции, на букву того же регистра, 
       расположенную в алфавите на i-й позиции с конца алфавита. 
       (Например, буква В заменяется на букву Э.
     */
    internal class BCoder : ICoder
    {

        public const int EN_UPPERCASE_FIRST_UTF16 = 'A';
        public const int EN_UPPERCASE_LAST_UTF16 = 'Z';
        public const int EN_LOWERRCASE_FIRST_UTF16 = 'a';
        public const int EN_LOWERRCASE_LAST_UTF16 = 'z';
        public const int RU_UPPERCASE_FIRST_UTF16 = 'А';
        public const int RU_UPPERCASE_LAST_UTF16 = 'Я';
        public const int RU_LOWERRCASE_FIRST_UTF16 = 'а';
        public const int RU_LOWERRCASE_LAST_UTF16 = 'я';

        public string Encode(string text)
        {
            var charArr = text.ToCharArray();

            var encryptedCharArr = new char[charArr.Length];

            for (int i = 0; i < charArr.Length; i++)
            {
                encryptedCharArr[i] = ReplaceCharToEncryptAndDecrypt(charArr[i]);
            }
            return new string(encryptedCharArr);
        }


        public string Decode(string text)
        {
            var charArr = text.ToCharArray();

            var decryptedCharArr = new char[charArr.Length];

            for (int i = 0; i < charArr.Length; i++)
            {
                decryptedCharArr[i] = ReplaceCharToEncryptAndDecrypt(charArr[i]);
            }
            return new string(decryptedCharArr);
        }

        /// <summary>
        /// Метод заменяет символ другим символом по определенному алгоритму
        /// </summary>
        /// <param name="sym">char исходный символ</param>
        /// <returns>char измененный символ</returns>
        private char ReplaceCharToEncryptAndDecrypt(char sym)
        {
            char encryptedSym;

            if (sym >= EN_UPPERCASE_FIRST_UTF16 && sym <= EN_UPPERCASE_LAST_UTF16)
            {
                encryptedSym = ReplaceChar(sym, EN_UPPERCASE_FIRST_UTF16, EN_UPPERCASE_LAST_UTF16);
            }
            else if (sym >= EN_LOWERRCASE_FIRST_UTF16 && sym <= EN_LOWERRCASE_LAST_UTF16)
            {
                encryptedSym = ReplaceChar(sym, EN_LOWERRCASE_FIRST_UTF16, EN_LOWERRCASE_LAST_UTF16);
            }
            else if (sym >= RU_UPPERCASE_FIRST_UTF16 && sym <= RU_UPPERCASE_LAST_UTF16)
            {
                encryptedSym = ReplaceChar(sym, RU_UPPERCASE_FIRST_UTF16, RU_UPPERCASE_LAST_UTF16);
            }
            else if (sym >= RU_LOWERRCASE_FIRST_UTF16 && sym <= RU_LOWERRCASE_LAST_UTF16)
            {
                encryptedSym = ReplaceChar(sym, RU_LOWERRCASE_FIRST_UTF16, RU_LOWERRCASE_LAST_UTF16);
            }
            else
            {
                encryptedSym = sym;
            }
            return encryptedSym;
        }

        /// <summary>
        /// Метод заменяет выполняет замену каждой буквы стоящей на i-й позиции на букву того же регистра расположенную в алфавите на i-й позиции с конца алфавита.
        /// </summary>
        /// <param name="sym">char символ до замены</param>
        /// <param name="firstSym">int код первого символа алфавита</param>
        /// <param name="lastSym">int код последнего символа алфавита</param>
        /// <returns>char измененный символ</returns>
        private char ReplaceChar(char sym, int firstSym, int lastSym) => (char)(lastSym - (sym - firstSym));
    }
}
