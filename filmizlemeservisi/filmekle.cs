using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filmizlemeservisi
{
    public partial class filmekle : Form
    {
        public filmekle()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            string filmIsmi = textBox1.Text.Trim();
            string filmIcerigi = textBox2.Text.Trim();

            // Film ismi ve içerik boş değilse ana veri yapısına ekliyoruz
            if (!string.IsNullOrEmpty(filmIsmi) && !string.IsNullOrEmpty(filmIcerigi))
            {
                // Ana veri yapısına yeni film ekleyelim
                if (!FilmIzlemeSistemi.filmveri.filmIcerikleri.ContainsKey(filmIsmi))
                {
                    FilmIzlemeSistemi.filmveri.filmIsimleri.Add(filmIsmi);
                    FilmIzlemeSistemi.filmveri.filmIcerikleri.Add(filmIsmi, filmIcerigi);

                    MessageBox.Show("Film başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Formu temizleyelim
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    MessageBox.Show("Bu film zaten mevcut!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Film ismi ve içeriği boş olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
