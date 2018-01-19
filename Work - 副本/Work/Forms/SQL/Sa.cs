using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Work.Forms.SQL
{
    public partial class Sa : UserControl
    {
        string nickname;
        string uppath;
        string uppath1;
        string name;
        string name1;
        string nickname1;
        public Sa(string nickname,string nickname1,string name,string name1,string d,string d1,string date,
            string uppath,string uppath1)
        {
            InitializeComponent();
            this.nickname = nickname;
            this.nickname1 = nickname1;
            button1.Text = nickname1;
            book.Text = name;
            book1.Text = name1;
            this.name = name;
            this.name1 = name1;
            D.Text = d;
            D1.Text = d1;
            Date1.Text = date;
            this.uppath = uppath;
            this.uppath1 = uppath1;
            pictureBox2.ImageLocation = uppath;
            pictureBox3.ImageLocation = uppath1;
            pictureBox2.DoubleClick += PictureBox2_DoubleClick;
            pictureBox3.DoubleClick += PictureBox3_DoubleClick;
        }

        private void PictureBox3_DoubleClick(object sender, EventArgs e)
        {
            if (uppath1 != null)
            {
                string str = "select book_name from book where image_path='" + uppath1 + "'";
                Work.Forms.SQL.SqlConnection s = new Work.Forms.SQL.SqlConnection(str);
                s.Connection();
                SqlCommand com = new SqlCommand(str, s.conn);
                string name = com.ExecuteScalar().ToString();
                Author_label a = new Author_label(nickname, name);
                a.ShowDialog();

            }
        }

        private void PictureBox2_DoubleClick(object sender, EventArgs e)
        {
            if (uppath != null)
            {
                string str = "select book_name from book where image_path='" + uppath + "'";
                Work.Forms.SQL.SqlConnection s = new Work.Forms.SQL.SqlConnection(str);
                s.Connection();
                SqlCommand com = new SqlCommand(str, s.conn);
                string name = com.ExecuteScalar().ToString();
                Author_label a = new Author_label(nickname, name);
                a.ShowDialog();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nickname1 != null)
            {

                Person a = new Person(nickname1, nickname);
                a.ShowDialog();

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
