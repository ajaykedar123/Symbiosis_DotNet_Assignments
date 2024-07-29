using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Point3D :IFormattable
    {

        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }

        // Parameterized Constructor for initializing the members
        public Point3D(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        // Override ToString() method
        public override string ToString()
        {
            return $"Point3D(x: {x}, y: {y}, z: {z})";
        }

        // Implement IFormattable Interface
        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (string.IsNullOrEmpty(format)) format = "G";
            switch (format)
            {
                case "G":
                case "C":
                    return $"({x}, {y}, {z})";
                case "X":
                    return x.ToString();
                case "Y":
                    return y.ToString();
                case "Z":
                    return z.ToString();
                default:
                    throw new FormatException($"The {format} format string is not supported.");
            }
        }

        // Implement the IFormattable.ToString with default format provider
        public string ToString(string format)
        {
            return ToString(format, null);
        }
        static void Main(string[] args)
        {
            // Create an instance of Point3D
            Point3D point = new Point3D(9.2f, 7.3f, 1.1f);

            // Print x, y, and z individually and combined using various formats

            // Print x
            Console.WriteLine(point.ToString("X"));
            // Print y
            Console.WriteLine(point.ToString("Y"));
            // Print z
            Console.WriteLine(point.ToString("Z"));
            // Print combined (x, y, z)
            Console.WriteLine(point.ToString("C"));
            // Print combined (x, y, z)
            Console.WriteLine(point.ToString("G")); 


            Console.WriteLine($"X: {point.ToString("X")}");
            Console.WriteLine($"Y: {point.ToString("Y")}");
            Console.WriteLine($"Z: {point.ToString("Z")}");
            Console.WriteLine($"Combined (C): {point.ToString("C")}");
            Console.WriteLine($"General (G): {point.ToString("G")}");

            Console.ReadKey();
        }
    }
}
