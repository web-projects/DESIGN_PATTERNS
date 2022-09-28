using System;
using System.Collections.Generic;
using System.Text;

namespace VectorCache.Implementation
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
            => (X, Y) = (x, y);

        protected bool Equals(Point other)
        {
            return X == other.X && Y == other.Y;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            return Equals((Point) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X * 397) ^ Y;
            }
        }
    }
}
