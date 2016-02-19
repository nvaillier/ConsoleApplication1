using System;
using System.Collections.Generic;
using System.Linq;

// Static using
using static System.Math;
using static System.Console;

namespace ConsoleApplication1
{
    public class Point
    {
        // Getter-only auto-properties + initialize value
        public int X { get; } = 0;
        public int Y { get; } = 0;

        #region Constructor
        // Constructor
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point() { }

        #endregion
        // Sting interpolation
        public override string ToString() => $"({X}, {Y})";

        // Expression bodied members (available for properties too)
        public double Dist => Sqrt(X * X + Y * Y);

        // Dictionary index initializer
        public Dictionary<string, string> UserData = new Dictionary<string, string>()
        {
            ["mail"] = "toto@truc.com",
            ["twitter"] = "@test"
        };

        // Null conditional operators
        public string TestMethod(string author)
            => string.Join("", author?.Split(' ').ToList().Select(word => word.Substring(0, 1).ToUpper())).Trim();

        // Exception Filter
        public void Test()
        {
            try
            {
                WriteLine("TRY");
            }
            catch (Exception ex)
            when (ex.HResult == 1)
            {
                WriteLine("CATCH ... WHEN ...");
            }
        }

        // DNX usage...
    }
}
