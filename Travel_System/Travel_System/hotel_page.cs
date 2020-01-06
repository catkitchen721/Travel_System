using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Travel_System {
    public partial class hotel_page : Form {
        public string city_name;
        public string area;
        public site_map form1;
        public hotel_page() {
            InitializeComponent();
        }

        private void hotel_page_Load(object sender, EventArgs e) {
            txt_city_name.Text = city_name;
            read_hotel_data(area + "_" + city_name + ".txt");

        }
        private void read_hotel_data(string name) {
            hotel_data.ColumnHeadersDefaultCellStyle.Font = new Font(txt_city_name.Font, FontStyle.Bold);
            hotel_data.RowsDefaultCellStyle.Font = new Font(txt_city_name.Font.Name, 8.5F, FontStyle.Regular);
            hotel_data.ColumnCount = 3;
            hotel_data.Columns[0].Name = "名稱";
            hotel_data.Columns[1].Name = "星等";
            hotel_data.Columns[2].Name = "地點";
            string file_name = "../../../../data/hotel/" + name;
            StreamReader file = new StreamReader(file_name);
            string line;

            while (true) {
                string[] data = new string[3];
                line = file.ReadLine();
                if (line == null)
                    break;
                data[0] = file.ReadLine();  // name
                line = file.ReadLine();
                line = file.ReadLine();
                data[2] = file.ReadLine();  // address
                line = file.ReadLine();
                line = file.ReadLine();
                data[1] = file.ReadLine();  // star
                while (true) {
                    line = file.ReadLine();
                    if (line == "- - - end - - -")
                        break;
                }
                hotel_data.Rows.Add(data);
            }
        }
    }
}
