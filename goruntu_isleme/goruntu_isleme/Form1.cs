using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace goruntu_isleme
{

    public partial class Form1 : Form
    {

        PictureBox picturebox2;
        public Bitmap picture2(Bitmap islenmis)
        {


            this.Controls.Remove(picturebox2);
            picturebox2 = new PictureBox();
            this.Controls.Add(picturebox2);
            picturebox2.SetBounds(300, 62, 258, 206);
            picturebox2.Image = islenmis;
            return islenmis;
        }
        public Form1()
        {
            InitializeComponent();
      
        }


        private void görüntüAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "(*.jpg)|*.jpg|(*.png)|*.png";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Image = new Bitmap(fd.OpenFile());
            }
      
        }

        private void kırmızıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i, j;
            Color r;
            int red, green, blue;
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            for (i = 0; i <= bmp.Width - 1; i++)
            {
                for (j = 0; j <= bmp.Height - 1; j++)
                {
                    r = bmp.GetPixel(i, j);
                    if (r.G - 255 > 0)
                    {
                        green = r.G - 255;
                    }
                    else { green = 0; }

                    if (r.B - 255 > 0)
                    {
                        blue = r.B - 255;
                    }
                    else { blue = 0; }                        
                    r = Color.FromArgb(r.R, green, blue);
                    bmp.SetPixel(i, j, r);                
                }
            }
            picture2(bmp); 
        }

        private void yeşilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i, j;
            Color r;
            int red, green, blue;
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            for (i = 0; i <= bmp.Width - 1; i++)
            {
                for (j = 0; j <= bmp.Height - 1; j++)
                {
                    r = bmp.GetPixel(i, j);
                    if (r.G - 255 > 0)
                    {
                        red = r.R - 255;
                    }
                    else { red = 0; }

                    if (r.B - 255 > 0)
                    {
                        blue = r.B - 255;
                    }
                    else { blue = 0; }
                    r = Color.FromArgb(red, r.G, blue);
                    bmp.SetPixel(i, j, r);
                }
            }
            picture2(bmp);
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i, j;
            Color r;
            int red, green, blue;
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            for (i = 0; i <= bmp.Width - 1; i++)
            {
                for (j = 0; j <= bmp.Height - 1; j++)
                {
                    r = bmp.GetPixel(i, j);
                    if (r.G - 255 > 0)
                    {
                        red = r.R - 255;
                    }
                    else { red = 0; }

                    if (r.G - 255 > 0)
                    {
                        green = r.B - 255;
                    }
                    else { green = 0; }
                    r = Color.FromArgb(red, green, r.B);
                    bmp.SetPixel(i, j, r);
                }
            }
            picture2(bmp);
        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i, j;
            Color r;
            int ort;
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            for (i = 0; i <= bmp.Width - 1; i++)
            {
                for (j = 0; j <= bmp.Height - 1; j++)
                {
                    r = bmp.GetPixel(i, j);
                    ort = (r.R + r.G + r.B) / 3;
                 
                    r = Color.FromArgb(ort, ort, ort);
                    bmp.SetPixel(i, j, r);
                }
            }
            picture2(bmp);
        }

        private void negatifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i, j;
            Color r;
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            for (i = 0; i <= bmp.Width - 1; i++)
            {
                for (j = 0; j <= bmp.Height - 1; j++)
                {
                    r = bmp.GetPixel(i, j);
                    r = Color.FromArgb(255-r.R, 255-r.G, 255-r.B);
                    bmp.SetPixel(i, j, r);
                }
            }
            picture2(bmp);
        }

        private void tersÇevirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i, j;
            Color r,t,y;
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            for (i = 0; i < bmp.Width; i++)
            {
                for (j = 0; j < bmp.Height/2; j++)
                {
                    r = bmp.GetPixel(i, j);
                    y = bmp.GetPixel(i,( (bmp.Height-1)-j));
                 
                    bmp.SetPixel(i, j, y);
                    bmp.SetPixel(i, ((bmp.Height - 1) - j), r);

                }
            }
            picture2(bmp);
        }

        private void aynalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i, j;
            Color r, t, y;
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            for (i = 0; i < bmp.Width/2; i++)
            {
                for (j = 0; j < bmp.Height; j++)
                {
                    r = bmp.GetPixel(i, j);
                    y = bmp.GetPixel(((bmp.Width - 1) -i), j);

                    bmp.SetPixel(i, j, y);
                    bmp.SetPixel(((bmp.Width - 1) - i),j, r);

                }
            }
            picture2(bmp);
        }

        private void öteleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i, j;
            Color r;
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap kopya = new Bitmap(bmp.Width,bmp.Height);


            for (i = 0; i < bmp.Width; i++)
            {
                for (j = 0; j < bmp.Height; j++)
                {
                    r = bmp.GetPixel(i, j);
                    if(i+20<kopya.Width&&j+20<kopya.Height)
                    kopya.SetPixel(i + 20, j + 20,r);
                
                    

                }
            }
            picture2(kopya);
        }

        private void yakınlaştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap yeni = new Bitmap(bmp.Width * 2, bmp.Height * 2);
            int x = 0, y = 0;
            for (int i = 0; i < bmp.Width * 2; i += 2)
            {
                for (int j = 0; j < bmp.Height * 2; j += 2)
                {
                    if ((i + 1) < yeni.Width && (j + 1) < yeni.Height)
                    {
                        yeni.SetPixel(i, j, bmp.GetPixel(x, y));
                        yeni.SetPixel(i, j + 1, bmp.GetPixel(x, y));
                        yeni.SetPixel(i + 1, j, bmp.GetPixel(x, y));
                        yeni.SetPixel(i + 1, j + 1, bmp.GetPixel(x, y));
                    }
                    y++;
                }
                x++;
                y = 0;
            }
            picture2(yeni);
        }

        private void uzaklaştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap yeni = new Bitmap(bmp.Width / 2, bmp.Height / 2);
            int x = 0, y = 0;

            int a, b, c;
            for (int i = 0; i < yeni.Width; i++)
            {
                for (int j = 0; j < yeni.Height; j++)
                {
                    a = (bmp.GetPixel(x, y).R + bmp.GetPixel(x, y + 1).R + bmp.GetPixel(x + 1, y).R + bmp.GetPixel(x + 1, y + 1).R) / 4;
                    b = (bmp.GetPixel(x, y).G + bmp.GetPixel(x, y + 1).G + bmp.GetPixel(x + 1, y).G + bmp.GetPixel(x + 1, y + 1).G) / 4;
                    c = (bmp.GetPixel(x, y).B + bmp.GetPixel(x, y + 1).B + bmp.GetPixel(x + 1, y).B + bmp.GetPixel(x + 1, y + 1).B) / 4;


                    yeni.SetPixel(i, j, Color.FromArgb(a, b, c));
                    y += 2;
                }
                x += 2;
                y = 0;
            }
            picture2(yeni);
        }

        private void parlaklığıArttırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);

            Color r;
            int R, G, B;
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    R = (bmp.GetPixel(i, j).R + 50);
                    G = (bmp.GetPixel(i, j).G + 50);
                    B = (bmp.GetPixel(i, j).B + 50);
                    if (R > 255)
                    {
                        R = 255;
                    }
                    if (G > 255)
                    {
                        G = 255;
                    }
                    if (B > 255)
                    {
                        B = 255;
                    }

                    bmp.SetPixel(i, j, Color.FromArgb(R, G, B));

                }
            }
            picture2(bmp);
        }

        private void parlaklığıAzaltToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Color r;
            int R, G, B;
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    R = (bmp.GetPixel(i, j).R - 50);
                    G = (bmp.GetPixel(i, j).G - 50);
                    B = (bmp.GetPixel(i, j).B - 50);
                    if (R < 0)
                    {
                        R = 0;
                    }
                    if (G < 0)
                    {
                        G = 0;
                    }
                    if (B < 0)
                    {
                        B = 0;
                    }

                    bmp.SetPixel(i, j, Color.FromArgb(R, G, B));

                }
            }
            picture2(bmp);
        }

        private void kontrastArttırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);

            Color r;
            int R, G, B;
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    R = (bmp.GetPixel(i, j).R * 2);
                    G = (bmp.GetPixel(i, j).G * 2);
                    B = (bmp.GetPixel(i, j).B * 2);
                    if (R > 255)
                    {
                        R = 255;
                    }
                    if (G > 255)
                    {
                        G = 255;
                    }
                    if (B > 255)
                    {
                        B = 255;
                    }

                    bmp.SetPixel(i, j, Color.FromArgb(R, G, B));

                }
            }
            picture2(bmp); 


        }

        private void kontrastAzaltToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Color r;
            int R, G, B;
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    R = (bmp.GetPixel(i, j).R * (-1));
                    G = (bmp.GetPixel(i, j).G * (-1));
                    B = (bmp.GetPixel(i, j).B * (-1));
                    if (R < 0)
                    {
                        R = 80;
                    }
                    if (G < 0)
                    {
                        G = 90;
                    }
                    if (B < 0)
                    {
                        B = 100;
                    }
                    bmp.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }
            picture2(bmp); 

        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] kirmizi = new int[256];
            int[] yesil = new int[256];
            int[] mavi = new int[256];
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Color r;
            int R, G, B;
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    r = bmp.GetPixel(i, j);
                    kirmizi[r.R]++;
                    yesil[r.G]++;
                    mavi[r.B]++;

                }
            }
            for (int t = 1; t < 255; t++)
            {

                chart1.Series["Kırmızı"].Points.AddXY(t, kirmizi[t]);
                chart1.Series["Yeşil"].Points.AddXY(t, yesil[t]);
                chart1.Series["Mavi"].Points.AddXY(t, mavi[t]);
            }
         
        }
    }

}
