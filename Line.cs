using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;


namespace LabSystemDif
{
    class Line
    {
        Action<LinkedList<PointF>, Color> Drawing;
        Action<PointF[], Color> DrawingsAll;

        public Color ColorLine { get; private set; }

        public MethodRunge Method { get; private set; }

        public PointF[] Points { get; private set; }
        public LinkedList<PointF> ListPoints { get; private set; }

        int Across = 1;

        int Count = 0;

        public Line(Func<float, float, float, float> dirivX, Func<float, float, float, float> dirivY, float stepH,
            PointF nullPoint, Color color, Action<LinkedList<PointF>, Color> drawing, Action<PointF[], Color> all, int across)
        {
            DrawingsAll = all;
            Drawing = drawing;

            Points = null;
            ListPoints = new LinkedList<PointF>();
            ColorLine = color;

            Method = new MethodRunge(dirivX, dirivY, stepH, nullPoint);
            Across = across;

            if (Across <= 0)
            {
                string[] str = stepH.ToString().Split(',');
                if (str.Length == 2 && str[1].Length > 3) Across = (int)Math.Pow(10, str[1].Length - 3);
                else Across = 1;
            }
        }

        public Line(Func<float, float, float, float> dirivX, Func<float, float, float, float> dirivY, float stepH, PointF nullPoint,
            Color color, int count, Action<PointF[], Color> all)
        {
            DrawingsAll = all;

            ColorLine = color;

            Method = new MethodRunge(dirivX, dirivY, stepH, nullPoint);

            Points = Method.PointsSystem(count);
        }

        public void NewPoint()
        {
            if (Count % Across != 0)
            {
                Method.NewPoint();
                Count++;
                return;
            }
            ListPoints.AddLast(Method.NewPoint());
            Drawing(ListPoints, ColorLine);
            Count++;
        }

        public void DrawingAll()
        {
            if (Points == null) DrawingsAll(ListPoints.ToArray(), ColorLine);
            else DrawingsAll(Points, ColorLine);
        }

        public void NullPoints()
        {
            if (Points == null)
            {
                try
                {
                    Method.NullPoint = ListPoints.Last.Value;
                    ListPoints = new LinkedList<PointF>();
                }
                catch
                {
                    return;
                }
            }
        }
    }
}
