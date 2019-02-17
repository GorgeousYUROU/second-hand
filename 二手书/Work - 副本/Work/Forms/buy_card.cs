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
    public partial class buy_card : Form
    {
        public string nickname;
        public buy_card(string nickname)
        {
            InitializeComponent();
            this.nickname = nickname;
            this.Nickname_label.Text = nickname;
            this.buy.Click += Buy_Click;
            this.share.Click += Share_Click;
            share.Checked = true;
        }

        private void Share_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "我的转赠订单";
            this.tableLayoutPanel1.Controls.Clear();
            string str = "select * from old_accept where friend_ID=(select friend_ID from friend where friend_nickname='" + nickname + "') order by date1 desc";
            Work.Forms.SQL.SqlConnection s = new Work.Forms.SQL.SqlConnection(str);
            s.Connection();
            SqlCommand com = new SqlCommand(str, s.conn);
            SqlDataReader r = com.ExecuteReader();
            if (!r.Read())
            {
                Label l = new Label();
                l.Text = "暂无此类订单";
                l.Font = new Font("宋体", 15);
                tableLayoutPanel1.Controls.Add(l, 0, 0);
            }
            else
            {
                int row = 0;
                tableLayoutPanel1.Controls.Add(new Old((string)r["name1"], (string)r["path1"],
                    r["price1"].ToString(), r["date1"].ToString(), nickname, (string)r["nickname"], (string)r["sale_ID"],1), 0, row);
                RowStyle cs = tableLayoutPanel1.RowStyles[row];
                cs.SizeType = SizeType.Absolute;
                cs.Height = 93;
                this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 93));
                row++;
                tableLayoutPanel1.RowCount = row + 1;
                while (r.Read())
                {
                    tableLayoutPanel1.Controls.Add(new Old((string)r["name1"], (string)r["path1"],
                    r["price1"].ToString(), r["date1"].ToString(), nickname, (string)r["nickname"], (string)r["sale_ID"],1), 0, row);
                    this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 93));
                    row++;
                    tableLayoutPanel1.RowCount = row + 1;
                }
            }
            r.Close();
            s.Close();
        }

        private void Buy_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "我的已买订单";
            this.tableLayoutPanel1.Controls.Clear();
            string str = "select * from old_buy where friend_ID=(select friend_ID from friend where friend_nickname='" + nickname + "') order by date1 desc";
            Work.Forms.SQL.SqlConnection s = new Work.Forms.SQL.SqlConnection(str);
            s.Connection();
            SqlCommand com = new SqlCommand(str, s.conn);
            SqlDataReader r = com.ExecuteReader();
            if (!r.Read())
            {
                Label l = new Label();
                l.Text = "暂无此类订单";
                l.Font = new Font("宋体", 15);
                tableLayoutPanel1.Controls.Add(l, 0, 0);
            }
            else
            {
                int row = 0;
                tableLayoutPanel1.Controls.Add(new Old((string)r["name1"], (string)r["path1"],
                    r["price1"].ToString(), r["date1"].ToString(), nickname, (string)r["nickname"], (string)r["sale_ID"],0), 0, row);
                RowStyle cs = tableLayoutPanel1.RowStyles[row];
                cs.SizeType = SizeType.Absolute;
                cs.Height = 93;
                this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 93));
                row++;
                tableLayoutPanel1.RowCount = row + 1;
                while (r.Read())
                {
                    tableLayoutPanel1.Controls.Add(new Old((string)r["name1"], (string)r["path1"],
                    r["price1"].ToString(), r["date1"].ToString(), nickname, (string)r["nickname"], (string)r["sale_ID"],0), 0, row);
                    this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 93));
                    row++;
                    tableLayoutPanel1.RowCount = row + 1;
                }
            }
            r.Close();
            s.Close();
        }
        private void buy_card_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            buy_card b = new buy_card(nickname);
            b.StartPosition = FormStartPosition.CenterScreen;
            b.ShowDialog();
            this.Close();
        }

        private void share_CheckedChanged(object sender, EventArgs e)
        {
            if (share.Checked == true)
            {
                groupBox1.Text = "我的转赠订单";
                this.tableLayoutPanel1.Controls.Clear();
                string str = "select * from old_accept where friend_ID=(select friend_ID from friend where friend_nickname='" + nickname + "') order by date1 desc";
                Work.Forms.SQL.SqlConnection s = new Work.Forms.SQL.SqlConnection(str);
                s.Connection();
                SqlCommand com = new SqlCommand(str, s.conn);
                SqlDataReader r = com.ExecuteReader();
                if (!r.Read())
                {
                    Label l = new Label();
                    l.Text = "暂无此类订单";
                    l.Font = new Font("宋体", 15);
                    tableLayoutPanel1.Controls.Add(l, 0, 0);
                }
                else
                {
                    int row = 0;
                    tableLayoutPanel1.Controls.Add(new Old((string)r["name1"], (string)r["path1"],
                        r["price1"].ToString(), r["date1"].ToString(), nickname, (string)r["nickname"], (string)r["sale_ID"], 1), 0, row);
                    RowStyle cs = tableLayoutPanel1.RowStyles[row];
                    cs.SizeType = SizeType.Absolute;
                    cs.Height = 93;
                    this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 93));
                    row++;
                    tableLayoutPanel1.RowCount = row + 1;
                    while (r.Read())
                    {
                        tableLayoutPanel1.Controls.Add(new Old((string)r["name1"], (string)r["path1"],
                        r["price1"].ToString(), r["date1"].ToString(), nickname, (string)r["nickname"], (string)r["sale_ID"], 1), 0, row);
                        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 93));
                        row++;
                        tableLayoutPanel1.RowCount = row + 1;
                    }
                }
                r.Close();
                s.Close();
            }
        }
    }
}
