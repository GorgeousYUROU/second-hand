namespace Work.Forms
{
    partial class search_book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(search_book));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Nickname_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Book_key = new System.Windows.Forms.RadioButton();
            this.Book_type = new System.Windows.Forms.RadioButton();
            this.Book_publish = new System.Windows.Forms.RadioButton();
            this.Book_author = new System.Windows.Forms.RadioButton();
            this.Book_name = new System.Windows.Forms.RadioButton();
            this.Search_textBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.双击得到更多 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Controls.Add(this.Nickname_label);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 76);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 51);
            this.label1.TabIndex = 18;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Book_key);
            this.groupBox1.Controls.Add(this.Book_type);
            this.groupBox1.Controls.Add(this.Book_publish);
            this.groupBox1.Controls.Add(this.Book_author);
            this.groupBox1.Controls.Add(this.Book_name);
            this.groupBox1.Controls.Add(this.Search_textBox);
            this.groupBox1.Font = new System.Drawing.Font("等线 Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(1, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1022, 135);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "买赠";
            // 
            // Book_key
            // 
            this.Book_key.AutoSize = true;
            this.Book_key.Location = new System.Drawing.Point(779, 80);
            this.Book_key.Name = "Book_key";
            this.Book_key.Size = new System.Drawing.Size(68, 25);
            this.Book_key.TabIndex = 25;
            this.Book_key.Text = "标签";
            this.Book_key.UseVisualStyleBackColor = true;
            // 
            // Book_type
            // 
            this.Book_type.AutoSize = true;
            this.Book_type.Location = new System.Drawing.Point(601, 80);
            this.Book_type.Name = "Book_type";
            this.Book_type.Size = new System.Drawing.Size(68, 25);
            this.Book_type.TabIndex = 24;
            this.Book_type.Text = "分类";
            this.Book_type.UseVisualStyleBackColor = true;
            // 
            // Book_publish
            // 
            this.Book_publish.AutoSize = true;
            this.Book_publish.Location = new System.Drawing.Point(401, 80);
            this.Book_publish.Name = "Book_publish";
            this.Book_publish.Size = new System.Drawing.Size(88, 25);
            this.Book_publish.TabIndex = 23;
            this.Book_publish.Text = "出版社";
            this.Book_publish.UseVisualStyleBackColor = true;
            // 
            // Book_author
            // 
            this.Book_author.AutoSize = true;
            this.Book_author.Location = new System.Drawing.Point(244, 80);
            this.Book_author.Name = "Book_author";
            this.Book_author.Size = new System.Drawing.Size(68, 25);
            this.Book_author.TabIndex = 22;
            this.Book_author.Text = "作者";
            this.Book_author.UseVisualStyleBackColor = true;
            // 
            // Book_name
            // 
            this.Book_name.AutoSize = true;
            this.Book_name.Location = new System.Drawing.Point(80, 80);
            this.Book_name.Name = "Book_name";
            this.Book_name.Size = new System.Drawing.Size(68, 25);
            this.Book_name.TabIndex = 21;
            this.Book_name.Text = "书名";
            this.Book_name.UseVisualStyleBackColor = true;
            this.Book_name.CheckedChanged += new System.EventHandler(this.Book_name_CheckedChanged);
            // 
            // Search_textBox
            // 
            this.Search_textBox.AccessibleDescription = "搜索书籍";
            this.Search_textBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Search_textBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Search_textBox.BackColor = System.Drawing.Color.Moccasin;
            this.Search_textBox.Font = new System.Drawing.Font("宋体", 14F);
            this.Search_textBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Search_textBox.Location = new System.Drawing.Point(371, 27);
            this.Search_textBox.Name = "Search_textBox";
            this.Search_textBox.Size = new System.Drawing.Size(300, 29);
            this.Search_textBox.TabIndex = 20;
            this.Search_textBox.Text = "搜索书籍";
            this.Search_textBox.WordWrap = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1010, 315);
            this.dataGridView1.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.双击得到更多);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("等线", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(1, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1022, 375);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "搜索结果";
            // 
            // 双击得到更多
            // 
            this.双击得到更多.AutoSize = true;
            this.双击得到更多.Font = new System.Drawing.Font("等线", 13F);
            this.双击得到更多.Location = new System.Drawing.Point(92, 30);
            this.双击得到更多.Name = "双击得到更多";
            this.双击得到更多.Size = new System.Drawing.Size(171, 19);
            this.双击得到更多.TabIndex = 13;
            this.双击得到更多.Text = "双击得到更多。。。";
            // 
            // search_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "search_book";
            this.Text = "search_book";
            this.Load += new System.EventHandler(this.search_book_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Nickname_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Book_key;
        private System.Windows.Forms.RadioButton Book_type;
        private System.Windows.Forms.RadioButton Book_publish;
        private System.Windows.Forms.RadioButton Book_author;
        private System.Windows.Forms.RadioButton Book_name;
        private System.Windows.Forms.TextBox Search_textBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label 双击得到更多;
        private System.Windows.Forms.Label label1;
    }
}