namespace EokulOtomasyon
{
    partial class Form_Ogretmen
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_dersad = new System.Windows.Forms.ComboBox();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.tx_not3 = new System.Windows.Forms.TextBox();
            this.tx_not2 = new System.Windows.Forms.TextBox();
            this.tx_not1 = new System.Windows.Forms.TextBox();
            this.tx_ograd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(346, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÖĞRETMEN";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(166, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "......";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "ÖĞRETMEN ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "......";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = ".....";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ÖĞRETMEN TC :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÖĞRETMEN ADI :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(371, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(831, 250);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ÖĞRENCİLER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(825, 229);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_guncelle);
            this.groupBox3.Controls.Add(this.cb_dersad);
            this.groupBox3.Controls.Add(this.btn_listele);
            this.groupBox3.Controls.Add(this.btn_ekle);
            this.groupBox3.Controls.Add(this.tx_not3);
            this.groupBox3.Controls.Add(this.tx_not2);
            this.groupBox3.Controls.Add(this.tx_not1);
            this.groupBox3.Controls.Add(this.tx_ograd);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(18, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 355);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DÜZENLE";
            // 
            // cb_dersad
            // 
            this.cb_dersad.FormattingEnabled = true;
            this.cb_dersad.Location = new System.Drawing.Point(130, 71);
            this.cb_dersad.Name = "cb_dersad";
            this.cb_dersad.Size = new System.Drawing.Size(170, 24);
            this.cb_dersad.TabIndex = 2;
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(130, 270);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(170, 37);
            this.btn_listele.TabIndex = 12;
            this.btn_listele.Text = "LİSTELE";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(130, 184);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(170, 37);
            this.btn_ekle.TabIndex = 10;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // tx_not3
            // 
            this.tx_not3.Location = new System.Drawing.Point(130, 156);
            this.tx_not3.Name = "tx_not3";
            this.tx_not3.Size = new System.Drawing.Size(170, 22);
            this.tx_not3.TabIndex = 5;
            // 
            // tx_not2
            // 
            this.tx_not2.Location = new System.Drawing.Point(130, 128);
            this.tx_not2.Name = "tx_not2";
            this.tx_not2.Size = new System.Drawing.Size(170, 22);
            this.tx_not2.TabIndex = 4;
            // 
            // tx_not1
            // 
            this.tx_not1.Location = new System.Drawing.Point(130, 100);
            this.tx_not1.Name = "tx_not1";
            this.tx_not1.Size = new System.Drawing.Size(170, 22);
            this.tx_not1.TabIndex = 3;
            // 
            // tx_ograd
            // 
            this.tx_ograd.Location = new System.Drawing.Point(130, 44);
            this.tx_ograd.Name = "tx_ograd";
            this.tx_ograd.Size = new System.Drawing.Size(170, 22);
            this.tx_ograd.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "NOT 3:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "NOT 2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "NOT 1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "DERS AD:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "ÖĞRENCİ AD:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(371, 279);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(828, 250);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "NOTLAR";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 18);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(822, 229);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(130, 227);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(170, 37);
            this.btn_guncelle.TabIndex = 13;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // Form_Ogretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 601);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Ogretmen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÖĞRETMEN";
            this.Load += new System.EventHandler(this.Form_Ogretmen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cb_dersad;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox tx_not3;
        private System.Windows.Forms.TextBox tx_not2;
        private System.Windows.Forms.TextBox tx_not1;
        private System.Windows.Forms.TextBox tx_ograd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_guncelle;
    }
}