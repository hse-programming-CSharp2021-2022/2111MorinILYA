using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint2
{
    public partial class Form1 : Form
    {
        Bitmap pic;
        int x1, y1;
        public Form1()
        {
            InitializeComponent();
            pic = new Bitmap(1000, 1000);
            x1 = y1 = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            p.Color = ((Button)sender).BackColor;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                p.Color = colorDialog1.Color;
                ((Button)sender).BackColor = colorDialog1.Color;
            }
        }

        Pen p= new Pen(Color.Black, 3f);

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Filter = "JPG(*.JPG)|*.jpg";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Save(saveFileDialog1.FileName);
                    }

                }


            }
            catch(System.Exception)
            {
                MessageBox.Show("Не удалось сохранить файл.");
            }

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                if (openFileDialog1.FileName != "")
                {
                    pic = (Bitmap)Image.FromFile(openFileDialog1.FileName);
                    pictureBox1.Image = pic;



                }

            }
            catch(System.IO.FileNotFoundException)
            {
                MessageBox.Show("Не удалось открыть файл.");
            }

            




        }


        Graphics g;
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
            
            g = Graphics.FromImage(pic);

            p.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            p.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            p.Width = trackBar1.Value;
            if (e.Button==MouseButtons.Left)
            {
                g.DrawLine(p, x1, y1, e.X, e.Y);
                pictureBox1.Image = pic;


            }

            x1 = e.X;
            y1 = e.Y;

            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            g.Clear(pictureBox1.BackColor);
            pictureBox1.Image = pic;
        }


    }
}
