/* In this class I practice the usage of properties and fields in this language
 * */

using System;
using System.Collections.Generic;
using System.Text;

namespace usingProperties
{
    class Box
    {
        private double height, volume, width;

        public double Length { get; set; }

        public double Height
        {
            get => height;
            set => height = value;
        }

        public double Volume
        {
            get
            {
                return Length * Height * Width;
            }

            set
            {
                volume = value;
            }

        }

        public double Width
        {
            get
            {
                return width;
            }

            set
            {
                width = value;
            }
        }

        public Box(double Length, double height, double width)
        {
            this.Length = Length;
            this.height = height;
            this.width = width;

        }

        public Box() { }

        public void PrintStats()
        {
            Console.WriteLine("This box has a length of {0}, a height of {1}, a width of {2}, and a volume of {3}", Length, height, width, volume = Width * height * Length);
            Console.WriteLine("");
        }

        public double FrontSurface
        {
            get
            {
                return Length * height;
            }
        }
    }
}
