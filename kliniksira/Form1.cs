using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace kliniksira
{
    public partial class FormKayit : Form
    {
        // Veritabaný baðlantý adresimi ve fiþ üzerine yazdýracaðým deðiþkenleri burada tanýmladým.
        string connStr = "Server=asafb;Database=hastaVerileri;Integrated Security=True;TrustServerCertificate=True;";

        int yazdirilacakSiraNo;
        string yazdirilacakAdSoyad;
        string yazdirilacakDurum;
        string yazdirilacakSaat;
        int yazdirilacakYas;

        public FormKayit()
        {
            InitializeComponent();
        }

        private void FormKayit_Load(object sender, EventArgs e)
        {
            // Program açýldýðýnda  doktorun kullandýðý paneli de otomatik olarak yan tarafta açýyorum.
            Form2 doktorFormu = new Form2();
            doktorFormu.Show();
            doktorFormu.Left = this.Left + this.Width + 10;
        }

        private void btnSiraVer_Click(object sender, EventArgs e)
        {
            // Önce kullanýcýnýn Ad, Soyad ve TC bilgilerini eksiksiz girdiðinden emin oluyorum.
            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text) || mskTC.Text.Length != 11)
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz ve doðru giriniz.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    // Bugün kayýt olan hasta sayýsýný bulup, buna 100 ekleyerek yeni bir sýra numarasý üretiyorum(hastanelerdeki gibi).
                    string sayimSorgu = "SELECT COUNT(*) FROM Hastalar WHERE CAST(KayitSaati AS DATE) = CAST(GETDATE() AS DATE)";
                    int gunlukSayi = 0;

                    using (SqlCommand cmdSay = new SqlCommand(sayimSorgu, conn))
                    {
                        gunlukSayi = (int)cmdSay.ExecuteScalar();
                    }
                    int yeniSiraNo = gunlukSayi + 100;

                    // Girilen TC numarasýna sahip bir hasta daha önce kayýt olmuþ mu kontrol ediyorum.
                    string kontrolSorgu = "SELECT HastaID FROM Hastalar WHERE TCKimlikNo = @tc";
                    int mevcutHastaID = 0;

                    using (SqlCommand cmdKontrol = new SqlCommand(kontrolSorgu, conn))
                    {
                        cmdKontrol.Parameters.AddWithValue("@tc", mskTC.Text);
                        object sonuc = cmdKontrol.ExecuteScalar();
                        if (sonuc != null) mevcutHastaID = Convert.ToInt32(sonuc);
                    }

                    DateTime suan = DateTime.Now;
                    int yas = DateTime.Now.Year - dtDogum.Value.Year;

                    string sqlIslem;

                    // Eðer hasta daha önce varsa bilgilerini güncelliyorum, yoksa yeni kayýt oluþturuyorum.
                    if (mevcutHastaID > 0)
                    {
                        sqlIslem = "UPDATE Hastalar SET Ad=@ad, Soyad=@soyad, Durum=0, KayitSaati=@saat, SiraNo=@sira, EngelDurumu=@engel WHERE HastaID=@id";
                    }
                    else
                    {
                        sqlIslem = "INSERT INTO Hastalar (TCKimlikNo, Ad, Soyad, DogumTarihi, EngelDurumu, Durum, KayitSaati, SiraNo) " +
                                   "VALUES (@tc, @ad, @soyad, @dogum, @engel, 0, @saat, @sira)";
                    }

                    // Hazýrladýðým sorguyu burada çalýþtýrýp veritabanýna kaydediyorum.
                    using (SqlCommand cmdIslem = new SqlCommand(sqlIslem, conn))
                    {
                        cmdIslem.Parameters.AddWithValue("@tc", mskTC.Text);
                        cmdIslem.Parameters.AddWithValue("@ad", txtAd.Text);
                        cmdIslem.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                        cmdIslem.Parameters.AddWithValue("@dogum", dtDogum.Value);
                        cmdIslem.Parameters.AddWithValue("@engel", chkEngel.Checked);
                        cmdIslem.Parameters.AddWithValue("@saat", suan);
                        cmdIslem.Parameters.AddWithValue("@sira", yeniSiraNo);

                        if (mevcutHastaID > 0) cmdIslem.Parameters.AddWithValue("@id", mevcutHastaID);

                        cmdIslem.ExecuteNonQuery();
                    }

                    // Kayýt tamamlanýnca, hastaya verilecek fiþi hazýrlayan fonksiyonu çaðýrýyorum.
                    FisHazirlaVeGoster(yeniSiraNo, txtAd.Text + " " + txtSoyad.Text, yas, chkEngel.Checked);

                    // Ýþlem bitince ekraný temizliyorum.
                    Temizle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }


        void FisHazirlaVeGoster(int sira, string adSoyad, int yas, bool engel)
        {
            // Fiþe yazýlacak bilgileri deðiþkenlere atýyorum.
            yazdirilacakSiraNo = sira;
            yazdirilacakAdSoyad = adSoyad;
            yazdirilacakYas = yas;
            yazdirilacakSaat = DateTime.Now.ToString("HH:mm");

            // Hasta 65 yaþ üstüyse veya engelliyse "ÖNCELÝKLÝ", deðilse "NORMAL" olarak belirliyorum.
            yazdirilacakDurum = (yas >= 65 || engel) ? "ÖNCELÝKLÝ HASTA" : "NORMAL HASTA";

            // Yazdýrma önizleme penceresini hazýrlayýp ekrana getiriyorum.
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(FisTasarimiCiz);
            PrintPreviewDialog onizleme = new PrintPreviewDialog();
            onizleme.Document = pd;
            onizleme.Text = "Sýra Fiþi Önizleme";
            onizleme.ShowDialog();
        }

        private void FisTasarimiCiz(object sender, PrintPageEventArgs e)
        {
            // Burada kaðýt üzerindeki tasarýmý yapýyorum. Fontlarý ve yazý tiplerini ayarlýyorum.
            Font baslikFont = new Font("Arial", 16, FontStyle.Bold);
            Font siraFont = new Font("Arial", 24, FontStyle.Bold);
            Font normalFont = new Font("Arial", 10, FontStyle.Regular);
            Font kucukFont = new Font("Arial", 8, FontStyle.Italic);
            Brush firca = Brushes.Black;
            float x = 10;
            float y = 10;
            float kagitGenisligi = 250;

            // Sýrasýyla baþlýðý, sýra numarasýný, hasta bilgilerini ve durumu kaðýda çizdiriyorum.
            StringFormat merkezFormat = new StringFormat() { Alignment = StringAlignment.Center };
            e.Graphics.DrawString("*** SIRA FÝÞÝ ***", baslikFont, firca, kagitGenisligi / 2 + x, y, merkezFormat);
            y += 40;

            e.Graphics.DrawString(yazdirilacakSiraNo.ToString(), siraFont, firca, kagitGenisligi / 2 + x, y, merkezFormat);
            y += 50;

            e.Graphics.DrawString("-----------------------------------------", normalFont, firca, x, y);
            y += 20;

            e.Graphics.DrawString($"Hasta: {yazdirilacakAdSoyad}", normalFont, firca, x, y);
            y += 20;
            e.Graphics.DrawString($"Yaþ: {yazdirilacakYas}", normalFont, firca, x, y);
            y += 20;
            e.Graphics.DrawString($"Durum: {yazdirilacakDurum}", new Font("Arial", 10, FontStyle.Bold), firca, x, y);
            y += 20;
            e.Graphics.DrawString($"Saat: {yazdirilacakSaat}", normalFont, firca, x, y);
            y += 30;

            e.Graphics.DrawString("Geçmiþ Olsun...", kucukFont, firca, kagitGenisligi / 2 + x, y, merkezFormat);
        }

        void Temizle()
        {
            // Yeni kayýt için metin kutularýný temizliyorum.
            txtAd.Clear();
            txtSoyad.Clear();
            mskTC.Clear();
            chkEngel.Checked = false;
            dtDogum.Value = DateTime.Now;
        }
    }
}