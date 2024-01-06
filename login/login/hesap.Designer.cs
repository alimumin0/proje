namespace muhasebe
{
    partial class hesap
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            btn_bonus = new Button();
            txt_bonus = new TextBox();
            check_bonus = new CheckBox();
            btn_prim = new Button();
            txt_prim = new TextBox();
            check_prim = new CheckBox();
            btn_gncl = new Button();
            txt_maas = new TextBox();
            lbl_tel = new Label();
            lbl_yas = new Label();
            lbl_adsoyad = new Label();
            btn_bilgi = new Button();
            comboBox1 = new ComboBox();
            groupBox2 = new GroupBox();
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            btn_yıllık = new Button();
            btn_liste = new Button();
            btn_aylık = new Button();
            btn_karhesap = new Button();
            txt_gider = new TextBox();
            txt_gelir = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btn_bonus);
            groupBox1.Controls.Add(txt_bonus);
            groupBox1.Controls.Add(check_bonus);
            groupBox1.Controls.Add(btn_prim);
            groupBox1.Controls.Add(txt_prim);
            groupBox1.Controls.Add(check_prim);
            groupBox1.Controls.Add(btn_gncl);
            groupBox1.Controls.Add(txt_maas);
            groupBox1.Controls.Add(lbl_tel);
            groupBox1.Controls.Add(lbl_yas);
            groupBox1.Controls.Add(lbl_adsoyad);
            groupBox1.Controls.Add(btn_bilgi);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(445, 669);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Çalışan Görüntüleme";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("SF UI  Text", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(324, 40);
            button1.Name = "button1";
            button1.Size = new Size(113, 32);
            button1.TabIndex = 13;
            button1.Text = "Calisan Getir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_bonus
            // 
            btn_bonus.Cursor = Cursors.Hand;
            btn_bonus.Location = new Point(270, 542);
            btn_bonus.Name = "btn_bonus";
            btn_bonus.Size = new Size(141, 33);
            btn_bonus.TabIndex = 12;
            btn_bonus.Text = "Bonusu Ver";
            btn_bonus.UseVisualStyleBackColor = true;
            btn_bonus.Visible = false;
            // 
            // txt_bonus
            // 
            txt_bonus.Font = new Font("SF UI  Text", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_bonus.Location = new Point(17, 537);
            txt_bonus.Multiline = true;
            txt_bonus.Name = "txt_bonus";
            txt_bonus.Size = new Size(223, 40);
            txt_bonus.TabIndex = 11;
            txt_bonus.Visible = false;
            // 
            // check_bonus
            // 
            check_bonus.AutoSize = true;
            check_bonus.Font = new Font("SF UI  Text", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            check_bonus.Location = new Point(8, 483);
            check_bonus.Name = "check_bonus";
            check_bonus.Size = new Size(121, 37);
            check_bonus.TabIndex = 10;
            check_bonus.Text = "Bonus";
            check_bonus.UseVisualStyleBackColor = true;
            // 
            // btn_prim
            // 
            btn_prim.Cursor = Cursors.Hand;
            btn_prim.Location = new Point(270, 409);
            btn_prim.Name = "btn_prim";
            btn_prim.Size = new Size(141, 33);
            btn_prim.TabIndex = 9;
            btn_prim.Text = "Primi Ver";
            btn_prim.UseVisualStyleBackColor = true;
            btn_prim.Visible = false;
            // 
            // txt_prim
            // 
            txt_prim.Font = new Font("SF UI  Text", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_prim.Location = new Point(17, 404);
            txt_prim.Multiline = true;
            txt_prim.Name = "txt_prim";
            txt_prim.Size = new Size(223, 40);
            txt_prim.TabIndex = 8;
            txt_prim.Visible = false;
            // 
            // check_prim
            // 
            check_prim.AutoSize = true;
            check_prim.Font = new Font("SF UI  Text", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            check_prim.Location = new Point(8, 350);
            check_prim.Name = "check_prim";
            check_prim.Size = new Size(96, 37);
            check_prim.TabIndex = 7;
            check_prim.Text = "Prim";
            check_prim.UseVisualStyleBackColor = true;
            // 
            // btn_gncl
            // 
            btn_gncl.Cursor = Cursors.Hand;
            btn_gncl.Location = new Point(270, 280);
            btn_gncl.Name = "btn_gncl";
            btn_gncl.Size = new Size(141, 33);
            btn_gncl.TabIndex = 6;
            btn_gncl.Text = "Güncelle";
            btn_gncl.UseVisualStyleBackColor = true;
            // 
            // txt_maas
            // 
            txt_maas.Font = new Font("SF UI  Text", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_maas.Location = new Point(17, 275);
            txt_maas.Multiline = true;
            txt_maas.Name = "txt_maas";
            txt_maas.Size = new Size(223, 40);
            txt_maas.TabIndex = 5;
            txt_maas.Text = "Maaşı";
            // 
            // lbl_tel
            // 
            lbl_tel.AutoSize = true;
            lbl_tel.Font = new Font("SF UI  Text", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_tel.Location = new Point(8, 224);
            lbl_tel.Name = "lbl_tel";
            lbl_tel.Size = new Size(245, 33);
            lbl_tel.TabIndex = 4;
            lbl_tel.Text = "Telefon Numarası";
            // 
            // lbl_yas
            // 
            lbl_yas.AutoSize = true;
            lbl_yas.Font = new Font("SF UI  Text", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_yas.Location = new Point(8, 165);
            lbl_yas.Name = "lbl_yas";
            lbl_yas.Size = new Size(68, 33);
            lbl_yas.TabIndex = 3;
            lbl_yas.Text = "Yaşı";
            // 
            // lbl_adsoyad
            // 
            lbl_adsoyad.AutoSize = true;
            lbl_adsoyad.Font = new Font("SF UI  Text", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_adsoyad.Location = new Point(8, 110);
            lbl_adsoyad.Name = "lbl_adsoyad";
            lbl_adsoyad.Size = new Size(152, 33);
            lbl_adsoyad.TabIndex = 2;
            lbl_adsoyad.Text = "Adı Soyadı";
            // 
            // btn_bilgi
            // 
            btn_bilgi.Cursor = Cursors.Hand;
            btn_bilgi.Font = new Font("SF UI  Text", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_bilgi.Location = new Point(324, 77);
            btn_bilgi.Name = "btn_bilgi";
            btn_bilgi.Size = new Size(113, 32);
            btn_bilgi.TabIndex = 1;
            btn_bilgi.Text = "Bilgileri Getir";
            btn_bilgi.UseVisualStyleBackColor = true;
            btn_bilgi.Click += btn_bilgi_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(8, 39);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(302, 32);
            comboBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(panel1);
            groupBox2.ForeColor = SystemColors.ControlText;
            groupBox2.Location = new Point(463, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(997, 333);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kar Grafiği";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Location = new Point(6, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(985, 297);
            panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(btn_yıllık);
            groupBox3.Controls.Add(btn_liste);
            groupBox3.Controls.Add(btn_aylık);
            groupBox3.Controls.Add(btn_karhesap);
            groupBox3.Controls.Add(txt_gider);
            groupBox3.Controls.Add(txt_gelir);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.ForeColor = SystemColors.ControlText;
            groupBox3.Location = new Point(463, 348);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(997, 333);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kar Hesaplama";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SF UI  Text", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkViolet;
            label4.Location = new Point(744, 148);
            label4.Name = "label4";
            label4.Size = new Size(87, 33);
            label4.TabIndex = 19;
            label4.Text = "TEXT";
            label4.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SF UI  Text", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(664, 65);
            label3.Name = "label3";
            label3.Size = new Size(253, 41);
            label3.TabIndex = 13;
            label3.Text = "AYLIK KARINIZ";
            label3.Visible = false;
            // 
            // btn_yıllık
            // 
            btn_yıllık.Cursor = Cursors.Hand;
            btn_yıllık.Location = new Point(298, 262);
            btn_yıllık.Name = "btn_yıllık";
            btn_yıllık.Size = new Size(178, 40);
            btn_yıllık.TabIndex = 18;
            btn_yıllık.Text = "Yıllık Kârı Göster";
            btn_yıllık.UseVisualStyleBackColor = true;
            // 
            // btn_liste
            // 
            btn_liste.Cursor = Cursors.Hand;
            btn_liste.Location = new Point(298, 151);
            btn_liste.Name = "btn_liste";
            btn_liste.Size = new Size(178, 40);
            btn_liste.TabIndex = 17;
            btn_liste.Text = "Kârı Listeye Ekle";
            btn_liste.UseVisualStyleBackColor = true;
            // 
            // btn_aylık
            // 
            btn_aylık.Cursor = Cursors.Hand;
            btn_aylık.Location = new Point(298, 206);
            btn_aylık.Name = "btn_aylık";
            btn_aylık.Size = new Size(178, 40);
            btn_aylık.TabIndex = 16;
            btn_aylık.Text = "Aylık Kârı Göster";
            btn_aylık.UseVisualStyleBackColor = true;
            btn_aylık.Click += btn_aylık_Click;
            // 
            // btn_karhesap
            // 
            btn_karhesap.Cursor = Cursors.Hand;
            btn_karhesap.Location = new Point(298, 98);
            btn_karhesap.Name = "btn_karhesap";
            btn_karhesap.Size = new Size(178, 40);
            btn_karhesap.TabIndex = 13;
            btn_karhesap.Text = "Kârı Hesapla";
            btn_karhesap.UseVisualStyleBackColor = true;
            btn_karhesap.Click += btn_karhesap_Click;
            // 
            // txt_gider
            // 
            txt_gider.Font = new Font("SF UI  Text", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_gider.Location = new Point(30, 206);
            txt_gider.Multiline = true;
            txt_gider.Name = "txt_gider";
            txt_gider.Size = new Size(223, 40);
            txt_gider.TabIndex = 15;
            // 
            // txt_gelir
            // 
            txt_gelir.Font = new Font("SF UI  Text", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_gelir.Location = new Point(30, 98);
            txt_gelir.Multiline = true;
            txt_gelir.Name = "txt_gelir";
            txt_gelir.Size = new Size(223, 40);
            txt_gelir.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF UI  Text", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(30, 170);
            label2.Name = "label2";
            label2.Size = new Size(86, 33);
            label2.TabIndex = 14;
            label2.Text = "Gider";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF UI  Text", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 62);
            label1.Name = "label1";
            label1.Size = new Size(76, 33);
            label1.TabIndex = 13;
            label1.Text = "Gelir";
            // 
            // hesap
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1472, 693);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("SF UI  Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "hesap";
            Text = "Muhasebe";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_bilgi;
        private ComboBox comboBox1;
        private Label lbl_tel;
        private Label lbl_yas;
        private Label lbl_adsoyad;
        private GroupBox groupBox2;
        private Panel panel1;
        private Button btn_gncl;
        private TextBox txt_maas;
        private Button btn_bonus;
        private TextBox txt_bonus;
        private CheckBox check_bonus;
        private Button btn_prim;
        private TextBox txt_prim;
        private CheckBox check_prim;
        private GroupBox groupBox3;
        private Button btn_liste;
        private Button btn_aylık;
        private Button btn_karhesap;
        private TextBox txt_gider;
        private TextBox txt_gelir;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Button btn_yıllık;
        private Button button1;
    }
}