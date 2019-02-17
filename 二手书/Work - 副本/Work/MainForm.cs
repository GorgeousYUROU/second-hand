using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Work.Forms;

namespace Work
{
    public partial class ManiForm : Form
    {
        public string nickname="未登录";
        string uppath;
        public ManiForm()
        {
            InitializeComponent();
            toolTip1.SetToolTip(add, "添加售卖订单或交换订单");
            toolTip2.SetToolTip(button5, "查看待交换，待转赠,未卖");
            toolTip3.SetToolTip(button6, "查看已转赠,已卖");
            toolTip4.SetToolTip(button11, "查看转赠,已买");
            pictureBox1.DoubleClick += pictureBox1_Click;
            pictureBox2.DoubleClick += pictureBox1_Click;
            pictureBox3.DoubleClick += pictureBox1_Click;
            pictureBox4.DoubleClick += pictureBox1_Click;
            pictureBox5.DoubleClick += pictureBox1_Click;
            reset();
        }

        
        public void reset()
        {
            string str = "select top 5 name1 from Cbook group by name1 order by count(name1) DESC";
            Work.Forms.SQL.SqlConnection s = new Work.Forms.SQL.SqlConnection(str);
            s.Connection();
            SqlCommand com = new SqlCommand(str, s.conn);
            SqlDataReader r = com.ExecuteReader();
            string[] name = new string[5];
            int i = 0;
            while (r.Read())
            {
                name[i] = r["name1"].ToString();
                i++;
            }
            r.Close();
            for (int j = 0; j < 5; j++)
            {
                str = "select image_path from book where book_name='" + name[j] + "'";
                
                com = new SqlCommand(str, s.conn);
                uppath = com.ExecuteScalar().ToString();
                if (j == 0) { pictureBox1.ImageLocation = uppath; }
                if (j == 1) { pictureBox2.ImageLocation = uppath;  }
                if (j == 2) { pictureBox3.ImageLocation = uppath;  }
                if (j == 3) { pictureBox4.ImageLocation = uppath;  }
                if (j == 4) { pictureBox5.ImageLocation = uppath; }

            }
            s.Close();
        }
        private void ManiForm_Load(object sender, EventArgs e)
        {
            this.MouseWheel += FormSample_MouseWheel;
            string str = "select book_name from book ";
            Work.Forms.SQL.SqlConnection s = new Forms.SQL.SqlConnection(str);
            s.Connection();
            SqlCommand com = new SqlCommand(str, s.conn);
            SqlDataReader r = com.ExecuteReader();
            string m ="";
            r.Read();
            m = r[0].ToString();
            while (r.Read())
            {
                m+=","+r[0].ToString();
               
            }
            r.Close();
            s.Close();
            string[] m1 = m.Split(',');
            var source = new AutoCompleteStringCollection();
            source.AddRange(m1);
            Search_textBox.AutoCompleteCustomSource = source;
            Search_textBox.MouseDown += Search_textBox_MouseDown;


        }

        private void Search_textBox_MouseDown(object sender, MouseEventArgs e)
        {
            Search_textBox.Text = "";
        }

        /// <summary>  
        /// 滚动方法  
        /// </summary>  
        /// <param name="sender"></param>  
        /// <param name="e"></param>  
        void FormSample_MouseWheel(object sender, MouseEventArgs e)
        {
            //获取光标位置  
            Point mousePoint = new Point(e.X, e.Y);
            //换算成相对本窗体的位置  
            mousePoint.Offset(this.Location.X, this.Location.Y);
            //判断是否在panel内  
            if (panel1.RectangleToScreen(panel2.DisplayRectangle).Contains(mousePoint))
            {
                //滚动  
                panel2.AutoScrollPosition = new Point(0, panel2.VerticalScroll.Value - e.Delta);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Nickname_button.Text != "未登录")
            {
                Collect_card collect = new Collect_card(this.nickname);
                collect.StartPosition = FormStartPosition.CenterScreen;

                collect.ShowDialog();
            }
            else
            {
                MessageBox.Show("请先登录");
                MainLogin mainlogin = new Forms.MainLogin(this);
                mainlogin.ShowDialog();
                if (nickname != null) Nickname_button.Text = nickname;
            }
        }

