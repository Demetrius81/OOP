using System;

namespace Constructions
{
    /// <summary>
    /// Тестовый класс
    /// </summary>
    public static class Demo
    {
        /* 
         
         V Создать тестовый пример,работающий с созданными классами.
         V Разбить созданные классы (здания, фабричный класс) и тестовый пример в разные исходные файлы. 
         V Разместить классы в одном пространстве имен.
         V Создать сборку (DLL), включающие эти классы. 
         V Подключить сборку к проекту и откомпилировать тестовый пример со сборкой. 
         V Получить исполняемый файл, 
         V проверить с помощью утилиты ILDASM, что тестовый пример ссылается на сборку и не содержит в себе классов здания и Creator.
         
         */


        /// <summary>
        /// Тестовый метод
        /// </summary>
        public static void Test()
        {
            Console.WriteLine("Добавляем 6 зданий с разной конфигурацией. Одно здание с ошибкой.");

            Creator.CreateBuild(3);

            Console.WriteLine("Ловим исключение:");

            try
            {
                Creator.CreateBuild(4, 15, 5, 8);
            }
            catch (ArgumentException ex)
            {
                PrintAlarm(ex);
            }
            Creator.CreateBuild(7, 2, 3, 12);

            Creator.CreateBuild(12, 3, 2, 12);

            Creator.CreateBuild(24.75M, 9, 2, 72);

            Creator.CreateBuild(26.3M, 10, 4, 160);

            PrintAllBuildings();

            Console.WriteLine("Удаляем несуществующее здание.");

            Console.WriteLine("Ловим исключение:");

            try
            {
                Creator.RemoveBuilding(856738);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                PrintAlarm(ex);
            }
            Console.WriteLine("Удаляем здание из хеш-таблицы по номеру здания.");

            Creator.RemoveBuilding(2);

            PrintAllBuildings();
        }

        /// <summary>
        /// Метод выводит на экран сообщение об исключении
        /// </summary>
        /// <param name="ex">исключение</param>
        public static void PrintAlarm(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(ex.Message);

            Console.WriteLine("Press any key to continue...");

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.ReadKey();
        }

        /// <summary>
        /// Метод выводит в консоль список зданий
        /// </summary>
        public static void PrintAllBuildings()
        {
            foreach (var key in Creator.Buildings.Keys)
            {
                Creator.Buildings.TryGetValue(key, out IBuilding building);

                Console.WriteLine($"{building.ToString()}," +
                    $" высота потолков {building.FloorHeightCalculate()}м." +
                    $" Количество квартир в подъезде {building.NumberOfApartmentInEntranceCalculate()}," +
                    $" количество квартир на этаже {building.NumberOfApartmentOnFloorCalculate()}.");
            }
            Console.ReadKey();
        }


    }
}
