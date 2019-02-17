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
    public partial class P : UserControl
    {
        string uppath, nickname;
        public P(string uppath,string nickname)
        {
            InitializeComponent();
            this.uppath = uppath;
            this.nickname = nickname;
            this.pictureBox2.DoubleClick += PictureBox1_DoubleClick;
            this.pictureBox2.ImageLocation = uppath;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_DoubleClick(object sender, EventArgs e)
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
    }
}
