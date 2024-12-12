namespace AdoNet1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            gbx = new GroupBox();
            button1 = new Button();
            addBtn = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            labal4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            button2 = new Button();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            label7 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gbx.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(717, 206);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // gbx
            // 
            gbx.Controls.Add(button1);
            gbx.Controls.Add(addBtn);
            gbx.Controls.Add(textBox3);
            gbx.Controls.Add(textBox2);
            gbx.Controls.Add(textBox1);
            gbx.Controls.Add(labal4);
            gbx.Controls.Add(label3);
            gbx.Controls.Add(label2);
            gbx.Location = new Point(34, 258);
            gbx.Name = "gbx";
            gbx.Size = new Size(248, 164);
            gbx.TabIndex = 1;
            gbx.TabStop = false;
            gbx.Text = "Add Product";
            // 
            // button1
            // 
            button1.Location = new Point(6, 129);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Temizle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(136, 124);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 34);
            addBtn.TabIndex = 3;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(91, 91);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(91, 60);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // labal4
            // 
            labal4.AutoSize = true;
            labal4.Location = new Point(23, 98);
            labal4.Name = "labal4";
            labal4.Size = new Size(43, 20);
            labal4.TabIndex = 2;
            labal4.Text = "stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 67);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 1;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 35);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(288, 258);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(251, 164);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Update Product";
            // 
            // button2
            // 
            button2.Location = new Point(123, 122);
            button2.Name = "button2";
            button2.Size = new Size(108, 29);
            button2.TabIndex = 10;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(62, 89);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(62, 56);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(62, 21);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 92);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 6;
            label6.Text = "stok";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 56);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 5;
            label5.Text = "price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 24);
            label4.Name = "label4";
            label4.Size = new Size(22, 20);
            label4.TabIndex = 4;
            label4.Text = "İd";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(564, 259);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(194, 111);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Delete Product";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 43);
            label7.Name = "label7";
            label7.Size = new Size(22, 20);
            label7.TabIndex = 11;
            label7.Text = "İd";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(44, 40);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label8.ForeColor = SystemColors.HotTrack;
            label8.Location = new Point(627, 382);
            label8.Name = "label8";
            label8.Size = new Size(85, 41);
            label8.TabIndex = 5;
            label8.Text = "Help";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.Location = new Point(80, 76);
            button3.Name = "button3";
            button3.Size = new Size(108, 29);
            button3.TabIndex = 12;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(gbx);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gbx.ResumeLayout(false);
            gbx.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox gbx;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label labal4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button addBtn;
        private Button button1;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button button2;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private GroupBox groupBox2;
        private Button button3;
        private TextBox textBox7;
        private Label label7;
        private Label label8;
    }
}
