using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Drawing;

namespace QuanLyCaPhe
{
    partial class frLogin
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            btn_login = new Button();
            pictureBox1 = new PictureBox();
            btn_thoat = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 192);
            label1.Location = new Point(168, 26);
            label1.Name = "label1";
            label1.Size = new Size(132, 23);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(141, 62);
            label2.Name = "label2";
            label2.Size = new Size(194, 23);
            label2.TabIndex = 1;
            label2.Text = "QUẢN LÝ NHÂN SỰ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(155, 132);
            label3.Name = "label3";
            label3.Size = new Size(87, 19);
            label3.TabIndex = 2;
            label3.Text = "Tài khoản:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(155, 175);
            label4.Name = "label4";
            label4.Size = new Size(84, 19);
            label4.TabIndex = 3;
            label4.Text = "Mật khẩu:";
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_username.Location = new Point(248, 128);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(154, 27);
            txt_username.TabIndex = 0;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_password.Location = new Point(248, 171);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(154, 27);
            txt_password.TabIndex = 1;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.Turquoise;
            btn_login.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.ForeColor = Color.FromArgb(64, 0, 64);
            btn_login.Location = new Point(171, 218);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(96, 53);
            btn_login.TabIndex = 2;
            btn_login.Text = "Đăng nhập";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.login;
            pictureBox1.Location = new Point(12, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 129);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btn_thoat
            // 
            btn_thoat.BackColor = Color.Turquoise;
            btn_thoat.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_thoat.ForeColor = Color.FromArgb(64, 0, 64);
            btn_thoat.Location = new Point(273, 218);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(97, 53);
            btn_thoat.TabIndex = 3;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = false;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // frLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(438, 339);
            Controls.Add(btn_thoat);
            Controls.Add(pictureBox1);
            Controls.Add(btn_login);
            Controls.Add(txt_password);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_username);
            ForeColor = Color.FromArgb(255, 128, 0);
            Name = "frLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_username;
        private TextBox txt_password;
        private Button btn_login;
        private Button btn_thoat;
        private PictureBox pictureBox1;

    }
}