
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace MyIMDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public Form1(List<string> filmListe) : this()
        {
            foreach (string film in filmListe) { list.Add(film); }
        }

        List<string> list = new List<string>();
        string newString;
        bool karanlikmi;
        int hangiFilm;
        string connectionString = "Data Source=DESKTOP-LH27J2I;Initial Catalog=IMDb;Integrated Security=True";
        bool ilk = false;
        private void GetDataFromTableMovie(int TableId)
        {
            hangiFilm = TableId;
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
                                lbl_moviename.Text = reader[1].ToString();
                                lbl_budget.Text = "$" + reader[2].ToString() + " Milyon";
                                lbl_revenue.Text = "$" + reader[3].ToString() + " Milyon";
                                lbl_movietime.Text = reader[4].ToString() + " dk";
                                lbl_director.Text = reader[5].ToString();
                                lbl_movierating.Text = reader[6].ToString().Remove(3);
                                lbl_producer.Text = reader[7].ToString();
                                lbl_movieyear.Text = reader[8].ToString().Remove(10);
                                lbl_topic.Text = reader[9].ToString();
                                movie_afis.Image = Image.FromFile(reader[10].ToString());
                                lbl_popularity.Text = reader[11].ToString();
                                if (reader[12].ToString() == null)
                                {
                                    lbl_yourrate.Visible = false;
                                }
                                else
                                {
                                    lbl_yourrate.Text = reader[12].ToString() + "/10";
                                    lbl_yourrate.Visible = true;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluþtu.", ex.ToString());
                }
            }
        }

        private void GetDataFromTableCasting(int TableId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM Table_Cast WHERE CastID = @TableId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TableId", TableId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                lbl_cast1.Text = reader[1].ToString();
                                lbl_cast2.Text = reader[2].ToString();
                                lbl_cast3.Text = reader[3].ToString();
                                lbl_cast4.Text = reader[4].ToString();
                                lbl_cast5.Text = reader[5].ToString();
                                lbl_cast6.Text = reader[6].ToString();

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluþtu.", ex.ToString());
                }
            }
        }

        private void KaranlikYap()
        {
            pictureBox3.Image = Image.FromFile("C:\\Users\\tekeb\\Desktop\\Yeni klasör (3)\\light.png");
            this.BackColor = Color.FromArgb(7, 4, 12);
            label7.BackColor = Color.FromArgb(7, 4, 12);
            groupBox1.BackColor = Color.FromArgb(7, 4, 12);
            lbl_director.BackColor = Color.FromArgb(7, 4, 12);
            lbl_producer.BackColor = Color.FromArgb(7, 4, 12);
            label5.BackColor = Color.FromArgb(7, 4, 12);
            lbl_revenue.BackColor = Color.FromArgb(7, 4, 12);
            lbl_budget.BackColor = Color.FromArgb(7, 4, 12);
            //pictureBox3.BackColor = Color.FromArgb(7, 4, 12);
            lbl_cast1.BackColor = Color.FromArgb(7, 4, 12);
            lbl_cast2.BackColor = Color.FromArgb(7, 4, 12);
            lbl_cast3.BackColor = Color.FromArgb(7, 4, 12);
            lbl_cast4.BackColor = Color.FromArgb(7, 4, 12);
            lbl_cast5.BackColor = Color.FromArgb(7, 4, 12);
            lbl_cast6.BackColor = Color.FromArgb(7, 4, 12);
            pnl_popularity.BackColor = this.BackColor;
            pnl_rate.BackColor = this.BackColor;
            pnl_rating.BackColor = this.BackColor;
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            pictureBox3.BackColor = menuStrip1.BackColor;


            lbl_moviename.ForeColor = Color.White;
            lbl_movietime.ForeColor = Color.White;
            lbl_movieyear.ForeColor = Color.White;
            lbl_producer.ForeColor = Color.White;
            lbl_revenue.ForeColor = Color.White;
            lbl_director.ForeColor = Color.White;
            lbl_cast1.ForeColor = Color.White;
            lbl_cast2.ForeColor = Color.White;
            lbl_cast3.ForeColor = Color.White;
            lbl_cast4.ForeColor = Color.White;
            lbl_cast5.ForeColor = Color.White;
            lbl_cast6.ForeColor = Color.White;
            groupBox1.ForeColor = Color.White;
            lbl_budget.ForeColor = Color.White;
            lbl_topic.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label7.ForeColor = Color.White;
            lbl_movierating.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            lbl_yourrate.ForeColor = Color.White;
            lbl_popularity.ForeColor = Color.White;
            menuStrip1.BackColor = Color.FromArgb(64, 64, 64);
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;

        }

        private void AydinlikYap()
        {
            pictureBox3.Image = Image.FromFile("C:\\Users\\tekeb\\Desktop\\Yeni klasör (3)\\darkmodeiacon.png");


            this.BackColor = Color.Silver;
            label7.BackColor = Color.Silver;
            groupBox1.BackColor = Color.Silver;
            lbl_director.BackColor = Color.Silver;
            lbl_producer.BackColor = Color.Silver;
            label5.BackColor = Color.Silver;
            lbl_revenue.BackColor = Color.Silver;
            lbl_budget.BackColor = Color.Silver;
            //pictureBox3.BackColor = Color.FromArgb(100, 100, 100);
            lbl_cast1.BackColor = Color.Silver;
            lbl_cast2.BackColor = Color.Silver;
            lbl_cast3.BackColor = Color.Silver;
            lbl_cast4.BackColor = Color.Silver;
            lbl_cast5.BackColor = Color.Silver;
            lbl_cast6.BackColor = Color.Silver;
            pnl_popularity.BackColor = this.BackColor;
            pnl_rate.BackColor = this.BackColor;
            pnl_rating.BackColor = this.BackColor;
            //menuStrip1.BackColor = Color.FromArgb(45, 47, 49);
            menuStrip1.BackColor = Color.FromArgb(131, 130, 130);
            pictureBox3.BackColor = menuStrip1.BackColor;
            panel1.BackColor = menuStrip1.BackColor;


            lbl_moviename.ForeColor = Color.Black;
            lbl_movietime.ForeColor = Color.Black;
            lbl_movieyear.ForeColor = Color.Black;
            lbl_producer.ForeColor = Color.Black;
            lbl_revenue.ForeColor = Color.Black;
            lbl_director.ForeColor = Color.Black;
            lbl_cast1.ForeColor = Color.Black;
            lbl_cast2.ForeColor = Color.Black;
            lbl_cast3.ForeColor = Color.Black;
            lbl_cast4.ForeColor = Color.Black;
            lbl_cast5.ForeColor = Color.Black;
            lbl_cast6.ForeColor = Color.Black;
            groupBox1.ForeColor = Color.Black;
            lbl_budget.ForeColor = Color.Black;
            lbl_topic.ForeColor = Color.FromArgb(5, 12, 2);
            label5.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            lbl_movierating.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;
            lbl_yourrate.ForeColor = Color.Black;
            lbl_popularity.ForeColor = Color.Black;

        }
        /*
        private void siyahYap()
        {
            
        }

        private void beyazYap()
        {
            
        }
        */
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            theGodfatherToolStripMenuItem_Click(sender, e);

            KaranlikYap();
            karanlikmi = true;

            SqlConnection connection = new SqlConnection(connectionString);

            try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show("Bir hata oluþtu" + ex.ToString());
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel1_Click(sender, e);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            WatchList watchList = new WatchList();
            watchList.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel1_Click(sender, e);
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pnl_rating.BackColor = Color.FromArgb(100, 100, 100);
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Gray;
            pictureBox2.BackColor = Color.Gray;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            pictureBox2.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Gray;
            pictureBox2.BackColor = Color.Gray;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Gray;
            pictureBox2.BackColor = Color.Gray;
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            pnl_popularity.BackColor = this.BackColor;
            pnl_rate.BackColor = this.BackColor;
            pnl_rating.BackColor = this.BackColor;
            pictureBox2.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            pnl_rating.BackColor = Color.FromArgb(100, 100, 100);
        }

        private void pnl_rating_MouseLeave(object sender, EventArgs e)
        {
            pnl_rating.BackColor = this.BackColor;
        }

        private void lbl_movierating_MouseEnter(object sender, EventArgs e)
        {
            pnl_rating.BackColor = Color.FromArgb(100, 100, 100);
        }

        private void gorunurYap()
        {
            pnl_popularity.Visible = true;
            pictureBox_popularity.Visible = true;
            lbl_popularity.Visible = true;
            lbl_moviename.Visible = true;
            lbl_movietime.Visible = true;
            lbl_movieyear.Visible = true;
            lbl_budget.Visible = true;
            lbl_revenue.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            lbl_producer.Visible = true;
            lbl_director.Visible = true;
            lbl_topic.Visible = true;
            lbl_cast1.Visible = true;
            lbl_cast2.Visible = true;
            lbl_cast3.Visible = true;
            lbl_cast4.Visible = true;
            lbl_cast5.Visible = true;
            lbl_cast6.Visible = true;
            pnl_rating.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            groupBox1.Visible = true;
            pictureBox_Rate.Visible = true;
            lbl_ratebuton.Visible = true;
            pictureBox_Rate.Visible = true;
            pnl_rate.Visible = true;
            pictureBox_Rate.Visible = true;
            lbl_ratebuton.Visible = true;

        }

        private void madMAxToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            GetDataFromTableMovie(1);
            GetDataFromTableCasting(1);
            gorunurYap();
        }

        private void johnWickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(2);
            GetDataFromTableCasting(2);
            gorunurYap();
        }

        private void scarfaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(3);
            GetDataFromTableCasting(3);
            gorunurYap();
        }

        private void theDarkKnightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(4);
            GetDataFromTableCasting(4);
            gorunurYap();
        }

        private void vForVendettaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(5);
            GetDataFromTableCasting(5);
            gorunurYap();
        }

        private void gladiatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(6);
            GetDataFromTableCasting(6);
            gorunurYap();

        }

        private void avengersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(7);
            GetDataFromTableCasting(7);
            gorunurYap();
        }

        private void ýnceptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(8);
            GetDataFromTableCasting(8);
            gorunurYap();
        }

        private void trumanShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(9);
            GetDataFromTableCasting(9);
            gorunurYap();
        }

        private void gORAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(10);
            GetDataFromTableCasting(10);
            gorunurYap();
        }

        private void forrestGumpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(11);
            GetDataFromTableCasting(11);
            gorunurYap();
        }

        private void laVitaÈBellaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(12);
            GetDataFromTableCasting(12);
            gorunurYap();
        }

        private void vizonteleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(13);
            GetDataFromTableCasting(13);
            gorunurYap();
        }

        private void theMaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(14);
            GetDataFromTableCasting(14);
            gorunurYap();
        }

        private void again17ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(15);
            GetDataFromTableCasting(15);
            gorunurYap();
        }

        private void pardonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(16);
            GetDataFromTableCasting(16);
            gorunurYap();
        }

        private void theGodfatherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(17);
            GetDataFromTableCasting(17);
            gorunurYap();
        }

        private void leonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(18);
            GetDataFromTableCasting(18);
            gorunurYap();
        }

        private void taxiDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(19);
            GetDataFromTableCasting(19);
            gorunurYap();
        }

        private void goodWillHuntingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(20);
            GetDataFromTableCasting(20);
            gorunurYap();
        }

        private void aBeautifulMindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(21);
            GetDataFromTableCasting(21);
            gorunurYap();
        }

        private void theSocialNetworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(22);
            GetDataFromTableCasting(22);
            gorunurYap();
        }

        private void schindlersListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(23);
            GetDataFromTableCasting(23);
            gorunurYap();
        }

        private void godfellasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(24);
            GetDataFromTableCasting(24);
            gorunurYap();
        }

        private void laLaLandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(25);
            GetDataFromTableCasting(25);
            gorunurYap();
        }

        private void theNotebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(26);
            GetDataFromTableCasting(26);
            gorunurYap();
        }

        private void titanicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(27);
            GetDataFromTableCasting(27);
            gorunurYap();
        }

        private void casablancaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(28);
            GetDataFromTableCasting(28);
            gorunurYap();
        }

        private void prideAndPrejudiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(29);
            GetDataFromTableCasting(29);
            gorunurYap();
        }

        private void moonlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(30);
            GetDataFromTableCasting(30);
            gorunurYap();
        }

        private void eternalSunshineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(31);
            GetDataFromTableCasting(31);
            gorunurYap();
        }

        private void brokebackMountainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(32);
            GetDataFromTableCasting(32);
            gorunurYap();
        }

        private void psychoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(33);
            GetDataFromTableCasting(33);
            gorunurYap();
        }

        private void theShinigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(34);
            GetDataFromTableCasting(34);
            gorunurYap();
        }

        private void getOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(35);
            GetDataFromTableCasting(35);
            gorunurYap();
        }

        private void ýtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(36);
            GetDataFromTableCasting(36);
            gorunurYap();
        }

        private void sawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(37);
            GetDataFromTableCasting(37);
            gorunurYap();
        }

        private void theExorcistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(38);
            GetDataFromTableCasting(38);
            gorunurYap();
        }

        private void screamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(39);
            GetDataFromTableCasting(39);
            gorunurYap();
        }

        private void alienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(40);
            GetDataFromTableCasting(40);
            gorunurYap();
        }

        private void snowpiercerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(41);
            GetDataFromTableCasting(41);
            gorunurYap();
        }

        private void duneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(42);
            GetDataFromTableCasting(42);
            gorunurYap();
        }

        private void solarisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(43);
            GetDataFromTableCasting(43);
            gorunurYap();
        }

        private void ýnterstellarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(44);
            GetDataFromTableCasting(44);
            gorunurYap();
        }

        private void theExtraTerrestrialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(45);
            GetDataFromTableCasting(45);
            gorunurYap();
        }

        private void backToTheFutureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(46);
            GetDataFromTableCasting(46);
            gorunurYap();
        }

        private void starWarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(47);
            GetDataFromTableCasting(47);
            gorunurYap();
        }

        private void aSpaceOdysseyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(48);
            GetDataFromTableCasting(48);
            gorunurYap();
        }

        private void wALLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(49);
            GetDataFromTableCasting(49);
            gorunurYap();
        }

        private void shrekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(50);
            GetDataFromTableCasting(50);
            gorunurYap();
        }

        private void toyStoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(51);
            GetDataFromTableCasting(51);
            gorunurYap();
        }

        private void hTTYDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(52);
            GetDataFromTableCasting(52);
            gorunurYap();
        }

        private void monstersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(53);
            GetDataFromTableCasting(53);
            gorunurYap();
        }

        private void theLionKingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(54);
            GetDataFromTableCasting(54);
            gorunurYap();
        }

        private void upToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(55);
            GetDataFromTableCasting(55);
            gorunurYap();
        }

        private void ýnsideOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromTableMovie(56);
            GetDataFromTableCasting(56);
            gorunurYap();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /*lbl_yourrate.Visible = false;
            pnl_popularity.Visible = false;
            pictureBox_popularity.Visible = false;
            lbl_popularity.Visible = false;
            pictureBox_Rate.Visible = false;
            pnl_rate.Visible = false;
            pictureBox_Rate.Visible = false;
            lbl_ratebuton.Visible = false;
            lbl_moviename.Visible = false;
            lbl_movietime.Visible = false;
            lbl_movieyear.Visible = false;
            lbl_budget.Visible = false;
            lbl_revenue.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            lbl_producer.Visible = false;
            lbl_director.Visible = false;
            lbl_topic.Visible = false;
            lbl_cast1.Visible = false;
            lbl_cast2.Visible = false;
            lbl_cast3.Visible = false;
            lbl_cast4.Visible = false;
            lbl_cast5.Visible = false;
            lbl_cast6.Visible = false;
            pnl_rating.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            movie_afis.Image = null;
            groupBox1.Visible = false;
            */
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Hide();

        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            pnl_rating.BackColor = Color.FromArgb(100, 100, 100);
        }
        private void lbl_movierating_MouseEnter_1(object sender, EventArgs e)
        {
            pnl_rating.BackColor = Color.FromArgb(100, 100, 100);
        }
        private void pictureBox4_MouseEnter_1(object sender, EventArgs e)
        {
            pnl_rating.BackColor = Color.FromArgb(100, 100, 100);
        }

        private void pnl_rating_MouseEnter(object sender, EventArgs e)
        {
            pnl_rating.BackColor = Color.FromArgb(100, 100, 100);


        }

        private void pnl_rating_MouseLeave_1(object sender, EventArgs e)
        {
            pnl_rating.BackColor = this.BackColor;
        }
        private void label6_MouseLeave(object sender, EventArgs e)
        {
            pnl_rating.BackColor = this.BackColor;
        }
        private void lbl_movierating_MouseLeave(object sender, EventArgs e)
        {
            pnl_rating.BackColor = this.BackColor;
        }


        private void pnl_rate_MouseEnter(object sender, EventArgs e)
        {
            pnl_rate.BackColor = Color.FromArgb(100, 100, 100);
        }

        private void pictureBox_Rate_MouseEnter(object sender, EventArgs e)
        {
            pnl_rate.BackColor = Color.FromArgb(100, 100, 100);
        }

        private void lbl_ratebuton_MouseEnter(object sender, EventArgs e)
        {
            pnl_rate.BackColor = Color.FromArgb(100, 100, 100);
        }

        private void lbl_yourrate_MouseEnter(object sender, EventArgs e)
        {
            pnl_rate.BackColor = Color.FromArgb(100, 100, 100);
        }
        private void pictureBox_Rate_MouseLeave(object sender, EventArgs e)
        {
            pnl_rate.BackColor = this.BackColor;
        }
        private void lbl_yourrate_MouseLeave(object sender, EventArgs e)
        {
            pnl_rate.BackColor = this.BackColor;
        }
        private void lbl_ratebuton_MouseLeave(object sender, EventArgs e)
        {
            pnl_rate.BackColor = this.BackColor;
        }
        private void pnl_rate_MouseLeave(object sender, EventArgs e)
        {
            pnl_rate.BackColor = this.BackColor;
        }
        private void lbl_popularity_MouseLeave(object sender, EventArgs e)
        {
            pnl_rate.BackColor = this.BackColor;
        }



        private void pnl_popularity_MouseEnter(object sender, EventArgs e)
        {
            pnl_popularity.BackColor = Color.FromArgb(100, 100, 100);
        }

        private void pictureBox_popularity_MouseEnter(object sender, EventArgs e)
        {
            pnl_popularity.BackColor = Color.FromArgb(100, 100, 100);
        }

        private void lbl_popularity_MouseEnter(object sender, EventArgs e)
        {
            pnl_popularity.BackColor = Color.FromArgb(100, 100, 100);
        }

        private void pnl_popularity_MouseLeave(object sender, EventArgs e)
        {
            pnl_popularity.BackColor = this.BackColor;
        }

        private void pictureBox_popularity_MouseLeave(object sender, EventArgs e)
        {
            pnl_popularity.BackColor = this.BackColor;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(100, 100, 100);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = menuStrip1.BackColor;
        }

        private void pictureBox2_MouseEnter_1(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 100, 100);
        }

        private void label1_MouseEnter_1(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 100, 100);
        }

        private void panel1_MouseEnter_1(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 100, 100);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = menuStrip1.BackColor;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = menuStrip1.BackColor;
        }

        private void panel1_MouseLeave_1(object sender, EventArgs e)
        {
            panel1.BackColor = menuStrip1.BackColor;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (karanlikmi == true)
            {
                AydinlikYap();
                karanlikmi = false;

            }
            else
            {
                KaranlikYap();
                karanlikmi = true;

            }
        }

        private void panel1_Click_1(object sender, EventArgs e)
        {
            WatchList watchList = new WatchList(list);
            watchList.Show();
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            panel1_Click_1(sender, e);
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            panel1_Click_1(sender, e);
        }

        private void pnl_rate_Click(object sender, EventArgs e)
        {
            FormRate puanForm = new FormRate(hangiFilm);
            puanForm.ShowDialog();
            GetDataFromTableMovie(hangiFilm);
        }

        private void lbl_ratebuton_Click(object sender, EventArgs e)
        {
            pnl_rate_Click(sender, e);
        }

        private void pictureBox_Rate_Click(object sender, EventArgs e)
        {
            pnl_rate_Click(sender, e);
        }

        private void lbl_yourrate_Click(object sender, EventArgs e)
        {
            pnl_rate_Click(sender, e);
        }

        private void pnl_popularity_Click(object sender, EventArgs e)
        {
            FormLeaderboard liderlik = new FormLeaderboard();
            liderlik.ShowDialog();
        }

        private void lbl_popularity_Click(object sender, EventArgs e)
        {
            pnl_popularity_Click(sender, e);
        }

        private void pictureBox_popularity_Click(object sender, EventArgs e)
        {
            pnl_popularity_Click(sender, e);
        }


    }
}