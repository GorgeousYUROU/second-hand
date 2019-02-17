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
    public partial class search_book : Form
    {
        public String nickname;
        public String search_Text;

        public search_book(String nickname, String search_Text)
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
                case "书名": strsql = "select book_ID,book_name,book_author,book_publish,book_type,book_key,book_price from book where book_name Like '%" + Search_textBox.Text + "%'"; break;
                case "作者": strsql = "select book_ID,book_name,book_author,book_publish,book_type,book_key,book_price from book where book_author Like '%" + Search_textBox.Text + "%'"; break;
                case "出版社": strsql = "select book_ID,book_name,book_author,book_publish,book_type,book_key,book_price from book where book_publish Like '%" + Search_textBox.Text + "%'"; break;
                case "分类": strsql = "select book_ID,book_name,book_author,book_publish,book_type,book_key,book_price from book where book_type Like '%" + Search_textBox.Text + "%'"; break;
                case "标签": strsql = "select book_ID,book_name,book_author,book_publish,book_type,book_key,book_price from book where book_key Like '%" + Search_textBox.Text + "%'"; break;
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
        private void search_book_Load(object sender, EventArgs e)
        {
            
            


        }

      
    

        private void Book_name_CheckedChanged(object sender, EventArgs e)
        {
            if (Book_name.Checked == true)
            {
                dataGridView1.DataSource = null;
                //查询字符串
                string strsql = null;

                strsql = "select book_ID,book_name,book_author,book_publish,book_type,book_key,book_price from book where book_name Like '%" + Search_textBox.Text + "%'";



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
        }
    }
}
