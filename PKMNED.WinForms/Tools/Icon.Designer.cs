namespace PKMNED.WinForms;

sealed partial class Icon
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


        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Icon));
        PB_Large = new System.Windows.Forms.PictureBox();
        CB_AppInfo = new System.Windows.Forms.ComboBox();
        L_AppInfo = new System.Windows.Forms.Label();
        PB_Small = new System.Windows.Forms.PictureBox();
        TB_Short = new System.Windows.Forms.TextBox();
        TB_Long = new System.Windows.Forms.TextBox();
        TB_Publisher = new System.Windows.Forms.TextBox();
        B_ExportSMDH = new System.Windows.Forms.Button();
        B_ExportSmallIcon = new System.Windows.Forms.Button();
        B_ExportLargeIcon = new System.Windows.Forms.Button();
        B_ImportLargeIcon = new System.Windows.Forms.Button();
        B_ImportSmallIcon = new System.Windows.Forms.Button();
        B_ImportSMDH = new System.Windows.Forms.Button();
        B_Save = new System.Windows.Forms.Button();
        B_Cancel = new System.Windows.Forms.Button();
        groupBox1 = new System.Windows.Forms.GroupBox();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize)PB_Large).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PB_Small).BeginInit();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // PB_Large
        // 
        PB_Large.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        PB_Large.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        PB_Large.Location = new System.Drawing.Point(196, 10);
        PB_Large.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        PB_Large.Name = "PB_Large";
        PB_Large.Size = new System.Drawing.Size(58, 57);
        PB_Large.TabIndex = 1;
        PB_Large.TabStop = false;
        // 
        // CB_AppInfo
        // 
        CB_AppInfo.FormattingEnabled = true;
        CB_AppInfo.Location = new System.Drawing.Point(18, 44);
        CB_AppInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CB_AppInfo.Name = "CB_AppInfo";
        CB_AppInfo.Size = new System.Drawing.Size(174, 23);
        CB_AppInfo.TabIndex = 8;
        CB_AppInfo.SelectedIndexChanged += CB_AppInfo_SelectedIndexChanged;
        // 
        // L_AppInfo
        // 
        L_AppInfo.AutoSize = true;
        L_AppInfo.Location = new System.Drawing.Point(14, 25);
        L_AppInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_AppInfo.Name = "L_AppInfo";
        L_AppInfo.Size = new System.Drawing.Size(57, 15);
        L_AppInfo.TabIndex = 7;
        L_AppInfo.Text = "AppInfo#";
        // 
        // PB_Small
        // 
        PB_Small.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        PB_Small.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        PB_Small.Location = new System.Drawing.Point(159, 10);
        PB_Small.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        PB_Small.Name = "PB_Small";
        PB_Small.Size = new System.Drawing.Size(30, 30);
        PB_Small.TabIndex = 9;
        PB_Small.TabStop = false;
        // 
        // TB_Short
        // 
        TB_Short.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        TB_Short.Location = new System.Drawing.Point(18, 75);
        TB_Short.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        TB_Short.MaxLength = 64;
        TB_Short.Name = "TB_Short";
        TB_Short.Size = new System.Drawing.Size(336, 23);
        TB_Short.TabIndex = 10;
        // 
        // TB_Long
        // 
        TB_Long.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        TB_Long.Location = new System.Drawing.Point(18, 105);
        TB_Long.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        TB_Long.MaxLength = 128;
        TB_Long.Name = "TB_Long";
        TB_Long.Size = new System.Drawing.Size(336, 23);
        TB_Long.TabIndex = 11;
        // 
        // TB_Publisher
        // 
        TB_Publisher.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        TB_Publisher.Location = new System.Drawing.Point(18, 135);
        TB_Publisher.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        TB_Publisher.MaxLength = 64;
        TB_Publisher.Name = "TB_Publisher";
        TB_Publisher.Size = new System.Drawing.Size(336, 23);
        TB_Publisher.TabIndex = 12;
        // 
        // B_ExportSMDH
        // 
        B_ExportSMDH.Location = new System.Drawing.Point(7, 55);
        B_ExportSMDH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_ExportSMDH.Name = "B_ExportSMDH";
        B_ExportSMDH.Size = new System.Drawing.Size(103, 27);
        B_ExportSMDH.TabIndex = 15;
        B_ExportSMDH.Text = "Export SMDH";
        B_ExportSMDH.UseVisualStyleBackColor = true;
        B_ExportSMDH.Click += B_ExportSMDH_Click;
        B_ExportSMDH.ForeColor = accent;
        B_ExportSMDH.Font = font;
        B_ExportSMDH.FlatAppearance.BorderColor = accent;
        B_ExportSMDH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        // 
        // B_ExportSmallIcon
        // 
        B_ExportSmallIcon.Location = new System.Drawing.Point(117, 55);
        B_ExportSmallIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_ExportSmallIcon.Name = "B_ExportSmallIcon";
        B_ExportSmallIcon.Size = new System.Drawing.Size(103, 27);
        B_ExportSmallIcon.TabIndex = 16;
        B_ExportSmallIcon.Text = "Export Small";
        B_ExportSmallIcon.UseVisualStyleBackColor = true;
        B_ExportSmallIcon.Click += B_ExportSmallIcon_Click;
        B_ExportSmallIcon.ForeColor = accent;
        B_ExportSmallIcon.Font = font;
        B_ExportSmallIcon.FlatAppearance.BorderColor = accent;
        B_ExportSmallIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        // 
        // B_ExportLargeIcon
        // 
        B_ExportLargeIcon.Location = new System.Drawing.Point(226, 55);
        B_ExportLargeIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_ExportLargeIcon.Name = "B_ExportLargeIcon";
        B_ExportLargeIcon.Size = new System.Drawing.Size(103, 27);
        B_ExportLargeIcon.TabIndex = 17;
        B_ExportLargeIcon.Text = "Export Large";
        B_ExportLargeIcon.UseVisualStyleBackColor = true;
        B_ExportLargeIcon.Click += B_ExportLargeIcon_Click;
        B_ExportLargeIcon.ForeColor = accent;
        B_ExportLargeIcon.Font = font;
        B_ExportLargeIcon.FlatAppearance.BorderColor = accent;
        B_ExportLargeIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        // 
        // B_ImportLargeIcon
        // 
        B_ImportLargeIcon.Enabled = false;
        B_ImportLargeIcon.Location = new System.Drawing.Point(226, 22);
        B_ImportLargeIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_ImportLargeIcon.Name = "B_ImportLargeIcon";
        B_ImportLargeIcon.Size = new System.Drawing.Size(103, 27);
        B_ImportLargeIcon.TabIndex = 20;
        B_ImportLargeIcon.Text = "Import Large";
        B_ImportLargeIcon.UseVisualStyleBackColor = true;
        B_ImportLargeIcon.Click += B_ImportLargeIcon_Click;
        B_ImportLargeIcon.ForeColor = accent;
        B_ImportLargeIcon.Font = font;
        B_ImportLargeIcon.FlatAppearance.BorderColor = accent;
        B_ImportLargeIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        // 
        // B_ImportSmallIcon
        // 
        B_ImportSmallIcon.Enabled = false;
        B_ImportSmallIcon.Location = new System.Drawing.Point(117, 22);
        B_ImportSmallIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_ImportSmallIcon.Name = "B_ImportSmallIcon";
        B_ImportSmallIcon.Size = new System.Drawing.Size(103, 27);
        B_ImportSmallIcon.TabIndex = 19;
        B_ImportSmallIcon.Text = "Import Small";
        B_ImportSmallIcon.UseVisualStyleBackColor = true;
        B_ImportSmallIcon.Click += B_ImportSmallIcon_Click;
        B_ImportSmallIcon.ForeColor = accent;
        B_ImportSmallIcon.Font = font;
        B_ImportSmallIcon.FlatAppearance.BorderColor = accent;
        B_ImportSmallIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        // 
        // B_ImportSMDH
        // 
        B_ImportSMDH.Location = new System.Drawing.Point(7, 22);
        B_ImportSMDH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_ImportSMDH.Name = "B_ImportSMDH";
        B_ImportSMDH.Size = new System.Drawing.Size(103, 27);
        B_ImportSMDH.TabIndex = 18;
        B_ImportSMDH.Text = "Import SMDH";
        B_ImportSMDH.UseVisualStyleBackColor = true;
        B_ImportSMDH.Click += B_ImportSMDH_Click;
        B_ImportSMDH.ForeColor = accent;
        B_ImportSMDH.Font = font;
        B_ImportSMDH.FlatAppearance.BorderColor = accent;
        B_ImportSMDH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        // 
        // B_Save
        // 
        B_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        B_Save.Location = new System.Drawing.Point(278, 370);
        B_Save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Save.Name = "B_Save";
        B_Save.Size = new System.Drawing.Size(77, 27);
        B_Save.TabIndex = 21;
        B_Save.Text = "Save";
        B_Save.UseVisualStyleBackColor = true;
        B_Save.Click += B_Save_Click;
        B_Save.ForeColor = System.Drawing.Color.FromArgb(154, 205, 50);
        B_Save.Font = font;
        B_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(154, 205, 50);
        B_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        // 
        // B_Cancel
        // 
        B_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        B_Cancel.Location = new System.Drawing.Point(194, 370);
        B_Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Cancel.Name = "B_Cancel";
        B_Cancel.Size = new System.Drawing.Size(77, 27);
        B_Cancel.TabIndex = 22;
        B_Cancel.Text = "Cancel";
        B_Cancel.UseVisualStyleBackColor = true;
        B_Cancel.Click += B_Cancel_Click;
        B_Cancel.ForeColor = System.Drawing.Color.Red;
        B_Cancel.Font = font;
        B_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
        B_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(B_ImportLargeIcon);
        groupBox1.Controls.Add(B_ImportSmallIcon);
        groupBox1.Controls.Add(B_ImportSMDH);
        groupBox1.Controls.Add(B_ExportLargeIcon);
        groupBox1.Controls.Add(B_ExportSMDH);
        groupBox1.Controls.Add(B_ExportSmallIcon);
        groupBox1.Location = new System.Drawing.Point(18, 165);
        groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        groupBox1.Size = new System.Drawing.Size(337, 97);
        groupBox1.TabIndex = 23;
        groupBox1.TabStop = false;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new System.Drawing.Point(-1, 294);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(145, 146);
        pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 24;
        pictureBox1.TabStop = false;
        // 
        // Icon
        //
        BackColor = bg;
        Font = font;
        ForeColor = text;
        AllowDrop = true;
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(370, 411);
        Controls.Add(pictureBox1);
        Controls.Add(groupBox1);
        Controls.Add(B_Cancel);
        Controls.Add(B_Save);
        Controls.Add(TB_Publisher);
        Controls.Add(TB_Long);
        Controls.Add(TB_Short);
        Controls.Add(PB_Small);
        Controls.Add(CB_AppInfo);
        Controls.Add(L_AppInfo);
        Controls.Add(PB_Large);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MinimizeBox = false;
        MinimumSize = new System.Drawing.Size(371, 276);
        Name = "Icon";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "SMDH Editor";
        ((System.ComponentModel.ISupportInitialize)PB_Large).EndInit();
        ((System.ComponentModel.ISupportInitialize)PB_Small).EndInit();
        groupBox1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox PB_Large;
    private System.Windows.Forms.ComboBox CB_AppInfo;
    private System.Windows.Forms.Label L_AppInfo;
    private System.Windows.Forms.PictureBox PB_Small;
    private System.Windows.Forms.TextBox TB_Short;
    private System.Windows.Forms.TextBox TB_Long;
    private System.Windows.Forms.TextBox TB_Publisher;
    private System.Windows.Forms.Button B_ExportSMDH;
    private System.Windows.Forms.Button B_ExportSmallIcon;
    private System.Windows.Forms.Button B_ExportLargeIcon;
    private System.Windows.Forms.Button B_ImportLargeIcon;
    private System.Windows.Forms.Button B_ImportSmallIcon;
    private System.Windows.Forms.Button B_ImportSMDH;
    private System.Windows.Forms.Button B_Save;
    private System.Windows.Forms.Button B_Cancel;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.PictureBox pictureBox1;
}
