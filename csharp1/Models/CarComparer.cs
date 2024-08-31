using csharp1.Enums;

namespace csharp1.Models
{
    class CarComparer : IComparer<Car>
    {
        public CompareField SortBy;
        public int Compare(Car? x, Car? y)
        {
            switch (SortBy)
            {
                case CompareField.Id:
                    return x.Id.CompareTo(y.Id);
                case CompareField.Name:
                    return x.Name.CompareTo(y.Name);
                case CompareField.MaxMph:
                    return x.MaxMph.CompareTo(y.MaxMph);
                case CompareField.Horsepower:
                    return x.Horsepower.CompareTo(y.Horsepower);
                case CompareField.Price:
                    return x.Price.CompareTo(y.Price);
                default:
                    throw new ArgumentException();
            }
        }
    }
}
