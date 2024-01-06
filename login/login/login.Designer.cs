namespace login
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            txt_username = new TextBox();
            txt_pass = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            label2 = new Label();
            btn_giris = new Button();
            show_pass = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkViolet;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-54, -12);
            panel1.Name = "panel1";
            panel1.Size = new Size(599, 765);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(599, 765);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txt_username
            // 
            txt_username.BackColor = Color.WhiteSmoke;
            txt_username.BorderStyle = BorderStyle.None;
            txt_username.Location = new Point(668, 277);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(345, 24);
            txt_username.TabIndex = 1;
            // 
            // txt_pass
            // 
            txt_pass.BackColor = Color.WhiteSmoke;
            txt_pass.BorderStyle = BorderStyle.None;
            txt_pass.Location = new Point(12, 9);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(345, 24);
            txt_pass.TabIndex = 2;
            txt_pass.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(604, 269);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(604, 357);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Location = new Point(656, 268);
            panel2.Name = "panel2";
            panel2.Size = new Size(361, 42);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(txt_pass);
            panel3.Location = new Point(656, 357);
            panel3.Name = "panel3";
            panel3.Size = new Size(361, 42);
            panel3.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Text", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(672, 135);
            label1.Name = "label1";
            label1.Size = new Size(289, 53);
            label1.TabIndex = 7;
            label1.Text = "HOŞGELDİN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Pro Text", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(711, 203);
            label2.Name = "label2";
            label2.Size = new Size(210, 16);
            label2.TabIndex = 8;
            label2.Text = "Devam etmek için lütfen giriş yap";
            // 
            // btn_giris
            // 
            btn_giris.Cursor = Cursors.Hand;
            btn_giris.Location = new Point(871, 433);
            btn_giris.Name = "btn_giris";
            btn_giris.Size = new Size(119, 40);
            btn_giris.TabIndex = 9;
            btn_giris.Text = "Giriş Yap";
            btn_giris.UseVisualStyleBackColor = true;
            btn_giris.Click += btn_giris_Click;
            // 
            // show_pass
            // 
            show_pass.AutoSize = true;
            show_pass.Font = new Font("SF Pro Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            show_pass.Location = new Point(668, 440);
            show_pass.Name = "show_pass";
            show_pass.Size = new Size(161, 28);
            show_pass.TabIndex = 10;
            show_pass.Text = "Şifreyi Göster";
            show_pass.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1085, 660);
            Controls.Add(show_pass);
            Controls.Add(btn_giris);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(txt_username);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Font = new Font("SF Pro Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Ekranı";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox txt_username;
        private TextBox txt_pass;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private Button btn_giris;
        private CheckBox show_pass;
    }
}