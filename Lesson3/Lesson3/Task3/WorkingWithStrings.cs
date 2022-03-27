using System;
using System.IO;
using System.Text;

namespace Lesson3.Task3
{
    internal class WorkingWithStrings
    {
        //Работа со строками.
        //Дан текстовый файл, содержащий ФИО и e-mail адрес.
        //Разделителем между ФИО и адресом электронной почты является символ &:
        //Кучма Андрей Витальевич & Kuchma@mail.ru
        //Мизинцев Павел Николаевич & Pasha@mail.ru
        //Сформировать новый файл, содержащий список адресов электронной почты.
        //Предусмотреть метод, выделяющий из строки адрес почты.
        //Методу в качестве параметра передается символьная строка s,
        //e-mail возвращается в той же строке s: public void SearchMail (ref string s).

        private readonly string _pathNameMail;

        private readonly string _pathMail;

        internal string PathNameMail { get => _pathNameMail; }

        internal string PathMail { get => _pathMail; }

        public WorkingWithStrings(string pathNameMail = "namemail.txt")
        {
            _pathNameMail = pathNameMail;

            _pathMail = $"mail.txt";
        }

        /// <summary>
        /// Метод читает из файла текст
        /// </summary>
        /// <returns>текст</returns>
        private string ReadingFromFile()
        {
            try
            {
                using (StreamReader reader = new StreamReader(PathNameMail, Encoding.UTF8))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        /// <summary>
        /// Метод записывает текст в файл
        /// </summary>
        /// <param name="text">текст</param>
        private void WritingFile(string text)
        {
            using (StreamWriter writer = new StreamWriter(PathMail, false, Encoding.UTF8))
            {
                writer.Write(text);
            }
        }

        /// <summary>
        /// Метод отделяет почту от имени в тексте и записывает текст в файл
        /// </summary>
        public void SeparateString()
        {
            string text = ReadingFromFile();

            SearchMail(ref text);

            WritingFile(text);
        }

        /// <summary>
        /// Метод формирует из исходной строки с именами и почтой строку с почтой
        /// </summary>
        /// <param name="text">текст</param>
        private void SearchMail(ref string text)
        {
            string[] textArray = text.Replace(" ", "").Replace("\r", "").Split(new char[] { '\n', '&' });

            text = "";

            foreach (string line in textArray)
            {
                if (line.Contains('@'))
                {
                    text = (text == "") ? (new string($"{line}\r\n")) : ($"{text}" + $"{line}\r\n");
                }
            }
        }

    }
}
