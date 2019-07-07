namespace LabSystemDif
{
    
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ImageSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Drawing = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Null = new System.Windows.Forms.Button();
            this.DirivY0 = new System.Windows.Forms.ComboBox();
            this.Stop = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Y0 = new System.Windows.Forms.ComboBox();
            this.Gamma = new System.Windows.Forms.ComboBox();
            this.Alpha = new System.Windows.Forms.ComboBox();
            this.Beta = new System.Windows.Forms.ComboBox();
            this.CountStep = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DrawLine = new System.Windows.Forms.Button();
            this.nullPoint = new System.Windows.Forms.Label();
            this.NullImage = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.LineIndex = new System.Windows.Forms.NumericUpDown();
            this.IsArrow = new System.Windows.Forms.CheckBox();
            this.LengthArrow = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Rotate = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Across = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.CountArrow = new System.Windows.Forms.ComboBox();
            this.step = new System.Windows.Forms.ComboBox();
            this.AcrossPoint = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CountPoint = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Scale = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcrossPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scale)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(11, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "нарисовать еще";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "h - шаг";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "gamma :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "beta :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "alpha :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "y0_diriv :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "y0 :";
            // 
            // ImageSave
            // 
            this.ImageSave.Location = new System.Drawing.Point(188, 391);
            this.ImageSave.Name = "ImageSave";
            this.ImageSave.Size = new System.Drawing.Size(151, 52);
            this.ImageSave.TabIndex = 62;
            this.ImageSave.Text = "Save image";
            this.ImageSave.UseVisualStyleBackColor = true;
            this.ImageSave.Click += new System.EventHandler(this.ImageSave_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.Location = new System.Drawing.Point(189, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 23);
            this.button2.TabIndex = 64;
            this.button2.Text = "сбросить масштаб";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Drawing
            // 
            this.Drawing.FormattingEnabled = true;
            this.Drawing.Items.AddRange(new object[] {
            "",
            "lines",
            "points",
            "curve"});
            this.Drawing.Location = new System.Drawing.Point(77, 194);
            this.Drawing.Name = "Drawing";
            this.Drawing.Size = new System.Drawing.Size(60, 17);
            this.Drawing.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 67;
            this.label7.Text = "рисовать по";
            // 
            // timer1
            // 
            this.timer1.Interval = 2;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Null
            // 
            this.Null.BackColor = System.Drawing.Color.LightGray;
            this.Null.Location = new System.Drawing.Point(189, 333);
            this.Null.Name = "Null";
            this.Null.Size = new System.Drawing.Size(150, 23);
            this.Null.TabIndex = 68;
            this.Null.Text = "сбросить все";
            this.Null.UseVisualStyleBackColor = false;
            this.Null.Click += new System.EventHandler(this.Null_Click);
            // 
            // DirivY0
            // 
            this.DirivY0.FormattingEnabled = true;
            this.DirivY0.Items.AddRange(new object[] {
            "0"});
            this.DirivY0.Location = new System.Drawing.Point(64, 47);
            this.DirivY0.Name = "DirivY0";
            this.DirivY0.Size = new System.Drawing.Size(60, 21);
            this.DirivY0.TabIndex = 69;
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.LightGray;
            this.Stop.Location = new System.Drawing.Point(11, 391);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(164, 23);
            this.Stop.TabIndex = 70;
            this.Stop.Text = "стоп / продолжить";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(360, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(696, 468);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDoubleClick);
            // 
            // Y0
            // 
            this.Y0.FormattingEnabled = true;
            this.Y0.Items.AddRange(new object[] {
            "0.01",
            "0.1",
            "0.5",
            "1",
            "-0.01",
            "-0.1",
            "-0.5",
            "-1"});
            this.Y0.Location = new System.Drawing.Point(64, 22);
            this.Y0.Name = "Y0";
            this.Y0.Size = new System.Drawing.Size(60, 21);
            this.Y0.TabIndex = 71;
            // 
            // Gamma
            // 
            this.Gamma.FormattingEnabled = true;
            this.Gamma.Items.AddRange(new object[] {
            "0.1",
            "0.01",
            "0.5",
            "1",
            "-0.1",
            "-0.01",
            "-0.5",
            "-1"});
            this.Gamma.Location = new System.Drawing.Point(64, 73);
            this.Gamma.Name = "Gamma";
            this.Gamma.Size = new System.Drawing.Size(60, 21);
            this.Gamma.TabIndex = 72;
            // 
            // Alpha
            // 
            this.Alpha.FormattingEnabled = true;
            this.Alpha.Items.AddRange(new object[] {
            "1",
            "-1"});
            this.Alpha.Location = new System.Drawing.Point(64, 104);
            this.Alpha.Name = "Alpha";
            this.Alpha.Size = new System.Drawing.Size(60, 21);
            this.Alpha.TabIndex = 73;
            // 
            // Beta
            // 
            this.Beta.FormattingEnabled = true;
            this.Beta.Items.AddRange(new object[] {
            "0",
            "0.01",
            "0.1",
            "1",
            "1.5",
            "2",
            "2.5"});
            this.Beta.Location = new System.Drawing.Point(64, 130);
            this.Beta.Name = "Beta";
            this.Beta.Size = new System.Drawing.Size(60, 21);
            this.Beta.TabIndex = 74;
            // 
            // CountStep
            // 
            this.CountStep.FormattingEnabled = true;
            this.CountStep.Items.AddRange(new object[] {
            "10",
            "1000"});
            this.CountStep.Location = new System.Drawing.Point(66, 98);
            this.CountStep.Name = "CountStep";
            this.CountStep.Size = new System.Drawing.Size(60, 21);
            this.CountStep.TabIndex = 75;
            this.CountStep.TextChanged += new System.EventHandler(this.CountStep_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 76;
            this.label9.Text = "скорость";
            // 
            // DrawLine
            // 
            this.DrawLine.BackColor = System.Drawing.Color.LightGray;
            this.DrawLine.Location = new System.Drawing.Point(11, 334);
            this.DrawLine.Name = "DrawLine";
            this.DrawLine.Size = new System.Drawing.Size(164, 24);
            this.DrawLine.TabIndex = 77;
            this.DrawLine.Text = "нарисовать";
            this.DrawLine.UseVisualStyleBackColor = false;
            this.DrawLine.Click += new System.EventHandler(this.DrawLine_Click);
            // 
            // nullPoint
            // 
            this.nullPoint.AutoSize = true;
            this.nullPoint.Location = new System.Drawing.Point(24, 54);
            this.nullPoint.Name = "nullPoint";
            this.nullPoint.Size = new System.Drawing.Size(0, 13);
            this.nullPoint.TabIndex = 78;
            // 
            // NullImage
            // 
            this.NullImage.BackColor = System.Drawing.Color.LightGray;
            this.NullImage.Location = new System.Drawing.Point(12, 420);
            this.NullImage.Name = "NullImage";
            this.NullImage.Size = new System.Drawing.Size(164, 23);
            this.NullImage.TabIndex = 79;
            this.NullImage.Text = "стереть";
            this.NullImage.UseVisualStyleBackColor = false;
            this.NullImage.Click += new System.EventHandler(this.NullImage_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 81;
            this.label10.Text = "линия";
            // 
            // LineIndex
            // 
            this.LineIndex.Location = new System.Drawing.Point(67, 72);
            this.LineIndex.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.LineIndex.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.LineIndex.Name = "LineIndex";
            this.LineIndex.Size = new System.Drawing.Size(60, 20);
            this.LineIndex.TabIndex = 82;
            this.LineIndex.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.LineIndex.ValueChanged += new System.EventHandler(this.LineIndex_ValueChanged);
            // 
            // IsArrow
            // 
            this.IsArrow.AutoSize = true;
            this.IsArrow.Location = new System.Drawing.Point(15, 31);
            this.IsArrow.Name = "IsArrow";
            this.IsArrow.Size = new System.Drawing.Size(73, 17);
            this.IsArrow.TabIndex = 84;
            this.IsArrow.Text = "рисовать";
            this.IsArrow.UseVisualStyleBackColor = true;
            // 
            // LengthArrow
            // 
            this.LengthArrow.FormattingEnabled = true;
            this.LengthArrow.Items.AddRange(new object[] {
            "15"});
            this.LengthArrow.Location = new System.Drawing.Point(146, 42);
            this.LengthArrow.Name = "LengthArrow";
            this.LengthArrow.Size = new System.Drawing.Size(55, 21);
            this.LengthArrow.TabIndex = 85;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(79, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 86;
            this.label11.Text = "продольная";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(207, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 88;
            this.label12.Text = "поперечная";
            // 
            // Rotate
            // 
            this.Rotate.FormattingEnabled = true;
            this.Rotate.Items.AddRange(new object[] {
            "20"});
            this.Rotate.Location = new System.Drawing.Point(281, 42);
            this.Rotate.Name = "Rotate";
            this.Rotate.Size = new System.Drawing.Size(55, 21);
            this.Rotate.TabIndex = 87;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(92, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 90;
            this.label13.Text = "интервал";
            // 
            // Across
            // 
            this.Across.FormattingEnabled = true;
            this.Across.Items.AddRange(new object[] {
            "1000"});
            this.Across.Location = new System.Drawing.Point(146, 16);
            this.Across.Name = "Across";
            this.Across.Size = new System.Drawing.Size(55, 21);
            this.Across.TabIndex = 89;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(204, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 92;
            this.label14.Text = "колличество";
            // 
            // CountArrow
            // 
            this.CountArrow.FormattingEnabled = true;
            this.CountArrow.Items.AddRange(new object[] {
            "10"});
            this.CountArrow.Location = new System.Drawing.Point(281, 16);
            this.CountArrow.Name = "CountArrow";
            this.CountArrow.Size = new System.Drawing.Size(55, 21);
            this.CountArrow.TabIndex = 91;
            // 
            // step
            // 
            this.step.FormattingEnabled = true;
            this.step.Items.AddRange(new object[] {
            "0.005",
            "0.000005"});
            this.step.Location = new System.Drawing.Point(64, 157);
            this.step.Name = "step";
            this.step.Size = new System.Drawing.Size(60, 21);
            this.step.TabIndex = 96;
            // 
            // AcrossPoint
            // 
            this.AcrossPoint.Location = new System.Drawing.Point(261, 266);
            this.AcrossPoint.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.AcrossPoint.Name = "AcrossPoint";
            this.AcrossPoint.Size = new System.Drawing.Size(59, 20);
            this.AcrossPoint.TabIndex = 99;
            this.AcrossPoint.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AcrossPoint.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(210, 268);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 100;
            this.label16.Text = "across";
            this.label16.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "колличестов точек";
            // 
            // CountPoint
            // 
            this.CountPoint.Location = new System.Drawing.Point(67, 46);
            this.CountPoint.Name = "CountPoint";
            this.CountPoint.Size = new System.Drawing.Size(59, 20);
            this.CountPoint.TabIndex = 36;
            this.CountPoint.Text = "1000";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 127);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 94;
            this.label15.Text = "масштаб";
            // 
            // Scale
            // 
            this.Scale.Location = new System.Drawing.Point(67, 125);
            this.Scale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Scale.Name = "Scale";
            this.Scale.Size = new System.Drawing.Size(59, 20);
            this.Scale.TabIndex = 95;
            this.Scale.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Across);
            this.groupBox1.Controls.Add(this.LengthArrow);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.Rotate);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.CountArrow);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.IsArrow);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 78);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "параметры стрелки";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Y0);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.step);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.DirivY0);
            this.groupBox2.Controls.Add(this.Gamma);
            this.groupBox2.Controls.Add(this.Alpha);
            this.groupBox2.Controls.Add(this.Beta);
            this.groupBox2.Controls.Add(this.Drawing);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(11, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 222);
            this.groupBox2.TabIndex = 102;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "параметры новой линии";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LineIndex);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.CountStep);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.Scale);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.CountPoint);
            this.groupBox3.Location = new System.Drawing.Point(201, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(138, 160);
            this.groupBox3.TabIndex = 103;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "параметры линий";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 475);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.AcrossPoint);
            this.Controls.Add(this.NullImage);
            this.Controls.Add(this.nullPoint);
            this.Controls.Add(this.DrawLine);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Null);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ImageSave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcrossPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scale)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ImageSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox Drawing;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Null;
        private System.Windows.Forms.ComboBox DirivY0;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox Y0;
        private System.Windows.Forms.ComboBox Gamma;
        private System.Windows.Forms.ComboBox Alpha;
        private System.Windows.Forms.ComboBox Beta;
        private System.Windows.Forms.ComboBox CountStep;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button DrawLine;
        private System.Windows.Forms.Label nullPoint;
        private System.Windows.Forms.Button NullImage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown LineIndex;
        private System.Windows.Forms.CheckBox IsArrow;
        private System.Windows.Forms.ComboBox LengthArrow;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox Rotate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox Across;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox CountArrow;
        private System.Windows.Forms.ComboBox step;
        private System.Windows.Forms.NumericUpDown AcrossPoint;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CountPoint;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown Scale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

