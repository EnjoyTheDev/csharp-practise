using System;

namespace lecture_13
{
  class Program
  {
    static void Main(string[] args)
    {
      Shape[] shapeArray = new Shape[3];

      shapeArray[0] = new CircleArea();
      shapeArray[1] = new SquareArea();
      shapeArray[2] = new TriangleArea();

      for (int i = 0; i < shapeArray.Length; i++)
      {
        switch (shapeArray[i])
        {
          case CircleArea circle:
            {
              circle.CalcArea();
              Console.WriteLine($"\n This is {circle.ShapeName}. CLR Type is {circle.GetType().Name}. Square is {circle.circleArea}.");
              break;
            }
          case SquareArea square:
            {
              square.CalcArea();
              Console.WriteLine($"\n This is {square.ShapeName}. CLR Type is {square.GetType().Name}. Square is {square.squareArea}.");
              break;
            }

          case TriangleArea triangle:
            {
              triangle.CalcArea();
              Console.WriteLine($"\n This is {triangle.ShapeName}. CLR Type is {triangle.GetType().Name}. Square is {triangle.triangleArea}.");
              break;
            }
        }
      }
    }
  }
}