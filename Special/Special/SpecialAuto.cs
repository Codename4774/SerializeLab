using System;
using System.IO;
using System.Collections.Generic;


public abstract class SpecialAuto : Auto
{
    public override void SerializeObject(StreamWriter file, char separator)
    {
        base.SerializeObject(file, separator);
    }

    public override void DeserializeObject(List<string> data)
    {
        base.DeserializeObject(data);
    }
    public SpecialAuto(int classIndex)
        : base(classIndex)
    { }
    public SpecialAuto(int weigth, string color, string mark, int height, int width, int classIndex)
        : base(weigth, color, mark, height, width, classIndex)
    {
    }
}
