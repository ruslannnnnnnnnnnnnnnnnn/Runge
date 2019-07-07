using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LabSystemDif
{
    class Controller
    {
        public bool IsInit { get; private set; }

        public Lines Lines { get; private set; }

        public DrawingLine Drawing { get; private set; }

        public int IndexLine;

        Color[] colors = 
        {
            Color.Green, Color.DarkBlue, Color.DarkOliveGreen, Color.Black,
            Color.DarkCyan, Color.DarkOliveGreen, Color.DarkSeaGreen, Color.DarkViolet, Color.Firebrick, Color.DarkRed, Color.BlueViolet,
            Color.Gray, Color.Honeydew, Color.Khaki, Color.Lavender, Color.Maroon, Color.Olive, Color.Orange, Color.Red, Color.Chocolate
        };

        private int countStep = 1;

        int indexColor = -1;

        public int IndexColor
        {
            get
            {
                return indexColor;
            }
            set
            {
                if (value >= colors.Length) indexColor = 0;
                else indexColor = value;
            }
        }

        public int CountStep
        {
            get
            {
                return countStep;
            }

            set
            {
                if (value > 0) countStep = value;
            }
        }

        PointF[] Points
        {
            get
            {
                if (Lines[IndexLine].Points == null) return Lines[IndexLine].ListPoints.ToArray();
                return Lines[IndexLine].Points;
            }
        }

        public Controller(DrawingLine drawing)
        {
            Drawing = drawing;
            Lines = new Lines(drawing);

            Drawing.DrawingNull();
        }

        public void Main(int count, PointF nullPoint, float step,
            Func<float, float, float, float> DirivX, Func<float, float, float, float> DirivY)
        {
            Lines.Add(DirivX, DirivY, step, nullPoint,
                (Lines.Count > IndexLine && Lines[IndexLine].Method.NullPoint.Eqvl(nullPoint)) ? colors[IndexColor] : colors[++IndexColor], count);

            DrawAll = Lines.DrawAll;

            Draw = () => { for (int i = 0; i < countStep; i++, Lines[IndexLine].NewPoint()) ; };

            MainMult(1);
        }

        public void Main(int count, PointF nullPoint, float step, 
            Func<float, float, float, float> DirivX, Func<float, float, float, float> DirivY, string drawing, bool isArrow, int across)
        {
            IsInit = true;

            if (drawing == "curve" || drawing == "lines" || drawing == "points")
            {
                Lines.Add(DirivX, DirivY, step, nullPoint,
                        (Lines.Count > IndexLine && Lines[IndexLine].Method.NullPoint.Eqvl(nullPoint)) ? colors[IndexColor] : colors[++IndexColor], drawing, isArrow, across);
                DrawAll = Lines.DrawAll;

                Draw = () => { for (int i = 0; i < countStep; i++, Lines[IndexLine].NewPoint()) ; };
            }
            else IsInit = false;
        }

        public Action Draw { get; private set; }
        public Action DrawAll { get; private set; }

        private void MainMult(float scale) {
            Drawing.Scale *= scale;
            DrawAll();
        }

        public void MainDivd(float scale)
        {
            Drawing.Scale /= scale;
            DrawAll();
        }

        public void MainTranslate(float x, float y) => Drawing.Translate(x, y);
        public void MainNullTranslate()
        {
            Drawing.TranslateNull();
            Drawing.Scale = 1;
        }

        public void MainNull()
        {
            MainNullTranslate();
            Drawing.DrawingNull();          
        }

        public void MainNullScale()
        {
            MainNullTranslate();
            DrawAll();
        }

        public void MainTransleteCenterAndScaleMult(float scale, float x, float y) {
            Drawing.Scale *= scale;

            PointF point = Drawing.GetTruePoint(x, y).Mult(scale);
            point = Drawing.GetTranslatePoint(point.X, point.Y);

            MainTranslate(point.X, point.Y);

            try
            {
                DrawAll();
            }
            catch
            {
                return;
            }
        }

        public void MainTransleteCenterAndScaleDivd(float scale, float x, float y)
        {
            Drawing.Scale /= scale;

            PointF point = Drawing.GetTruePoint(x, y).Div(scale);
            point = Drawing.GetTranslatePoint(point.X, point.Y);

            MainTranslate(point.X, point.Y);

            try
            {
                DrawAll();
            }
            catch
            {
                return;
            }
        }
    }
}
