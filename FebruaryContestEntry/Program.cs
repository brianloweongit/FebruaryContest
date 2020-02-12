using System;

namespace FebruaryContestEntry
{
  class Program
  {
    const char block = '▓';
    const int RequiredRows = 15;
    const int RequiredColumns = 30;

    static void Main(string[] args)
    {
      var size = new ShapeSize(RequiredRows, RequiredColumns);

      var colours = new Colours(ConsoleColor.Green, ConsoleColor.Yellow);

      DrawShape(block, size, colours);

      Console.ResetColor();
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine("Yay, a colorful shape!");
      Console.ReadLine();
    }

    private static void DrawShape(char block, ShapeSize size, Colours colours)
    {
      for (int r = 1; r <= size.Rows; r++)
      {
        for (int c = 1; c <= size.Columns; c++)
        {
            Fill(block, r, c, size, colours);
        }
      }
    }

    private static void Fill(char block, int r, int c, ShapeSize size, Colours colours)
    {
      Console.ForegroundColor = GetColour(r,c,size,colours);
      Console.Write(block);
      if (c == size.Columns) {
        Console.WriteLine();
      }
    }

    private static ConsoleColor GetColour(int r, int c, ShapeSize size, Colours colours)
    {
      return IsStroke(r, c, size)
        ? colours.Stroke
        : colours.Fill;
    }

    private static bool IsStroke(int r, int c, ShapeSize size)
    {
      return 1 == r || 1 == c || size.Rows == r || size.Columns == c;
    }
  }
}
