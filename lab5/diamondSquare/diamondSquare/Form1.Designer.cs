namespace diamondSquare
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roughnessTb = new System.Windows.Forms.TextBox();
            this.roughnessBtn = new System.Windows.Forms.Button();
            this.generateBtn = new System.Windows.Forms.Button();
            this.x1HeightTb = new System.Windows.Forms.TextBox();
            this.x2HeightTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(96, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // roughnessTb
            // 
            this.roughnessTb.Location = new System.Drawing.Point(512, 556);
            this.roughnessTb.Name = "roughnessTb";
            this.roughnessTb.Size = new System.Drawing.Size(133, 22);
            this.roughnessTb.TabIndex = 1;
            this.roughnessTb.Text = "1";
            this.roughnessTb.TextChanged += new System.EventHandler(this.roughnessTb_TextChanged);
            // 
            // roughnessBtn
            // 
            this.roughnessBtn.Location = new System.Drawing.Point(512, 601);
            this.roughnessBtn.Name = "roughnessBtn";
            this.roughnessBtn.Size = new System.Drawing.Size(133, 30);
            this.roughnessBtn.TabIndex = 2;
            this.roughnessBtn.Text = "Apply roughness";
            this.roughnessBtn.UseVisualStyleBackColor = true;
            this.roughnessBtn.Click += new System.EventHandler(this.roughnessBtn_Click);
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(22, 556);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(177, 70);
            this.generateBtn.TabIndex = 4;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // x1HeightTb
            // 
            this.x1HeightTb.Location = new System.Drawing.Point(362, 555);
            this.x1HeightTb.Name = "x1HeightTb";
            this.x1HeightTb.Size = new System.Drawing.Size(94, 22);
            this.x1HeightTb.TabIndex = 5;
            this.x1HeightTb.Text = "0";
            this.x1HeightTb.TextChanged += new System.EventHandler(this.x1HeightTb_TextChanged);
            // 
            // x2HeightTb
            // 
            this.x2HeightTb.Location = new System.Drawing.Point(362, 609);
            this.x2HeightTb.Name = "x2HeightTb";
            this.x2HeightTb.Size = new System.Drawing.Size(94, 22);
            this.x2HeightTb.TabIndex = 6;
            this.x2HeightTb.Text = "0";
            this.x2HeightTb.TextChanged += new System.EventHandler(this.x2HeightTb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 555);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "x1 height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 609);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "x2 height";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 666);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.x2HeightTb);
            this.Controls.Add(this.x1HeightTb);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.roughnessBtn);
            this.Controls.Add(this.roughnessTb);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox roughnessTb;
        private System.Windows.Forms.Button roughnessBtn;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.TextBox x1HeightTb;
        private System.Windows.Forms.TextBox x2HeightTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

