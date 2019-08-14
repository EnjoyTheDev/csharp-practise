using System;
using System.Collections.Generic;
using System.Text;

namespace lecture_13
{
  internal class Shape
  {
    internal int oneSide = 5;

    public virtual void CalcArea()
    {
      Console.WriteLine("Area");
    }
  }

  internal class CircleArea : Shape
  {
    public string ShapeName { get; } = "Circle";
    public double circleArea { get; set; }

    public override void CalcArea()
    {
      int radius = 4;
      circleArea = Math.Round(Math.PI * Math.Pow(radius, 2), 2);
    }
  }

  internal class SquareArea : Shape
  {
    internal string ShapeName { get; } = "Square";
    public double squareArea { get; set; }

    public override void CalcArea()
    {
      squareArea = Math.Pow(oneSide, 2);
    }
  }

  internal class TriangleArea : Shape
  {
    internal string ShapeName { get; } = "Triangle";
    public double triangleArea { get; set; }

    public override void CalcArea()
    {
      double height = 9;
      triangleArea = (height * oneSide / 2);
    }
  }
}