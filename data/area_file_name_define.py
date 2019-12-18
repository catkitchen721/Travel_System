import os

total_file_name_list = []
area_dict = {}
def all_file_name(path):
	for file in os.listdir(path):
		total_file_name_list.append(file)

def split_area(item_list):
	for item in item_list:
		item = item.split("_")
		area, name = item[0], item[1].split(".")[0]
		try:
			area_dict[area].append(name)
		except:
			area_dict[area] = []
			area_dict[area].append(name)

def write_area_city_file(item_dict):
	with open("area_city.txt", "w", encoding="utf-8") as file:
		for item in item_dict:
			file.write(item + "\n")
			for city in item_dict[item]:
				file.write(city + "\n")
			file.write("-\n")

all_file_name("./scene")
split_area(total_file_name_list)
write_area_city_file(area_dict)
# print(area_dict)