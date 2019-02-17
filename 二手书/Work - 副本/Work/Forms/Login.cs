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
    public partial class Login : Form
    {
        MainLogin A=null;
        public Login()
        {
            InitializeComponent();
        }
        public Login(MainLogin A)
        {
            InitializeComponent();
            this.A= A;
            Account_textBox.MouseDown += Account_textBox_MouseDown;
            PassWord_textBox.MouseDown += Account_textBox_MouseDown;
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
        public string getText()
        {
            return Account_textBox.Text;
        }
        private void Login_richTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            
            
            this.Close();
            A.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
           this.A.Show();
            
        }

        private void PassWord_textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;

            t.PasswordChar = '*';
        }

        private void Account_textBoc_TextChanged(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;

        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            String str = "select * from friend where friend_nickname='"+ Account_textBox.Text+"'";
            Work.Forms.SQL.SqlConnection s = new Work.Forms.SQL.SqlConnection(str);
            s.Connection();
            s.da.Fill(s.ds, "friend");
            SqlCommand c = s.da.SelectCommand;
            Object o = c.ExecuteScalar();
            if ((o==null) )
            {
                MessageBox.Show("账号不存在或输入错误", "需要再次输入", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                s.Close();
            }
            else
            {
                s.Close();
                str = "select friend_password from friend where friend_nickname='" + Account_textBox.Text + "'";
                s = new Work.Forms.SQL.SqlConnection(str);
                s.Connection();
                s.da.Fill(s.ds, "friend");
                c = s.da.SelectCommand;
                SqlDataReader r = c.ExecuteReader();
                r.Read();
                String ps = r.GetString(0);
                if (ps == PassWord_textBox.Text)
                {
                    ManiForm B = this.A.A;
                    B.nickname = this.Account_textBox.Text;
                    this.Close();
                    A.Close();
                    B.Show();
                    r.Close();
                    s.Close();
                }
                else
                {
                    MessageBox.Show("密码输入错误", "需要再次输入", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    r.Close();
                    s.Close();
                }
            }
                
               
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
    }
