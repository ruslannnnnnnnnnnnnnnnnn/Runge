using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace LabSystemDif
{
    class Lines
    {
        public DrawingLine Drawing { get; private set; }
        LinkedList<Line> lines;

        public Line Last
        {
            get
            {
                return lines.Last.Value;
            }
        }

        public Line this[int index]
        {
            get
            {
                if (index >= lines.Count) return null;
                return lines.ElementAt(index);
            }
        }

        public int Count
        {
            get
            {
                return lines.Count;
            }
        }

        public Lines(DrawingLine drawing)
        {
            Drawing = drawing;
            lines = new LinkedList<Line>();
        }

        public void Add(Func<float, float, float, float> dirivX, Func<float, float, float, float> dirivY, float stepH, PointF nullPoint, Color color, int count)
        {
            lines.AddLast(new Line(dirivX, dirivY, stepH, nullPoint, color, count, (list, col) => 
            {
                Drawing.NewColors(col);
                Drawing.Drawing(list.ToArray());
            }));
        }

        public void Add(Func<float, float, float, float> dirivX, Func<float, float, float, float> dirivY, float stepH, PointF nullPoint, Color color, string drawing, bool arrow, int across)
        {
            Action<LinkedList<PointF>, Color> draw = null;
            Action<PointF[], Color> drawAll = null;

            if (drawing == "points")
            {
                draw = (list, col) =>
                {
                    Drawing.NewColors(col);
                    Drawing.PutPixelToScale(list.Last.Value);
                };

                drawAll = (points, col) =>
                {
                    Drawing.NewColors(col);
                    Drawing.DrawingAllToPoints(points);
                };

                if (arrow)
                    drawAll = (points, col) =>
                    {
                        Drawing.NewColors(col);
                        Drawing.DrawingAllToPointsArrows(points);
                    };
            }
            else if (drawing == "lines")
            {
                draw = (list, col) =>
                {
                    if (list.Count < 2) return;
                    Drawing.NewColors(col);
                    Drawing.DrawLineToScale(list.Last.Previous.Value, list.Last.Value);
                };
                drawAll = (points, col) =>
                {
                    if (points.Length < 2) return;
                    Drawing.NewColors(col);
                    Drawing.DrawingAllToLines(points);
                };

                if (arrow)
                    drawAll = (points, col) =>
                    {
                        Drawing.NewColors(col);
                        Drawing.DrawingAllToLinesArrows(points);
                    };
            }
            else if (drawing == "curve")
            {
                draw = (list, col) =>
                {
                    if (list.Count < 2) return;
                    Drawing.NewColors(col);
                    Drawing.DrawingAllToCurve(list.ToArray());
                };
                drawAll = (points, col) =>
                {
                    if (points.Length < 2) return;
                    Drawing.NewColors(col);
                    Drawing.DrawingAllToCurve(points);
                };
            }
            else return;

            lines.AddLast(new Line(dirivX, dirivY, stepH, nullPoint, color, draw, drawAll, across));
        }

        public void DrawAll()
        {
            Drawing.DrawingNull();

            foreach (var line in lines)
            {
                line.DrawingAll();
            }
        }

        public void NullLines()
        {
            foreach (var line in lines)
            {
                line.NullPoints();
            }
        }
    }
}
