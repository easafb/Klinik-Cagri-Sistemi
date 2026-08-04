namespace kliniksira
{
    partial class FormKayit
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKayit));
            lblAd = new Label();
            lblTC = new Label();
            lblSoyad = new Label();
            lblDogum = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            mskTC = new MaskedTextBox();
            grpBilgiler = new GroupBox();
            dtDogum = new DateTimePicker();
            chkEngel = new CheckBox();
            btnSiraVer = new Button();
            lblSonuc = new Label();
            printPreviewDialog1 = new PrintPreviewDialog();
            grpBilgiler.SuspendLayout();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblAd.Location = new Point(6, 38);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(128, 23);
            lblAd.TabIndex = 1;
            lblAd.Text = "Adı                : ";
            // 
            // lblTC
            // 
            lblTC.AutoSize = true;
            lblTC.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblTC.Location = new Point(1, 143);
            lblTC.Name = "lblTC";
            lblTC.Size = new Size(126, 23);
            lblTC.TabIndex = 2;
            lblTC.Text = "T.C Kimlik      :";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblSoyad.Location = new Point(6, 89);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(124, 23);
            lblSoyad.TabIndex = 3;
            lblSoyad.Text = "Soyad            :";
            // 
            // lblDogum
            // 
            lblDogum.AutoSize = true;
            lblDogum.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblDogum.Location = new Point(6, 197);
            lblDogum.Name = "lblDogum";
            lblDogum.Size = new Size(130, 23);
            lblDogum.TabIndex = 4;
            lblDogum.Text = "Doğum Tarihi :";
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtAd.Location = new Point(139, 38);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 30);
            txtAd.TabIndex = 5;
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtSoyad.Location = new Point(139, 86);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 30);
            txtSoyad.TabIndex = 6;
            // 
            // mskTC
            // 
            mskTC.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            mskTC.Location = new Point(139, 140);
            mskTC.Mask = "00000000000";
            mskTC.Name = "mskTC";
            mskTC.Size = new Size(125, 30);
            mskTC.TabIndex = 7;
            mskTC.ValidatingType = typeof(int);
            // 
            // grpBilgiler
            // 
            grpBilgiler.Controls.Add(dtDogum);
            grpBilgiler.Controls.Add(chkEngel);
            grpBilgiler.Controls.Add(lblAd);
            grpBilgiler.Controls.Add(mskTC);
            grpBilgiler.Controls.Add(lblTC);
            grpBilgiler.Controls.Add(txtSoyad);
            grpBilgiler.Controls.Add(lblSoyad);
            grpBilgiler.Controls.Add(txtAd);
            grpBilgiler.Controls.Add(lblDogum);
            grpBilgiler.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpBilgiler.Location = new Point(20, 12);
            grpBilgiler.Name = "grpBilgiler";
            grpBilgiler.Size = new Size(400, 299);
            grpBilgiler.TabIndex = 10;
            grpBilgiler.TabStop = false;
            grpBilgiler.Text = "Hasta Kimlik Bilgileri";
            // 
            // dtDogum
            // 
            dtDogum.Location = new Point(139, 191);
            dtDogum.Name = "dtDogum";
            dtDogum.Size = new Size(230, 30);
            dtDogum.TabIndex = 11;
            // 
            // chkEngel
            // 
            chkEngel.AutoSize = true;
            chkEngel.CheckAlign = ContentAlignment.MiddleRight;
            chkEngel.Location = new Point(6, 245);
            chkEngel.Name = "chkEngel";
            chkEngel.Size = new Size(147, 27);
            chkEngel.TabIndex = 10;
            chkEngel.Text = "Engel Durumu";
            chkEngel.UseVisualStyleBackColor = true;
            // 
            // btnSiraVer
            // 
            btnSiraVer.BackColor = Color.ForestGreen;
            btnSiraVer.FlatStyle = FlatStyle.Flat;
            btnSiraVer.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSiraVer.ForeColor = Color.White;
            btnSiraVer.Location = new Point(26, 329);
            btnSiraVer.Name = "btnSiraVer";
            btnSiraVer.Size = new Size(394, 54);
            btnSiraVer.TabIndex = 11;
            btnSiraVer.Text = "SIRA VER";
            btnSiraVer.UseVisualStyleBackColor = false;
            btnSiraVer.Click += btnSiraVer_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblSonuc.ForeColor = Color.DarkRed;
            lblSonuc.Location = new Point(159, 397);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(8, 8);
            lblSonuc.TabIndex = 12;
            lblSonuc.Text = "Sistem Hazır...";
            lblSonuc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // FormKayit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 248);
            ClientSize = new Size(432, 453);
            Controls.Add(lblSonuc);
            Controls.Add(btnSiraVer);
            Controls.Add(grpBilgiler);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormKayit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hasta Kayıt Paneli";
            Load += FormKayit_Load;
            grpBilgiler.ResumeLayout(false);
            grpBilgiler.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblAd;
        private Label lblTC;
        private Label lblSoyad;
        private Label lblDogum;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private MaskedTextBox mskTC;
        private GroupBox grpBilgiler;
        private Button btnSiraVer;
        private Label lblSonuc;
        private CheckBox chkEngel;
        private DateTimePicker dtDogum;
        private PrintPreviewDialog printPreviewDialog1;
    }
}
