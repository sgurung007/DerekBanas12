using System;
using System.Collections.Generic;
using System.Linq;

namespace DerekBanas12
{
    class Program
    {
        delegate double doubleIt(double val);
        static void Main(string[] args)
        {
            //This is fucking eye patch
            //Generic collections, Generic Methods ,Generic structs, and Delegates
            List<Animal> animalList = new List<Animal>();

            //add Animal in animalList generic list
            animalList.Add(new Animal() { Name = "train1" });
            animalList.Add(new Animal() { Name = "boat" });
            animalList.Add(new Animal() { Name = "motorcycyle" });
            animalList.Add(new Animal() { Name = "bicycle" });

            //insert animal in 1 index of animal list
            animalList.Insert(1, new Animal() { Name = "aeroplane" });

            //delete the bicycle
            animalList.RemoveAt(animalList.Count - 1);

            //printing out the animals
            foreach (Animal o in animalList)
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

            Console.WriteLine("*****************************************");
            //lambda expression
            doubleIt dlit = x => x * 2;
            Console.WriteLine($"5 * 2 is {dlit(5)}");

            List<int> numList = new List<int> { 1, 9, 2, 6, 3 };

            var evenList = numList.Where(a => a % 2 == 0).ToList();

            foreach (int o in evenList)
            {
                Console.WriteLine($"{o}");
            }
            Console.WriteLine("*****************************************");
            var rangeList = numList.Where(x => (x > 2) && (x < 9)).ToList();

            foreach (int o in rangeList)
            {
                Console.WriteLine($"{o}");
            }

            Console.WriteLine("*****************************************");
            //select
            var oneTo10 = new List<int>();
            oneTo10.AddRange(Enumerable.Range(1, 10));

            var squares = oneTo10.Select(x => x * x);

            foreach (var o in squares)
            {
                Console.WriteLine($"{o}");
            }
            Console.WriteLine("*****************************************");
            //zip
            var listOne = new List<int>(new int[] { 1, 3, 4 });
            var listTwo = new List<int>(new int[] { 4, 6, 8 });

            var sumList = listOne.Zip(listTwo, (x, y) => x + y).ToList();

            foreach (var o in sumList)
            {
                Console.WriteLine($"zip : {o}");
            }

            Console.WriteLine("*****************************************");
            //aggrigate

            var numList5 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("sum :{0}",
                numList5.Aggregate((a, b) => a + b));
            Console.WriteLine("*****************************************");
            var numList6 = new List<int> { 1, 2, 3, 4, 5};
            Console.WriteLine("Ave :{0}",
                numList6.AsQueryable().Average());
            Console.WriteLine("*****************************************");
            Console.WriteLine("All >3:{0}",
                numList6.All(x => x > 3));
            Console.WriteLine("Any >3: {0}",
                numList6.Any(x => x > 3));
            Console.WriteLine("*****************************************");
            //Distinct 
            var numList7 = new List<int>{ 1,2,3,4,5,3};
            Console.WriteLine("Distinct: {0}",
                string.Join(",", numList7.Distinct()));
            Console.WriteLine("*****************************************");
            var numList8 = new List<int> { 4, 5 };
            Console.WriteLine("Except: {0}",
                string.Join(",",
                numList7.Except(numList8)));

            //Intersect //found in the both list


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
