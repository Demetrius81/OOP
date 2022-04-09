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

    internal class ACoder : ICoder
    {


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

        private char ReplaceCharToEncrypt(char sym) =>
                    sym == 90 ? (char)65 :
                    sym == 122 ? (char)97 :
                    sym == 1071 ? (char)1040 :
                    sym == 1103 ? (char)1072 : (char)(sym + 1);



        private char ReplaceCharToDecrypt(char sym) =>
                    sym == 65 ? (char)90 :
                    sym == 97 ? (char)122 :
                    sym == 1040 ? (char)1071 :
                    sym == 1072 ? (char)1103 : (char)(sym - 1);

    }

}
