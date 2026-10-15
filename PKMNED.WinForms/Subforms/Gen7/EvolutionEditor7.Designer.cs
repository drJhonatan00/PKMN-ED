using OpenTK.Graphics.ES11;
using System.Windows.Forms;

namespace PKMNED.WinForms;

partial class EvolutionEditor7
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvolutionEditor7));
        CB_Species = new ComboBox();
        L_Species = new Label();
        B_Dump = new Button();
        CB_M1 = new ComboBox();
        L_M1 = new Label();
        CB_I1 = new ComboBox();
        CB_P1 = new ComboBox();
        PB_1 = new PictureBox();
        B_RandAll = new Button();
        GB_Randomizer = new GroupBox();
        CHK_E = new CheckBox();
        CHK_L = new CheckBox();
        L_Protip = new Label();
        CHK_BST = new CheckBox();
        CHK_Type = new CheckBox();
        CHK_Exp = new CheckBox();
        NUD_F1 = new NumericUpDown();
        NUD_L1 = new NumericUpDown();
        NUD_L2 = new NumericUpDown();
        NUD_F2 = new NumericUpDown();
        PB_2 = new PictureBox();
        CB_P2 = new ComboBox();
        CB_I2 = new ComboBox();
        label1 = new Label();
        CB_M2 = new ComboBox();
        NUD_L3 = new NumericUpDown();
        NUD_F3 = new NumericUpDown();
        PB_3 = new PictureBox();
        CB_P3 = new ComboBox();
        CB_I3 = new ComboBox();
        label2 = new Label();
        CB_M3 = new ComboBox();
        NUD_L4 = new NumericUpDown();
        NUD_F4 = new NumericUpDown();
        PB_4 = new PictureBox();
        CB_P4 = new ComboBox();
        CB_I4 = new ComboBox();
        label3 = new Label();
        CB_M4 = new ComboBox();
        NUD_L5 = new NumericUpDown();
        NUD_F5 = new NumericUpDown();
        PB_5 = new PictureBox();
        CB_P5 = new ComboBox();
        CB_I5 = new ComboBox();
        label4 = new Label();
        CB_M5 = new ComboBox();
        NUD_L6 = new NumericUpDown();
        NUD_F6 = new NumericUpDown();
        PB_6 = new PictureBox();
        CB_P6 = new ComboBox();
        CB_I6 = new ComboBox();
        label5 = new Label();
        CB_M6 = new ComboBox();
        NUD_L7 = new NumericUpDown();
        NUD_F7 = new NumericUpDown();
        PB_7 = new PictureBox();
        CB_P7 = new ComboBox();
        CB_I7 = new ComboBox();
        label6 = new Label();
        CB_M7 = new ComboBox();
        NUD_L8 = new NumericUpDown();
        NUD_F8 = new NumericUpDown();
        PB_8 = new PictureBox();
        CB_P8 = new ComboBox();
        CB_I8 = new ComboBox();
        label7 = new Label();
        CB_M8 = new ComboBox();
        B_Trade = new Button();
        B_EveryLevel = new Button();
        ((System.ComponentModel.ISupportInitialize)PB_1).BeginInit();
        GB_Randomizer.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_F1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_L1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_L2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_F2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PB_2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_L3).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_F3).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PB_3).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_L4).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_F4).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PB_4).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_L5).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_F5).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PB_5).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_L6).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_F6).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PB_6).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_L7).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_F7).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PB_7).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_L8).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_F8).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PB_8).BeginInit();
        SuspendLayout();
        // 
        // CB_Species
        // 
        CB_Species.AutoCompleteMode = AutoCompleteMode.Suggest;
        CB_Species.AutoCompleteSource = AutoCompleteSource.ListItems;
        CB_Species.FormattingEnabled = true;
        CB_Species.Location = new System.Drawing.Point(77, 16);
        CB_Species.Margin = new Padding(4, 3, 4, 3);
        CB_Species.Name = "CB_Species";
        CB_Species.Size = new System.Drawing.Size(140, 25);
        CB_Species.TabIndex = 1;
        CB_Species.SelectedIndexChanged += ChangeEntry;
        // 
        // L_Species
        // 
        L_Species.AutoSize = true;
        L_Species.Location = new System.Drawing.Point(14, 19);
        L_Species.Margin = new Padding(4, 0, 4, 0);
        L_Species.Name = "L_Species";
        L_Species.Size = new System.Drawing.Size(56, 19);
        L_Species.TabIndex = 2;
        L_Species.Text = "Species:";
        // 
        // B_Dump
        // 
        B_Dump.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_Dump.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_Dump.FlatStyle = FlatStyle.Flat;
        B_Dump.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Dump.ForeColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_Dump.Location = new System.Drawing.Point(230, 12);
        B_Dump.Margin = new Padding(4, 3, 4, 3);
        B_Dump.Name = "B_Dump";
        B_Dump.Size = new System.Drawing.Size(69, 31);
        B_Dump.TabIndex = 5;
        B_Dump.Text = "Dump";
        B_Dump.UseVisualStyleBackColor = false;
        B_Dump.Click += B_Dump_Click;
        // 
        // CB_M1
        // 
        CB_M1.DropDownStyle = ComboBoxStyle.DropDownList;
        CB_M1.DropDownWidth = 200;
        CB_M1.FormattingEnabled = true;
        CB_M1.Location = new System.Drawing.Point(146, 60);
        CB_M1.Margin = new Padding(4, 3, 4, 3);
        CB_M1.MaxDropDownItems = 10;
        CB_M1.Name = "CB_M1";
        CB_M1.Size = new System.Drawing.Size(174, 25);
        CB_M1.TabIndex = 6;
        CB_M1.SelectedIndexChanged += ChangeMethod;
        // 
        // L_M1
        // 
        L_M1.Location = new System.Drawing.Point(4, 59);
        L_M1.Margin = new Padding(4, 0, 4, 0);
        L_M1.Name = "L_M1";
        L_M1.Size = new System.Drawing.Size(80, 26);
        L_M1.TabIndex = 7;
        L_M1.Text = "Method 1:";
        L_M1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // CB_I1
        // 
        CB_I1.AutoCompleteMode = AutoCompleteMode.Suggest;
        CB_I1.AutoCompleteSource = AutoCompleteSource.ListItems;
        CB_I1.FormattingEnabled = true;
        CB_I1.Location = new System.Drawing.Point(328, 60);
        CB_I1.Margin = new Padding(4, 3, 4, 3);
        CB_I1.Name = "CB_I1";
        CB_I1.Size = new System.Drawing.Size(117, 25);
        CB_I1.TabIndex = 9;
        CB_I1.SelectedIndexChanged += ChangeInto;
        // 
        // CB_P1
        // 
        CB_P1.AutoCompleteMode = AutoCompleteMode.Suggest;
        CB_P1.AutoCompleteSource = AutoCompleteSource.ListItems;
        CB_P1.FormattingEnabled = true;
        CB_P1.Location = new System.Drawing.Point(453, 60);
        CB_P1.Margin = new Padding(4, 3, 4, 3);
        CB_P1.Name = "CB_P1";
        CB_P1.Size = new System.Drawing.Size(140, 25);
        CB_P1.TabIndex = 10;
        // 
        // PB_1
        // 
        PB_1.Location = new System.Drawing.Point(92, 51);
        PB_1.Margin = new Padding(4, 3, 4, 3);
        PB_1.Name = "PB_1";
        PB_1.Size = new System.Drawing.Size(47, 40);
        PB_1.TabIndex = 54;
        PB_1.TabStop = false;
        // 
        // B_RandAll
        // 
        B_RandAll.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_RandAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(192, 192, 255);
        B_RandAll.FlatStyle = FlatStyle.Flat;
        B_RandAll.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_RandAll.ForeColor = System.Drawing.Color.FromArgb(192, 192, 255);
        B_RandAll.Location = new System.Drawing.Point(596, 431);
        B_RandAll.Margin = new Padding(4, 3, 4, 3);
        B_RandAll.Name = "B_RandAll";
        B_RandAll.Size = new System.Drawing.Size(117, 35);
        B_RandAll.TabIndex = 62;
        B_RandAll.Text = "Randomize All";
        B_RandAll.UseVisualStyleBackColor = false;
        B_RandAll.Click += B_RandAll_Click;
        // 
        // GB_Randomizer
        // 
        GB_Randomizer.Controls.Add(CHK_E);
        GB_Randomizer.Controls.Add(CHK_L);
        GB_Randomizer.Controls.Add(L_Protip);
        GB_Randomizer.Controls.Add(CHK_BST);
        GB_Randomizer.Controls.Add(CHK_Type);
        GB_Randomizer.Controls.Add(CHK_Exp);
        GB_Randomizer.Font = new System.Drawing.Font("Segoe UI", 10F);
        GB_Randomizer.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        GB_Randomizer.Location = new System.Drawing.Point(19, 382);
        GB_Randomizer.Margin = new Padding(4, 3, 4, 3);
        GB_Randomizer.Name = "GB_Randomizer";
        GB_Randomizer.Padding = new Padding(4, 3, 4, 3);
        GB_Randomizer.Size = new System.Drawing.Size(416, 136);
        GB_Randomizer.TabIndex = 63;
        GB_Randomizer.TabStop = false;
        GB_Randomizer.Text = "Randomizer Options";
        // 
        // CHK_E
        // 
        CHK_E.AutoSize = true;
        CHK_E.Location = new System.Drawing.Point(7, 109);
        CHK_E.Margin = new Padding(4, 3, 4, 3);
        CHK_E.Name = "CHK_E";
        CHK_E.Size = new System.Drawing.Size(117, 23);
        CHK_E.TabIndex = 480;
        CHK_E.Text = "Event Legends";
        CHK_E.UseVisualStyleBackColor = true;
        // 
        // CHK_L
        // 
        CHK_L.AutoSize = true;
        CHK_L.Location = new System.Drawing.Point(7, 88);
        CHK_L.Margin = new Padding(4, 3, 4, 3);
        CHK_L.Name = "CHK_L";
        CHK_L.Size = new System.Drawing.Size(119, 23);
        CHK_L.TabIndex = 479;
        CHK_L.Text = "Game Legends";
        CHK_L.UseVisualStyleBackColor = true;
        // 
        // L_Protip
        // 
        L_Protip.AutoSize = true;
        L_Protip.ForeColor = System.Drawing.Color.Red;
        L_Protip.Location = new System.Drawing.Point(209, 11);
        L_Protip.Margin = new Padding(4, 0, 4, 0);
        L_Protip.Name = "L_Protip";
        L_Protip.Size = new System.Drawing.Size(204, 19);
        L_Protip.TabIndex = 66;
        L_Protip.Text = "(Protip: Difficulty++ in Personal)";
        // 
        // CHK_BST
        // 
        CHK_BST.AutoSize = true;
        CHK_BST.Checked = true;
        CHK_BST.CheckState = CheckState.Checked;
        CHK_BST.Location = new System.Drawing.Point(7, 69);
        CHK_BST.Margin = new Padding(4, 3, 4, 3);
        CHK_BST.Name = "CHK_BST";
        CHK_BST.Size = new System.Drawing.Size(220, 23);
        CHK_BST.TabIndex = 65;
        CHK_BST.Text = "Share a similar BST as Evolution";
        CHK_BST.UseVisualStyleBackColor = true;
        // 
        // CHK_Type
        // 
        CHK_Type.AutoSize = true;
        CHK_Type.Checked = true;
        CHK_Type.CheckState = CheckState.Checked;
        CHK_Type.Location = new System.Drawing.Point(7, 50);
        CHK_Type.Margin = new Padding(4, 3, 4, 3);
        CHK_Type.Name = "CHK_Type";
        CHK_Type.Size = new System.Drawing.Size(247, 23);
        CHK_Type.TabIndex = 64;
        CHK_Type.Text = "Share at least one Type as Evolution";
        CHK_Type.UseVisualStyleBackColor = true;
        // 
        // CHK_Exp
        // 
        CHK_Exp.AutoSize = true;
        CHK_Exp.Checked = true;
        CHK_Exp.CheckState = CheckState.Checked;
        CHK_Exp.Location = new System.Drawing.Point(7, 31);
        CHK_Exp.Margin = new Padding(4, 3, 4, 3);
        CHK_Exp.Name = "CHK_Exp";
        CHK_Exp.Size = new System.Drawing.Size(277, 23);
        CHK_Exp.TabIndex = 63;
        CHK_Exp.Text = "Share the same EXP Growth as Evolution";
        CHK_Exp.UseVisualStyleBackColor = true;
        // 
        // NUD_F1
        // 
        NUD_F1.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_F1.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_F1.Location = new System.Drawing.Point(601, 61);
        NUD_F1.Margin = new Padding(4, 3, 4, 3);
        NUD_F1.Maximum = new decimal(new int[] { 127, 0, 0, 0 });
        NUD_F1.Minimum = new decimal(new int[] { 127, 0, 0, int.MinValue });
        NUD_F1.Name = "NUD_F1";
        NUD_F1.Size = new System.Drawing.Size(52, 25);
        NUD_F1.TabIndex = 64;
        NUD_F1.ValueChanged += ChangeInto;
        // 
        // NUD_L1
        // 
        NUD_L1.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_L1.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_L1.Location = new System.Drawing.Point(660, 61);
        NUD_L1.Margin = new Padding(4, 3, 4, 3);
        NUD_L1.Maximum = new decimal(new int[] { 127, 0, 0, 0 });
        NUD_L1.Minimum = new decimal(new int[] { 127, 0, 0, int.MinValue });
        NUD_L1.Name = "NUD_L1";
        NUD_L1.Size = new System.Drawing.Size(52, 25);
        NUD_L1.TabIndex = 65;
        // 
        // NUD_L2
        // 
        NUD_L2.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_L2.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_L2.Location = new System.Drawing.Point(660, 102);
        NUD_L2.Margin = new Padding(4, 3, 4, 3);
        NUD_L2.Maximum = new decimal(new int[] { 127, 0, 0, 0 });
        NUD_L2.Minimum = new decimal(new int[] { 127, 0, 0, int.MinValue });
        NUD_L2.Name = "NUD_L2";
        NUD_L2.Size = new System.Drawing.Size(52, 25);
        NUD_L2.TabIndex = 72;
        // 
        // NUD_F2
        // 
        NUD_F2.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_F2.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_F2.Location = new System.Drawing.Point(601, 102);
        NUD_F2.Margin = new Padding(4, 3, 4, 3);
        NUD_F2.Maximum = new decimal(new int[] { 127, 0, 0, 0 });
        NUD_F2.Minimum = new decimal(new int[] { 127, 0, 0, int.MinValue });
        NUD_F2.Name = "NUD_F2";
        NUD_F2.Size = new System.Drawing.Size(52, 25);
        NUD_F2.TabIndex = 71;
        NUD_F2.ValueChanged += ChangeInto;
        // 
        // PB_2
        // 
        PB_2.Location = new System.Drawing.Point(92, 92);
        PB_2.Margin = new Padding(4, 3, 4, 3);
        PB_2.Name = "PB_2";
        PB_2.Size = new System.Drawing.Size(47, 40);
        PB_2.TabIndex = 70;
        PB_2.TabStop = false;
        // 
        // CB_P2
        // 
        CB_P2.AutoCompleteMode = AutoCompleteMode.Suggest;
        CB_P2.AutoCompleteSource = AutoCompleteSource.ListItems;
        CB_P2.FormattingEnabled = true;
        CB_P2.Location = new System.Drawing.Point(453, 101);
        CB_P2.Margin = new Padding(4, 3, 4, 3);
        CB_P2.Name = "CB_P2";
        CB_P2.Size = new System.Drawing.Size(140, 25);
        CB_P2.TabIndex = 69;
        // 
        // CB_I2
        // 
        CB_I2.AutoCompleteMode = AutoCompleteMode.Suggest;
        CB_I2.AutoCompleteSource = AutoCompleteSource.ListItems;
        CB_I2.FormattingEnabled = true;
        CB_I2.Location = new System.Drawing.Point(328, 101);
        CB_I2.Margin = new Padding(4, 3, 4, 3);
        CB_I2.Name = "CB_I2";
        CB_I2.Size = new System.Drawing.Size(117, 25);
        CB_I2.TabIndex = 68;
        CB_I2.SelectedIndexChanged += ChangeInto;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(4, 100);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(80, 26);
        label1.TabIndex = 67;
        label1.Text = "Method 2:";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // CB_M2
        // 
        CB_M2.DropDownStyle = ComboBoxStyle.DropDownList;
        CB_M2.DropDownWidth = 200;
        CB_M2.FormattingEnabled = true;
        CB_M2.Location = new System.Drawing.Point(146, 101);
        CB_M2.Margin = new Padding(4, 3, 4, 3);
        CB_M2.MaxDropDownItems = 10;
        CB_M2.Name = "CB_M2";
        CB_M2.Size = new System.Drawing.Size(174, 25);
        CB_M2.TabIndex = 66;
        CB_M2.SelectedIndexChanged += ChangeMethod;
        // 
        // NUD_L3
        // 
        NUD_L3.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_L3.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_L3.Location = new System.Drawing.Point(660, 143);
        NUD_L3.Margin = new Padding(4, 3, 4, 3);
        NUD_L3.Maximum = new decimal(new int[] { 127, 0, 0, 0 });
        NUD_L3.Minimum = new decimal(new int[] { 127, 0, 0, int.MinValue });
        NUD_L3.Name = "NUD_L3";
        NUD_L3.Size = new System.Drawing.Size(52, 25);
        NUD_L3.TabIndex = 79;
        // 
        // NUD_F3
        // 
        NUD_F3.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_F3.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_F3.Location = new System.Drawing.Point(601, 143);
        NUD_F3.Margin = new Padding(4, 3, 4, 3);
        NUD_F3.Maximum = new decimal(new int[] { 127, 0, 0, 0 });
        NUD_F3.Minimum = new decimal(new int[] { 127, 0, 0, int.MinValue });
        NUD_F3.Name = "NUD_F3";
        NUD_F3.Size = new System.Drawing.Size(52, 25);
        NUD_F3.TabIndex = 78;
        NUD_F3.ValueChanged += ChangeInto;
        // 
        // PB_3
        // 
        PB_3.Location = new System.Drawing.Point(92, 133);
        PB_3.Margin = new Padding(4, 3, 4, 3);
        PB_3.Name = "PB_3";
        PB_3.Size = new System.Drawing.Size(47, 40);
        PB_3.TabIndex = 77;
        PB_3.TabStop = false;
        // 
        // CB_P3
        // 
        CB_P3.AutoCompleteMode = AutoCompleteMode.Suggest;
        CB_P3.AutoCompleteSource = AutoCompleteSource.ListItems;
        CB_P3.FormattingEnabled = true;
        CB_P3.Location = new System.Drawing.Point(453, 142);
        CB_P3.Margin = new Padding(4, 3, 4, 3);
        CB_P3.Name = "CB_P3";
        CB_P3.Size = new System.Drawing.Size(140, 25);
        CB_P3.TabIndex = 76;
        // 
        // CB_I3
        // 
        CB_I3.AutoCompleteMode = AutoCompleteMode.Suggest;
        CB_I3.AutoCompleteSource = AutoCompleteSource.ListItems;
        CB_I3.FormattingEnabled = true;
        CB_I3.Location = new System.Drawing.Point(328, 142);
        CB_I3.Margin = new Padding(4, 3, 4, 3);
        CB_I3.Name = "CB_I3";
        CB_I3.Size = new System.Drawing.Size(117, 25);
        CB_I3.TabIndex = 75;
        CB_I3.SelectedIndexChanged += ChangeInto;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(4, 139);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(80, 26);
        label2.TabIndex = 74;
        label2.Text = "Method 3:";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // CB_M3
        // 
        CB_M3.DropDownStyle = ComboBoxStyle.DropDownList;
        CB_M3.DropDownWidth = 200;
        CB_M3.FormattingEnabled = true;
        CB_M3.Location = new System.Drawing.Point(146, 142);
        CB_M3.Margin = new Padding(4, 3, 4, 3);
        CB_M3.MaxDropDownItems = 10;
        CB_M3.Name = "CB_M3";
        CB_M3.Size = new System.Drawing.Size(174, 25);
        CB_M3.TabIndex = 73;
        CB_M3.SelectedIndexChanged += ChangeMethod;
        // 
        // NUD_L4
        // 
        NUD_L4.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_L4.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_L4.Location = new System.Drawing.Point(660, 184);
        NUD_L4.Margin = new Padding(4, 3, 4, 3);
        NUD_L4.Maximum = new decimal(new int[] { 127, 0, 0, 0 });
        NUD_L4.Minimum = new decimal(new int[] { 127, 0, 0, int.MinValue });
        NUD_L4.Name = "NUD_L4";
        NUD_L4.Size = new System.Drawing.Size(52, 25);
        NUD_L4.TabIndex = 86;
        // 
        // NUD_F4
        // 
        NUD_F4.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_F4.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_F4.Location = new System.Drawing.Point(601, 184);
        NUD_F4.Margin = new Padding(4, 3, 4, 3);
        NUD_F4.Maximum = new decimal(new int[] { 127, 0, 0, 0 });
        NUD_F4.Minimum = new decimal(new int[] { 127, 0, 0, int.MinValue });
        NUD_F4.Name = "NUD_F4";
        NUD_F4.Size = new System.Drawing.Size(52, 25);
        NUD_F4.TabIndex = 85;
        NUD_F4.ValueChanged += ChangeInto;
        // 
        // PB_4
        // 
        PB_4.Location = new System.Drawing.Point(92, 172);
        PB_4.Margin = new Padding(4, 3, 4, 3);
        PB_4.Name = "PB_4";
        PB_4.Size = new System.Drawing.Size(47, 40);
        PB_4.TabIndex = 84;
        PB_4.TabStop = false;
        // 
        // CB_P4
        // 
        CB_P4.AutoCompleteMode = AutoCompleteMode.Suggest;
        CB_P4.AutoCompleteSource = AutoCompleteSource.ListItems;
        CB_P4.FormattingEnabled = true;
        CB_P4.Location = new System.Drawing.Point(453, 181);
        CB_P4.Margin = new Padding(4, 3, 4, 3);
        CB_P4.Name = "CB_P4";
        CB_P4.Size = new System.Drawing.Size(140, 25);
        CB_P4.TabIndex = 83;
        // 
        // CB_I4
        // 
        CB_I4.AutoCompleteMode = AutoCompleteMode.Suggest;
        CB_I4.AutoCompleteSource = AutoCompleteSource.ListItems;
        CB_I4.FormattingEnabled = true;
        CB_I4.Location = new System.Drawing.Point(328, 181);
        CB_I4.Margin = new Padding(4, 3, 4, 3);
        CB_I4.Name = "CB_I4";
        CB_I4.Size = new System.Drawing.Size(117, 25);
        CB_I4.TabIndex = 82;
        CB_I4.SelectedIndexChanged += ChangeInto;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(4, 180);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(80, 26);
        label3.TabIndex = 81;
        label3.Text = "Method 4:";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // CB_M4
        // 
        CB_M4.DropDownStyle = ComboBoxStyle.DropDownList;
        CB_M4.DropDownWidth = 200;
        CB_M4.FormattingEnabled = true;
        CB_M4.Location = new System.Drawing.Point(146, 181);
        CB_M4.Margin = new Padding(4, 3, 4, 3);
        CB_M4.MaxDropDownItems = 10;
        CB_M4.Name = "CB_M4";
        CB_M4.Size = new System.Drawing.Size(174, 25);
        CB_M4.TabIndex = 80;
        CB_M4.SelectedIndexChanged += ChangeMethod;
        // 
        // NUD_L5
        // 
        NUD_L5.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_L5.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_L5.Location = new System.Drawing.Point(660, 223);
        NUD_L5.Margin = new Padding(4, 3, 4, 3);
        NUD_L5.Maximum = new decimal(new int[] { 127, 0, 0, 0 });
        NUD_L5.Minimum = new decimal(new int[] { 127, 0, 0, int.MinValue });
        NUD_L5.Name = "NUD_L5";
        NUD_L5.Size = new System.Drawing.Size(52, 25);
        NUD_L5.TabIndex = 93;
        // 
        // NUD_F5
        // 
        NUD_F5.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_F5.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_F5.Location = new System.Drawing.Point(601, 223);
        NUD_F5.Margin = new Padding(4, 3, 4, 3);
        NUD_F5.Maximum = new decimal(new int[] { 127, 0, 0, 0 });
        NUD_F5.Minimum = new decimal(new int[] { 127, 0, 0, int.MinValue });
        NUD_F5.Name = "NUD_F5";
        NUD_F5.Size = new System.Drawing.Size(52, 25);
        NUD_F5.TabIndex = 92;
        NUD_F5.ValueChanged += ChangeInto;
        // 
        // PB_5
        // 
        PB_5.Location = new System.Drawing.Point(92, 213);
        PB_5.Margin = new Padding(4, 3, 4, 3);
        PB_5.Name = "PB_5";
        PB_5.Size = new System.Drawing.Size(47, 40);
        PB_5.TabIndex = 91;
        PB_5.TabStop = false;
        // 
        // CB_P5
        // 
        CB_P5.AutoCompleteMode = AutoCompleteMode.Suggest;
        CB_P5.AutoCompleteSource = AutoCompleteSource.ListItems;
        CB_P5.FormattingEnabled = true;
        CB_P5.Location = new System.Drawing.Point(453, 222);
        CB_P5.Margin = new Padding(4, 3, 4, 3);
        CB_P5.Name = "CB_P5";
        CB_P5.Size = new System.Drawing.Size(140, 25);
        CB_P5.TabIndex = 90;
        // 
        // CB_I5
        // 
        CB_I5.AutoCompleteMode = AutoCompleteMode.Suggest;
        CB_I5.AutoCompleteSource = AutoCompleteSource.ListItems;
        CB_I5.FormattingEnabled = true;
        CB_I5.Location = new System.Drawing.Point(328, 222);
        CB_I5.Margin = new Padding(4, 3, 4, 3);
        CB_I5.Name = "CB_I5";
        CB_I5.Size = new System.Drawing.Size(117, 25);
        CB_I5.TabIndex = 89;
        CB_I5.SelectedIndexChanged += ChangeInto;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(4, 221);
        label4.Margin = new Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(80, 26);
        label4.TabIndex = 88;
        label4.Text = "Method 5:";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // CB_M5
        // 
        CB_M5.DropDownStyle = ComboBoxStyle.DropDownList;
        CB_M5.DropDownWidth = 200;
        CB_M5.FormattingEnabled = true;
        CB_M5.Location = new System.Drawing.Point(146, 222);
        CB_M5.Margin = new Padding(4, 3, 4, 3);
        CB_M5.MaxDropDownItems = 10;
        CB_M5.Name = "CB_M5";
        CB_M5.Size = new System.Drawing.Size(174, 25);
        CB_M5.TabIndex = 87;
        CB_M5.SelectedIndexChanged += ChangeMethod;
        // 
        // NUD_L6
        // 
        NUD_L6.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_L6.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_L6.Location = new System.Drawing.Point(660, 264);
        NUD_L6.Margin = new Padding(4, 3, 4, 3);
        NUD_L6.Maximum = new decimal(new int[] { 127, 0, 0, 0 });
        NUD_L6.Minimum = new decimal(new int[] { 127, 0, 0, int.MinValue });
        NUD_L6.Name = "NUD_L6";
        NUD_L6.Size = new System.Drawing.Size(52, 25);
        NUD_L6.TabIndex = 100;
        // 
        // NUD_F6
        // 
        NUD_F6.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_F6.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_F6.Location = new System.Drawing.Point(601, 264);
        NUD_F6.Margin = new Padding(4, 3, 4, 3);
        NUD_F6.Maximum = new decimal(new int[] { 127, 0, 0, 0 });
        NUD_F6.Minimum = new decimal(new int[] { 127, 0, 0, int.MinValue });
        NUD_F6.Name = "NUD_F6";
        NUD_F6.Size = new System.Drawing.Size(52, 25);
        NUD_F6.TabIndex = 99;
        NUD_F6.ValueChanged += ChangeInto;
        // 
        // PB_6
        // 
        PB_6.Location = new System.Drawing.Point(92, 254);
        PB_6.Margin = new Padding(4, 3, 4, 3);
        PB_6.Name = "PB_6";
        PB_6.Size = new System.Drawing.Size(47, 40);
        PB_6.TabIndex = 98;
        PB_6.TabStop = false;
        // 
        // CB_P6
        // 
        CB_P6.AutoCompleteMode = AutoCompleteMode.Suggest;
        CB_P6.AutoCompleteSource = AutoCompleteSource.ListItems;
        CB_P6.FormattingEnabled = true;
        CB_P6.Location = new System.Drawing.Point(453, 263);
        CB_P6.Margin = new Padding(4, 3, 4, 3);
        CB_P6.Name = "CB_P6";
        CB_P6.Size = new System.Drawing.Size(140, 25);
        CB_P6.TabIndex = 97;
        // 
        // CB_I6
        // 
        CB_I6.AutoCompleteMode = AutoCompleteMode.Suggest;
        CB_I6.AutoCompleteSource = AutoCompleteSource.ListItems;
        CB_I6.FormattingEnabled = true;
        CB_I6.Location = new System.Drawing.Point(328, 263);
        CB_I6.Margin = new Padding(4, 3, 4, 3);
        CB_I6.Name = "CB_I6";
        CB_I6.Size = new System.Drawing.Size(117, 25);
        CB_I6.TabIndex = 96;
        CB_I6.SelectedIndexChanged += ChangeInto;
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(4, 262);
        label5.Margin = new Padding(4, 0, 4, 0);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(80, 26);
        label5.TabIndex = 95;
        label5.Text = "Method 6:";
        label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // CB_M6
        // 
        CB_M6.DropDownStyle = ComboBoxStyle.DropDownList;
        CB_M6.DropDownWidth = 200;
        CB_M6.FormattingEnabled = true;
        CB_M6.Location = new System.Drawing.Point(146, 263);
        CB_M6.Margin = new Padding(4, 3, 4, 3);
        CB_M6.MaxDropDownItems = 10;
        CB_M6.Name = "CB_M6";
        CB_M6.Size = new System.Drawing.Size(174, 25);
        CB_M6.TabIndex = 94;
        CB_M6.SelectedIndexChanged += ChangeMethod;
        // 
        // NUD_L7
        // 
        NUD_L7.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_L7.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_L7.Location = new System.Drawing.Point(660, 305);
        NUD_L7.Margin = new Padding(4, 3, 4, 3);
        NUD_L7.Maximum = new decimal(new int[] { 127, 0, 0, 0 });
        NUD_L7.Minimum = new decimal(new int[] { 127, 0, 0, int.MinValue });
        NUD_L7.Name = "NUD_L7";
        NUD_L7.Size = new System.Drawing.Size(52, 25);
        NUD_L7.TabIndex = 107;
        // 
        // NUD_F7
        // 
        NUD_F7.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_F7.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_F7.Location = new System.Drawing.Point(601, 305);
        NUD_F7.Margin = new Padding(4, 3, 4, 3);
        NUD_F7.Maximum = new decimal(new int[] { 127, 0, 0, 0 });
        NUD_F7.Minimum = new decimal(new int[] { 127, 0, 0, int.MinValue });
        NUD_F7.Name = "NUD_F7";
        NUD_F7.Size = new System.Drawing.Size(52, 25);
        NUD_F7.TabIndex = 106;
        NUD_F7.ValueChanged += ChangeInto;
        // 
        // PB_7
        // 
        PB_7.Location = new System.Drawing.Point(92, 295);
        PB_7.Margin = new Padding(4, 3, 4, 3);
        PB_7.Name = "PB_7";
        PB_7.Size = new System.Drawing.Size(47, 40);
        PB_7.TabIndex = 105;
        PB_7.TabStop = false;
        // 
        // CB_P7
        // 
        CB_P7.AutoCompleteMode = AutoCompleteMode.Suggest;
        CB_P7.AutoCompleteSource = AutoCompleteSource.ListItems;
        CB_P7.FormattingEnabled = true;
        CB_P7.Location = new System.Drawing.Point(453, 304);
        CB_P7.Margin = new Padding(4, 3, 4, 3);
        CB_P7.Name = "CB_P7";
        CB_P7.Size = new System.Drawing.Size(140, 25);
        CB_P7.TabIndex = 104;
        // 
        // CB_I7
        // 
        CB_I7.AutoCompleteMode = AutoCompleteMode.Suggest;
        CB_I7.AutoCompleteSource = AutoCompleteSource.ListItems;
        CB_I7.FormattingEnabled = true;
        CB_I7.Location = new System.Drawing.Point(328, 304);
        CB_I7.Margin = new Padding(4, 3, 4, 3);
        CB_I7.Name = "CB_I7";
        CB_I7.Size = new System.Drawing.Size(117, 25);
        CB_I7.TabIndex = 103;
        CB_I7.SelectedIndexChanged += ChangeInto;
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(4, 303);
        label6.Margin = new Padding(4, 0, 4, 0);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(80, 26);
        label6.TabIndex = 102;
        label6.Text = "Method 7:";
        label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // CB_M7
        // 
        CB_M7.DropDownStyle = ComboBoxStyle.DropDownList;
        CB_M7.DropDownWidth = 200;
        CB_M7.FormattingEnabled = true;
        CB_M7.Location = new System.Drawing.Point(146, 304);
        CB_M7.Margin = new Padding(4, 3, 4, 3);
        CB_M7.MaxDropDownItems = 10;
        CB_M7.Name = "CB_M7";
        CB_M7.Size = new System.Drawing.Size(174, 25);
        CB_M7.TabIndex = 101;
        CB_M7.SelectedIndexChanged += ChangeMethod;
        // 
        // NUD_L8
        // 
        NUD_L8.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_L8.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_L8.Location = new System.Drawing.Point(660, 346);
        NUD_L8.Margin = new Padding(4, 3, 4, 3);
        NUD_L8.Maximum = new decimal(new int[] { 127, 0, 0, 0 });
        NUD_L8.Minimum = new decimal(new int[] { 127, 0, 0, int.MinValue });
        NUD_L8.Name = "NUD_L8";
        NUD_L8.Size = new System.Drawing.Size(52, 25);
        NUD_L8.TabIndex = 114;
        // 
        // NUD_F8
        // 
        NUD_F8.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_F8.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_F8.Location = new System.Drawing.Point(601, 346);
        NUD_F8.Margin = new Padding(4, 3, 4, 3);
        NUD_F8.Maximum = new decimal(new int[] { 127, 0, 0, 0 });
        NUD_F8.Minimum = new decimal(new int[] { 127, 0, 0, int.MinValue });
        NUD_F8.Name = "NUD_F8";
        NUD_F8.Size = new System.Drawing.Size(52, 25);
        NUD_F8.TabIndex = 113;
        NUD_F8.ValueChanged += ChangeInto;
        // 
        // PB_8
        // 
        PB_8.Location = new System.Drawing.Point(92, 334);
        PB_8.Margin = new Padding(4, 3, 4, 3);
        PB_8.Name = "PB_8";
        PB_8.Size = new System.Drawing.Size(47, 40);
        PB_8.TabIndex = 112;
        PB_8.TabStop = false;
        // 
        // CB_P8
        // 
        CB_P8.AutoCompleteMode = AutoCompleteMode.Suggest;
        CB_P8.AutoCompleteSource = AutoCompleteSource.ListItems;
        CB_P8.FormattingEnabled = true;
        CB_P8.Location = new System.Drawing.Point(453, 343);
        CB_P8.Margin = new Padding(4, 3, 4, 3);
        CB_P8.Name = "CB_P8";
        CB_P8.Size = new System.Drawing.Size(140, 25);
        CB_P8.TabIndex = 111;
        // 
        // CB_I8
        // 
        CB_I8.AutoCompleteMode = AutoCompleteMode.Suggest;
        CB_I8.AutoCompleteSource = AutoCompleteSource.ListItems;
        CB_I8.FormattingEnabled = true;
        CB_I8.Location = new System.Drawing.Point(328, 343);
        CB_I8.Margin = new Padding(4, 3, 4, 3);
        CB_I8.Name = "CB_I8";
        CB_I8.Size = new System.Drawing.Size(117, 25);
        CB_I8.TabIndex = 110;
        CB_I8.SelectedIndexChanged += ChangeInto;
        // 
        // label7
        // 
        label7.Location = new System.Drawing.Point(4, 342);
        label7.Margin = new Padding(4, 0, 4, 0);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(80, 26);
        label7.TabIndex = 109;
        label7.Text = "Method 8:";
        label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // CB_M8
        // 
        CB_M8.DropDownStyle = ComboBoxStyle.DropDownList;
        CB_M8.DropDownWidth = 200;
        CB_M8.FormattingEnabled = true;
        CB_M8.Location = new System.Drawing.Point(146, 343);
        CB_M8.Margin = new Padding(4, 3, 4, 3);
        CB_M8.MaxDropDownItems = 10;
        CB_M8.Name = "CB_M8";
        CB_M8.Size = new System.Drawing.Size(174, 25);
        CB_M8.TabIndex = 108;
        CB_M8.SelectedIndexChanged += ChangeMethod;
        // 
        // B_Trade
        // 
        B_Trade.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_Trade.FlatAppearance.BorderColor = System.Drawing.Color.Red;
        B_Trade.FlatStyle = FlatStyle.Flat;
        B_Trade.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Trade.ForeColor = System.Drawing.Color.Red;
        B_Trade.Location = new System.Drawing.Point(548, 479);
        B_Trade.Margin = new Padding(4, 3, 4, 3);
        B_Trade.Name = "B_Trade";
        B_Trade.Size = new System.Drawing.Size(167, 35);
        B_Trade.TabIndex = 116;
        B_Trade.Text = "Remove Trade Evolutions";
        B_Trade.UseVisualStyleBackColor = false;
        B_Trade.Click += B_Trade_Click;
        // 
        // B_EveryLevel
        // 
        B_EveryLevel.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_EveryLevel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(192, 192, 255);
        B_EveryLevel.FlatStyle = FlatStyle.Flat;
        B_EveryLevel.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_EveryLevel.ForeColor = System.Drawing.Color.FromArgb(192, 192, 255);
        B_EveryLevel.Location = new System.Drawing.Point(523, 10);
        B_EveryLevel.Margin = new Padding(4, 3, 4, 3);
        B_EveryLevel.Name = "B_EveryLevel";
        B_EveryLevel.Size = new System.Drawing.Size(192, 35);
        B_EveryLevel.TabIndex = 117;
        B_EveryLevel.Text = "Random Evolution Every Level";
        B_EveryLevel.UseVisualStyleBackColor = false;
        B_EveryLevel.Click += B_EveryLevel_Click;
        // 
        // EvolutionEditor7
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        ClientSize = new System.Drawing.Size(728, 530);
        Controls.Add(B_EveryLevel);
        Controls.Add(B_Trade);
        Controls.Add(NUD_L8);
        Controls.Add(NUD_F8);
        Controls.Add(PB_8);
        Controls.Add(CB_P8);
        Controls.Add(B_RandAll);
        Controls.Add(CB_I8);
        Controls.Add(label7);
        Controls.Add(CB_M8);
        Controls.Add(NUD_L7);
        Controls.Add(NUD_F7);
        Controls.Add(PB_7);
        Controls.Add(CB_P7);
        Controls.Add(CB_I7);
        Controls.Add(label6);
        Controls.Add(CB_M7);
        Controls.Add(NUD_L6);
        Controls.Add(NUD_F6);
        Controls.Add(PB_6);
        Controls.Add(CB_P6);
        Controls.Add(CB_I6);
        Controls.Add(label5);
        Controls.Add(CB_M6);
        Controls.Add(NUD_L5);
        Controls.Add(NUD_F5);
        Controls.Add(PB_5);
        Controls.Add(CB_P5);
        Controls.Add(CB_I5);
        Controls.Add(label4);
        Controls.Add(CB_M5);
        Controls.Add(NUD_L4);
        Controls.Add(NUD_F4);
        Controls.Add(PB_4);
        Controls.Add(CB_P4);
        Controls.Add(CB_I4);
        Controls.Add(label3);
        Controls.Add(CB_M4);
        Controls.Add(NUD_L3);
        Controls.Add(NUD_F3);
        Controls.Add(PB_3);
        Controls.Add(CB_P3);
        Controls.Add(CB_I3);
        Controls.Add(label2);
        Controls.Add(CB_M3);
        Controls.Add(NUD_L2);
        Controls.Add(NUD_F2);
        Controls.Add(PB_2);
        Controls.Add(CB_P2);
        Controls.Add(CB_I2);
        Controls.Add(label1);
        Controls.Add(CB_M2);
        Controls.Add(NUD_L1);
        Controls.Add(NUD_F1);
        Controls.Add(GB_Randomizer);
        Controls.Add(PB_1);
        Controls.Add(CB_P1);
        Controls.Add(CB_I1);
        Controls.Add(L_M1);
        Controls.Add(CB_M1);
        Controls.Add(B_Dump);
        Controls.Add(L_Species);
        Controls.Add(CB_Species);
        Font = new System.Drawing.Font("Segoe UI", 10F);
        ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MaximumSize = new System.Drawing.Size(744, 569);
        MinimumSize = new System.Drawing.Size(744, 569);
        Name = "EvolutionEditor7";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Evolution Editor";
        FormClosing += Form_Closing;
        ((System.ComponentModel.ISupportInitialize)PB_1).EndInit();
        GB_Randomizer.ResumeLayout(false);
        GB_Randomizer.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_F1).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_L1).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_L2).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_F2).EndInit();
        ((System.ComponentModel.ISupportInitialize)PB_2).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_L3).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_F3).EndInit();
        ((System.ComponentModel.ISupportInitialize)PB_3).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_L4).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_F4).EndInit();
        ((System.ComponentModel.ISupportInitialize)PB_4).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_L5).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_F5).EndInit();
        ((System.ComponentModel.ISupportInitialize)PB_5).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_L6).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_F6).EndInit();
        ((System.ComponentModel.ISupportInitialize)PB_6).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_L7).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_F7).EndInit();
        ((System.ComponentModel.ISupportInitialize)PB_7).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_L8).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_F8).EndInit();
        ((System.ComponentModel.ISupportInitialize)PB_8).EndInit();
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox CB_Species;
    private System.Windows.Forms.Label L_Species;
    private System.Windows.Forms.Button B_Dump;
    private System.Windows.Forms.ComboBox CB_M1;
    private System.Windows.Forms.Label L_M1;
    private System.Windows.Forms.ComboBox CB_I1;
    private System.Windows.Forms.ComboBox CB_P1;
    private System.Windows.Forms.PictureBox PB_1;
    private System.Windows.Forms.Button B_RandAll;
    private System.Windows.Forms.GroupBox GB_Randomizer;
    private System.Windows.Forms.CheckBox CHK_Exp;
    private System.Windows.Forms.CheckBox CHK_Type;
    private System.Windows.Forms.CheckBox CHK_BST;
    private System.Windows.Forms.Label L_Protip;
    private System.Windows.Forms.NumericUpDown NUD_F1;
    private System.Windows.Forms.NumericUpDown NUD_L1;
    private System.Windows.Forms.NumericUpDown NUD_L2;
    private System.Windows.Forms.NumericUpDown NUD_F2;
    private System.Windows.Forms.PictureBox PB_2;
    private System.Windows.Forms.ComboBox CB_P2;
    private System.Windows.Forms.ComboBox CB_I2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox CB_M2;
    private System.Windows.Forms.NumericUpDown NUD_L3;
    private System.Windows.Forms.NumericUpDown NUD_F3;
    private System.Windows.Forms.PictureBox PB_3;
    private System.Windows.Forms.ComboBox CB_P3;
    private System.Windows.Forms.ComboBox CB_I3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox CB_M3;
    private System.Windows.Forms.NumericUpDown NUD_L4;
    private System.Windows.Forms.NumericUpDown NUD_F4;
    private System.Windows.Forms.PictureBox PB_4;
    private System.Windows.Forms.ComboBox CB_P4;
    private System.Windows.Forms.ComboBox CB_I4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox CB_M4;
    private System.Windows.Forms.NumericUpDown NUD_L5;
    private System.Windows.Forms.NumericUpDown NUD_F5;
    private System.Windows.Forms.PictureBox PB_5;
    private System.Windows.Forms.ComboBox CB_P5;
    private System.Windows.Forms.ComboBox CB_I5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox CB_M5;
    private System.Windows.Forms.NumericUpDown NUD_L6;
    private System.Windows.Forms.NumericUpDown NUD_F6;
    private System.Windows.Forms.PictureBox PB_6;
    private System.Windows.Forms.ComboBox CB_P6;
    private System.Windows.Forms.ComboBox CB_I6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox CB_M6;
    private System.Windows.Forms.NumericUpDown NUD_L7;
    private System.Windows.Forms.NumericUpDown NUD_F7;
    private System.Windows.Forms.PictureBox PB_7;
    private System.Windows.Forms.ComboBox CB_P7;
    private System.Windows.Forms.ComboBox CB_I7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ComboBox CB_M7;
    private System.Windows.Forms.NumericUpDown NUD_L8;
    private System.Windows.Forms.NumericUpDown NUD_F8;
    private System.Windows.Forms.PictureBox PB_8;
    private System.Windows.Forms.ComboBox CB_P8;
    private System.Windows.Forms.ComboBox CB_I8;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.ComboBox CB_M8;
    private System.Windows.Forms.Button B_Trade;
    private System.Windows.Forms.Button B_EveryLevel;
    private System.Windows.Forms.CheckBox CHK_E;
    private System.Windows.Forms.CheckBox CHK_L;
}
