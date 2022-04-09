using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7.Task1
{
    /*
     V  Определить интерфейс IСoder, который полагает методы поддержки шифрования строк. 
     V  В интерфейсе объявляются два метода Encode() и 
     V  Decode(), используемые для шифрования и дешифрования строк. 
     */

    /// <summary>
    /// Интерфейс содержит методы поддержки шифрования строк
    /// </summary>
    internal interface ICoder
    {
        /// <summary>
        /// Метод используется для шифрования строки
        /// </summary>
        /// <param name="text">string текст для зашифровки</param>
        /// <returns>string зашифрованный текст</returns>
        string Encode(string text);

        /// <summary>
        /// Метод используется для дешифрования строки
        /// </summary>
        /// <param name="text">string зашифрованный текст</param>
        /// <returns>string расшифрованный текст</returns>
        string Decode(string text);
    }
}
