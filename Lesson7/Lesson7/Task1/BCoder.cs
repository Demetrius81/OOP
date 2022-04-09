using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7.Task1
{
    /*
     * Создать класс BCoder, реализующий интерфейс ICoder. 
     * Класс шифрует строку, выполняя замену каждой буквы, 
       стоящей в алфавите на i-й позиции, на букву того же регистра, 
       расположенную в алфавите на i-й позиции с конца алфавита. 
       (Например, буква В заменяется на букву Э.
     */
    internal class BCoder : ICoder
    {

        public string Encode(string text)
        {
            var charArr = text.ToCharArray();

            var encryptedCharArr = new char[charArr.Length];

            for (int i = 0; i < charArr.Length; i++)
            {
                encryptedCharArr[i] =
                    charArr[i] == 90 ? (char)65 :
                    charArr[i] == 122 ? (char)97 :
                    charArr[i] == 1071 ? (char)1040 :
                    charArr[i] == 1103 ? (char)1072 : encryptedCharArr[i] = (char)(charArr[i] + 1);
            }
            return new string(encryptedCharArr);
        }


        public string Decode(string text)
        {
            var charArr = text.ToCharArray();

            var decryptedCharArr = new char[charArr.Length];

            for (int i = 0; i < charArr.Length; i++)
            {
                decryptedCharArr[i] =
                    charArr[i] == 65 ? (char)90 :
                    charArr[i] == 97 ? (char)122 :
                    charArr[i] == 1040 ? (char)1071 :
                    charArr[i] == 1072 ? (char)1103 : decryptedCharArr[i] = (char)(charArr[i] - 1);
            }
            return new string(decryptedCharArr);
        }



    }
}
