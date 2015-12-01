// Static using
using static System.Math;

namespace ConsoleApplication1
{
    public class Point
    {
        // Getter-only auto-properties
        public int X { get; }
        public int Y { get; }

        // Constructor
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point() : this(0, 0) { }

        // Sting interpolation
        public override string ToString() => $"({X}, {Y})";

        // Expression bodied members
        public double Dist => Sqrt(X * X + Y * Y);
    }
}
