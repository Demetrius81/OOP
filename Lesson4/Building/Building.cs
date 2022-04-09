using System;

namespace Constructions
{
    /// <summary>
    /// Класс здание
    /// </summary>
    internal class Building : IBuilding
    {
        /*
         
         V Реализовать класс для описания здания (
         V уникальный номер здания, 
         V высота,
         V этажность, 
         V количество квартир, 
         V подъездов). 
         V Поля сделать закрытыми,
         V предусмотреть методы для заполнения полей и 
         V методы получения значений полей для печати.
         V Добавить методы вычисления высоты этажа, 
         V количества квартир в подъезде, 
         V количества квартир на этаже 
       ??? и т.д. ??? Это значит придумай себе работу сам :)
         V Предусмотреть возможность, чтобы уникальный номер здания генерировался программно.
         V Для этого в классе предусмотреть статическое поле, которое бы хранило последний
        использованный номер здания, и предусмотреть метод, который увеличивал бы
        значение этого поля.
        
         */

        #region Fields and Properties

        private static int _id;

        private readonly decimal _height;

        private readonly int _idBuilding;

        private readonly int _numberOfApartments;

        private readonly int _numberOfEntrances;

        private readonly int _numberOfFloors;

        public decimal Height { get => _height; }

        public int IdBuilding { get => _idBuilding; }

        public int NumberOfApartments { get => _numberOfApartments; }

        public int NumberOfEntrances { get => _numberOfEntrances; }

        public int NumberOfFloors { get => _numberOfFloors; }

        #endregion

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="height">Высота здания</param>
        /// <param name="numberOfFloors">Количество этажей</param>
        /// <param name="numberOfEntrances">Количество подъездов</param>
        /// <param name="numberOfApartments">Количество квартир должно быть кратно произведению количества этажей и количества подъездов</param>
        /// <exception cref="ArgumentException">исключение при неверном вводе количества квартир</exception>
        internal protected Building(decimal height, int numberOfFloors, int numberOfEntrances, int numberOfApartments)
        {
            if (numberOfApartments % (numberOfEntrances * numberOfFloors) != 0)
            {
                throw new ArgumentException($"Количество квартир должно быть кратно" +
                    $" произведению количества этажей и количества подъездов");
            }
            IncrementID();
            _idBuilding = _id;
            _height = height;
            _numberOfFloors = numberOfFloors;
            _numberOfApartments = numberOfApartments;
            _numberOfEntrances = numberOfEntrances;
        }

        /// <summary>
        /// Метод увеличивает номер дома
        /// </summary>
        private void IncrementID() => _id++;

        /// <summary>
        /// Метод вычисления высоты одного этажа
        /// </summary>
        /// <returns>Высота одного этажа</returns>
        public decimal FloorHeightCalculate() => _height / _numberOfFloors;

        /// <summary>
        /// Метод вычисления количества квартир в подъезде
        /// </summary>
        /// <returns>Количество квартир в подъезде</returns>
        public int NumberOfApartmentInEntranceCalculate() => _numberOfApartments / _numberOfEntrances;

        /// <summary>
        /// Метод вычисления количества квартир на этаже
        /// </summary>
        /// <returns>Количество квартир на этаже</returns>
        public int NumberOfApartmentOnFloorCalculate() => _numberOfApartments / _numberOfFloors;

        /// <summary>
        /// Перегруженный метод ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $" Здание номер {_idBuilding}";

    }
}
