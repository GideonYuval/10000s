using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10000
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Contract
    {
        private string name;
        private int days;
        private int kilo;

        public Contract(string name, int days, int kilo)
        {
            this.name = name;
            this.days = days;
            this.kilo = kilo;
        }
    }

    class Vehicle
    {
        private string id;
        private Contract contract;

        public Vehicle (string name, int days, int kilo, string id)
        {
            this.id = id;
            this.contract = new Contract(name, days, kilo);
        }
        
    }

    class Car : Vehicle
    {
        private int seats;

        public Car(string name, int days, int kilo, string id, int seats): base(name, days, kilo, id)
        {
            this.seats = seats;
        }
    }

    class Truck: Vehicle //error because no constructor (not required by Q)
    {
        private int max;

    }

    class Motorcycle: Vehicle //error because no constructor (not required by Q)
    {
        private bool offRoad;
    }
}
