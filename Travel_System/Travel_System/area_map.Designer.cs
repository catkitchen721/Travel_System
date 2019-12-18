namespace Travel_System {
    partial class area_map {
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
            this.area_map_image = new System.Windows.Forms.PictureBox();
            this.area_tag = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.area_map_image)).BeginInit();
            this.SuspendLayout();
            // 
            // area_map_image
            // 
            this.area_map_image.Location = new System.Drawing.Point(109, 150);
            this.area_map_image.Name = "area_map_image";
            this.area_map_image.Size = new System.Drawing.Size(760, 648);
            this.area_map_image.TabIndex = 0;
            this.area_map_image.TabStop = false;
            // 
            // area_tag
            // 
            this.area_tag.AutoSize = true;
            this.area_tag.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.area_tag.Location = new System.Drawing.Point(1130, 150);
            this.area_tag.Name = "area_tag";
            this.area_tag.Size = new System.Drawing.Size(172, 48);
            this.area_tag.TabIndex = 1;
            this.area_tag.Text = "北部地區";
            // 
            // area_map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1589, 972);
            this.Controls.Add(this.area_tag);
            this.Controls.Add(this.area_map_image);
            this.Name = "area_map";
            this.Text = "area_map";
            this.Load += new System.EventHandler(this.area_map_Load);
            ((System.ComponentModel.ISupportInitialize)(this.area_map_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox area_map_image;
        private System.Windows.Forms.Label area_tag;
    }
}