using System;

namespace Exercise2
{
    class TestHouse
    {
        static void Main()
        {
            bool debug = true;

            SmallApartment mySmallApartament = new SmallApartment();
            Person myPerson = new Person();

            myPerson.Name = "Kishore";
            myPerson.House = mySmallApartament;
            myPerson.ShowData();

            if (debug)
                Console.ReadLine();
        }
    }

    class House
    { 
        protected int area;
        protected door door;

        public int Area
        {
            get { return area; }
            set { area = value; }
        }
        public door Door
        {
            get { return door; }
            set { door = value; }
        }
       
        public House(int area)
        {
            this.area = area;
            door = new door();
        }
        public virtual void ShowData()
        {
            Console.WriteLine("I am a house, my area is {0} m2.", area);
        }
    }
    class door
    {
        protected string color;

        public door()
        {
            color = "Brown";
        }
        public door(string color)
        {
            this.color = color;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public void ShowData()
        {
            Console.WriteLine("I am a door, my color is {0}.", color);
        }

    }
    class SmallApartment : House
    {
        public SmallApartment() : base(50)
        {
            
        }
        public override void ShowData()
        {
            Console.WriteLine("I am an apartment, my area is " +
                area + " m2");

        }
    }
    class Person
    {
        protected string name;
        protected House house;

        public Person()
        {
            name = "Juan";
            house = new House(150);
        }
        public Person(string name, House house)
        {
            this.name = name;
            this.house = house;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public House House
        {
            get { return house; }
            set { house = value; }
        }

        public void ShowData()
        {
            Console.WriteLine("My name is {0}.", name);
            house.ShowData();
            house.Door.ShowData();
        }
    }
}
