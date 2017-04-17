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
        private int weigth;
        public int Weigth
        {
            set
            {
                if (IsCorrectNumb(value))
                {
                    weigth = value;
                }
                else
                {
                    throw new Exception();
                }
            }
            get
            {
                return weigth;
            }
        }
        public string Color { set; get; }
        public string Mark { set; get; }
        private int height;
        public int Height
        {
            set
            {
                if (IsCorrectNumb(value))
                {
                    height = value;
                }
                else
                {
                    throw new Exception();
                }
            }
            get
            {
                return height;
            }
        }
        private int width;
        public int Width
        {
            set
            {
                if (IsCorrectNumb(value))
                {
                    width = value;
                }
                else
                {
                    throw new Exception();
                }
            }
            get
            {
                return width;
            }
        }

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
        public bool IsCorrectNumb(int value)
        {
            if (value <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
