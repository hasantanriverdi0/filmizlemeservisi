using FilmIzlemeSistemi;  // Filmveri sınıfını içeren namespace'i dahil ettik
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filmizlemeservisi
{
    public partial class filmizle : Form
    {
        public filmizle()
        {
            InitializeComponent();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void filmizle_Load(object sender, EventArgs e)
        {
            // Film isimlerini comboBox'a yükleyelim
            comboBox1.DataSource = FilmIzlemeSistemi.filmveri.filmIsimleri;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenFilm = comboBox1.SelectedItem.ToString();

            // Seçilen filmin içeriğini textBox1'e yazdıralım
            if (FilmIzlemeSistemi.filmveri.filmIcerikleri.ContainsKey(secilenFilm))
            {
                // TextBox'a içeriği yazalım
                textBox1.Text = FilmIzlemeSistemi.filmveri.filmIcerikleri[secilenFilm];

                // TextBox'ın özelliklerini ayarlayalım
                textBox1.Multiline = true;       // Birden fazla satırda gösterim sağlanacak
                textBox1.ScrollBars = ScrollBars.Vertical; // Dikey kaydırma çubuğu ekleyelim
                textBox1.ReadOnly = true;        // Sadece okuma için
            }
        }
    }
}
