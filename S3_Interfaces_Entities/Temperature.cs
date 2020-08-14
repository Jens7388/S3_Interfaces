using System;

namespace S3_Interfaces_Entities
{
    public class Temperature
    {
        public double C { get; set; }

        public double F { get; set; }

        public string Text { get; set; }

        public Temperature(double c, double f, string text)
        {
            C = c;
            F = f;
            Text = text;
        }
    }
}
