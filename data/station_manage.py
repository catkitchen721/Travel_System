import pandas as pd

global station_train_dict
station_train_dict = {}

def write_station_info():
	stations = pd.read_csv("station_number.csv")
	wrtie_in_file = open("station_info.txt", "w", encoding="utf-8")
	for num in range(len(stations)):
		station_name = stations.iloc[num]["stationName"]
		station_number = stations.iloc[num]["stationCode"]
		station_train_dict[station_number] = [station_name, [], []]
		# print(station_train_dict[station_number])
		address = (stations.iloc[num]["stationAddrTw"].split(" "))[0]

		location = stations.iloc[num]["gps"].split(" ")
		location_lat = location[0]
		location_lon = location[1]

		wrtie_in_file.write("station name\n" + station_name + "\n-\n")
		wrtie_in_file.write("station code\n" + str(station_number) + "\n-\n")
		wrtie_in_file.write("city\n" + address + "\n-\n")
		wrtie_in_file.write("location\n" + str(location_lon) + "\n" + str(location_lat) + "\n-\n- - - end - - -\n")

	wrtie_in_file.close()

from xml.dom.minidom import parse
# 獲取 python節點下得所有id屬性
def train_routine():
	# 獲取test.xml文件物件
	doc = parse("routine.xml")
	output_file = open("train_routine.txt", "w", encoding="utf-8")

	count = 0
	for train in doc.getElementsByTagName("TrainInfo"):
		# print("火車:", train.getAttribute("Train"))
		train_number = train.getAttribute("Train")
		if("每日行駛" not in train.getAttribute("Note")):
			continue
		output_file.write("火車" + "\n" + str(train_number) + "\n-\n")
		for node in train.getElementsByTagName("TimeInfo"):
			# 獲取標籤ID屬性
			arr = node.getAttribute("ARRTime")
			dep = node.getAttribute("DEPTime")
			station = int(node.getAttribute("Station"))
			order = node.getAttribute("Order")

			if(station not in station_train_dict.keys()):
				continue

			station_train_dict[station][1].append(train_number)
			station_train_dict[station][2].append(order)

			# 列印輸出
			# print(station, arr, dep, order)
			output_file.write(str(order) + " " + str(station) + " " + arr + " " + dep + "\n")
		# print("- - - end - - -\n")
		output_file.write("- - - end - - -\n")
		count += 1
	print("total:" + str(count))

def write_station_train_info():
	output_file = open("station_train.txt", "w", encoding="utf-8")
	for station in station_train_dict.keys():
		name = station_train_dict[station][0]
		# print(station_train_dict[station][0], station)
		output_file.write(name + "\n" + str(station) + "\n-\n")
		for num in range(len(station_train_dict[station][1])):
			train_number = station_train_dict[station][1][num]
			order = station_train_dict[station][2][num]
			output_file.write(str(train_number) + " " + str(order) + "\n")
		output_file.write("- - - end - - -\n")

write_station_info()
train_routine()
write_station_train_info()
