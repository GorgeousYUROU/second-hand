using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Work.Forms.SQL;
using System.Data.SqlClient;
namespace Work.Forms
{
    public partial class Change_search : Form
    {
        public String nickname;
        public String search_Text;
        public Change_search(String nickname, String search_Text)
        {
            InitializeComponent();
            this.nickname = nickname;
            this.search_Text = search_Text;
            this.Nickname_label.Text = nickname;
            this.Search_textBox.Text = search_Text;
            Book_name.Click += Book_name_Click;
            Book_author.Click += Book_name_Click;
            Book_publish.Click += Book_name_Click;
            Book_type.Click += Book_name_Click;
            Book_key.Click += Book_name_Click;
            dataGridView1.MouseDoubleClick += DataGridView1_MouseDoubleClick;
            Book_name.Checked = true;
        }

        private void DataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int rows = dataGridView1.CurrentCell.RowIndex;
            string id = Convert.ToString(dataGridView1.Rows[rows].Cells[0].Value);
            string bookname = Convert.ToString(dataGridView1.Rows[rows].Cells[1].Value);
            Author_label book = new Author_label(nickname, bookname);
            book.Show();
        }

        private void Book_name_Click(object sender, EventArgs e)
        {

            RadioButton r = sender as RadioButton;
            switch (r.Text)
            {
                case "书名": Find("书名"); break;
                case "作者": Find("作者"); break;
                case "出版社": Find("出版社"); break;
                case "分类": Find("分类"); break;
                case "标签": Find("标签"); break;
            }

        }

        private void Find(string text)
        {
            dataGridView1.DataSource = null;
            //查询字符串
            string strsql = null;
            switch (text)
            {
                case "书名": strsql = "select * from book_change where 书籍名称 Like '%" + Search_textBox.Text + "%' and 出售人!='" + nickname + "'"; break;
                case "作者": strsql = "select * from book_change where 书籍作者 Like '%" + Search_textBox.Text + "%' and 出售人!='" + nickname + "'"; break;
                case "出版社": strsql = "select * from book_change where 出版社 Like '%" + Search_textBox.Text + "%' and 出售人!='" + nickname + "'"; break;
                case "分类": strsql = "select * from book_change where 书籍种类 Like '%" + Search_textBox.Text + "%' and 出售人!='" + nickname + "'"; break;
                case "标签": strsql = "select * from book_change where 书籍标签 Like '%" + Search_textBox.Text + "%' and 出售人!='" + nickname + "'"; break;
            }

            Work.Forms.SQL.SqlConnection s = new Work.Forms.SQL.SqlConnection(strsql);
            s.Connection();

            //使用Fill方法填充DataSet，其中的表名"newUser"为DataSet中
            //填充的记录集，这个名字可以随便起，如果要操作其中的记录，
            //可以通过 DataTable tb = ds.Tables["newUser"]; 来进行
            s.da.Fill(s.ds, "book");
            if (s.ds.Tables["book"].Rows.Count != 0)
            {
                //自动生成DataGridView列  
                dataGridView1.AutoGenerateColumns = true;
                //建立数据源  
                BindingSource bs = new BindingSource();
                bs.DataSource = s.ds.Tables["book"];

                //为 GridView 绑定数据源
                dataGridView1.DataSource = bs;
                //dataGridView1.Refresh();
            }
            else { MessageBox.Show("很抱歉没查到你所要的书籍"); }
            s.Close();
        }

        private void Change_search_Load(object sender, EventArgs e)
        {

        }

