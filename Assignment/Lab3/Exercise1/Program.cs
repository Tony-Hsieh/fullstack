using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var rt = new Rectangle();
            Calculate(rt);

            var c = new Circle();
            c.UserEnter();
            Calculate(c);
        }
        public static void Calculate(Shape1 S)
        {
            Console.WriteLine("Area : {0}", S.Area());
            Console.WriteLine("Circumference : {0}", S.Circumference());
        }
    }
    abstract class Shape1
    {

        protected float R, L, B;

        //Abstract methods can have only declarations
        public abstract float Area();
        public abstract float Circumference();
    }

    class Rectangle : Shape1
    {
        public Rectangle()
        {
            Console.Write("Enter Length: ");
            L = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter Breadth: ");
            B = Convert.ToSingle(Console.ReadLine());
            
        }

        public override float Area()
        {
            return L * B;
        }

        public override float Circumference()
        {
            return 2 * (L + B);
        }
    }
    class Circle : Shape1
    {
        public void UserEnter()
        {
            Console.Write("Enter Radius: ");
            R = Convert.ToSingle(Console.ReadLine());
        }
        public override float Area()
        {
            return R * R * (float)3.14;
        }
        public override float Circumference()
        {
            return 2 * (float)3.14 * R;
        }

    }

}
