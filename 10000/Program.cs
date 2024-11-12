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

    public class Contract
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

        public int GetDays()
        { return days; }

        public int GetKilo()
            { return kilo; }

    }

    public class Vehicle
    {
        private string id;
        private Contract contract;

        public Vehicle (string name, int days, int kilo, string id) //ב1
        {
            this.id = id;
            this.contract = new Contract(name, days, kilo);
        }

        public virtual double Payment () //סעיף ג1
        //note - need virtual so we can override this in derived functions
        {
            return 60*contract.GetDays()+2*contract.GetKilo();
        }
        
    }

    public class Car : Vehicle
    {
        private int seats;

        //ב2
        public Car(string name, int days, int kilo, string id, int seats): base(name, days, kilo, id)
        {
            this.seats = seats;
        }
    }

    public class Truck : Vehicle 
    {
        private int max;

        public Truck(string name, int days, int kilo, string id) : base(name, days, kilo, id) //not required!
        {
        }

        public override double Payment()
        //use the base method, then add 500. rather than reimplement the base
        //note - without writing base, this function would recursively call itself
        {
            return base.Payment()+500;
        }

    }

    public class Motorcycle : Vehicle 
    {
        private bool offRoad;

        public Motorcycle(string name, int days, int kilo, string id) : base(name, days, kilo, id) //not required!
        {
        }

        public override double Payment()
        {
            return base.Payment() /2;
        }
    }
}
