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
                    Debug.WriteLine(filePath);
                    Debug.WriteLine("AZZ");
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
                // List<string> res1 = MainProgram.Search_FingerPrint(MainProgram.GetStringToMatch(AsciiInput)[0], kmpRadio.Checked);
                // List<string> res2 = MainProgram.Search_FingerPrint(MainProgram.GetStringToMatch(AsciiInput)[1], kmpRadio.Checked);
                // List<string> res3 = MainProgram.Search_FingerPrint(MainProgram.GetStringToMatch(AsciiInput)[2], kmpRadio.Checked);
                // string filePath;
                // int res1Val = int.Parse(res1[2]);
                // int res2Val = int.Parse(res2[2]);
                // int res3Val = int.Parse(res3[2]);
                // int min = Math.Min(Math.Min(res1Val, res2Val), res3Val);
                // if (res1Val == min) {
                //     filePath = res1[0];
                // } else if (res2Val == min) {
                //     filePath = res2[0];
                // } else {
                //     filePath = res3[0];
                // }
                string filePath = res[0];
                stopwatch.Stop();
                resultPictureBox.Image = Image.FromFile(filePath);
                resultPictureBoxLabel.Text = filePath + res[1] + res[2] + $"\nTime: {stopwatch.Elapsed.TotalMilliseconds} ms";

            }
        }

    }
}
