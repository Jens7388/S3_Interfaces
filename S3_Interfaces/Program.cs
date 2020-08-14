using S3_Interfaces_Entities;
using System;

namespace S3_Interfaces
{
    class Program
    {
        static void Main()
        {
            Temperature temp1 = new Temperature(10, 50);
            Temperature temp2 = new Temperature(10, 50);
            Temperature temp3 = (Temperature)temp2.Clone();
            Console.WriteLine(temp1.CompareTo(temp2));
            Console.WriteLine(temp3.ToString());
            Console.WriteLine(temp3.Equals(temp2));
            Console.ReadLine();
        }
    }
}