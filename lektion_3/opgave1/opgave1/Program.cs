using System;

namespace opgave1
{

    class CarComparer : IComparer<Car>
    {
        public int Compare(Car? x, Car? y)
        {
            if (x.Make.CompareTo(y.Make) == 0)
            {
                if (x.Model.CompareTo(y.Model) == 0)
                {
                    if (x.Price > y.Price)
                    {
                        return 1;
                    }
                    else if (x.Price < y.Price)
                    {
                        return -1;
                    }
                    else return 0;
                }
                else if (x.Model.CompareTo(y.Model) > 0)
                {
                    return 1;
                }
                else return -1;
            }
            if (x.Make.CompareTo(y.Make) > 0)
            {
                return 1;
            }
            else return -1;
        }

    }
    class Car : IComparable<Car>
    {
        public string Make { get; private set; }
        public string Model { get; private set; }
        public decimal Price { get; private set; }
        public Car(string make, string model, decimal price)
        {
            Make = make;
            Model = model;
            Price = price;
        }

        
        public int CompareTo(Car? other)
        {
            if (Price > other.Price)
            {
                return -1;
            }
            if (Price < other.Price)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
    }
    class program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>()
            {
                new Car("Skoda", "Fabia", 50000m),
                new Car("Skoda", "Octavia", 60000m),
                new Car("Fiat", "500", 12345m),
                new Car("Ford", "Mustang", 9000000m),
                new Car("Ford", "Mustang", 9000001m)
             };
                        
            cars.Sort(new CarComparer());
            Console.WriteLine("Sorted by price");
            foreach (Car car in cars)
            {
                Console.WriteLine($" {car.Make} {car.Model} {car.Price}");
            }
            Console.Read();
        }
    }

}