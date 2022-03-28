using System;

namespace Constructions
{
    public class Building
    {
        /*Реализовать класс для описания здания (
         * уникальный номер здания, 
         * высота,
         * этажность, 
         * количество квартир, 
         * подъездов). 
         * Поля сделать закрытыми,
         * предусмотреть методы для заполнения полей и 
         * методы получения значений полей для печати.
         * Добавить методы вычисления высоты этажа, 
         * количества квартир в подъезде, 
         * количества квартир на этаже 
         * и т.д.                              ???
         * Предусмотреть возможность, чтобы уникальный номер здания генерировался программно.
         * Для этого в классе предусмотреть статическое поле, которое бы хранило последний
        использованный номер здания, и предусмотреть метод, который увеличивал бы
        значение этого поля.*/

        #region Fields and Properties

        private static int _id;

        private readonly int _idBuilding;

        private readonly int _height;

        private readonly int _numberOfFloors;

        private readonly int _numberOfApartments;

        private readonly int _numberOfEntrances;

        private int _numberOfApartmentInEntrance;

        private int _numberOfApartmentOnFloor;

        private decimal _floorHeight;

        /// <summary>
        /// Номер здания
        /// </summary>
        public int IdBuilding { get => _idBuilding; }

        /// <summary>
        /// Высота здания
        /// </summary>
        public int Height { get => _height; }

        /// <summary>
        /// Количество тажей
        /// </summary>
        public int NumberOfFloors { get => _numberOfFloors; }

        /// <summary>
        /// Количество квартир
        /// </summary>
        public int NumberOfApartments { get => _numberOfApartments; }

        /// <summary>
        /// Количество подъездов
        /// </summary>
        public int NumberOfEntrances { get => _numberOfEntrances; }

        /// <summary>
        /// Количество квартир в подъезде
        /// </summary>
        public int NumberOfApartmentInEntrance
        {
            get => _numberOfApartmentInEntrance;
            set => _numberOfApartmentInEntrance = NumberOfApartmentInEntranceCalculate();
        }

        /// <summary>
        /// Количество квартир на этаже
        /// </summary>
        public int NumberOfApartmentOnFloor
        {
            get => _numberOfApartmentOnFloor;
            set => _numberOfApartmentOnFloor = NumberOfApartmentOnFloorCalculate();
        }

        /// <summary>
        /// Высота одного этажа
        /// </summary>
        public decimal FloorHeight
        {
            get => _floorHeight;
            set => _floorHeight = FloorHeightCalculate();
        }

        #endregion

        public Building(int height, int numberOfFloors = 1, int numberOfApartments = 1, int numberOfEntrances = 1)
        {
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
        /// Метод вычисления количества квартир в подъезде
        /// </summary>
        /// <returns>Количество квартир в подъезде</returns>
        private int NumberOfApartmentInEntranceCalculate() => _numberOfApartments / _numberOfEntrances;

        /// <summary>
        /// Метод вычисления количества квартир на этаже
        /// </summary>
        /// <returns>Количество квартир на этаже</returns>
        private int NumberOfApartmentOnFloorCalculate() => _numberOfApartments / _numberOfFloors;

        /// <summary>
        /// Метод вычисления высоты одного этажа
        /// </summary>
        /// <returns>Высота одного этажа</returns>
        private decimal FloorHeightCalculate() => _height / _numberOfFloors;

    }
}
