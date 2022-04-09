using System;
using System.Collections.Generic;

namespace Constructions
{
    /// <summary>
    /// Фабрика классов
    /// </summary>
    public static class Creator
    {
        /* 
         
         V Для реализованного класса создать новый класс Creator, 
           который будет являться фабрикой объектов класса здания.
         V Для этого изменить модификатор доступа к конструкторам класса,
           в новый созданный класс добавить
         V перегруженные фабричные методы CreateBuild для создания объектов класса здания. 
         V В классе Creator все методы сделать статическими, 
       ??? конструктор класса сделать закрытым. ???  Статический класс не может иметь конструктор
         V Для хранения объектов класса здания в классе Creator использовать хеш-таблицу. 
         V Предусмотреть возможность удаления объекта здания по его уникальному номеру из хеш-таблицы.
         
         */

        private static Dictionary<int, IBuilding> _buildings = new Dictionary<int, IBuilding>();

        /// <summary>
        /// Хеш-таблица для хранения экземпляров класса Building
        /// </summary>
        public static Dictionary<int, IBuilding> Buildings { get => _buildings; private set => _buildings = value; }



        /// <summary>
        /// Метод создает здание и сохраняет его в хеш-таблицу
        /// </summary>
        /// <param name="height">Высота здания</param>
        /// <param name="numberOfFloors">Количество этажей, по умолчанию 1</param>
        /// <param name="numberOfEntrances">Количество подъездов, по умолчанию 1</param>
        /// <param name="numberOfApartments">Количество квартир должно быть кратно произведению количества этажей и количества подъездов, по умолчанию 1</param>
        public static void CreateBuild(decimal height, int numberOfFloors = 1, int numberOfEntrances = 1, int numberOfApartments = 1)
        {
            IBuilding building = AddBuild(height, numberOfFloors, numberOfEntrances, numberOfApartments);

            Buildings.Add(building.IdBuilding, building);
        }

        /// <summary>
        /// Метод создает здание
        /// </summary>
        /// <param name="height">Высота здания</param>
        /// <param name="numberOfFloors">Количество этажей</param>
        /// <param name="numberOfEntrances">Количество подъездов</param>
        /// <param name="numberOfApartments">Количество квартир</param>
        private static IBuilding AddBuild(decimal height, int numberOfFloors, int numberOfEntrances, int numberOfApartments)
        {
            return new Building(height, numberOfFloors, numberOfEntrances, numberOfApartments);
        }

        /// <summary>
        /// Метод удаляет экземпляр объекта Building из хеш-таблицы по ключу
        /// </summary>
        /// <param name="key">ключ номер дома</param>
        /// <exception cref="ArgumentOutOfRangeException">исключение при отсутствии номера дома в хеш-таблице</exception>
        public static void RemoveBuilding(int key)
        {
            if (Buildings.ContainsKey(key))
            {
                Buildings.Remove(key);
            }
            else
            {
                throw new ArgumentOutOfRangeException($"Дома номер {key} не существует");
            }
        }

    }
}
