using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeLab.Classes
{
    abstract class Auto
    {
        public int Weigth { set; get; }
        public string Color { set; get; }
        public string Mark { set; get; }
        public int Height { get; set;}
        public int Width { get; set; }
        public int Mileage { get; set; }

        public Auto()
        { }
        public Auto(int weigth, string color, string mark, int height, int width, int mileage)
        {
            this.Weigth = weigth;
            this.Color = color;
            this.Mark = mark;
            this.Width = width;
            this.Mileage = mileage;
        }

    }
}
