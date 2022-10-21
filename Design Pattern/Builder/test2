using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder03
{
    /*
    Director : 건설 사무실(shop)으로 처리해 주세요.
    Builder 종류 : 집(HouseBuilder) --> abstract 또는 interface
    상속 또는 구현 ConcreteHouseBuilder(이름은 자유롭게) 클래스가 있어야 합니다.
    부품종류 : 차고지 유, 무(GargeParts)
               수영장 유, 무(SwimmingPoolParts)
               조형물 유, 무(FancyStatuesParts)
               정원 유, 무(GardenParts)
    제품(Product) : 집
     */
    internal class Program
    {
        public static void Main(string[] args)
        {
            HouseBuilder builder;
            Shop shop = new Shop();

            builder = new House_Type1();
            shop.Construct_House(builder);
            builder.House.Show();
        }
        class Shop
        {
            public void Construct_House(HouseBuilder houseBuilder)
            {
                houseBuilder.Build_Garge();
                houseBuilder.Build_SwimmingPool();
                houseBuilder.Build_FancyStatues();
                houseBuilder.Build_Garden();
            }
        }
        abstract class HouseBuilder
        {
            protected House house;
            public House House
            {
                get { return house; }
            }

            public abstract void Build_Garge();
            public abstract void Build_SwimmingPool();
            public abstract void Build_FancyStatues();
            public abstract void Build_Garden();
        }
        class House_Type1 : HouseBuilder
        {
            public House_Type1()
            {
                house = new House("House_Type1");
            }
            public override void Build_Garge()
            {
                house["garge"] = "유";
            }
            public override void Build_SwimmingPool()
            {
                house["swimmingPool"] = "유";
            }
            public override void Build_FancyStatues()            
            {
                house["fancyStatues"] = "유";
            }
            public override void Build_Garden()
            {
                house["garden"] = "유";
            }
        }
        class House
        {
            private string house_Type;
            private Dictionary<string, string> houses_parts = new Dictionary<string, string>();

            public House(string houseType)
            {
                this.house_Type = houseType;
            }
            public string this[string key]
            {
                get { return houses_parts[key]; }
                set { houses_parts[key] = value; }
            }
            public void Show()
            {
                Console.WriteLine("House Type1: {0}", house_Type);
                Console.WriteLine("Garge: {0}", houses_parts["garge"]);
                Console.WriteLine("SwimmingPool: {0}", houses_parts["swimmingPool"]);
                Console.WriteLine("FancyStatues: {0}", houses_parts["fancyStatues"]);
                Console.WriteLine("Garden: {0}", houses_parts["garden"]);
            }
        }
    }
}
