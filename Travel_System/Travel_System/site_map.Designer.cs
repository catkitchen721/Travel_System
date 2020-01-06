namespace Travel_System {
    partial class site_map {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.user_account_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.photo_box = new System.Windows.Forms.PictureBox();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.label1 = new System.Windows.Forms.Label();
            this.button_train = new System.Windows.Forms.Button();
            this.button_hotel = new System.Windows.Forms.Button();
            this.button_bus = new System.Windows.Forms.Button();
            this.info_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.button_adding = new System.Windows.Forms.Button();
            this.site_name = new System.Windows.Forms.Label();
            this.label_site = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.photo_box)).BeginInit();
            this.SuspendLayout();
            // 
            // user_account_label
            // 
            this.user_account_label.AutoSize = true;
            this.user_account_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.user_account_label.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.user_account_label.Location = new System.Drawing.Point(1639, 885);
            this.user_account_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.user_account_label.Name = "user_account_label";
            this.user_account_label.Size = new System.Drawing.Size(198, 61);
            this.user_account_label.TabIndex = 39;
            this.user_account_label.Text = "Default";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(1456, 885);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 61);
            this.label3.TabIndex = 38;
            this.label3.Text = "使用者";
            // 
            // photo_box
            // 
            this.photo_box.Location = new System.Drawing.Point(1095, 152);
            this.photo_box.Name = "photo_box";
            this.photo_box.Size = new System.Drawing.Size(457, 361);
            this.photo_box.TabIndex = 30;
            this.photo_box.TabStop = false;
            // 
            // gMapControl1
            // 
            this.gMapControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(-96, 114);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(1113, 928);
            this.gMapControl1.TabIndex = 26;
            this.gMapControl1.Zoom = 0D;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-91, -8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 74);
            this.label1.TabIndex = 31;
            this.label1.Text = "我是可以縮放的 google 地圖";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_train
            // 
            this.button_train.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_train.Location = new System.Drawing.Point(1714, 694);
            this.button_train.Name = "button_train";
            this.button_train.Size = new System.Drawing.Size(209, 60);
            this.button_train.TabIndex = 37;
            this.button_train.Text = "火車查詢";
            this.button_train.UseVisualStyleBackColor = true;
            this.button_train.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_hotel
            // 
            this.button_hotel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_hotel.Location = new System.Drawing.Point(1440, 694);
            this.button_hotel.Name = "button_hotel";
            this.button_hotel.Size = new System.Drawing.Size(209, 60);
            this.button_hotel.TabIndex = 35;
            this.button_hotel.Text = "附近住宿";
            this.button_hotel.UseVisualStyleBackColor = true;
            this.button_hotel.Click += new System.EventHandler(this.button_hotel_Click);
            // 
            // button_bus
            // 
            this.button_bus.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_bus.Location = new System.Drawing.Point(1998, 694);
            this.button_bus.Name = "button_bus";
            this.button_bus.Size = new System.Drawing.Size(209, 60);
            this.button_bus.TabIndex = 36;
            this.button_bus.Text = "公車查詢";
            this.button_bus.UseVisualStyleBackColor = true;
            // 
            // info_box
            // 
            this.info_box.BackColor = System.Drawing.Color.White;
            this.info_box.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.info_box.Location = new System.Drawing.Point(1673, 152);
            this.info_box.Multiline = true;
            this.info_box.Name = "info_box";
            this.info_box.ReadOnly = true;
            this.info_box.Size = new System.Drawing.Size(565, 437);
            this.info_box.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(1690, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 48);
            this.label2.TabIndex = 33;
            this.label2.Text = "景點資訊";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(1102, 568);
            this.hScrollBar1.MaximumSize = new System.Drawing.Size(450, 35);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(450, 35);
            this.hScrollBar1.TabIndex = 32;
            // 
            // button_adding
            // 
            this.button_adding.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_adding.Location = new System.Drawing.Point(1183, 694);
            this.button_adding.Name = "button_adding";
            this.button_adding.Size = new System.Drawing.Size(209, 60);
            this.button_adding.TabIndex = 27;
            this.button_adding.Text = "加入名單";
            this.button_adding.UseVisualStyleBackColor = true;
            // 
            // site_name
            // 
            this.site_name.AutoSize = true;
            this.site_name.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.site_name.Location = new System.Drawing.Point(1319, 79);
            this.site_name.Name = "site_name";
            this.site_name.Size = new System.Drawing.Size(96, 48);
            this.site_name.TabIndex = 29;
            this.site_name.Text = "緯度";
            // 
            // label_site
            // 
            this.label_site.AutoSize = true;
            this.label_site.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_site.Location = new System.Drawing.Point(1097, 79);
            this.label_site.Name = "label_site";
            this.label_site.Size = new System.Drawing.Size(210, 48);
            this.label_site.TabIndex = 28;
            this.label_site.Text = "景點名稱：";
            // 
            // site_map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2283, 1035);
            this.Controls.Add(this.user_account_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.photo_box);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_train);
            this.Controls.Add(this.button_hotel);
            this.Controls.Add(this.button_bus);
            this.Controls.Add(this.info_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.button_adding);
            this.Controls.Add(this.site_name);
            this.Controls.Add(this.label_site);
            this.MinimizeBox = false;
            this.Name = "site_map";
            this.Text = "site_map";
            this.Load += new System.EventHandler(this.site_map_Load);
            ((System.ComponentModel.ISupportInitialize)(this.photo_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user_account_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox photo_box;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_train;
        private System.Windows.Forms.Button button_hotel;
        private System.Windows.Forms.Button button_bus;
        private System.Windows.Forms.TextBox info_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Button button_adding;
        private System.Windows.Forms.Label site_name;
        private System.Windows.Forms.Label label_site;
    }
}