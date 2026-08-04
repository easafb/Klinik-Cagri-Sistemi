using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms; 

namespace KlinikMonitor
{
    public partial class hastamon : Form
    {
        public hastamon()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=ASAFB;Initial Catalog=hastaVerileri;Integrated Security=True;TrustServerCertificate=True");

        private void hastamon_Load(object sender, EventArgs e)
        {
            // Form açýldýðýnda, ekranýn anlýk güncellenmesi için bir zamanlayýcý (Timer) baþlattým.
            timer1.Interval = 1000; 
            timer1.Start();

            lblAnaHastaAd.Text = "";
            lblAnaSiraNo.Text = "";
            lblBekleyenSayisi.Text = "Bekleyen: 0";
            picOncelik.Image = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            VerileriGuncelle();
        }

        void VerileriGuncelle()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                // Durumu '1' olan yani o an doktorun çaðýrdýðý hastayý çekiyorum.
                // En son çaðrýlanýn görünmesi için 'CagrilmaSaati'ne göre sýraladým.
                SqlCommand komutSol = new SqlCommand("SELECT TOP 1 (Ad + ' ' + Soyad) AS TamAd, SiraNo, Yas, EngelDurumu FROM Hastalar WHERE Durum = 1 ORDER BY CagrilmaSaati DESC", baglanti);
                SqlDataReader dr = komutSol.ExecuteReader();

                if (dr.Read())
                {
                    lblAnaHastaAd.Text = dr["TamAd"].ToString();
                    lblAnaSiraNo.Text = dr["SiraNo"].ToString();

                    lblAnaHastaAd.Visible = true;
                    lblAnaSiraNo.Visible = true;

                    bool engelliMi = false;
                    int yas = 0;

                    if (dr["EngelDurumu"] != DBNull.Value)
                        engelliMi = Convert.ToBoolean(dr["EngelDurumu"]);

                    if (dr["Yas"] != DBNull.Value)
                        yas = Convert.ToInt32(dr["Yas"]);

                    if (engelliMi == true)
                    {
                        picOncelik.Image = Properties.Resources.engelli;
                    }
                    else if (yas >= 65)
                    {
                        picOncelik.Image = Properties.Resources.yasli;
                    }
                    else
                    {
                        picOncelik.Image = Properties.Resources.normal;
                    }
                    picOncelik.Visible = true;
                }
                else
                {
                    lblAnaHastaAd.Text = "";
                    lblAnaSiraNo.Text = "";
                    picOncelik.Image = null;
                }
                dr.Close();


               
                SqlDataAdapter da = new SqlDataAdapter("SELECT SiraNo as 'Sýra', (Ad + ' ' + Soyad) as 'Ad Soyad' FROM Hastalar WHERE Durum = 0 ORDER BY SiraNo ASC", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewBekleyenler.DataSource = dt;

                lblBekleyenSayisi.Text = "Toplam Bekleyen: " + dt.Rows.Count.ToString();
                lblBekleyenSayisi.Visible = true;

                baglanti.Close();
            }
            catch (Exception ex)
            {
            }
        }
    }
}