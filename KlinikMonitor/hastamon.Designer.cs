namespace KlinikMonitor
{
    partial class hastamon
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hastamon));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlSol = new Panel();
            picOncelik = new PictureBox();
            lblAnaHastaAd = new Label();
            lblAnaSiraNo = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            dataGridViewBekleyenler = new DataGridView();
            lblBekleyenSayisi = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1.SuspendLayout();
            pnlSol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picOncelik).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBekleyenler).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.52174F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.47826F));
            tableLayoutPanel1.Controls.Add(pnlSol, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1920, 1080);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlSol
            // 
            pnlSol.BackColor = Color.Transparent;
            pnlSol.Controls.Add(picOncelik);
            pnlSol.Controls.Add(lblAnaHastaAd);
            pnlSol.Controls.Add(lblAnaSiraNo);
            pnlSol.Dock = DockStyle.Fill;
            pnlSol.Location = new Point(3, 3);
            pnlSol.Name = "pnlSol";
            pnlSol.Size = new Size(1079, 1074);
            pnlSol.TabIndex = 0;
            // 
            // picOncelik
            // 
            picOncelik.Dock = DockStyle.Fill;
            picOncelik.Image = (Image)resources.GetObject("picOncelik.Image");
            picOncelik.Location = new Point(0, 600);
            picOncelik.Name = "picOncelik";
            picOncelik.Size = new Size(1079, 474);
            picOncelik.SizeMode = PictureBoxSizeMode.Zoom;
            picOncelik.TabIndex = 2;
            picOncelik.TabStop = false;
            picOncelik.Visible = false;
            // 
            // lblAnaHastaAd
            // 
            lblAnaHastaAd.Dock = DockStyle.Top;
            lblAnaHastaAd.Font = new Font("Calibri", 79.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAnaHastaAd.Location = new Point(0, 400);
            lblAnaHastaAd.Name = "lblAnaHastaAd";
            lblAnaHastaAd.Size = new Size(1079, 200);
            lblAnaHastaAd.TabIndex = 1;
            lblAnaHastaAd.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblAnaSiraNo
            // 
            lblAnaSiraNo.Dock = DockStyle.Top;
            lblAnaSiraNo.Font = new Font("Arial", 199.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAnaSiraNo.ForeColor = Color.Gold;
            lblAnaSiraNo.Location = new Point(0, 0);
            lblAnaSiraNo.Name = "lblAnaSiraNo";
            lblAnaSiraNo.Size = new Size(1079, 400);
            lblAnaSiraNo.TabIndex = 0;
            lblAnaSiraNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(dataGridViewBekleyenler, 0, 0);
            tableLayoutPanel2.Controls.Add(lblBekleyenSayisi, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(1088, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.Size = new Size(829, 1074);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // dataGridViewBekleyenler
            // 
            dataGridViewBekleyenler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBekleyenler.BackgroundColor = Color.MidnightBlue;
            dataGridViewBekleyenler.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewBekleyenler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewBekleyenler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBekleyenler.ColumnHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewBekleyenler.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewBekleyenler.Dock = DockStyle.Fill;
            dataGridViewBekleyenler.Location = new Point(3, 3);
            dataGridViewBekleyenler.Name = "dataGridViewBekleyenler";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewBekleyenler.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewBekleyenler.RowHeadersVisible = false;
            dataGridViewBekleyenler.RowHeadersWidth = 51;
            dataGridViewBekleyenler.RowTemplate.Height = 60;
            dataGridViewBekleyenler.Size = new Size(823, 906);
            dataGridViewBekleyenler.TabIndex = 0;
            // 
            // lblBekleyenSayisi
            // 
            lblBekleyenSayisi.Dock = DockStyle.Fill;
            lblBekleyenSayisi.Font = new Font("Arial", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBekleyenSayisi.ForeColor = Color.OrangeRed;
            lblBekleyenSayisi.Location = new Point(3, 912);
            lblBekleyenSayisi.Name = "lblBekleyenSayisi";
            lblBekleyenSayisi.Size = new Size(823, 162);
            lblBekleyenSayisi.TabIndex = 1;
            lblBekleyenSayisi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // hastamon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1920, 1080);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "hastamon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            pnlSol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picOncelik).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBekleyenler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlSol;
        private Label lblAnaHastaAd;
        private Label lblAnaSiraNo;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dataGridViewBekleyenler;
        private Label lblBekleyenSayisi;
        private PictureBox picOncelik;
        private System.Windows.Forms.Timer timer1;
    }
}
