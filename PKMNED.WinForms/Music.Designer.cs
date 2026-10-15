namespace PKMNED.WinForms
{
    partial class Music
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            var bg = System.Drawing.Color.FromArgb(15, 23, 42);
            var surface = System.Drawing.Color.FromArgb(30, 41, 59);
            var surface2 = System.Drawing.Color.FromArgb(36, 50, 73);
            var accent = System.Drawing.Color.FromArgb(56, 189, 248);
            var text = System.Drawing.Color.FromArgb(226, 232, 240);
            var muted = System.Drawing.Color.FromArgb(148, 163, 184);
            var font = new System.Drawing.Font("Segoe UI", 10F);
            var title = new System.Drawing.Font("Segoe UI Semibold", 11F);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Music));
            button1 = new System.Windows.Forms.Button();
            listBox1 = new System.Windows.Forms.ListBox();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(12, 235);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(267, 50);
            button1.TabIndex = 1;
            button1.Text = "Select audio and music from the ROM";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.BackColor = System.Drawing.Color.Transparent;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.FlatAppearance.BorderColor = accent;
            button1.ForeColor = accent;
            button1.Font = font;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new System.Drawing.Point(302, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(296 + 54, 550);
            listBox1.TabIndex = 9;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBox1.BackColor = bg;
            listBox1.Font = font;
            listBox1.ForeColor = text;
            listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            listBox1.Anchor = System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // axWindowsMediaPlayer1
            //
            
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new System.Drawing.Point(652, 0);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (System.Windows.Forms.AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new System.Drawing.Size(392, 550);
            axWindowsMediaPlayer1.TabIndex = 10;
            axWindowsMediaPlayer1.Anchor = System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom; 
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(157, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(158, 15);
            label1.TabIndex = 11;
            label1.Text = "";
            label1.ForeColor = text;
            label1.Font = font;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(139, 15);
            label2.TabIndex = 12;
            label2.Text = "Music folder in the ROM:\nExtractedRomFS\\data\\sound";
            label2.ForeColor = text;
            label2.Font = font;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(0, 328);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(263, 261);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // Music
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = bg;
            ClientSize = new System.Drawing.Size(1044, 550);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Music";
            Text = "Music";
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
            Load += Music_Load;
        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
