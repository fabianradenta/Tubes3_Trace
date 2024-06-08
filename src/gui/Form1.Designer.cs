using System.Windows.Forms;

namespace gui
{
    partial class Form1 : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            uploadButton = new Button();
            uploadedPictureBox = new PictureBox();
            uploadedPictureBoxLabel = new Label();
            topLabel = new Label();
            resultPictureBox = new PictureBox();
            resultPictureBoxLabel = new Label();
            bmRadio = new RadioButton();
            groupBox1 = new GroupBox();
            kmpRadio = new RadioButton();
            searchButton = new Button();
            timeLabel = new Label();
            persentageLabel = new Label();
            biodataLabel = new Label();
            nikLabel = new Label();
            namaLabel = new Label();
            tempatLahirLabel = new Label();
            tanggalLahirLabel = new Label();
            jenisKelaminLabel = new Label();
            golonganDarahLabel = new Label();
            alamatLabel = new Label();
            agamaLabel = new Label();
            statusPerkawinanLabel = new Label();
            pekerjaanLabel = new Label();
            kewarganegaraanLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)uploadedPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resultPictureBox).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // uploadButton
            // 
            uploadButton.BackColor = SystemColors.Control;
            uploadButton.Image = (Image)resources.GetObject("uploadButton.Image");
            uploadButton.Location = new Point(129, 524);
            uploadButton.Name = "uploadButton";
            uploadButton.Size = new Size(188, 48);
            uploadButton.TabIndex = 0;
            uploadButton.UseVisualStyleBackColor = false;
            uploadButton.Click += uploadButton_Click;
            // 
            // uploadedPictureBox
            // 
            uploadedPictureBox.BackColor = Color.White;
            uploadedPictureBox.BorderStyle = BorderStyle.FixedSingle;
            uploadedPictureBox.Location = new Point(33, 85);
            uploadedPictureBox.Name = "uploadedPictureBox";
            uploadedPictureBox.Size = new Size(384, 412);
            uploadedPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            uploadedPictureBox.TabIndex = 1;
            uploadedPictureBox.TabStop = false;
            uploadedPictureBox.Click += uploadedPictureBox_Click;
            // 
            // uploadedPictureBoxLabel
            // 
            uploadedPictureBoxLabel.AutoSize = true;
            uploadedPictureBoxLabel.BackColor = Color.White;
            uploadedPictureBoxLabel.Font = new Font("League Spartan ExtraBold", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uploadedPictureBoxLabel.ForeColor = Color.DarkGray;
            uploadedPictureBoxLabel.Location = new Point(77, 260);
            uploadedPictureBoxLabel.Name = "uploadedPictureBoxLabel";
            uploadedPictureBoxLabel.Size = new Size(306, 49);
            uploadedPictureBoxLabel.TabIndex = 3;
            uploadedPictureBoxLabel.Text = "Sidik Jari Masukan";
            uploadedPictureBoxLabel.Click += uploadedPictureBoxLabel_Click;
            // 
            // topLabel
            // 
            topLabel.AutoSize = true;
            topLabel.BackColor = Color.Transparent;
            topLabel.Font = new Font("League Spartan ExtraBold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            topLabel.ForeColor = Color.White;
            topLabel.Location = new Point(143, 20);
            topLabel.Name = "topLabel";
            topLabel.Size = new Size(1022, 50);
            topLabel.TabIndex = 4;
            topLabel.Text = "Sistem Deteksi Individu Berbasis Biometrik Melalui Citra Sidik Jari";
            // 
            // resultPictureBox
            // 
            resultPictureBox.BackColor = Color.White;
            resultPictureBox.BorderStyle = BorderStyle.FixedSingle;
            resultPictureBox.Location = new Point(448, 85);
            resultPictureBox.Name = "resultPictureBox";
            resultPictureBox.Size = new Size(384, 412);
            resultPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            resultPictureBox.TabIndex = 4;
            resultPictureBox.TabStop = false;
            // 
            // resultPictureBoxLabel
            // 
            resultPictureBoxLabel.AutoSize = true;
            resultPictureBoxLabel.BackColor = Color.White;
            resultPictureBoxLabel.Font = new Font("League Spartan ExtraBold", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultPictureBoxLabel.ForeColor = Color.DarkGray;
            resultPictureBoxLabel.Location = new Point(517, 260);
            resultPictureBoxLabel.Name = "resultPictureBoxLabel";
            resultPictureBoxLabel.Size = new Size(257, 49);
            resultPictureBoxLabel.TabIndex = 6;
            resultPictureBoxLabel.Text = "Sidik Jari Cocok";
            // 
            // bmRadio
            // 
            bmRadio.AutoSize = true;
            bmRadio.Font = new Font("League Spartan ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bmRadio.ForeColor = Color.White;
            bmRadio.Location = new Point(15, 23);
            bmRadio.Name = "bmRadio";
            bmRadio.Size = new Size(62, 34);
            bmRadio.TabIndex = 7;
            bmRadio.TabStop = true;
            bmRadio.Text = "BM";
            bmRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(kmpRadio);
            groupBox1.Controls.Add(bmRadio);
            groupBox1.Font = new Font("League Spartan ExtraBold", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(386, 515);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(197, 57);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Method:";
            // 
            // kmpRadio
            // 
            kmpRadio.AutoSize = true;
            kmpRadio.Font = new Font("League Spartan ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kmpRadio.ForeColor = Color.White;
            kmpRadio.Location = new Point(117, 23);
            kmpRadio.Name = "kmpRadio";
            kmpRadio.Size = new Size(74, 34);
            kmpRadio.TabIndex = 8;
            kmpRadio.TabStop = true;
            kmpRadio.Text = "KMP";
            kmpRadio.UseVisualStyleBackColor = true;
            kmpRadio.CheckedChanged += kmpRadio_CheckedChanged;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.White;
            searchButton.Font = new Font("League Spartan ExtraBold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchButton.ForeColor = Color.White;
            searchButton.Image = (Image)resources.GetObject("searchButton.Image");
            searchButton.Location = new Point(644, 524);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(188, 48);
            searchButton.TabIndex = 9;
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += button1_Click;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.BackColor = Color.Transparent;
            timeLabel.Font = new Font("League Spartan ExtraBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timeLabel.ForeColor = Color.White;
            timeLabel.Location = new Point(861, 512);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(254, 35);
            timeLabel.TabIndex = 10;
            timeLabel.Text = "Waktu Pencarian: 0 ms";
            // 
            // persentageLabel
            // 
            persentageLabel.AutoSize = true;
            persentageLabel.BackColor = Color.Transparent;
            persentageLabel.Font = new Font("League Spartan ExtraBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            persentageLabel.ForeColor = Color.White;
            persentageLabel.Location = new Point(861, 547);
            persentageLabel.Name = "persentageLabel";
            persentageLabel.Size = new Size(288, 35);
            persentageLabel.TabIndex = 11;
            persentageLabel.Text = "Persentase Kecocokan: 0%";
            // 
            // biodataLabel
            // 
            biodataLabel.AutoSize = true;
            biodataLabel.BackColor = Color.Transparent;
            biodataLabel.Font = new Font("League Spartan ExtraBold", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            biodataLabel.ForeColor = Color.White;
            biodataLabel.Location = new Point(1005, 85);
            biodataLabel.Name = "biodataLabel";
            biodataLabel.Size = new Size(110, 40);
            biodataLabel.TabIndex = 12;
            biodataLabel.Text = "Biodata";
            // 
            // nikLabel
            // 
            nikLabel.AutoSize = true;
            nikLabel.BackColor = Color.Transparent;
            nikLabel.Font = new Font("League Spartan ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nikLabel.ForeColor = Color.White;
            nikLabel.Location = new Point(861, 135);
            nikLabel.Name = "nikLabel";
            nikLabel.Size = new Size(57, 30);
            nikLabel.TabIndex = 13;
            nikLabel.Text = "NIK: ";
            // 
            // namaLabel
            // 
            namaLabel.AutoSize = true;
            namaLabel.BackColor = Color.Transparent;
            namaLabel.Font = new Font("League Spartan ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            namaLabel.ForeColor = Color.White;
            namaLabel.Location = new Point(861, 165);
            namaLabel.Name = "namaLabel";
            namaLabel.Size = new Size(80, 30);
            namaLabel.TabIndex = 14;
            namaLabel.Text = "Nama: ";
            // 
            // tempatLahirLabel
            // 
            tempatLahirLabel.AutoSize = true;
            tempatLahirLabel.BackColor = Color.Transparent;
            tempatLahirLabel.Font = new Font("League Spartan ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tempatLahirLabel.ForeColor = Color.White;
            tempatLahirLabel.Location = new Point(861, 195);
            tempatLahirLabel.Name = "tempatLahirLabel";
            tempatLahirLabel.Size = new Size(142, 30);
            tempatLahirLabel.TabIndex = 15;
            tempatLahirLabel.Text = "Tempat Lahir: ";
            // 
            // tanggalLahirLabel
            // 
            tanggalLahirLabel.AutoSize = true;
            tanggalLahirLabel.BackColor = Color.Transparent;
            tanggalLahirLabel.Font = new Font("League Spartan ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tanggalLahirLabel.ForeColor = Color.White;
            tanggalLahirLabel.Location = new Point(861, 225);
            tanggalLahirLabel.Name = "tanggalLahirLabel";
            tanggalLahirLabel.Size = new Size(147, 30);
            tanggalLahirLabel.TabIndex = 16;
            tanggalLahirLabel.Text = "Tanggal Lahir: ";
            // 
            // jenisKelaminLabel
            // 
            jenisKelaminLabel.AutoSize = true;
            jenisKelaminLabel.BackColor = Color.Transparent;
            jenisKelaminLabel.Font = new Font("League Spartan ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            jenisKelaminLabel.ForeColor = Color.White;
            jenisKelaminLabel.Location = new Point(861, 255);
            jenisKelaminLabel.Name = "jenisKelaminLabel";
            jenisKelaminLabel.Size = new Size(143, 30);
            jenisKelaminLabel.TabIndex = 17;
            jenisKelaminLabel.Text = "Jenis Kelamin: ";
            // 
            // golonganDarahLabel
            // 
            golonganDarahLabel.AutoSize = true;
            golonganDarahLabel.BackColor = Color.Transparent;
            golonganDarahLabel.Font = new Font("League Spartan ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            golonganDarahLabel.ForeColor = Color.White;
            golonganDarahLabel.Location = new Point(861, 288);
            golonganDarahLabel.Name = "golonganDarahLabel";
            golonganDarahLabel.Size = new Size(170, 30);
            golonganDarahLabel.TabIndex = 18;
            golonganDarahLabel.Text = "Golongan Darah: ";
            // 
            // alamatLabel
            // 
            alamatLabel.AutoSize = true;
            alamatLabel.BackColor = Color.Transparent;
            alamatLabel.Font = new Font("League Spartan ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            alamatLabel.ForeColor = Color.White;
            alamatLabel.Location = new Point(861, 318);
            alamatLabel.Name = "alamatLabel";
            alamatLabel.Size = new Size(92, 30);
            alamatLabel.TabIndex = 19;
            alamatLabel.Text = "Alamat: ";
            // 
            // agamaLabel
            // 
            agamaLabel.AutoSize = true;
            agamaLabel.BackColor = Color.Transparent;
            agamaLabel.Font = new Font("League Spartan ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            agamaLabel.ForeColor = Color.White;
            agamaLabel.Location = new Point(861, 348);
            agamaLabel.Name = "agamaLabel";
            agamaLabel.Size = new Size(91, 30);
            agamaLabel.TabIndex = 20;
            agamaLabel.Text = "Agama: ";
            // 
            // statusPerkawinanLabel
            // 
            statusPerkawinanLabel.AutoSize = true;
            statusPerkawinanLabel.BackColor = Color.Transparent;
            statusPerkawinanLabel.Font = new Font("League Spartan ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statusPerkawinanLabel.ForeColor = Color.White;
            statusPerkawinanLabel.Location = new Point(861, 378);
            statusPerkawinanLabel.Name = "statusPerkawinanLabel";
            statusPerkawinanLabel.Size = new Size(193, 30);
            statusPerkawinanLabel.TabIndex = 21;
            statusPerkawinanLabel.Text = "Status Perkawinan: ";
            // 
            // pekerjaanLabel
            // 
            pekerjaanLabel.AutoSize = true;
            pekerjaanLabel.BackColor = Color.Transparent;
            pekerjaanLabel.Font = new Font("League Spartan ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pekerjaanLabel.ForeColor = Color.White;
            pekerjaanLabel.Location = new Point(861, 408);
            pekerjaanLabel.Name = "pekerjaanLabel";
            pekerjaanLabel.Size = new Size(114, 30);
            pekerjaanLabel.TabIndex = 22;
            pekerjaanLabel.Text = "Pekerjaan: ";
            // 
            // kewarganegaraanLabel
            // 
            kewarganegaraanLabel.AutoSize = true;
            kewarganegaraanLabel.BackColor = Color.Transparent;
            kewarganegaraanLabel.Font = new Font("League Spartan ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kewarganegaraanLabel.ForeColor = Color.White;
            kewarganegaraanLabel.Location = new Point(861, 438);
            kewarganegaraanLabel.Name = "kewarganegaraanLabel";
            kewarganegaraanLabel.Size = new Size(192, 30);
            kewarganegaraanLabel.TabIndex = 23;
            kewarganegaraanLabel.Text = "Kewarganegaraan: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1282, 603);
            Controls.Add(kewarganegaraanLabel);
            Controls.Add(pekerjaanLabel);
            Controls.Add(statusPerkawinanLabel);
            Controls.Add(agamaLabel);
            Controls.Add(alamatLabel);
            Controls.Add(golonganDarahLabel);
            Controls.Add(jenisKelaminLabel);
            Controls.Add(tanggalLahirLabel);
            Controls.Add(tempatLahirLabel);
            Controls.Add(namaLabel);
            Controls.Add(nikLabel);
            Controls.Add(biodataLabel);
            Controls.Add(persentageLabel);
            Controls.Add(timeLabel);
            Controls.Add(searchButton);
            Controls.Add(groupBox1);
            Controls.Add(resultPictureBoxLabel);
            Controls.Add(resultPictureBox);
            Controls.Add(topLabel);
            Controls.Add(uploadedPictureBoxLabel);
            Controls.Add(uploadedPictureBox);
            Controls.Add(uploadButton);
            Name = "Form1";
            Text = "Trace";
            ((System.ComponentModel.ISupportInitialize)uploadedPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)resultPictureBox).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button uploadButton;
        private PictureBox uploadedPictureBox;
        private Label uploadedPictureBoxLabel;
        private Label topLabel;
        private PictureBox resultPictureBox;
        private Label resultPictureBoxLabel;
        private RadioButton bmRadio;
        private GroupBox groupBox1;
        private RadioButton kmpRadio;
        private Button searchButton;
        private Label timeLabel;
        private Label persentageLabel;
        private Label biodataLabel;
        private Label nikLabel;
        private Label namaLabel;
        private Label tempatLahirLabel;
        private Label tanggalLahirLabel;
        private Label jenisKelaminLabel;
        private Label golonganDarahLabel;
        private Label alamatLabel;
        private Label agamaLabel;
        private Label statusPerkawinanLabel;
        private Label pekerjaanLabel;
        private Label kewarganegaraanLabel;
    }
}
