﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SerializeLab.Classes.CarClasses
{
    class CarWithClosedRoof : Car
    {
        public enum KindOfHatch { Hatch, SlidingHatch, PanoramicSunroof };
        public KindOfHatch KindHatch { set; get; }
        public int SaloonVolume { set; get; }
        public CarWithClosedRoof()
            : base()
        { }
        public CarWithClosedRoof(int weigth, string color, string mark, int height,
                                 int width, int mileage, int countPlaces, int bagageCapacity, KindOfHatch kindHatch, int saloonVolume)
            : base(weigth, color, mark, height, width, mileage, countPlaces, bagageCapacity)
        {
            this.KindHatch = kindHatch;
            this.SaloonVolume = saloonVolume;
        }
    }
}