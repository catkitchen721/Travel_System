namespace Travel_System
{
    partial class login
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.title_image = new System.Windows.Forms.PictureBox();
            this.login_bt = new System.Windows.Forms.Button();
            this.userin = new System.Windows.Forms.TextBox();
            this.pswin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.signup_bt = new System.Windows.Forms.Button();
            this.intro_bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.title_image)).BeginInit();
            this.SuspendLayout();
            // 
            // title_image
            // 
            this.title_image.Image = ((System.Drawing.Image)(resources.GetObject("title_image.Image")));
            this.title_image.Location = new System.Drawing.Point(145, 69);
            this.title_image.Margin = new System.Windows.Forms.Padding(0);
            this.title_image.Name = "title_image";
            this.title_image.Size = new System.Drawing.Size(657, 172);
            this.title_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.title_image.TabIndex = 0;
            this.title_image.TabStop = false;
            this.title_image.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // login_bt
            // 
            this.login_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.login_bt.Cursor = System.Windows.Forms.Cursors.Default;
            this.login_bt.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.login_bt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.login_bt.Location = new System.Drawing.Point(218, 427);
            this.login_bt.Margin = new System.Windows.Forms.Padding(2);
            this.login_bt.Name = "login_bt";
            this.login_bt.Size = new System.Drawing.Size(118, 48);
            this.login_bt.TabIndex = 1;
            this.login_bt.Text = "登入";
            this.login_bt.UseVisualStyleBackColor = false;
            this.login_bt.Click += new System.EventHandler(this.login_bt_Click);
            // 
            // userin
            // 
            this.userin.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.userin.Location = new System.Drawing.Point(430, 272);
            this.userin.Margin = new System.Windows.Forms.Padding(2);
            this.userin.Name = "userin";
            this.userin.Size = new System.Drawing.Size(309, 39);
            this.userin.TabIndex = 3;
            // 
            // pswin
            // 
            this.pswin.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pswin.Location = new System.Drawing.Point(430, 337);
            this.pswin.Margin = new System.Windows.Forms.Padding(2);
            this.pswin.Name = "pswin";
            this.pswin.Size = new System.Drawing.Size(309, 39);
            this.pswin.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(184, 278);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "使用者 user       : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(185, 342);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "密碼 password : ";
            // 
            // signup_bt
            // 
            this.signup_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.signup_bt.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.signup_bt.Location = new System.Drawing.Point(414, 427);
            this.signup_bt.Margin = new System.Windows.Forms.Padding(2);
            this.signup_bt.Name = "signup_bt";
            this.signup_bt.Size = new System.Drawing.Size(118, 48);
            this.signup_bt.TabIndex = 7;
            this.signup_bt.Text = "註冊";
            this.signup_bt.UseVisualStyleBackColor = false;
            this.signup_bt.Click += new System.EventHandler(this.signup_bt_Click);
            // 
            // intro_bt
            // 
            this.intro_bt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.intro_bt.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.intro_bt.Location = new System.Drawing.Point(620, 427);
            this.intro_bt.Margin = new System.Windows.Forms.Padding(2);
            this.intro_bt.Name = "intro_bt";
            this.intro_bt.Size = new System.Drawing.Size(118, 48);
            this.intro_bt.TabIndex = 8;
            this.intro_bt.Text = "系統介紹";
            this.intro_bt.UseVisualStyleBackColor = false;
            this.intro_bt.Click += new System.EventHandler(this.intro_bt_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(948, 549);
            this.Controls.Add(this.intro_bt);
            this.Controls.Add(this.signup_bt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pswin);
            this.Controls.Add(this.userin);
            this.Controls.Add(this.login_bt);
            this.Controls.Add(this.title_image);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "login";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.title_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox title_image;
        private System.Windows.Forms.Button login_bt;
        private System.Windows.Forms.TextBox userin;
        private System.Windows.Forms.TextBox pswin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button signup_bt;
        private System.Windows.Forms.Button intro_bt;
    }
}

