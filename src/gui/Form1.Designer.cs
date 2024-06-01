using System.Windows.Forms;

namespace gui
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            uploadButton = new Button();
            uploadedPictureBox = new PictureBox();
            uploadedPictureBoxLabel = new Label();
            topLabel = new Label();
            resultPictureBox = new PictureBox();
            resultTextBox = new TextBox();
            resultPictureBoxLabel = new Label();
            bmRadio = new RadioButton();
            groupBox1 = new GroupBox();
            kmpRadio = new RadioButton();
            searchButton = new Button();
            timeLabel = new Label();
            persentageLabel = new Label();
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
            // resultTextBox
            // 
            resultTextBox.Location = new Point(861, 85);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(384, 412);
            resultTextBox.TabIndex = 5;
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1282, 603);
            Controls.Add(persentageLabel);
            Controls.Add(timeLabel);
            Controls.Add(searchButton);
            Controls.Add(groupBox1);
            Controls.Add(resultPictureBoxLabel);
            Controls.Add(resultTextBox);
            Controls.Add(resultPictureBox);
            Controls.Add(topLabel);
            Controls.Add(uploadedPictureBoxLabel);
            Controls.Add(uploadedPictureBox);
            Controls.Add(uploadButton);
            Name = "MainForm";
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
        private TextBox resultTextBox;
        private Label resultPictureBoxLabel;
        private RadioButton bmRadio;
        private GroupBox groupBox1;
        private RadioButton kmpRadio;
        private Button searchButton;
        private Label timeLabel;
        private Label persentageLabel;
    }
}
