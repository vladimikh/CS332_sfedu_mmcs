namespace affine_transform
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label13 = new System.Windows.Forms.Label();
            this.intersectionTb = new System.Windows.Forms.TextBox();
            this.intersectionBtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rotateAroundPointCb = new System.Windows.Forms.CheckBox();
            this.chosenPointTb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ninetyDegBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.applyBtn = new System.Windows.Forms.Button();
            this.polyChk = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lineChk = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 78);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "Положение точки";
            // 
            // intersectionTb
            // 
            this.intersectionTb.Location = new System.Drawing.Point(12, 41);
            this.intersectionTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.intersectionTb.Name = "intersectionTb";
            this.intersectionTb.ReadOnly = true;
            this.intersectionTb.Size = new System.Drawing.Size(155, 22);
            this.intersectionTb.TabIndex = 28;
            this.intersectionTb.Text = "Неизвестно";
            // 
            // intersectionBtn
            // 
            this.intersectionBtn.Location = new System.Drawing.Point(12, 80);
            this.intersectionBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.intersectionBtn.Name = "intersectionBtn";
            this.intersectionBtn.Size = new System.Drawing.Size(156, 37);
            this.intersectionBtn.TabIndex = 27;
            this.intersectionBtn.Text = "Найти";
            this.intersectionBtn.UseVisualStyleBackColor = true;
            this.intersectionBtn.Click += new System.EventHandler(this.intersectionBtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 22);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Точка пересечения";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 102);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Принадлежность полигону";
            // 
            // rotateAroundPointCb
            // 
            this.rotateAroundPointCb.AutoSize = true;
            this.rotateAroundPointCb.Location = new System.Drawing.Point(377, 46);
            this.rotateAroundPointCb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rotateAroundPointCb.Name = "rotateAroundPointCb";
            this.rotateAroundPointCb.Size = new System.Drawing.Size(116, 21);
            this.rotateAroundPointCb.TabIndex = 23;
            this.rotateAroundPointCb.Text = "Вокруг точки";
            this.rotateAroundPointCb.UseVisualStyleBackColor = true;
            // 
            // chosenPointTb
            // 
            this.chosenPointTb.Location = new System.Drawing.Point(12, 41);
            this.chosenPointTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chosenPointTb.Name = "chosenPointTb";
            this.chosenPointTb.ReadOnly = true;
            this.chosenPointTb.Size = new System.Drawing.Size(132, 22);
            this.chosenPointTb.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 22);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Выбранная точка";
            // 
            // ninetyDegBtn
            // 
            this.ninetyDegBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ninetyDegBtn.Location = new System.Drawing.Point(335, 42);
            this.ninetyDegBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ninetyDegBtn.Name = "ninetyDegBtn";
            this.ninetyDegBtn.Size = new System.Drawing.Size(36, 25);
            this.ninetyDegBtn.TabIndex = 20;
            this.ninetyDegBtn.Text = "90";
            this.ninetyDegBtn.UseVisualStyleBackColor = true;
            this.ninetyDegBtn.Click += new System.EventHandler(this.ninetyDegBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(123, 92);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(123, 44);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Поворот";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Масштаб %";
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(375, 81);
            this.applyBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(120, 37);
            this.applyBtn.TabIndex = 11;
            this.applyBtn.Text = "Применить";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // polyChk
            // 
            this.polyChk.Appearance = System.Windows.Forms.Appearance.Button;
            this.polyChk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("polyChk.BackgroundImage")));
            this.polyChk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.polyChk.Location = new System.Drawing.Point(69, 23);
            this.polyChk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.polyChk.Name = "polyChk";
            this.polyChk.Size = new System.Drawing.Size(53, 49);
            this.polyChk.TabIndex = 5;
            this.polyChk.UseVisualStyleBackColor = true;
            this.polyChk.CheckedChanged += new System.EventHandler(this.polyChk_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Смещение";
            // 
            // lineChk
            // 
            this.lineChk.Appearance = System.Windows.Forms.Appearance.Button;
            this.lineChk.BackgroundImage = global::affine_transform.Properties.Resources.icons8_Line2_96;
            this.lineChk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lineChk.Location = new System.Drawing.Point(8, 23);
            this.lineChk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lineChk.Name = "lineChk";
            this.lineChk.Size = new System.Drawing.Size(53, 49);
            this.lineChk.TabIndex = 4;
            this.lineChk.UseVisualStyleBackColor = true;
            this.lineChk.CheckedChanged += new System.EventHandler(this.lineChk_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 80);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 175);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1115, 553);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lineChk);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.polyChk);
            this.groupBox2.Location = new System.Drawing.Point(16, 33);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(133, 134);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ResetBtn);
            this.groupBox3.Controls.Add(this.numericUpDown5);
            this.groupBox3.Controls.Add(this.numericUpDown4);
            this.groupBox3.Controls.Add(this.numericUpDown3);
            this.groupBox3.Controls.Add(this.numericUpDown2);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.applyBtn);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.rotateAroundPointCb);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.ninetyDegBtn);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(157, 33);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(507, 134);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(247, 81);
            this.ResetBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(120, 37);
            this.ResetBtn.TabIndex = 24;
            this.ResetBtn.Text = "Сброс";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(247, 42);
            this.numericUpDown5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDown5.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(80, 22);
            this.numericUpDown5.TabIndex = 4;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(149, 90);
            this.numericUpDown4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(80, 22);
            this.numericUpDown4.TabIndex = 3;
            this.numericUpDown4.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(149, 42);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(80, 22);
            this.numericUpDown3.TabIndex = 2;
            this.numericUpDown3.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(35, 90);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(80, 22);
            this.numericUpDown2.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(35, 42);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 22);
            this.numericUpDown1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.intersectionBtn);
            this.groupBox4.Controls.Add(this.intersectionTb);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(680, 33);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(183, 134);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chosenPointTb);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(871, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(260, 134);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 742);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1155, 779);
            this.Name = "Form1";
            this.Text = "Аффинные преобразования";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox lineChk;
		private System.Windows.Forms.CheckBox polyChk;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ninetyDegBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox chosenPointTb;
        private System.Windows.Forms.CheckBox rotateAroundPointCb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox intersectionTb;
        private System.Windows.Forms.Button intersectionBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

