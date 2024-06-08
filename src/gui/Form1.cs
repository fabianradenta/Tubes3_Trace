using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using ImageProcess;

namespace gui
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
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
                resultPictureBoxLabel.Text = filePath + res[1] + res[2] + $"Time: {stopwatch.Elapsed.TotalMilliseconds} ms";
                timeLabel.Text = $"Time: {stopwatch.Elapsed.TotalMilliseconds} ms";
                persentageLabel.Text = "Percentage: " + res[2] + "%";

            }
        }

        private void uploadedPictureBoxLabel_Click(object sender, EventArgs e)
        {
            uploadedPictureBox_Click(sender, e);
        }
    }
}
