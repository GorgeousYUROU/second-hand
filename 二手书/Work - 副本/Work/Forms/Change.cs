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
    public partial class Change : Form
    {
        string nickname;
        public Change(string nickname)
        {
            InitializeComponent();
            this.nickname = nickname;
            this.Nickname_label.Text = nickname;
            reset();
        }

        private void reset()
        {
            string str = "select * from old_change where n='" + Nickname_label.Text + "' and n!=n1  order by date1 DESC";
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
                tableLayoutPanel1.Controls.Add(new Sa((string)r["n"], (string)r["n1"], (r["b"]).ToString(), r["b1"].ToString(), (r["d"]).ToString(), r["d1"].ToString(), r["date1"].ToString(),r["p"].ToString(), r["p1"].ToString()), 0, row);
                RowStyle cs = tableLayoutPanel1.RowStyles[row];
                cs.SizeType = SizeType.Absolute;
                cs.Height = 120;
                row++;
                this.tableLayoutPanel1.RowCount = row + 1;
                this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 120));

                while (r.Read())
                {
                    tableLayoutPanel1.Controls.Add(new Sa((string)r["n"], (string)r["n1"], (r["b"]).ToString(), r["b1"].ToString(), (r["d"]).ToString(), r["d1"].ToString(), r["date1"].ToString(), r["p"].ToString(), r["p1"].ToString()), 0, row);
                    this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 120));
                    row++;
                    this.tableLayoutPanel1.RowCount = row + 1;
                }
            }
            r.Close();
            s.Close();
        }
        private void Change_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Change b = new Change(nickname);
            b.StartPosition = FormStartPosition.CenterScreen;
            b.ShowDialog();
            this.Close();
        }
    }
}
