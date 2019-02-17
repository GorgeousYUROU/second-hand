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
namespace Work
{
    public partial class Collect_card : Form
    {
        public string nickname;
        public Collect_card(string nickname)
        {
            InitializeComponent();
            this.Nickname_label.Text = nickname;
            this.nickname = nickname;
            change.Checked = true;
            change.Click += Change_Click;
            share.Click += Share_Click;
            buy.Click += Buy_Click;
        }

        private void Buy_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "我收藏的售卖订单";
            tableLayoutPanel1.Controls.Clear();
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.ColumnCount = 1;
            string str = "select * from Cbuy where nickname='" + Nickname_label.Text + "'  order by date1 DESC";
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
                tableLayoutPanel1.Controls.Add(new Last((string)r["nickname"], (string)r["n"], r["ID"].ToString(), r["d"].ToString(), Convert.ToDateTime(r["date1"]), (string)r["b"], (string)r["p"], 2,this), 0, row);
                RowStyle cs = tableLayoutPanel1.RowStyles[row];
                cs.SizeType = SizeType.Absolute;
                cs.Height = 93;
                row++;
                this.tableLayoutPanel1.RowCount = row + 1;
                this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 93));

                while (r.Read())
                {
                    tableLayoutPanel1.Controls.Add(new Last((string)r["nickname"], (string)r["n"], r["ID"].ToString(), r["d"].ToString(), Convert.ToDateTime(r["date1"]), (string)r["b"], (string)r["p"], 2,this), 0, row);
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
            groupBox1.Text = "我收藏的转赠订单";
            tableLayoutPanel1.Controls.Clear();
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.ColumnCount = 1;
            string str = "select * from Cshare where nickname='" + Nickname_label.Text + "'  order by date1 DESC";
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
                tableLayoutPanel1.Controls.Add(new Last((string)r["nickname"], (string)r["n"], r["ID"].ToString(), r["d"].ToString(), Convert.ToDateTime(r["date1"]), (string)r["b"], (string)r["p"],1,this), 0, row);
                RowStyle cs = tableLayoutPanel1.RowStyles[row];
                cs.SizeType = SizeType.Absolute;
                cs.Height = 93;
                row++;
                this.tableLayoutPanel1.RowCount = row + 1;
                this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 93));

                while (r.Read())
                {
                    tableLayoutPanel1.Controls.Add(new Last((string)r["nickname"], (string)r["n"], r["ID"].ToString(), r["d"].ToString(), Convert.ToDateTime(r["date1"]), (string)r["b"], (string)r["p"],1,this), 0, row);
                    this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 93));
                    row++;
                    this.tableLayoutPanel1.RowCount = row + 1;
                }
            }
            r.Close();
            s.Close();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "我收藏的交换订单";
            tableLayoutPanel1.Controls.Clear();
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.ColumnCount = 1;
            string str = "select * from Cchange where nickname='" + Nickname_label.Text + "'  order by date1 DESC";
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
                tableLayoutPanel1.Controls.Add(new Last((string)r["nickname"], (string)r["n"], r["ID"].ToString(), r["d"].ToString(), Convert.ToDateTime(r["date1"]), (string)r["b"], (string)r["p"],0,this) ,0, row);
                RowStyle cs = tableLayoutPanel1.RowStyles[row];
                cs.SizeType = SizeType.Absolute;
                cs.Height = 93;
                row++;
                this.tableLayoutPanel1.RowCount = row + 1;
                this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 93));

                while (r.Read())
                {
                    tableLayoutPanel1.Controls.Add(new Last((string)r["nickname"], (string)r["n"], r["ID"].ToString(), r["d"].ToString(), Convert.ToDateTime(r["date1"]), (string)r["b"], (string)r["p"],0,this), 0, row);
                    this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 93));
                    row++;
                    this.tableLayoutPanel1.RowCount = row + 1;
                }
            }
            r.Close();
            s.Close();
            
        }

        private void Collect_card_Load(object sender, EventArgs e)
        {

        }

        private void change_CheckedChanged(object sender, EventArgs e)
        {
            if(change.Checked==true)
            {
                groupBox1.Text = "我收藏的交换订单";
                tableLayoutPanel1.Controls.Clear();
                this.tableLayoutPanel1.RowCount = 1;
                this.tableLayoutPanel1.ColumnCount = 1;
                string str = "select * from Cchange where nickname='" + Nickname_label.Text + "'  order by date1 DESC";
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
                    tableLayoutPanel1.Controls.Add(new Last((string)r["nickname"], (string)r["n"], r["ID"].ToString(), r["d"].ToString(), Convert.ToDateTime(r["date1"]), (string)r["b"], (string)r["p"], 0, this), 0, row);
                    RowStyle cs = tableLayoutPanel1.RowStyles[row];
                    cs.SizeType = SizeType.Absolute;
                    cs.Height = 93;
                    row++;
                    this.tableLayoutPanel1.RowCount = row + 1;
                    this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 93));

                    while (r.Read())
                    {
                        tableLayoutPanel1.Controls.Add(new Last((string)r["nickname"], (string)r["n"], r["ID"].ToString(), r["d"].ToString(), Convert.ToDateTime(r["date1"]), (string)r["b"], (string)r["p"], 0, this), 0, row);
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
            Collect_card b = new Collect_card(nickname);
            b.StartPosition = FormStartPosition.CenterScreen;
            b.ShowDialog();
            this.Close();
        }
    }
}
