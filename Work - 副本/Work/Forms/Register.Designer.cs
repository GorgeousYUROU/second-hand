namespace Work.Forms
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.Close_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Register_button = new System.Windows.Forms.Button();
            this.PassWord_textBox = new System.Windows.Forms.TextBox();
            this.Account_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Close_button
            // 
            this.Close_button.Image = ((System.Drawing.Image)(resources.GetObject("Close_button.Image")));
            this.Close_button.Location = new System.Drawing.Point(341, 1);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(30, 30);
            this.Close_button.TabIndex = 6;
            this.Close_button.UseVisualStyleBackColor = true;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("宋体", 11F);
            this.button1.Location = new System.Drawing.Point(0, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "< 返回";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Register_button
            // 
            this.Register_button.BackColor = System.Drawing.Color.DarkSalmon;
            this.Register_button.Font = new System.Drawing.Font("幼圆", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Register_button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Register_button.Location = new System.Drawing.Point(97, 389);
            this.Register_button.Name = "Register_button";
            this.Register_button.Size = new System.Drawing.Size(167, 59);
            this.Register_button.TabIndex = 13;
            this.Register_button.Text = "注册";
            this.Register_button.UseVisualStyleBackColor = false;
            this.Register_button.Click += new System.EventHandler(this.Register_button_Click);
            // 
            // PassWord_textBox
            // 
            this.PassWord_textBox.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PassWord_textBox.Location = new System.Drawing.Point(83, 329);
            this.PassWord_textBox.Name = "PassWord_textBox";
            this.PassWord_textBox.Size = new System.Drawing.Size(251, 35);
            this.PassWord_textBox.TabIndex = 17;
            this.PassWord_textBox.Text = "请输入密码";
            this.PassWord_textBox.UseWaitCursor = true;
            this.PassWord_textBox.TextChanged += new System.EventHandler(this.PassWord_textBox_TextChanged);
            // 
            // Account_textBox
            // 
            this.Account_textBox.AcceptsTab = true;
            this.Account_textBox.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Account_textBox.Location = new System.Drawing.Point(83, 273);
            this.Account_textBox.Name = "Account_textBox";
            this.Account_textBox.Size = new System.Drawing.Size(251, 35);
            this.Account_textBox.TabIndex = 16;
            this.Account_textBox.Text = "请输入注册昵称";
            this.Account_textBox.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(34, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 35);
            this.label2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(32, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 33);
            this.label1.TabIndex = 14;
            // 
            // Register
            // 
            this.AcceptButton = this.Register_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(370, 510);
            this.Controls.Add(this.PassWord_textBox);
            this.Controls.Add(this.Account_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Register_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Close_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Register_button;
        private System.Windows.Forms.TextBox PassWord_textBox;
        private System.Windows.Forms.TextBox Account_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}