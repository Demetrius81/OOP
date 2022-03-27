using System;
using System.IO;
using System.Text;

namespace Lesson3.Task3
{
    internal class Demo
    {

        public static void TaskDemo()
        {
            WorkingWithStrings workingWithStrings = new WorkingWithStrings();

            workingWithStrings.SeparateString();

            string textFromFullFile;

            string textFromMail;

            using (StreamReader reader = new StreamReader(workingWithStrings.PathNameMail, Encoding.UTF8))
            {
                textFromFullFile = reader.ReadToEnd();
            }
            using (StreamReader reader = new StreamReader(workingWithStrings.PathMail, Encoding.UTF8))
            {
                textFromMail = reader.ReadToEnd();
            }
            Console.WriteLine($"Текст из файла {workingWithStrings.PathNameMail}:");

            Console.WriteLine();

            Console.WriteLine(textFromFullFile);

            Console.WriteLine();

            Console.WriteLine($"Текст из файла {workingWithStrings.PathMail}:");

            Console.WriteLine();

            Console.WriteLine(textFromMail);

            Console.WriteLine($"To continue press any key...");

            Console.ReadKey();

        }
    }
}
