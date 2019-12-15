# Travel System 旅遊景點系統
C# 視窗程式設計 Final Project 
```
For Traveling
```
進度文件 [HackMD](https://hackmd.io/ko7Dfvz0SxCt5Dv3YDDDzQ?view)


## 初步想法架構
1. **資料庫**記錄每個使用者儲存下來的景點資料
	- 希望可以做個資料庫，判斷登入者是否合法
	- 每個使用者都可以記錄自己過去曾經納入名單的景點
3. 分層搜尋縣市景點資料，並且展示附近住宿資料
4. 連結 google map API 地圖展示
5. 結合火車時刻查詢

optional 其它想法:
- [ ] 建立群組共享景點資料(應該也還是要靠資料庫)
- [ ] 匯出景點資料到 google 的 [我的地圖 My Map](https://www.google.com/intl/zh-TW/maps/about/mymaps/) 進行共享：[匯入檔案](https://support.google.com/mymaps/answer/3024836?co=GENIE.Platform%3DDesktop&hl=zh-Hant) 應該用 csv 方式

#### 構想流程圖
![](https://i.imgur.com/sRd404e.jpg)


## 分檔介紹
### login
最一開始的初始畫面，使用者可以選擇登入、註冊或檢視系統資訊(關於這個東西的簡介)。
<hr/>

### Taiwan_map
進入之後第一個選擇地區的地方，如果滑移到地區上面會有分圖浮現，旁邊的字也會顯示地區名稱。
- [ ] 分圖位置還需要再設置(因為我是手動調的，所以還不太準) 
<hr/>

### system_info
系統資訊，用 TextBox 簡單放個介紹。
