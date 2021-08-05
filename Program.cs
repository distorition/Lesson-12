using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Lesson_12._1
{
    public class PointClass
    {
        public int X;
        public int Y;
    }

    public struct PointStruct
    {
        public int X;
        public int Y;
    }
    public class BechmarkClass
    {
        private static void NewMethod()
        {
            int x;
            int y;
            Console.WriteLine("Ввидите значения для подсчета длинны");
            Console.WriteLine($"  X: {x = Convert.ToInt32(Console.ReadLine())}");
            Console.WriteLine($"  Y: {y = Convert.ToInt32(Console.ReadLine())}");
            var point = new PointClass() { X = x };
            var pointtwo = new PointClass() { Y = y };
            var pointoneStruc = new PointStruct() { X = x };
            var pointTwoStruct = new PointStruct() { Y = y };
            Console.WriteLine($"подсчет через класс{SomePointClass(point, pointtwo)}");
            Console.WriteLine($"подсчет через структуру  {PointStruct1(pointoneStruc, pointTwoStruct)}");
            Console.WriteLine($"подсчет через класс дабл{doublelPointClass(point, pointtwo)}");
            Console.WriteLine($"подсчет через структуру с числением корня  {floatPointStruct(pointoneStruc, pointTwoStruct)}");
        }

        public static float SomePointClass(PointClass pointClassOne, PointClass pointClassTwo)
        {
            float x = pointClassOne.X - pointClassTwo.X;
            float y = pointClassOne.Y - pointClassTwo.Y;
            return (x * x) + (y * y);

        }
        public static float PointStruct1(PointStruct pointStructOne, PointStruct pointStructTwo)
        {
            float x = pointStructOne.X - pointStructTwo.X;
            float y = pointStructOne.Y - pointStructTwo.Y;
            return (x * x) + (y * y);

        }
        public static double doublelPointClass(PointClass pointClassOne, PointClass pointClassTwo)
        {
            double x = pointClassOne.X - pointClassTwo.X;
            double y = pointClassOne.Y - pointClassTwo.Y;
            return (x * x) + (y * y);

        }
        public static float floatPointStruct(PointStruct pointStructOne, PointStruct pointStructTwo)
        {
            float x = pointStructOne.X - pointStructTwo.X;
            float y = pointStructOne.Y - pointStructTwo.Y;
            return (float)Math.Sqrt((x * x) + (y * y));

        }
         [Benchmark]
    public void TetsSum()
    {
             void NewMethod()
            {
                int x;
                int y;
                Console.WriteLine("Ввидите значения для подсчета длинны");
                Console.WriteLine($"  X: {x = Convert.ToInt32(Console.ReadLine())}");
                Console.WriteLine($"  Y: {y = Convert.ToInt32(Console.ReadLine())}");
                var point = new PointClass() { X = x };
                var pointtwo = new PointClass() { Y = y };
                var pointoneStruc = new PointStruct() { X = x };
                var pointTwoStruct = new PointStruct() { Y = y };
                Console.WriteLine($"подсчет через класс{SomePointClass(point, pointtwo)}");
                Console.WriteLine($"подсчет через структуру  {PointStruct1(pointoneStruc, pointTwoStruct)}");
                Console.WriteLine($"подсчет через класс дабл{doublelPointClass(point, pointtwo)}");
                Console.WriteLine($"подсчет через структуру с числением корня  {floatPointStruct(pointoneStruc, pointTwoStruct)}");
            }
            float SomePointClass(PointClass pointClassOne, PointClass pointClassTwo)
            {
                float x = pointClassOne.X - pointClassTwo.X;
                float y = pointClassOne.Y - pointClassTwo.Y;
                return (x * x) + (y * y);

            }
            float PointStruct1(PointStruct pointStructOne, PointStruct pointStructTwo)
            {
                float x = pointStructOne.X - pointStructTwo.X;
                float y = pointStructOne.Y - pointStructTwo.Y;
                return (x * x) + (y * y);

            }
             double doublelPointClass(PointClass pointClassOne, PointClass pointClassTwo)
            {
                double x = pointClassOne.X - pointClassTwo.X;
                double y = pointClassOne.Y - pointClassTwo.Y;
                return (x * x) + (y * y);

            }
             float floatPointStruct(PointStruct pointStructOne, PointStruct pointStructTwo)
            {
                float x = pointStructOne.X - pointStructTwo.X;
                float y = pointStructOne.Y - pointStructTwo.Y;
                return (float)Math.Sqrt((x * x) + (y * y));

            }

        }
    }
 

   
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
            NewMethod();
        }

        private static void NewMethod()
        {
            int x;
            int y;
            Console.WriteLine("Ввидите значения для подсчета длинны");
            Console.WriteLine($"  X: {x = Convert.ToInt32(Console.ReadLine())}");
            Console.WriteLine($"  Y: {y = Convert.ToInt32(Console.ReadLine())}");
            var point = new PointClass() { X = x };
            var pointtwo = new PointClass() { Y = y };
            var pointoneStruc = new PointStruct() { X = x };
            var pointTwoStruct = new PointStruct() { Y = y };
            Console.WriteLine($"подсчет через класс{SomePointClass(point, pointtwo)}");
            Console.WriteLine($"подсчет через структуру  {PointStruct1(pointoneStruc, pointTwoStruct)}");
            Console.WriteLine($"подсчет через класс дабл{doublelPointClass(point, pointtwo)}");
            Console.WriteLine($"подсчет через структуру с числением корня  {floatPointStruct(pointoneStruc, pointTwoStruct)}");
        }

        public static float SomePointClass(PointClass pointClassOne, PointClass pointClassTwo)
        {
            float x = pointClassOne.X - pointClassTwo.X;
            float y = pointClassOne.Y - pointClassTwo.Y;
            return (x * x) + (y * y);

        }
        public static float PointStruct1(PointStruct pointStructOne, PointStruct pointStructTwo)
        {
            float x = pointStructOne.X - pointStructTwo.X;
            float y = pointStructOne.Y - pointStructTwo.Y;
            return (x * x) + (y * y);

        }
        public static double doublelPointClass(PointClass pointClassOne, PointClass pointClassTwo)
        {
            double x = pointClassOne.X - pointClassTwo.X;
            double y = pointClassOne.Y - pointClassTwo.Y;
            return (x * x) + (y * y);

        }
        public static float floatPointStruct(PointStruct pointStructOne, PointStruct pointStructTwo)
        {
            float x = pointStructOne.X - pointStructTwo.X;
            float y = pointStructOne.Y - pointStructTwo.Y;
            return (float)Math.Sqrt ((x * x) + (y * y));

        }


    }
}
