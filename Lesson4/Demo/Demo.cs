using System;

namespace Constructions
{
    public static class Demo
    {
        /* 
         
         V Создать тестовый пример,работающий с созданными классами.
         * Разбить созданные классы (здания, фабричный класс) и тестовый пример в разные исходные файлы. 
         * Разместить классы в одном пространстве имен.
         * Создать сборку (DLL), включающие эти классы. 
         * Подключить сборку к проекту и откомпилировать тестовый пример со сборкой. 
         * Получить исполняемый файл, 
         * проверить с помощью утилиты ILDASM, что тестовый пример ссылается на сборку и не содержит в себе классов здания и Creator.
         
         */



        public static void Test()
        {

            Creator.CreateBuild(3);
            Creator.CreateBuild(7, 2, 3, 12);
            Creator.CreateBuild(12, 3, 2, 12);
            Creator.CreateBuild(24.75M, 9, 2, 72);
            Creator.CreateBuild(26.3M, 10, 4, 160);

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
