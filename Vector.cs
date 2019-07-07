using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LabSystemDif
{
    class Vector
    {
        public float X { get; private set; }
        public float Y { get; private set; }

        public Vector(float x, float y)
        {
            X = x;
            Y = y;
        }

        public Vector(PointF p0, PointF p1)
        {
            X = p1.X - p0.X;
            Y = p1.Y - p0.Y;
        }

        public static Vector operator *(float value, Vector vector)
            => new Vector(value * vector.X, value * vector.Y);

        public static Vector operator *(Vector vector, float value) => value * vector;

        public static Vector operator +(Vector vector1, Vector vectro2)
            => new Vector(vector1.X + vectro2.X, vector1.Y + vectro2.Y);


        public static PointF operator +(PointF point, Vector vector)
            => new PointF(point.X + vector.X, point.Y + vector.Y);

        public static Vector operator /(Vector vector, float value) 
            => new Vector(vector.X / value, vector.Y / value);

        public static Vector operator -(Vector vector1, Vector vectro2)
        {
            return new Vector(vector1.X - vectro2.X, vector1.Y - vectro2.Y);
        }

        public PointF ToPointF() => new PointF(X, Y);

        public double Norma(Vector vector) {
            float dx = X - vector.X;
            float dy = Y - vector.Y;

            return Math.Sqrt(dx * dx + dy * dy);
        }

        public double Norma()
        {
            return Math.Sqrt(X * X + Y * Y);
        }

        public Vector UnitVector()
            => new Vector((float)(X / Norma()), (float)(Y / Norma()));
    }
}
