using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Work.Forms.SQL
{
    public partial class Last : UserControl
    {
        string nickname;
        string n;
        string id;
        string uppath;
        string name;
        string date1;
        int flag;
        string state;
        Form a;
        public Last(string nickname, string n, string id, string d, DateTime date1, string b, string p, int flag, Form a)
        {

            InitializeComponent();
            if (flag == 0)
            {
                state = "待交换";
            }
            if (flag == 1)
            {
                state = "转赠";
            }
            if (flag == 2)
            {
                state = "在卖";
            }
            this.flag = flag;
            this.nickname = nickname;
            this.n = n;
            this.id = id;
            this.a = a;
            this.date1 = (DateTime.Now - date1).Days.ToString();
            this.name = b;
            this.uppath = p;
            pictureBox1.DoubleClick += PictureBox1_DoubleClick;
            this.book.Text = name;
            price.Text = n;
            date.Text = d;
            label2.Text = this.date1;
            pictureBox1.ImageLocation = uppath;
            if (flag == 1)
            {
                label3.Text = "转赠者";
                label4.Text = "转赠价";
                button1.Text = "转赠";
            }
            if (flag == 2)
            {
                label3.Text = "售卖者";
                label4.Text = "售卖价";
                button1.Text = "购买";
            }
        }

        public void delete()
        {
            string str = null;
            Work.Forms.SQL.SqlConnection s = new Work.Forms.SQL.SqlConnection(str);
            s.Connection();
            str = "Delete  from collect_card where nickname='" + nickname + "' and card_ID='" + id + "' and card_state='" + state + "'";
            SqlCommand com = new SqlCommand(str, s.conn);

            com.ExecuteNonQuery();
            s.Close();

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
                a.Show();
                s.Close();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                string str = null;
                Work.Forms.SQL.SqlConnection s = new Work.Forms.SQL.SqlConnection(str);
                s.Connection();
                string str2 = "select friend_ID from friend where friend_nickname='"
                    + nickname + "'";
                str = "select * from change where friend_ID=(" + str2 + ") and change_state='待交换'";
                SqlCommand com = new SqlCommand(str, s.conn);
                SqlDataReader r = com.ExecuteReader();
                if (r.Read())
                {
                    string str1 = "select friend_ID from friend where friend_nickname='"
                    + nickname + "'";
                    str = "update change set friend_ID1=(" + str1 + ") where change_ID='" + id + "'";
                    r.Close();
                    com = new SqlCommand(str, s.conn);
                    com.ExecuteNonQuery();
                    s.Close();
                    MessageBox.Show("交换成功，可在我的订单查询");
                   
                    delete();
                    a.Hide();
                    Change b = new Change(nickname);
                    b.StartPosition = FormStartPosition.CenterScreen;
                    b.ShowDialog();
                    a.Close();
                }
                else { MessageBox.Show("请先在添加订单中添加交换订单"); }
                r.Close();
                s.Close();
            }
            if (flag == 1)
            {
                string str = null;
                Work.Forms.SQL.SqlConnection s = new Work.Forms.SQL.SqlConnection(str);
                s.Connection();
                string str1 = "select friend_ID from friend where friend_nickname='"
                    + nickname + "'";
                str = "update sale set friend_ID1=(" + str1 + ") where sale_ID='" + id + "'";

                SqlCommand com = new SqlCommand(str, s.conn);

                com = new SqlCommand(str, s.conn);
                com.ExecuteNonQuery();
                s.Close();
                MessageBox.Show("转赠成功，可在我的订单查询");
                delete();
                a.Hide();
                buy_card b = new buy_card(nickname);
                b.StartPosition = FormStartPosition.CenterScreen;
                b.ShowDialog();
                a.Close();




            }
            if (flag == 2)
            {
                string str = null;
                Work.Forms.SQL.SqlConnection s = new Work.Forms.SQL.SqlConnection(str);
                s.Connection();
                string str1 = "select friend_ID from friend where friend_nickname='"
                    + nickname + "'";
                str = "update sale set friend_ID1=(" + str1 + ") where sale_ID='" + id + "'";

                SqlCommand com = new SqlCommand(str, s.conn);

                com = new SqlCommand(str, s.conn);
                com.ExecuteNonQuery();
                s.Close();
                MessageBox.Show("购买成功，可在我的订单查询");

                delete();
                a.Hide();
                buy_card b = new buy_card(nickname);
                b.StartPosition = FormStartPosition.CenterScreen;
                b.ShowDialog();
                a.Close();

            }


        }


        private void button2_Click(object sender, EventArgs e)
        {
            delete();
            MessageBox.Show("取消收藏成功，请重新查看");
            a.Hide();
            Collect_card b = new Collect_card(nickname);
            b.StartPosition = FormStartPosition.CenterScreen;
            b.ShowDialog();
            a.Close();

        }
    }
}

    

