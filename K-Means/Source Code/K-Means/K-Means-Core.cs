using System;
using System.Collections.Generic;


namespace K_Means
{
    /// <summary>
    /// 座標點。
    /// </summary>
    public class cord
    {
        /// <summary>
        /// 座標點資料索引。
        /// </summary>
        public int index { get; set; }

        /// <summary>
        /// X 軸座標位置。
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// Y 軸座標位置。
        /// </summary>
        public double y { get; set; }

        /// <summary>
        /// 到群 1 中心距離。
        /// </summary>
        public double dgp1 { get; set; }
        /// <summary>
        /// 到群 2 中心距離。
        /// </summary>
        public double dgp2 { get; set; }

        /// <summary>
        /// constructor.
        /// </summary>
        public cord()
        { index = 0; x = 0; y = 0; dgp1 = 0; dgp2 = 0; }

        /// <summary>
        /// constructor.
        /// </summary>
        /// <param name="i">座標點資料索引。</param>
        /// <param name="tx">初始 x。</param>
        /// <param name="ty">初始 y。</param>
        public cord(int i, double tx, double ty)
        { index = i; x = tx; y = ty; }
    }

    /// <summary>
    /// K-Means 類別。
    /// </summary>
    public class kmeans
    {
        /// <summary>
        /// 初始群中心點差異 1。
        /// </summary>
        public cord OffieSetGroupPoint1 = new cord(0, -0.5, -0.5);
        /// <summary>
        /// 初始群中心點差異 2。
        /// </summary>
        public cord OffieSetGroupPoint2 = new cord(0, 0.5, 0.5);

        /// <summary>
        /// 初始座標點集合， 7 點。
        /// </summary>
        public List<cord> data = new List<cord>()
            {
                new cord() { index = 0, x = 6, y = (-3) },
                new cord() { index = 1,  x = 3, y = 1 },
                new cord() { index = 2, x = 5, y = 7 },
                new cord() { index = 3, x = (-2), y = (-3)},
                new cord() { index = 4, x = (-4), y = 3},
                new cord() { index = 5, x = 3, y = 7},
                new cord() { index = 6, x = (-2), y=2 }
            };



        /// <summary>
        /// 計算傳入的座標點的中心座標。
        /// </summary>
        /// <param name="data">傳入的座標點。</param>
        /// <returns>回傳：計算的中心座標。</returns>
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

        /// <summary>
        /// 計算兩座標點間的距離。
        /// </summary>
        /// <param name="p1">座標點一。</param>
        /// <param name="p2">座標點二。</param>
        /// <returns>回傳：兩座標點間的距離。</returns>
        public double distance(cord p1, cord p2)
        {
            //    --------------------------- 
            //  \/ (x1 - x2)^2 + (y1 - y2)^2
            return Math.Sqrt(Math.Pow((p1.x - p2.x), 2) + Math.Pow((p1.y - p2.y), 2));
        }

