namespace Work.Forms
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Login_button = new System.Windows.Forms.Button();
            this.Close_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Account_textBox = new System.Windows.Forms.TextBox();
            this.PassWord_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(30, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 33);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(32, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 35);
            this.label2.TabIndex = 3;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.Color.DarkSalmon;
            this.Login_button.Font = new System.Drawing.Font("幼圆", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Login_button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Login_button.Location = new System.Drawing.Point(96, 407);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(162, 56);
            this.Login_button.TabIndex = 4;
            this.Login_button.Text = "登录";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // Close_button
            // 
            this.Close_button.Image = ((System.Drawing.Image)(resources.GetObject("Close_button.Image")));
            this.Close_button.Location = new System.Drawing.Point(338, 3);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(30, 30);
            this.Close_button.TabIndex = 5;
            this.Close_button.UseVisualStyleBackColor = true;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("宋体", 11F);
            this.button1.Location = new System.Drawing.Point(1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "< 返回";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Account_textBox
            // 
            this.Account_textBox.AcceptsTab = true;
            this.Account_textBox.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Account_textBox.Location = new System.Drawing.Point(81, 280);
            this.Account_textBox.Name = "Account_textBox";
            this.Account_textBox.Size = new System.Drawing.Size(251, 35);
            this.Account_textBox.TabIndex = 7;
            this.Account_textBox.Text = "请输入账号";
            this.Account_textBox.UseWaitCursor = true;
            this.Account_textBox.TextChanged += new System.EventHandler(this.Account_textBoc_TextChanged);
            // 
            // PassWord_textBox
            // 
            this.PassWord_textBox.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PassWord_textBox.Location = new System.Drawing.Point(81, 340);
            this.PassWord_textBox.Name = "PassWord_textBox";
            this.PassWord_textBox.Size = new System.Drawing.Size(251, 35);
            this.PassWord_textBox.TabIndex = 8;
            this.PassWord_textBox.Text = "请输入密码";
            this.PassWord_textBox.UseWaitCursor = true;
            this.PassWord_textBox.TextChanged += new System.EventHandler(this.PassWord_textBox_TextChanged);
            // 
            // Login
            // 
            this.AcceptButton = this.Login_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(370, 510);
            this.Controls.Add(this.PassWord_textBox);
            this.Controls.Add(this.Account_textBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Account_textBox;
        private System.Windows.Forms.TextBox PassWord_textBox;
    }
}