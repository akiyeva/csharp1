namespace csharp1.Models
{
    public class Car : IComparable<Car>, IEquatable<Car>, ICloneable
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int MaxMph { get; set; }
        public int Horsepower { get; set; }
        public decimal Price { get; set; }
        public Car(int id, string name, int maxMph, int horsePower, decimal price)
        {
            Id = id;
            Name = name;
            MaxMph = maxMph;
            Horsepower = horsePower;
            Price = price;
        }

        public Car()
        {
        }

        public object Clone()
        {
            var car = new Car();

            car.Id = this.Id;
            car.Name = this.Name;
            car.MaxMph = this.MaxMph;
            car.Horsepower = this.Horsepower;
            car.Price = this.Price;

            return car;
        }

        public int CompareTo(Car? other)
        {
            if (other is null)
            {
                throw new ArgumentException("Is null");
            }
            return Name.CompareTo(other.Name);
        }

        public bool Equals(Car? other)
        {
            return other != null && this.Name == other.Name
                                 && this.MaxMph == other.MaxMph
                                 && this.Price == other.Price
                                 && this.Horsepower == other.Horsepower;
        }
    }


}
