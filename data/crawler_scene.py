import requests
from bs4 import BeautifulSoup


area_dict = {"north": "1", "center": "2", "south": "3", "east": "4"}

def grab_area_city(area_key):
	'''
	抓取縣市
	'''
	area_url = "https://www.taiwan.net.tw/m1.aspx?sNo=000050" + area_dict[area_key]
	res = requests.get(area_url)
	content = res.content.decode()
	print(area_key, "：")

	soup = BeautifulSoup(content, 'html.parser')
	grid = soup.find(class_="grid circularbtn-list")

	for item in grid.find_all("a"):
		if(item.find(class_="circularbtn-title")):
			city = item.find(class_="circularbtn-title").string
			# print(city, end="：")
			grab_city_site(city, "https://www.taiwan.net.tw/" + item["href"], area_key)
		#print(item["href"])

def grab_city_site(county, county_url, area):
	'''
	一個縣市景點
	'''
	res = requests.get(county_url)
	content = res.content.decode()
	file_name = area + "_" + county + ".txt"
	file = open(file_name, "w", encoding='UTF-8')

	# 取得資料進行整理
	soup = BeautifulSoup(content, 'html.parser')
	grid = soup.find(class_="grid card-list card-style-columns").find_all("li")
	base_url = "https://www.taiwan.net.tw/"
	for item in grid:
		try:
			gets = item.find(class_="card-link")
		except:
			pass
		href = base_url + gets["href"]
		title = gets["title"]
		print(title)
		line = "景點名\n" + title + "\n" + "-\n連結\n" + href + "\n-\n"
		try:
			file.write(line)
		except:
			print("error:", line)
			file.write("ERROR\n-\n")
		# print("景點名\n%s\n-\n連結\n%s-" % (title, href))
		grab_site_info(href, file)
		
	file.close()
		


def get_photo_url(soup, file):
	grid = soup.find(class_="album")
	file.write("照片\n")
	for item in grid:
		if(str(type(item)) == "<class 'bs4.element.Tag'>"):
			gets = item.find(class_="lazyload")
			line = gets["data-src"] + "\n"
			# print(gets["data-src"])
			file.write(line)
	file.write("-\n")

def get_location(soup, file):
	# location
	info = soup.find(class_="info-table")
	info = info.find_all("dd")
	for item in info:
		if(str(type(item)) != "<class 'bs4.element.Tag'>"):
			continue

		if("/" in item.string):
			string = str(item.string).replace("/", " ").split(" ")
			# print("經緯度：", string[0], string[1], sep="\n")
			line = "經緯度\n" + string[0] + "\n" + string[1] + "\n-\n"
			file.write(line)
			break

def get_traffic(soup, file):
	info = soup.find("article")

	# for self drive
	file.write("自行開車\n")
	# print("自行開車：")
	try:
		line = str(info.find("p").string) + "\n-\n"
		# print(info.find("p").string)
		file.write(line)
	except:
		file.write("None\n-\n")
		# print("None")

	# for public traffic
	file.write("大眾交通\n")
	if(info.find("li")):
		traffic = info.find_all("li")
	else:
		traffic = info.find_all("p")
	try:
		for item in traffic:
			item = str(item)
			item = item[item.index(">")+1:item.index("。")]
			if("<" in item):
				item = item[:item.index("<")]
			line = item + "\n"
			file.write(line)
			# print(item[item.index(">")+1:item.index("。")])
		file.write("-\n")
	except:
		file.write("None\n-\n")
		# print("None")

def grab_site_info(url, file):
	'''
	單一景點內部資料
	'''
	# url_title = "https://www.taiwan.net.tw/"

	res = requests.get(url)
	content = res.content.decode()

	# 取得資料進行整理
	soup = BeautifulSoup(content, 'html.parser')
	get_photo_url(soup, file)
	# print("-")
	get_location(soup, file)
	# print("-")
	get_traffic(soup, file)
	file.write("- - - end - - -\n")
	print("- - - end - - -")

def crawler_all_area():
	for area in area_dict:
		grab_area_city("north")

print("finish")
