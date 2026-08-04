using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace kliniksira
{
    public partial class Form2 : Form
    {
        string yol = "Data Source=ASAFB;Initial Catalog=hastaVerileri;Integrated Security=True;TrustServerCertificate=True;";
        int aktifHastaID = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Form açıldığında listeyi dolduruyorum ve listenin canlı kalması için sayacı başlatıyorum.
            ListeyiYenile();
            if (timer1 != null) timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Her saniye listeyi yeniliyorum ki yeni kayıt yaptıran hastalar anında doktorun önüne düşsün.
            ListeyiYenile();
        }

        void ListeyiYenile()
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(yol))
                {
                    baglanti.Open();

                    // Burası kritik noktam: SQL sorgusunda 'CASE' yapısı kullanarak 65 yaş üstü ve engellilere öncelik verdim.
                    // Onları listenin en tepesine alıyorum, diğerlerini kayıt saatine göre sıralıyorum.
                    string sql = @"SELECT SiraNo, Ad, Soyad, 
                                (CASE WHEN Yas >= 65 THEN '65 Yaş Üstü' WHEN EngelDurumu = 1 THEN 'Engelli' ELSE 'Normal' END) AS OncelikDurumu, 
                                HastaID, Yas, EngelDurumu 
                                FROM Hastalar 
                                WHERE Durum = 0 
                                ORDER BY (CASE WHEN Yas >= 65 OR EngelDurumu = 1 THEN 0 ELSE 1 END), KayitSaati ASC";

                    using (SqlDataAdapter da = new SqlDataAdapter(sql, baglanti))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvBekleyenler.DataSource = dt;
                    }
                }

                if (dgvBekleyenler.Columns.Count > 0)
                {
                    dgvBekleyenler.Columns["HastaID"].Visible = false;
                    dgvBekleyenler.Columns["Yas"].Visible = false;
                    dgvBekleyenler.Columns["EngelDurumu"].Visible = false;

                    dgvBekleyenler.Columns["SiraNo"].Width = 50;
                    dgvBekleyenler.Columns["SiraNo"].HeaderText = "Sıra";

                    dgvBekleyenler.Columns["Ad"].Width = 100;
                    dgvBekleyenler.Columns["Soyad"].Width = 100;

                    dgvBekleyenler.Columns["OncelikDurumu"].Width = 120;
                    dgvBekleyenler.Columns["OncelikDurumu"].HeaderText = "Durum Bilgisi";

                    dgvBekleyenler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    // Öncelikli hastalar gözden kaçmasın diye listede onları kırmızı renkle işaretliyorum.
                    foreach (DataGridViewRow satir in dgvBekleyenler.Rows)
                    {
                        if (satir.IsNewRow || satir.Cells["OncelikDurumu"].Value == null) continue;
                        string durum = satir.Cells["OncelikDurumu"].Value.ToString();

                        if (durum != "Normal")
                        {
                            satir.DefaultCellStyle.BackColor = Color.LightCoral;
                            satir.DefaultCellStyle.ForeColor = Color.White;
                        }
                    }
                }
            }
            catch { }
        }

        private void btnCagir_Click(object sender, EventArgs e)
        {
            if (aktifHastaID != 0)
            {
                DialogResult cevap = MessageBox.Show("Şu an içeride hasta var. Muayeneyi bitirip sıradakini çağırmak istiyor musunuz?", "Onay", MessageBoxButtons.YesNo);
                if (cevap == DialogResult.No) return;
            }

            if (dgvBekleyenler.Rows.Count == 0)
            {
                MessageBox.Show("Bekleyen hasta yok.");
                return;
            }

            // Listenin en başındaki (en yüksek öncelikli) hastayı seçiyorum.
            DataGridViewRow secilenSatir = dgvBekleyenler.Rows[0];

            aktifHastaID = Convert.ToInt32(secilenSatir.Cells["HastaID"].Value);
            string ad = secilenSatir.Cells["Ad"].Value.ToString();
            string soyad = secilenSatir.Cells["Soyad"].Value.ToString();
            string durumBilgisi = secilenSatir.Cells["OncelikDurumu"].Value.ToString();

            lblAktifHasta.Text = ad.ToUpper() + " " + soyad.ToUpper();

            if (durumBilgisi != "Normal")
            {
                lblAktifHasta.ForeColor = Color.Red;
                lblAktifHasta.Text += "\n(" + durumBilgisi.ToUpper() + ")";
            }
            else
            {
                lblAktifHasta.ForeColor = Color.Green;
                lblAktifHasta.Text += "\n(NORMAL)";
            }

            // Burası önemli: Hastanın durumunu '1' (Çağrıldı) yapıyorum ve saatini güncelliyorum ki Ana Monitörde en üstte görünsün.
            VeritabaniGuncelle("UPDATE Hastalar SET Durum = 1, CagrilmaSaati = GETDATE() WHERE HastaID = " + aktifHastaID);

            ListeyiYenile();
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            if (aktifHastaID == 0) return;

            lblAktifHasta.Text = "BEKLENİYOR...";
            lblAktifHasta.ForeColor = Color.Black;
            aktifHastaID = 0;

            MessageBox.Show("Muayene tamamlandı.");
            ListeyiYenile();
        }
        void VeritabaniGuncelle(string sorgu)
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(yol))
                {
                    baglanti.Open();
                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {
                        komut.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}