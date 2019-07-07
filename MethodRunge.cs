using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LabSystemDif
{
    class MethodRunge
    {
        public PointF PrevPoint { get; private set; }
        public PointF NullPoint;

        protected float T;

        /// <summary>
        /// длина шага
        /// </summary>
        public float StepH;

        /// <summary>
        /// производные
        /// </summary>
        protected Func<float, float, float, float> DirivX, DirivY;

        public MethodRunge() { }

        public MethodRunge(Func<float, float, float, float> DirX, 
            Func<float, float, float, float> DirY, float stepH, PointF nullPoint) {
            DirivX = DirX;
            DirivY = DirY;

            StepH = stepH;
            NullPoint = nullPoint;
            PrevPoint = NullPoint;
        }


        public void NewParams(Func<float, float, float, float> dirivX, Func<float, float, float, float> dirivY, float stepH, PointF nullPoint)
        {
            DirivX = dirivX;
            DirivY = dirivY;

            StepH = stepH;
            NullPoint = nullPoint;
            PrevPoint = NullPoint;
        }

        public virtual PointF NewPoint()
        {
            return PrevPoint = Step(PrevPoint, T += StepH);
        }

        /// <summary>
        /// итерационный процесс
        /// </summary>
        /// <param name="CountPoint"> колличество точек</param>
        /// <returns></returns>
        public virtual PointF[] PointsSystem(int CountPoint) {
            PointF[] points = new PointF[CountPoint];
            float t = 0;

            points[0] = NullPoint;

            for (int i = 1; i < CountPoint; i++) {
                points[i] = Step(points[i - 1], t = t + StepH); 
            }

            return points;
        }
        /// <summary>
        /// шаг итерации
        /// выч. новую точку
        /// </summary>
        /// <param name="point">предыдущая точка</param>
        /// <returns>точка</returns>
        protected virtual PointF Step(PointF point, float t) {
            Vector Q1, Q2, Q3, Q4;

            Q1 = VectorQ(t, point);
            Q2 = VectorQ(t + StepH / 2, point + Q1 / 2);
            Q3 = VectorQ(t + StepH / 2, point + Q2 / 2);
            Q4 = VectorQ(t + StepH, point + Q3);

            return point + (Q1 + 2 * Q2 + 2 * Q3 + Q4) / 6;

        }

        protected virtual Vector VectorQ(float t, PointF point) 
            => new Vector(DirivX(t, point.X, point.Y), DirivY(t, point.X, point.Y)) * StepH;

    }


    class FunctionToDraw: MethodRunge
    {
        Func<float, float> FuncX, FuncY;

        public FunctionToDraw(Func<float, float> funcX, Func<float, float> funcY)
        {
            FuncX = funcX;
            FuncY = funcY;
        }

        public override PointF NewPoint()
        {
            PointF point = new PointF(FuncX(T), FuncY(T));
            T += StepH;
            return point;
        }

        public override PointF[] PointsSystem(int CountPoint)
        {
            PointF[] points = new PointF[CountPoint];

            for (int i = 0; i < CountPoint; i++)
            {
                points[i] = NewPoint();
            }

            return points;
        }
    }
}
