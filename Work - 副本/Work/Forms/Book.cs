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
using Work.Forms.SQL;
namespace Work.Forms
{
    public partial class Author_label : Form
    {
        public string nickname;
        public string bookname;
        public Author_label(string nickname,string bookname)
        {
            InitializeComponent();
            this.nickname = nickname;
            this.Nickname_label.Text = nickname;
            this.bookname = bookname;
            this.BookName.Text = bookname;
            reset();
            Card("交换单");
            Card("买赠单");
           
        }

      
        private void Card(string text)
        {
            string str = null;
            Work.Forms.SQL.SqlConnection s; 
           if(text=="交换单")
            {
               
                str = "select * from dbo.change_card('" + bookname + "')";
                s = new Work.Forms.SQL.SqlConnection(str);
                s.Connection();
                s.da.Fill(s.ds, "book");
                
                    //自动生成DataGridView列  
                    dataGridView1.AutoGenerateColumns = true;
                    //建立数据源  
                    BindingSource bs = new BindingSource();
                    bs.DataSource = s.ds.Tables["book"];
                
                    //为 GridView 绑定数据源
                    dataGridView1.DataSource = bs;
                dataGridView1.Columns[3].DefaultCellStyle.Format = "yyyy-MM-dd";
                //dataGridView1.Refresh();
                s.Close();
            }
            if (text == "买赠单")
            {

                str = "select * from dbo.sale_card('" + bookname + "')";
                s = new Work.Forms.SQL.SqlConnection(str);
                s.Connection();
                s.da.Fill(s.ds, "book");

                //自动生成DataGridView列  
                dataGridView2.AutoGenerateColumns = true;
                //建立数据源  
                BindingSource bs = new BindingSource();
                bs.DataSource = s.ds.Tables["book"];

                //为 GridView 绑定数据源
                dataGridView2.DataSource = bs;
                dataGridView2.Columns[3].DefaultCellStyle.Format = "yyyy-MM-dd";
                //dataGridView1.Refresh();
                s.Close();
            }
            
        }
        private void reset()
        {
            String str = "select * from book where book_name='" + bookname + "'";
            Work.Forms.SQL.SqlConnection s = new SQL.SqlConnection(str);
            s.Connection();
            SqlCommand c;
            c = new SqlCommand(str, s.conn);
            SqlDataReader r = c.ExecuteReader();
            r.Read();

            if (!r.IsDBNull(3))
            {
                author.Text = (string)r["book_author"];
            }

            if (!r.IsDBNull(2))
            {
                price.Text = Convert.ToString(Convert.ToInt16(r["book_price"]));
                if (price.Text == "0") price.Text = "暂无";
            }
            else price.Text = "暂无";
            if (!r.IsDBNull(8))
            {
                if ((string)r["image_path"] != "not")
                    pictureBox1.ImageLocation = (string)r["image_path"];
                else
                    pictureBox1.ImageLocation = "..\\..\\image\\TMPSNAPSHOT1494254004016.jpg";
            }
            else
                pictureBox1.ImageLocation = "..\\..\\image\\TMPSNAPSHOT1494254004016.jpg";
            if (!r.IsDBNull(0))
               number.Text = (string)r["book_ID"];
            if (!r.IsDBNull(5))
                publish.Text = (string)r["book_publish"];
            if (!r.IsDBNull(4))
                type.Text = (string)r["book_type"];
            
            if (!r.IsDBNull(6))
                key.Text = (string)r["book_key"];
            else key.Text = "暂无";
            if (!r.IsDBNull(7))
                description.Text = (string)r["book_description"];
            else description.Text = "暂无";
            r.Close();
            
            str = "select * from collect_book where book_ID='" + number.Text + "' and nickname='" + nickname + "'";
            s = new Work.Forms.SQL.SqlConnection(str);
            s.Connection();
            SqlCommand com = new SqlCommand(str, s.conn);
            r = com.ExecuteReader();
            if (r.Read())
            {
                button1.ImageIndex = 1;
                
            }
            r.Close();
            s.Close();
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void Author_label_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button t = (sender as Button);
            if(Nickname_label.Text!="未登录")
            {
                if (t.ImageIndex==0)
                {
                    string str = "insert into collect_book Values('" + number.Text + "','" + nickname + "')";
                    Work.Forms.SQL.SqlConnection s = new Work.Forms.SQL.SqlConnection(str);
                    s.Connection();
                    SqlCommand com = new SqlCommand(str, s.conn);
                    com.ExecuteNonQuery();
                    s.Close();
                    button1.ImageIndex = 1;
                }
                else
                {
                    string str = str = "delete from collect_book where book_ID='" + number.Text + "' and nickname='" + nickname + "'";
                    Work.Forms.SQL.SqlConnection s = new Work.Forms.SQL.SqlConnection(str);
                    s.Connection();
                    SqlCommand com = new SqlCommand(str, s.conn);
                    com.ExecuteNonQuery();
                    s.Close();
                    button1.ImageIndex = 0;
                }

            }
            else
            {
                MessageBox.Show("请退回主页登录");
            }
}

        private void key_Click(object sender, EventArgs e)
        {

        }
    }
}
