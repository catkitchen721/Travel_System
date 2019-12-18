namespace Travel_System {
    partial class Taiwan_map {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Taiwan_map));
            this.taiwan = new System.Windows.Forms.PictureBox();
            this.north_area = new System.Windows.Forms.PictureBox();
            this.center_area = new System.Windows.Forms.PictureBox();
            this.south_area = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.east_area = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.taiwan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.north_area)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.center_area)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.south_area)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.east_area)).BeginInit();
            this.SuspendLayout();
            // 
            // taiwan
            // 
            this.taiwan.Image = ((System.Drawing.Image)(resources.GetObject("taiwan.Image")));
            this.taiwan.Location = new System.Drawing.Point(117, 86);
            this.taiwan.Name = "taiwan";
            this.taiwan.Size = new System.Drawing.Size(736, 850);
            this.taiwan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.taiwan.TabIndex = 0;
            this.taiwan.TabStop = false;
            // 
            // north_area
            // 
            this.north_area.Cursor = System.Windows.Forms.Cursors.Hand;
            this.north_area.Location = new System.Drawing.Point(493, 86);
            this.north_area.Name = "north_area";
            this.north_area.Size = new System.Drawing.Size(301, 264);
            this.north_area.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.north_area.TabIndex = 1;
            this.north_area.TabStop = false;
            this.north_area.Click += new System.EventHandler(this.area_image_click);
            this.north_area.MouseEnter += new System.EventHandler(this.north_area_MouseHover);
            this.north_area.MouseLeave += new System.EventHandler(this.north_area_MouseLeave);
            // 
            // center_area
            // 
            this.center_area.Cursor = System.Windows.Forms.Cursors.Hand;
            this.center_area.Location = new System.Drawing.Point(258, 234);
            this.center_area.Name = "center_area";
            this.center_area.Size = new System.Drawing.Size(419, 344);
            this.center_area.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.center_area.TabIndex = 2;
            this.center_area.TabStop = false;
            this.center_area.Click += new System.EventHandler(this.area_image_click);
            this.center_area.MouseEnter += new System.EventHandler(this.north_area_MouseHover);
            this.center_area.MouseLeave += new System.EventHandler(this.north_area_MouseLeave);
            // 
            // south_area
            // 
            this.south_area.Cursor = System.Windows.Forms.Cursors.Hand;
            this.south_area.Location = new System.Drawing.Point(216, 539);
            this.south_area.Name = "south_area";
            this.south_area.Size = new System.Drawing.Size(422, 406);
            this.south_area.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.south_area.TabIndex = 3;
            this.south_area.TabStop = false;
            this.south_area.Click += new System.EventHandler(this.area_image_click);
            this.south_area.MouseEnter += new System.EventHandler(this.north_area_MouseHover);
            this.south_area.MouseLeave += new System.EventHandler(this.north_area_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(1074, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "目前選擇地區：";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.name.Location = new System.Drawing.Point(1404, 244);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(282, 55);
            this.name.TabIndex = 6;
            this.name.Text = "地區名稱顯示";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSalmon;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(1078, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(608, 89);
            this.label3.TabIndex = 7;
            this.label3.Text = "請選擇地區";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // east_area
            // 
            this.east_area.Cursor = System.Windows.Forms.Cursors.Hand;
            this.east_area.Location = new System.Drawing.Point(527, 238);
            this.east_area.Name = "east_area";
            this.east_area.Size = new System.Drawing.Size(274, 698);
            this.east_area.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.east_area.TabIndex = 8;
            this.east_area.TabStop = false;
            this.east_area.Click += new System.EventHandler(this.area_image_click);
            this.east_area.MouseEnter += new System.EventHandler(this.north_area_MouseHover);
            this.east_area.MouseLeave += new System.EventHandler(this.north_area_MouseLeave);
            // 
            // Taiwan_map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1802, 1164);
            this.Controls.Add(this.east_area);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.south_area);
            this.Controls.Add(this.center_area);
            this.Controls.Add(this.north_area);
            this.Controls.Add(this.taiwan);
            this.Name = "Taiwan_map";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 20, 20);
            this.Text = "Taiwan_map";
            this.Load += new System.EventHandler(this.Taiwan_map_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taiwan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.north_area)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.center_area)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.south_area)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.east_area)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox taiwan;
        private System.Windows.Forms.PictureBox north_area;
        private System.Windows.Forms.PictureBox center_area;
        private System.Windows.Forms.PictureBox south_area;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox east_area;
    }
}