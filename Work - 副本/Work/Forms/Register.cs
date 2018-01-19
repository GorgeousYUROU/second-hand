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
    public partial class Register : Form
    {
        public MainLogin A = null;
        public Register(MainLogin A)
        {
            InitializeComponent();
            this.A = A;
            Account_textBox.MouseDown += Account_textBox_MouseDown;
            PassWord_textBox.MouseDown+= Account_textBox_MouseDown;
            Account_textBox.MouseHover += Account_textBox_MouseHover;
            PassWord_textBox.MouseHover += PassWord_textBox_MouseHover;
        }

        private void PassWord_textBox_MouseHover(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;

            if (t.Text == "") t.Text = "请输入密码";
        }

        private void Account_textBox_MouseHover(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;

            if (t.Text == "") t.Text = "请输入昵称";
        }

        private void Account_textBox_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox t = sender as TextBox;
            t.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.A.Show();

        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            A.Close();
            this.Close();
        }

        private void PassWord_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            String str = "select * from friend where friend_nickname='" + Account_textBox.Text + "'";
            Work.Forms.SQL.SqlConnection s = new Work.Forms.SQL.SqlConnection(str);
            s.Connection();
            s.da.Fill(s.ds, "friend");
            SqlCommand c = s.da.SelectCommand;
            Object o = c.ExecuteScalar();
            if ((o != null))
            {
                MessageBox.Show("账号已存在", "需要再次输入", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
            else
            {
                str = "select top 1 * from friend order by friend_ID DESC";
                c = new SqlCommand(str, s.conn);
                SqlDataReader r = c.ExecuteReader();
                r.Read();
                Int32 t = Convert.ToInt32(r["friend_ID"])+1;
                string id = t.ToString();
                str = "insert into friend values('" +id+ "',null,null,'"+
                    PassWord_textBox.Text+"',null,null,'"+ Account_textBox.Text + "',null,null)";
                r.Close();
                c = new SqlCommand(str, s.conn);
                c.ExecuteNonQuery();

                s.Close();
                ManiForm B = this.A.A;
                    B.nickname = this.Account_textBox.Text;
                string n = this.Account_textBox.Text;
                    this.Close();
                    A.Close();
                   
                new Person(n,0).ShowDialog();
                B.Show();


            }


        }
    }
}
