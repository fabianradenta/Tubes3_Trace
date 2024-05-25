using System.Windows.Forms;

namespace gui
{
    partial class Form1
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
            uploadButton.Location = new Point(74, 385);
            uploadButton.Name = "uploadButton";
            uploadButton.Size = new Size(188, 29);
            uploadButton.TabIndex = 0;
            uploadButton.Text = "Pilih Citra";
            uploadButton.UseVisualStyleBackColor = true;
            uploadButton.Click += uploadButton_Click;
            // 
            // uploadedPictureBox
            // 
            uploadedPictureBox.BackColor = SystemColors.ControlLight;
            uploadedPictureBox.BorderStyle = BorderStyle.FixedSingle;
            uploadedPictureBox.Location = new Point(44, 60);
            uploadedPictureBox.Name = "uploadedPictureBox";
            uploadedPictureBox.Size = new Size(264, 300);
            uploadedPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            uploadedPictureBox.TabIndex = 1;
            uploadedPictureBox.TabStop = false;
            uploadedPictureBox.Click += uploadedPictureBox_Click;
            // 
            // uploadedPictureBoxLabel
            // 
            uploadedPictureBoxLabel.AutoSize = true;
            uploadedPictureBoxLabel.BackColor = SystemColors.ControlLight;
            uploadedPictureBoxLabel.Location = new Point(108, 195);
            uploadedPictureBoxLabel.Name = "uploadedPictureBoxLabel";
            uploadedPictureBoxLabel.Size = new Size(129, 20);
            uploadedPictureBoxLabel.TabIndex = 3;
            uploadedPictureBoxLabel.Text = "Sidik Jari Masukan";
            // 
            // topLabel
            // 
            topLabel.AutoSize = true;
            topLabel.Location = new Point(270, 19);
            topLabel.Name = "topLabel";
            topLabel.Size = new Size(440, 20);
            topLabel.TabIndex = 4;
            topLabel.Text = "Sistem Deteksi Individu Berbasis Biometrik Melalui Citra Sidik Jari";
            // 
            // resultPictureBox
            // 
            resultPictureBox.BackColor = SystemColors.ControlLight;
            resultPictureBox.BorderStyle = BorderStyle.FixedSingle;
            resultPictureBox.Location = new Point(329, 60);
            resultPictureBox.Name = "resultPictureBox";
            resultPictureBox.Size = new Size(264, 300);
            resultPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            resultPictureBox.TabIndex = 4;
            resultPictureBox.TabStop = false;
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(613, 60);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(264, 300);
            resultTextBox.TabIndex = 5;
            // 
            // resultPictureBoxLabel
            // 
            resultPictureBoxLabel.AutoSize = true;
            resultPictureBoxLabel.BackColor = SystemColors.ControlLight;
            resultPictureBoxLabel.Location = new Point(407, 195);
            resultPictureBoxLabel.Name = "resultPictureBoxLabel";
            resultPictureBoxLabel.Size = new Size(112, 20);
            resultPictureBoxLabel.TabIndex = 6;
            resultPictureBoxLabel.Text = "Sidik Jari Cocok";
            // 
            // bmRadio
            // 
            bmRadio.AutoSize = true;
            bmRadio.Location = new Point(17, 26);
            bmRadio.Name = "bmRadio";
            bmRadio.Size = new Size(52, 24);
            bmRadio.TabIndex = 7;
            bmRadio.TabStop = true;
            bmRadio.Text = "BM";
            bmRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(kmpRadio);
            groupBox1.Controls.Add(bmRadio);
            groupBox1.Location = new Point(296, 366);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(155, 57);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Method:";
            // 
            // kmpRadio
            // 
            kmpRadio.AutoSize = true;
            kmpRadio.Location = new Point(85, 26);
            kmpRadio.Name = "kmpRadio";
            kmpRadio.Size = new Size(60, 24);
            kmpRadio.TabIndex = 8;
            kmpRadio.TabStop = true;
            kmpRadio.Text = "KMP";
            kmpRadio.UseVisualStyleBackColor = true;
            kmpRadio.CheckedChanged += kmpRadio_CheckedChanged;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(481, 385);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(112, 29);
            searchButton.TabIndex = 9;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += button1_Click;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(665, 375);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(155, 20);
            timeLabel.TabIndex = 10;
            timeLabel.Text = "Waktu Pencarian: 0 ms";
            // 
            // persentageLabel
            // 
            persentageLabel.AutoSize = true;
            persentageLabel.Location = new Point(665, 399);
            persentageLabel.Name = "persentageLabel";
            persentageLabel.Size = new Size(181, 20);
            persentageLabel.TabIndex = 11;
            persentageLabel.Text = "Persentase Kecocokan: 0%";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 435);
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
