using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyIMDB
{
    public partial class FormRate : Form
    {
        public FormRate(int whichFilm)
        {
            InitializeComponent();
            hangiFilm = whichFilm;
        }

        int hangiFilm;
        string connectionString = "Data Source=DESKTOP-LH27J2I;Initial Catalog=IMDb;Integrated Security=True";

        private void SetRate(int satirNumarasi, int yeniDeger)
        {

            // SqlConnection oluştur
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Bağlantıyı aç
                connection.Open();

                // SQL sorgusu
                string updateQuery = $"UPDATE Table_Movies SET YourRate = @YeniDeger WHERE MovieID = @SatirNumarasi";

                // SqlCommand oluştur
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    // Parametre ekleyerek SQL sorgusunu güncelle
                    command.Parameters.AddWithValue("@YeniDeger", yeniDeger);
                    command.Parameters.AddWithValue("@SatirNumarasi", satirNumarasi);

                    // Komutu çalıştır
                    int affectedRows = command.ExecuteNonQuery();

                    // Güncellenen satır sayısını kontrol et
                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Değer güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void sariYap(PictureBox fotoKutusu)
        {
            fotoKutusu.Image = Image.FromFile("C:\\Users\\tekeb\\Desktop\\Yeni klasör (3)\\sarıyıldız.png");
        }

        private void iciniBosalt(PictureBox fotoKutusu)
        {
            fotoKutusu.Image = Image.FromFile("C:\\Users\\tekeb\\Desktop\\Yeni klasör (3)\\icibosyıldız.png");
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            sariYap(pictureBox1);
            iciniBosalt(pictureBox2);
            iciniBosalt(pictureBox3);
            iciniBosalt(pictureBox4);
            iciniBosalt(pictureBox5);
            iciniBosalt(pictureBox6);
            iciniBosalt(pictureBox7);
            iciniBosalt(pictureBox8);
            iciniBosalt(pictureBox9);
            iciniBosalt(pictureBox10);
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            sariYap(pictureBox1);
            sariYap(pictureBox2);
            iciniBosalt(pictureBox3);
            iciniBosalt(pictureBox4);
            iciniBosalt(pictureBox5);
            iciniBosalt(pictureBox6);
            iciniBosalt(pictureBox7);
            iciniBosalt(pictureBox8);
            iciniBosalt(pictureBox9);
            iciniBosalt(pictureBox10);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            sariYap(pictureBox1);
            sariYap(pictureBox2);
            sariYap(pictureBox3);
            iciniBosalt(pictureBox4);
            iciniBosalt(pictureBox5);
            iciniBosalt(pictureBox6);
            iciniBosalt(pictureBox7);
            iciniBosalt(pictureBox8);
            iciniBosalt(pictureBox9);
            iciniBosalt(pictureBox10);
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            sariYap(pictureBox1);
            sariYap(pictureBox2);
            sariYap(pictureBox3);
            sariYap(pictureBox4);
            iciniBosalt(pictureBox5);
            iciniBosalt(pictureBox6);
            iciniBosalt(pictureBox7);
            iciniBosalt(pictureBox8);
            iciniBosalt(pictureBox9);
            iciniBosalt(pictureBox10);
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            sariYap(pictureBox1);
            sariYap(pictureBox2);
            sariYap(pictureBox3);
            sariYap(pictureBox4);
            sariYap(pictureBox5);
            iciniBosalt(pictureBox6);
            iciniBosalt(pictureBox7);
            iciniBosalt(pictureBox8);
            iciniBosalt(pictureBox9);
            iciniBosalt(pictureBox10);
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            sariYap(pictureBox1);
            sariYap(pictureBox2);
            sariYap(pictureBox3);
            sariYap(pictureBox4);
            sariYap(pictureBox5);
            sariYap(pictureBox6);
            iciniBosalt(pictureBox7);
            iciniBosalt(pictureBox8);
            iciniBosalt(pictureBox9);
            iciniBosalt(pictureBox10);
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            sariYap(pictureBox1);
            sariYap(pictureBox2);
            sariYap(pictureBox3);
            sariYap(pictureBox4);
            sariYap(pictureBox5);
            sariYap(pictureBox6);
            sariYap(pictureBox7);
            iciniBosalt(pictureBox8);
            iciniBosalt(pictureBox9);
            iciniBosalt(pictureBox10);
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            sariYap(pictureBox1);
            sariYap(pictureBox2);
            sariYap(pictureBox3);
            sariYap(pictureBox4);
            sariYap(pictureBox5);
            sariYap(pictureBox6);
            sariYap(pictureBox7);
            sariYap(pictureBox8);
            iciniBosalt(pictureBox9);
            iciniBosalt(pictureBox10);
        }

        private void pictureBox9_MouseEnter(object sender, EventArgs e)
        {
            sariYap(pictureBox1);
            sariYap(pictureBox2);
            sariYap(pictureBox3);
            sariYap(pictureBox4);
            sariYap(pictureBox5);
            sariYap(pictureBox6);
            sariYap(pictureBox7);
            sariYap(pictureBox8);
            sariYap(pictureBox9);
            iciniBosalt(pictureBox10);
        }

        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            sariYap(pictureBox1);
            sariYap(pictureBox2);
            sariYap(pictureBox3);
            sariYap(pictureBox4);
            sariYap(pictureBox5);
            sariYap(pictureBox6);
            sariYap(pictureBox7);
            sariYap(pictureBox8);
            sariYap(pictureBox9);
            sariYap(pictureBox10);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SetRate(hangiFilm, 1);
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SetRate(hangiFilm, 2);
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SetRate(hangiFilm, 3);
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SetRate(hangiFilm, 4);
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SetRate(hangiFilm, 5);
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SetRate(hangiFilm, 6);
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            SetRate(hangiFilm, 7);
            this.Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            SetRate(hangiFilm, 8);
            this.Close();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            SetRate(hangiFilm, 9);
            this.Close();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            SetRate(hangiFilm, 10);
            this.Close();
        }

        private void FormRate_MouseEnter(object sender, EventArgs e)
        {
            iciniBosalt(pictureBox1);
            iciniBosalt(pictureBox2);
            iciniBosalt(pictureBox3);
            iciniBosalt(pictureBox4);
            iciniBosalt(pictureBox5);
            iciniBosalt(pictureBox6);
            iciniBosalt(pictureBox7);
            iciniBosalt(pictureBox8);
            iciniBosalt(pictureBox9);
            iciniBosalt(pictureBox10);

        }
    }
}
