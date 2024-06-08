using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using ImageProcess;
using database;

namespace gui
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        private Database db = new Database();
        public Form1()
        {
            InitializeComponent();
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            using (openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog.Filter = "Images files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg;*.png;*.bmp;*.jpeg|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of specified file
                    string filePath = openFileDialog.FileName;

                    uploadedPictureBox.Image = Image.FromFile(filePath);
                    uploadedPictureBoxLabel.Visible = false;
                }
            }
        }

        private void uploadedPictureBox_Click(object sender, EventArgs e)
        {
            using (openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog.Filter = "Images files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg;*.png;*.bmp;*.jpeg|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of specified file
                    string filePath = openFileDialog.FileName;
                    uploadedPictureBox.Image = Image.FromFile(filePath);
                    uploadedPictureBoxLabel.Visible = false;
                }
            }
        }

        private void bmRadio_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void kmpRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bmRadio.Checked || kmpRadio.Checked)
            {
                // Run KMP 
                string imagePath = openFileDialog.FileName;
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                List<string> AsciiInput = ImageToString.IntToString(ImageToString.ConvertToBinaryImage(imagePath));
                List<string> res = MainProgram.Search_FingerPrint(AsciiInput, kmpRadio.Checked);
                string filePath = res[0];
                stopwatch.Stop();
                resultPictureBox.Image = Image.FromFile(filePath);
                resultPictureBoxLabel.Visible = false;
                db.connect();
                string name = db.getNameFromSidikJari(filePath);
                Biodata result = db.getBiodataFromName(name);
                timeLabel.Text = $"Time: {stopwatch.Elapsed.TotalMilliseconds} ms";
                persentageLabel.Text = "Percentage: " + res[2] + "%";
                nikLabel.Text = $"NIK: {result.nik}";
                namaLabel.Text = $"Nama: {result.nama}";
                tempatLahirLabel.Text = $"Tempat Lahir: {result.tempat_lahir}";
                tanggalLahirLabel.Text = $"Tanggal Lahir: {result.tanggal_lahir}";
                jenisKelaminLabel.Text = $"Jenis Kelamin: {result.jenis_kelamin}";
                golonganDarahLabel.Text = $"Golongan Darah: {result.golongan_darah}";
                alamatLabel.Text = $"Alamat: {result.alamat}";
                agamaLabel.Text = $"Agama: {result.agama}";
                statusPerkawinanLabel.Text = $"Status Perkawinan: {result.status}";
                pekerjaanLabel.Text = $"Pekerjaan: {result.pekerjaan}";
                kewarganegaraanLabel.Text = $"Kewarganegaraan: {result.kewarganegaraan}";
            }
        }

        private void uploadedPictureBoxLabel_Click(object sender, EventArgs e)
        {
            uploadedPictureBox_Click(sender, e);
        }
    }
}
