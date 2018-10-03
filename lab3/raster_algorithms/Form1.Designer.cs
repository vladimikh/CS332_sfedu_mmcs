namespace raster_algorithms
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chooseColorBtn = new System.Windows.Forms.Button();
            this.chooseImageBtn = new System.Windows.Forms.Button();
            this.radioPen = new System.Windows.Forms.RadioButton();
            this.radioFillColor = new System.Windows.Forms.RadioButton();
            this.radioFillTexture = new System.Windows.Forms.RadioButton();
            this.fillColorPan = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioSelectBorder = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chooseBorderColorBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.borderColorPan = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(829, 510);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // chooseColorBtn
            // 
            this.chooseColorBtn.Location = new System.Drawing.Point(7, 59);
            this.chooseColorBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chooseColorBtn.Name = "chooseColorBtn";
            this.chooseColorBtn.Size = new System.Drawing.Size(145, 32);
            this.chooseColorBtn.TabIndex = 1;
            this.chooseColorBtn.Text = "Цвет заливки";
            this.chooseColorBtn.UseVisualStyleBackColor = true;
            this.chooseColorBtn.Click += new System.EventHandler(this.chooseColorBtn_Click);
            // 
            // chooseImageBtn
            // 
            this.chooseImageBtn.Location = new System.Drawing.Point(7, 96);
            this.chooseImageBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chooseImageBtn.Name = "chooseImageBtn";
            this.chooseImageBtn.Size = new System.Drawing.Size(145, 32);
            this.chooseImageBtn.TabIndex = 2;
            this.chooseImageBtn.Text = "Текстура";
            this.chooseImageBtn.UseVisualStyleBackColor = true;
            this.chooseImageBtn.Click += new System.EventHandler(this.chooseImageBtn_Click);
            // 
            // radioPen
            // 
            this.radioPen.AutoSize = true;
            this.radioPen.Location = new System.Drawing.Point(8, 23);
            this.radioPen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioPen.Name = "radioPen";
            this.radioPen.Size = new System.Drawing.Size(97, 21);
            this.radioPen.TabIndex = 8;
            this.radioPen.Text = "Карандаш";
            this.radioPen.UseVisualStyleBackColor = true;
            this.radioPen.CheckedChanged += new System.EventHandler(this.radioPen_CheckedChanged);
            // 
            // radioFillColor
            // 
            this.radioFillColor.AutoSize = true;
            this.radioFillColor.Location = new System.Drawing.Point(8, 52);
            this.radioFillColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioFillColor.Name = "radioFillColor";
            this.radioFillColor.Size = new System.Drawing.Size(135, 21);
            this.radioFillColor.TabIndex = 9;
            this.radioFillColor.Text = "Заливка цветом";
            this.radioFillColor.UseVisualStyleBackColor = true;
            // 
            // radioFillTexture
            // 
            this.radioFillTexture.AutoSize = true;
            this.radioFillTexture.Location = new System.Drawing.Point(8, 81);
            this.radioFillTexture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioFillTexture.Name = "radioFillTexture";
            this.radioFillTexture.Size = new System.Drawing.Size(155, 21);
            this.radioFillTexture.TabIndex = 10;
            this.radioFillTexture.Text = "Заливка текстурой";
            this.radioFillTexture.UseVisualStyleBackColor = true;
            // 
            // fillColorPan
            // 
            this.fillColorPan.BackColor = System.Drawing.Color.Black;
            this.fillColorPan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fillColorPan.Location = new System.Drawing.Point(159, 59);
            this.fillColorPan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fillColorPan.Name = "fillColorPan";
            this.fillColorPan.Size = new System.Drawing.Size(33, 31);
            this.fillColorPan.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioSelectBorder);
            this.groupBox1.Controls.Add(this.radioPen);
            this.groupBox1.Controls.Add(this.radioFillColor);
            this.groupBox1.Controls.Add(this.radioFillTexture);
            this.groupBox1.Location = new System.Drawing.Point(853, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(205, 145);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // radioSelectBorder
            // 
            this.radioSelectBorder.AutoSize = true;
            this.radioSelectBorder.Location = new System.Drawing.Point(8, 110);
            this.radioSelectBorder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioSelectBorder.Name = "radioSelectBorder";
            this.radioSelectBorder.Size = new System.Drawing.Size(163, 21);
            this.radioSelectBorder.TabIndex = 11;
            this.radioSelectBorder.TabStop = true;
            this.radioSelectBorder.Text = "Выделение границы";
            this.radioSelectBorder.UseVisualStyleBackColor = true;
            this.radioSelectBorder.CheckedChanged += new System.EventHandler(this.radioSelectBorder_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chooseBorderColorBtn);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.borderColorPan);
            this.groupBox2.Controls.Add(this.chooseColorBtn);
            this.groupBox2.Controls.Add(this.chooseImageBtn);
            this.groupBox2.Controls.Add(this.fillColorPan);
            this.groupBox2.Location = new System.Drawing.Point(853, 167);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(205, 145);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // chooseBorderColorBtn
            // 
            this.chooseBorderColorBtn.Location = new System.Drawing.Point(7, 22);
            this.chooseBorderColorBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chooseBorderColorBtn.Name = "chooseBorderColorBtn";
            this.chooseBorderColorBtn.Size = new System.Drawing.Size(145, 32);
            this.chooseBorderColorBtn.TabIndex = 12;
            this.chooseBorderColorBtn.Text = "Цвет границы";
            this.chooseBorderColorBtn.UseVisualStyleBackColor = true;
            this.chooseBorderColorBtn.Click += new System.EventHandler(this.chooseBorderColorBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(159, 96);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // borderColorPan
            // 
            this.borderColorPan.BackColor = System.Drawing.Color.Black;
            this.borderColorPan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.borderColorPan.Location = new System.Drawing.Point(159, 22);
            this.borderColorPan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.borderColorPan.Name = "borderColorPan";
            this.borderColorPan.Size = new System.Drawing.Size(33, 31);
            this.borderColorPan.TabIndex = 13;
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Location = new System.Drawing.Point(944, 490);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(108, 28);
            this.clearButton.TabIndex = 16;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 533);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Растровые алгоритмы";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button chooseColorBtn;
        private System.Windows.Forms.Button chooseImageBtn;
        private System.Windows.Forms.RadioButton radioPen;
        private System.Windows.Forms.RadioButton radioFillColor;
        private System.Windows.Forms.RadioButton radioFillTexture;
        private System.Windows.Forms.Panel fillColorPan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button chooseBorderColorBtn;
        private System.Windows.Forms.Panel borderColorPan;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.RadioButton radioSelectBorder;
    }
}

