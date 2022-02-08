using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class HouseDetails
    {
        public class Home
        {
            public int Area { get; set; }
            public Door door;

            public Home(int area = 250)
            {
                this.Area = area;
            }

            public void ShowData()
            {
                Console.WriteLine($"The area of my house is {Area} m2");
            }

            public Door GetDoor()
            {
                return door;
            }

            public class Door
            {
                public string Color { get; set; }

                public Door(string color = "Red")
                {
                    this.Color = color;
                }

                public void ShowData()
                {
                    Console.WriteLine($"Color of my door is {Color}");
                }
            }
        }

        public class SmallApartment : Home
        {
            public SmallApartment(int area = 150) : base(area)
            {
            }
        }

        public class Person
        {
            private string name;
            public Home home { get; set; }

            public Person(string name)
            {
                this.name = name;
            }

            public void ShowData()
            {
                Console.WriteLine($"A person name is {name}");
                Console.WriteLine("Data of house:");
                home.ShowData();
                Console.WriteLine("Data of door:");
                home.GetDoor().ShowData();
            }

        }

        static void Main(string[] args)
        {
            SmallApartment apartment = new SmallApartment();
            Person person = new Person("Suma");
            apartment.door = new Home.Door("Blue");
            person.home = apartment;
            person.ShowData();
            Console.ReadLine();
        }
    }
}
