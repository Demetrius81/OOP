namespace Constructions
{
    /// <summary>
    /// Интерфейс класса здание
    /// </summary>
    public interface IBuilding
    {
        /// <summary>
        /// Высота здания
        /// </summary>
        decimal Height { get; }

        /// <summary>
        /// Номер здания
        /// </summary>
        int IdBuilding { get; }

        /// <summary>
        /// Количество квартир
        /// </summary>
        int NumberOfApartments { get; }

        /// <summary>
        /// Количество подъездов
        /// </summary>
        int NumberOfEntrances { get; }

        /// <summary>
        /// Количество тажей
        /// </summary>
        int NumberOfFloors { get; }

        decimal FloorHeightCalculate();
        int NumberOfApartmentInEntranceCalculate();
        int NumberOfApartmentOnFloorCalculate();
    }
}