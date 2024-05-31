using System.Diagnostics;
using System.Windows.Forms;

namespace gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
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
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
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
            }
            else if (kmpRadio.Checked)
            {
                // Run KMP algorithm
                Debug.WriteLine("KMP algorithm runned");
            }
        }

    }
}
