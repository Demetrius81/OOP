using System;
using System.Collections.Generic;
using System.Text;
using Lesson7.Task1;

namespace Lesson7.Task1
{
    /*
     V Создать класс ACoder, реализующий интерфейс ICoder. 
     V Класс шифрует строку посредством сдвига каждого символа на одну «алфавитную» позицию выше. 
       (В результате такого сдвига буква А становится буквой Б).
     */

    /// <summary>
    /// Метод шифрования строки посредством сдвига символа
    /// </summary>
    internal class ACoder : ICoder
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
                encryptedCharArr[i] = ReplaceCharToEncrypt(charArr[i]);
            }
            return new string(encryptedCharArr);
        }


        public string Decode(string text)
        {
            var charArr = text.ToCharArray();

            var decryptedCharArr = new char[charArr.Length];

            for (int i = 0; i < charArr.Length; i++)
            {
                decryptedCharArr[i] = ReplaceCharToDecrypt(charArr[i]);
            }
            return new string(decryptedCharArr);
        }

        /// <summary>
        /// Метод заменяет символ другим символом по определенному алгоритму
        /// </summary>
        /// <param name="sym">char исходный символ</param>
        /// <returns>char измененный символ</returns>
        private char ReplaceCharToEncrypt(char sym)
        {
            char encryptedSym;

            if (sym < EN_UPPERCASE_FIRST_UTF16 || sym > EN_UPPERCASE_LAST_UTF16 &&
                sym < EN_LOWERRCASE_FIRST_UTF16 || sym > EN_LOWERRCASE_LAST_UTF16 &&
                sym < RU_UPPERCASE_FIRST_UTF16 || sym > RU_UPPERCASE_LAST_UTF16 &&
                sym < RU_LOWERRCASE_FIRST_UTF16 || sym > RU_LOWERRCASE_LAST_UTF16)
            {
                encryptedSym = sym;
            }
            else
            {
                encryptedSym = sym == EN_UPPERCASE_LAST_UTF16 ? (char)EN_UPPERCASE_FIRST_UTF16 :
                    sym == EN_LOWERRCASE_LAST_UTF16 ? (char)EN_LOWERRCASE_FIRST_UTF16 :
                    sym == RU_UPPERCASE_LAST_UTF16 ? (char)RU_UPPERCASE_FIRST_UTF16 :
                    sym == RU_LOWERRCASE_LAST_UTF16 ? (char)RU_LOWERRCASE_FIRST_UTF16 : (char)(sym + 1);
            }
            return encryptedSym;
        }

        /// <summary>
        /// Метод заменяет символ другим символом по определенному алгоритму
        /// </summary>
        /// <param name="sym">char исходный символ</param>
        /// <returns>char измененный символ</returns>
        private char ReplaceCharToDecrypt(char sym)
        {
            char decryptedSym;

            if (sym < EN_UPPERCASE_FIRST_UTF16 || sym > EN_UPPERCASE_LAST_UTF16 &&
                sym < EN_LOWERRCASE_FIRST_UTF16 || sym > EN_LOWERRCASE_LAST_UTF16 &&
                sym < RU_UPPERCASE_FIRST_UTF16 || sym > RU_UPPERCASE_LAST_UTF16 &&
                sym < RU_LOWERRCASE_FIRST_UTF16 || sym > RU_LOWERRCASE_LAST_UTF16)
            {
                decryptedSym = sym;
            }
            else
            {
                decryptedSym = sym == EN_UPPERCASE_FIRST_UTF16 ? (char)EN_UPPERCASE_LAST_UTF16 :
                    sym == EN_LOWERRCASE_FIRST_UTF16 ? (char)EN_LOWERRCASE_LAST_UTF16 :
                    sym == RU_UPPERCASE_FIRST_UTF16 ? (char)RU_UPPERCASE_LAST_UTF16 :
                    sym == RU_LOWERRCASE_FIRST_UTF16 ? (char)RU_LOWERRCASE_LAST_UTF16 : (char)(sym - 1);
            }
            return decryptedSym;
        }
    }
}
