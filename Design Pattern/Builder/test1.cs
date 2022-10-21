using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderSimple02
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CarBuilder builder;

            builder = new AvantteBuilder();

            Shop shop = new Shop();
            shop.Construct(builder);
            builder.Car.Show();
            /*
            builder = n0ew GrandeurBuilder();
            shop.Construct(builder);
            builder.Car.Show();

            builder = new SonataBuilder();
            shop.Construct(builder);
            builder.Car.Show();
            */

            Console.ReadKey();
        }
    }
    class Shop
    {
        public void Construct(CarBuilder carBuilder)
        {
            carBuilder.BuildEngine();
            carBuilder.BuildMissionCooler();
            carBuilder.BuildTire();
            carBuilder.BuildTubor();

        }
    }
    abstract class CarBuilder
    {
        protected Car car;
        public Car Car
        {
            get { return car; }
        }

        public abstract void BuildEngine();
        public abstract void BuildMissionCooler();
        public abstract void BuildTire();
        public abstract void BuildTubor();
    }
    class AvantteBuilder : CarBuilder
    {
        public AvantteBuilder()
        {
            car = new Car("Avantte");
        }
        public override void BuildEngine()
        {
            car["engine"] = "AType";
        }
        public override void BuildMissionCooler()
        {
            car["missionCooler"] = "유";
        }
        public override void BuildTire()
        {
            car["tire"] = "한국";
        }
        public override void BuildTubor()
        {
            car["tubor"] = "유";
        }
    }
    /*
    class GrandeurBuilder : CarBuilder
    {

    }
    class SonataBuilder : CarBuilder
    {

    }
    */
    class Car
    {        
        private string _carType;
        private Dictionary<string, string> _parts = new Dictionary<string, string>();
        
        public Car(string carType)
        {
            this._carType = carType;
        }
        
        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("Car Type: {0}", _carType);
            Console.WriteLine(" Engine : {0}", _parts["engine"]);
            Console.WriteLine(" MissionCooler : {0}", _parts["missionCooler"]);
            Console.WriteLine(" Tire : {0}", _parts["tire"]);
            Console.WriteLine(" Tubor : {0}", _parts["tubor"]);
        }
    }
}

