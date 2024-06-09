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
                openFileDialog.InitialDirectory = Path.GetFullPath("../../test/");
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
                openFileDialog.InitialDirectory = Path.GetFullPath("../../test/");
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
                // Run 
                string imagePath = openFileDialog.FileName;
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                List<string> AsciiInput = ImageToString.IntToString(ImageToString.ConvertToBinaryImage(imagePath));
                List<string> res = MainProgram.Search_FingerPrint(AsciiInput, kmpRadio.Checked);
                string filePath = res[0];
                string state = res[1];
                stopwatch.Stop();
                persentageLabel.Text = "Percentage: " + res[2] + "%";
                timeLabel.Text = $"Time: {stopwatch.Elapsed.TotalMilliseconds} ms";
                if (state != "-1") {
                    resultPictureBox.Image = Image.FromFile(filePath);
                    resultPictureBoxLabel.Visible = false;
                    db.connect();
                    string name = db.getNameFromSidikJari(filePath);
                    Biodata result = db.getBiodataFromName(name);
                    resultTextBox.Clear();
                    AppendTextWithColor(resultTextBox, "", Color.White);
                    AppendTextWithColor(resultTextBox, "NIK: ", Color.Red);
                    AppendTextWithColor(resultTextBox, $"{result.nik}\n", Color.Black);
                    AppendTextWithColor(resultTextBox, "Nama: ", Color.Red);
                    AppendTextWithColor(resultTextBox, $"{result.nama}\n", Color.Black);
                    AppendTextWithColor(resultTextBox, "Tempat Lahir: ", Color.Red);
                    AppendTextWithColor(resultTextBox, $"{result.tempat_lahir}\n", Color.Black);
                    AppendTextWithColor(resultTextBox, "Tanggal Lahir: ", Color.Red);
                    AppendTextWithColor(resultTextBox, $"{result.tanggal_lahir}\n", Color.Black);
                    AppendTextWithColor(resultTextBox, "Jenis Kelamin: ", Color.Red);
                    AppendTextWithColor(resultTextBox, $"{result.jenis_kelamin}\n", Color.Black);
                    AppendTextWithColor(resultTextBox, "Golongan Darah: ", Color.Red);
                    AppendTextWithColor(resultTextBox, $"{result.golongan_darah}\n", Color.Black);
                    AppendTextWithColor(resultTextBox, "Alamat: ", Color.Red);
                    AppendTextWithColor(resultTextBox, $"{result.alamat}\n", Color.Black);
                    AppendTextWithColor(resultTextBox, "Agama: ", Color.Red);
                    AppendTextWithColor(resultTextBox, $"{result.agama}\n", Color.Black);
                    AppendTextWithColor(resultTextBox, "Status Perkawinan: ", Color.Red);
                    AppendTextWithColor(resultTextBox, $"{result.status}\n", Color.Black);
                    AppendTextWithColor(resultTextBox, "Pekerjaan: ", Color.Red);
                    AppendTextWithColor(resultTextBox, $"{result.pekerjaan}\n", Color.Black);
                    AppendTextWithColor(resultTextBox, "Kewarganegaraan: ", Color.Red);
                    AppendTextWithColor(resultTextBox, $"{result.kewarganegaraan}\n", Color.Black);
                } else {
                    resultPictureBoxLabel.Visible = false;
                    AppendTextWithColor(resultTextBox, "", Color.White);
                    AppendTextWithColor(resultTextBox, "Gambar sidik jari tidak ketemu", Color.Red);
                }
            }
        }

        private void uploadedPictureBoxLabel_Click(object sender, EventArgs e)
        {
            uploadedPictureBox_Click(sender, e);
        }

        private void AppendTextWithColor(RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}
