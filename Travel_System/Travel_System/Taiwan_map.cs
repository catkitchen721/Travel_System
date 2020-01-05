using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_System {
    public partial class Taiwan_map : Form {
        public const string pic_folder = "../../../../image/";
        string[] image_list = new string[4] { "north_area.png", "center_area.png", "south_area.png", "east_area.png" };
        string[] area_name = new string[4] { "北部地區", "中部地區", "南部地區", "東部地區" };
        string[] area_file_header = new string[4] { "north", "center", "south", "east" };
        PictureBox[] area_picbox;

        public Taiwan_map() {
            InitializeComponent();
            name.Text = "";
            // initialize map info
            north_area.Location = new Point(185, 0);
            center_area.Location = new Point(60, 80);
            south_area.Location = new Point(50, 220);
            east_area.Location = new Point(170, 70);
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

            // user account
            user_account_label.Text = login.user_account;

            area_picbox = new PictureBox[4] { north_area, center_area, south_area, east_area};
        }

        private void Taiwan_map_Load(object sender, EventArgs e) {
            Image content = Image.FromFile(pic_folder + "taiwan.png");
            taiwan.Image = content;
            ReadFile.read_area_city_file("area_city.txt");
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
