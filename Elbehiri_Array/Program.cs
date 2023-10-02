using Elbehiri_Array;
using System;
using System.Diagnostics;
using System.Linq;

namespace Elbehiri1Arrary
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            var Alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz" +
                        "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz" +
                        "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            Charcters ArrayObj = new Charcters();
            ArrayObj.GetFinalArray(Alpha);
            ArrayObj.DisplayDataFromArry();

            sw.Stop();
            Console.WriteLine($"list access time: {sw.Elapsed.ToString()} = {sw.ElapsedMilliseconds.ToString()} ms");
            Console.ReadKey();
        }
    }
}