﻿namespace GiaoDien_qlpks
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
            nhapMatkhau = new Label();
            nhapten = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Dangnhap = new Button();
            Dong = new Button();
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
            // nhapMatkhau
            // 
            nhapMatkhau.AutoSize = true;
            nhapMatkhau.BackColor = SystemColors.ActiveCaption;
            nhapMatkhau.Font = new Font("Segoe UI", 15F, FontStyle.Italic, GraphicsUnit.Point);
            nhapMatkhau.Location = new Point(134, 268);
            nhapMatkhau.Name = "nhapMatkhau";
            nhapMatkhau.Size = new Size(96, 28);
            nhapMatkhau.TabIndex = 2;
            nhapMatkhau.Text = "Mật Khẩu";
            nhapMatkhau.Click += label2_Click;
            // 
            // nhapten
            // 
            nhapten.AutoSize = true;
            nhapten.BackColor = SystemColors.ActiveCaption;
            nhapten.Font = new Font("Segoe UI", 15F, FontStyle.Italic, GraphicsUnit.Point);
            nhapten.Location = new Point(134, 174);
            nhapten.Name = "nhapten";
            nhapten.Size = new Size(151, 28);
            nhapten.TabIndex = 2;
            nhapten.Text = "Tên Đăng Nhập";
            nhapten.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(319, 174);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(319, 268);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(260, 23);
            textBox2.TabIndex = 4;
            // 
            // Dangnhap
            // 
            Dangnhap.Location = new Point(286, 344);
            Dangnhap.Name = "Dangnhap";
            Dangnhap.Size = new Size(113, 46);
            Dangnhap.TabIndex = 5;
            Dangnhap.Text = "Đăng nhập";
            Dangnhap.UseVisualStyleBackColor = true;
            Dangnhap.Click += button2_Click;
            // 
            // Dong
            // 
            Dong.Location = new Point(487, 344);
            Dong.Name = "Dong";
            Dong.Size = new Size(103, 46);
            Dong.TabIndex = 6;
            Dong.Text = "Đóng";
            Dong.UseVisualStyleBackColor = true;
            Dong.Click += button3_Click;
            // 
            // FormDangnhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Dong);
            Controls.Add(Dangnhap);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(nhapten);
            Controls.Add(nhapMatkhau);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "FormDangnhap";
            Text = "Quản Lý Phòng Khách Sạn";
            Load += FormDangnhap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label nhapMatkhau;
        private Label nhapten;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button Dangnhap;
        private Button Dong;
    }
}