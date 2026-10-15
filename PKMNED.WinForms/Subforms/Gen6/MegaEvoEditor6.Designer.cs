using System.Windows.Forms;

namespace PKMNED.WinForms;

partial class MegaEvoEditor6
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MegaEvoEditor6));
        LBL_Item1 = new Label();
        LBL_Forme1 = new Label();
        GB_MEvo1 = new GroupBox();
        LBL_Into1 = new Label();
        PB_M1 = new PictureBox();
        PB_S1 = new PictureBox();
        CB_Forme1 = new ComboBox();
        CB_Item1 = new ComboBox();
        GB_MEvo2 = new GroupBox();
        LBL_Into2 = new Label();
        PB_M2 = new PictureBox();
        CB_Forme2 = new ComboBox();
        PB_S2 = new PictureBox();
        CB_Item2 = new ComboBox();
        LBL_Forme2 = new Label();
        LBL_Item2 = new Label();
        CHK_MEvo1 = new CheckBox();
        CHK_MEvo2 = new CheckBox();
        CB_Species = new ComboBox();
        bpkx = new PictureBox();
        B_Dump = new Button();
        GB_MEvo3 = new GroupBox();
        LBL_Into3 = new Label();
        PB_M3 = new PictureBox();
        CB_Forme3 = new ComboBox();
        PB_S3 = new PictureBox();
        CB_Item3 = new ComboBox();
        LBL_Forme3 = new Label();
        LBL_Item3 = new Label();
        CHK_MEvo3 = new CheckBox();
        GB_MEvo1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)PB_M1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PB_S1).BeginInit();
        GB_MEvo2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)PB_M2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PB_S2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)bpkx).BeginInit();
        GB_MEvo3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)PB_M3).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PB_S3).BeginInit();
        SuspendLayout();
        // 
        // LBL_Item1
        // 
        LBL_Item1.AutoSize = true;
        LBL_Item1.Location = new System.Drawing.Point(7, 26);
        LBL_Item1.Margin = new Padding(4, 0, 4, 0);
        LBL_Item1.Name = "LBL_Item1";
        LBL_Item1.Size = new System.Drawing.Size(37, 19);
        LBL_Item1.TabIndex = 9;
        LBL_Item1.Text = "Item";
        // 
        // LBL_Forme1
        // 
        LBL_Forme1.AutoSize = true;
        LBL_Forme1.Location = new System.Drawing.Point(7, 85);
        LBL_Forme1.Margin = new Padding(4, 0, 4, 0);
        LBL_Forme1.Name = "LBL_Forme1";
        LBL_Forme1.Size = new System.Drawing.Size(114, 19);
        LBL_Forme1.TabIndex = 10;
        LBL_Forme1.Text = "Alt Forme (if any)";
        // 
        // GB_MEvo1
        // 
        GB_MEvo1.Controls.Add(LBL_Into1);
        GB_MEvo1.Controls.Add(PB_M1);
        GB_MEvo1.Controls.Add(PB_S1);
        GB_MEvo1.Controls.Add(CB_Forme1);
        GB_MEvo1.Controls.Add(CB_Item1);
        GB_MEvo1.Controls.Add(LBL_Forme1);
        GB_MEvo1.Controls.Add(LBL_Item1);
        GB_MEvo1.Enabled = false;
        GB_MEvo1.Font = new System.Drawing.Font("Segoe UI", 10F);
        GB_MEvo1.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        GB_MEvo1.Location = new System.Drawing.Point(14, 82);
        GB_MEvo1.Margin = new Padding(4, 3, 4, 3);
        GB_MEvo1.Name = "GB_MEvo1";
        GB_MEvo1.Padding = new Padding(4, 3, 4, 3);
        GB_MEvo1.Size = new System.Drawing.Size(147, 186);
        GB_MEvo1.TabIndex = 11;
        GB_MEvo1.TabStop = false;
        GB_MEvo1.Text = "Evolution 1";
        // 
        // LBL_Into1
        // 
        LBL_Into1.AutoSize = true;
        LBL_Into1.Location = new System.Drawing.Point(56, 149);
        LBL_Into1.Margin = new Padding(4, 0, 4, 0);
        LBL_Into1.Name = "LBL_Into1";
        LBL_Into1.Size = new System.Drawing.Size(37, 19);
        LBL_Into1.TabIndex = 34;
        LBL_Into1.Text = "Into:";
        // 
        // PB_M1
        // 
        PB_M1.BorderStyle = BorderStyle.FixedSingle;
        PB_M1.Location = new System.Drawing.Point(94, 138);
        PB_M1.Margin = new Padding(4, 3, 4, 3);
        PB_M1.Name = "PB_M1";
        PB_M1.Size = new System.Drawing.Size(49, 42);
        PB_M1.SizeMode = PictureBoxSizeMode.CenterImage;
        PB_M1.TabIndex = 33;
        PB_M1.TabStop = false;
        // 
        // PB_S1
        // 
        PB_S1.BorderStyle = BorderStyle.FixedSingle;
        PB_S1.Location = new System.Drawing.Point(6, 138);
        PB_S1.Margin = new Padding(4, 3, 4, 3);
        PB_S1.Name = "PB_S1";
        PB_S1.Size = new System.Drawing.Size(49, 42);
        PB_S1.SizeMode = PictureBoxSizeMode.CenterImage;
        PB_S1.TabIndex = 32;
        PB_S1.TabStop = false;
        // 
        // CB_Forme1
        // 
        CB_Forme1.AutoCompleteMode = AutoCompleteMode.Suggest;
        CB_Forme1.AutoCompleteSource = AutoCompleteSource.ListItems;
        CB_Forme1.FormattingEnabled = true;
        CB_Forme1.Location = new System.Drawing.Point(6, 108);
        CB_Forme1.Margin = new Padding(4, 3, 4, 3);
        CB_Forme1.Name = "CB_Forme1";
        CB_Forme1.Size = new System.Drawing.Size(140, 25);
        CB_Forme1.TabIndex = 18;
        CB_Forme1.SelectedIndexChanged += Update_PBs;
        // 
        // CB_Item1
        // 
        CB_Item1.AutoCompleteMode = AutoCompleteMode.Suggest;
        CB_Item1.AutoCompleteSource = AutoCompleteSource.ListItems;
        CB_Item1.FormattingEnabled = true;
        CB_Item1.Location = new System.Drawing.Point(2, 45);
        CB_Item1.Margin = new Padding(4, 3, 4, 3);
        CB_Item1.Name = "CB_Item1";
        CB_Item1.Size = new System.Drawing.Size(140, 25);
        CB_Item1.TabIndex = 12;
        CB_Item1.SelectedValueChanged += Update_PBs;
        // 
        // GB_MEvo2
        // 
        GB_MEvo2.Controls.Add(LBL_Into2);
        GB_MEvo2.Controls.Add(PB_M2);
        GB_MEvo2.Controls.Add(CB_Forme2);
        GB_MEvo2.Controls.Add(PB_S2);
        GB_MEvo2.Controls.Add(CB_Item2);
        GB_MEvo2.Controls.Add(LBL_Forme2);
        GB_MEvo2.Controls.Add(LBL_Item2);
        GB_MEvo2.Enabled = false;
        GB_MEvo2.Font = new System.Drawing.Font("Segoe UI", 10F);
        GB_MEvo2.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        GB_MEvo2.Location = new System.Drawing.Point(168, 82);
        GB_MEvo2.Margin = new Padding(4, 3, 4, 3);
        GB_MEvo2.Name = "GB_MEvo2";
        GB_MEvo2.Padding = new Padding(4, 3, 4, 3);
        GB_MEvo2.Size = new System.Drawing.Size(147, 186);
        GB_MEvo2.TabIndex = 12;
        GB_MEvo2.TabStop = false;
        GB_MEvo2.Text = "Evolution 2";
        // 
        // LBL_Into2
        // 
        LBL_Into2.AutoSize = true;
        LBL_Into2.Location = new System.Drawing.Point(55, 150);
        LBL_Into2.Margin = new Padding(4, 0, 4, 0);
        LBL_Into2.Name = "LBL_Into2";
        LBL_Into2.Size = new System.Drawing.Size(37, 19);
        LBL_Into2.TabIndex = 35;
        LBL_Into2.Text = "Into:";
        // 
        // PB_M2
        // 
        PB_M2.BorderStyle = BorderStyle.FixedSingle;
        PB_M2.Location = new System.Drawing.Point(93, 138);
        PB_M2.Margin = new Padding(4, 3, 4, 3);
        PB_M2.Name = "PB_M2";
        PB_M2.Size = new System.Drawing.Size(49, 42);
        PB_M2.SizeMode = PictureBoxSizeMode.CenterImage;
        PB_M2.TabIndex = 35;
        PB_M2.TabStop = false;
        // 
        // CB_Forme2
        // 
        CB_Forme2.AutoCompleteMode = AutoCompleteMode.Suggest;
        CB_Forme2.AutoCompleteSource = AutoCompleteSource.ListItems;
        CB_Forme2.FormattingEnabled = true;
        CB_Forme2.Location = new System.Drawing.Point(2, 108);
        CB_Forme2.Margin = new Padding(4, 3, 4, 3);
        CB_Forme2.Name = "CB_Forme2";
        CB_Forme2.Size = new System.Drawing.Size(140, 25);
        CB_Forme2.TabIndex = 19;
        CB_Forme2.SelectedIndexChanged += Update_PBs;
        // 
        // PB_S2
        // 
        PB_S2.BorderStyle = BorderStyle.FixedSingle;
        PB_S2.Location = new System.Drawing.Point(5, 138);
        PB_S2.Margin = new Padding(4, 3, 4, 3);
        PB_S2.Name = "PB_S2";
        PB_S2.Size = new System.Drawing.Size(49, 42);
        PB_S2.SizeMode = PictureBoxSizeMode.CenterImage;
        PB_S2.TabIndex = 34;
        PB_S2.TabStop = false;
        // 
        // CB_Item2
        // 
        CB_Item2.AutoCompleteMode = AutoCompleteMode.Suggest;
        CB_Item2.AutoCompleteSource = AutoCompleteSource.ListItems;
        CB_Item2.FormattingEnabled = true;
        CB_Item2.Location = new System.Drawing.Point(2, 48);
        CB_Item2.Margin = new Padding(4, 3, 4, 3);
        CB_Item2.Name = "CB_Item2";
        CB_Item2.Size = new System.Drawing.Size(140, 25);
        CB_Item2.TabIndex = 13;
        CB_Item2.SelectedValueChanged += Update_PBs;
        // 
        // LBL_Forme2
        // 
        LBL_Forme2.AutoSize = true;
        LBL_Forme2.Location = new System.Drawing.Point(7, 85);
        LBL_Forme2.Margin = new Padding(4, 0, 4, 0);
        LBL_Forme2.Name = "LBL_Forme2";
        LBL_Forme2.Size = new System.Drawing.Size(114, 19);
        LBL_Forme2.TabIndex = 10;
        LBL_Forme2.Text = "Alt Forme (if any)";
        // 
        // LBL_Item2
        // 
        LBL_Item2.AutoSize = true;
        LBL_Item2.Location = new System.Drawing.Point(7, 26);
        LBL_Item2.Margin = new Padding(4, 0, 4, 0);
        LBL_Item2.Name = "LBL_Item2";
        LBL_Item2.Size = new System.Drawing.Size(37, 19);
        LBL_Item2.TabIndex = 9;
        LBL_Item2.Text = "Item";
        // 
        // CHK_MEvo1
        // 
        CHK_MEvo1.AutoSize = true;
        CHK_MEvo1.Location = new System.Drawing.Point(14, 51);
        CHK_MEvo1.Margin = new Padding(4, 3, 4, 3);
        CHK_MEvo1.Name = "CHK_MEvo1";
        CHK_MEvo1.Size = new System.Drawing.Size(76, 23);
        CHK_MEvo1.TabIndex = 13;
        CHK_MEvo1.Text = "Enabled";
        CHK_MEvo1.UseVisualStyleBackColor = true;
        CHK_MEvo1.CheckedChanged += CHK_Changed;
        // 
        // CHK_MEvo2
        // 
        CHK_MEvo2.AutoSize = true;
        CHK_MEvo2.Location = new System.Drawing.Point(168, 51);
        CHK_MEvo2.Margin = new Padding(4, 3, 4, 3);
        CHK_MEvo2.Name = "CHK_MEvo2";
        CHK_MEvo2.Size = new System.Drawing.Size(76, 23);
        CHK_MEvo2.TabIndex = 14;
        CHK_MEvo2.Text = "Enabled";
        CHK_MEvo2.UseVisualStyleBackColor = true;
        CHK_MEvo2.CheckedChanged += CHK_Changed;
        // 
        // CB_Species
        // 
        CB_Species.AutoCompleteMode = AutoCompleteMode.Suggest;
        CB_Species.AutoCompleteSource = AutoCompleteSource.ListItems;
        CB_Species.FormattingEnabled = true;
        CB_Species.Location = new System.Drawing.Point(14, 16);
        CB_Species.Margin = new Padding(4, 3, 4, 3);
        CB_Species.Name = "CB_Species";
        CB_Species.Size = new System.Drawing.Size(210, 25);
        CB_Species.TabIndex = 15;
        CB_Species.SelectedIndexChanged += ChangeIndex;
        // 
        // bpkx
        // 
        bpkx.BorderStyle = BorderStyle.FixedSingle;
        bpkx.Location = new System.Drawing.Point(308, 99);
        bpkx.Name = "bpkx";
        bpkx.Size = new System.Drawing.Size(42, 32);
        bpkx.SizeMode = PictureBoxSizeMode.CenterImage;
        bpkx.TabIndex = 31;
        bpkx.TabStop = false;
        // 
        // B_Dump
        // 
        B_Dump.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_Dump.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_Dump.FlatStyle = FlatStyle.Flat;
        B_Dump.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Dump.ForeColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_Dump.Location = new System.Drawing.Point(382, 7);
        B_Dump.Margin = new Padding(4, 3, 4, 3);
        B_Dump.Name = "B_Dump";
        B_Dump.Size = new System.Drawing.Size(88, 31);
        B_Dump.TabIndex = 18;
        B_Dump.Text = "Dump";
        B_Dump.UseVisualStyleBackColor = true;
        B_Dump.Click += B_Dump_Click;
        // 
        // GB_MEvo3
        // 
        GB_MEvo3.Controls.Add(LBL_Into3);
        GB_MEvo3.Controls.Add(PB_M3);
        GB_MEvo3.Controls.Add(CB_Forme3);
        GB_MEvo3.Controls.Add(PB_S3);
        GB_MEvo3.Controls.Add(CB_Item3);
        GB_MEvo3.Controls.Add(LBL_Forme3);
        GB_MEvo3.Controls.Add(LBL_Item3);
        GB_MEvo3.Enabled = false;
        GB_MEvo3.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        GB_MEvo3.Location = new System.Drawing.Point(322, 82);
        GB_MEvo3.Margin = new Padding(4, 3, 4, 3);
        GB_MEvo3.Name = "GB_MEvo3";
        GB_MEvo3.Padding = new Padding(4, 3, 4, 3);
        GB_MEvo3.Size = new System.Drawing.Size(147, 186);
        GB_MEvo3.TabIndex = 13;
        GB_MEvo3.TabStop = false;
        GB_MEvo3.Text = "Evolution 3";
        // 
        // LBL_Into3
        // 
        LBL_Into3.AutoSize = true;
        LBL_Into3.Location = new System.Drawing.Point(54, 150);
        LBL_Into3.Margin = new Padding(4, 0, 4, 0);
        LBL_Into3.Name = "LBL_Into3";
        LBL_Into3.Size = new System.Drawing.Size(37, 19);
        LBL_Into3.TabIndex = 36;
        LBL_Into3.Text = "Into:";
        // 
        // PB_M3
        // 
        PB_M3.BorderStyle = BorderStyle.FixedSingle;
        PB_M3.Location = new System.Drawing.Point(92, 138);
        PB_M3.Margin = new Padding(4, 3, 4, 3);
        PB_M3.Name = "PB_M3";
        PB_M3.Size = new System.Drawing.Size(49, 42);
        PB_M3.SizeMode = PictureBoxSizeMode.CenterImage;
        PB_M3.TabIndex = 35;
        PB_M3.TabStop = false;
        // 
        // CB_Forme3
        // 
        CB_Forme3.AutoCompleteMode = AutoCompleteMode.Suggest;
        CB_Forme3.AutoCompleteSource = AutoCompleteSource.ListItems;
        CB_Forme3.FormattingEnabled = true;
        CB_Forme3.Location = new System.Drawing.Point(4, 108);
        CB_Forme3.Margin = new Padding(4, 3, 4, 3);
        CB_Forme3.Name = "CB_Forme3";
        CB_Forme3.Size = new System.Drawing.Size(140, 25);
        CB_Forme3.TabIndex = 20;
        CB_Forme3.SelectedIndexChanged += Update_PBs;
        // 
        // PB_S3
        // 
        PB_S3.BorderStyle = BorderStyle.FixedSingle;
        PB_S3.Location = new System.Drawing.Point(4, 138);
        PB_S3.Margin = new Padding(4, 3, 4, 3);
        PB_S3.Name = "PB_S3";
        PB_S3.Size = new System.Drawing.Size(49, 42);
        PB_S3.SizeMode = PictureBoxSizeMode.CenterImage;
        PB_S3.TabIndex = 34;
        PB_S3.TabStop = false;
        // 
        // CB_Item3
        // 
        CB_Item3.AutoCompleteMode = AutoCompleteMode.Suggest;
        CB_Item3.AutoCompleteSource = AutoCompleteSource.ListItems;
        CB_Item3.FormattingEnabled = true;
        CB_Item3.Location = new System.Drawing.Point(4, 48);
        CB_Item3.Margin = new Padding(4, 3, 4, 3);
        CB_Item3.Name = "CB_Item3";
        CB_Item3.Size = new System.Drawing.Size(140, 25);
        CB_Item3.TabIndex = 18;
        CB_Item3.SelectedValueChanged += Update_PBs;
        // 
        // LBL_Forme3
        // 
        LBL_Forme3.AutoSize = true;
        LBL_Forme3.Location = new System.Drawing.Point(7, 85);
        LBL_Forme3.Margin = new Padding(4, 0, 4, 0);
        LBL_Forme3.Name = "LBL_Forme3";
        LBL_Forme3.Size = new System.Drawing.Size(114, 19);
        LBL_Forme3.TabIndex = 10;
        LBL_Forme3.Text = "Alt Forme (if any)";
        // 
        // LBL_Item3
        // 
        LBL_Item3.AutoSize = true;
        LBL_Item3.Location = new System.Drawing.Point(7, 26);
        LBL_Item3.Margin = new Padding(4, 0, 4, 0);
        LBL_Item3.Name = "LBL_Item3";
        LBL_Item3.Size = new System.Drawing.Size(37, 19);
        LBL_Item3.TabIndex = 9;
        LBL_Item3.Text = "Item";
        // 
        // CHK_MEvo3
        // 
        CHK_MEvo3.AutoSize = true;
        CHK_MEvo3.Location = new System.Drawing.Point(332, 51);
        CHK_MEvo3.Margin = new Padding(4, 3, 4, 3);
        CHK_MEvo3.Name = "CHK_MEvo3";
        CHK_MEvo3.Size = new System.Drawing.Size(76, 23);
        CHK_MEvo3.TabIndex = 16;
        CHK_MEvo3.Text = "Enabled";
        CHK_MEvo3.UseVisualStyleBackColor = true;
        CHK_MEvo3.CheckedChanged += CHK_Changed;
        // 
        // MegaEvoEditor6
        // 
        AllowDrop = true;
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        ClientSize = new System.Drawing.Size(483, 275);
        Controls.Add(B_Dump);
        Controls.Add(CHK_MEvo3);
        Controls.Add(GB_MEvo3);
        Controls.Add(CB_Species);
        Controls.Add(CHK_MEvo2);
        Controls.Add(CHK_MEvo1);
        Controls.Add(GB_MEvo2);
        Controls.Add(GB_MEvo1);
        Font = new System.Drawing.Font("Segoe UI", 10F);
        ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MaximumSize = new System.Drawing.Size(499, 314);
        MinimumSize = new System.Drawing.Size(499, 314);
        Name = "MegaEvoEditor6";
        Text = "Mega Evo Editor";
        FormClosing += Form_Closing;
        GB_MEvo1.ResumeLayout(false);
        GB_MEvo1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)PB_M1).EndInit();
        ((System.ComponentModel.ISupportInitialize)PB_S1).EndInit();
        GB_MEvo2.ResumeLayout(false);
        GB_MEvo2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)PB_M2).EndInit();
        ((System.ComponentModel.ISupportInitialize)PB_S2).EndInit();
        ((System.ComponentModel.ISupportInitialize)bpkx).EndInit();
        GB_MEvo3.ResumeLayout(false);
        GB_MEvo3.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)PB_M3).EndInit();
        ((System.ComponentModel.ISupportInitialize)PB_S3).EndInit();
        ResumeLayout(false);
        PerformLayout();




    }

    #endregion

    private System.Windows.Forms.Label LBL_Item1;
    private System.Windows.Forms.Label LBL_Forme1;
    private System.Windows.Forms.GroupBox GB_MEvo1;
    private System.Windows.Forms.GroupBox GB_MEvo2;
    private System.Windows.Forms.Label LBL_Forme2;
    private System.Windows.Forms.Label LBL_Item2;
    private System.Windows.Forms.CheckBox CHK_MEvo1;
    private System.Windows.Forms.CheckBox CHK_MEvo2;
    private System.Windows.Forms.ComboBox CB_Species;
    private System.Windows.Forms.GroupBox GB_MEvo3;
    private System.Windows.Forms.Label LBL_Forme3;
    private System.Windows.Forms.Label LBL_Item3;
    private System.Windows.Forms.CheckBox CHK_MEvo3;
    private System.Windows.Forms.ComboBox CB_Item1;
    private System.Windows.Forms.ComboBox CB_Item2;
    private System.Windows.Forms.ComboBox CB_Item3;
    private System.Windows.Forms.ComboBox CB_Forme1;
    private System.Windows.Forms.ComboBox CB_Forme2;
    private System.Windows.Forms.ComboBox CB_Forme3;
    private System.Windows.Forms.PictureBox PB_M1;
    private System.Windows.Forms.PictureBox PB_S1;
    private System.Windows.Forms.PictureBox PB_M2;
    private System.Windows.Forms.PictureBox PB_S2;
    private System.Windows.Forms.PictureBox PB_M3;
    private System.Windows.Forms.PictureBox PB_S3;
    private System.Windows.Forms.PictureBox bpkx;
    private System.Windows.Forms.Label LBL_Into1;
    private System.Windows.Forms.Label LBL_Into2;
    private System.Windows.Forms.Label LBL_Into3;
    private System.Windows.Forms.Button B_Dump;
}
