namespace PKMNED.WinForms;

sealed partial class ToolsUI
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolsUI));
        PB_Unpack = new System.Windows.Forms.Panel();
        L_DARCMini = new System.Windows.Forms.Label();
        CHK_PNG = new System.Windows.Forms.CheckBox();
        label1 = new System.Windows.Forms.Label();
        PB_Repack = new System.Windows.Forms.Panel();
        label4 = new System.Windows.Forms.Label();
        CB_Repack = new System.Windows.Forms.ComboBox();
        PB_BCLIM = new System.Windows.Forms.PictureBox();
        B_Reset = new System.Windows.Forms.Button();
        CHK_Delete = new System.Windows.Forms.CheckBox();
        pBar1 = new System.Windows.Forms.ProgressBar();
        NUD_Padding = new System.Windows.Forms.NumericUpDown();
        L_Padding = new System.Windows.Forms.Label();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize)PB_BCLIM).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Padding).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // PB_Unpack
        // 
        PB_Unpack.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        PB_Unpack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        PB_Unpack.Location = new System.Drawing.Point(14, 33);
        PB_Unpack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        PB_Unpack.Name = "PB_Unpack";
        PB_Unpack.Size = new System.Drawing.Size(408, 87);
        PB_Unpack.TabIndex = 0;
        PB_Unpack.MouseLeave += DropLeave;
        PB_Unpack.MouseHover += DropHover;
        // 
        // L_DARCMini
        // 
        L_DARCMini.AutoSize = true;
        L_DARCMini.Location = new System.Drawing.Point(10, 11);
        L_DARCMini.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_DARCMini.Name = "L_DARCMini";
        L_DARCMini.Size = new System.Drawing.Size(371, 19);
        L_DARCMini.TabIndex = 1;
        L_DARCMini.Text = "GARC, DARC && Mini Unpack (CTRL to Skip Decompression)";
        // 
        // CHK_PNG
        // 
        CHK_PNG.AutoSize = true;
        CHK_PNG.Location = new System.Drawing.Point(151, 285);
        CHK_PNG.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_PNG.Name = "CHK_PNG";
        CHK_PNG.Size = new System.Drawing.Size(117, 23);
        CHK_PNG.TabIndex = 2;
        CHK_PNG.Text = "Autosave PNG";
        CHK_PNG.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new System.Drawing.Point(21, 287);
        label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(95, 19);
        label1.TabIndex = 3;
        label1.Text = "BCLIM Viewer";
        // 
        // PB_Repack
        // 
        PB_Repack.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        PB_Repack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        PB_Repack.Location = new System.Drawing.Point(214, 162);
        PB_Repack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        PB_Repack.Name = "PB_Repack";
        PB_Repack.Size = new System.Drawing.Size(208, 87);
        PB_Repack.TabIndex = 5;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new System.Drawing.Point(10, 142);
        label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(94, 19);
        label4.TabIndex = 7;
        label4.Text = "Folder Repack";
        // 
        // CB_Repack
        // 
        CB_Repack.FormattingEnabled = true;
        CB_Repack.Location = new System.Drawing.Point(14, 162);
        CB_Repack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CB_Repack.Name = "CB_Repack";
        CB_Repack.Size = new System.Drawing.Size(174, 25);
        CB_Repack.TabIndex = 8;
        // 
        // PB_BCLIM
        // 
        PB_BCLIM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        PB_BCLIM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        PB_BCLIM.Location = new System.Drawing.Point(14, 308);
        PB_BCLIM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        PB_BCLIM.Name = "PB_BCLIM";
        PB_BCLIM.Size = new System.Drawing.Size(408, 162);
        PB_BCLIM.TabIndex = 1;
        PB_BCLIM.TabStop = false;
        PB_BCLIM.Click += PB_BCLIM_Click;
        // 
        // B_Reset
        // 
        B_Reset.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_Reset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Reset.ForeColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_Reset.Location = new System.Drawing.Point(32, 245);
        B_Reset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Reset.Name = "B_Reset";
        B_Reset.Size = new System.Drawing.Size(93, 31);
        B_Reset.TabIndex = 9;
        B_Reset.Text = "Reset View";
        B_Reset.UseVisualStyleBackColor = false;
        B_Reset.Click += B_Reset_Click;
        // 
        // CHK_Delete
        // 
        CHK_Delete.AutoSize = true;
        CHK_Delete.Checked = true;
        CHK_Delete.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_Delete.Location = new System.Drawing.Point(14, 194);
        CHK_Delete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_Delete.Name = "CHK_Delete";
        CHK_Delete.Size = new System.Drawing.Size(192, 23);
        CHK_Delete.TabIndex = 10;
        CHK_Delete.Text = "Delete Folder after Packing";
        CHK_Delete.UseVisualStyleBackColor = true;
        // 
        // pBar1
        // 
        pBar1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        pBar1.Location = new System.Drawing.Point(14, 125);
        pBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        pBar1.Name = "pBar1";
        pBar1.Size = new System.Drawing.Size(408, 16);
        pBar1.TabIndex = 11;
        // 
        // NUD_Padding
        // 
        NUD_Padding.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_Padding.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_Padding.Hexadecimal = true;
        NUD_Padding.Location = new System.Drawing.Point(138, 214);
        NUD_Padding.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_Padding.Maximum = new decimal(new int[] { 65536, 0, 0, 0 });
        NUD_Padding.Name = "NUD_Padding";
        NUD_Padding.Size = new System.Drawing.Size(51, 25);
        NUD_Padding.TabIndex = 12;
        NUD_Padding.Value = new decimal(new int[] { 4, 0, 0, 0 });
        // 
        // L_Padding
        // 
        L_Padding.Location = new System.Drawing.Point(14, 214);
        L_Padding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Padding.Name = "L_Padding";
        L_Padding.Size = new System.Drawing.Size(117, 26);
        L_Padding.TabIndex = 13;
        L_Padding.Text = "GARC Padding:";
        L_Padding.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // pictureBox1
        // 
        pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new System.Drawing.Point(141, 516);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(145, 165);
        pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 14;
        pictureBox1.TabStop = false;
        // 
        // ToolsUI
        // 
        AllowDrop = true;
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        ClientSize = new System.Drawing.Size(436, 647);
        Controls.Add(pictureBox1);
        Controls.Add(L_Padding);
        Controls.Add(NUD_Padding);
        Controls.Add(pBar1);
        Controls.Add(CHK_Delete);
        Controls.Add(B_Reset);
        Controls.Add(CB_Repack);
        Controls.Add(label4);
        Controls.Add(PB_Repack);
        Controls.Add(label1);
        Controls.Add(CHK_PNG);
        Controls.Add(PB_BCLIM);
        Controls.Add(L_DARCMini);
        Controls.Add(PB_Unpack);
        Font = new System.Drawing.Font("Segoe UI", 10F);
        ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MinimumSize = new System.Drawing.Size(394, 512);
        Name = "ToolsUI";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Tools";
        FormClosing += CloseForm;
        ((System.ComponentModel.ISupportInitialize)PB_BCLIM).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Padding).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel PB_Unpack;
    private System.Windows.Forms.Label L_DARCMini;
    private System.Windows.Forms.CheckBox CHK_PNG;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel PB_Repack;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox CB_Repack;
    private System.Windows.Forms.PictureBox PB_BCLIM;
    private System.Windows.Forms.Button B_Reset;
    private System.Windows.Forms.CheckBox CHK_Delete;
    private System.Windows.Forms.ProgressBar pBar1;
    private System.Windows.Forms.NumericUpDown NUD_Padding;
    private System.Windows.Forms.Label L_Padding;
    private System.Windows.Forms.PictureBox pictureBox1;
}
