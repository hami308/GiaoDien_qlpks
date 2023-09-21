namespace GiaoDien_qlpks
{
    partial class FormDangnhap
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(796, 367);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 35F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.InfoText;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 117);
            label1.TabIndex = 1;
            label1.Text = "ĐĂNG NHẬP";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(134, 268);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 2;
            label2.Text = "Mật Khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(134, 174);
            label3.Name = "label3";
            label3.Size = new Size(151, 28);
            label3.TabIndex = 2;
            label3.Text = "Tên Đăng Nhập";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(319, 174);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(319, 268);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(260, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(286, 344);
            button2.Name = "button2";
            button2.Size = new Size(113, 46);
            button2.TabIndex = 5;
            button2.Text = "Đăng nhập";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(487, 344);
            button3.Name = "button3";
            button3.Size = new Size(103, 46);
            button3.TabIndex = 6;
            button3.Text = "Đóng";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // FormDangnhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "FormDangnhap";
            Text = "Quản Lý Phòng Khách Sạn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
    }
}