﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_System
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            Image content = Image.FromFile(Taiwan_map.pic_folder + "title_img.png");
            title_image.Image = content;
        }
        

        private void pictureBox1_Click(object sender, EventArgs e) {

        }
    }
}
