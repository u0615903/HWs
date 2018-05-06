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

namespace ImageVerifiable
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

        private void LoadSource(TextBox tb)
        {
            this.LoadImage(tb, this.pbSource);
            if (this.pbSource.Image != null)
            {
                this.tbSource.Text = ""
                     + "Width: " + this.pbSource.Width.ToString() + "\r\n"
                     + "Height: " + this.pbSource.Height.ToString() + "\r\n"
                     + "Format: " + this.GetImageFormat(this.pbSource.Image);
            }
        }


        private void btnOpenS_Click(object sender, EventArgs e)
        {
            this.LoadSource(this.tbPath1);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            bool VerifyResult;
            bool goVerify;

            double psnr;

            string vFileName;
            TextBox tb;


            vFileName = Path.GetFileNameWithoutExtension(this.tbPath1.Text) + "-V" + Path.GetExtension(this.tbPath1.Text);

            VerifyResult = true;
            goVerify = File.Exists(vFileName);
            if (goVerify)
            {
                tb = new TextBox();
                tb.Text = vFileName;
                this.LoadSource(tb);
            }

            if (this.pbSource.Image == null)
            { this.btnOpenS_Click(sender, e); }

            if (this.pbSource.Image == null)
            { return; }

            if (goVerify)
            {
                Image img;

                img = this.pbTarget.Image;
                VerifyResult = ImageValidate.Verify(this.pbSource.Image, ref img);
                this.pbTarget.Image = img;
            }
            else
            {
                this.pbTarget.Image = ImageValidate.MakeVerifiable(this.pbSource.Image);

                this.pbTarget.Image.Save(
                    vFileName
                    , ((this.pbSource.Image.RawFormat.Guid == ImageFormat.MemoryBmp.Guid) ? ImageFormat.Bmp : this.pbSource.Image.RawFormat));
            }

            this.tbTarget.Text = ""
                 + "Width: " + this.pbTarget.Width.ToString() + "\r\n"
                 + "Height: " + this.pbTarget.Height.ToString() + "\r\n"
                 + "Format: " + this.GetImageFormat(this.pbTarget.Image);

            if (goVerify)
            {
                this.tbTarget.Text += "\r\n\r\n"
                    + "Verify: " + VerifyResult.ToString();
            }

            psnr = Quality.PSNR(this.pbSource.Image, this.pbTarget.Image);
            if (Double.IsNaN(psnr))
            {
                this.tbTarget.Text += "\r\n\r\n"
                    + "Images are identical.";
            }
            else
            {
                this.tbTarget.Text += "\r\n\r\n"
                    + "PSNR: " + psnr.ToString("00.0000");
            }

        }

    }

}
