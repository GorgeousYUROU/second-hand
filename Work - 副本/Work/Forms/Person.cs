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
    public partial class Person : Form
    {
        public string nickname;
        public Person(string nickname)
        {
            InitializeComponent();
            this.nickname = nickname;
            this.Nickname_label.Text = nickname;
            this.nickname_textBox.Text = nickname;
            reset();
            name_textBox.ReadOnly = true;
            grade_textBox.ReadOnly = true;
            grade_textBox.ReadOnly = true;
            profession_textBox.ReadOnly = true;
            phone_textBox.ReadOnly = true;
            Description_textBox.ReadOnly = true;
        }
        public Person(string nickname,int flag)
        {
            InitializeComponent();
            this.nickname = nickname;
            this.Nickname_label.Text = nickname;
            this.nickname_textBox.Text = nickname;
            
            name_textBox.ReadOnly = false;
            grade_textBox.ReadOnly = false;
            grade_textBox.ReadOnly = false;
            profession_textBox.ReadOnly = false;
            phone_textBox.ReadOnly = false;
            Description_textBox.ReadOnly = false;
            phone_textBox.Text = "必填项";
            phone_textBox.MouseDown += Phone_textBox_MouseDown;
            phone_textBox.MouseHover += Phone_textBox_MouseHover;
        }

        private void Phone_textBox_MouseHover(object sender, EventArgs e)
        {
            if(phone_textBox.Text == "")
                phone_textBox.Text = "必填项";
        }

        private void Phone_textBox_MouseDown(object sender, MouseEventArgs e)
        {
            phone_textBox.Text = "";
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
            else grade_textBox.Text = "只输入年份即可，如15";
            if (!r.IsDBNull(4))
            profession_textBox.Text = (string)r["friend_speciality"];
            if (!r.IsDBNull(8))
                phone_textBox.Text = (string)r["friend_phone"];
            if (!r.IsDBNull(7))
                Description_textBox.Text = (string)r["friend_descreption"];
            else Description_textBox.Text = "50以内";
            r.Close();
            s.Close();
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str = "update friend set friend_name='" + name_textBox.Text + "'where friend_nickname='" + nickname + "'";
            Work.Forms.SQL.SqlConnection s = new SQL.SqlConnection(str);
            s.Connection();
            SqlCommand c;
            if (name_textBox.Text !="")
            {  
                 c= new SqlCommand(str,s.conn);
                c.ExecuteNonQuery();
                 
            }
            if (grade_textBox.Text != "只输入年份即可，如15")
            {
                str = "update friend set friend_grade='" + grade_textBox.Text + "'where friend_nickname='" + nickname + "'";
                c = new SqlCommand(str, s.conn);
                c.ExecuteNonQuery();
            }
            if (profession_textBox.Text !="")
            {
                str = "update friend set friend_speciality='" + profession_textBox.Text + "'where friend_nickname='" + nickname + "'";
                c = new SqlCommand(str, s.conn);
                c.ExecuteNonQuery();
            }
            if ((phone_textBox.Text != "必填项") &&(phone_textBox.Text != ""))
            {
                str = "update friend set friend_phone='" + phone_textBox.Text + "'where friend_nickname='" + nickname + "'";
                c = new SqlCommand(str, s.conn);
                c.ExecuteNonQuery();
            }
            if (Description_textBox.Text !="50字以内")
            {
                str = "update friend set friend_descreption='" + Description_textBox.Text + "'where friend_nickname='" + nickname + "'";
                c = new SqlCommand(str, s.conn);
                c.ExecuteNonQuery();
            }
            s.Close();
            if (phone_textBox.Text == "必填项" || phone_textBox.Text == "")
            { MessageBox.Show("请填入手机号"); phone_textBox.ReadOnly = false; }
            else { MessageBox.Show("保存成功"); phone_textBox.ReadOnly = true; }
                name_textBox.ReadOnly = true;
            grade_textBox.ReadOnly = true;
            grade_textBox.ReadOnly = true;
            profession_textBox.ReadOnly = true;
            
            Description_textBox.ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            name_textBox.ReadOnly = false;
            grade_textBox.ReadOnly = false;
            grade_textBox.ReadOnly = false;
            profession_textBox.ReadOnly = false;
            phone_textBox.ReadOnly = false;
            Description_textBox.ReadOnly = false;

        }

        private void Person_Load(object sender, EventArgs e)
        {

        }
    }
}
