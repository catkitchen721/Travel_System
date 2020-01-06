using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

using System.Net;

namespace Travel_System {
    public partial class site_map : Form {
        GMarkerGoogle marker;
        GMapOverlay marker_overlay;
        DataTable dt;

        List<GMarkerGoogle> marker_list = new List<GMarkerGoogle>();
        int fila = 0;
        
        public string area_name;
        public string city_name;

        public int file_is_created = 0;
        public DirectoryInfo dinfo;
        FileInfo[] files;
        public string sys_startup;

        public string site_name_wf;
        public string LON;
        public string LAT;
        public int INDEX_PIC;

        public int site_index;

        public area_map form1 = null;
        public site_map() {
            InitializeComponent();

        }

        private void site_map_Load(object sender, EventArgs e) {
            // initial setting
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(0, 0);
            gMapControl1.MinZoom = 6;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 10;
            gMapControl1.AutoScroll = true;

            gMapControl1.OnMarkerClick += new MarkerClick(gMapControl1_OnMarkerClick);
            marker_overlay = new GMapOverlay("marker");

            // user account
            user_account_label.Text = login.user_account;

            /*** write csv ***/
            Directory.CreateDirectory("csv");
            sys_startup = Application.StartupPath+"\\csv";
            dinfo = new DirectoryInfo(sys_startup);
            files = dinfo.GetFiles();
            for(int i = 0; i < files.Length; i++)
            {
                if(files[i].Name == (login.user_account + ".csv"))
                {
                    file_is_created = 1;
                }
            }
            if (file_is_created == 0)
            {
                //create csv files
                using (StreamWriter sw = File.CreateText(sys_startup + "\\" + login.user_account + ".csv"))
                {
                    sw.WriteLine("經度,緯度,景點名");
                }
                file_is_created = 1;
            }
            /*** marker sample
            
            marker = new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.red);
            markeroverlay.Markers.Add(marker);
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Location:\n lat:{0}\n lon:{1}", lat, lon);
            gMapControl1.Overlays.Add(marker_overlay);

            ***/

            string file_name = area_name + "_" + city_name + ".txt";
            int total_site_number = ReadFile.read_scene_file(file_name);
            info_box.Text = ReadFile.site_name_list[0];
            info_box.Text += ("[" + total_site_number.ToString() + "]\n");
            info_box.Text = ReadFile.location_list[1].Count.ToString();
            for (int i = 0; i < ReadFile.site_name_list.Count; i++) {
                add_markers_on_map(i, marker_overlay);
            }
            gMapControl1.Position = new PointLatLng(ReadFile.location_list[0][1], ReadFile.location_list[0][0]);
            site_name.Text = form1.city_name;

        }

        private void add_markers_on_map(int index, GMapOverlay gmap) {

            //marker_overlay = new GMapOverlay("Marcador");
            double lon = (double)ReadFile.location_list[index][0];
            double lat = (double)ReadFile.location_list[index][1];
            marker = new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.red);
            gmap.Markers.Add(marker);
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("{0}\n", ReadFile.site_name_list[index]);
            gmap.Markers.Add(marker);
            gMapControl1.Overlays.Add(gmap);
            marker_list.Add(marker);

        }

        private void gMapControl1_OnMarkerClick(GMapMarker item, MouseEventArgs e) {
            // 當滑鼠點擊座標
            int index = marker_list.IndexOf((GMarkerGoogle)item);
            site_index = index;
            info_box.Text = ReadFile.site_name_list[index] + "\r\n";
            info_box.Text += (ReadFile.self_drive_list[index] + "\r\n");

            try {
                info_box.Text += ("[" + ReadFile.public_traffic_list[index][0] + "]\r\n");
                info_box.Text += ("[" + ReadFile.public_traffic_list[index][1] + "]\r\n");
            }
            catch (Exception exception) {
                ;
            }
            hScrollBar1.Maximum = ReadFile.photo_list[index].Count;
        }

