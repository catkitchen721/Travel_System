using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Travel_System {
    public partial class site_map : Form {
        GMarkerGoogle marker;
        GMapOverlay marker_overlay;
        DataTable dt;

        List<GMarkerGoogle> marker_list = new List<GMarkerGoogle>();
        int fila = 0;
        
        public string area_name;
        public string city_name;
        public area_map form1 = null;
        public site_map() {
            InitializeComponent();
            gMapControl1.Height = 800;
            gMapControl1.Width = 1000;
            this.Height = 800;
            this.Width = 1200;
            splitContainer1.Panel1MinSize = 800;
            splitContainer1.Panel2MinSize = 400;
        }

        private void site_map_Load(object sender, EventArgs e) {
            //double lat = (double)ReadFile.location_list[0][1];
            //double lon = (double)ReadFile.location_list[0][0];
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
            double lon = (double)ReadFile.location_list[0][index*2];
            double lat = (double)ReadFile.location_list[0][index*2+1];
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
            MessageBox.Show("Click!!");
        }

        private void gMapControl1_OnMarkerEnter(GMapMarker item) {
            // 當滑鼠移到座標點上
            int index = marker_list.IndexOf((GMarkerGoogle)item);
            info_box.Text = ReadFile.site_name_list[index] + "\r\n";
            info_box.Text += (ReadFile.self_drive_list[index] + "\r\n");
            info_box.Text += (ReadFile.public_traffic_list[index][0] + "\r\n");
        }

    }
}
