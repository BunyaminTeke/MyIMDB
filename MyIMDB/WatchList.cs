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
    public partial class WatchList : Form
    {
        public WatchList()
        {
            InitializeComponent();
        }

        public WatchList(List<string> filmListe) : this()
        {
            foreach (string film in filmListe) { MovieNames.Add(film); }
        }
        public List<string> MovieNames = new List<string>();
        string resimYolu;

        private void WatchList_Load(object sender, EventArgs e)
        {
            foreach (string film in MovieNames)
            {
                comboBox1.Items.Add(film);
            }

            sagaok_Click(sender, e);

            movie4add.Parent = film4afis;
            movie4add.BackColor = Color.FromArgb(5, 255, 255, 255);

            movie3add.Parent = film3afis;
            movie3add.BackColor = Color.FromArgb(5, 255, 255, 255);

            movie2add.Parent = film2afis;
            movie2add.BackColor = Color.FromArgb(5, 255, 255, 255);

            movie1add.Parent = film1afis;
            movie1add.BackColor = Color.FromArgb(5, 255, 255, 255);
            sagaok.BackColor = Color.Transparent;
        }


        string connectionString = "Data Source=DESKTOP-LH27J2I;Initial Catalog=IMDb;Integrated Security=True";

        private void GetDataFromTableMovie(int hangiKisim, int TableId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM Table_Movies WHERE MovieID = @TableId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TableId", TableId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                if (hangiKisim == 0)
                                {
                                    film1afis.Image = Image.FromFile(reader[10].ToString());
                                    lbl_movie1critic.Text = reader[6].ToString().Remove(3);
                                    lbl_movie1name.Text = reader[1].ToString();
                                    FilmIsmiOrtala(lbl_movie1name, lbl_movie1name.Size.Width);

                                }
                                else if (hangiKisim == 1)
                                {
                                    film2afis.Image = Image.FromFile(reader[10].ToString());
                                    lbl_movie2critic.Text = reader[6].ToString().Remove(3);
                                    lbl_movie2name.Text = reader[1].ToString();
                                    FilmIsmiOrtala(lbl_movie2name, lbl_movie2name.Size.Width);
                                }
                                else if (hangiKisim == 2)
                                {
                                    film3afis.Image = Image.FromFile(reader[10].ToString());
                                    lbl_movie3critic.Text = reader[6].ToString().Remove(3);
                                    lbl_movie3name.Text = reader[1].ToString();
                                    FilmIsmiOrtala(lbl_movie3name, lbl_movie3name.Size.Width);
                                }
                                else if (hangiKisim == 3)
                                {
                                    film4afis.Image = Image.FromFile(reader[10].ToString());
                                    lbl_movie4critic.Text = reader[6].ToString().Remove(3);
                                    lbl_movie4name.Text = reader[1].ToString();
                                    FilmIsmiOrtala(lbl_movie4name, lbl_movie4name.Size.Width);
                                }

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu.", ex.ToString());
                }
            }
        }

        private void FilmIsmiOrtala(Label lblornek, int uzunluk)
        {
            lblornek.Location = new Point((230 - uzunluk) / 2, lblornek.Location.Y);
        }

        private void sagaok_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sayi0, sayi1 = -1, sayi2 = -1, sayi3 = -1, sayi4 = -1;

            for (int i = 0; i < 4; i++)
            {
            tekrar:

                sayi0 = rnd.Next(1, 57);

                if (sayi0 == sayi1 || sayi0 == sayi2 || sayi0 == sayi3 || sayi0 == sayi4)
                {

                    goto tekrar;
                }
                else
                {
                    if (i == 0)
                    {
                        sayi1 = sayi0;
                    }
                    else if (i == 1)
                    {
                        sayi2 = sayi0;
                    }
                    else if (i == 2)
                    {
                        sayi3 = sayi0;
                    }
                    else if (i == 3)
                    {
                        sayi4 = sayi0;
                    }

                    GetDataFromTableMovie(i, sayi0);

                }

            }
        }

        private void home_MouseEnter(object sender, EventArgs e)
        {
            home.BackColor = Color.Gray;
        }

        private void home_MouseLeave(object sender, EventArgs e)
        {
            home.BackColor = this.BackColor;
        }

        private void movie1add_MouseEnter(object sender, EventArgs e)
        {
            resimYolu = "C:\\Users\\tekeb\\Desktop\\Yeni klasör\\timesgribook2.png";
            movie1add.Image = Image.FromFile(resimYolu);
        }

        private void movie1add_MouseLeave(object sender, EventArgs e)
        {
            resimYolu = "C:\\Users\\tekeb\\Desktop\\Yeni klasör\\timesgribook1.png";
            movie1add.Image = Image.FromFile(resimYolu);
        }

        private void movie2add_MouseEnter(object sender, EventArgs e)
        {
            resimYolu = "C:\\Users\\tekeb\\Desktop\\Yeni klasör\\timesgribook2.png";
            movie2add.Image = Image.FromFile(resimYolu);
        }

        private void movie2add_MouseLeave(object sender, EventArgs e)
        {
            resimYolu = "C:\\Users\\tekeb\\Desktop\\Yeni klasör\\timesgribook1.png";
            movie2add.Image = Image.FromFile(resimYolu);
        }

        private void movie3add_MouseEnter(object sender, EventArgs e)
        {
            resimYolu = "C:\\Users\\tekeb\\Desktop\\Yeni klasör\\timesgribook2.png";
            movie3add.Image = Image.FromFile(resimYolu);
        }

        private void movie3add_MouseLeave(object sender, EventArgs e)
        {
            resimYolu = "C:\\Users\\tekeb\\Desktop\\Yeni klasör\\timesgribook1.png";
            movie3add.Image = Image.FromFile(resimYolu);
        }

        private void movie4add_MouseEnter(object sender, EventArgs e)
        {
            resimYolu = "C:\\Users\\tekeb\\Desktop\\Yeni klasör\\timesgribook2.png";
            movie4add.Image = Image.FromFile(resimYolu);
        }

        private void movie4add_MouseLeave(object sender, EventArgs e)
        {
            resimYolu = "C:\\Users\\tekeb\\Desktop\\Yeni klasör\\timesgribook1.png";
            movie4add.Image = Image.FromFile(resimYolu);
        }

        private void pnl_movie1trailer_MouseEnter(object sender, EventArgs e)
        {
            pnl_movie1trailer.BackColor = Color.FromArgb(100, 100, 100);
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pnl_movie1trailer.BackColor = Color.FromArgb(100, 100, 100);
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            pnl_movie1trailer.BackColor = this.BackColor;
        }

        private void pnl_movie1trailer_MouseLeave(object sender, EventArgs e)
        {
            pnl_movie1trailer.BackColor = Color.Black;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pnl_movie1trailer.BackColor = Color.Black;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            pnl_movie1trailer.BackColor = Color.Black;
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(100, 100, 100);
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(100, 100, 100);
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(100, 100, 100);
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Black;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Black;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Black;
        }

        private void pnl_movie3trailer_MouseEnter(object sender, EventArgs e)
        {
            pnl_movie3trailer.BackColor = Color.FromArgb(100, 100, 100);
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            pnl_movie3trailer.BackColor = Color.FromArgb(100, 100, 100);
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            pnl_movie3trailer.BackColor = Color.FromArgb(100, 100, 100);
        }

        private void pnl_movie3trailer_MouseLeave(object sender, EventArgs e)
        {
            pnl_movie3trailer.BackColor = Color.Black;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            pnl_movie3trailer.BackColor = Color.Black;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pnl_movie3trailer.BackColor = Color.Black;
        }

        private void home_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(MovieNames);
            form1.Show();
            this.Close();
        }

        private void pnl_movie4trailer_MouseEnter(object sender, EventArgs e)
        {
            pnl_movie4trailer.BackColor = Color.FromArgb(100, 100, 100);
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            pnl_movie4trailer.BackColor = Color.FromArgb(100, 100, 100);
        }

        private void pictureBox12_MouseEnter(object sender, EventArgs e)
        {
            pnl_movie4trailer.BackColor = Color.FromArgb(100, 100, 100);
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            pnl_movie4trailer.BackColor = Color.Black;
        }

        private void pnl_movie4trailer_MouseLeave(object sender, EventArgs e)
        {
            pnl_movie4trailer.BackColor = Color.Black;
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            pnl_movie4trailer.BackColor = Color.Black;
        }

        private void sagaok_MouseEnter(object sender, EventArgs e)
        {
            sagaok.BackColor = Color.Gray;
        }

        private void sagaok_MouseLeave(object sender, EventArgs e)
        {
            sagaok.BackColor = this.BackColor;
        }

        private void movie1add_Click(object sender, EventArgs e)
        {
            if (MovieNames.Contains(lbl_movie1name.Text) == false)
            {
                comboBox1.Items.Add(lbl_movie1name.Text);
                MovieNames.Add(lbl_movie1name.Text);

            }
        }

        private void movie2add_Click(object sender, EventArgs e)
        {
            if (MovieNames.Contains(lbl_movie2name.Text) == false)
            {
                comboBox1.Items.Add(lbl_movie2name.Text);
                MovieNames.Add(lbl_movie2name.Text);
            }
        }

        private void movie3add_Click(object sender, EventArgs e)
        {
            if (MovieNames.Contains(lbl_movie3name.Text) == false)
            {
                comboBox1.Items.Add(lbl_movie3name.Text);
                MovieNames.Add(lbl_movie3name.Text);
            }
        }

        private void movie4add_Click(object sender, EventArgs e)
        {
            if (MovieNames.Contains(lbl_movie4name.Text) == false)
            {
                comboBox1.Items.Add(lbl_movie4name.Text);
                MovieNames.Add(lbl_movie4name.Text);
            }
        }

        private void delete_MouseEnter(object sender, EventArgs e)
        {
            delete.Image = Image.FromFile("C:\\Users\\tekeb\\Desktop\\Yeni klasör (3)\\trashopen.png");
        }

        private void delete_MouseLeave(object sender, EventArgs e)
        {
            delete.Image = Image.FromFile("C:\\Users\\tekeb\\Desktop\\Yeni klasör (3)\\trashclosed.png");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Silmek istediğiniz Filmi Seçiniz");
            }
            else
            {
                MovieNames.Remove(comboBox1.SelectedItem.ToString());
                comboBox1.Items.Remove(comboBox1.SelectedItem.ToString());
            }
        }
    }
}
