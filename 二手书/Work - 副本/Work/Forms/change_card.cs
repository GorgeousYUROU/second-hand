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
    public partial class change_card : Form
    {
        public string nickname;
        public change_card(string nickname)
        {
            InitializeComponent();
            this.nickname = nickname;
            this.Nickname_label.Text = this.nickname;
            change.Checked = true;
            change.Click += Change_Click;
            share.Click += Share_Click;
            buy.Click += Buy_Click;
            

        }

        private void Buy_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "未售出的订单";
            tableLayoutPanel1.Controls.Clear();
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.ColumnCount = 1;
            string str = "select * from new_sale where friend_nickname='" + Nickname_label.Text + "'  order by date1 DESC";
            Work.Forms.SQL.SqlConnection s = new Work.Forms.SQL.SqlConnection(str);
            s.Connection();
            SqlCommand com = new SqlCommand(str, s.conn);
            SqlDataReader r = com.ExecuteReader();
            if (!r.Read())
            {
                Label l = new Label();
                l.Text = "暂无此类订单";
                l.Font = new Font("宋体", 15);
                l.AutoSize = true;
                l.SetBounds(400, 200, 300, 40);

                tableLayoutPanel1.Controls.Add(l, 0, 0);
            }
            else
            {
                int row = 0;
                tableLayoutPanel1.Controls.Add(new UserControl1((string)r["name1"], (string)r["path1"],(r["price1"]).ToString(), r["date1"].ToString(),nickname,(string)r["订单号"],this), 0, row);
                RowStyle cs = tableLayoutPanel1.RowStyles[row];
                cs.SizeType = SizeType.Absolute;
                cs.Height = 93;
                row++;
                this.tableLayoutPanel1.RowCount = row + 1;
                this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 93));

                while (r.Read())
                {
                    tableLayoutPanel1.Controls.Add(new UserControl1((string)r["name1"], (string)r["path1"],(r["price1"]).ToString(), r["date1"].ToString(), nickname, (string)r["订单号"],this), 0, row);
                    this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 93));
                    row++;
                    this.tableLayoutPanel1.RowCount = row + 1;
                }
            }
            r.Close();
            s.Close();
        }

        private void Share_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();
            this.tableLayoutPanel1.ColumnCount =1;
            //this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            groupBox1.Text = "待转赠订单";
            string str = "select * from new_share where friend_nickname='" + Nickname_label.Text + "' order by date1 DESC";
            Work.Forms.SQL.SqlConnection s = new Work.Forms.SQL.SqlConnection(str);
            s.Connection();
            SqlCommand com = new SqlCommand(str, s.conn);
            SqlDataReader r = com.ExecuteReader();
            if (!r.Read())
            {
                Label l = new Label();
                l.Text = "暂无此类订单";
                l.Font = new Font("宋体", 15);
                l.AutoSize = true;
                l.SetBounds(400, 200, 300, 40);
                tableLayoutPanel1.Controls.Add(l, 0, 0);
                
            }
            else
            {
                int row = 0;
                tableLayoutPanel1.Controls.Add(new UserControl1((string)r["name1"], (string)r["path1"], "0", r["date1"].ToString(), nickname,(string)r["订单号"],this), 0, row);
                RowStyle cs = tableLayoutPanel1.RowStyles[row];
                cs.SizeType = SizeType.Absolute;
                cs.Height = 93;
                row++;
                this.tableLayoutPanel1.RowCount = row+1;
                this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute,93));
                while (r.Read())
                {
                    tableLayoutPanel1.Controls.Add(new UserControl1((string)r["name1"], (string)r["path1"], "0", r["date1"].ToString(), nickname, (string)r["订单号"],this), 0, row);
                    this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 93));
                    row++;
                    this.tableLayoutPanel1.RowCount = row+1;
                }
            }
            r.Close();
            s.Close();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "我的待交换订单";
            tableLayoutPanel1.Controls.Clear();
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.ColumnCount = 1;
            string str = "select * from new_change where friend_nickname='" + Nickname_label.Text + "'  order by date1 DESC";
            Work.Forms.SQL.SqlConnection s = new Work.Forms.SQL.SqlConnection(str);
            s.Connection();
            SqlCommand com = new SqlCommand(str, s.conn);
            SqlDataReader r = com.ExecuteReader();
            if (!r.Read())
            {
                Label l = new Label();
                l.Text = "暂无此类订单";
                l.Font = new Font("宋体", 15);
                l.AutoSize = true;
                l.SetBounds(400, 200, 300, 40);

                tableLayoutPanel1.Controls.Add(l, 0, 0);
            }
            else
            {
                int row = 0;
                tableLayoutPanel1.Controls.Add(new UserControl1((string)r["name1"], (string)r["path1"], (r["price1"]).ToString(), r["date1"].ToString(),1,nickname,(string)r["订单号"],this), 0, row);
                RowStyle cs = tableLayoutPanel1.RowStyles[row];
                cs.SizeType = SizeType.Absolute;
                cs.Height = 93;
                row++;
                this.tableLayoutPanel1.RowCount = row + 1;
                this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 93));

                while (r.Read())
                {
                    tableLayoutPanel1.Controls.Add(new UserControl1((string)r["name1"], (string)r["path1"], (r["price1"]).ToString(), r["date1"].ToString(),1, nickname, (string)r["订单号"],this), 0, row);
                    this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 93));
                    row++;
                    this.tableLayoutPanel1.RowCount = row + 1;
                }
            }
            r.Close();
            s.Close();
        }

        
        private void change_card_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void change_CheckedChanged(object sender, EventArgs e)
        {
            if (change.Checked == true)
            {
                groupBox1.Text = "我的待交换订单";
                tableLayoutPanel1.Controls.Clear();
                this.tableLayoutPanel1.RowCount = 1;
                this.tableLayoutPanel1.ColumnCount = 1;
                string str = "select * from new_change where friend_nickname='" + Nickname_label.Text + "'  order by date1 DESC";
                Work.Forms.SQL.SqlConnection s = new Work.Forms.SQL.SqlConnection(str);
                s.Connection();
                SqlCommand com = new SqlCommand(str, s.conn);
                SqlDataReader r = com.ExecuteReader();
                if (!r.Read())
                {
                    Label l = new Label();
                    l.Text = "暂无此类订单";
                    l.Font = new Font("宋体", 15);
                    l.AutoSize = true;
                    l.SetBounds(400, 200, 300, 40);

                    tableLayoutPanel1.Controls.Add(l, 0, 0);
                }
                else
                {
                    int row = 0;
                    tableLayoutPanel1.Controls.Add(new UserControl1((string)r["name1"], (string)r["path1"], (r["price1"]).ToString(), r["date1"].ToString(), 1, nickname, (string)r["订单号"], this), 0, row);
                    RowStyle cs = tableLayoutPanel1.RowStyles[row];
                    cs.SizeType = SizeType.Absolute;
                    cs.Height = 93;
                    row++;
                    this.tableLayoutPanel1.RowCount = row + 1;
                    this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 93));

                    while (r.Read())
                    {
                        tableLayoutPanel1.Controls.Add(new UserControl1((string)r["name1"], (string)r["path1"], (r["price1"]).ToString(), r["date1"].ToString(), 1, nickname, (string)r["订单号"], this), 0, row);
                        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 93));
                        row++;
                        this.tableLayoutPanel1.RowCount = row + 1;
                    }
                }
                r.Close();
                s.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            change_card b = new change_card(nickname);
            b.StartPosition = FormStartPosition.CenterScreen;
            b.ShowDialog();
            this.Close();
        }
    }
}
