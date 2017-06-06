using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;


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
                throw new Exception("Invalid data");
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
                throw new Exception("Invalid data");
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
                throw new Exception("Invalid data.");
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
    public virtual void SerializeObject(StreamWriter file, char separator)
    {
        file.Write(this.GetType().Name);
        file.Write(separator);
        file.Write(this.Weigth);
        file.Write(separator);
        file.Write(this.Color);
        file.Write(separator);
        file.Write(this.Mark);
        file.Write(separator);
        file.Write(this.Height);
        file.Write(separator);
        file.Write(this.Width);
        file.Write(separator);
    }
    public virtual void DeserializeObject(List<string> data)
    {
        const int currentItemList = 0;

        try
        {
            this.Weigth = Convert.ToInt32(data[currentItemList]);
            data.RemoveAt(currentItemList);
            this.Color = data[currentItemList];
            data.RemoveAt(currentItemList);
            this.Mark = data[currentItemList];
            data.RemoveAt(currentItemList);
            this.Height = Convert.ToInt32(data[currentItemList]);
            data.RemoveAt(currentItemList);
            this.Width = Convert.ToInt32(data[currentItemList]);
            data.RemoveAt(currentItemList);
        }
        catch
        {
            throw new Exception("Invalid data");
        }
    }
}
