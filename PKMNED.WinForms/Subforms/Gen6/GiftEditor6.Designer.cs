namespace PKMNED.WinForms;

partial class GiftEditor6
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiftEditor6));
        B_Cancel = new System.Windows.Forms.Button();
        B_Save = new System.Windows.Forms.Button();
        LB_Gifts = new System.Windows.Forms.ListBox();
        CB_Species = new System.Windows.Forms.ComboBox();
        CB_HeldItem = new System.Windows.Forms.ComboBox();
        L_Species = new System.Windows.Forms.Label();
        L_HeldItem = new System.Windows.Forms.Label();
        NUD_Level = new System.Windows.Forms.NumericUpDown();
        L_Level = new System.Windows.Forms.Label();
        NUD_Form = new System.Windows.Forms.NumericUpDown();
        L_Form = new System.Windows.Forms.Label();
        L_Nature = new System.Windows.Forms.Label();
        B_RandAll = new System.Windows.Forms.Button();
        tabControl1 = new System.Windows.Forms.TabControl();
        tabPage1 = new System.Windows.Forms.TabPage();
        L_Gender = new System.Windows.Forms.Label();
        CB_Gender = new System.Windows.Forms.ComboBox();
        L_Ability = new System.Windows.Forms.Label();
        CB_Ability = new System.Windows.Forms.ComboBox();
        CB_Nature = new System.Windows.Forms.ComboBox();
        GB_EIVs = new System.Windows.Forms.GroupBox();
        L_HP = new System.Windows.Forms.Label();
        NUD_IV3 = new System.Windows.Forms.NumericUpDown();
        NUD_IV4 = new System.Windows.Forms.NumericUpDown();
        NUD_IV5 = new System.Windows.Forms.NumericUpDown();
        L_SPD = new System.Windows.Forms.Label();
        L_SPE = new System.Windows.Forms.Label();
        L_SPA = new System.Windows.Forms.Label();
        NUD_IV2 = new System.Windows.Forms.NumericUpDown();
        NUD_IV1 = new System.Windows.Forms.NumericUpDown();
        NUD_IV0 = new System.Windows.Forms.NumericUpDown();
        L_ATK = new System.Windows.Forms.Label();
        L_DEF = new System.Windows.Forms.Label();
        CHK_ShinyLock = new System.Windows.Forms.CheckBox();
        tabPage2 = new System.Windows.Forms.TabPage();
        B_ModifyLevel = new System.Windows.Forms.Button();
        GB_Tweak = new System.Windows.Forms.GroupBox();
        CHK_AllowMega = new System.Windows.Forms.CheckBox();
        NUD_ForceFullyEvolved = new System.Windows.Forms.NumericUpDown();
        CHK_ForceFullyEvolved = new System.Windows.Forms.CheckBox();
        CHK_RandomAbility = new System.Windows.Forms.CheckBox();
        CHK_RemoveShinyLock = new System.Windows.Forms.CheckBox();
        CHK_Item = new System.Windows.Forms.CheckBox();
        L_RandOpt = new System.Windows.Forms.Label();
        CHK_BST = new System.Windows.Forms.CheckBox();
        CHK_E = new System.Windows.Forms.CheckBox();
        CHK_L = new System.Windows.Forms.CheckBox();
        CHK_G6 = new System.Windows.Forms.CheckBox();
        CHK_G5 = new System.Windows.Forms.CheckBox();
        CHK_G4 = new System.Windows.Forms.CheckBox();
        CHK_G3 = new System.Windows.Forms.CheckBox();
        CHK_G2 = new System.Windows.Forms.CheckBox();
        CHK_G1 = new System.Windows.Forms.CheckBox();
        L_Mega = new System.Windows.Forms.Label();
        CHK_ReplaceMega = new System.Windows.Forms.CheckBox();
        NUD_LevelBoost = new System.Windows.Forms.NumericUpDown();
        CHK_Level = new System.Windows.Forms.CheckBox();
        ((System.ComponentModel.ISupportInitialize)NUD_Level).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Form).BeginInit();
        tabControl1.SuspendLayout();
        tabPage1.SuspendLayout();
        GB_EIVs.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_IV3).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_IV4).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_IV5).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_IV2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_IV1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_IV0).BeginInit();
        tabPage2.SuspendLayout();
        GB_Tweak.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_ForceFullyEvolved).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_LevelBoost).BeginInit();
        SuspendLayout();
        // 
        // B_Cancel
        // 
        B_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        B_Cancel.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
        B_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Cancel.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Cancel.ForeColor = System.Drawing.Color.Red;
        B_Cancel.Location = new System.Drawing.Point(302, 446);
        B_Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Cancel.Name = "B_Cancel";
        B_Cancel.Size = new System.Drawing.Size(82, 31);
        B_Cancel.TabIndex = 467;
        B_Cancel.Text = "Cancel";
        B_Cancel.UseVisualStyleBackColor = false;
        B_Cancel.Click += B_Cancel_Click;
        // 
        // B_Save
        // 
        B_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        B_Save.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(154, 205, 50);
        B_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Save.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Save.ForeColor = System.Drawing.Color.FromArgb(154, 205, 50);
        B_Save.Location = new System.Drawing.Point(391, 446);
        B_Save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Save.Name = "B_Save";
        B_Save.Size = new System.Drawing.Size(82, 31);
        B_Save.TabIndex = 466;
        B_Save.Text = "Save";
        B_Save.UseVisualStyleBackColor = false;
        B_Save.Click += B_Save_Click;
        // 
        // LB_Gifts
        // 
        LB_Gifts.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        LB_Gifts.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        LB_Gifts.Font = new System.Drawing.Font("Segoe UI", 10F);
        LB_Gifts.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        LB_Gifts.FormattingEnabled = true;
        LB_Gifts.Location = new System.Drawing.Point(2, 2);
        LB_Gifts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        LB_Gifts.Name = "LB_Gifts";
        LB_Gifts.Size = new System.Drawing.Size(128, 480);
        LB_Gifts.TabIndex = 468;
        LB_Gifts.SelectedIndexChanged += ChangeIndex;
        // 
        // CB_Species
        // 
        CB_Species.FormattingEnabled = true;
        CB_Species.Location = new System.Drawing.Point(76, 9);
        CB_Species.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CB_Species.Name = "CB_Species";
        CB_Species.Size = new System.Drawing.Size(158, 25);
        CB_Species.TabIndex = 469;
        CB_Species.SelectedIndexChanged += ChangeSpecies;
        // 
        // CB_HeldItem
        // 
        CB_HeldItem.FormattingEnabled = true;
        CB_HeldItem.Location = new System.Drawing.Point(76, 151);
        CB_HeldItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CB_HeldItem.Name = "CB_HeldItem";
        CB_HeldItem.Size = new System.Drawing.Size(158, 25);
        CB_HeldItem.TabIndex = 470;
        // 
        // L_Species
        // 
        L_Species.Location = new System.Drawing.Point(10, 8);
        L_Species.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Species.Name = "L_Species";
        L_Species.Size = new System.Drawing.Size(64, 31);
        L_Species.TabIndex = 477;
        L_Species.Text = "Species:";
        L_Species.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // L_HeldItem
        // 
        L_HeldItem.Location = new System.Drawing.Point(0, 150);
        L_HeldItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_HeldItem.Name = "L_HeldItem";
        L_HeldItem.Size = new System.Drawing.Size(74, 31);
        L_HeldItem.TabIndex = 478;
        L_HeldItem.Text = "Held Item:";
        L_HeldItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // NUD_Level
        // 
        NUD_Level.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        NUD_Level.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_Level.Location = new System.Drawing.Point(76, 37);
        NUD_Level.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_Level.Name = "NUD_Level";
        NUD_Level.Size = new System.Drawing.Size(48, 25);
        NUD_Level.TabIndex = 479;
        NUD_Level.Value = new decimal(new int[] { 100, 0, 0, 0 });
        // 
        // L_Level
        // 
        L_Level.Location = new System.Drawing.Point(10, 34);
        L_Level.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Level.Name = "L_Level";
        L_Level.Size = new System.Drawing.Size(64, 31);
        L_Level.TabIndex = 480;
        L_Level.Text = "Level:";
        L_Level.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // NUD_Form
        // 
        NUD_Form.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        NUD_Form.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_Form.Location = new System.Drawing.Point(76, 66);
        NUD_Form.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_Form.Name = "NUD_Form";
        NUD_Form.Size = new System.Drawing.Size(48, 25);
        NUD_Form.TabIndex = 481;
        // 
        // L_Form
        // 
        L_Form.Location = new System.Drawing.Point(10, 61);
        L_Form.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Form.Name = "L_Form";
        L_Form.Size = new System.Drawing.Size(64, 31);
        L_Form.TabIndex = 482;
        L_Form.Text = "Form:";
        L_Form.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // L_Nature
        // 
        L_Nature.Location = new System.Drawing.Point(10, 178);
        L_Nature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Nature.Name = "L_Nature";
        L_Nature.Size = new System.Drawing.Size(64, 31);
        L_Nature.TabIndex = 490;
        L_Nature.Text = "Nature:";
        L_Nature.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // B_RandAll
        // 
        B_RandAll.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        B_RandAll.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_RandAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(166, 136, 210);
        B_RandAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_RandAll.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_RandAll.ForeColor = System.Drawing.Color.FromArgb(166, 136, 210);
        B_RandAll.Location = new System.Drawing.Point(139, 447);
        B_RandAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_RandAll.Name = "B_RandAll";
        B_RandAll.Size = new System.Drawing.Size(97, 31);
        B_RandAll.TabIndex = 496;
        B_RandAll.Text = "Randomize All";
        B_RandAll.UseVisualStyleBackColor = false;
        B_RandAll.Click += B_RandAll_Click;
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tabPage1);
        tabControl1.Controls.Add(tabPage2);
        tabControl1.Location = new System.Drawing.Point(138, 16);
        tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new System.Drawing.Size(334, 422);
        tabControl1.TabIndex = 502;
        // 
        // tabPage1
        // 
        tabPage1.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        tabPage1.Controls.Add(L_Gender);
        tabPage1.Controls.Add(CB_Gender);
        tabPage1.Controls.Add(L_Ability);
        tabPage1.Controls.Add(CB_Ability);
        tabPage1.Controls.Add(CB_Nature);
        tabPage1.Controls.Add(GB_EIVs);
        tabPage1.Controls.Add(CHK_ShinyLock);
        tabPage1.Controls.Add(CB_Species);
        tabPage1.Controls.Add(L_Nature);
        tabPage1.Controls.Add(L_Species);
        tabPage1.Controls.Add(L_HeldItem);
        tabPage1.Controls.Add(NUD_Level);
        tabPage1.Controls.Add(L_Level);
        tabPage1.Controls.Add(L_Form);
        tabPage1.Controls.Add(CB_HeldItem);
        tabPage1.Controls.Add(NUD_Form);
        tabPage1.Location = new System.Drawing.Point(4, 26);
        tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tabPage1.Size = new System.Drawing.Size(326, 392);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "Editor";
        // 
        // L_Gender
        // 
        L_Gender.Location = new System.Drawing.Point(10, 120);
        L_Gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Gender.Name = "L_Gender";
        L_Gender.Size = new System.Drawing.Size(64, 31);
        L_Gender.TabIndex = 532;
        L_Gender.Text = "Gender:";
        L_Gender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // CB_Gender
        // 
        CB_Gender.FormattingEnabled = true;
        CB_Gender.Location = new System.Drawing.Point(76, 121);
        CB_Gender.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CB_Gender.Name = "CB_Gender";
        CB_Gender.Size = new System.Drawing.Size(158, 25);
        CB_Gender.TabIndex = 531;
        // 
        // L_Ability
        // 
        L_Ability.Location = new System.Drawing.Point(10, 92);
        L_Ability.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Ability.Name = "L_Ability";
        L_Ability.Size = new System.Drawing.Size(64, 31);
        L_Ability.TabIndex = 530;
        L_Ability.Text = "Ability:";
        L_Ability.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // CB_Ability
        // 
        CB_Ability.FormattingEnabled = true;
        CB_Ability.Location = new System.Drawing.Point(76, 93);
        CB_Ability.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CB_Ability.Name = "CB_Ability";
        CB_Ability.Size = new System.Drawing.Size(158, 25);
        CB_Ability.TabIndex = 529;
        // 
        // CB_Nature
        // 
        CB_Nature.FormattingEnabled = true;
        CB_Nature.Location = new System.Drawing.Point(76, 179);
        CB_Nature.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CB_Nature.Name = "CB_Nature";
        CB_Nature.Size = new System.Drawing.Size(158, 25);
        CB_Nature.TabIndex = 505;
        // 
        // GB_EIVs
        // 
        GB_EIVs.Controls.Add(L_HP);
        GB_EIVs.Controls.Add(NUD_IV3);
        GB_EIVs.Controls.Add(NUD_IV4);
        GB_EIVs.Controls.Add(NUD_IV5);
        GB_EIVs.Controls.Add(L_SPD);
        GB_EIVs.Controls.Add(L_SPE);
        GB_EIVs.Controls.Add(L_SPA);
        GB_EIVs.Controls.Add(NUD_IV2);
        GB_EIVs.Controls.Add(NUD_IV1);
        GB_EIVs.Controls.Add(NUD_IV0);
        GB_EIVs.Controls.Add(L_ATK);
        GB_EIVs.Controls.Add(L_DEF);
        GB_EIVs.Font = new System.Drawing.Font("Segoe UI", 10F);
        GB_EIVs.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        GB_EIVs.Location = new System.Drawing.Point(14, 232);
        GB_EIVs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        GB_EIVs.Name = "GB_EIVs";
        GB_EIVs.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        GB_EIVs.Size = new System.Drawing.Size(173, 146);
        GB_EIVs.TabIndex = 504;
        GB_EIVs.TabStop = false;
        GB_EIVs.Text = "IVs";
        // 
        // L_HP
        // 
        L_HP.Location = new System.Drawing.Point(3, 23);
        L_HP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_HP.Name = "L_HP";
        L_HP.Size = new System.Drawing.Size(34, 27);
        L_HP.TabIndex = 495;
        L_HP.Text = "HP:";
        L_HP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // NUD_IV3
        // 
        NUD_IV3.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        NUD_IV3.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_IV3.Location = new System.Drawing.Point(121, 24);
        NUD_IV3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_IV3.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_IV3.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
        NUD_IV3.Name = "NUD_IV3";
        NUD_IV3.Size = new System.Drawing.Size(40, 25);
        NUD_IV3.TabIndex = 492;
        NUD_IV3.Value = new decimal(new int[] { 31, 0, 0, 0 });
        // 
        // NUD_IV4
        // 
        NUD_IV4.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        NUD_IV4.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_IV4.Location = new System.Drawing.Point(121, 65);
        NUD_IV4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_IV4.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_IV4.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
        NUD_IV4.Name = "NUD_IV4";
        NUD_IV4.Size = new System.Drawing.Size(40, 25);
        NUD_IV4.TabIndex = 493;
        NUD_IV4.Value = new decimal(new int[] { 31, 0, 0, 0 });
        // 
        // NUD_IV5
        // 
        NUD_IV5.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        NUD_IV5.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_IV5.Location = new System.Drawing.Point(121, 104);
        NUD_IV5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_IV5.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_IV5.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
        NUD_IV5.Name = "NUD_IV5";
        NUD_IV5.Size = new System.Drawing.Size(40, 25);
        NUD_IV5.TabIndex = 494;
        NUD_IV5.Value = new decimal(new int[] { 31, 0, 0, 0 });
        // 
        // L_SPD
        // 
        L_SPD.Location = new System.Drawing.Point(80, 63);
        L_SPD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_SPD.Name = "L_SPD";
        L_SPD.Size = new System.Drawing.Size(41, 27);
        L_SPD.TabIndex = 500;
        L_SPD.Text = "SpD:";
        L_SPD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // L_SPE
        // 
        L_SPE.Location = new System.Drawing.Point(84, 103);
        L_SPE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_SPE.Name = "L_SPE";
        L_SPE.Size = new System.Drawing.Size(36, 27);
        L_SPE.TabIndex = 499;
        L_SPE.Text = "Spe:";
        L_SPE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // L_SPA
        // 
        L_SPA.Location = new System.Drawing.Point(85, 22);
        L_SPA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_SPA.Name = "L_SPA";
        L_SPA.Size = new System.Drawing.Size(36, 27);
        L_SPA.TabIndex = 498;
        L_SPA.Text = "SpA:";
        L_SPA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // NUD_IV2
        // 
        NUD_IV2.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        NUD_IV2.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_IV2.Location = new System.Drawing.Point(38, 104);
        NUD_IV2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_IV2.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_IV2.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
        NUD_IV2.Name = "NUD_IV2";
        NUD_IV2.Size = new System.Drawing.Size(40, 25);
        NUD_IV2.TabIndex = 491;
        NUD_IV2.Value = new decimal(new int[] { 31, 0, 0, 0 });
        // 
        // NUD_IV1
        // 
        NUD_IV1.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        NUD_IV1.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_IV1.Location = new System.Drawing.Point(38, 65);
        NUD_IV1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_IV1.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_IV1.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
        NUD_IV1.Name = "NUD_IV1";
        NUD_IV1.Size = new System.Drawing.Size(40, 25);
        NUD_IV1.TabIndex = 490;
        NUD_IV1.Value = new decimal(new int[] { 31, 0, 0, 0 });
        // 
        // NUD_IV0
        // 
        NUD_IV0.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        NUD_IV0.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_IV0.Location = new System.Drawing.Point(38, 24);
        NUD_IV0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_IV0.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_IV0.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
        NUD_IV0.Name = "NUD_IV0";
        NUD_IV0.Size = new System.Drawing.Size(40, 25);
        NUD_IV0.TabIndex = 489;
        NUD_IV0.Value = new decimal(new int[] { 31, 0, 0, 0 });
        // 
        // L_ATK
        // 
        L_ATK.Location = new System.Drawing.Point(5, 63);
        L_ATK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_ATK.Name = "L_ATK";
        L_ATK.Size = new System.Drawing.Size(33, 27);
        L_ATK.TabIndex = 496;
        L_ATK.Text = "Atk:";
        L_ATK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // L_DEF
        // 
        L_DEF.Location = new System.Drawing.Point(3, 103);
        L_DEF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_DEF.Name = "L_DEF";
        L_DEF.Size = new System.Drawing.Size(34, 27);
        L_DEF.TabIndex = 497;
        L_DEF.Text = "Def:";
        L_DEF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // CHK_ShinyLock
        // 
        CHK_ShinyLock.AutoSize = true;
        CHK_ShinyLock.Location = new System.Drawing.Point(76, 213);
        CHK_ShinyLock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_ShinyLock.Name = "CHK_ShinyLock";
        CHK_ShinyLock.Size = new System.Drawing.Size(93, 23);
        CHK_ShinyLock.TabIndex = 503;
        CHK_ShinyLock.Text = "Shiny Lock";
        CHK_ShinyLock.UseVisualStyleBackColor = true;
        // 
        // tabPage2
        // 
        tabPage2.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        tabPage2.Controls.Add(B_ModifyLevel);
        tabPage2.Controls.Add(GB_Tweak);
        tabPage2.Controls.Add(L_Mega);
        tabPage2.Controls.Add(CHK_ReplaceMega);
        tabPage2.Controls.Add(NUD_LevelBoost);
        tabPage2.Controls.Add(CHK_Level);
        tabPage2.Location = new System.Drawing.Point(4, 26);
        tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tabPage2.Size = new System.Drawing.Size(326, 392);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "Randomizer Options";
        // 
        // B_ModifyLevel
        // 
        B_ModifyLevel.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        B_ModifyLevel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_ModifyLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_ModifyLevel.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_ModifyLevel.ForeColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_ModifyLevel.Location = new System.Drawing.Point(235, 20);
        B_ModifyLevel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_ModifyLevel.Name = "B_ModifyLevel";
        B_ModifyLevel.Size = new System.Drawing.Size(82, 31);
        B_ModifyLevel.TabIndex = 514;
        B_ModifyLevel.Text = "× Current";
        B_ModifyLevel.UseVisualStyleBackColor = false;
        B_ModifyLevel.Click += ModifyLevels;
        // 
        // GB_Tweak
        // 
        GB_Tweak.Controls.Add(CHK_AllowMega);
        GB_Tweak.Controls.Add(NUD_ForceFullyEvolved);
        GB_Tweak.Controls.Add(CHK_ForceFullyEvolved);
        GB_Tweak.Controls.Add(CHK_RandomAbility);
        GB_Tweak.Controls.Add(CHK_RemoveShinyLock);
        GB_Tweak.Controls.Add(CHK_Item);
        GB_Tweak.Controls.Add(L_RandOpt);
        GB_Tweak.Controls.Add(CHK_BST);
        GB_Tweak.Controls.Add(CHK_E);
        GB_Tweak.Controls.Add(CHK_L);
        GB_Tweak.Controls.Add(CHK_G6);
        GB_Tweak.Controls.Add(CHK_G5);
        GB_Tweak.Controls.Add(CHK_G4);
        GB_Tweak.Controls.Add(CHK_G3);
        GB_Tweak.Controls.Add(CHK_G2);
        GB_Tweak.Controls.Add(CHK_G1);
        GB_Tweak.Font = new System.Drawing.Font("Segoe UI", 10F);
        GB_Tweak.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        GB_Tweak.Location = new System.Drawing.Point(6, 75);
        GB_Tweak.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        GB_Tweak.Name = "GB_Tweak";
        GB_Tweak.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        GB_Tweak.Size = new System.Drawing.Size(301, 222);
        GB_Tweak.TabIndex = 513;
        GB_Tweak.TabStop = false;
        GB_Tweak.Text = "Extra Randomization Tweaks";
        // 
        // CHK_AllowMega
        // 
        CHK_AllowMega.AutoSize = true;
        CHK_AllowMega.Location = new System.Drawing.Point(10, 162);
        CHK_AllowMega.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_AllowMega.Name = "CHK_AllowMega";
        CHK_AllowMega.Size = new System.Drawing.Size(197, 23);
        CHK_AllowMega.TabIndex = 296;
        CHK_AllowMega.Text = "Allow Random Mega Forms";
        CHK_AllowMega.UseVisualStyleBackColor = true;
        // 
        // NUD_ForceFullyEvolved
        // 
        NUD_ForceFullyEvolved.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        NUD_ForceFullyEvolved.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_ForceFullyEvolved.Location = new System.Drawing.Point(203, 185);
        NUD_ForceFullyEvolved.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_ForceFullyEvolved.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        NUD_ForceFullyEvolved.Name = "NUD_ForceFullyEvolved";
        NUD_ForceFullyEvolved.Size = new System.Drawing.Size(47, 25);
        NUD_ForceFullyEvolved.TabIndex = 518;
        NUD_ForceFullyEvolved.Value = new decimal(new int[] { 50, 0, 0, 0 });
        // 
        // CHK_ForceFullyEvolved
        // 
        CHK_ForceFullyEvolved.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        CHK_ForceFullyEvolved.AutoSize = true;
        CHK_ForceFullyEvolved.Location = new System.Drawing.Point(10, 187);
        CHK_ForceFullyEvolved.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_ForceFullyEvolved.Name = "CHK_ForceFullyEvolved";
        CHK_ForceFullyEvolved.Size = new System.Drawing.Size(195, 23);
        CHK_ForceFullyEvolved.TabIndex = 517;
        CHK_ForceFullyEvolved.Text = "Force Fully Evolved at Level";
        CHK_ForceFullyEvolved.UseVisualStyleBackColor = true;
        // 
        // CHK_RandomAbility
        // 
        CHK_RandomAbility.AutoSize = true;
        CHK_RandomAbility.Location = new System.Drawing.Point(10, 143);
        CHK_RandomAbility.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_RandomAbility.Name = "CHK_RandomAbility";
        CHK_RandomAbility.Size = new System.Drawing.Size(233, 23);
        CHK_RandomAbility.TabIndex = 298;
        CHK_RandomAbility.Text = "Random Abilities (1, 2, or Hidden)";
        CHK_RandomAbility.UseVisualStyleBackColor = true;
        // 
        // CHK_RemoveShinyLock
        // 
        CHK_RemoveShinyLock.AutoSize = true;
        CHK_RemoveShinyLock.Location = new System.Drawing.Point(10, 122);
        CHK_RemoveShinyLock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_RemoveShinyLock.Name = "CHK_RemoveShinyLock";
        CHK_RemoveShinyLock.Size = new System.Drawing.Size(152, 23);
        CHK_RemoveShinyLock.TabIndex = 297;
        CHK_RemoveShinyLock.Text = "Remove Shiny Locks";
        CHK_RemoveShinyLock.UseVisualStyleBackColor = true;
        // 
        // CHK_Item
        // 
        CHK_Item.AutoSize = true;
        CHK_Item.Checked = true;
        CHK_Item.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_Item.Location = new System.Drawing.Point(10, 103);
        CHK_Item.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_Item.Name = "CHK_Item";
        CHK_Item.Size = new System.Drawing.Size(149, 23);
        CHK_Item.TabIndex = 295;
        CHK_Item.Text = "Random Held Items";
        CHK_Item.UseVisualStyleBackColor = true;
        // 
        // L_RandOpt
        // 
        L_RandOpt.AutoSize = true;
        L_RandOpt.Location = new System.Drawing.Point(7, 20);
        L_RandOpt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_RandOpt.Name = "L_RandOpt";
        L_RandOpt.Size = new System.Drawing.Size(137, 19);
        L_RandOpt.TabIndex = 294;
        L_RandOpt.Text = "Randomizer Options:";
        // 
        // CHK_BST
        // 
        CHK_BST.AutoSize = true;
        CHK_BST.Location = new System.Drawing.Point(149, 82);
        CHK_BST.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_BST.Name = "CHK_BST";
        CHK_BST.Size = new System.Drawing.Size(140, 23);
        CHK_BST.TabIndex = 288;
        CHK_BST.Text = "Randomize by BST";
        CHK_BST.UseVisualStyleBackColor = true;
        // 
        // CHK_E
        // 
        CHK_E.AutoSize = true;
        CHK_E.Checked = true;
        CHK_E.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_E.Location = new System.Drawing.Point(149, 62);
        CHK_E.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_E.Name = "CHK_E";
        CHK_E.Size = new System.Drawing.Size(117, 23);
        CHK_E.TabIndex = 287;
        CHK_E.Text = "Event Legends";
        CHK_E.UseVisualStyleBackColor = true;
        // 
        // CHK_L
        // 
        CHK_L.AutoSize = true;
        CHK_L.Checked = true;
        CHK_L.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_L.Location = new System.Drawing.Point(149, 44);
        CHK_L.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_L.Name = "CHK_L";
        CHK_L.Size = new System.Drawing.Size(119, 23);
        CHK_L.TabIndex = 286;
        CHK_L.Text = "Game Legends";
        CHK_L.UseVisualStyleBackColor = true;
        // 
        // CHK_G6
        // 
        CHK_G6.AutoSize = true;
        CHK_G6.Checked = true;
        CHK_G6.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_G6.Location = new System.Drawing.Point(78, 82);
        CHK_G6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_G6.Name = "CHK_G6";
        CHK_G6.Size = new System.Drawing.Size(65, 23);
        CHK_G6.TabIndex = 285;
        CHK_G6.Text = "Gen 6";
        CHK_G6.UseVisualStyleBackColor = true;
        // 
        // CHK_G5
        // 
        CHK_G5.AutoSize = true;
        CHK_G5.Checked = true;
        CHK_G5.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_G5.Location = new System.Drawing.Point(78, 62);
        CHK_G5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_G5.Name = "CHK_G5";
        CHK_G5.Size = new System.Drawing.Size(65, 23);
        CHK_G5.TabIndex = 284;
        CHK_G5.Text = "Gen 5";
        CHK_G5.UseVisualStyleBackColor = true;
        // 
        // CHK_G4
        // 
        CHK_G4.AutoSize = true;
        CHK_G4.Checked = true;
        CHK_G4.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_G4.Location = new System.Drawing.Point(78, 44);
        CHK_G4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_G4.Name = "CHK_G4";
        CHK_G4.Size = new System.Drawing.Size(65, 23);
        CHK_G4.TabIndex = 283;
        CHK_G4.Text = "Gen 4";
        CHK_G4.UseVisualStyleBackColor = true;
        // 
        // CHK_G3
        // 
        CHK_G3.AutoSize = true;
        CHK_G3.Checked = true;
        CHK_G3.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_G3.Location = new System.Drawing.Point(10, 82);
        CHK_G3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_G3.Name = "CHK_G3";
        CHK_G3.Size = new System.Drawing.Size(65, 23);
        CHK_G3.TabIndex = 282;
        CHK_G3.Text = "Gen 3";
        CHK_G3.UseVisualStyleBackColor = true;
        // 
        // CHK_G2
        // 
        CHK_G2.AutoSize = true;
        CHK_G2.Checked = true;
        CHK_G2.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_G2.Location = new System.Drawing.Point(10, 62);
        CHK_G2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_G2.Name = "CHK_G2";
        CHK_G2.Size = new System.Drawing.Size(65, 23);
        CHK_G2.TabIndex = 281;
        CHK_G2.Text = "Gen 2";
        CHK_G2.UseVisualStyleBackColor = true;
        // 
        // CHK_G1
        // 
        CHK_G1.AutoSize = true;
        CHK_G1.Checked = true;
        CHK_G1.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_G1.Location = new System.Drawing.Point(10, 44);
        CHK_G1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_G1.Name = "CHK_G1";
        CHK_G1.Size = new System.Drawing.Size(65, 23);
        CHK_G1.TabIndex = 280;
        CHK_G1.Text = "Gen 1";
        CHK_G1.UseVisualStyleBackColor = true;
        // 
        // L_Mega
        // 
        L_Mega.Location = new System.Drawing.Point(13, 344);
        L_Mega.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Mega.Name = "L_Mega";
        L_Mega.Size = new System.Drawing.Size(161, 43);
        L_Mega.TabIndex = 512;
        L_Mega.Text = "XY - Lucario\r\nORAS - Latias/Latios";
        L_Mega.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // CHK_ReplaceMega
        // 
        CHK_ReplaceMega.AutoSize = true;
        CHK_ReplaceMega.Checked = true;
        CHK_ReplaceMega.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_ReplaceMega.Location = new System.Drawing.Point(13, 303);
        CHK_ReplaceMega.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_ReplaceMega.Name = "CHK_ReplaceMega";
        CHK_ReplaceMega.Size = new System.Drawing.Size(210, 42);
        CHK_ReplaceMega.TabIndex = 511;
        CHK_ReplaceMega.Text = "Replace Megas with \r\nAnother Mega (via Held Item)";
        CHK_ReplaceMega.UseVisualStyleBackColor = true;
        // 
        // NUD_LevelBoost
        // 
        NUD_LevelBoost.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        NUD_LevelBoost.DecimalPlaces = 2;
        NUD_LevelBoost.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_LevelBoost.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
        NUD_LevelBoost.Location = new System.Drawing.Point(174, 23);
        NUD_LevelBoost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_LevelBoost.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
        NUD_LevelBoost.Name = "NUD_LevelBoost";
        NUD_LevelBoost.Size = new System.Drawing.Size(50, 25);
        NUD_LevelBoost.TabIndex = 303;
        NUD_LevelBoost.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // CHK_Level
        // 
        CHK_Level.AutoSize = true;
        CHK_Level.Checked = true;
        CHK_Level.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_Level.Location = new System.Drawing.Point(10, 24);
        CHK_Level.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_Level.Name = "CHK_Level";
        CHK_Level.Size = new System.Drawing.Size(165, 23);
        CHK_Level.TabIndex = 302;
        CHK_Level.Text = "Multiply PKM Level by";
        CHK_Level.UseVisualStyleBackColor = true;
        // 
        // GiftEditor6
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        ClientSize = new System.Drawing.Size(486, 484);
        Controls.Add(tabControl1);
        Controls.Add(B_RandAll);
        Controls.Add(LB_Gifts);
        Controls.Add(B_Cancel);
        Controls.Add(B_Save);
        Font = new System.Drawing.Font("Segoe UI", 10F);
        ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MinimizeBox = false;
        MinimumSize = new System.Drawing.Size(502, 437);
        Name = "GiftEditor6";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Gift Editor";
        ((System.ComponentModel.ISupportInitialize)NUD_Level).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Form).EndInit();
        tabControl1.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        tabPage1.PerformLayout();
        GB_EIVs.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)NUD_IV3).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_IV4).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_IV5).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_IV2).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_IV1).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_IV0).EndInit();
        tabPage2.ResumeLayout(false);
        tabPage2.PerformLayout();
        GB_Tweak.ResumeLayout(false);
        GB_Tweak.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_ForceFullyEvolved).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_LevelBoost).EndInit();
        ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button B_Cancel;
    private System.Windows.Forms.Button B_Save;
    private System.Windows.Forms.ListBox LB_Gifts;
    private System.Windows.Forms.ComboBox CB_Species;
    private System.Windows.Forms.ComboBox CB_HeldItem;
    private System.Windows.Forms.Label L_Species;
    private System.Windows.Forms.Label L_HeldItem;
    private System.Windows.Forms.NumericUpDown NUD_Level;
    private System.Windows.Forms.Label L_Level;
    private System.Windows.Forms.NumericUpDown NUD_Form;
    private System.Windows.Forms.Label L_Form;
    private System.Windows.Forms.Label L_Nature;
    private System.Windows.Forms.Button B_RandAll;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.NumericUpDown NUD_LevelBoost;
    private System.Windows.Forms.CheckBox CHK_Level;
    private System.Windows.Forms.CheckBox CHK_ReplaceMega;
    private System.Windows.Forms.Label L_Mega;
    private System.Windows.Forms.CheckBox CHK_ShinyLock;
    private System.Windows.Forms.GroupBox GB_EIVs;
    private System.Windows.Forms.Label L_HP;
    private System.Windows.Forms.NumericUpDown NUD_IV3;
    private System.Windows.Forms.NumericUpDown NUD_IV4;
    private System.Windows.Forms.NumericUpDown NUD_IV5;
    private System.Windows.Forms.Label L_SPD;
    private System.Windows.Forms.Label L_SPE;
    private System.Windows.Forms.Label L_SPA;
    private System.Windows.Forms.NumericUpDown NUD_IV2;
    private System.Windows.Forms.NumericUpDown NUD_IV1;
    private System.Windows.Forms.NumericUpDown NUD_IV0;
    private System.Windows.Forms.Label L_ATK;
    private System.Windows.Forms.Label L_DEF;
    private System.Windows.Forms.ComboBox CB_Nature;
    private System.Windows.Forms.GroupBox GB_Tweak;
    private System.Windows.Forms.CheckBox CHK_RemoveShinyLock;
    private System.Windows.Forms.CheckBox CHK_AllowMega;
    private System.Windows.Forms.CheckBox CHK_Item;
    private System.Windows.Forms.Label L_RandOpt;
    private System.Windows.Forms.CheckBox CHK_BST;
    private System.Windows.Forms.CheckBox CHK_E;
    private System.Windows.Forms.CheckBox CHK_L;
    private System.Windows.Forms.CheckBox CHK_G6;
    private System.Windows.Forms.CheckBox CHK_G5;
    private System.Windows.Forms.CheckBox CHK_G4;
    private System.Windows.Forms.CheckBox CHK_G3;
    private System.Windows.Forms.CheckBox CHK_G2;
    private System.Windows.Forms.CheckBox CHK_G1;
    private System.Windows.Forms.Button B_ModifyLevel;
    private System.Windows.Forms.Label L_Gender;
    private System.Windows.Forms.ComboBox CB_Gender;
    private System.Windows.Forms.Label L_Ability;
    private System.Windows.Forms.ComboBox CB_Ability;
    private System.Windows.Forms.CheckBox CHK_RandomAbility;
    private System.Windows.Forms.NumericUpDown NUD_ForceFullyEvolved;
    private System.Windows.Forms.CheckBox CHK_ForceFullyEvolved;
}
