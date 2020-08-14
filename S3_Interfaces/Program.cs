using S3_Interfaces_Entities;
using System;

namespace S3_Interfaces
{
    class Program
    {
        static void Main()
        {
            Temperature temp1 = new Temperature(70, 69, "text");
            Temperature temp2 = new Temperature(69, 69, "text");
            Console.WriteLine(temp1.CompareTo(temp2));
        }
    }
}