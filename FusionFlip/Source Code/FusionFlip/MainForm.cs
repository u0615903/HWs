using Media.Image.Fun;
using Media.Image.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FusionFlips
{
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();

        }

        private void LoadImage(TextBox tb, PictureBox pb)
        {
            if (File.Exists(tb.Text))
            {
                try
                {
                    pb.Load(tb.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Load Image " + tb.Text + " Failed.", "Error");
                }

            }
            else
            {
                OpenFileDialog ofd;

                ofd = new OpenFileDialog();

                ofd.ShowDialog();

                if (!string.IsNullOrEmpty(ofd.FileName))
                {
                    try
                    {
                        pb.Load(ofd.FileName);
                        tb.Text = ofd.FileName;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Load Image " + tb.Text + " Failed.", "Error");
                    }

                }

            }

        }

        private string GetImageFormat(Image img)
        {
            string result;


            switch (img.PixelFormat)
            {
                case PixelFormat.Format16bppArgb1555:
                    result = "16bppArgb1555";
                    break;
                case PixelFormat.Format16bppGrayScale:
                    result = "16bppGrayScale";
                    break;
                case PixelFormat.Format16bppRgb555:
                    result = "16bppRgb555";
                    break;
                case PixelFormat.Format16bppRgb565:
                    result = "16bppRgb565";
                    break;
                case PixelFormat.Format24bppRgb:
                    result = "24bppRgb";
                    break;
                case PixelFormat.Format32bppArgb:
                    result = "32bppArgb";
                    break;
                case PixelFormat.Format32bppPArgb:
                    result = "32bppPArgb";
                    break;
                case PixelFormat.Format32bppRgb:
                    result = "32bppRgb";
                    break;
                case PixelFormat.Format48bppRgb:
                    result = "48bppRgb";
                    break;
                case PixelFormat.Format64bppArgb:
                    result = "64bppArgb";
                    break;
                case PixelFormat.Format64bppPArgb:
                    result = "64bppPArgb";
                    break;
                case PixelFormat.Format8bppIndexed:
                    result = "8bppIndexed";
                    break;
                case PixelFormat.Format1bppIndexed:
                    result = "1bppIndexed";
                    break;
                case PixelFormat.Format4bppIndexed:
                    result = "4bppIndexed";
                    break;
                default:
                    result = "Unknow";
                    break;
            }

            return result;
        }


        private void btnOpenS_Click(object sender, EventArgs e)
        {
            this.LoadImage(this.tbPath1, this.pbSource);
            if (this.pbSource.Image != null)
            {
                this.tbSource.Text = ""
                     + "Width: " + this.pbSource.Width.ToString() + "\r\n"
                     + "Height: " + this.pbSource.Height.ToString() + "\r\n"
                     + "Format: " + this.GetImageFormat(this.pbSource.Image);
            }
        }

        private void btnOpenT_Click(object sender, EventArgs e)
        {
            this.LoadImage(this.tbPath2, this.pbTarget);
            if (this.pbTarget.Image != null)
            {
                this.tbTarget.Text = ""
                     + "Width: " + this.pbTarget.Width.ToString() + "\r\n"
                     + "Height: " + this.pbTarget.Height.ToString() + "\r\n"
                     + "Format: " + this.GetImageFormat(this.pbTarget.Image);
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            double psnr;


            if (this.pbSource.Image == null)
            { this.btnOpenS_Click(sender, e); }

            if (this.pbTarget.Image == null)
            { this.btnOpenT_Click(sender, e); ; }

            if ((this.pbSource.Image == null) || (this.pbTarget.Image == null))
            { return; }

            this.pbResult.Image = FusionFlip.MakeFlip(this.pbSource.Image, this.pbTarget.Image);

            this.pbResult.Image.Save(
                Path.GetFileNameWithoutExtension(this.tbPath1.Text) + "-Filpped"
                + Path.GetExtension(this.tbPath1.Text)
                , ((this.pbSource.Image.RawFormat.Guid == ImageFormat.MemoryBmp.Guid) ? ImageFormat.Bmp : this.pbSource.Image.RawFormat));

            this.tbResult.Text = ""
                 + "Width: " + this.pbResult.Width.ToString() + "\r\n"
                 + "Height: " + this.pbResult.Height.ToString() + "\r\n"
                 + "Format: " + this.GetImageFormat(this.pbResult.Image);


            psnr = Quality.PSNR(this.pbSource.Image, this.pbResult.Image);
            if (psnr == double.NaN)
            {
                this.tbResult.Text += "\r\n\r\n"
                    + "Images are identical.";
            }
            else
            {
                this.tbResult.Text += "\r\n\r\n"
                    + "PSNR: " + psnr.ToString("00.0000");
            }

        }

        private void btnRevResult_Click(object sender, EventArgs e)
        {
            Image img;


            if (this.pbResult.Image == null) { return; }

            img = this.pbResult.Image;

            this.pbResult.Image = FusionFlip.MakeFlip(img);

            this.pbResult.Image.Save(
                Path.GetFileNameWithoutExtension(this.tbPath1.Text) + "-Filpped-Rev"
                + Path.GetExtension(this.tbPath1.Text)
                , ((img.RawFormat.Guid == ImageFormat.MemoryBmp.Guid) ? ImageFormat.Bmp : img.RawFormat));
        }

    }

}
