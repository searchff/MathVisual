using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MV
{
    public class LineSegment
    {
        List<IntVector2D> pointList = new List<IntVector2D>();
        public LineSegment()
        {

        }
        public void Create(LogicImage li, int x0, int y0, int x1, int y1, Color32 color)
        {
            int dx = Mathf.Abs(x1 - x0), sx = x0 < x1 ? 1 : -1;
            int dy = Mathf.Abs(y1 - y0), sy = y0 < y1 ? 1 : -1;
            int err = (dx > dy ? dx : -dy) / 2, e2;
            for (; ; )
            {
                li.SetPixel(x0, y0, color);
                pointList.Add(new IntVector2D(x0, y0));
                if (x0 == x1 && y0 == y1) break;
                e2 = err;
                if (e2 > -dx) { err -= dy; x0 += sx; }
                if (e2 < dy) { err += dx; y0 += sy; }
            }
        }
       
    }
}
