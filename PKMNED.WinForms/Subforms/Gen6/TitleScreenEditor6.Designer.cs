namespace PKMNED.WinForms;

sealed partial class TitleScreenEditor6
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleScreenEditor6));
        PB_Image = new System.Windows.Forms.PictureBox();
        CB_DARC = new System.Windows.Forms.ComboBox();
        CB_File = new System.Windows.Forms.ComboBox();
        L_DARCSelect = new System.Windows.Forms.Label();
        L_Dimensions = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)PB_Image).BeginInit();
        SuspendLayout();
        // 
        // PB_Image
        // 
        PB_Image.Location = new System.Drawing.Point(14, 86);
        PB_Image.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        PB_Image.Name = "PB_Image";
        PB_Image.Size = new System.Drawing.Size(400, 240);
        PB_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
        PB_Image.TabIndex = 0;
        PB_Image.TabStop = false;
        PB_Image.Click += PB_Image_Click;
        // 
        // CB_DARC
        // 
        CB_DARC.FormattingEnabled = true;
        CB_DARC.Location = new System.Drawing.Point(68, 10);
        CB_DARC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CB_DARC.Name = "CB_DARC";
        CB_DARC.Size = new System.Drawing.Size(116, 25);
        CB_DARC.TabIndex = 1;
        CB_DARC.SelectedIndexChanged += ChangeDARC;
        // 
        // CB_File
        // 
        CB_File.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        CB_File.FormattingEnabled = true;
        CB_File.Location = new System.Drawing.Point(14, 45);
        CB_File.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CB_File.Name = "CB_File";
        CB_File.Size = new System.Drawing.Size(468, 25);
        CB_File.TabIndex = 2;
        CB_File.SelectedIndexChanged += ChangeFile;
        // 
        // L_DARCSelect
        // 
        L_DARCSelect.AutoSize = true;
        L_DARCSelect.Location = new System.Drawing.Point(14, 15);
        L_DARCSelect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_DARCSelect.Name = "L_DARCSelect";
        L_DARCSelect.Size = new System.Drawing.Size(48, 19);
        L_DARCSelect.TabIndex = 3;
        L_DARCSelect.Text = "DARC:";
        // 
        // L_Dimensions
        // 
        L_Dimensions.AutoSize = true;
        L_Dimensions.Location = new System.Drawing.Point(191, 15);
        L_Dimensions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Dimensions.Name = "L_Dimensions";
        L_Dimensions.Size = new System.Drawing.Size(80, 19);
        L_Dimensions.TabIndex = 4;
        L_Dimensions.Text = "Dimensions";
        // 
        // TitleScreenEditor6
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        ClientSize = new System.Drawing.Size(495, 414);
        Controls.Add(L_Dimensions);
        Controls.Add(L_DARCSelect);
        Controls.Add(CB_File);
        Controls.Add(CB_DARC);
        Controls.Add(PB_Image);
        Font = new System.Drawing.Font("Segoe UI", 10F);
        ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MaximumSize = new System.Drawing.Size(645, 538);
        MinimumSize = new System.Drawing.Size(511, 450);
        Name = "TitleScreenEditor6";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Title Screen Editor";
        FormClosing += Form_Closing;
        ((System.ComponentModel.ISupportInitialize)PB_Image).EndInit();
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox PB_Image;
    private System.Windows.Forms.ComboBox CB_DARC;
    private System.Windows.Forms.ComboBox CB_File;
    private System.Windows.Forms.Label L_DARCSelect;
    private System.Windows.Forms.Label L_Dimensions;

}
