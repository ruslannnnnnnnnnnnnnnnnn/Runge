using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace LabSystemDif
{
    static class ExtensionPointF
    {
        public static double Norma(this PointF p0, PointF p1)
        {
            float dx = p1.X - p0.X;
            float dy = p1.Y - p0.Y;

            return Math.Sqrt(dx * dx + dy * dy);
        }

        public static PointF Mult(this PointF p0, float Const) {
            return new PointF(p0.X * Const, p0.Y * Const);
        }

        public static PointF Div(this PointF p0, float Const) {
            return new PointF(p0.X / Const, p0.Y / Const);
        }

        public static PointF Transform(this PointF point, Matrix matr) {
            return new PointF(point.X * matr.Elements[0] + point.Y * matr.Elements[2] + matr.Elements[4],
                point.Y * matr.Elements[1] + point.Y * matr.Elements[3] + matr.Elements[5]);
        }

        public static bool Eqvl(this PointF point0, PointF point1)
        {
            return point0.X == point1.X && point0.Y == point1.Y;
        }
    }

    static class ExtensionArr {
        public static string InString(this Array arr) {
            string str = "";

            foreach (object el in arr) {
                str += el.ToString() + " ";
            }

            return str;
        }
    }
}
