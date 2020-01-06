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
    public partial class train_website : Form {
        public site_map site_form;
        public string dest_station;
        public train_website() {
            InitializeComponent();

        }

        private void train_website_Load(object sender, EventArgs e) {

            string[] city_list = new string[ReadFile.city_list.Count];
            for (int i = 0; i < ReadFile.city_list.Count; i++) {
                if (ReadFile.city_list[i] == "")
                    continue;
                combo_city.Items.Add(ReadFile.city_list[i]);
            }
            text_source_station.Text = dest_station + " 車站";
            text_dest.Text = dest_station + " 車站";
        }

        private void combo_city_SelectedIndexChanged(object sender, EventArgs e) {
            combo_station.Items.Clear();
            foreach (var item in ReadFile.station_info) {
                if (item.Value[1] != combo_city.Text)
                    continue;
                combo_station.Items.Add(item.Key);
            }
        }

        private void search_Click(object sender, EventArgs e) {
            data_view.Rows.Clear();
            text_source.Text = combo_station.Text + " 車站";
            data_view.ColumnHeadersDefaultCellStyle.Font = new Font(text_dest.Font, FontStyle.Bold);
            data_view.RowsDefaultCellStyle.Font = new Font(text_dest.Font.Name, 8.5F, FontStyle.Regular);

            string source_station = combo_station.Text;
            //List<string[]> times =  ReadFile.search_two_station_train(source_station, dest_station);
            List<string> list_1 = new List<string>();
            List<string> list_2 = new List<string>();
            int count1 = 0;
            int count2 = 0;

            try {
                count1 = ReadFile.station_train_dict[source_station][1].Count;
                count2 = ReadFile.station_train_dict[dest_station][1].Count;
            }
            catch (Exception exception) {
                MessageBox.Show("搜尋的火車站可能不在資料裡");
            }

            for (int i = 0; i < count1; i++) {
                list_1.Add(ReadFile.station_train_dict[source_station][1][i]);
            }
            for (int i = 0; i < count2; i++) {
                list_2.Add(ReadFile.station_train_dict[dest_station][1][i]);
            }

            
            List<string[]> match = new List<string[]>();

            for (int i = 0; i < list_1.Count; i++) {
                if (list_2.Contains(list_1[i])) {
                    int index = list_2.IndexOf(list_1[i]);
                    int order_1 = int.Parse(ReadFile.station_train_dict[source_station][2][i]);
                    int order_2 = int.Parse(ReadFile.station_train_dict[dest_station][2][index]);
                    if (order_1 < order_2) {
                        //MessageBox.Show(order_1.ToString() + " / " + order_2.ToString() + ": " + list_1[i]);
                        string train = ReadFile.station_train_dict[source_station][1][i];
                        string dep_time = ReadFile.train_order_dict[train][order_1 - 1][3];
                        string arr_time = ReadFile.train_order_dict[train][order_2 - 1][2];
                        match.Add(new string[] { train, dep_time, arr_time });
                    }
                }
            }

            // data grid view setting
            data_view.ColumnCount = 3;
            data_view.Columns[0].Name = "班次";
            data_view.Columns[1].Name = "出發時間";
            data_view.Columns[2].Name = "抵達時間";
            for (int i = 0; i < match.Count; i++) {
                data_view.Rows.Add(match[i]);
            }

        }
    }
}
