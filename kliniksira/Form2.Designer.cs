namespace kliniksira
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            dgvBekleyenler = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            lblAktifHasta = new Label();
            btnCagir = new Button();
            btnBitir = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBekleyenler).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(dgvBekleyenler);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 453);
            panel1.TabIndex = 0;
            // 
            // dgvBekleyenler
            // 
            dgvBekleyenler.BackgroundColor = Color.White;
            dgvBekleyenler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBekleyenler.Dock = DockStyle.Bottom;
            dgvBekleyenler.Location = new Point(0, 197);
            dgvBekleyenler.Name = "dgvBekleyenler";
            dgvBekleyenler.ReadOnly = true;
            dgvBekleyenler.RowHeadersWidth = 51;
            dgvBekleyenler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBekleyenler.Size = new Size(500, 256);
            dgvBekleyenler.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(104, 9);
            label1.Name = "label1";
            label1.Size = new Size(253, 28);
            label1.TabIndex = 0;
            label1.Text = "BEKLEYEN HASTA LİSTESİ";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(525, 7);
            label2.Name = "label2";
            label2.Size = new Size(283, 36);
            label2.TabIndex = 1;
            label2.Text = "ŞU AN İÇERİDEKİ HASTA";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblAktifHasta
            // 
            lblAktifHasta.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAktifHasta.ForeColor = Color.DarkBlue;
            lblAktifHasta.Location = new Point(547, 56);
            lblAktifHasta.Name = "lblAktifHasta";
            lblAktifHasta.Size = new Size(246, 227);
            lblAktifHasta.TabIndex = 2;
            lblAktifHasta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCagir
            // 
            btnCagir.BackColor = Color.FromArgb(0, 120, 215);
            btnCagir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCagir.ForeColor = Color.White;
            btnCagir.Location = new Point(520, 381);
            btnCagir.Name = "btnCagir";
            btnCagir.Size = new Size(300, 60);
            btnCagir.TabIndex = 3;
            btnCagir.Text = "SIRADAKİ HASTAYI ÇAĞIR";
            btnCagir.UseVisualStyleBackColor = false;
            btnCagir.Click += btnCagir_Click;
            // 
            // btnBitir
            // 
            btnBitir.BackColor = Color.FromArgb(220, 53, 69);
            btnBitir.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnBitir.ForeColor = Color.White;
            btnBitir.Location = new Point(520, 319);
            btnBitir.Name = "btnBitir";
            btnBitir.Size = new Size(300, 45);
            btnBitir.TabIndex = 4;
            btnBitir.Text = "MUAYENE TAMAMLANDI";
            btnBitir.UseVisualStyleBackColor = false;
            btnBitir.Click += btnBitir_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 453);
            Controls.Add(btnBitir);
            Controls.Add(btnCagir);
            Controls.Add(lblAktifHasta);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doktor Paneli";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBekleyenler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dgvBekleyenler;
        private Label label2;
        private Label lblAktifHasta;
        private Button btnCagir;
        private Button btnBitir;
        private System.Windows.Forms.Timer timer1;
    }
}