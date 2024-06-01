using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using ImageProcess;

namespace gui
{
    public partial class MainForm : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        public MainForm()
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
            if (bmRadio.Checked)
            {
                // Run BM algorithm
                Debug.WriteLine("BM algorithm runned");
                Console.WriteLine("yoo");
            }
            else if (kmpRadio.Checked)
            {
                // Run KMP 
                string imagePath = openFileDialog.FileName;
                List<string> AsciiInput = ImageToString.IntToString(ImageToString.ConvertToBinaryImage(imagePath));
                List<string> res = MainProgram.Search_FingerPrint(MainProgram.GetStringToMatch(AsciiInput));
                string filePath = res[0];
                resultPictureBox.Image = Image.FromFile(filePath);
                resultPictureBoxLabel.Text = filePath + res[1];
            }
        }

        private void uploadedPictureBoxLabel_Click(object sender, EventArgs e)
        {
            uploadedPictureBox_Click(sender, e);
        }
    }
}
