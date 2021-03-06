﻿using System;
using System.Diagnostics.CodeAnalysis;

namespace S3_Interfaces_Entities
{
    public class Temperature: IEquatable<Temperature>, IComparable<Temperature>, ICloneable
    {
        public double C { get; set; }

        public double F
        {
            get
            {
                return (C * 9) / 5 + 32;
            }
        }

        public string Text
        {
            get
            {
                return GetText();
            }
        }

        public Temperature(double c)
        {
            C = c;

        }

        public bool Equals(Temperature temp)
        {
            if(temp == null)
            {
                return false;
            }
            return C == temp.C &&
                   F == temp.F &&
                   string.Equals(Text, temp.Text);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Temperature);
        }

        public override int GetHashCode()
        {
            unchecked //makes program ignore over/underflow
            {
                //hash codes are multiplied with prime numbers to avoid collisions
                int hash = 17;
                hash = hash * 23 + C.GetHashCode();
                hash = hash * 23 + F.GetHashCode();
                hash = hash * 23 + Text.GetHashCode();
                return hash;
            }
        }

        public int CompareTo(Temperature temp)
        {
            int result = C.CompareTo(temp.C);

            // Compare the other properties if the first matches
            if(result == 0)
            {
                result = F.CompareTo(temp.F);
            }
            if(result == 0)
            {
                result = Text.CompareTo(temp.Text);
            }
            return result;
        }

        public virtual object Clone()
        {
            object clone = MemberwiseClone();
            return clone;
        }

        private string GetText()
        {
            if(C < -30)
            {
                return "ekstremt koldt";
            }
            else if(C >= -30 && C < -10)
            {
                return "meget koldt";
            }
            else if(C >= -10 && C < 0)
            {
                return "koldt";
            }
            else if(C >= 0 && C < 10)
            {
                return "køligt";
            }
            else if(C >= 10 && C < 20)
            {
                return "mildt";
            }
            else if(C >= 20 && C < 30)
            {
                return "varmt";
            }
            else if(C >= 30 && C < 40)
            {
                return "meget varmt";
            }
            else
            {
                return "ekstremt varmt";
            }
        }

        public override string ToString()
        {
            return $"{C}°, celsius {F}° fahrenheit, det er {Text}";
        }
    }
}