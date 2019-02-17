namespace Work.Forms
{
    partial class MainLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLogin));
            this.Close_button = new System.Windows.Forms.Button();
            this.Login_button = new System.Windows.Forms.Button();
            this.Register_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Close_button
            // 
            this.Close_button.Image = ((System.Drawing.Image)(resources.GetObject("Close_button.Image")));
            this.Close_button.Location = new System.Drawing.Point(341, 2);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(30, 30);
            this.Close_button.TabIndex = 0;
            this.Close_button.UseVisualStyleBackColor = true;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click_1);
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.Color.Transparent;
            this.Login_button.Font = new System.Drawing.Font("幼圆", 17F, System.Drawing.FontStyle.Bold);
            this.Login_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Login_button.Image = ((System.Drawing.Image)(resources.GetObject("Login_button.Image")));
            this.Login_button.Location = new System.Drawing.Point(88, 310);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(197, 60);
            this.Login_button.TabIndex = 1;
            this.Login_button.Text = "登录";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // Register_button
            // 
            this.Register_button.Font = new System.Drawing.Font("幼圆", 17F, System.Drawing.FontStyle.Bold);
            this.Register_button.Image = ((System.Drawing.Image)(resources.GetObject("Register_button.Image")));
            this.Register_button.Location = new System.Drawing.Point(88, 404);
            this.Register_button.Name = "Register_button";
            this.Register_button.Size = new System.Drawing.Size(197, 63);
            this.Register_button.TabIndex = 2;
            this.Register_button.Text = "注册";
            this.Register_button.UseVisualStyleBackColor = true;
            this.Register_button.Click += new System.EventHandler(this.Register_button_Click);
            // 
            // MainLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(370, 510);
            this.Controls.Add(this.Register_button);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.Close_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Button Register_button;
    }
}