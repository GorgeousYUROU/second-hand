using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work.Forms
{
    public partial class MainLogin : Form
    {
        public ManiForm A = null;
        public MainLogin(ManiForm A)
        {
            InitializeComponent();

            Close_button.Click += Close_button_Click;
            this.A = A;

        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

       

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            Login login = new Forms.Login(this);
            login.Owner = this;
            login.StartPosition = FormStartPosition.CenterScreen;
            login.Show(this);
           
        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            Register register = new Forms.Register(this);
            register.Owner = this;
            register.StartPosition = FormStartPosition.CenterScreen;
            register.Show(this);
            
        }

        private void Close_button_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
