using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace LabSystemDif
{
    public partial class Form : System.Windows.Forms.Form
    {
        Controller Controller;
        int i = 0;

        public Form()
        {
            InitializeComponent();         

            Graphics gr = Graphics.FromHwnd(pictureBox1.Handle);
            Controller = new Controller(new DrawingLine(Color.DarkGreen, pictureBox1, 1, Color.Red, Color.Blue, 1));
        }

        private void NewLine()
        {
            try
            {
                float Y, derivY, stepH, gamma, alpha, beta;
                int iter;

                Y = float.Parse(Y0.Text);
                derivY = float.Parse(DirivY0.Text);
                alpha = float.Parse(Alpha.Text);
                beta = float.Parse(Beta.Text);
                gamma = float.Parse(Gamma.Text);


                iter = int.Parse(CountPoint.Text);
                stepH = float.Parse(step.Text);

                nullPoint.Text = new PointF(Y, derivY).ToString();

                Func<float, float, float, float>
                    dirivX = (t, x, y) => y,
                    dirivY = (t, x, y) =>
                        alpha * (float)(Math.Sign(y) * Math.Pow(Math.Abs(y), beta)) - x - gamma * y;                

                if (Drawing.Text == null || Drawing.Text == "")
                    Controller.Main(iter, new PointF(Y, derivY), stepH, dirivX, dirivY);
                else
                {
                    Controller.Main(iter, new PointF(Y, derivY), stepH, dirivX, dirivY, Drawing.Text, IsArrow.Checked, (int)AcrossPoint.Value);
                    if (IsArrow.Checked)
                    {
                        if (LengthArrow.Text != "") Controller.Drawing.LengthArrow = float.Parse(LengthArrow.Text);
                        if (CountArrow.Text != "") Controller.Drawing.CountArrows = float.Parse(CountArrow.Text);
                        if (Rotate.Text != "") Controller.Drawing.RotateArrow = float.Parse(Rotate.Text);
                        if (Across.Text != "") Controller.Drawing.Across = float.Parse(Across.Text);
                    }
                    Controller.CountStep = int.Parse(CountStep.Text);

                    timer1.Start();
                }

                LineIndex.Maximum++;
                LineIndex.Value = LineIndex.Maximum - 1;

            }
            catch
            {
                MessageBox.Show("ошибка ввода!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewLine();
        }


        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                Controller.MainTransleteCenterAndScaleMult((float)Scale.Value, e.X, e.Y);
            }
            else {
                Controller.MainTransleteCenterAndScaleDivd((float)Scale.Value, e.X, e.Y);
            }
        }


        private void ImageSave_Click(object sender, EventArgs e)
        {
            Image saveImage = pictureBox1.Image;          

            if (saveImage != null) //если в pictureBox есть изображение
            {
                //создание диалогового окна "Сохранить как..", для сохранения изображения
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить картинку как...";
                //отображать ли предупреждение, если пользователь указывает имя уже существующего файла
                savedialog.OverwritePrompt = true;
                //отображать ли предупреждение, если пользователь указывает несуществующий путь
                savedialog.CheckPathExists = true;
                //список форматов файла, отображаемый в поле "Тип файла"
                savedialog.Filter = "Image Files(*.JPG)|*.JPG";
                //отображается ли кнопка "Справка" в диалоговом окне
                savedialog.ShowHelp = true;
                if (savedialog.ShowDialog() == DialogResult.OK) //если в диалоговом окне нажата кнопка "ОК"
                {
                    try
                    {
                        saveImage.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else {
                MessageBox.Show("Нет изображения!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Controller.MainNullScale();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                //if (IsCountToStop.Checked && i > countToStop.Value) return;
                Controller.Draw();

                /*if (IsCountToStop.Checked) i++;
                else i = 0;*/
            }
            catch
            {
                timer1.Stop();
            }
        }

        private void Null_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Controller.MainNull();
            Controller = new Controller(new DrawingLine(Color.DarkGreen, pictureBox1, 1, Color.Red, Color.Blue, 1));

            LineIndex.ValueChanged -= LineIndex_ValueChanged; 
            LineIndex.Value = -1;
            LineIndex.Maximum = 0;
            LineIndex.ValueChanged += LineIndex_ValueChanged;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if (!Controller.IsInit) return;
            
            timer1.Enabled = !timer1.Enabled;
        }

        private void CountStep_TextChanged(object sender, EventArgs e)
        {
            try
            {
               if (Controller != null) Controller.CountStep = int.Parse(CountStep.Text);
            }
            catch
            {
                MessageBox.Show("ошибка ввода!");
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            PointF point = Controller.Drawing.TruePoint(e.X, e.Y);
            Y0.Text = point.X.ToString();
            DirivY0.Text = point.Y.ToString();
        }

        private void DrawLine_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            Controller.Drawing.DrawingNull();

            Controller = new Controller(new DrawingLine(Color.DarkGreen, pictureBox1, 1, Color.Red, Color.Blue, 1));

            LineIndex.ValueChanged -= LineIndex_ValueChanged;
            LineIndex.Value = -1;
            LineIndex.Maximum = 0;
            LineIndex.ValueChanged += LineIndex_ValueChanged;

            NewLine();
        }

        private void NullImage_Click(object sender, EventArgs e)
        {
            Controller.Drawing.DrawingNull();
            Controller.Lines.NullLines();
        }

        private void LineIndex_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Controller.IndexLine = (int)LineIndex.Value;
                nullPoint.Text = Controller.Lines[Controller.IndexLine].Method.NullPoint.ToString();
            }
            catch
            {
                MessageBox.Show("ошибка ввода!");
            }
        }
    }
}
