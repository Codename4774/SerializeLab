using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SerializeLab.Classes
{
    public class Auto
    {
        //public int Id { set; get; }
        public int Weigth { set; get; }
        public string Color { set; get; }
        public string Mark { set; get; }
        public int Height { get; set;}
        public int Width { get; set; }

        private int classIndex;

        public int ClassIndex
        {
            get
            {
                return classIndex;
            }
        }
        public Auto(int classIndex)
        {
            this.classIndex = classIndex;
        }
        public Auto(int weigth, string color, string mark, int height, int width, int classIndex)
        {
            this.Weigth = weigth;
            this.Color = color;
            this.Mark = mark;
            this.Width = width;
            this.classIndex = classIndex;
        }
    }
}
