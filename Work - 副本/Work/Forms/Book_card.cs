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
    public partial class Book_card : Form
    {
        public string nickname;
        public Book_card(string nickname)
        {
            InitializeComponent();
            this.nickname = nickname;
            this.Nickname_label.Text = nickname;
            reset();
        }

        private void reset()
        {
            string str = "select * from Cbook where nickname='" + nickname + "'";
            Work.Forms.SQL.SqlConnection s = new Work.Forms.SQL.SqlConnection(str);
            s.Connection();
            SqlCommand com = new SqlCommand(str, s.conn);
            SqlDataReader r = com.ExecuteReader();
            int row = 1, col = 1;
            while (r.Read())
            {
                
                tableLayoutPanel1.Controls.Add(new P((string)r["path1"], nickname),col,row);
                if ((col + 1) % 6 == 0) { row = row + 2; col = 1; }
                else col++;
                
            }
            r.Close();
            s.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Book_card_Load(object sender, EventArgs e)
        {
            string str = "select book_name from book ";
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
            Search_textBox.AutoCompleteCustomSource = source;
            Search_textBox.MouseDown += Search_textBox_MouseDown;


        }

        private void Search_textBox_MouseDown(object sender, MouseEventArgs e)
        {
            Search_textBox.Text = "";
        }
    

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            search_book search = new search_book(this.nickname, Search_textBox.Text);
            search.StartPosition = FormStartPosition.CenterScreen;

            search.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Book_card b = new Book_card(nickname);
            b.StartPosition = FormStartPosition.CenterScreen;
            b.ShowDialog();
            this.Close();
        }
    }
}
