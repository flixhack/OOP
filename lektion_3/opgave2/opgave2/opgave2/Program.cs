using System;
using System.Net;
using System.Reflection.Metadata.Ecma335;

namespace opgave2
{
    public interface ITaxable
    {
        decimal TaxValue { get;}
    }
    public class FixedProperty
    {
        protected string location;
        protected bool inCity;
        protected decimal estimatedValue;

        public FixedProperty(string location, bool inCity, decimal value)
        {
            this.location = location;
            this.inCity = inCity;
            this.estimatedValue = value;
        }

        public FixedProperty(string location) :
          this(location, true, 1000000)
        {
        }

        public string Location
        {
            get
            {
                return location;
            }
        }
    }

    public class Vehicle
    {
        protected int registrationNumber;
        protected double maxVelocity;
        protected decimal value;

        public Vehicle(int registrationNumber, double maxVelocity, decimal value)
        {
            this.registrationNumber = registrationNumber;
            this.maxVelocity = maxVelocity;
            this.value = value;
        }

        public int RegistrationNumber
        {
            get
            {
                return registrationNumber;
            }
        }

    }

    public class Bus : Vehicle, ITaxable
    {
        protected int numberOfSeats;
        public Bus(int numberOfSeats, int regNumber, decimal value) :
            base(regNumber, 80, value)
        {
            this.numberOfSeats = numberOfSeats;
        }
        public int NumberOfSeats
        {
            get
            {
                return numberOfSeats;
            }
        }

        decimal ITaxable.TaxValue => 6969;
    }

    public class House : FixedProperty, ITaxable
    {
        protected double area;
        public decimal TaxValue { get; }

        public House(string location, bool inCity, double area, decimal value) :
            base(location, inCity, value)
        {
            this.area = area;
            this.TaxValue = value/(decimal)area;
        }

        public double Area
        {
            get
            {
                return area;
            }
        }

    }
    class program
    {
        static void Main(string[] args)
        {
            FixedProperty property = new FixedProperty("Himmerlandsgad", true, 1000);
            Vehicle vehicle = new Bus(1234, 100, 2000);

            ITaxable bus = new Bus(59, 1111, 20000);
            ITaxable house = new House("aalborg", true, 90, 500000);

            Console.WriteLine("Taxvalue for bus: " + bus.TaxValue + ", and house: " + house.TaxValue);
            Console.Read();
        }
    }
}