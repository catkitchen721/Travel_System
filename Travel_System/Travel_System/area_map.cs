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
        string[] city_list = new string[4] { "臺北市", "新北市", "桃園市", "宜蘭縣" };
        Button[] button_list;
        public string city_name;
        public area_map() {
            InitializeComponent();
        }

        private void area_map_Load(object sender, EventArgs e) {
            button_list = new Button[4]{button1, button2, button3, button4};
        }

        private void city_button_click(object sender, EventArgs e) {
            Button click = (Button)sender;
            int index = Array.IndexOf(button_list, click);
            city_name = city_list[index];
            site_map form2 = new site_map();
            form2.form1 = this;
            form2.ShowDialog();
        }
    }
}