        private void Change_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                int rows = dataGridView1.CurrentCell.RowIndex;
                string id = Convert.ToString(dataGridView1.Rows[rows].Cells[0].Value);
                if (Nickname_label.Text != "未登录")
                {
                    string str = null;
                    Work.Forms.SQL.SqlConnection s = new Work.Forms.SQL.SqlConnection(str);
                    s.Connection();
                    string str2 = "select friend_ID from friend where friend_nickname='"
                        + Nickname_label.Text + "'";
                    str = "select * from change where friend_ID=(" + str2 + ") and change_state='待交换'";
                    SqlCommand com = new SqlCommand(str, s.conn);
                    SqlDataReader r = com.ExecuteReader();
                    if (r.Read())
                    {
                        string str1 = "select friend_ID from friend where friend_nickname='"
                        + Nickname_label.Text + "'";
                        str = "update change set friend_ID1=(" + str1 + ") where change_ID='" + id + "'";
                        r.Close();
                        com = new SqlCommand(str, s.conn);
                        com.ExecuteNonQuery();


                        str = str = "select *  from collect_card where nickname='" + nickname + "' and card_ID='" + id + "' and card_state='待交换'";
                        com = new SqlCommand(str, s.conn);
                        r = com.ExecuteReader();
                        if (r.Read())
                        {
                            delete(id);
                        }
                        r.Close();
                        s.Close();

                        this.Close();
                        Change a = new Change(this.nickname);
                        a.StartPosition = FormStartPosition.CenterScreen;

                        a.ShowDialog();
                    }
                    else { MessageBox.Show("请先在添加订单中添加交换订单"); }
                }
                else
                {
                    MessageBox.Show("请退回主页登录");
                }
            }
          else  MessageBox.Show("请选择订单");

        }
        public void delete(string id)
        {
            string str = null;
            Work.Forms.SQL.SqlConnection s = new Work.Forms.SQL.SqlConnection(str);
            s.Connection();
            str = "Delete  from collect_card where nickname='" + nickname + "' and card_ID='" + id + "' and card_state='待交换'";
            SqlCommand com = new SqlCommand(str, s.conn);

            com.ExecuteNonQuery();
            s.Close();

        }
        private void Want_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                int rows = dataGridView1.CurrentCell.RowIndex;
          
            
                    string id = Convert.ToString(dataGridView1.Rows[rows].Cells[0].Value);
                    if (Nickname_label.Text != "未登录")
                    {
                        string str = null;
                        Work.Forms.SQL.SqlConnection s = new Work.Forms.SQL.SqlConnection(str);
                        s.Connection();
                        str = "select * from collect_card where nickname='" + nickname + "' and card_ID='" + id + "' and card_state='待交换'";
                        SqlCommand com = new SqlCommand(str, s.conn);
                        SqlDataReader r = com.ExecuteReader();
                        if (!r.Read())
                        {
                            r.Close();
                            str = "insert into collect_card values('" + nickname + "','" + id + "','待交换')";
                            com = new SqlCommand(str, s.conn);
                            com.ExecuteNonQuery();
                            MessageBox.Show("订单加入购物车成功");
                        }
                        else
                        {
                            r.Close();
                            MessageBox.Show("订单已加入购物车");
                        }
                        s.Close();
                    }

                    else
                    {
                        MessageBox.Show("请退回主页登录");
                    }
                }
            
            else { MessageBox.Show("请选择订单"); }
        }

        private void Book_name_CheckedChanged(object sender, EventArgs e)
        {
            if (Book_name.Checked == true)
            {
                dataGridView1.DataSource = null;
                //查询字符串
                string strsql = null;

                strsql = "select * from book_change where 书籍名称 Like '%" + Search_textBox.Text + "%' and 出售人!='" + nickname + "'";


                Work.Forms.SQL.SqlConnection s = new Work.Forms.SQL.SqlConnection(strsql);
                s.Connection();
                //使用Fill方法填充DataSet，其中的表名"newUser"为DataSet中
                //填充的记录集，这个名字可以随便起，如果要操作其中的记录，
                //可以通过 DataTable tb = ds.Tables["newUser"]; 来进行
                s.da.Fill(s.ds, "book");
                if (s.ds.Tables["book"].Rows.Count != 0)
                {
                    //自动生成DataGridView列  
                    dataGridView1.AutoGenerateColumns = true;
                    //建立数据源  
                    BindingSource bs = new BindingSource();
                    bs.DataSource = s.ds.Tables["book"];

                    //为 GridView 绑定数据源
                    dataGridView1.DataSource = bs;
                    //dataGridView1.Refresh();
                    dataGridView1.Columns[2].Visible = false;
                    dataGridView1.Columns[0].Visible = false;
                }
                else { MessageBox.Show("很抱歉没查到你所要的书籍"); }
                s.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
