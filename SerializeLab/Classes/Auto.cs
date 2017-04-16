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

        public Auto()
        { }
        public Auto(int weigth, string color, string mark, int height, int width, int mileage)
        {
            this.Weigth = weigth;
            this.Color = color;
            this.Mark = mark;
            this.Width = width;
        }

        public virtual void GetAttributesFromControls(Control[] controlList)
        {
            const int WeightIndex = 0;
            const int ColorIndex = 1;
            const int MarkIndex = 2;
            const int HeightIndex = 3;
            const int WidthIndex = 4;
            
            
            Weigth = Convert.ToInt32(controlList[WeightIndex].Text);
            Color = controlList[ColorIndex].Text;
            Mark = controlList[MarkIndex].Text;
            Height = Convert.ToInt32(controlList[HeightIndex].Text);
            Width = Convert.ToInt32(controlList[WidthIndex].Text);
        }

    }
}
