﻿namespace ProjectFinalOOP
{
    partial class sweet
    {
        private const string V = "sweet";

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sweet));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Code = new DataGridViewTextBoxColumn();
            button1 = new Button();
            textBoxprice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            textBoxcode = new TextBox();
            label4 = new Label();
            comboBox2 = new ComboBox();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(128, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(128, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Name, Amount, Price, Code });
            dataGridView1.Location = new Point(405, 55);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(496, 344);
            dataGridView1.TabIndex = 1;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.Width = 125;
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.Width = 125;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 125;
            // 
            // Code
            // 
            Code.HeaderText = "Code";
            Code.MinimumWidth = 6;
            Code.Name = "Code";
            Code.Width = 125;
            // 
            // button1
            // 
            button1.ForeColor = Color.Red;
            button1.Location = new Point(214, 404);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 2;
            button1.Text = "ตกลง";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxprice
            // 
            textBoxprice.ForeColor = SystemColors.InactiveCaptionText;
            textBoxprice.Location = new Point(200, 273);
            textBoxprice.Margin = new Padding(3, 4, 3, 4);
            textBoxprice.Name = "textBoxprice";
            textBoxprice.ReadOnly = true;
            textBoxprice.Size = new Size(114, 27);
            textBoxprice.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Pink;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(65, 115);
            label1.Name = "label1";
            label1.Size = new Size(86, 30);
            label1.TabIndex = 6;
            label1.Text = "ชื่อสินค้า";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.NavajoWhite;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(65, 192);
            label2.Name = "label2";
            label2.Size = new Size(70, 30);
            label2.TabIndex = 7;
            label2.Text = "จำนวน";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MediumAquamarine;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(65, 273);
            label3.Name = "label3";
            label3.Size = new Size(55, 30);
            label3.TabIndex = 8;
            label3.Text = "ราคา";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.OldLace;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "เค้กส้ม", "ครัวซ็องเนยสด", "เค้กช็อกโกแลต", "บานอฟฟี่พาย", "พายข้าวโพด" });
            comboBox1.Location = new Point(200, 115);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(114, 28);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBoxcode
            // 
            textBoxcode.BackColor = SystemColors.HighlightText;
            textBoxcode.Location = new Point(200, 347);
            textBoxcode.Margin = new Padding(3, 4, 3, 4);
            textBoxcode.Name = "textBoxcode";
            textBoxcode.Size = new Size(114, 27);
            textBoxcode.TabIndex = 10;
            textBoxcode.TextChanged += textBoxcode_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Yellow;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(43, 343);
            label4.Name = "label4";
            label4.Size = new Size(108, 30);
            label4.TabIndex = 11;
            label4.Text = "โค้ดส่วนลด";
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.OldLace;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            comboBox2.Location = new Point(200, 192);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(114, 28);
            comboBox2.TabIndex = 12;
            // 
            // button2
            // 
            button2.ForeColor = Color.Red;
            button2.Location = new Point(815, 407);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 24;
            button2.Text = "ย้อนกลับ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(65, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // sweet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(textBoxcode);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxprice);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            //Name = "sweet";
            Text = "sweet";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox textBoxprice;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private TextBox textBoxcode;
        private Label label4;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Code;
        private ComboBox comboBox2;
        private Button button2;
        private PictureBox pictureBox1;
    }
}