using System;

namespace NULLTypes 
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime? date = new DateTime(2024, 1, 9);
            DateTime? date2 = date.GetValueOrDefault();
            DateTime? date3 = date2;

            Console.WriteLine(date3.GetValueOrDefault());

            //DateTime date = null;

            //Console.WriteLine("GetValueorDefault(): " + date.GetValueOrDefault());
            //Console.WriteLine("HasValue: " + date.HasValue);
            //Console.WriteLine("Value: " + date.Value);
        }
    }
}