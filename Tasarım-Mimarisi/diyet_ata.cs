using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Tasarım_Mimarisi
{
    public partial class diyet_ata : Form
    {
        public string ad, soyad, tc;
        public string isim;
        public diyet_ata()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = Giris.baglanti_kur();
        private void diyet_ata_Load(object sender, EventArgs e)
        {
            item_add();
            ad_txt.Text = ad;
            soyad_txt.Text = soyad;
            tc_txt.Text = tc;
        }

        private void geri_btn_Click(object sender, EventArgs e)
        {
            
        }
        private void item_add()
        {
            comboboxdiyet.Items.Clear();
            baglanti.Open();
            OleDbCommand sorgu = new OleDbCommand("select *from Diyetler", baglanti);
            OleDbDataReader oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                comboboxdiyet.Items.Add(oku["DiyetAdi"].ToString());
            }
            baglanti.Close();
        }

        private void cikis_btn_Click(object sender, EventArgs e)
        {
            ana_sayfa ana = new ana_sayfa();
            ana.isim = isim;
            ana.Show();
            this.Hide();
        }

        private void combobox_Click(object sender, EventArgs e)
        {

        }

        private void combobox_Enter(object sender, EventArgs e)
        {
            if (comboboxdiyet.Text == "Diyet Seçiniz")
            {
                comboboxdiyet.Text = "";
                comboboxdiyet.ForeColor = Color.Black;

            }
        }

        private void combobox_Leave(object sender, EventArgs e)
        {
            if (comboboxdiyet.Text == "")
            {
                comboboxdiyet.Text = "Diyet Seçiniz";
                comboboxdiyet.ForeColor = Color.Silver;

            }
        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {
            if (comboboxdiyet.Text=="Diyet Seçiniz")
            {
                MessageBox.Show("Lütfen Diyet seçiniz!", "Tamam");
            }
            else
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("update Hastalar set Diyet = '" + comboboxdiyet.SelectedItem.ToString() + "' where TC = '" + tc + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Diyet ataması yapılmıştır!", "Tamam");
            }
            
            
        }

        private void anasycks_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
