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
    public partial class Old : UserControl
    {
        public string uppath;
        public string nickname;
        public string nickname1;
        public string id;
       
        public Old(string name, string uppath, string price, string date, string nickname,string nickname1,string id)
        {
            InitializeComponent();
            this.book.Text = name;
            this.pictureBox1.ImageLocation = uppath;
            this.uppath = uppath;
            
            this.price.Text = price;
            this.date.Text = date;
            this.nickname = nickname;
            this.nickname1 = nickname1;
            button1.Text = nickname1;
            this.id = id;
            this.pictureBox1.DoubleClick += PictureBox1_DoubleClick; ;
            
            this.button1.Click += Button1_Click;

        }

        public Old(string name, string uppath, string price, string date,string nickname,string nickname1,   string id,int flag)
        {
            InitializeComponent();
            this.book.Text = name;
            this.pictureBox1.ImageLocation = uppath;
            this.uppath = uppath;
            this.price.Text = price;
            this.date.Text = date;
            
            this.nickname = nickname;
            this.nickname1 = nickname1;
            if (flag==1)
            {
                label3.Text = "转赠价格:";
                label4.Text = "转赠日期";
                label1.Text = "转赠人";
            }
            else
            {
                label1.Text = "出售人";
            }
            button1.Text = nickname1;
            this.id = id;
            this.pictureBox1.DoubleClick += PictureBox1_DoubleClick; ;

            this.button1.Click += Button1_Click;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (nickname1 != null)
            {
                
                Person a = new Person(nickname1,nickname);
                a.ShowDialog();

            }
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
                s.Close();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
