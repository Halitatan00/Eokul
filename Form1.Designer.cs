namespace EokulOtomasyon
{
    partial class Form_Anasayfa
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
            this.btn_ogretmen = new System.Windows.Forms.Button();
            this.btn_ogrenci = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_no = new System.Windows.Forms.TextBox();
            this.tx_sifre = new System.Windows.Forms.TextBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ogretmen
            // 
            this.btn_ogretmen.Location = new System.Drawing.Point(141, 15);
            this.btn_ogretmen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ogretmen.Name = "btn_ogretmen";
            this.btn_ogretmen.Size = new System.Drawing.Size(267, 118);
            this.btn_ogretmen.TabIndex = 0;
            this.btn_ogretmen.Text = "ÖĞRETMEN";
            this.btn_ogretmen.UseVisualStyleBackColor = true;
            this.btn_ogretmen.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ogrenci
            // 
            this.btn_ogrenci.Location = new System.Drawing.Point(417, 15);
            this.btn_ogrenci.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ogrenci.Name = "btn_ogrenci";
            this.btn_ogrenci.Size = new System.Drawing.Size(274, 118);
            this.btn_ogrenci.TabIndex = 1;
            this.btn_ogrenci.Text = "ÖĞRENCİ";
            this.btn_ogrenci.UseVisualStyleBackColor = true;
            this.btn_ogrenci.Click += new System.EventHandler(this.btn_ogrenci_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ÖĞRETMEN TC :";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "ŞİFRE :";
            this.label2.Visible = false;
            // 
            // tx_no
            // 
            this.tx_no.Location = new System.Drawing.Point(417, 140);
            this.tx_no.Name = "tx_no";
            this.tx_no.Size = new System.Drawing.Size(274, 22);
            this.tx_no.TabIndex = 4;
            this.tx_no.Visible = false;
            // 
            // tx_sifre
            // 
            this.tx_sifre.Location = new System.Drawing.Point(417, 168);
            this.tx_sifre.Name = "tx_sifre";
            this.tx_sifre.Size = new System.Drawing.Size(274, 22);
            this.tx_sifre.TabIndex = 5;
            this.tx_sifre.Visible = false;
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(552, 197);
            this.btn_giris.Margin = new System.Windows.Forms.Padding(4);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(139, 50);
            this.btn_giris.TabIndex = 6;
            this.btn_giris.Text = "GİRİŞ";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Visible = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.Location = new System.Drawing.Point(753, 13);
            this.btn_admin.Margin = new System.Windows.Forms.Padding(4);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(125, 27);
            this.btn_admin.TabIndex = 7;
            this.btn_admin.Text = "ADMİN";
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // Form_Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 300);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.tx_sifre);
            this.Controls.Add(this.tx_no);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ogrenci);
            this.Controls.Add(this.btn_ogretmen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANASAYFA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ogretmen;
        private System.Windows.Forms.Button btn_ogrenci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_no;
        private System.Windows.Forms.TextBox tx_sifre;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Button btn_admin;
    }
}

