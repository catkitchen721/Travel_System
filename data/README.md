# data 來源
目前用 python 執行爬蟲，之後來得及的話會試著轉到 C# 上。  

### crawler.py
python 爬蟲檔

### 資料夾  
##### scene : 景點資料  
資料格式範例 
```
景點名
士林夜市
-
連結
https://www.taiwan.net.tw/m1.aspx?sNo=0001090&id=154
-
照片
https://www.taiwan.net.tw/att/1/big_scenic_spots/pic_154_14.jpg
https://www.taiwan.net.tw/att/1/big_scenic_spots/pic_154_15.jpg
https://www.taiwan.net.tw/att/1/big_scenic_spots/pic_154_12.jpg
-
經緯度
121.52440
25.088628
-
自行開車
國道1號→臺北交流道下→重慶北路四段→百齡橋→承德路四段→承德路四段292巷→大南路→基河路。
-
大眾交通
搭高鐵或臺鐵至臺北站下→轉搭臺北捷運至劍潭站下
搭臺北市雙層觀光巴士至捷運劍潭站下
-
- - - end - - -
```
目前還沒爬 `說明文字` 的部份，如果之後有需要會補上。  

##### hotel : 住宿資料  
資料格式範例  
```
名稱
帝豪飯店
-
地點
高雄市三民區安寧街387號
-
星等
3
-
照片
https://taiwan.taiwanstay.net.tw/twpic/17282.jpg
-
連結
https://taiwanstay.net.tw/room/502
- - - end - - -
```
