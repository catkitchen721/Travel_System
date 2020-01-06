import requests
import time
from bs4 import BeautifulSoup
import os

# file = open("./hotel/hotels.txt", "w", encoding='UTF-8')

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


# basic_url = "https://taiwanstay.net.tw/legal-hotel-list?hohs_url=&holu_hotel_kind=&search_keyword=&hoci_city=%E5%85%A8%E9%83%A8&hoci_area=all&horm_price=&horm_room_num=&horm_room_type=&hohl_evaluation=all&hotel_facility_type=&start="
# for num in range(46):
# 	search_url = basic_url + str(num*10)
# 	print("num:", num)
# 	get_hotel_basic_info(search_url)
# 	time.sleep(1)
# print("finish")

city_file_name = []
def append_to_file(city_name, content):
	path = "./hotel/"
	# print(city_name)
	for item in city_file_name:
		if(city_name in item):
			path += (item + ".txt")
			with open(path, "a", encoding="utf-8") as file:
				file.write(content)
				file.close()
				return

def list_dir(path):
	for file in os.listdir(path):
		file = file.split(".")
		city_file_name.append(file[0])
	print(city_file_name)

def read_hotel_file(file_name):
	with open(file_name, "r", encoding="utf-8") as file:
		line_count = 0
		flag = False
		while(True):
			address = ""
			write_content = ""

			while(True):
				line_count += 1
				tmp = file.readline()
				write_content += tmp
				# split symbol
				if("- - - end - - -" in tmp):
					break
				elif("-" in tmp):

					continue
				elif(tmp == ""):
					flag =True
					break

				if("地點" in tmp):
					address_line = file.readline()
					address = address_line[:3]

					if("市" in address or "縣" in address):
						write_content += address_line
						# print("success")
						pass
					else:
						print("fail:({0}) {1}", line_count, address)

			append_to_file(address, write_content)
			if(flag):
				break

list_dir("./scene")

read_hotel_file("./hotel/hotels.txt")
