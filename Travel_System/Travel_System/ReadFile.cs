using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Travel_System {
    class ReadFile {
        public static List<string> site_name_list = new List<string>();
        public static List<string> url_list = new List<string>();
        public static List<List<string>> photo_list = new List<List<string>>();
        public static List<List<float>> location_list = new List<List<float>>();
        public static List<string> self_drive_list = new List<string>();
        public static List<List<string>> public_traffic_list = new List<List<string>>();
        
        public static int read_file(string file_name) {
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
                        photo_list.Add(substring_photo);
                    }
                    else if (list_case == 3) {
                        location_list.Add(substring_location);
                    }
                    else if (list_case == 5) {
                        public_traffic_list.Add(substring_traffic);
                        line = file.ReadLine();
                        num += 1;
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
                        substring_location.Add((float)(0.2));
                        break;
                    case 4:
                        self_drive_list.Add(line);
                        break;
                    case 5:
                        substring_traffic.Add(line);
                        break;
                    default:
                        return 20;
                }
                count++;
                
            }
            return num;
        }
        
    }
}
