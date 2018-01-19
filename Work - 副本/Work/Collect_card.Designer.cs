namespace Work
{
    partial class Collect_card
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Collect_card));
            this.Nickname_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buy = new System.Windows.Forms.RadioButton();
            this.share = new System.Windows.Forms.RadioButton();
            this.change = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(176)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Nickname_label);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 76);
            this.panel1.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(235, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 35);
            this.button2.TabIndex = 25;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("方正舒体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(443, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 43);
            this.label3.TabIndex = 18;
            this.label3.Text = "我的收藏";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("等线", 15F);
            this.groupBox1.Location = new System.Drawing.Point(338, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 28);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "我收藏的交换订单";
            // 
            // buy
            // 
            this.buy.AutoSize = true;
            this.buy.Location = new System.Drawing.Point(81, 172);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(128, 25);
            this.buy.TabIndex = 4;
            this.buy.TabStop = true;
            this.buy.Text = "收藏的售卖";
            this.buy.UseVisualStyleBackColor = true;
            // 
            // share
            // 
            this.share.AutoSize = true;
            this.share.Location = new System.Drawing.Point(81, 108);
            this.share.Name = "share";
            this.share.Size = new System.Drawing.Size(128, 25);
            this.share.TabIndex = 3;
            this.share.TabStop = true;
            this.share.Text = "收藏的转赠";
            this.share.UseVisualStyleBackColor = true;
            // 
            // change
            // 
            this.change.AutoSize = true;
            this.change.Location = new System.Drawing.Point(81, 40);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(128, 25);
            this.change.TabIndex = 0;
            this.change.TabStop = true;
            this.change.Text = "收藏的交换";
            this.change.UseVisualStyleBackColor = true;
            this.change.CheckedChanged += new System.EventHandler(this.change_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buy);
            this.groupBox2.Controls.Add(this.share);
            this.groupBox2.Controls.Add(this.change);
            this.groupBox2.Font = new System.Drawing.Font("等线", 15F);
            this.groupBox2.Location = new System.Drawing.Point(0, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 516);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "我的收藏";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.CausesValidation = false;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Font = new System.Drawing.Font("宋体", 9F);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(338, 146);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 452F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(585, 452);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 51);
            this.label1.TabIndex = 26;
            // 
            // Collect_card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 611);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("等线", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Collect_card";
            this.Text = "Collect_card";
            this.Load += new System.EventHandler(this.Collect_card_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Nickname_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton buy;
        private System.Windows.Forms.RadioButton share;
        private System.Windows.Forms.RadioButton change;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}