using System;
using System.Collections.Generic;

namespace DerekBanas12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generic collections, Generic Methods ,Generic structs, and Delegates
            List<Animal> animalList = new List<Animal>();

            //add Animal in animalList generic list
            animalList.Add(new Animal() { Name = "train1"});
            animalList.Add(new Animal() { Name = "boat" });
            animalList.Add(new Animal() { Name = "motorcycyle" });
            animalList.Add(new Animal() { Name = "bicycle" });

            //insert animal in 1 index of animal list
            animalList.Insert(1, new Animal() { Name= "aeroplane" });

            //delete the bicycle
            animalList.RemoveAt(animalList.Count - 1);

            //printing out the animals
            foreach(Animal o in animalList)
            {
                Console.WriteLine("object is: {0}",
                    o.Name);
            }

            Console.WriteLine("*****************************************");
            int num1 = 5;
            int num2 = 10;
            surajGenericMethod.GetSum(ref num1, ref num2);

            string xstr = "50", ystr = "100";
            surajGenericMethod.GetSum(ref xstr, ref ystr);

            double double1 = 50.000, double2 = 50.5007;
            surajGenericMethod.GetSum(ref double1, ref double2);
            Console.WriteLine("*****************************************");

            int int1 = 4, int2 = 4;
            Rectangle<int> rec1 = new Rectangle<int>(20, 10);
            Console.WriteLine("Area with integer: {0}", rec1.GetArea());

            Console.WriteLine("*****************************************");
            suraj sum, sub, sumsub;

            sum = new suraj(sumSuraj);
            sub = new suraj(subSuraj);
            sumsub = sum + sub;

            sum(10, 5);
            sumsub(10, 5);
        }

        public struct Rectangle<T>
        {
            private T width;
            private T lenght;

            public T Width
            {
                get { return width; }
                set { width = value; }
                
            }

            public T Length
            {
                get { return lenght; }
                set { lenght = value; }
            }

            public Rectangle(T w, T l)
            {
                width = w;
                lenght = l;
            }
            public string GetArea()
            {
                double dblWidth = Convert.ToDouble(width);
                double dblLength = Convert.ToDouble(lenght);
                return Convert.ToString(dblWidth * dblLength);
            }


        }

        public delegate void suraj(double num1, double num2);
        public static void sumSuraj(double a, double b)
        {
            Console.WriteLine($"sum is: {a}+{b}={a + b}");
        }
        public static void subSuraj(double a, double b)
        {
            Console.WriteLine($"sub is: {a}-{b}={a - b}");
        }

    }
}
