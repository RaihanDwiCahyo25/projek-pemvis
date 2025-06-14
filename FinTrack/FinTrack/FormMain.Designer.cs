namespace FinTrack
{
    partial class FormMain
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
            panelHeader = new Panel();
            btnLogout = new Button();
            label1 = new Label();
            btnReset = new Button();
            dgvTransaksi = new DataGridView();
            grpFilter = new GroupBox();
            txtKeyword = new TextBox();
            btnFilter = new Button();
            cmbFilterJenis = new ComboBox();
            btnCetak = new Button();
            grpAksi = new GroupBox();
            btnHapus = new Button();
            btnEdit = new Button();
            grpInput = new GroupBox();
            btnSimpan = new Button();
            label3 = new Label();
            lblDeskripsi = new Label();
            label5 = new Label();
            lblKategori = new Label();
            lblJumlah = new Label();
            cmbJenis = new ComboBox();
            txtDeskripsi = new TextBox();
            cmbKategori = new ComboBox();
            dtpTanggal = new DateTimePicker();
            txtJumlah = new TextBox();
            lblHalaman = new Label();
            btnPrev = new Button();
            btnNext = new Button();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaksi).BeginInit();
            grpFilter.SuspendLayout();
            grpAksi.SuspendLayout();
            grpInput.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(btnLogout);
            panelHeader.Controls.Add(label1);
            panelHeader.Location = new Point(14, 1);
            panelHeader.Margin = new Padding(3, 4, 3, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(992, 64);
            panelHeader.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(424, 24);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(86, 31);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(406, 0);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 0;
            label1.Text = "Welcome to FinTrack";
            label1.Click += label1_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(472, 19);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(86, 31);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // dgvTransaksi
            // 
            dgvTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransaksi.Location = new Point(441, 137);
            dgvTransaksi.Margin = new Padding(3, 4, 3, 4);
            dgvTransaksi.Name = "dgvTransaksi";
            dgvTransaksi.RowHeadersWidth = 51;
            dgvTransaksi.Size = new Size(568, 368);
            dgvTransaksi.TabIndex = 8;
            dgvTransaksi.CellClick += dgvTransaksi_CellClick;
            dgvTransaksi.CellContentClick += dataGridView1_CellContentClick;
            // 
            // grpFilter
            // 
            grpFilter.Controls.Add(txtKeyword);
            grpFilter.Controls.Add(btnFilter);
            grpFilter.Controls.Add(cmbFilterJenis);
            grpFilter.Controls.Add(btnReset);
            grpFilter.Location = new Point(441, 73);
            grpFilter.Margin = new Padding(3, 4, 3, 4);
            grpFilter.Name = "grpFilter";
            grpFilter.Padding = new Padding(3, 4, 3, 4);
            grpFilter.Size = new Size(565, 57);
            grpFilter.TabIndex = 9;
            grpFilter.TabStop = false;
            grpFilter.Text = "Filter";
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(6, 22);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.PlaceholderText = "cari deskripsi/kategori";
            txtKeyword.Size = new Size(278, 27);
            txtKeyword.TabIndex = 15;
            txtKeyword.TextChanged += txtKeyword_TextChanged;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(379, 19);
            btnFilter.Margin = new Padding(3, 4, 3, 4);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(86, 31);
            btnFilter.TabIndex = 14;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // cmbFilterJenis
            // 
            cmbFilterJenis.FormattingEnabled = true;
            cmbFilterJenis.Location = new Point(290, 21);
            cmbFilterJenis.Margin = new Padding(3, 4, 3, 4);
            cmbFilterJenis.Name = "cmbFilterJenis";
            cmbFilterJenis.Size = new Size(83, 28);
            cmbFilterJenis.TabIndex = 13;
            // 
            // btnCetak
            // 
            btnCetak.Location = new Point(17, 144);
            btnCetak.Margin = new Padding(3, 4, 3, 4);
            btnCetak.Name = "btnCetak";
            btnCetak.Size = new Size(86, 31);
            btnCetak.TabIndex = 10;
            btnCetak.Text = "Cetak";
            btnCetak.UseVisualStyleBackColor = true;
            btnCetak.Click += btnCetak_Click;
            // 
            // grpAksi
            // 
            grpAksi.Controls.Add(btnHapus);
            grpAksi.Controls.Add(btnEdit);
            grpAksi.Controls.Add(btnCetak);
            grpAksi.Location = new Point(321, 132);
            grpAksi.Margin = new Padding(3, 4, 3, 4);
            grpAksi.Name = "grpAksi";
            grpAksi.Padding = new Padding(3, 4, 3, 4);
            grpAksi.Size = new Size(113, 217);
            grpAksi.TabIndex = 11;
            grpAksi.TabStop = false;
            grpAksi.Text = "Aksi";
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(17, 87);
            btnHapus.Margin = new Padding(3, 4, 3, 4);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(86, 31);
            btnHapus.TabIndex = 12;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(17, 36);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(86, 31);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "Ubah";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // grpInput
            // 
            grpInput.Controls.Add(btnSimpan);
            grpInput.Controls.Add(label3);
            grpInput.Controls.Add(lblDeskripsi);
            grpInput.Controls.Add(label5);
            grpInput.Controls.Add(lblKategori);
            grpInput.Controls.Add(lblJumlah);
            grpInput.Controls.Add(cmbJenis);
            grpInput.Controls.Add(txtDeskripsi);
            grpInput.Controls.Add(cmbKategori);
            grpInput.Controls.Add(dtpTanggal);
            grpInput.Controls.Add(txtJumlah);
            grpInput.Location = new Point(14, 132);
            grpInput.Margin = new Padding(3, 4, 3, 4);
            grpInput.Name = "grpInput";
            grpInput.Padding = new Padding(3, 4, 3, 4);
            grpInput.Size = new Size(281, 311);
            grpInput.TabIndex = 14;
            grpInput.TabStop = false;
            grpInput.Text = "Input";
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(95, 253);
            btnSimpan.Margin = new Padding(3, 4, 3, 4);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(86, 31);
            btnSimpan.TabIndex = 20;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 75);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 19;
            label3.Text = "Jenis";
            // 
            // lblDeskripsi
            // 
            lblDeskripsi.AutoSize = true;
            lblDeskripsi.Location = new Point(51, 191);
            lblDeskripsi.Name = "lblDeskripsi";
            lblDeskripsi.Size = new Size(69, 20);
            lblDeskripsi.TabIndex = 18;
            lblDeskripsi.Text = "Deskripsi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 113);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 17;
            label5.Text = "Tanggal";
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(51, 152);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(66, 20);
            lblKategori.TabIndex = 16;
            lblKategori.Text = "Kategori";
            lblKategori.Click += lblKategori_Click;
            // 
            // lblJumlah
            // 
            lblJumlah.AutoSize = true;
            lblJumlah.Location = new Point(51, 36);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(55, 20);
            lblJumlah.TabIndex = 15;
            lblJumlah.Text = "Jumlah";
            // 
            // cmbJenis
            // 
            cmbJenis.FormattingEnabled = true;
            cmbJenis.Location = new Point(120, 71);
            cmbJenis.Margin = new Padding(3, 4, 3, 4);
            cmbJenis.Name = "cmbJenis";
            cmbJenis.Size = new Size(141, 28);
            cmbJenis.TabIndex = 9;
            cmbJenis.Text = "Pilih Jenis";
            cmbJenis.SelectedIndexChanged += cmbJenis_SelectedIndexChanged;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(120, 187);
            txtDeskripsi.Margin = new Padding(3, 4, 3, 4);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(141, 57);
            txtDeskripsi.TabIndex = 8;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(120, 148);
            cmbKategori.Margin = new Padding(3, 4, 3, 4);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(141, 28);
            cmbKategori.TabIndex = 7;
            cmbKategori.Text = "Pilih Kategori";
            // 
            // dtpTanggal
            // 
            dtpTanggal.Location = new Point(120, 109);
            dtpTanggal.Margin = new Padding(3, 4, 3, 4);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(141, 27);
            dtpTanggal.TabIndex = 6;
            // 
            // txtJumlah
            // 
            txtJumlah.Location = new Point(120, 29);
            txtJumlah.Margin = new Padding(3, 4, 3, 4);
            txtJumlah.Name = "txtJumlah";
            txtJumlah.Size = new Size(141, 27);
            txtJumlah.TabIndex = 0;
            // 
            // lblHalaman
            // 
            lblHalaman.AutoSize = true;
            lblHalaman.Location = new Point(667, 518);
            lblHalaman.Name = "lblHalaman";
            lblHalaman.Size = new Size(123, 20);
            lblHalaman.TabIndex = 15;
            lblHalaman.Text = "Halaman 1 dari 1";
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(447, 518);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(94, 29);
            btnPrev.TabIndex = 16;
            btnPrev.Text = "Prev";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(905, 518);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 17;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 600);
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            Controls.Add(lblHalaman);
            Controls.Add(grpInput);
            Controls.Add(grpAksi);
            Controls.Add(grpFilter);
            Controls.Add(dgvTransaksi);
            Controls.Add(panelHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            Text = "FormMain";
            Load += FormMain_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaksi).EndInit();
            grpFilter.ResumeLayout(false);
            grpFilter.PerformLayout();
            grpAksi.ResumeLayout(false);
            grpInput.ResumeLayout(false);
            grpInput.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHeader;
        private Label label1;
        private Button btnLogout;
        private Button btnReset;
        private DataGridView dgvTransaksi;
        private GroupBox grpFilter;
        private Button btnCetak;
        private GroupBox grpAksi;
        private Button btnEdit;
        private Button btnHapus;
        private GroupBox grpInput;
        private TextBox txtDeskripsi;
        private ComboBox cmbKategori;
        private DateTimePicker dtpTanggal;
        private TextBox txtJumlah;
        private ComboBox cmbJenis;
        private Label lblDeskripsi;
        private Label label5;
        private Label lblKategori;
        private Label lblJumlah;
        private Label label3;
        private Button btnSimpan;
        private ComboBox cmbFilterJenis;
        private Button btnFilter;
        private TextBox txtKeyword;
        private Label lblHalaman;
        private Button btnPrev;
        private Button btnNext;
    }
}