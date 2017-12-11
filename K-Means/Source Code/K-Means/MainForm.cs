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
        kmeans kms;

        public MainForm()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            DataColumn dc;

            DataTable dt;

            kms = new kmeans();

            dt = new DataTable("cord");

            dc = dt.Columns.Add();
            dc.ColumnName = "Num";
            dc.Caption = "編號";
            dc.DataType = typeof(int);
            dc.AutoIncrement = true;

            dc = dt.Columns.Add();
            dc.ColumnName = "Cx";
            dc.Caption = "座標 X";
            dc.DataType = typeof(double);

            dc = dt.Columns.Add();
            dc.ColumnName = "Cy";
            dc.Caption = "座標 Y";
            dc.DataType = typeof(double);

            foreach (cord item in kms.data)
            {
                dt.Rows.Add(new Object[] { null, item.x, item.y });
            }

            dt.AcceptChanges();

            this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.DataSource = dt;

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderText = dt.Columns[col.HeaderText].Caption;
            }

            this.tbOffSetP1X.Text = kms.OffieSetGroupPoint1.x.ToString();
            this.tbOffSetP1Y.Text = kms.OffieSetGroupPoint1.y.ToString();
            this.tbOffSetP2X.Text = kms.OffieSetGroupPoint2.x.ToString();
            this.tbOffSetP2Y.Text = kms.OffieSetGroupPoint2.y.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bmp;

            Graphics g;

            DataTable dt;

            List<cord> data;


            data = new List<cord>();
            dt = this.dataGridView1.DataSource as DataTable;
            foreach (DataRow dr in dt.Rows)
            {
                data.Add(new cord(((double)dr["Cx"]), ((double)dr["Cy"])));
            }

            kms.data = data;


            kms.OffieSetGroupPoint1.x = Convert.ToDouble(this.tbOffSetP1X.Text);
            kms.OffieSetGroupPoint1.y = Convert.ToDouble(this.tbOffSetP1Y.Text);
            kms.OffieSetGroupPoint2.x = Convert.ToDouble(this.tbOffSetP2X.Text);
            kms.OffieSetGroupPoint2.y = Convert.ToDouble(this.tbOffSetP2Y.Text);

            bmp = new Bitmap(420, 420);

            this.pictureBox1.Image = (Image)bmp;

            g = Graphics.FromImage(bmp);

            
            kms.Go(g, this);
        }

    }

}
