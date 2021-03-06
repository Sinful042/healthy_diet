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
    public partial class ekle_hastalık : Form
    {
        public string isim;
        bool hastalik_yok;
        public ekle_hastalık()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=odev1.mdb");
        private void ekle_btn_Click(object sender, EventArgs e)
        {
            hastalik_yok = true;
            if (hastalik.Text=="")
            {
                MessageBox.Show("Lütfen hastalik ismini giriniz!", "Tamam");
            }
            else
            {
                baglanti.Open();
                OleDbCommand sorgu = new OleDbCommand("select *from Hastaliklar", baglanti);
                OleDbDataReader oku = sorgu.ExecuteReader();
                while (oku.Read())
                {
                    if (hastalik.Text == oku["HastalikAdi"].ToString())
                    {
                        MessageBox.Show("Bu hastalık zaten mevcut", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        hastalik_yok = false;



                    }
                }
                baglanti.Close();
                if (hastalik_yok)
                {
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("insert into Hastaliklar(HastalikAdi) values('" + hastalik.Text + "')", baglanti);
                    komut.ExecuteReader();
                    baglanti.Close();
                    MessageBox.Show("Hastalık Eklendi", "Tamam");
                    ana_sayfa ana = new ana_sayfa();
                    ana.isim = isim;
                    ana.Show();
                    this.Hide();
                }
            }
            
            
            
            
            
            
        }

        

        private void anasycks_Click(object sender, EventArgs e)
        {
            ana_sayfa ana = new ana_sayfa();
            ana.isim = isim;
            ana.Show();
            this.Hide();
        }

        private void ekle_hastalık_Load(object sender, EventArgs e)
        {

        }
    }
}