        private void Nickname_button_Click(object sender, EventArgs e)
        {
            if (Nickname_button.Text == "未登录")
            {
                MainLogin mainlogin = new Forms.MainLogin(this);
                mainlogin.ShowDialog();
                if (nickname != null) Nickname_button.Text = nickname;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Search search = new Search(this.nickname, Search_textBox.Text);
            search.StartPosition = FormStartPosition.CenterScreen;
        
            search.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Change_search search = new Change_search(this.nickname, Search_textBox.Text);
            search.StartPosition = FormStartPosition.CenterScreen;

            search.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Nickname_button.Text != "未登录")
            {
                Person person = new Person(this.nickname);
                person.StartPosition = FormStartPosition.CenterScreen;

                person.ShowDialog();
            }
            else
            {
                MessageBox.Show("请先登录");
                MainLogin mainlogin = new Forms.MainLogin(this);
                mainlogin.ShowDialog();
                if (nickname != null) Nickname_button.Text = nickname;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Nickname_button.Text = "未登录";
            this.nickname = "未登录";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Nickname_button.Text != "未登录")
            {
                Book_card book = new Book_card(this.nickname);
           book.StartPosition = FormStartPosition.CenterScreen;

            book.ShowDialog();
            }
            else
            {
                MessageBox.Show("请先登录");
                MainLogin mainlogin = new Forms.MainLogin(this);
                mainlogin.ShowDialog();
                if (nickname != null) Nickname_button.Text = nickname;
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Nickname_button.Text != "未登录")
            {
               change_card change = new change_card(this.nickname);
            change.StartPosition = FormStartPosition.CenterScreen;

            change.ShowDialog();  
            }
            else
            {
                MessageBox.Show("请先登录");
                MainLogin mainlogin = new Forms.MainLogin(this);
                mainlogin.ShowDialog();
                if (nickname != null) Nickname_button.Text = nickname;
            }
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Nickname_button.Text != "未登录")
            {
               sale_card sale = new sale_card(this.nickname);
            sale.StartPosition = FormStartPosition.CenterScreen;

            sale.ShowDialog();
            }
            else
            {
                MessageBox.Show("请先登录");
                MainLogin mainlogin = new Forms.MainLogin(this);
                mainlogin.ShowDialog();
                if (nickname != null) Nickname_button.Text = nickname;
            }
            
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (Nickname_button.Text != "未登录")
            {
                Add a = new Add(this.nickname);
                a.StartPosition = FormStartPosition.CenterScreen;

                a.ShowDialog();
            }
            else
            {
                MessageBox.Show("请先登录");
                MainLogin mainlogin = new Forms.MainLogin(this);
                mainlogin.ShowDialog();
                if (nickname != null) Nickname_button.Text = nickname;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Nickname_button.Text != "未登录")
            {
                buy_card a = new buy_card(this.nickname);
                a.StartPosition = FormStartPosition.CenterScreen;

                a.ShowDialog();
            }
            else
            {
                MessageBox.Show("请先登录");
                MainLogin mainlogin = new Forms.MainLogin(this);
                mainlogin.ShowDialog();
                if (nickname != null) Nickname_button.Text = nickname;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Nickname_button.Text != "未登录")
            {
                Change a = new Change(this.nickname);
                a.StartPosition = FormStartPosition.CenterScreen;

                a.ShowDialog();
            }
            else
            {
                MessageBox.Show("请先登录");
                MainLogin mainlogin = new Forms.MainLogin(this);
                mainlogin.ShowDialog();
                if (nickname != null) Nickname_button.Text = nickname;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string str = "select * from book where image_path='" + (sender as PictureBox).ImageLocation + "'";
            Work.Forms.SQL.SqlConnection s = new Work.Forms.SQL.SqlConnection(str);
            s.Connection();
            SqlCommand com = new SqlCommand(str, s.conn);
            SqlDataReader r = com.ExecuteReader();
            r.Read();
            string name = r["book_name"].ToString();
            r.Close();
            s.Close();
            Author_label a = new Author_label(nickname, name);
            a.ShowDialog();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Thanks m = new Thanks();
            m.StartPosition = FormStartPosition.CenterScreen;
            m.ShowDialog();
        }
    }
}
