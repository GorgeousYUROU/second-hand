namespace Work.Forms
{
    partial class Person
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Person));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Nickname_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nickname_label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Description_textBox = new System.Windows.Forms.TextBox();
            this.phone_textBox = new System.Windows.Forms.TextBox();
            this.profession_textBox = new System.Windows.Forms.TextBox();
            this.grade_textBox = new System.Windows.Forms.TextBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.nickname_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(176)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Nickname_label);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 76);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Nickname_label
            // 
            this.Nickname_label.Font = new System.Drawing.Font("宋体", 16F);
            this.Nickname_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Nickname_label.Image = ((System.Drawing.Image)(resources.GetObject("Nickname_label.Image")));
            this.Nickname_label.Location = new System.Drawing.Point(825, 21);
            this.Nickname_label.Name = "Nickname_label";
            this.Nickname_label.Size = new System.Drawing.Size(122, 45);
            this.Nickname_label.TabIndex = 17;
            this.Nickname_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(176)))), ((int)(((byte)(75)))));
            this.label2.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(69, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 33);
            this.label2.TabIndex = 16;
            this.label2.Text = "夕拾市场";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nickname_label1);
            this.groupBox1.Font = new System.Drawing.Font("等线", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(3, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 463);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "个人信息设置";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(68, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 31);
            this.label8.TabIndex = 5;
            this.label8.Text = "个人描述";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(54, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 31);
            this.label7.TabIndex = 4;
            this.label7.Text = "手机号";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(36, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 31);
            this.label6.TabIndex = 3;
            this.label6.Text = "专业";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(36, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 31);
            this.label5.TabIndex = 2;
            this.label5.Text = "年级";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(36, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "姓名";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nickname_label1
            // 
            this.nickname_label1.Location = new System.Drawing.Point(83, 47);
            this.nickname_label1.Name = "nickname_label1";
            this.nickname_label1.Size = new System.Drawing.Size(126, 31);
            this.nickname_label1.TabIndex = 0;
            this.nickname_label1.Text = "昵称(不可修改)";
            this.nickname_label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Description_textBox);
            this.groupBox2.Controls.Add(this.phone_textBox);
            this.groupBox2.Controls.Add(this.profession_textBox);
            this.groupBox2.Controls.Add(this.grade_textBox);
            this.groupBox2.Controls.Add(this.name_textBox);
            this.groupBox2.Controls.Add(this.nickname_textBox);
            this.groupBox2.Font = new System.Drawing.Font("等线", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(218, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(793, 463);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // Description_textBox
            // 
            this.Description_textBox.Location = new System.Drawing.Point(28, 262);
            this.Description_textBox.Multiline = true;
            this.Description_textBox.Name = "Description_textBox";
            this.Description_textBox.Size = new System.Drawing.Size(385, 170);
            this.Description_textBox.TabIndex = 5;
            this.Description_textBox.Text = "50字以内";
            // 
            // phone_textBox
            // 
            this.phone_textBox.Location = new System.Drawing.Point(28, 219);
            this.phone_textBox.Name = "phone_textBox";
            this.phone_textBox.Size = new System.Drawing.Size(385, 25);
            this.phone_textBox.TabIndex = 4;
            this.phone_textBox.WordWrap = false;
            // 
            // profession_textBox
            // 
            this.profession_textBox.Location = new System.Drawing.Point(28, 179);
            this.profession_textBox.Name = "profession_textBox";
            this.profession_textBox.Size = new System.Drawing.Size(385, 25);
            this.profession_textBox.TabIndex = 3;
            this.profession_textBox.WordWrap = false;
            // 
            // grade_textBox
            // 
            this.grade_textBox.AcceptsTab = true;
            this.grade_textBox.Location = new System.Drawing.Point(28, 134);
            this.grade_textBox.Name = "grade_textBox";
            this.grade_textBox.Size = new System.Drawing.Size(385, 25);
            this.grade_textBox.TabIndex = 2;
            this.grade_textBox.Text = "只输入年份即可，如15";
            this.grade_textBox.WordWrap = false;
            // 
            // name_textBox
            // 
            this.name_textBox.AcceptsTab = true;
            this.name_textBox.Location = new System.Drawing.Point(28, 93);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(385, 25);
            this.name_textBox.TabIndex = 1;
            this.name_textBox.WordWrap = false;
            // 
            // nickname_textBox
            // 
            this.nickname_textBox.AcceptsTab = true;
            this.nickname_textBox.Location = new System.Drawing.Point(28, 50);
            this.nickname_textBox.Name = "nickname_textBox";
            this.nickname_textBox.ReadOnly = true;
            this.nickname_textBox.Size = new System.Drawing.Size(385, 25);
            this.nickname_textBox.TabIndex = 0;
            this.nickname_textBox.WordWrap = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("等线", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(501, 561);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 38);
            this.button1.TabIndex = 18;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("等线", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(259, 561);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 38);
            this.button2.TabIndex = 19;
            this.button2.Text = "修改";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 51);
            this.label1.TabIndex = 27;
            // 
            // Person
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 611);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Person";
            this.Text = "Person";
            this.Load += new System.EventHandler(this.Person_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Nickname_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nickname_label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Description_textBox;
        private System.Windows.Forms.TextBox phone_textBox;
        private System.Windows.Forms.TextBox profession_textBox;
        private System.Windows.Forms.TextBox grade_textBox;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox nickname_textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}