using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace color_space_conversion
{
    public partial class Form1 : Form
    {
        //Graphics g1, g2;
        PictureBox pictureBoxCurrent;
		Image picture1b, picture2b;
		int Hue1 = 0;
        int Sat1 = 0;
        int Val1 = 0;
		int Hue2 = 0;
		int Sat2= 0;
		int Val2 = 0;

		public Form1()
        {
            InitializeComponent();
            DisableControls();
            splitContainer1.SplitterDistance = splitContainer1.Width / 2;
            btnMoveLeft.Enabled = false;
            btnMoveRight.Enabled = false;
            radioButton1.Checked = true;
            pictureBoxCurrent = pictureBox1;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bmp = new Bitmap(open.FileName);
                    pictureBoxCurrent.Image = bmp;

					pictureBoxCurrentBackup();

					if (radioButton1.Checked)
                    {
                        btnMoveRight.Enabled = true;
                        //g1 = Graphics.FromImage(pictureBox1.Image);
                    }
                    else
                    {
                        btnMoveLeft.Enabled = true;
                        //g2 = Graphics.FromImage(pictureBox2.Image);
                    }
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
            EnableControls();
            refreshHistogram();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxCurrent.Image != null)
            {
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить как...";
                //отображать ли предупреждение, если пользователь указывает имя уже существующего файла
                savedialog.OverwritePrompt = true;
                //отображать ли предупреждение, если пользователь указывает несуществующий путь
                savedialog.CheckPathExists = true;
                //список форматов файла, отображаемый в поле "Тип файла"
                savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                //отображается ли кнопка "Справка" в диалоговом окне
                savedialog.ShowHelp = true;
                if (savedialog.ShowDialog() == DialogResult.OK) //если в диалоговом окне нажата кнопка "ОК"
                {
                    try
                    {
                        pictureBoxCurrent.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

		private void pictureBox1Backup()
		{
			picture1b = (Image)pictureBox1.Image.Clone();
		}

		private void pictureBox2Backup()
		{
			picture2b = (Image)pictureBox2.Image.Clone();
		}

		private void pictureBoxCurrentBackup()
		{
			if (radioButton1.Checked)
				picture1b = (Image)pictureBoxCurrent.Image.Clone();
			else
				picture2b = (Image)pictureBoxCurrent.Image.Clone();
		}

		private void pictureBoxCurrentLoad()
		{
			if (radioButton1.Checked)
				pictureBoxCurrent.Image = (Image)picture1b.Clone();
			else
				pictureBoxCurrent.Image = (Image)picture2b.Clone();
		}

		private void refreshHistogram()
        {
            chartRGB.Series[0].Points.Clear();
            chartRGB.Series[1].Points.Clear();
            chartRGB.Series[2].Points.Clear();
            chartRGB.Series[3].Points.Clear();

            if (pictureBoxCurrent.Image != null)
            {
                for (int i = 0; i < 256; i++)
                {
                    chartRGB.Series[0].Points.Add(0);
                    chartRGB.Series[1].Points.Add(0);
                    chartRGB.Series[2].Points.Add(0);
                    chartRGB.Series[3].Points.Add(0);
                }

                Bitmap bmp = pictureBoxCurrent.Image as Bitmap;

                // Lock the bitmap's bits. 
                Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                System.Drawing.Imaging.BitmapData bmpData =
                    bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                    bmp.PixelFormat);

                // Get the address of the first line.
                IntPtr ptr = bmpData.Scan0;

                // Declare an array to hold the bytes of the bitmap.
                int bytes = Math.Abs(bmpData.Stride) * bmp.Height;
                byte[] rgbValues = new byte[bytes];

                // Copy the RGB values into the array.
                System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

                // Set every third value to 255. A 24bpp bitmap will look red.  
                for (int i = 0; i < rgbValues.Length; i += 3)
                {
                    int avg = (rgbValues[i + 0] + rgbValues[i + 1] + rgbValues[i + 2]) / 3;
                    chartRGB.Series[0].Points[avg].YValues[0] += 1;
                    chartRGB.Series[1].Points[rgbValues[i + 2]].YValues[0] += 1;
                    chartRGB.Series[2].Points[rgbValues[i + 1]].YValues[0] += 1;
                    chartRGB.Series[3].Points[rgbValues[i + 0]].YValues[0] += 1;
                }
                chartRGB.Series[1].Points[0].YValues[0] = 0;
                chartRGB.Series[2].Points[0].YValues[0] = 0;
                chartRGB.Series[3].Points[0].YValues[0] = 0;

                // Unlock the bits.
                bmp.UnlockBits(bmpData);

                pictureBoxCurrent.Refresh();
            }
        }

        private void EnableControls()
        {
            groupBox1.Enabled = true;
            groupBoxHSV.Enabled = true;
            groupBox3.Enabled = true;
        }

        private void DisableControls()
        {
            groupBox1.Enabled = false;
            groupBoxHSV.Enabled = false;
            groupBox3.Enabled = false;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            if (pictureBoxCurrent.Image != null)
            {
                Bitmap bmp = pictureBoxCurrent.Image as Bitmap;

                // Lock the bitmap's bits. 
                Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                System.Drawing.Imaging.BitmapData bmpData =
                    bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                    bmp.PixelFormat);

                // Get the address of the first line.
                IntPtr ptr = bmpData.Scan0;

                // Declare an array to hold the bytes of the bitmap.
                int bytes = Math.Abs(bmpData.Stride) * bmp.Height;
                byte[] rgbValues = new byte[bytes];

                // Copy the RGB values into the array.
                System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

                // Set every third value to 255. A 24bpp bitmap will look red.  
                for (int i = 0; i < rgbValues.Length; i += 3)
                {
                    rgbValues[i + 0] = 0;
                    rgbValues[i + 1] = 0;
                }
                // Copy the RGB values back to the bitmap
                System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);

                // Unlock the bits.
                bmp.UnlockBits(bmpData);

				pictureBoxCurrentBackup();
				pictureBoxCurrent.Refresh();
                refreshHistogram();
            }
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            if (pictureBoxCurrent.Image != null)
            {
                Bitmap bmp = pictureBoxCurrent.Image as Bitmap;

                // Lock the bitmap's bits. 
                Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                System.Drawing.Imaging.BitmapData bmpData =
                    bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                    bmp.PixelFormat);

                // Get the address of the first line.
                IntPtr ptr = bmpData.Scan0;

                // Declare an array to hold the bytes of the bitmap.
                int bytes = Math.Abs(bmpData.Stride) * bmp.Height;
                byte[] rgbValues = new byte[bytes];

                // Copy the RGB values into the array.
                System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

                // Set every third value to 255. A 24bpp bitmap will look red.  
                for (int i = 0; i < rgbValues.Length; i += 3)
                {
                    rgbValues[i + 0] = 0;
                    rgbValues[i + 2] = 0;
                }
                // Copy the RGB values back to the bitmap
                System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);

                // Unlock the bits.
                bmp.UnlockBits(bmpData);

				pictureBoxCurrentBackup();
                pictureBoxCurrent.Refresh();
				refreshHistogram();
            }
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            if (pictureBoxCurrent.Image != null)
            {
                Bitmap bmp = pictureBoxCurrent.Image as Bitmap;

                // Lock the bitmap's bits. 
                Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                System.Drawing.Imaging.BitmapData bmpData =
                    bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                    bmp.PixelFormat);

                // Get the address of the first line.
                IntPtr ptr = bmpData.Scan0;

                // Declare an array to hold the bytes of the bitmap.
                int bytes = Math.Abs(bmpData.Stride) * bmp.Height;
                byte[] rgbValues = new byte[bytes];

                // Copy the RGB values into the array.
                System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

                // Set every third value to 255. A 24bpp bitmap will look red.  
                for (int i = 0; i < rgbValues.Length; i += 3)
                {
                    rgbValues[i + 1] = 0;
                    rgbValues[i + 2] = 0;
                }
                // Copy the RGB values back to the bitmap
                System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);

                // Unlock the bits.
                bmp.UnlockBits(bmpData);

				pictureBoxCurrentBackup();
                pictureBoxCurrent.Refresh();
				refreshHistogram();
            }
        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox2.Image = (Image)pictureBox1.Image.Clone();
				//g2 = Graphics.FromImage(pictureBox2.Image);
				pictureBox2Backup();
                pictureBox2.Refresh();
                refreshHistogram();
                btnMoveLeft.Enabled = true;
            }
        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
            {
                pictureBox1.Image = (Image)pictureBox2.Image.Clone();
				//g1 = Graphics.FromImage(pictureBox1.Image);
				pictureBox1Backup();
                pictureBox1.Refresh();
                refreshHistogram();
                btnMoveRight.Enabled = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                pictureBoxCurrent = pictureBox1;
                radioButton2.Checked = false;

				trackBarHue.Value = Hue1;
				trackBarSat.Value = Sat1;
				trackBarVal.Value = Val1;

				refreshHistogram();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                pictureBoxCurrent = pictureBox2;
                radioButton1.Checked = false;

				trackBarHue.Value = Hue2;
				trackBarSat.Value = Sat2;
				trackBarVal.Value = Val2;

				refreshHistogram();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
			if (pictureBox1.Image == null)
				openToolStripMenuItem_Click(sender, e);
		}

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
			if (pictureBox2.Image == null)
				openToolStripMenuItem_Click(sender, e);
		}

        private void btnBW1_Click(object sender, EventArgs e)
        {
            if (pictureBoxCurrent.Image != null)
            {
                Bitmap bmp = pictureBoxCurrent.Image as Bitmap;

                // Lock the bitmap's bits. 
                Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                System.Drawing.Imaging.BitmapData bmpData =
                    bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                    bmp.PixelFormat);

                // Get the address of the first line.
                IntPtr ptr = bmpData.Scan0;

                // Declare an array to hold the bytes of the bitmap.
                int bytes = Math.Abs(bmpData.Stride) * bmp.Height;
                byte[] rgbValues = new byte[bytes];

                // Copy the RGB values into the array.
                System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

                // Set every third value to 255. A 24bpp bitmap will look red.  
                for (int i = 0; i < rgbValues.Length; i += 3)
                {
                    int avg = (rgbValues[i + 0] + rgbValues[i + 1] + rgbValues[i + 2]) / 3;
                    rgbValues[i + 0] = (byte)avg;
                    rgbValues[i + 1] = (byte)avg;
                    rgbValues[i + 2] = (byte)avg;
                }
                // Copy the RGB values back to the bitmap
                System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);

                // Unlock the bits.
                bmp.UnlockBits(bmpData);

				pictureBoxCurrentBackup();
                pictureBoxCurrent.Refresh();
				refreshHistogram();
            }
        }

        private void btnBW2_Click(object sender, EventArgs e)
        {
            if (pictureBoxCurrent.Image != null)
            {
                Bitmap bmp = pictureBoxCurrent.Image as Bitmap;

                // Lock the bitmap's bits. 
                Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                System.Drawing.Imaging.BitmapData bmpData =
                    bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                    bmp.PixelFormat);

                // Get the address of the first line.
                IntPtr ptr = bmpData.Scan0;

                // Declare an array to hold the bytes of the bitmap.
                int bytes = Math.Abs(bmpData.Stride) * bmp.Height;
                byte[] rgbValues = new byte[bytes];

                // Copy the RGB values into the array.
                System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

                // Set every third value to 255. A 24bpp bitmap will look red.  
                for (int i = 0; i < rgbValues.Length; i += 3)
                {
                    int gray = Convert.ToInt32(0.0722 * rgbValues[i + 0] + 0.7152 * rgbValues[i + 1] + 0.2126 * rgbValues[i + 2]);
                    rgbValues[i + 0] = (byte)gray;
                    rgbValues[i + 1] = (byte)gray;
                    rgbValues[i + 2] = (byte)gray;
                }
                // Copy the RGB values back to the bitmap
                System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);

                // Unlock the bits.
                bmp.UnlockBits(bmpData);

				pictureBoxCurrentBackup();
                pictureBoxCurrent.Refresh();
				refreshHistogram();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
            timer1.Stop();
        }

        private void convertRGBToHSV(int rr, int gg, int bb, ref int hh, ref int ss, ref int vv)
        {
            double h = 0;
            double s = 0;
            double v = 0;

            double r = rr / 255.0;
            double g = gg / 255.0;
            double b = bb / 255.0;

            double max = Math.Max(r, Math.Max(g, b));
            double min = Math.Min(r, Math.Min(g, b));

            if (max == min)
                h = 0;
            else if (max == r && g >= b)
                h = 60 * ((g - b) / (max - min));
            else if (max == r && g < b)
                h = 60 * ((g - b) / (max - min)) + 360;
            else if (max == g)
                h = 60 * ((b - r) / (max - min)) + 120;
            else
                h = 60 * ((r - g) / (max - min)) + 240;

            if (max == 0)
                s = 0;
            else
                s = 1 - min / max;

            v = max;

            hh = Convert.ToInt32(h / 360 * 255);
            ss = Convert.ToInt32(s * 255);
            vv = Convert.ToInt32(v * 255);
        }

        private void convertHSVToRGB(int hh, int ss, int vv, ref int rr, ref int gg, ref int bb)
        {
            double r = 0;
            double g = 0;
            double b = 0;

            double h = hh / 255.0 * 360;
            double s = ss / 255.0 * 100;
            double v = vv / 255.0 * 100;

            int hi = Convert.ToInt32(Math.Floor(h / 60) % 6);
            double vmin = ((100 - s) * v) / 100;
            double a = (v - vmin) * (h % 60) / 60;
            double vinc = vmin + a;
            double vdec = v - a;

            switch (hi) {
                case 0:
                    r = v;
                    g = vinc;
                    b = vmin;
                    break;
                case 1:
                    r = vdec;
                    g = v;
                    b = vmin;
                    break;
                case 2:
                    r = vmin;
                    g = v;
                    b = vinc;
                    break;
                case 3:
                    r = vmin;
                    g = vdec;
                    b = v;
                    break;
                case 4:
                    r = vinc;
                    g = vmin;
                    b = v;
                    break;
                case 5:
                    r = v;
                    g = vmin;
                    b = vdec;
                    break;
            }

            rr = Convert.ToInt32(r / 100 * 255);
            gg = Convert.ToInt32(g / 100 * 255);
            bb = Convert.ToInt32(b / 100 * 255);
        }            

        private void SetHSV()
        {
            if (pictureBoxCurrent.Image != null)
            {
				pictureBoxCurrentLoad();

				Bitmap bmp = pictureBoxCurrent.Image as Bitmap;

                // Lock the bitmap's bits. 
                Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                System.Drawing.Imaging.BitmapData bmpData =
                    bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                    bmp.PixelFormat);

                // Get the address of the first line.
                IntPtr ptr = bmpData.Scan0;

                // Declare an array to hold the bytes of the bitmap.
                int bytes = Math.Abs(bmpData.Stride) * bmp.Height;
                byte[] rgbValues = new byte[bytes];

                // Copy the RGB values into the array.
                System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

				int Hue = 0;
				int Sat = 0;
				int Val = 0;
				if (radioButton1.Checked)
				{
					Hue = Hue1;
					Sat = Sat1;
					Val = Val1;
				}
				else
				{
					Hue = Hue2;
					Sat = Sat2;
					Val = Val2;
				}

				for (int i = 0; i < rgbValues.Length; i += 3)
                {
                    int h = 0;
                    int s = 0;
                    int v = 0;
                    int r = 0;
                    int g = 0;
                    int b = 0;
                    convertRGBToHSV(rgbValues[i + 2], rgbValues[i + 1], rgbValues[i + 0], ref h, ref s, ref v);

					h += Hue;
					s += Sat;
					v += Val;

                    if (h < 0)
                        h = 0;
                    else if (h > 255)
                        h = 255;

                    if (s < 0)
                        s = 0;
                    else if (s > 255)
                        s = 255;

                    if (v < 0)
                        v = 0;
                    else if (v > 255)
                        v = 255;

                    convertHSVToRGB(h, s, v, ref r, ref g, ref b);
                    rgbValues[i + 0] = (byte)b;
                    rgbValues[i + 1] = (byte)g;
                    rgbValues[i + 2] = (byte)r;
                }

                // Copy the RGB values back to the bitmap
                System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);

                // Unlock the bits.
                bmp.UnlockBits(bmpData);

                pictureBoxCurrent.Refresh();
                refreshHistogram();
            }
        }

        private void trackBarHue_Scroll(object sender, EventArgs e)
        {
			if (radioButton1.Checked)
				Hue1 = trackBarHue.Value;
			else
				Hue2 = trackBarHue.Value;

			ValH.Text = Convert.ToString(trackBarHue.Value);
        }

        private void trackBarSat_Scroll(object sender, EventArgs e)
        {
			if (radioButton1.Checked)
				Sat1 = trackBarSat.Value;
			else
				Sat2 = trackBarSat.Value;

			ValS.Text = Convert.ToString(trackBarSat.Value);
        }

        private void trackBarVal_Scroll(object sender, EventArgs e)
        {
			if (radioButton1.Checked)
				Val1 = trackBarVal.Value;
			else
				Val2 = trackBarVal.Value;

			ValV.Text = Convert.ToString(trackBarVal.Value);
        }

		private void tstToolStripMenuItem_Click(object sender, EventArgs e)
		{
			pictureBoxCurrentLoad();
			pictureBoxCurrent.Refresh();
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			trackBarHue.Value = 0;
			trackBarSat.Value = 0;
			trackBarVal.Value = 0;
			SetHSV();
		}

		private void trackBarSat_MouseUp(object sender, MouseEventArgs e)
		{
			SetHSV();
		}

		private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null && pictureBox2.Image != null && 
                pictureBox1.Image.Width == pictureBox2.Image.Width &&
                pictureBox1.Image.Height == pictureBox2.Image.Height)
            {
                Bitmap bmp1 = pictureBoxCurrent.Image as Bitmap;
                Bitmap bmp2;
                if (pictureBoxCurrent.Name.Equals("pictureBox1"))
                    bmp2 = pictureBox2.Image as Bitmap;
                else
                    bmp2 = pictureBox1.Image as Bitmap;

                // Lock the bitmap's bits. 
                Rectangle rect1 = new Rectangle(0, 0, bmp1.Width, bmp1.Height);
                System.Drawing.Imaging.BitmapData bmpData1 =
                    bmp1.LockBits(rect1, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                    bmp1.PixelFormat);

                Rectangle rect2 = new Rectangle(0, 0, bmp2.Width, bmp2.Height);
                System.Drawing.Imaging.BitmapData bmpData2 =
                    bmp2.LockBits(rect2, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                    bmp2.PixelFormat);

                // Get the address of the first line.
                IntPtr ptr1 = bmpData1.Scan0;
                IntPtr ptr2 = bmpData2.Scan0;

                // Declare an array to hold the bytes of the bitmap.
                int bytes1 = Math.Abs(bmpData1.Stride) * bmp1.Height;
                byte[] rgbValues1 = new byte[bytes1];

                int bytes2 = Math.Abs(bmpData2.Stride) * bmp2.Height;
                byte[] rgbValues2 = new byte[bytes2];

                // Copy the RGB values into the array.
                System.Runtime.InteropServices.Marshal.Copy(ptr1, rgbValues1, 0, bytes1);
                System.Runtime.InteropServices.Marshal.Copy(ptr2, rgbValues2, 0, bytes2);

                int max_diff = Math.Abs(rgbValues1.Max() - rgbValues2.Max());

                // Set every third value to 255. A 24bpp bitmap will look red.  
                for (int i = 0; i < rgbValues1.Length; i += 3)
                {
                    int bDiff = Math.Abs(rgbValues1[i + 0] - rgbValues2[i + 0]);
                    int gDiff = Math.Abs(rgbValues1[i + 1] - rgbValues2[i + 1]);
                    int rDiff = Math.Abs(rgbValues1[i + 2] - rgbValues2[i + 2]);

                    if (max_diff != 0)
                    {
                        rgbValues1[i + 0] = (byte)(bDiff * 255 / max_diff);
                        rgbValues1[i + 1] = (byte)(gDiff * 255 / max_diff);
                        rgbValues1[i + 2] = (byte)(rDiff * 255 / max_diff);
                    }
                    else
                    {
                        rgbValues1[i + 0] = (byte)bDiff;
                        rgbValues1[i + 1] = (byte)gDiff;
                        rgbValues1[i + 2] = (byte)rDiff;
                    }
                    
                }
                // Copy the RGB values back to the bitmap
                System.Runtime.InteropServices.Marshal.Copy(rgbValues1, 0, ptr1, bytes1);
                System.Runtime.InteropServices.Marshal.Copy(rgbValues2, 0, ptr2, bytes2);

                // Unlock the bits.
                bmp1.UnlockBits(bmpData1);
                bmp2.UnlockBits(bmpData2);

				pictureBoxCurrentBackup();
                pictureBoxCurrent.Refresh();
                refreshHistogram();
            }
            else
            {
                toolStripStatusLabel1.Text = "Размеры изображений не совпадают!";
                timer1.Start();
            }
        }
    }
}
