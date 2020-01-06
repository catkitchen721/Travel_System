namespace Travel_System {
    partial class train_website {
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
            this.label7 = new System.Windows.Forms.Label();
            this.text_dest = new System.Windows.Forms.Label();
            this.text_source = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.data_view = new System.Windows.Forms.DataGridView();
            this.text_source_station = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_station = new System.Windows.Forms.ComboBox();
            this.combo_city = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_view)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(412, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 50);
            this.label7.TabIndex = 25;
            this.label7.Text = "到";
            // 
            // text_dest
            // 
            this.text_dest.AutoSize = true;
            this.text_dest.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.text_dest.Location = new System.Drawing.Point(508, 151);
            this.text_dest.Name = "text_dest";
            this.text_dest.Size = new System.Drawing.Size(210, 50);
            this.text_dest.TabIndex = 24;
            this.text_dest.Text = "(抵達車站)";
            // 
            // text_source
            // 
            this.text_source.AutoSize = true;
            this.text_source.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.text_source.Location = new System.Drawing.Point(180, 151);
            this.text_source.Name = "text_source";
            this.text_source.Size = new System.Drawing.Size(210, 50);
            this.text_source.TabIndex = 23;
            this.text_source.Text = "(出發車站)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(103, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 50);
            this.label4.TabIndex = 22;
            this.label4.Text = "從";
            // 
            // data_view
            // 
            this.data_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.data_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_view.Location = new System.Drawing.Point(101, 259);
            this.data_view.Name = "data_view";
            this.data_view.RowTemplate.Height = 38;
            this.data_view.Size = new System.Drawing.Size(1014, 516);
            this.data_view.TabIndex = 21;
            // 
            // text_source_station
            // 
            this.text_source_station.AutoSize = true;
            this.text_source_station.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.text_source_station.Location = new System.Drawing.Point(1246, 711);
            this.text_source_station.Name = "text_source_station";
            this.text_source_station.Size = new System.Drawing.Size(210, 50);
            this.text_source_station.TabIndex = 20;
            this.text_source_station.Text = "(抵達車站)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(1246, 632);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 50);
            this.label3.TabIndex = 19;
            this.label3.Text = "抵達車站：";
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.search.Location = new System.Drawing.Point(1245, 532);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(152, 62);
            this.search.TabIndex = 18;
            this.search.Text = "確定";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(1246, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 50);
            this.label2.TabIndex = 17;
            this.label2.Text = "車站";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(1246, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 50);
            this.label1.TabIndex = 16;
            this.label1.Text = "縣市";
            // 
            // combo_station
            // 
            this.combo_station.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.combo_station.FormattingEnabled = true;
            this.combo_station.Location = new System.Drawing.Point(1245, 430);
            this.combo_station.Name = "combo_station";
            this.combo_station.Size = new System.Drawing.Size(152, 48);
            this.combo_station.TabIndex = 15;
            // 
            // combo_city
            // 
            this.combo_city.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.combo_city.FormattingEnabled = true;
            this.combo_city.Location = new System.Drawing.Point(1245, 266);
            this.combo_city.Name = "combo_city";
            this.combo_city.Size = new System.Drawing.Size(152, 48);
            this.combo_city.TabIndex = 14;
            this.combo_city.SelectedIndexChanged += new System.EventHandler(this.combo_city_SelectedIndexChanged);
            // 
            // train_website
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1568, 926);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.text_dest);
            this.Controls.Add(this.text_source);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.data_view);
            this.Controls.Add(this.text_source_station);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_station);
            this.Controls.Add(this.combo_city);
            this.Name = "train_website";
            this.Text = "train_website";
            this.Load += new System.EventHandler(this.train_website_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label text_dest;
        private System.Windows.Forms.Label text_source;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView data_view;
        private System.Windows.Forms.Label text_source_station;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_station;
        private System.Windows.Forms.ComboBox combo_city;
    }
}