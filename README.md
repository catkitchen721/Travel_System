# Travel System 旅遊景點系統
C# 視窗程式設計 Final Project 
```
For Traveling
```
## 初步想法架構
1. **資料庫**記錄每個使用者儲存下來的景點資料
2. 分層搜尋縣市景點資料，並且展示附近住宿資料
3. 連結 google map API 地圖展示
4. 結合火車時刻查詢

optional 其它想法:
- [ ] 建立群組共享景點資料
- [ ] 匯出景點資料到 google 的 [我的地圖 My Map](https://www.google.com/intl/zh-TW/maps/about/mymaps/) 進行共享

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
