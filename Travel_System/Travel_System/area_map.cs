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
    public partial class area_map : Form {
        List<Button> button_list = new List<Button>();
        public string city_name;
        public string area_name;
        public string area_name_file;
        public Taiwan_map form_taiwan;

        public area_map() {
            InitializeComponent();
        }

        private void area_map_Load(object sender, EventArgs e) {
            load_city_button(area_name);
            area_tag.Text = area_name;

            // 區域地圖
            Image img = Image.FromFile(Taiwan_map.pic_folder + area_name_file + "_area.png");
            area_map_image.Image = img;
            area_map_image.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void city_button_click(object sender, EventArgs e) {
            Button click = (Button)sender;
            int index = button_list.IndexOf(click);
            city_name = click.Text;
            // 縣市景點的 form
            site_map form2 = new site_map();
            form2.form1 = this;
            form2.area_name = area_name_file;
            form2.city_name = click.Text;
            form2.WindowState = FormWindowState.Maximized;
            form2.ShowDialog();
        }
        private void load_city_button(string area_name) {
            List<string> city_list = ReadFile.area_vs_city[area_name_file];
            int start_x = 500, start_y = 150;
            // 區域的縣市 button
            for (int i = 0; i < city_list.Count; i++) {
                Button new_button = new Button();
                new_button.Height = 30;
                new_button.Text = city_list[i];
                new_button.Font = new Font("微軟正黑體", 14, FontStyle.Regular, GraphicsUnit.Point);
                button_list.Add(new_button);
                int x = (i % 2 == 0) ? start_x : start_x + 100;
                int y = start_y + (i / 2) * 60;
                new_button.Location = new Point(x, y);
                this.Controls.Add(new_button);
                new_button.Click += city_button_click;
            }
        }
    }
}
