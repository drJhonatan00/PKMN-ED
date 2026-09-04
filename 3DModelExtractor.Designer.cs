namespace pk3DS.WinForms
{
    partial class _3DModelExtractor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_3DModelExtractor));
            button1 = new System.Windows.Forms.Button();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(35, 39);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(201, 51);
            button1.TabIndex = 0;
            button1.Text = "Extract";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new System.Drawing.Point(35, 142);
            numericUpDown1.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(201, 23);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(35, 124);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(35, 15);
            label1.TabIndex = 2;
            label1.Text = "Index";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(35, 212);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(308, 180);
            label2.TabIndex = 3;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(535, 180);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(99, 15);
            label3.TabIndex = 5;
            label3.Text = "Pokédex number:";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new System.Drawing.Point(637, 177);
            numericUpDown2.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new System.Drawing.Size(43, 23);
            numericUpDown2.TabIndex = 6;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(535, 222);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(163, 30);
            label4.TabIndex = 7;
            label4.Text = "It's include variant forms and \r\nmega evolutions";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(535, 289);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(146, 15);
            label5.TabIndex = 8;
            label5.Text = "Your model is in the index:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(685, 290);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(49, 15);
            label6.TabIndex = 9;
            label6.Text = "0000000";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(655, 332);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(145, 146);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // _3DModelExtractor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(numericUpDown2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(button1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "_3DModelExtractor";
            Text = "3DModelExtractor";
            Load += _3DModelExtractor_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}