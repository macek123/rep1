namespace PEERTOPEERKOMUNIKACE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonStart = new Button();
            labelTextBox1 = new Label();
            label2 = new Label();
            textBoxMistniIP = new TextBox();
            textBoxMistniPort = new TextBox();
            textBoxCiziPort = new TextBox();
            textBoxCiziIP = new TextBox();
            label1 = new Label();
            label3 = new Label();
            textBoxChat = new TextBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            buttonOdesli = new Button();
            listBox1 = new ListBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonStart.Location = new Point(205, 231);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(112, 39);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // labelTextBox1
            // 
            labelTextBox1.AutoSize = true;
            labelTextBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelTextBox1.Location = new Point(44, 23);
            labelTextBox1.Name = "labelTextBox1";
            labelTextBox1.Size = new Size(99, 30);
            labelTextBox1.TabIndex = 1;
            labelTextBox1.Text = "Místní IP:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(20, 78);
            label2.Name = "label2";
            label2.Size = new Size(118, 30);
            label2.TabIndex = 2;
            label2.Text = "Místní Port:";
            // 
            // textBoxMistniIP
            // 
            textBoxMistniIP.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMistniIP.Location = new Point(160, 23);
            textBoxMistniIP.Name = "textBoxMistniIP";
            textBoxMistniIP.Size = new Size(206, 35);
            textBoxMistniIP.TabIndex = 3;
            // 
            // textBoxMistniPort
            // 
            textBoxMistniPort.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMistniPort.Location = new Point(160, 75);
            textBoxMistniPort.Name = "textBoxMistniPort";
            textBoxMistniPort.Size = new Size(206, 35);
            textBoxMistniPort.TabIndex = 4;
            // 
            // textBoxCiziPort
            // 
            textBoxCiziPort.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCiziPort.Location = new Point(160, 179);
            textBoxCiziPort.Name = "textBoxCiziPort";
            textBoxCiziPort.Size = new Size(206, 35);
            textBoxCiziPort.TabIndex = 8;
            // 
            // textBoxCiziIP
            // 
            textBoxCiziIP.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCiziIP.Location = new Point(160, 128);
            textBoxCiziIP.Name = "textBoxCiziIP";
            textBoxCiziIP.Size = new Size(206, 35);
            textBoxCiziIP.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(44, 182);
            label1.Name = "label1";
            label1.Size = new Size(94, 30);
            label1.TabIndex = 6;
            label1.Text = "Cizí Port:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(63, 131);
            label3.Name = "label3";
            label3.Size = new Size(75, 30);
            label3.TabIndex = 5;
            label3.Text = "Cizí IP:";
            // 
            // textBoxChat
            // 
            textBoxChat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxChat.Location = new Point(81, 344);
            textBoxChat.Name = "textBoxChat";
            textBoxChat.Size = new Size(206, 29);
            textBoxChat.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(400, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(20, 344);
            label4.Name = "label4";
            label4.Size = new Size(55, 25);
            label4.TabIndex = 11;
            label4.Text = "Chat:";
            // 
            // buttonOdesli
            // 
            buttonOdesli.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOdesli.Location = new Point(316, 344);
            buttonOdesli.Name = "buttonOdesli";
            buttonOdesli.Size = new Size(87, 29);
            buttonOdesli.TabIndex = 12;
            buttonOdesli.Text = "Odešli";
            buttonOdesli.UseVisualStyleBackColor = true;
            buttonOdesli.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(81, 396);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(322, 244);
            listBox1.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(-19, 301);
            label5.Name = "label5";
            label5.Size = new Size(562, 15);
            label5.TabIndex = 14;
            label5.Text = "---------------------------------------------------------------------------------------------------------------";
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 710);
            Controls.Add(label5);
            Controls.Add(listBox1);
            Controls.Add(buttonOdesli);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxChat);
            Controls.Add(textBoxCiziPort);
            Controls.Add(textBoxCiziIP);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(textBoxMistniPort);
            Controls.Add(textBoxMistniIP);
            Controls.Add(label2);
            Controls.Add(labelTextBox1);
            Controls.Add(buttonStart);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStart;
        private Label labelTextBox1;
        private Label label2;
        private TextBox textBoxMistniIP;
        private TextBox textBoxMistniPort;
        private TextBox textBoxCiziPort;
        private TextBox textBoxCiziIP;
        private Label label1;
        private Label label3;
        private TextBox textBoxChat;
        private PictureBox pictureBox1;
        private Label label4;
        private Button buttonOdesli;
        private ListBox listBox1;
        private Label label5;
    }
}