        /// <summary>
        /// 進行分群運算。
        /// </summary>
        /// <param name="g"></param>
        /// <param name="f"></param>
        public void Go(Action<int, IList<cord>> output, ref bool NextControl)
        {
            bool ori_NextControl;
            bool keepGoing;

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


            ori_NextControl = NextControl;
            NextControl = !ori_NextControl;

            group1 = new List<cord>();
            group2 = new List<cord>();

            #region 邏輯步驟
            /* Step 0. 
             *     計算出所有座標點的中心位置 (Cx, Cy)
             * Step 1.
             *     設定第一群的中心點
             *     設定第二群的中心點
             * Step 2.    
             *     計算出所有點與第一群中心點的幾何距離
             *     計算出所有點與第二群中心點的幾何距離
             * Step 3.
             *     依最接近原則，進行分 2 群，各群之點與其群中心的幾何距離總和，也分別算出
             * Step 4.
             *     分別算出新的兩群的中心座標
             * Step 5.
             *     若各群之點與中心的距離總和 大於 threshold，就回到 Step 2. ，否則就結束計算
             */
            #endregion

            #region 輸出資料

            // 輸出資料 演算步驟
            output(97, new List<cord>() { new cord(0, 0, 0) });

            #endregion

            #region Step 0.

            // 計算出所有座標點的中心位置 (Cx, Cy)
            centerPoint = this.center(data);

            #region 輸出資料

            // 輸出資料 (畫面清除)
            output(0, null);

            // 輸出資料 (所有座標點)
            output(1, data);

            // 輸出資料 (初始中心座標點)
            output(2, new List<cord>() { centerPoint });

            #region 單步前進控制

            if (ori_NextControl)
            {
                // 輸出資料 下一步控制開始
                output(98, null);
            }
            while (!NextControl) { };
            if (ori_NextControl)
            {
                // 輸出資料 下一步控制結束
                output(99, null);
                NextControl = false;
            }

            #endregion

            // 輸出資料 演算步驟
            output(97, new List<cord>() { new cord(0, 1, 0) });

            #endregion

            #endregion

            #region Step 1.

            // 設定第一群的中心點
            groupCenterPoint1 = new cord() { x = centerPoint.x + OffieSetGroupPoint1.x, y = centerPoint.y + OffieSetGroupPoint1.y };
            // 設定第二群的中心點
            groupCenterPoint2 = new cord() { x = centerPoint.x + OffieSetGroupPoint2.x, y = centerPoint.y + OffieSetGroupPoint2.y };

            #region 輸出資料

            // 輸出資料 (畫面清除)
            output(0, null);

            // 輸出資料 (所有座標點)
            output(1, data);

            // 輸出資料 (各群的中心座標點)
            output(3, new List<cord>() { groupCenterPoint1, groupCenterPoint2 });

            #region 單步前進控制

            if (ori_NextControl)
            {
                // 輸出資料 下一步控制開始
                output(98, null);
            }
            while (!NextControl) { };
            if (ori_NextControl)
            {
                // 輸出資料 下一步控制結束
                output(99, null);
                NextControl = false;
            }

            #endregion

            // 輸出資料 演算步驟
            output(97, new List<cord>() { new cord(0, 2.3, 0) });

            #endregion

            #endregion

            keepGoing = true;
            do
            {
                prevDistSum1 = 0;
                prevDistSum2 = 0;
                group1.Clear();
                group2.Clear();
                foreach (cord item in data)
                {
                    #region Step 2.

                    // 計算出所有點與第一群中心點的幾何距離                
                    item.dgp1 = dist1 = this.distance(item, groupCenterPoint1);
                    // 計算出所有點與第二群中心點的幾何距離
                    item.dgp2 = dist2 = this.distance(item, groupCenterPoint2);

                    // 輸出資料 (所有座標點與群中心點的幾何距離)
                    output(4, data);

                    #endregion

                    #region Step 3.

                    // 依最接近原則，進行分 2 群，各群之點與其群中心的幾何距離總和，也分別算出
                    if (dist1 <= dist2)
                    {
                        group1.Add(item); prevDistSum1 += dist1;

                        #region 輸出資料

                        // 輸出資料 (第一群座標點)
                        output(5, new List<cord>() { item });

                        #endregion
                    }
                    else
                    {
                        group2.Add(item); prevDistSum2 += dist2;

                        #region 輸出資料

                        // 輸出資料 (第二群座標點)
                        output(6, new List<cord>() { item });

                        #endregion

                    }

                    #endregion

                    #region 單步前進控制

                    if (ori_NextControl)
                    {
                        // 輸出資料 下一步控制開始
                        output(98, null);
                    }
                    while (!NextControl) { };
                    if (ori_NextControl)
                    {
                        // 輸出資料 下一步控制結束
                        output(99, null);
                        NextControl = false;
                    }

                    #endregion
                }

                #region 輸出資料

                // 輸出資料 目前 (所有座標點與各群中心點的幾何距離總和)
                output(7, new List<cord>() { new cord(0, prevDistSum1, prevDistSum2) });

                // 輸出資料 演算步驟
                output(97, new List<cord>() { new cord(0, 4, 0) });

                #endregion

                #region Step 4.

                // 分別算出新的兩群的中心座標
                groupCenterPoint1 = this.center(group1);
                groupCenterPoint2 = this.center(group2);

                #region 輸出資料

                // 輸出資料 (畫面清除)
                output(0, null);

                // 輸出資料 (所有座標點)
                output(1, data);

                // 輸出資料 (第一群座標點)
                output(9, group1);

                // 輸出資料 (第二群座標點)
                output(10, group2);

                // 輸出資料 (各群的中心座標點)
                output(3, new List<cord>() { groupCenterPoint1, groupCenterPoint2 });

                #region 單步前進控制

                if (ori_NextControl)
                {
                    // 輸出資料 下一步控制開始
                    output(98, null);
                }
                while (!NextControl) { };
                if (ori_NextControl)
                {
                    // 輸出資料 下一步控制結束
                    output(99, null);
                    NextControl = false;
                }

                #endregion

                // 輸出資料 演算步驟
                output(97, new List<cord>() { new cord(0, 5, 0) });

                #endregion

                #endregion

                #region Step 5.

                // 若各群之點與中心的距離總和 大於 threshold，就回到 Step 2. ，否則就結束計算
                nextDistSum1 = 0;
                nextDistSum2 = 0;
                foreach (cord item in group1)
                {
                    nextDistSum1 += this.distance(item, groupCenterPoint1);
                }

                foreach (cord item in group2)
                {
                    nextDistSum2 += this.distance(item, groupCenterPoint2);
                }

                #region 輸出資料

                // 輸出資料 新 (所有座標點與的各群中心點的幾何距離總和)
                output(8, new List<cord>() { new cord(0, nextDistSum1, nextDistSum2) });

                #region 單步前進控制

                if (ori_NextControl)
                {
                    // 輸出資料 下一步控制開始
                    output(98, null);
                }
                while (!NextControl) { };
                if (ori_NextControl)
                {
                    // 輸出資料 下一步控制結束
                    output(99, null);
                    NextControl = false;
                }

                #endregion

                // 輸出資料 演算步驟
                output(97, new List<cord>() { new cord(0, 2.3, 0) });

                #endregion

                // Threshold Testing.
                keepGoing = (Math.Abs((prevDistSum1 + prevDistSum2) - (nextDistSum1 + nextDistSum2)) >= 1.0);

                #endregion
            }
            while (keepGoing);

            #region 輸出資料

            // 輸出資料 重置
            output(100, null);

            #endregion

        }

    }

}