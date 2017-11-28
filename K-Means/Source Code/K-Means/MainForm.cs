using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace K_Means
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bmp;

            Graphics g;

            kmeans kms;


            bmp = new Bitmap(420, 420);

            this.pictureBox1.Image = (Image)bmp;

            g = Graphics.FromImage(bmp);

            kms = new kmeans();

            kms.Go(g, this);
        }
    }
}
