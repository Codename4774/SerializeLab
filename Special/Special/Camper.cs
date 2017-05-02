using System;
using System.IO;
using System.Collections.Generic;

public class Camper : SpecialAuto
{
    private int areaOfLivingSpace;
    public int AreaOfLivingSpace
    {
        get
        {
            return areaOfLivingSpace;
        }
        set
        {
            areaOfLivingSpace = value;
        }
    }

    public override void SerializeObject(StreamWriter file, char separator)
    {
        base.SerializeObject(file, separator);

        file.Write(this.areaOfLivingSpace);
        file.Write(separator);
    }

    public override void DeserializeObject(List<string> data)
    {
        base.DeserializeObject(data);

        const int currentItemList = 0;

        try
        {
            this.areaOfLivingSpace = Convert.ToInt32(data[currentItemList]);
            data.RemoveAt(currentItemList);
        }
        catch
        {
            throw new Exception();
        }
    }
    public Camper(int classIndex)
        : base(classIndex)
    { }
    public Camper(int weigth, string color, string mark, int height, int width, int classIndex, int areaOfLivingSpace)
        : base(weigth, color, mark, height, width, classIndex)
    {
        AreaOfLivingSpace = areaOfLivingSpace;
    }
}
