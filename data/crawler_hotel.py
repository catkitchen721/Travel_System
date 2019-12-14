import requests
import time
from bs4 import BeautifulSoup

file = open("./hotel/hotels.txt", "w", encoding='UTF-8')

def get_hotel_basic_info(url):
	res = requests.get(url)
	content = res.content.decode()

	# 取得資料進行整理
	soup = BeautifulSoup(content, 'html.parser')
	content = soup.find_all(class_="row bg-color-white margin-bottom-20")
	for item in content:

		photo = item.find(class_="col-sm-5 sm-margin-bottom-20").find("img")["src"]
		
		info = item.find(class_="col-sm-4 news-v3")
		info = item.find("a")
		href = info["href"]
		name = info.string.replace(" ", "")

		address = item.find("p").find("a")
		address = address.text.replace(" ", "").replace("\n", "")

		star = len(item.find_all(class_="fa fa-star"))


		file.write("名稱%s-\n" % name)
		file.write("地點\n%s\n-\n" % address)
		file.write("星等\n%s\n-\n" % star)
		file.write("照片\n%s\n-\n" % photo)
		file.write("連結\n%s\n- - - end - - -\n" % href)

basic_url = "https://taiwanstay.net.tw/legal-hotel-list?hohs_url=&holu_hotel_kind=&search_keyword=&hoci_city=%E5%85%A8%E9%83%A8&hoci_area=all&horm_price=&horm_room_num=&horm_room_type=&hohl_evaluation=all&hotel_facility_type=&start="
for num in range(46):
	search_url = basic_url + str(num*10)
	print("num:", num)
	get_hotel_basic_info(search_url)
	time.sleep(1)
print("finish")