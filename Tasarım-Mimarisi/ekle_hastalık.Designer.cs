﻿
namespace Tasarım_Mimarisi
{
    partial class ekle_hastalık
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ekle_hastalık));
            this.hastalik = new System.Windows.Forms.TextBox();
            this.ekle_btn = new System.Windows.Forms.Button();
            this.anasycks = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hastalik
            // 
            this.hastalik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastalik.Location = new System.Drawing.Point(87, 77);
            this.hastalik.Name = "hastalik";
            this.hastalik.Size = new System.Drawing.Size(125, 26);
            this.hastalik.TabIndex = 1;
            // 
            // ekle_btn
            // 
            this.ekle_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ekle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekle_btn.ForeColor = System.Drawing.Color.White;
            this.ekle_btn.Image = ((System.Drawing.Image)(resources.GetObject("ekle_btn.Image")));
            this.ekle_btn.Location = new System.Drawing.Point(87, 168);
            this.ekle_btn.Name = "ekle_btn";
            this.ekle_btn.Size = new System.Drawing.Size(125, 127);
            this.ekle_btn.TabIndex = 2;
            this.ekle_btn.UseVisualStyleBackColor = true;
            this.ekle_btn.Click += new System.EventHandler(this.ekle_btn_Click);
            // 
            // anasycks
            // 
            this.anasycks.BackColor = System.Drawing.Color.Transparent;
            this.anasycks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("anasycks.BackgroundImage")));
            this.anasycks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.anasycks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anasycks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anasycks.ForeColor = System.Drawing.Color.Transparent;
            this.anasycks.Location = new System.Drawing.Point(350, 0);
            this.anasycks.Name = "anasycks";
            this.anasycks.Size = new System.Drawing.Size(40, 40);
            this.anasycks.TabIndex = 50;
            this.anasycks.UseVisualStyleBackColor = false;
            this.anasycks.Click += new System.EventHandler(this.anasycks_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 13F);
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(93, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 22);
            this.label2.TabIndex = 51;
            this.label2.Text = "Hastalığı Ekle";
            // 
            // ekle_hastalık
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(165)))), ((int)(((byte)(126)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(390, 340);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.anasycks);
            this.Controls.Add(this.ekle_btn);
            this.Controls.Add(this.hastalik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ekle_hastalık";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastalık Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox hastalik;
        private System.Windows.Forms.Button ekle_btn;
        private System.Windows.Forms.Button anasycks;
        private System.Windows.Forms.Label label2;
    }
}