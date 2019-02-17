using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Work.Forms.SQL;
using System.Data.SqlClient;
namespace Work.Forms.SQL
{
    public partial class UserControl1 : UserControl
    {
        public string uppath;
        public string nickname;
        public string id;
        Form a;
        public UserControl1(string name,string uppath,string price,string date,string nickname,string id,Form a)
        {
            InitializeComponent();
            this.book.Text = name;
            this.pictureBox1.ImageLocation = uppath;
            this.uppath = uppath;
            this.price.Text =price;
            this.a = a;
            this.date.Text = date;
            this.nickname = nickname;
            this.id = id;
            this.pictureBox1.DoubleClick += PictureBox1_DoubleClick;
            this.DoubleClick += UserControl1_DoubleClick;
            this.button1.Click += Button1_Click;
            
        }

       

        public UserControl1(string name, string uppath, string price, string date,int flag, string nickname,string id,Form a)
        {
            InitializeComponent();
            this.label3.Text = "交换期限";
            this.label4.Text = "交换日期";
            this.book.Text = name;
            this.uppath = uppath;
            this.pictureBox1.ImageLocation = uppath;
            this.price.Text = price;
            this.date.Text = date;
            this.a = a;
            this.nickname = nickname;
            this.id = id;
            this.pictureBox1.DoubleClick += PictureBox1_DoubleClick;
            this.DoubleClick += UserControl1_DoubleClick;
            this.button1.Click += Button1_Click1; ;
            
        }

        private void Button1_Click1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否确定删除，删除不可恢复", "好可惜的哦", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string str = "update change set friend_ID1=(select friend_ID from friend where friend_nickname='" + nickname + "')" +
                    "where change_ID='" + id + "'";
                Work.Forms.SQL.SqlConnection s = new Work.Forms.SQL.SqlConnection(str);
                s.Connection();
                SqlCommand com = new SqlCommand(str, s.conn);
                com.ExecuteNonQuery();
                s.Close();
                MessageBox.Show("请重新选择查看", "删除成功");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult result=MessageBox.Show("是否确定删除，删除不可恢复","好可惜的哦",MessageBoxButtons.YesNo);
               if(result==DialogResult.Yes)
            {
                string str = "update sale set friend_ID1=(select friend_ID from friend where friend_nickname='" + nickname+"')"+
                    "where sale_ID='" + id + "'";
                Work.Forms.SQL.SqlConnection s = new Work.Forms.SQL.SqlConnection(str);
                s.Connection();
                SqlCommand com = new SqlCommand(str, s.conn);
                com.ExecuteNonQuery();
                s.Close();
                MessageBox.Show("请重新选择查看", "删除成功");
                a.Hide();
                change_card b = new change_card(nickname);
                b.StartPosition = FormStartPosition.CenterScreen;
                b.ShowDialog();
                a.Close();

            }
        }

        private void UserControl1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void PictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (uppath != null)
            {
                string str = "select book_name from book where image_path='" + uppath + "'";
                Work.Forms.SQL.SqlConnection s = new Work.Forms.SQL.SqlConnection(str);
                s.Connection();
                SqlCommand com = new SqlCommand(str, s.conn);
                string name = com.ExecuteScalar().ToString();
                Author_label a = new Author_label(nickname, name);
                a.ShowDialog();
               
               
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void book_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void price_Click(object sender, EventArgs e)
        {

        }

        private void date_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
