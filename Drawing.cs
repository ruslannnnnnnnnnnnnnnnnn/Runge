using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LabSystemDif
{
    class DrawingLine
    {
        public Color ColorLine;
        public Pen PenLine;

        Graphics Gr;
        Bitmap Image;
        PictureBox PictureBox;
        SolidBrush SolidBrush;

        Color Arrow = Color.DarkRed;

        public Matrix TransformMatrix {
            get {
                return Gr.Transform;
            }
            set {
                if (value == null) return;
                Gr.Transform = value;
            }
        }

        public float Width, Height;
        public float WidthPen;
        Color Begin, End;

        private float scale;
        public float Scale {
            get {
                return scale;
            }
            set {
                if (value < 0) scale = 1;
                else scale = value;
            }
        }


        public float LengthArrow = 15, RotateArrow = 20, Across = 1000, CountArrows = 10;

        public DrawingLine(Color color, PictureBox pictBox, float WidthPen, Color begin, Color end, float scale)
        {
            ColorLine = color;
            PenLine = new Pen(ColorLine, WidthPen);
            SolidBrush = new SolidBrush(color);
            Gr = Graphics.FromImage(Image = new Bitmap(pictBox.Width, pictBox.Height));
            PictureBox = pictBox;

            //PenLine.StartCap = LineCap.ArrowAnchor;
            
            Width = pictBox.Width;
            Height = pictBox.Height;
            this.WidthPen = WidthPen;

            Begin = begin;
            End = end;

            Scale = scale;

            Gr.Transform = (TransformMatrix = new Matrix(1, 0, 0, -1, Width / 2, Height / 2));       
        }

        public void NewColors(Color color)
        {
            ColorLine = color;
            PenLine = new Pen(ColorLine, WidthPen);
            SolidBrush = new SolidBrush(color);
        }

        public void Translate(float x, float y) {
            float dx = x - Width / 2, dy = y - Height / 2;

            TransformMatrix = new Matrix(1, 0, 0, -1, TransformMatrix.Elements[4] - dx, TransformMatrix.Elements[5] - dy);
        }

        public void TranslateNull() => TransformMatrix = new Matrix(1, 0, 0, -1, Width / 2, Height / 2);

        private void DrawArrow(PointF startPoint, PointF endPoint)
        {
            Vector vector = new Vector(startPoint, endPoint);

            Vector vectorO = vector - vector.UnitVector() * LengthArrow;

            PointF pointO = startPoint + vectorO;

            Vector normal = new Vector(vector.Y, -vector.X).UnitVector();

            PointF pointLeft = pointO + normal * RotateArrow,
                pointRight = pointO + normal * (-RotateArrow);

            Pen pen = new Pen(Color.Red, WidthPen + 1);

            Gr.DrawLine(pen, pointLeft, endPoint);
            Gr.DrawLine(pen, pointRight, endPoint);

            PictureBox.Image = Image;
        }

        
        public PointF TruePoint(float x, float y)
        {
            return new PointF(((x - Gr.Transform.OffsetX) / Scale), (-(y - Gr.Transform.OffsetY) / Scale));
        }

        private PointF[] TruePoints(PointF[] points) {
            if (points == null) return null;

            LinkedList<PointF> list = new LinkedList<PointF>();
            list.AddLast(new PointF(points[0].X * scale, points[0].Y * scale));

            for(int i = 1; i < points.Length; i++) {
                PointF localPoint = new PointF(points[i].X * scale, points[i].Y * scale);

                if (Math.Abs(localPoint.X) > Width * 10 || Math.Abs(localPoint.Y) > Height * 10) {
                    break;
                }

                if(localPoint.Norma(list.Last()) > 0.05)
                    list.AddLast(localPoint);
            }

            return list.ToArray();
        }

        public void DrawingAllToCurve(PointF[] points)
        {
            PointF[] pointsTrue = TruePoints(points);

            if (pointsTrue == null || pointsTrue.Length <= 1) return;

            Gr.DrawCurve(PenLine, pointsTrue);
        }

        public void DrawingAllToPointsArrows(PointF[] points)
        {
            if (points == null || points.Length == 0) return;

            PointF prev = new PointF(points[0].X * scale, points[0].Y * scale);

            SolidBrush solidBrush = SolidBrush;
            float width = WidthPen;
            SolidBrush = new SolidBrush(Arrow);

            WidthPen += 3;
            PutPixelPoint(prev);

            WidthPen = width;
            SolidBrush = solidBrush;

            for (int i = 1; i < points.Length; i++)
            {
                if (i % Across == 0 && i / Across < CountArrows) DrawArrow(prev, prev = new PointF(points[i].X * scale, points[i].Y * scale));
                else prev = new PointF(points[i].X * scale, points[i].Y * scale);

                PutPixelPoint(prev);
            }

            PictureBox.Image = Image;
        }

        public void DrawingAllToPoints(PointF[] points)
        {
            if (points == null || points.Length == 0) return;

            for (int i = 0; i < points.Length; i++)
            {
                PutPixelPoint(new PointF(points[i].X * scale, points[i].Y * scale));
            }

            PictureBox.Image = Image;
        }

        public void DrawingAllToLinesArrows(PointF[] points)
        {
            if (points == null || points.Length < 2) return;

            PointF prev = new PointF(points[0].X * scale, points[0].Y * scale), now;

            SolidBrush solidBrush = SolidBrush;
            float width = WidthPen;
            SolidBrush = new SolidBrush(Arrow);
            WidthPen += 3;
            PutPixelPoint(prev);
            WidthPen = width;
            SolidBrush = solidBrush;

            try
            {
                for (int i = 1; i < points.Length; i++)
                {
                    now = new PointF(points[i].X * scale, points[i].Y * scale);
                    if (i % Across == 0 && i / Across < CountArrows) DrawArrow(prev, now);
                    Gr.DrawLine(PenLine, prev, prev = now);
                }
            }
            catch { }

            PictureBox.Image = Image;
        }

        public void DrawingAllToLines(PointF[] points)
        {
            if (points == null || points.Length < 2) return;

            try
            {
                for (int i = 0; i < points.Length - 1; i++)
                {
                    Gr.DrawLine(PenLine,
                        new PointF(points[i].X * scale, points[i].Y * scale),
                        new PointF(points[i + 1].X * scale, points[i + 1].Y * scale));
                }
            }
            catch{}

            PictureBox.Image = Image;
        }

        public void Drawing(PointF[] points)
        {
            PointF[] pointsTrue = TruePoints(points);

            if (pointsTrue == null || pointsTrue.Length <= 1) return;

            float sizePlus = 2;

            PutPixel(pointsTrue[0], WidthPen + sizePlus, Begin);
            Gr.DrawCurve(PenLine, pointsTrue);
            PutPixel(pointsTrue.Last(), WidthPen + sizePlus, End);

            //PictureBox.Image = Image;
        }

        public void DrawingNull()
        {
            Matrix matr = Gr.Transform.Clone();

            Gr = Graphics.FromImage(Image = new Bitmap((int)Width, (int)Height));

            Gr.FillRectangle(new SolidBrush(Color.White), -Width, -Height, Width * 2, Height * 2);
            Gr.DrawLine(new Pen(Color.Black), new PointF(matr.Elements[4], Height), new PointF(matr.Elements[4], 0));
            Gr.DrawLine(new Pen(Color.Black), new PointF(0, matr.Elements[5]), new PointF(Width, matr.Elements[5]));

            Gr.Transform = matr;
            
            DrawingLineGrap(10);

            PictureBox.Image = Image;
        }

        public void DrawLineToScale(PointF point1, PointF point2)
        {          
            Gr.DrawLine(PenLine, PointToScale(point1), PointToScale(point2));
            PictureBox.Image = Image;
        }

        public PointF GetTruePoint(float x, float y) {
            return new PointF((x - TransformMatrix.Elements[4]) / TransformMatrix.Elements[0], (y - TransformMatrix.Elements[5]) / TransformMatrix.Elements[3]);
        }

        public PointF GetTranslatePoint(float x, float y) {
            return new PointF(x, y).Transform(TransformMatrix);
        }


        public void PutPixel(PointF p, float sizePix, Color color)
        {
            Gr.FillRectangle(new SolidBrush(color), p.X, p.Y, sizePix, sizePix);
            
            PictureBox.Image = Image;
        }

        public void PutPixelToScale(PointF p)
        {
            PutPixelPoint(new PointF(p.X * scale, p.Y * scale));
            PictureBox.Image = Image;
        }


        public void PutPixel(PointF p) {
            Matrix matr = Gr.Transform;
            Gr.Transform = new Matrix(1, 0, 0, 1, 0, 0);
            Gr.FillRectangle(new SolidBrush(Color.Blue), p.X, p.Y, 3, 3);
            Gr.Transform = matr;
        }

        public void PutPixelPoint(PointF p)
        {
            try
            {
                Gr.FillRectangle(SolidBrush, p.X, p.Y, WidthPen, WidthPen);
            }
            catch
            {
                return;
            }
        }

        public PointF PointToScale(PointF point)
        {
            return new PointF(point.X * scale, point.Y * scale);
        }

        private void DrawingLineGrap(int Step)
        {
            //float Width = this.Width / 2, Height = this.Height / 2;
            float Width0 = TransformMatrix.Elements[4], Height0 = TransformMatrix.Elements[5]
                , Width1 = Width - Width0, Height1 = Height - Height0;

            TransformMatrix = new Matrix(1, 0, 0, 1, TransformMatrix.Elements[4], TransformMatrix.Elements[5]);

            int across = 100;
            float emSize = 7.37f, lineHeight = 5, Const = 2;

            Pen pen = new Pen(Color.Black);

            for (float i = Step; i < Width1; i += Step)
            {
                if (i % across == 0)
                {
                    Gr.DrawString("" + (i / (Scale)).ToString(), new Font("Arial", emSize), Brushes.Black, new PointF(i, /*Height1*/ - 16));
                    Const = 1;
                }
                else if (i % (across / 2) == 0)
                {
                    Gr.DrawString("" + (i / (Scale)).ToString(), new Font("Arial", emSize - 1), Brushes.Black, new PointF(i, /*Height1*/ -14));
                    Const = 1.5f;
                }
                else Const = 2;
                Gr.DrawLine(pen, new PointF(i, /*Height1*/ lineHeight / Const), new PointF(i, /*Height1*/ -lineHeight / Const));
            }
            Const = 2;

            for (float i = Step; i < Width0; i += Step)
            {

                if (i % across == 0)
                {
                    Gr.DrawString("-" + (i / (Scale)).ToString(), new Font("Arial", emSize), Brushes.Black, new PointF(-i, /*Height1*/ - 16));
                    Const = 1;
                }
                else if (i % (across / 2) == 0)
                {
                    Gr.DrawString("-" + (i / (Scale)).ToString(), new Font("Arial", emSize - 1), Brushes.Black, new PointF(-i, /*Height1*/ -14));
                    Const = 1.5f;
                }
                else Const = 2;
                Gr.DrawLine(pen, new PointF(-i, /*Height1*/ lineHeight / Const), new PointF(-i, /*Height1*/ -lineHeight / Const));
            }

            Const = 2;
            for (float i = Step; i < Height0; i += Step)
            {
                if(i % across == 0)
                {
                    Const = 1;
                    Gr.DrawString("" + (i / (Scale)).ToString(), new Font("Arial", emSize), Brushes.Black, new PointF(10.7f /*- Width0*/, -i - 8));
                }
                else if (i % (across / 2) == 0)
                {
                    Gr.DrawString("" + (i / (Scale)).ToString(), new Font("Arial", emSize - 1), Brushes.Black, new PointF(8.7f /*- Width0*/, -i - 8));
                    Const = 1.5f;
                }
                else Const = 2;
                Gr.DrawLine(pen, new PointF(/*-Width0*/ lineHeight / Const, -i), new PointF(-lineHeight / Const /*- Width0*/, -i));
            }

            Const = 2;

            for (float i = Step; i < Height1; i += Step)
            {
                if(i % across == 0)
                {
                    Const = 1;
                    Gr.DrawString("-" + (i / (Scale)).ToString(), new Font("Arial", emSize), Brushes.Black, new PointF(10.7f /*- Width0*/, i - 8));
                }
                else if (i % (across / 2) == 0)
                {
                    Gr.DrawString("-" + (i / (Scale)).ToString(), new Font("Arial", emSize - 1), Brushes.Black, new PointF(8.7f /*- Width0*/, i - 8));
                    Const = 1.5f;
                }
                else Const = 2;
                Gr.DrawLine(pen, new PointF(/*-Width0*/ lineHeight / Const, i), new PointF(-lineHeight / Const /*- Width0*/, i));
            }

            Gr.DrawString("y", new Font("Arial", emSize + 3), Brushes.Black, new PointF(Width1 - 15, 5));
            Gr.DrawString("y'", new Font("Arial", emSize + 3), Brushes.Black, new PointF(-17, -Height0 - 3));
            
            Gr.DrawString("-первая точка", new Font("Arial", emSize + 1.5f), Brushes.Black, new PointF(-Width0 + 15, Height1 - 21));
            PutPixel(new PointF(-Width0 + 10, Height1 - 15), 5, Arrow);

            TransformMatrix = new Matrix(1, 0, 0, -1, TransformMatrix.Elements[4], TransformMatrix.Elements[5]);
            

            PictureBox.Image = Image;
        }
        
    }
}
