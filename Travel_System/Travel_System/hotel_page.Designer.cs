namespace Travel_System {
    partial class hotel_page {
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
            this.txt_city_name = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.hotel_data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_data)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_city_name
            // 
            this.txt_city_name.AutoSize = true;
            this.txt_city_name.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_city_name.Location = new System.Drawing.Point(141, 86);
            this.txt_city_name.Name = "txt_city_name";
            this.txt_city_name.Size = new System.Drawing.Size(81, 40);
            this.txt_city_name.TabIndex = 5;
            this.txt_city_name.Text = "縣市";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label.Location = new System.Drawing.Point(270, 86);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(241, 40);
            this.label.TabIndex = 4;
            this.label.Text = "縣市的住宿資料";
            // 
            // hotel_data
            // 
            this.hotel_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.hotel_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hotel_data.Location = new System.Drawing.Point(90, 174);
            this.hotel_data.Name = "hotel_data";
            this.hotel_data.RowTemplate.Height = 38;
            this.hotel_data.Size = new System.Drawing.Size(991, 608);
            this.hotel_data.TabIndex = 3;
            // 
            // hotel_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 887);
            this.Controls.Add(this.txt_city_name);
            this.Controls.Add(this.label);
            this.Controls.Add(this.hotel_data);
            this.Name = "hotel_page";
            this.Text = "hotel_page";
            this.Load += new System.EventHandler(this.hotel_page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotel_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_city_name;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataGridView hotel_data;
    }
}