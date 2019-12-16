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

        int fila = 0;
        

        public area_map form1 = null;
        public site_map() {
            InitializeComponent();
        }

        private void site_map_Load(object sender, EventArgs e) {
            double lat = 22.9897454;
            double lon = 120.2321653;
            // initial setting
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(lat, lon);
            gMapControl1.MinZoom = 3;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;

            gMapControl1.OnMarkerClick += new MarkerClick(gMapControl1_OnMarkerClick);

            
            // marker
            marker_overlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.red);
            marker_overlay.Markers.Add(marker);
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Location:\n lat:{0}\n lon:{1}", lat, lon);
            gMapControl1.Overlays.Add(marker_overlay);

            int total_site_number = ReadFile.read_file("center_彰化縣.txt");
            info_box.Text = ReadFile.site_name_list[0];

            for (int i = 0; i < ReadFile.site_name_list.Count; i++) {
                add_markers_on_map(i, marker_overlay);
                info_box.Text += (ReadFile.site_name_list[i] + "\n");
            }

            site_name.Text = form1.city_name;
            
        }

        private void add_markers_on_map(int index, GMapOverlay gmap) {
            
            //marker_overlay = new GMapOverlay("Marcador");
            double lat = (double)ReadFile.location_list[index][1];
            double lon = (double)ReadFile.location_list[index][0];
            marker = new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.red);
            gmap.Markers.Add(marker);
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Location:\n lat:{0}\n lon:{1}\nName:{2}", lat, lon, ReadFile.site_name_list[index]);
            gMapControl1.Overlays.Add(gmap);
        }

        private void gMapControl1_OnMarkerClick(GMapMarker item, MouseEventArgs e) {
            // 當滑鼠點擊座標
            MessageBox.Show("Click!!");
        }

        private void gMapControl1_OnMarkerEnter(GMapMarker item) {
            // 當滑鼠移到座標點上
            
        }

    }
}
