using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Travel_System {
    class ReadFile {
        //  site basic information
        public static List<string> site_name_list = new List<string>();
        public static List<string> url_list = new List<string>();
        public static List<List<string>> photo_list = new List<List<string>>();
        public static List<List<float>> location_list = new List<List<float>>();
        public static List<string> self_drive_list = new List<string>();
        public static List<List<string>> public_traffic_list = new List<List<string>>();
        //
        public static List<string> city_list = new List<string>();

        // area city dictionary
        public static Dictionary<string, List<string>> area_vs_city = new Dictionary<string, List<string>>();

        // stations of every sity
        public static Dictionary<string, List<string>> city_vs_stations = new Dictionary<string, List<string>>();

        public static Dictionary<string, string> station_code_dict = new Dictionary<string, string>();

        public static Dictionary<string, List<string>> station_info = new Dictionary<string, List<string>>();

        public static Dictionary<string, List<List<string>>> station_train_dict = new Dictionary<string, List<List<string>>>();

        public static Dictionary<string, List<string[]>> train_order_dict = new Dictionary<string, List<string[]>>();

        // 讀每個車站每日經過的火車車次

        // 讀火車班次資料
        public static void read_train_order() {
            string file_name = "../../../../data/train/train_routine.txt";
            StreamReader file = new StreamReader(file_name);
            string line;
            while (true) {
                line = file.ReadLine();  // "火車"
                if (line == null)
                    break;
                string train_order = file.ReadLine();  // 火車班次
                line = file.ReadLine();  // "-"
                List<string[]> substring_info = new List<string[]>();
                while (true) {
                    line = file.ReadLine();
                    if (line == "- - - end - - -") {
                        break;
                    }
                    string[] data = Regex.Split(line, " ");
                    substring_info.Add(data);
                }
                train_order_dict.Add(train_order, substring_info);
            }
        }

        public static void build_city_station_info() {
            string file_name = "../../../../data/train/station_info.txt";
            StreamReader file = new StreamReader(file_name);
            string line;

            string station_name = "";
            int station_code = 0;
            List<string> substring = new List<string>();
            string city = "";
            while (true) {
                line = file.ReadLine();

                if (String.Compare("station name", line) == 0) {
                    line = file.ReadLine();
                    station_name = line;
                    //substring.Add(station_name);
                }
                else if (String.Compare("station code", line) == 0) {
                    line = file.ReadLine();
                    station_code = int.Parse(line);
                    substring.Add(station_code.ToString());
                }
                else if (String.Compare("city", line) == 0) {
                    line = file.ReadLine();
                    city = line;
                    substring.Add(city);
                }
                else if (String.Compare("- - - end - - -", line) == 0) {
                    try {
                        station_code_dict.Add(station_name, station_code.ToString());
                    }
                    catch (Exception e) {
                        ;
                    }
                    if (!city_list.Contains(city))
                        city_list.Add(city);
                    station_info.Add(station_name, substring);
                    station_name = "";
                    station_code = 0;
                    substring = new List<string>();
                    city = "";
                }
                else if (line == null)
                    break;
            }

        }

        public static int read_scene_file(string file_name) {
            file_name = "../../../../data/scene/" + file_name;
            StreamReader file = new StreamReader(file_name);
            string line;
            int list_case = 0;
            List<string> substring_photo = new List<string>();
            List<float> substring_location = new List<float>();
            List<string> substring_traffic = new List<string>();
            int num = 0, count = 0;
            line = file.ReadLine();
            while (true) {
                line = file.ReadLine();
                if (line == null)
                    break;
                if (String.Compare(line, "-") == 0) {
                    if (list_case == 2) {
                        //photo_list.Add(substring_photo);
                        //substring_photo = new List<string>();
                    }
                    else if (list_case == 3) {
                        photo_list.Add(substring_photo);
                        location_list.Add(substring_location);
                        substring_location = new List<float>();
                        substring_photo = new List<string>();
                        num += 1;
                    }
                    else if (list_case == 5) {
                        public_traffic_list.Add(substring_traffic);
                        line = file.ReadLine();  // - - - end - - -
                        substring_traffic = new List<string>();

                    }
                    list_case = (list_case + 1) % 6;
                    line = file.ReadLine();
                    continue;
                }

                switch (list_case) {
                    case 0:
                        site_name_list.Add(line);
                        break;
                    case 1:
                        url_list.Add(line);
                        break;
                    case 2:
                        substring_photo.Add(line);
                        break;
                    case 3:
                        substring_location.Add(float.Parse(line));
                        break;
                    case 4:
                        self_drive_list.Add(line);
                        break;
                    case 5:
                        int self_count = self_drive_list.Count;
                        if (line.Length <= 2 || self_count == 0) {
                            substring_traffic.Add("");
                            break;
                        }

                        if (self_count > 0 && String.Compare(line.Substring(0, 2), self_drive_list[self_count - 1].Substring(0, 2)) == 0)
                            ;
                        else
                            substring_traffic.Add(line);

                        break;
                    default:
                        return 20;
                }
                count++;

            }

            return num;
        }

        public static void read_area_city_file(string file_name) {
            // 讀取 area_city.txt 內的分區縣市名單
            file_name = "../../../../data/" + file_name;
            StreamReader file = new StreamReader(file_name);

            while (true) {
                string area_name = file.ReadLine();
                List<string> substring = new List<string>();
                if (area_name == null)
                    break;
                while (true) {
                    string line = file.ReadLine();
                    if (String.Compare(line, "-") == 0) {
                        break;
                    }
                    substring.Add(line);
                }
                area_vs_city.Add(area_name, substring);
            }
        }

        public static void clear_data() {
            site_name_list.Clear();
            url_list.Clear();
            photo_list.Clear();
            location_list.Clear();
            self_drive_list.Clear();
            public_traffic_list.Clear();
            //site_map.marker_list.Clear();
            //site_map.marker.Dispose();
            //site_map.marker_overlay.Clear();
            
    }

    }
}
