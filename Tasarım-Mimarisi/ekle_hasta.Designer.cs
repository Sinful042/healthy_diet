
namespace Tasarım_Mimarisi
{
    partial class ekle_hasta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ekle_hasta));
            this.soyad_txt = new System.Windows.Forms.TextBox();
            this.tc_txt = new System.Windows.Forms.TextBox();
            this.ad_txt = new System.Windows.Forms.TextBox();
            this.telefon_txt = new System.Windows.Forms.TextBox();
            this.comboboxteshis = new System.Windows.Forms.ComboBox();
            this.ekle_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.geri_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.yhastacks = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // soyad_txt
            // 
            this.soyad_txt.ForeColor = System.Drawing.Color.Silver;
            this.soyad_txt.Location = new System.Drawing.Point(171, 126);
            this.soyad_txt.Name = "soyad_txt";
            this.soyad_txt.Size = new System.Drawing.Size(145, 20);
            this.soyad_txt.TabIndex = 25;
            this.soyad_txt.Text = "Soyad";
            this.soyad_txt.Enter += new System.EventHandler(this.soyad_txt_Enter);
            this.soyad_txt.Leave += new System.EventHandler(this.soyad_txt_Leave);
            // 
            // tc_txt
            // 
            this.tc_txt.ForeColor = System.Drawing.Color.Silver;
            this.tc_txt.Location = new System.Drawing.Point(171, 164);
            this.tc_txt.MaxLength = 11;
            this.tc_txt.Name = "tc_txt";
            this.tc_txt.Size = new System.Drawing.Size(145, 20);
            this.tc_txt.TabIndex = 24;
            this.tc_txt.Text = "TC";
            this.tc_txt.Enter += new System.EventHandler(this.tc_txt_Enter);
            this.tc_txt.Leave += new System.EventHandler(this.tc_txt_Leave);
            // 
            // ad_txt
            // 
            this.ad_txt.ForeColor = System.Drawing.Color.LightGray;
            this.ad_txt.Location = new System.Drawing.Point(171, 87);
            this.ad_txt.Name = "ad_txt";
            this.ad_txt.Size = new System.Drawing.Size(145, 20);
            this.ad_txt.TabIndex = 23;
            this.ad_txt.Text = "Ad";
            this.ad_txt.Enter += new System.EventHandler(this.ad_txt_Enter);
            this.ad_txt.Leave += new System.EventHandler(this.ad_txt_Leave);
            // 
            // telefon_txt
            // 
            this.telefon_txt.ForeColor = System.Drawing.Color.Silver;
            this.telefon_txt.Location = new System.Drawing.Point(172, 201);
            this.telefon_txt.MaxLength = 11;
            this.telefon_txt.Name = "telefon_txt";
            this.telefon_txt.Size = new System.Drawing.Size(145, 20);
            this.telefon_txt.TabIndex = 29;
            this.telefon_txt.Text = "Telefon";
            this.telefon_txt.Enter += new System.EventHandler(this.telefon_txt_Enter);
            this.telefon_txt.Leave += new System.EventHandler(this.telefon_txt_Leave);
            // 
            // comboboxteshis
            // 
            this.comboboxteshis.DisplayMember = "Yok";
            this.comboboxteshis.ForeColor = System.Drawing.Color.Silver;
            this.comboboxteshis.FormattingEnabled = true;
            this.comboboxteshis.Location = new System.Drawing.Point(172, 239);
            this.comboboxteshis.Name = "comboboxteshis";
            this.comboboxteshis.Size = new System.Drawing.Size(145, 21);
            this.comboboxteshis.TabIndex = 30;
            this.comboboxteshis.Text = "Teşhis Seçiniz";
            this.comboboxteshis.Enter += new System.EventHandler(this.comboboxteshis_Enter);
            this.comboboxteshis.Leave += new System.EventHandler(this.comboboxteshis_Leave);
            // 
            // ekle_btn
            // 
            this.ekle_btn.BackColor = System.Drawing.Color.White;
            this.ekle_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ekle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekle_btn.ForeColor = System.Drawing.Color.Transparent;
            this.ekle_btn.Image = ((System.Drawing.Image)(resources.GetObject("ekle_btn.Image")));
            this.ekle_btn.Location = new System.Drawing.Point(171, 292);
            this.ekle_btn.Name = "ekle_btn";
            this.ekle_btn.Size = new System.Drawing.Size(58, 52);
            this.ekle_btn.TabIndex = 32;
            this.ekle_btn.UseVisualStyleBackColor = false;
            this.ekle_btn.Click += new System.EventHandler(this.ekle_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Impact", 12F);
            this.label7.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label7.Location = new System.Drawing.Point(276, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = "Geri";
            // 
            // geri_btn
            // 
            this.geri_btn.BackColor = System.Drawing.Color.White;
            this.geri_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.geri_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.geri_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geri_btn.Font = new System.Drawing.Font("Impact", 12F);
            this.geri_btn.ForeColor = System.Drawing.Color.Transparent;
            this.geri_btn.Image = ((System.Drawing.Image)(resources.GetObject("geri_btn.Image")));
            this.geri_btn.Location = new System.Drawing.Point(264, 290);
            this.geri_btn.Name = "geri_btn";
            this.geri_btn.Size = new System.Drawing.Size(57, 54);
            this.geri_btn.TabIndex = 46;
            this.geri_btn.UseVisualStyleBackColor = false;
            this.geri_btn.Click += new System.EventHandler(this.geri_btn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 12F);
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(181, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Kayıt";
            // 
            // yhastacks
            // 
            this.yhastacks.BackColor = System.Drawing.Color.Transparent;
            this.yhastacks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yhastacks.BackgroundImage")));
            this.yhastacks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yhastacks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yhastacks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yhastacks.ForeColor = System.Drawing.Color.Transparent;
            this.yhastacks.Location = new System.Drawing.Point(328, -1);
            this.yhastacks.Name = "yhastacks";
            this.yhastacks.Size = new System.Drawing.Size(35, 35);
            this.yhastacks.TabIndex = 48;
            this.yhastacks.UseVisualStyleBackColor = false;
            this.yhastacks.Click += new System.EventHandler(this.anasycks_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Location = new System.Drawing.Point(177, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 26);
            this.label2.TabIndex = 49;
            this.label2.Text = "Hasta Bilgileri";
            // 
            // ekle_hasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(360, 379);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yhastacks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.geri_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ekle_btn);
            this.Controls.Add(this.comboboxteshis);
            this.Controls.Add(this.telefon_txt);
            this.Controls.Add(this.soyad_txt);
            this.Controls.Add(this.tc_txt);
            this.Controls.Add(this.ad_txt);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ekle_hasta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Ekle";
            this.Load += new System.EventHandler(this.ekle_hasta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox soyad_txt;
        private System.Windows.Forms.TextBox tc_txt;
        private System.Windows.Forms.TextBox ad_txt;
        private System.Windows.Forms.TextBox telefon_txt;
        private System.Windows.Forms.ComboBox comboboxteshis;
        private System.Windows.Forms.Button ekle_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button geri_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yhastacks;
        private System.Windows.Forms.Label label2;
    }
}