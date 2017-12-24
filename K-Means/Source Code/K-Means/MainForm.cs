using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace K_Means
{

    public partial class MainForm : Form
    {

        # region 全域變數

        bool GoNext;

        int loop;

        Bitmap bmp;

        Brush btext;
        Brush btextcord;

        Brush ba;
        Brush bgpi;
        Brush bgp;
        Brush bg1;
        Brush bg2;

        Font ftextcord;

        Pen pl;
        Pen pb;

        kmeans kms;

        Thread kms_thread;

        #endregion

        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// 初始化。
        /// </summary>
        private void Init()
        {
            DataColumn dc;

            DataTable dt;

            DataRow dr;

            // 建立物件
            kms = new kmeans();

            // 資料初始化與畫面輸出顯示設定
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
            dc.DefaultValue = 0;

            dc = dt.Columns.Add();
            dc.ColumnName = "Cy";
            dc.Caption = "座標 Y";
            dc.DataType = typeof(double);
            dc.DefaultValue = 0;

            dc = dt.Columns.Add();
            dc.ColumnName = "group";
            dc.Caption = "群";
            dc.DataType = typeof(int);
            dc.DefaultValue = 0;

            dc = dt.Columns.Add();
            dc.ColumnName = "dgp1";
            dc.Caption = "群 1 中心距離";
            dc.DataType = typeof(string);
            dc.DefaultValue = 0;

            dc = dt.Columns.Add();
            dc.ColumnName = "dgp2";
            dc.Caption = "群 2 中心距離";
            dc.DataType = typeof(string);
            dc.DefaultValue = 0;

            foreach (cord item in kms.data)
            {
                dr = dt.Rows.Add(new Object[] { null, item.x, item.y });
                item.index = (int)dr["Num"];
            }

            dt.AcceptChanges();

            this.PointData.AutoGenerateColumns = true;
            this.PointData.DataSource = dt;

            foreach (DataGridViewColumn col in PointData.Columns)
            {
                col.HeaderText = dt.Columns[col.HeaderText].Caption;
            }

            this.OffSetP1X.Text = kms.OffieSetGroupPoint1.x.ToString();
            this.OffSetP1Y.Text = kms.OffieSetGroupPoint1.y.ToString();
            this.OffSetP2X.Text = kms.OffieSetGroupPoint2.x.ToString();
            this.OffSetP2Y.Text = kms.OffieSetGroupPoint2.y.ToString();

            // 繪圖區域建置

            btext = new SolidBrush(Color.Black);
            btextcord = new SolidBrush(Color.Black);

            // 所有座標點
            ba = new SolidBrush(Color.Violet);
            // 初始中心座標點
            bgpi = new SolidBrush(Color.Purple);
            // 各群的中心座標點
            bgp = new SolidBrush(Color.DarkRed);
            // 第一群座標點
            bg1 = new SolidBrush(Color.ForestGreen);
            // 第二群座標點
            bg2 = new SolidBrush(Color.Gold);

            ftextcord = new Font("Courier New", 8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(136)));

            pl = new Pen(Color.LightGray, 1);
            pb = new Pen(Color.Black, 1);

            bmp = new Bitmap(420, 420);

            this.pictureBox1.Image = (Image)bmp;

            this.DoubleBuffered = true;
        }

        /// <summary>
        /// 清除繪圖區域。
        /// </summary>
        /// <param name="g"></param>
        private void clear()
        {
            Graphics g;

            g = Graphics.FromImage(bmp);

            g.Clear(Color.White);

            for (int i = 10; i <= 410; i += 10)
            {
                g.DrawLine(pl, i, 10, i, 410);
                g.DrawLine(pl, 10, i, 410, i);
            }

            g.DrawRectangle(pb, 10, 10, 400, 400);
            g.DrawLine(pb, 210, 10, 210, 410);
            g.DrawLine(pb, 10, 210, 410, 210);
        }

        /// <summary>
        /// 資料輸出處理。
        /// </summary>
        /// <param name="action">動作。</param>
        /// <param name="data">資料。</param>
        private void OutputData(int action, IList<cord> data)
        {
            int gsleeptime;
            int tsleeptime;

            int osx;
            int osy;

            float w;
            float h;
            float sw;

            float tosy;

            float x;
            float y;
            float gzx;
            float gzy;
            float zx;
            float zy;
            float zpx;
            float zpy;

            string str;

            cord A1;
            cord A2;
            cord A3;
            cord A4;

            Graphics g;

            cord cPoint;


            gsleeptime = 1500;
            tsleeptime = 500;

            osx = 60;
            osy = 20;

            w = 8;
            h = 8;
            tosy = 20;
            gzx = 10;
            gzy = 10;
            zx = 200 + gzx;
            zy = 200 + gzy;
            zpx = zx - (w / 2);
            zpy = zy - (h / 2);

            g = Graphics.FromImage(bmp);

            switch (action)
            {
                // 輸出資料 (畫面清除)
                default:
                case 0:

                    this.SuspendLayout();

                    this.clear();

                    g.DrawString("分群回合： " + loop.ToString(), this.Font, btext, 16, 16);

                    this.ResumeLayout();

                    break;

                // 輸出資料 (所有座標點)
                case 1:

                    this.SuspendLayout();

                    A1 = new cord() { x = 352, y = gzy + gzy };
                    A2 = new cord() { x = gzx + gzx, y = gzy + tosy };
                    A3 = new cord() { x = gzx + gzx, y = gzy + zy };
                    A4 = new cord() { x = 352, y = gzy + zy };
                    foreach (cord item in data)
                    {
                        x = (float)(zpx + (item.x * 10));
                        y = (float)(zpy - (item.y * 10));

                        g.FillPie(ba, x, y, w, h, (float)0, (float)360);

                        #region Output Text - Coordinate

                        if (item.x > 0)
                        {
                            if (item.y > 0)
                            {
                                str = "(" + ((int)item.x).ToString() + ", " + ((int)item.y).ToString() + ")";
                                g.DrawString(str, ftextcord, btext, (float)A1.x, (float)A1.y);

                                g.DrawLine(pb, (float)(A1.x + 1), (float)(A1.y + 9), (x + w + 1), (y - 1));

                                if ((A1.y + osy) > zy)
                                { A1.x -= osx; A1.y = gzy + gzy; }
                                else
                                { A1.y += osy; }

                            }
                            else
                            {
                                str = "(" + ((int)item.x).ToString() + ", " + ((int)item.y).ToString() + ")";
                                g.DrawString(str, ftextcord, btext, (float)A4.x, (float)A4.y);

                                g.DrawLine(pb, (float)(A4.x + 1), (float)(A4.y + 9), (x + w + 1), (y + 1));

                                if ((A4.y + osy) > (zy + zy))
                                { A4.x -= osx; A4.y = gzy + zy; }
                                else
                                { A4.y += osy; }

                            }

                        }
                        else
                        {
                            if (item.y > 0)
                            {
                                str = "(" + ((int)item.x).ToString() + ", " + ((int)item.y).ToString() + ")";
                                g.DrawString(str, ftextcord, btext, (float)A2.x, (float)A2.y);

                                sw = g.MeasureString(str, ftextcord).Width;
                                g.DrawLine(pb, (float)(A2.x + sw), (float)(A2.y + 9), (x - 1), (y - 1));

                                if ((A2.y + osy) > zy)
                                { A2.x += osx; A2.y = gzy + tosy; }
                                else
                                { A2.y += osy; }

                            }
                            else
                            {
                                str = "(" + ((int)item.x).ToString() + ", " + ((int)item.y).ToString() + ")";
                                g.DrawString(str, ftextcord, btext, (float)A3.x, (float)A3.y);

                                sw = g.MeasureString(str, ftextcord).Width;
                                g.DrawLine(pb, (float)(A3.x + sw), (float)(A3.y + 9), (x - 1), (y + 1));

                                if ((A3.y + osy) > (zy + zy))
                                { A3.x += osx; A3.y = gzy + zy; }
                                else
                                { A3.y += osy; }

                            }

                        }

                        #endregion

                    }

                    this.ResumeLayout();

                    break;

                // 輸出資料 (初始中心座標點)
                case 2:

                    this.SuspendLayout();

                    cPoint = data[0];

                    x = (float)(zpx + (cPoint.x * 10));
                    y = (float)(zpy - (cPoint.y * 10));

                    g.FillPie(bgpi, x, y, w, h, (float)0, (float)360);

                    this.InitGroupPoint.Text = "初始中心點 (X, Y)：" + cPoint.x.ToString("##0.###") + ", " + cPoint.y.ToString("##0.###");

                    this.ResumeLayout();

                    this.Refresh();

                    // Step
                    System.Threading.Thread.Sleep(gsleeptime);

                    break;

                // 輸出資料 (各群的中心座標點)
                case 3:

                    cPoint = data[0];

                    x = (float)(zpx + (cPoint.x * 10));
                    y = (float)(zpy - (cPoint.y * 10));

                    this.SuspendLayout();

                    g.FillPie(bgp, x, y, w, h, (float)0, (float)360);

                    this.GroupPoint1.BackColor = Color.White;
                    this.GroupPoint1.ForeColor = Color.DarkRed;
                    this.GroupPoint1.Text = "第一群中心座標 (X, Y)：" + cPoint.x.ToString("##0.###") + ", " + cPoint.y.ToString("##0.###");

                    System.Threading.Thread.Sleep(tsleeptime);

                    this.ResumeLayout();

                    this.Refresh();

                    this.SuspendLayout();

                    this.GroupPoint1.BackColor = SystemColors.Control;
                    this.GroupPoint1.ForeColor = SystemColors.ControlText;

                    this.ResumeLayout();

                    this.Refresh();

                    this.SuspendLayout();

                    cPoint = data[1];

                    x = (float)(zpx + (cPoint.x * 10));
                    y = (float)(zpy - (cPoint.y * 10));

                    this.SuspendLayout();

                    g.FillPie(bgp, x, y, w, h, (float)0, (float)360);

                    this.GroupPoint2.BackColor = Color.White;
                    this.GroupPoint2.ForeColor = Color.DarkRed;
                    this.GroupPoint2.Text = "第二群中心座標 (X, Y)：" + cPoint.x.ToString("##0.###") + ", " + cPoint.y.ToString("##0.###");

                    System.Threading.Thread.Sleep(tsleeptime);

                    this.ResumeLayout();

                    this.Refresh();

                    this.SuspendLayout();

                    this.GroupPoint2.BackColor = SystemColors.Control;
                    this.GroupPoint2.ForeColor = SystemColors.ControlText;

                    this.ResumeLayout();

                    this.Refresh();

                    loop++;

                    // Step
                    System.Threading.Thread.Sleep(gsleeptime - tsleeptime - tsleeptime);

                    break;

                // 輸出資料 (所有座標點與群中心點的幾何距離)
                case 4:

                    this.SuspendLayout();

                    foreach (cord item in data)
                    {
                        this.PointData.CurrentCell = this.PointData["dgp1", item.index];

                        this.PointData["dgp1", item.index].Value = item.dgp1.ToString("##0.000000");
                        this.PointData["dgp2", item.index].Value = item.dgp2.ToString("##0.000000");
                    }

                    this.ResumeLayout();

                    break;

                // 輸出資料 (第一群座標點)
                case 5:
                case 9:

                    this.SuspendLayout();

                    foreach (cord item in data)
                    {
                        x = (float)(zpx + (item.x * 10));
                        y = (float)(zpy - (item.y * 10));

                        g.FillPie(bg1, x, y, w, h, (float)0, (float)360);

                        this.PointData.CurrentCell = this.PointData["group", item.index];

                        this.PointData["group", item.index].Value = 1;
                    }

                    this.ResumeLayout();

                    if (action == 5) { this.Refresh(); }

                    break;

                // 輸出資料 (第二群座標點)
                case 6:
                case 10:

                    this.SuspendLayout();

                    foreach (cord item in data)
                    {
                        x = (float)(zpx + (item.x * 10));
                        y = (float)(zpy - (item.y * 10));

                        g.FillPie(bg2, x, y, w, h, (float)0, (float)360);

                        this.PointData.CurrentCell = this.PointData["group", item.index];

                        this.PointData["group", item.index].Value = 2;
                    }

                    this.ResumeLayout();

                    if (action == 6) { this.Refresh(); }

                    break;

                // 輸出資料 目前 / 新 (所有座標點與各群中心點的幾何距離總和)
                case 7:
                case 8:

                    cPoint = data[0];

                    this.SuspendLayout();

                    this.dgp1.BackColor = Color.White;
                    this.dgp1.ForeColor = Color.DarkRed;
                    this.dgp2.BackColor = Color.White;
                    this.dgp2.ForeColor = Color.DarkRed;

                    this.dgp1.Text = "第一群中心幾何距離總和：" + cPoint.x.ToString("##0.000000");
                    this.dgp2.Text = "第二群中心幾何距離總和：" + cPoint.y.ToString("##0.000000");

                    System.Threading.Thread.Sleep(tsleeptime);

                    this.ResumeLayout();

                    this.Refresh();

                    this.SuspendLayout();

                    this.dgp1.BackColor = SystemColors.Control;
                    this.dgp1.ForeColor = SystemColors.ControlText;
                    this.dgp2.BackColor = SystemColors.Control;
                    this.dgp2.ForeColor = SystemColors.ControlText;

                    this.ResumeLayout();

                    this.Refresh();

                    break;


                // 輸出資料 演算步驟
                case 97:

                    cPoint = data[0];
                    this.AlgStep.Text = "演算步驟： Step " + cPoint.x.ToString("0.#");


                    break;
                // 輸出資料 下一步控制開始
                case 98:

                    this.Next.Visible = true;
                    this.Refresh();

                    break;

                // 輸出資料 下一步控制結束
                case 99:

                    this.Next.Visible = false;
                    this.Refresh();

                    break;

                // 輸出資料 重置
                case 100:

                    this.AlgStep.Text = "演算步驟： Step X";

                    this.Go.Visible = true;
                    this.Next.Visible = false;
                    this.ManualSteps.Visible = true;
                    this.Refresh();

                    MessageBox.Show("分群結束");

                    break;
            }

        }

        /// <summary>
        /// 資料輸出處理 (多執行緒)。
        /// </summary>
        /// <param name="action">動作。</param>
        /// <param name="data">資料。</param>
        private void OutputDataThread(int action, IList<cord> data)
        {

            if (this.InvokeRequired)
            { this.Invoke(new Action<int, IList<cord>>(this.OutputData), new Object[] { action, data }); }
            else
            { this.OutputData(action, data); }

        }

        /// <summary>
        /// 執行 (多執行緒)。
        /// </summary>
        private void GoThread()
        {
            loop = 0;
            kms.Go(this.OutputDataThread, ref this.GoNext);
        }


        private void Go_Click(object sender, EventArgs e)
        {
            DataTable dt;

            List<cord> data;


            // 建立座標資料
            data = new List<cord>();
            dt = this.PointData.DataSource as DataTable;
            foreach (DataRow dr in dt.Rows)
            {
                data.Add(new cord((int)dr["Num"], ((double)dr["Cx"]), ((double)dr["Cy"])));
            }

            kms.data = data;

            kms.OffieSetGroupPoint1.x = Convert.ToDouble(this.OffSetP1X.Text);
            kms.OffieSetGroupPoint1.y = Convert.ToDouble(this.OffSetP1Y.Text);
            kms.OffieSetGroupPoint2.x = Convert.ToDouble(this.OffSetP2X.Text);
            kms.OffieSetGroupPoint2.y = Convert.ToDouble(this.OffSetP2Y.Text);

            this.Go.Visible = !this.ManualSteps.Checked;
            this.Next.Visible = false;
            this.ManualSteps.Visible = !this.ManualSteps.Checked;

            this.Refresh();

            // 開始
            this.GoNext = this.ManualSteps.Checked;

            kms_thread = new Thread(new ThreadStart(this.GoThread));
            kms_thread.Start();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            this.GoNext = true;
        }

    }

}
