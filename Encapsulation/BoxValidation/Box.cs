using System;

public class Box
{
    private double length;
    private double width;
    private double height;

    public double Length
    {
        get { return length; }
        set
        {
            Validation(value, "Length");
            length = value;
        }
    }

    public double Width
    {
        get { return width; }
        set
        {
            Validation(value, "Width");
            width = value;
        }
    }

    public double Height
    {
        get { return height; }
        set
        {
            Validation(value, "Height");
            height = value;
        }
    }


    public Box(double length, double width, double heigth)
    {
        Length = length;
        Width = width;
        Height = heigth;
    }

    public void Validation(double value, string side)
    {
        if (value <= 0)
        {
            throw new ArgumentException($"{side} cannot be zero or negative.");
        }
    }

    public double LateralSurfaceArea()
    {
        return 2 * height * (length + width);
    }

    public double SurfaceArea()
    {
        return LateralSurfaceArea() + 2 * length * width;
    }

    public double Volume()
    {
        return length * width * height;
    }
}