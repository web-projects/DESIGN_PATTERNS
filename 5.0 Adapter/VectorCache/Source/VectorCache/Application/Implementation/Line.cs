using System.Drawing;

namespace VectorCache.Implementation
{
    public class Line
    {
        public Point Start, End;

        public Line(Point start, Point end) => (Start, End) = (start, end);
    }
}
