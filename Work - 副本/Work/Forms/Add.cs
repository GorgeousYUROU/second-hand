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
using System.IO;

namespace Work.Forms
{
    public partial class Add : Form
    {
        string uppath="";
        string nickname;
        public Add(string nickname)
        {
            InitializeComponent();
            this.Nickname_label.Text = nickname;
            this.nickname = nickname;
            toolTip1.SetToolTip(name, "必填项");
             toolTip2.SetToolTip(author, "必填项");
            toolTip3.SetToolTip(publish, "必填项");
            toolTip4.SetToolTip(number, "必填项,请在书中寻找");
            toolTip5.SetToolTip(price, "填写数字如34");
            toolTip6.SetToolTip(type, "限制字数在9个之内");
            toolTip7.SetToolTip(key, "限制字数在10个之内");
            toolTip8.SetToolTip(pictureBox1, "双击上传图片");
            pictureBox1.ImageLocation = "..\\..\\image\\TMPSNAPSHOT1494254406858.jpg";
            name.MouseDown += Name_MouseDown;
            author.MouseDown += Name_MouseDown;
            publish.MouseDown += Name_MouseDown;
            number.MouseDown += Name_MouseDown;
            price.MouseDown += Name_MouseDown;
            type.MouseDown += Name_MouseDown;
            key.MouseDown += Name_MouseDown;
            change.Click += Change_Click;
            share.Click += Change_Click;
            sale.Click += Change_Click;
            number.MouseLeave += Number_MouseLeave;
            string str = "select book_ID from book ";
            Work.Forms.SQL.SqlConnection s = new Forms.SQL.SqlConnection(str);
            s.Connection();
            SqlCommand com = new SqlCommand(str, s.conn);
            SqlDataReader r = com.ExecuteReader();
            string m = "";
            r.Read();
            m = r[0].ToString();
            while (r.Read())
            {
                m += "," + r[0].ToString();

            }
            r.Close();
            s.Close();
            string[] m1 = m.Split(',');
            var source = new AutoCompleteStringCollection();
            source.AddRange(m1);
            number.AutoCompleteCustomSource = source;

        }

        private void Number_MouseLeave(object sender, EventArgs e)
        {
            if(number.Text!="")
            {
                string str = null;
                Work.Forms.SQL.SqlConnection s = new Work.Forms.SQL.SqlConnection(str);
                s.Connection();
                str = "select * from book where book_ID='"+ number.Text+ "'";
                SqlCommand com = new SqlCommand(str, s.conn);
                SqlDataReader r = com.ExecuteReader();
                if (r.Read())
                {
                    
                    uppath =r["image_path"].ToString();
                    pictureBox1.ImageLocation = uppath;
                    name.Text = r["book_name"].ToString();
                    author.Text = r["book_author"].ToString();
                    publish.Text = r["book_publish"].ToString();
                    number.Text = r["book_ID"].ToString();
                    price.Text = r["book_price"].ToString();
                    type.Text = r["book_type"].ToString();
                    key.Text = r["book_key"].ToString();
                    description.Text = r["book_description"].ToString();
                    name.ReadOnly=true;
                    author.ReadOnly = true; 
                    publish.ReadOnly = true;
                    number.ReadOnly = true;
                    price.ReadOnly = true;
                    type.ReadOnly = true;
                    key.ReadOnly = true;
                    description.ReadOnly = true;
                }
                r.Close();
                s.Close();
            }
        }

