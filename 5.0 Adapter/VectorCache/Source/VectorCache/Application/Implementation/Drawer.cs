using MoreLinq;
using System;
using System.Collections.Generic;
using VectorCache.Interfaces;
using System.Drawing;

namespace VectorCache.Implementation
{
    public class Drawer : IDrawer
    {
        private readonly List<VectorObject> vectorObjects;

        public Drawer() 
            => vectorObjects = new List<VectorObject>
        {
            new VectorRectangle(1, 1, 10, 10),
            new VectorRectangle(3, 3, 6, 6)
        };

        public void Draw()
        {
            foreach (VectorObject vo in vectorObjects)
            {
                foreach (Line line in vo)
                {
                    LineToPointAdapter adapter = new LineToPointAdapter(line);
                    adapter.ForEach(DrawPoint);
                }
            }
        }

        public void DrawPoint(Point p)
        {
            Console.Write(".");
        }
    }
}