        private void gMapControl1_OnMarkerEnter(GMapMarker item) {
            // 當滑鼠移到座標點上
            int index = marker_list.IndexOf((GMarkerGoogle)item);
            INDEX_PIC = index;
            info_box.Text = ReadFile.site_name_list[index] + "\r\n";
            site_name_wf = ReadFile.site_name_list[index];
            info_box.Text += "經緯度:" + item.Position.Lng.ToString() + "," + item.Position.Lat.ToString() + "\r\n";
            LON = item.Position.Lng.ToString();
            LAT = item.Position.Lat.ToString();
            info_box.Text += (ReadFile.self_drive_list[index] + "\r\n");
            info_box.Text += (ReadFile.public_traffic_list[index][0] + "\r\n");

            String url_temp = "";
            if(ReadFile.photo_list[INDEX_PIC].Count > 0)
            {
                int val = 100 / ReadFile.photo_list[INDEX_PIC].Count;
                if(hScrollBar1.Value / val >= ReadFile.photo_list[INDEX_PIC].Count)
                    url_temp = ReadFile.photo_list[INDEX_PIC][hScrollBar1.Value /val - 1];
                else
                    url_temp = ReadFile.photo_list[INDEX_PIC][hScrollBar1.Value / val];
            }
                
            info_box.Text += (url_temp + "\r\n");

            if (url_temp.Contains("https:"))
            {
                url_temp=url_temp.Replace("https", "http");
                photo_box.LoadAsync(url_temp);
                photo_box.SizeMode = PictureBoxSizeMode.StretchImage;
            }
                

        }
        private string extract_station(string info) {
            int start = info.IndexOf("臺鐵至");
            if (start == -1)
                return "-1";
            else
                start += 3;
            int end = info.Substring(start).IndexOf("站");
            MessageBox.Show(info.Substring(start, end));
            return info.Substring(start, end);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool site_name_duplicated = false;
            using (StreamReader sr = new StreamReader(sys_startup + "\\" + login.user_account + ".csv"))
            {
                while (sr.Peek() >= 0)
                {
                    String temp = sr.ReadLine();
                    if (temp.Contains(site_name_wf))
                        site_name_duplicated = true;
                }
            }
            using (StreamWriter sw = File.AppendText(sys_startup + "\\" + login.user_account + ".csv"))
            {
                if(!site_name_duplicated)
                    sw.WriteLine(LON+","+LAT + "," + site_name_wf);
            }
        }
        private void button4_Click(object sender, EventArgs e) {
            train_website train_page = new train_website();
            train_page.site_form = this;
            if (site_index == -1) {
                MessageBox.Show("Please select a site.\n");
                return;
            }
            //string test_info = "搭臺鐵至水里站下-轉搭員林客運(往東埔)至東埔站下";
            train_page.dest_station = extract_station(ReadFile.public_traffic_list[site_index][0]);
            if (train_page.dest_station == "-1") {
                try {
                    train_page.dest_station = extract_station(ReadFile.public_traffic_list[site_index][1]);
                }
                catch (Exception ex) {
                    ;
                }
            }
            if (train_page.dest_station == "-1") {
                MessageBox.Show("這個景點沒辦法用火車抵達");
            }
            else {
                train_page.ShowDialog();
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            String url_temp = "";
            if (ReadFile.photo_list[INDEX_PIC].Count > 0)
            {
                int val = 100 / ReadFile.photo_list[INDEX_PIC].Count;
                if (hScrollBar1.Value / val >= ReadFile.photo_list[INDEX_PIC].Count)
                    url_temp = ReadFile.photo_list[INDEX_PIC][hScrollBar1.Value / val - 1];
                else
                    url_temp = ReadFile.photo_list[INDEX_PIC][hScrollBar1.Value / val];
            }

            if (url_temp.Contains("https:"))
            {
                url_temp = url_temp.Replace("https", "http");
                photo_box.LoadAsync(url_temp);
                photo_box.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void close_form(object sender, EventArgs e) {
            ReadFile.clear_data();
        }

        private void button_hotel_Click(object sender, EventArgs e) {
            hotel_page form2 = new hotel_page();
            form2.form1 = this;
            form2.city_name = city_name;
            form2.area = area_name;
            form2.ShowDialog();

        }
    }
}
