﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SerializeLab.Classes.TransportAutoClasses
{
    class TrolleyBus : TransportAuto
    {
        private int lengthOfRods;
        public int LengthOfRods
        {
            set
            {
                if (IsCorrectNumb(value))
                {
                    lengthOfRods = value;
                }
                else
                {
                    throw new Exception();
                }
            }
            get
            {
                return lengthOfRods;
            }
        }
        public TrolleyBus(int classIndex)
            : base(classIndex)
        { }
        public TrolleyBus(int weigth, string color, string mark, int height, int width, int classIndex, int countSittingPlace, int countStandingPlace,
                   int lengthOfRods)
            : base(weigth, color, mark, height, width, classIndex, countSittingPlace, countStandingPlace)
        {
            this.LengthOfRods = lengthOfRods;
        }
        public override void SerializeObject(StreamWriter file, char separator)
        {
            base.SerializeObject(file, separator);

            file.Write(this.LengthOfRods);
            file.Write(separator);
        }

        public override void DeserializeObject(List<string> data)
        {
            base.DeserializeObject(data);

            const int currentItemList = 0;

            try
            {
                this.LengthOfRods = Convert.ToInt32(data[currentItemList]);
                data.RemoveAt(currentItemList);
            }
            catch
            {
                throw new Exception();
            }
        }

    }
}
