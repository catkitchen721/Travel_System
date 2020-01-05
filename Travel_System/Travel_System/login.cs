using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Travel_System
{
    public partial class login : Form
    {
        public const string all_account_cmd = "SELECT * FROM users ORDER BY Id ASC";
        public const string add_account_cmd = "INSERT INTO users" +
            "(account, password, userdata) ";
        public static string exist_account_cmd;
        public static string check_account_cmd;
        public static SqlConnection cn;
        public static DataSet ds_all_account;
        public static SqlDataAdapter all_account;
        public static SqlCommand add_account;
        public static string user_account = "";

        public login()
        {
            InitializeComponent();
            Image content = Image.FromFile(Taiwan_map.pic_folder + "title_img.png");
            title_image.Image = content;

            cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|userdata.mdf;" +
                "Integrated Security=True";
            cn.Open();

            ds_all_account = new DataSet();
            all_account = new SqlDataAdapter(all_account_cmd, cn);
            all_account.Fill(ds_all_account);

            MessageBox.Show("資料庫連線成功！", "System");
        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void signup_bt_Click(object sender, EventArgs e)
        {
            if(userin.Text == "" || pswin.Text == "")
            {
                MessageBox.Show("請輸入帳號與密碼！", "帳密空白", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ds_all_account = new DataSet();
            all_account = new SqlDataAdapter(all_account_cmd, cn);
            all_account.Fill(ds_all_account);

            if (ds_all_account.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("歡迎！");
            }
            else
            {
                MessageBox.Show("歡迎！\n目前您是第1位使用者！", "System");
            }

            try
            {
                exist_account_cmd = $"SELECT count(account) FROM users WHERE account='{userin.Text}'";

                SqlCommand exist_account = new SqlCommand(exist_account_cmd, cn);
                SqlDataReader exist_account_reader = exist_account.ExecuteReader();
                exist_account_reader.Read();
                string exist_string = exist_account_reader[0].ToString();
                exist_account_reader.Close();
                
                if(exist_string == "0")
                {
                    add_account = new SqlCommand(add_account_cmd + $"VALUES('{userin.Text}', '{pswin.Text}', NULL);", cn);
                    add_account.ExecuteNonQuery();
                    MessageBox.Show("註冊成功！", "System");

                    ds_all_account = new DataSet();
                    all_account = new SqlDataAdapter(all_account_cmd, cn);
                    all_account.Fill(ds_all_account);

                    if (ds_all_account.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show(ds_all_account.Tables[0].Rows[(ds_all_account.Tables[0].Rows.Count) - 1]["account"].ToString() + " 您好！\n請直接登入！", "System");
                    }
                }
                else
                {
                    MessageBox.Show("帳號已存在！", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception exc)
            {
                //MessageBox.Show(exc.ToString(), "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("有些地方出錯了...", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            cn.Close();
            MessageBox.Show("資料庫已關閉", "System");
        }

        private void intro_bt_Click(object sender, EventArgs e)
        {
            ds_all_account = new DataSet();
            all_account = new SqlDataAdapter(all_account_cmd, cn);
            all_account.Fill(ds_all_account);

            if (ds_all_account.Tables[0].Rows.Count > 0)
            {
                string allusers = "";
                for(int i = 0; i < ds_all_account.Tables[0].Rows.Count; i++)
                {
                    allusers += ds_all_account.Tables[0].Rows[i]["Id"].ToString() + " " + ds_all_account.Tables[0].Rows[i]["account"].ToString() + "\n";
                }
                MessageBox.Show(allusers, "System");
            }
        }

        private void login_bt_Click(object sender, EventArgs e)
        {
            if (userin.Text == "" || pswin.Text == "")
            {
                MessageBox.Show("請輸入帳號與密碼！", "帳密空白", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                exist_account_cmd = $"SELECT count(account) FROM users WHERE account='{userin.Text}'";

                SqlCommand exist_account = new SqlCommand(exist_account_cmd, cn);
                SqlDataReader exist_account_reader = exist_account.ExecuteReader();
                exist_account_reader.Read();
                string exist_string = exist_account_reader[0].ToString();
                exist_account_reader.Close();

                if (exist_string == "0")
                {
                    MessageBox.Show("帳號或密碼錯誤！", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    check_account_cmd = $"SELECT account, password FROM users WHERE account='{userin.Text}'";
                    ds_all_account = new DataSet();
                    all_account = new SqlDataAdapter(check_account_cmd, cn);
                    all_account.Fill(ds_all_account);

                    if (ds_all_account.Tables[0].Rows.Count > 0)
                    {
                        if(ds_all_account.Tables[0].Rows[0]["password"].ToString() == pswin.Text)
                        {
                            MessageBox.Show(ds_all_account.Tables[0].Rows[0]["account"].ToString() + " 您好！", "System");
                            user_account = ds_all_account.Tables[0].Rows[0]["account"].ToString();
                            Taiwan_map taiwan_map = new Taiwan_map();
                            taiwan_map.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("帳號或密碼錯誤！", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("有些地方出錯了...", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //MessageBox.Show("有些地方出錯了...", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
