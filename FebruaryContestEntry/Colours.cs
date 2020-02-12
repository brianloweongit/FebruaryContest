using System;

namespace FebruaryContestEntry
{
  class Colours
  {
    public ConsoleColor Stroke { get; set; }
    public ConsoleColor Fill { get; set; }

    public Colours(ConsoleColor stroke, ConsoleColor fill)
    {
      Stroke = stroke;
      Fill = fill;
    }
  }
}
