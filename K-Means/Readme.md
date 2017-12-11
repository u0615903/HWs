# K-Means

K-Means 參考：
 - https://zh.wikipedia.org/wiki/K-%E5%B9%B3%E5%9D%87%E7%AE%97%E6%B3%95
 - https://en.wikipedia.org/wiki/K-means_clustering
  
英文的比較詳細


# About this program

K-Means 分群算法，有不少演變，這個程式實作基本的方法。
幾個重點：
 - 程式分群，為兩群。
 - 起始分群座標會影響分群結果。
 - 結束條件 |E(m+1) - E(m)| <= e ，會影響執行時間(次數)。


# Algorithm

 0. Step 0. 計算出所有座標點的中心位置 (Cx, Cy)。
 1. Step 1. 設定第一群的中心點，設定第二群的中心點。
 2. Step 2. 計算出所有點與第一群中心點的幾何距離，計算出所有點與第二群中心點的幾何距離。
 3. Step 3. 依最接近原則，進行分 2 群，各群之點與其群中心的幾何距離總和，也分別算出。
 4. Step 4. 分別算出新的兩群的中心座標。
 5. Step 5. 若各群之點與中心的距離總和 大於 threshold，就回到 Step 2. ，否則就結束計算。

# 以下列出兩種起始中心座標的結果

## 起始中心座標 (Cx - 0.5, Cy - 0.5), (Cx + 0.5, Cy + 0.5)

 * Start
 
![Start](https://github.com/u0615903/HWs/blob/master/K-Means/kmeans%20001.png)

 * Round 1
 
![Round 1](https://github.com/u0615903/HWs/blob/master/K-Means/kmeans%20002.png)

 * Round 2
 
![Round 2](https://github.com/u0615903/HWs/blob/master/K-Means/kmeans%20003.png)

 * Round 3 - End
 
![Round 3 - End](https://github.com/u0615903/HWs/blob/master/K-Means/kmeans%20004.png)


## 起始中心座標 (Cx - 1.5, Cy - 1.5), (Cx - 0.5, Cy - 0.5)

 * Start
 
![Start](https://github.com/u0615903/HWs/blob/master/K-Means/kmeans%20005.png)

 * Round 1
 
![Round 1](https://github.com/u0615903/HWs/blob/master/K-Means/kmeans%20006.png)

 * Round 2 - End
 
![Round 2 - End](https://github.com/u0615903/HWs/blob/master/K-Means/kmeans%20007.png)

