using System;
using System.Collections;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {      
            var numbers = new Array(3);
            numbers.Insert(10);
            numbers.Insert(20);
            numbers.Insert(30);
            numbers.Insert(50);
            numbers.Insert(60);
            numbers.Print();
            Console.WriteLine($"The maximum number in the array is {numbers.Max()}");

             int[] arrCommon = { 20, 60, 70 };
             numbers.Intersect(arrCommon);

              numbers.Reverse();

            numbers.InsertAt(40, 3);
            numbers.Print();   

           
        }
    }
}
