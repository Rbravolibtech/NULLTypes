using System;

namespace NULLTypes 
{
    internal class Program
    {
        static void Main(string[] args)

        {

            DateTime? date = null;
            DateTime date2;

            if (date != null)
                date2 = date.GetValueOrDefault();
            else
                date2 = DateTime.Today;
            Console.WriteLine(date2);



            // this code initializes a nullable DateTime variable, assigns its value
            //to another nullable DateTime variable using GetValueOrDefault()

            //DateTime? date = new DateTime(2024, 1, 9);
            //DateTime? date2 = date.GetValueOrDefault();
            //DateTime? date3 = date2;

            //Console.WriteLine(date3.GetValueOrDefault());

                //////////////////////////

            //DateTime date = null;

            //Console.WriteLine("GetValueorDefault(): " + date.GetValueOrDefault());
            //Console.WriteLine("HasValue: " + date.HasValue);
            //Console.WriteLine("Value: " + date.Value);
        }
    }
}