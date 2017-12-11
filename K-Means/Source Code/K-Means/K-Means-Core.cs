using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace K_Means
{

    public class cord
    {
        public double x { get; set; }
        public double y { get; set; }

        public cord()
        { x = 0; y = 0; }

        public cord(double tx, double ty)
        { x = tx; y = ty; }
    }

    public class kmeans
    {
        public cord OffieSetGroupPoint1 = new cord(-0.5, -0.5);
        public cord OffieSetGroupPoint2 = new cord(0.5, 0.5);

        public List<cord> data = new List<cord>()
            {
                new cord() { x = 6, y = (-3) },
                new cord() { x = 3, y = 1 },
                new cord() { x = 5, y = 7 },
                new cord() { x = (-2), y = (-3)},
                new cord() { x = (-4), y = 3},
                new cord() { x = 3, y = 7},
                new cord() { x = (-2), y=2 }
            };

        private void clear(Graphics g)
        {
            Pen pen;

            g.Clear(Color.White);


            pen = new Pen(Color.LightGray, 1);
            for (int i = 10; i <= 410; i += 10)
            {
                g.DrawLine(pen, i, 10, i, 410);
                g.DrawLine(pen, 10, i, 410, i);
            }

            pen = new Pen(Color.Blue, 1);
            g.DrawRectangle(pen, 10, 10, 400, 400);
            g.DrawLine(pen, 210, 10, 210, 410);
            g.DrawLine(pen, 10, 210, 410, 210);
        }

        public cord center(List<cord> data)
        {
            cord result;

            result = new cord();
            foreach (cord item in data)
            {
                result.x += item.x;
                result.y += item.y;
            }

            result.x /= data.Count;
            result.y /= data.Count;

            return result;
        }

        public double distance(cord p1, cord p2)
        {
            return Math.Sqrt(Math.Pow((p1.x - p2.x), 2) + Math.Pow((p1.y - p2.y), 2));
        }

        public void Go(Graphics g, Form f)
        {
            bool keepGoing;

            int loop;

            double dist1;
            double dist2;

            double prevDistSum1;
            double prevDistSum2;

            double nextDistSum1;
            double nextDistSum2;

            cord centerPoint;

            cord groupCenterPoint1;
            cord groupCenterPoint2;

            List<cord> group1;
            List<cord> group2;

            Brush btext;

            Brush b1;
            Brush b2;
            Brush bg;


            group1 = new List<cord>();
            group2 = new List<cord>();

            this.clear(g);

            btext = new SolidBrush(Color.Black);
            b1 = new SolidBrush(Color.Blue);
            b2 = new SolidBrush(Color.Green);
            bg = new SolidBrush(Color.Red);

            // Step 0. 
            // 計算出所有座標點的中心位置 (Cx, Cy)
            centerPoint = this.center(data);

            foreach (cord item in data)
            {
                g.FillPie(b1, (float)((item.x * 10) + 206), (float)((item.y * 10) + 206), (float)8, (float)8, (float)0, (float)360);
            }

            // Step 1. 
            // 設定第一群的中心點
            groupCenterPoint1 = new cord() { x = centerPoint.x + OffieSetGroupPoint1.x, y = centerPoint.y + OffieSetGroupPoint1.y };            
            // 設定第二群的中心點
            groupCenterPoint2 = new cord() { x = centerPoint.x + OffieSetGroupPoint2.x, y = centerPoint.y + OffieSetGroupPoint2.y };            

            g.FillPie(bg, (float)((groupCenterPoint1.x * 10) + 206), (float)((groupCenterPoint1.y * 10) + 206), (float)8, (float)8, (float)0, (float)360);
            g.FillPie(bg, (float)((groupCenterPoint2.x * 10) + 206), (float)((groupCenterPoint2.y * 10) + 206), (float)8, (float)8, (float)0, (float)360);

            f.Refresh();
            f.Invalidate();
            Thread.Sleep(1000);

            loop = 1;
            keepGoing = true;
            do
            {
                this.clear(g);

                g.DrawString("Current: " + loop.ToString(), f.Font, btext, 20, 20);

                f.Refresh();
                f.Invalidate();

                prevDistSum1 = 0;
                prevDistSum2 = 0;
                group1.Clear();
                group2.Clear();
                foreach (cord item in data)
                {
                    // Step 2.
                    // 計算出所有點與第一群中心點的幾何距離                
                    dist1 = this.distance(item, groupCenterPoint1);
                    // 計算出所有點與第二群中心點的幾何距離
                    dist2 = this.distance(item, groupCenterPoint2);

                    // Step 3. 
                    // 依最接近原則，進行分 2 群，各群之點與其群中心的幾何距離總和，也分別算出
                    if (dist1 <= dist2)
                    { group1.Add(item); prevDistSum1 += dist1; }
                    else
                    { group2.Add(item); prevDistSum2 += dist2; }

                }

                // Step 4.
                // 分別算出新的兩群的中心座標
                groupCenterPoint1 = this.center(group1);
                groupCenterPoint2 = this.center(group2);

                g.FillPie(bg, (float)((groupCenterPoint1.x * 10) + 206), (float)((groupCenterPoint1.y * 10) + 206), (float)8, (float)8, (float)0, (float)360);
                g.FillPie(bg, (float)((groupCenterPoint2.x * 10) + 206), (float)((groupCenterPoint2.y * 10) + 206), (float)8, (float)8, (float)0, (float)360);

                // Step 5.
                // 若各群之點與中心的距離總和 大於 threshold，就回到 Step 2. ，否則就結束計算
                nextDistSum1 = 0;
                nextDistSum2 = 0;
                foreach (cord item in group1)
                {
                    nextDistSum1 += this.distance(item, groupCenterPoint1);
                    g.FillPie(b1, (float)((item.x * 10) + 206), (float)((item.y * 10) + 206), (float)8, (float)8, (float)0, (float)360);
                }

                foreach (cord item in group2)
                {
                    nextDistSum2 += this.distance(item, groupCenterPoint2);
                    g.FillPie(b2, (float)((item.x * 10) + 206), (float)((item.y * 10) + 206), (float)8, (float)8, (float)0, (float)360);
                }

                f.Refresh();
                f.Invalidate();
                Thread.Sleep(1000);

                keepGoing = (Math.Abs((prevDistSum1 + prevDistSum2) - (nextDistSum1 + nextDistSum2)) >= 1.0);
                loop++;
            }
            while (keepGoing);

        }

    }

}