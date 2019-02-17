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
namespace Work.Forms.SQL
{
    public partial class Person : Form
    {
        public string nickname;
        public Person(string nickname,string nickname1)
        {
            InitializeComponent();
            this.nickname = nickname;
            this.Nickname_label.Text = nickname1;
            this.nickname_textBox.Text = nickname;
            reset();
            name_textBox.ReadOnly = true;
            grade_textBox.ReadOnly = true;
            grade_textBox.ReadOnly = true;
            profession_textBox.ReadOnly = true;
            phone_textBox.ReadOnly = true;
            Description_textBox.ReadOnly = true;
        }

        private void reset()
        {
            String str = "select * from friend where friend_nickname='" + nickname + "'";
            Work.Forms.SQL.SqlConnection s = new SQL.SqlConnection(str);
            s.Connection();
            SqlCommand c;
            c = new SqlCommand(str, s.conn);
            SqlDataReader r = c.ExecuteReader();
            r.Read();

            if (!r.IsDBNull(1))
            {
                name_textBox.Text = (string)r["friend_name"];
            }

            if (!r.IsDBNull(5))
                grade_textBox.Text = ((int)r["friend_grade"]).ToString();
            else grade_textBox.Text = "暂无";
            if (!r.IsDBNull(4))
                profession_textBox.Text = (string)r["friend_speciality"];
            else profession_textBox.Text = "暂无";
            if (!r.IsDBNull(8))
                phone_textBox.Text = (string)r["friend_phone"];
            if (!r.IsDBNull(7))
                Description_textBox.Text = (string)r["friend_descreption"];
            else Description_textBox.Text = "这个有点懒，什么都没有~~~~~";
            r.Close();
            s.Close();
        }

        private void Person_Load(object sender, EventArgs e)
        {

        }
    }
}
