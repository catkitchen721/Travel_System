using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Travel_System {
    public partial class Taiwan_map : Form {
        public const string pic_folder = "../../../../image/";
        string[] image_list = new string[5] { "north_area.png", "center_area.png", "south_area.png", "east_area.png", "outer_area.png" };
        string[] area_name = new string[5] { "北部地區", "中部地區", "南部地區", "東部地區", "離島地區" };
        string[] area_file_header = new string[5] { "north", "center", "south", "east", "outer" };
        PictureBox[] area_picbox;

        public Taiwan_map() {
            InitializeComponent();
            name.Text = "";
            // initialize map info
            north_area.Location = new Point(185, 0);
            center_area.Location = new Point(60, 80);
            south_area.Location = new Point(50, 220);
            east_area.Location = new Point(170, 70);
            outer_area.Location = new Point(25, 190);
            taiwan.Location = new Point(100, 70);

            // transparent background
            north_area.BackColor = Color.Transparent;
            north_area.Parent = taiwan;
            center_area.BackColor = Color.Transparent;
            center_area.Parent = taiwan;
            south_area.BackColor = Color.Transparent;
            south_area.Parent = taiwan;
            east_area.BackColor = Color.Transparent;
            east_area.Parent = taiwan;
            outer_area.BackColor = Color.Transparent;
            outer_area.Parent = taiwan;

            area_picbox = new PictureBox[5] { north_area, center_area, south_area, east_area, outer_area };
        }

        private void Taiwan_map_Load(object sender, EventArgs e) {
            Image content = Image.FromFile(pic_folder + "taiwan.png");
            taiwan.Image = content;
            ReadFile.read_area_city_file("area_city.txt");
            ReadFile.build_city_station_info();
            ReadFile.read_train_order();
            string d = read_station_train_file();
            //MessageBox.Show("count=" + d);
        }

        public static string read_station_train_file() {
            string file_name = "../../../../data/train/station_train.txt";
            StreamReader file = new StreamReader(file_name);
            string line;
            int count = 0;
            string tmp = "";
            while (true) {

                string name = file.ReadLine();
                if (name == null) {
                    break;
                }
                List<List<string>> concat = new List<List<string>>();
                List<string> station_code = new List<string> { file.ReadLine() };
                line = file.ReadLine();
                List<string> substring_train = new List<string>();
                List<string> substring_order = new List<string>();
                while (true) {

                    line = file.ReadLine();
                    if (String.Compare("- - - end - - -", line) == 0)
                        break;
                    string[] data = Regex.Split(line, " ");
                    substring_train.Add(data[0]);
                    substring_order.Add(data[1]);
                }
                concat.Add(station_code);
                concat.Add(substring_train);
                concat.Add(substring_order);

                ReadFile.station_train_dict.Add(name, concat);
                count += concat.Count;
                tmp = name;
            }
            //MessageBox.Show(ReadFile.station_train_dict["板橋"][1].Count.ToString());
            return tmp;
        }

        private void north_area_MouseHover(object sender, EventArgs e) {
            // 把滑到的 picturebox 轉換(所以大家共用同個 function)，載入圖片
            PictureBox object_box = (PictureBox)sender;
            Image img = Image.FromFile(pic_folder + image_list[Array.IndexOf(area_picbox, object_box)]);
            object_box.Image = img;
            object_box.BringToFront();
            name.Text = area_name[Array.IndexOf(area_picbox, object_box)];
        }

        private void north_area_MouseLeave(object sender, EventArgs e) {
            // 消除圖片
            PictureBox object_box = (PictureBox)sender;
            object_box.Image = null;
            object_box.Parent = taiwan;
            name.Text = "";
        }

        private void area_image_click(object sender, EventArgs e) {
            // 點下地區圖片, 載入地區縣市的 form
            int index = Array.IndexOf(area_picbox, (PictureBox)sender);
            area_map form_area = new area_map();
            form_area.form_taiwan = this;
            form_area.area_name = area_name[index];
            form_area.area_name_file = area_file_header[index];
            form_area.ShowDialog();
        }
    }
}