        private void Name_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.Text =="必填项"||t.Text == "必填项,可先输入" ||
            t.Text =="填写数字如34"||t.Text =="限制字数在15个之内"||
            t.Text =="限制字数在15个之内")
            t.Text = "";
        }

        private void Change_Click(object sender, EventArgs e)
        {
            RadioButton r = sender as RadioButton;
            switch(r.Text)
            {
                case "交换":date.Text = "交换期限:";单位.Text = "/天";
                    date1.Text = "0"; date1.ReadOnly = false;break;
                case "转赠": date.Text = "出售价格:"; 单位.Text = "/元";
                    date1.Text = "0";date1.ReadOnly = true; break;
                case "售卖": date.Text = "出售价格:"; 单位.Text = "/元";
                    date1.Text = "0"; date1.ReadOnly = false; break;
            }
          
        }

        private void Add_Load(object sender, EventArgs e)
        {
            name.Text = "必填项";
            author.Text = "必填项";
            publish.Text = "必填项";
            number.Text = "必填项,可先输入";
            price.Text = "填写数字如34";
            type.Text = "限制字数在15个之内";
            key.Text = "限制字数在15个之内";
            change.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("检查", "请确认所有项符合要求", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if ((name.Text != "必填项") &&
                (author.Text != "必填项") &&
                (publish.Text != "必填项") &&
                (number.Text != "必填项,可先输入") &&
                (name.Text != "") &&
                (author.Text != "") &&
                (publish.Text != "") &&
                (number.Text != ""))
                {
                    string Name = name.Text;
                    string Author = author.Text;
                    string Publish = publish.Text;
                    string Id = number.Text;
                    int Price = 0;
                    string Type = null, Key = null, Description = null;
                    if ((price.Text != "填写数字如34") && (price.Text != ""))
                    { Price = Convert.ToInt16(price.Text); }
                    if ((type.Text != "限制字数在15个之内") && (type.Text != ""))
                    {
                        Type = type.Text;
                    }
                    if ((key.Text != "限制字数在15个之内") && (key.Text != ""))
                    {
                        Key = key.Text;
                    }
                    if ((description.Text != "限制字数在100个之内") && (description.Text != ""))
                    {
                        Description = description.Text;
                    }
                    string str = null;
                    Work.Forms.SQL.SqlConnection s = new Work.Forms.SQL.SqlConnection(str);
                    s.Connection();
                    str = "select * from book where book_publish='" + publish.Text + "' and book_ID='"
                     + number.Text + "' and book_author='" + author.Text + "'";
                    SqlCommand com = new SqlCommand(str, s.conn);
                    SqlDataReader r = com.ExecuteReader();
                    if (!r.Read())
                    {
                        r.Close();
                        uppath = uppath == "" ? "not" : uppath;
                        str = "insert into book values('" + Id + "','" + Name + "'," + Price + ",'" + Author + "','" + Type + "','" + Publish + "','" + Key + "','" + Description + "','" + uppath + "')";
                        com = new SqlCommand(str, s.conn);
                        com.ExecuteNonQuery();
                    }
                    else
                    {
                        if (uppath != "")
                        {
                            r.Close();
                            str = "update  book set image_path='" + uppath + "' where book_ID='" + Id + "'";
                            com = new SqlCommand(str, s.conn);
                            com.ExecuteNonQuery();
                        }
                        r.Close();
                    }
                    if (change.Checked == true)
                    {

                        int change_diff = 0;
                        if ((date1.Text != "必填") && (date1.Text != ""))
                        { change_diff = Convert.ToInt16(date1.Text); }
                        string str2 = "select friend_ID from friend where friend_nickname='"
                        + Nickname_label.Text + "'";
                        str = "select * from change where friend_ID=(" + str2 + ") and change_state='待交换'";
                        com = new SqlCommand(str, s.conn);
                        r = com.ExecuteReader();
                        if (!r.Read())
                        {
                            r.Close();
                            str = "select top 1 * from change order by change_ID DESC";
                            com = new SqlCommand(str, s.conn);
                            r = com.ExecuteReader();
                            r.Read();
                            string ID = (Convert.ToInt32(r["change_ID"]) + 1).ToString();
                            r.Close();
                            string str1 = "select friend_ID from friend where friend_nickname='"
                            + Nickname_label.Text + "'";
                            com = new SqlCommand(str1, s.conn);
                            r = com.ExecuteReader();
                            r.Read();
                            string friend_ID = Convert.ToString(r["friend_ID"]);
                            r.Close();
                            str = "insert into change values('" + ID + "','" + friend_ID + "','" + Id + "'," + change_diff + ",GetDate(),'待交换',NULL)";
                            com = new SqlCommand(str, s.conn);
                            com.ExecuteNonQuery();
                            change_card change = new change_card(nickname);
                            change.StartPosition = FormStartPosition.CenterScreen;

                            change.ShowDialog();
                            this.Close();
                        }
                        else { r.Close(); MessageBox.Show("每个用户只允许有一个待交换订单"); }
                    }
                    else
                    {
                        string sale_state = null;
                        int sale_price = 0;
                        if ((date1.Text != "必填") && (date1.Text != ""))
                        { sale_price = Convert.ToInt16(date1.Text); }
                        if (sale.Checked == true) { sale_state = "在卖"; }
                        if (share.Checked == true) { sale_state = "转赠"; }
                        str = "select top 1 * from sale order by sale_ID DESC";
                        com = new SqlCommand(str, s.conn);
                        r = com.ExecuteReader();
                        r.Read();
                        string ID = (Convert.ToInt32(r["sale_ID"]) + 1).ToString();
                        r.Close();
                        string str1 = "select friend_ID from friend where friend_nickname='"
                        + Nickname_label.Text + "'";
                        com = new SqlCommand(str1, s.conn);
                        r = com.ExecuteReader();
                        r.Read();
                        string friend_ID = Convert.ToString(r["friend_ID"]);
                        r.Close();
                        str = "insert into sale values('" + ID + "','" + Id + "','" + friend_ID + "'," + sale_price + ",GetDate(),'" + sale_state + "',NULL)";
                        com = new SqlCommand(str, s.conn);
                        com.ExecuteNonQuery();
                        change_card change = new change_card(nickname);
                        change.StartPosition = FormStartPosition.CenterScreen;

                        change.ShowDialog();
                        this.Close();
                    }
                    s.Close();
                }
            } 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            
            if(f.ShowDialog()==DialogResult.OK)
            {
                uppath = "";//用于保存图片上传路径
                            //获取上传图片的文件名
                f.Filter = "图片|*.bmp;*.jpg;*.jpeg;*.png;*.gif";
                string fileFullname =f.FileName;
                //获取图片上传的时间，以时间作为图片的名字可以防止图片重名
                string dataName = DateTime.Now.ToString("yyyyMMddhhmmss");
                //获取图片的文件名（不含扩展名）
                string fileName = fileFullname.Substring(fileFullname.LastIndexOf("\\") + 1);
                //获取图片扩展名
                string type = fileFullname.Substring(fileFullname.LastIndexOf(".") + 1);
                //判断是否为要求的格式
                
                    //将图片上传到指定路径的文件夹
                    uppath= "..\\..\\image\\"+dataName + "." + type;
                    //将路径保存到变量，将该变量的值保存到数据库相应字段即可
                    File.Copy(fileFullname, uppath, false);
                pictureBox1.ImageLocation = @uppath;
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
