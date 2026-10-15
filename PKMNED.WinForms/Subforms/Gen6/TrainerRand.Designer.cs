namespace PKMNED.WinForms;

partial class TrainerRand
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainerRand));
        CHK_RandomPKM = new System.Windows.Forms.CheckBox();
        CHK_RandomItems = new System.Windows.Forms.CheckBox();
        CHK_RandomAbilities = new System.Windows.Forms.CheckBox();
        CHK_RandomGift = new System.Windows.Forms.CheckBox();
        CHK_RandomClass = new System.Windows.Forms.CheckBox();
        CHK_MaxDiffAI = new System.Windows.Forms.CheckBox();
        CHK_MaxDiffPKM = new System.Windows.Forms.CheckBox();
        B_OK = new System.Windows.Forms.Button();
        B_Cancel = new System.Windows.Forms.Button();
        NUD_GiftPercent = new System.Windows.Forms.NumericUpDown();
        label1 = new System.Windows.Forms.Label();
        NUD_Level = new System.Windows.Forms.NumericUpDown();
        CHK_Level = new System.Windows.Forms.CheckBox();
        GB_Tweak = new System.Windows.Forms.GroupBox();
        NUD_ForceFullyEvolved = new System.Windows.Forms.NumericUpDown();
        CHK_GymE4Only = new System.Windows.Forms.CheckBox();
        CHK_ForceFullyEvolved = new System.Windows.Forms.CheckBox();
        CHK_GymTrainers = new System.Windows.Forms.CheckBox();
        CHK_StoryMEvos = new System.Windows.Forms.CheckBox();
        CHK_RandomMegaForm = new System.Windows.Forms.CheckBox();
        CHK_TypeTheme = new System.Windows.Forms.CheckBox();
        CHK_BST = new System.Windows.Forms.CheckBox();
        CHK_E = new System.Windows.Forms.CheckBox();
        CHK_L = new System.Windows.Forms.CheckBox();
        CHK_G6 = new System.Windows.Forms.CheckBox();
        CHK_G5 = new System.Windows.Forms.CheckBox();
        CHK_G4 = new System.Windows.Forms.CheckBox();
        CHK_G3 = new System.Windows.Forms.CheckBox();
        CHK_G2 = new System.Windows.Forms.CheckBox();
        CHK_G1 = new System.Windows.Forms.CheckBox();
        CHK_6PKM = new System.Windows.Forms.CheckBox();
        CHK_IgnoreSpecialClass = new System.Windows.Forms.CheckBox();
        CHK_OnlySingles = new System.Windows.Forms.CheckBox();
        NUD_Damage = new System.Windows.Forms.NumericUpDown();
        CHK_Damage = new System.Windows.Forms.CheckBox();
        CHK_STAB = new System.Windows.Forms.CheckBox();
        NUD_STAB = new System.Windows.Forms.NumericUpDown();
        CB_Moves = new System.Windows.Forms.ComboBox();
        L_Moves = new System.Windows.Forms.Label();
        CHK_NoFixedDamage = new System.Windows.Forms.CheckBox();
        CHK_ForceHighPower = new System.Windows.Forms.CheckBox();
        NUD_ForceHighPower = new System.Windows.Forms.NumericUpDown();
        L_MinPKM = new System.Windows.Forms.Label();
        L_MaxPKM = new System.Windows.Forms.Label();
        NUD_RMin = new System.Windows.Forms.NumericUpDown();
        NUD_RMax = new System.Windows.Forms.NumericUpDown();
        ((System.ComponentModel.ISupportInitialize)NUD_GiftPercent).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Level).BeginInit();
        GB_Tweak.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_ForceFullyEvolved).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Damage).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_STAB).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_ForceHighPower).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_RMin).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_RMax).BeginInit();
        SuspendLayout();
        // 
        // CHK_RandomPKM
        // 
        CHK_RandomPKM.AutoSize = true;
        CHK_RandomPKM.Checked = true;
        CHK_RandomPKM.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_RandomPKM.Location = new System.Drawing.Point(14, 34);
        CHK_RandomPKM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_RandomPKM.Name = "CHK_RandomPKM";
        CHK_RandomPKM.Size = new System.Drawing.Size(140, 23);
        CHK_RandomPKM.TabIndex = 0;
        CHK_RandomPKM.Text = "Random Pokémon";
        CHK_RandomPKM.UseVisualStyleBackColor = true;
        CHK_RandomPKM.CheckedChanged += CHK_RandomPKM_CheckedChanged;
        // 
        // CHK_RandomItems
        // 
        CHK_RandomItems.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        CHK_RandomItems.AutoSize = true;
        CHK_RandomItems.Checked = true;
        CHK_RandomItems.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_RandomItems.Location = new System.Drawing.Point(81, 486);
        CHK_RandomItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_RandomItems.Name = "CHK_RandomItems";
        CHK_RandomItems.Size = new System.Drawing.Size(149, 23);
        CHK_RandomItems.TabIndex = 6;
        CHK_RandomItems.Text = "Random Held Items";
        CHK_RandomItems.UseVisualStyleBackColor = true;
        // 
        // CHK_RandomAbilities
        // 
        CHK_RandomAbilities.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        CHK_RandomAbilities.AutoSize = true;
        CHK_RandomAbilities.Checked = true;
        CHK_RandomAbilities.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_RandomAbilities.Location = new System.Drawing.Point(81, 507);
        CHK_RandomAbilities.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_RandomAbilities.Name = "CHK_RandomAbilities";
        CHK_RandomAbilities.Size = new System.Drawing.Size(233, 23);
        CHK_RandomAbilities.TabIndex = 7;
        CHK_RandomAbilities.Text = "Random Abilities (1, 2, or Hidden)";
        CHK_RandomAbilities.UseVisualStyleBackColor = true;
        // 
        // CHK_RandomGift
        // 
        CHK_RandomGift.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        CHK_RandomGift.AutoSize = true;
        CHK_RandomGift.Checked = true;
        CHK_RandomGift.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_RandomGift.Location = new System.Drawing.Point(81, 610);
        CHK_RandomGift.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_RandomGift.Name = "CHK_RandomGift";
        CHK_RandomGift.Size = new System.Drawing.Size(186, 23);
        CHK_RandomGift.TabIndex = 10;
        CHK_RandomGift.Text = "Random After-Battle Gifts";
        CHK_RandomGift.UseVisualStyleBackColor = true;
        CHK_RandomGift.CheckedChanged += CHK_RandomGift_CheckedChanged;
        // 
        // CHK_RandomClass
        // 
        CHK_RandomClass.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        CHK_RandomClass.AutoSize = true;
        CHK_RandomClass.Checked = true;
        CHK_RandomClass.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_RandomClass.Location = new System.Drawing.Point(81, 548);
        CHK_RandomClass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_RandomClass.Name = "CHK_RandomClass";
        CHK_RandomClass.Size = new System.Drawing.Size(172, 23);
        CHK_RandomClass.TabIndex = 9;
        CHK_RandomClass.Text = "Random Trainer Classes";
        CHK_RandomClass.UseVisualStyleBackColor = true;
        CHK_RandomClass.CheckedChanged += CHK_RandomClass_CheckedChanged;
        // 
        // CHK_MaxDiffAI
        // 
        CHK_MaxDiffAI.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        CHK_MaxDiffAI.AutoSize = true;
        CHK_MaxDiffAI.Checked = true;
        CHK_MaxDiffAI.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_MaxDiffAI.Location = new System.Drawing.Point(81, 629);
        CHK_MaxDiffAI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_MaxDiffAI.Name = "CHK_MaxDiffAI";
        CHK_MaxDiffAI.Size = new System.Drawing.Size(116, 23);
        CHK_MaxDiffAI.TabIndex = 13;
        CHK_MaxDiffAI.Text = "Max Trainer AI";
        CHK_MaxDiffAI.UseVisualStyleBackColor = true;
        // 
        // CHK_MaxDiffPKM
        // 
        CHK_MaxDiffPKM.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        CHK_MaxDiffPKM.AutoSize = true;
        CHK_MaxDiffPKM.Checked = true;
        CHK_MaxDiffPKM.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_MaxDiffPKM.Location = new System.Drawing.Point(81, 526);
        CHK_MaxDiffPKM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_MaxDiffPKM.Name = "CHK_MaxDiffPKM";
        CHK_MaxDiffPKM.Size = new System.Drawing.Size(77, 23);
        CHK_MaxDiffPKM.TabIndex = 8;
        CHK_MaxDiffPKM.Text = "Max IVs";
        CHK_MaxDiffPKM.UseVisualStyleBackColor = true;
        // 
        // B_OK
        // 
        B_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        B_OK.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_OK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(154, 205, 50);
        B_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_OK.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_OK.ForeColor = System.Drawing.Color.FromArgb(154, 205, 50);
        B_OK.Location = new System.Drawing.Point(379, 588);
        B_OK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_OK.Name = "B_OK";
        B_OK.Size = new System.Drawing.Size(71, 31);
        B_OK.TabIndex = 14;
        B_OK.Text = "OK";
        B_OK.UseVisualStyleBackColor = false;
        B_OK.Click += B_Save_Click;
        // 
        // B_Cancel
        // 
        B_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        B_Cancel.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
        B_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Cancel.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Cancel.ForeColor = System.Drawing.Color.Red;
        B_Cancel.Location = new System.Drawing.Point(379, 625);
        B_Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Cancel.Name = "B_Cancel";
        B_Cancel.Size = new System.Drawing.Size(71, 31);
        B_Cancel.TabIndex = 15;
        B_Cancel.Text = "Cancel";
        B_Cancel.UseVisualStyleBackColor = false;
        B_Cancel.Click += B_Close_Click;
        // 
        // NUD_GiftPercent
        // 
        NUD_GiftPercent.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        NUD_GiftPercent.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_GiftPercent.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_GiftPercent.Location = new System.Drawing.Point(266, 608);
        NUD_GiftPercent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_GiftPercent.Name = "NUD_GiftPercent";
        NUD_GiftPercent.Size = new System.Drawing.Size(50, 25);
        NUD_GiftPercent.TabIndex = 11;
        NUD_GiftPercent.Value = new decimal(new int[] { 15, 0, 0, 0 });
        NUD_GiftPercent.ValueChanged += ChangeGiftPercent;
        // 
        // label1
        // 
        label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        label1.AutoSize = true;
        label1.Location = new System.Drawing.Point(316, 611);
        label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(20, 19);
        label1.TabIndex = 12;
        label1.Text = "%";
        // 
        // NUD_Level
        // 
        NUD_Level.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_Level.DecimalPlaces = 2;
        NUD_Level.Enabled = false;
        NUD_Level.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_Level.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
        NUD_Level.Location = new System.Drawing.Point(175, 8);
        NUD_Level.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_Level.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
        NUD_Level.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
        NUD_Level.Name = "NUD_Level";
        NUD_Level.Size = new System.Drawing.Size(50, 25);
        NUD_Level.TabIndex = 3;
        NUD_Level.Value = new decimal(new int[] { 10, 0, 0, 65536 });
        NUD_Level.ValueChanged += ChangeLevelPercent;
        // 
        // CHK_Level
        // 
        CHK_Level.AutoSize = true;
        CHK_Level.Location = new System.Drawing.Point(14, 9);
        CHK_Level.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_Level.Name = "CHK_Level";
        CHK_Level.Size = new System.Drawing.Size(165, 23);
        CHK_Level.TabIndex = 2;
        CHK_Level.Text = "Multiply PKM Level by";
        CHK_Level.UseVisualStyleBackColor = true;
        CHK_Level.CheckedChanged += CHK_Level_CheckedChanged;
        // 
        // GB_Tweak
        // 
        GB_Tweak.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        GB_Tweak.Controls.Add(NUD_ForceFullyEvolved);
        GB_Tweak.Controls.Add(CHK_GymE4Only);
        GB_Tweak.Controls.Add(CHK_ForceFullyEvolved);
        GB_Tweak.Controls.Add(CHK_GymTrainers);
        GB_Tweak.Controls.Add(CHK_StoryMEvos);
        GB_Tweak.Controls.Add(CHK_RandomMegaForm);
        GB_Tweak.Controls.Add(CHK_TypeTheme);
        GB_Tweak.Controls.Add(CHK_BST);
        GB_Tweak.Controls.Add(CHK_E);
        GB_Tweak.Controls.Add(CHK_L);
        GB_Tweak.Controls.Add(CHK_G6);
        GB_Tweak.Controls.Add(CHK_G5);
        GB_Tweak.Controls.Add(CHK_G4);
        GB_Tweak.Controls.Add(CHK_G3);
        GB_Tweak.Controls.Add(CHK_G2);
        GB_Tweak.Controls.Add(CHK_G1);
        GB_Tweak.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        GB_Tweak.Location = new System.Drawing.Point(14, 65);
        GB_Tweak.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        GB_Tweak.Name = "GB_Tweak";
        GB_Tweak.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        GB_Tweak.Size = new System.Drawing.Size(441, 202);
        GB_Tweak.TabIndex = 323;
        GB_Tweak.TabStop = false;
        GB_Tweak.Text = "Options";
        // 
        // NUD_ForceFullyEvolved
        // 
        NUD_ForceFullyEvolved.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        NUD_ForceFullyEvolved.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_ForceFullyEvolved.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_ForceFullyEvolved.Location = new System.Drawing.Point(203, 127);
        NUD_ForceFullyEvolved.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_ForceFullyEvolved.Name = "NUD_ForceFullyEvolved";
        NUD_ForceFullyEvolved.Size = new System.Drawing.Size(50, 25);
        NUD_ForceFullyEvolved.TabIndex = 334;
        NUD_ForceFullyEvolved.Value = new decimal(new int[] { 50, 0, 0, 0 });
        // 
        // CHK_GymE4Only
        // 
        CHK_GymE4Only.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        CHK_GymE4Only.AutoSize = true;
        CHK_GymE4Only.Enabled = false;
        CHK_GymE4Only.Location = new System.Drawing.Point(164, 172);
        CHK_GymE4Only.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_GymE4Only.Name = "CHK_GymE4Only";
        CHK_GymE4Only.Size = new System.Drawing.Size(155, 23);
        CHK_GymE4Only.TabIndex = 295;
        CHK_GymE4Only.Text = "Theme Gym/E4 Only";
        CHK_GymE4Only.UseVisualStyleBackColor = true;
        // 
        // CHK_ForceFullyEvolved
        // 
        CHK_ForceFullyEvolved.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        CHK_ForceFullyEvolved.AutoSize = true;
        CHK_ForceFullyEvolved.Location = new System.Drawing.Point(10, 129);
        CHK_ForceFullyEvolved.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_ForceFullyEvolved.Name = "CHK_ForceFullyEvolved";
        CHK_ForceFullyEvolved.Size = new System.Drawing.Size(195, 23);
        CHK_ForceFullyEvolved.TabIndex = 333;
        CHK_ForceFullyEvolved.Text = "Force Fully Evolved at Level";
        CHK_ForceFullyEvolved.UseVisualStyleBackColor = true;
        // 
        // CHK_GymTrainers
        // 
        CHK_GymTrainers.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        CHK_GymTrainers.AutoSize = true;
        CHK_GymTrainers.Enabled = false;
        CHK_GymTrainers.Location = new System.Drawing.Point(10, 172);
        CHK_GymTrainers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_GymTrainers.Name = "CHK_GymTrainers";
        CHK_GymTrainers.Size = new System.Drawing.Size(153, 23);
        CHK_GymTrainers.TabIndex = 292;
        CHK_GymTrainers.Text = "Theme Gym Trainers";
        CHK_GymTrainers.UseVisualStyleBackColor = true;
        // 
        // CHK_StoryMEvos
        // 
        CHK_StoryMEvos.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        CHK_StoryMEvos.AutoSize = true;
        CHK_StoryMEvos.Checked = true;
        CHK_StoryMEvos.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_StoryMEvos.Location = new System.Drawing.Point(10, 82);
        CHK_StoryMEvos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_StoryMEvos.Name = "CHK_StoryMEvos";
        CHK_StoryMEvos.Size = new System.Drawing.Size(211, 23);
        CHK_StoryMEvos.TabIndex = 291;
        CHK_StoryMEvos.Text = "Ensure Story Mega Evolutions";
        CHK_StoryMEvos.UseVisualStyleBackColor = true;
        // 
        // CHK_RandomMegaForm
        // 
        CHK_RandomMegaForm.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        CHK_RandomMegaForm.AutoSize = true;
        CHK_RandomMegaForm.Location = new System.Drawing.Point(10, 106);
        CHK_RandomMegaForm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_RandomMegaForm.Name = "CHK_RandomMegaForm";
        CHK_RandomMegaForm.Size = new System.Drawing.Size(160, 23);
        CHK_RandomMegaForm.TabIndex = 294;
        CHK_RandomMegaForm.Text = "Random Mega Forms";
        CHK_RandomMegaForm.UseVisualStyleBackColor = true;
        // 
        // CHK_TypeTheme
        // 
        CHK_TypeTheme.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        CHK_TypeTheme.AutoSize = true;
        CHK_TypeTheme.Location = new System.Drawing.Point(10, 152);
        CHK_TypeTheme.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_TypeTheme.Name = "CHK_TypeTheme";
        CHK_TypeTheme.Size = new System.Drawing.Size(152, 23);
        CHK_TypeTheme.TabIndex = 289;
        CHK_TypeTheme.Text = "Type Theme Trainers";
        CHK_TypeTheme.UseVisualStyleBackColor = true;
        CHK_TypeTheme.CheckedChanged += CHK_TypeTheme_CheckedChanged;
        // 
        // CHK_BST
        // 
        CHK_BST.AutoSize = true;
        CHK_BST.Location = new System.Drawing.Point(164, 60);
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
        CHK_E.Location = new System.Drawing.Point(164, 41);
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
        CHK_L.Location = new System.Drawing.Point(164, 20);
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
        CHK_G6.Location = new System.Drawing.Point(88, 60);
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
        CHK_G5.Location = new System.Drawing.Point(88, 41);
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
        CHK_G4.Location = new System.Drawing.Point(88, 20);
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
        CHK_G3.Location = new System.Drawing.Point(10, 60);
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
        CHK_G2.Location = new System.Drawing.Point(10, 41);
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
        CHK_G1.Location = new System.Drawing.Point(10, 20);
        CHK_G1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_G1.Name = "CHK_G1";
        CHK_G1.Size = new System.Drawing.Size(65, 23);
        CHK_G1.TabIndex = 280;
        CHK_G1.Text = "Gen 1";
        CHK_G1.UseVisualStyleBackColor = true;
        // 
        // CHK_6PKM
        // 
        CHK_6PKM.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        CHK_6PKM.AutoSize = true;
        CHK_6PKM.Location = new System.Drawing.Point(24, 271);
        CHK_6PKM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_6PKM.Name = "CHK_6PKM";
        CHK_6PKM.Size = new System.Drawing.Size(235, 23);
        CHK_6PKM.TabIndex = 293;
        CHK_6PKM.Text = "6 Pokémon for Important Trainers";
        CHK_6PKM.UseVisualStyleBackColor = true;
        CHK_6PKM.CheckedChanged += CHK_6PKM_CheckedChanged;
        // 
        // CHK_IgnoreSpecialClass
        // 
        CHK_IgnoreSpecialClass.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        CHK_IgnoreSpecialClass.AutoSize = true;
        CHK_IgnoreSpecialClass.Checked = true;
        CHK_IgnoreSpecialClass.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_IgnoreSpecialClass.Location = new System.Drawing.Point(104, 569);
        CHK_IgnoreSpecialClass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_IgnoreSpecialClass.Name = "CHK_IgnoreSpecialClass";
        CHK_IgnoreSpecialClass.Size = new System.Drawing.Size(161, 23);
        CHK_IgnoreSpecialClass.TabIndex = 324;
        CHK_IgnoreSpecialClass.Text = "Ignore Special Classes";
        CHK_IgnoreSpecialClass.UseVisualStyleBackColor = true;
        // 
        // CHK_OnlySingles
        // 
        CHK_OnlySingles.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        CHK_OnlySingles.AutoSize = true;
        CHK_OnlySingles.Checked = true;
        CHK_OnlySingles.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_OnlySingles.Location = new System.Drawing.Point(104, 587);
        CHK_OnlySingles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_OnlySingles.Name = "CHK_OnlySingles";
        CHK_OnlySingles.Size = new System.Drawing.Size(142, 23);
        CHK_OnlySingles.TabIndex = 325;
        CHK_OnlySingles.Text = "Only Single Battles";
        CHK_OnlySingles.UseVisualStyleBackColor = true;
        // 
        // NUD_Damage
        // 
        NUD_Damage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        NUD_Damage.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_Damage.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_Damage.Location = new System.Drawing.Point(324, 434);
        NUD_Damage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_Damage.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
        NUD_Damage.Name = "NUD_Damage";
        NUD_Damage.Size = new System.Drawing.Size(41, 25);
        NUD_Damage.TabIndex = 326;
        NUD_Damage.Value = new decimal(new int[] { 2, 0, 0, 0 });
        // 
        // CHK_Damage
        // 
        CHK_Damage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        CHK_Damage.AutoSize = true;
        CHK_Damage.Checked = true;
        CHK_Damage.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_Damage.Location = new System.Drawing.Point(81, 435);
        CHK_Damage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_Damage.Name = "CHK_Damage";
        CHK_Damage.Size = new System.Drawing.Size(241, 23);
        CHK_Damage.TabIndex = 327;
        CHK_Damage.Text = "Ensure at least # Damaging Moves";
        CHK_Damage.UseVisualStyleBackColor = true;
        // 
        // CHK_STAB
        // 
        CHK_STAB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        CHK_STAB.AutoSize = true;
        CHK_STAB.Checked = true;
        CHK_STAB.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_STAB.Location = new System.Drawing.Point(81, 463);
        CHK_STAB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_STAB.Name = "CHK_STAB";
        CHK_STAB.Size = new System.Drawing.Size(208, 23);
        CHK_STAB.TabIndex = 328;
        CHK_STAB.Text = "Ensure at least # STAB Moves";
        CHK_STAB.UseVisualStyleBackColor = true;
        // 
        // NUD_STAB
        // 
        NUD_STAB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        NUD_STAB.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_STAB.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_STAB.Location = new System.Drawing.Point(287, 461);
        NUD_STAB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_STAB.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
        NUD_STAB.Name = "NUD_STAB";
        NUD_STAB.Size = new System.Drawing.Size(41, 25);
        NUD_STAB.TabIndex = 329;
        NUD_STAB.Value = new decimal(new int[] { 2, 0, 0, 0 });
        // 
        // CB_Moves
        // 
        CB_Moves.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        CB_Moves.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        CB_Moves.FormattingEnabled = true;
        CB_Moves.Items.AddRange(new object[] { "Don't Modify", "Randomize All", "Use Levelup Only", "Metronome Mode" });
        CB_Moves.Location = new System.Drawing.Point(135, 351);
        CB_Moves.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CB_Moves.Name = "CB_Moves";
        CB_Moves.Size = new System.Drawing.Size(157, 25);
        CB_Moves.TabIndex = 330;
        CB_Moves.SelectedIndexChanged += ChangeMoveRandomization;
        // 
        // L_Moves
        // 
        L_Moves.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        L_Moves.AutoSize = true;
        L_Moves.Location = new System.Drawing.Point(79, 356);
        L_Moves.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Moves.Name = "L_Moves";
        L_Moves.Size = new System.Drawing.Size(53, 19);
        L_Moves.TabIndex = 331;
        L_Moves.Text = "Moves:";
        // 
        // CHK_NoFixedDamage
        // 
        CHK_NoFixedDamage.AutoSize = true;
        CHK_NoFixedDamage.Checked = true;
        CHK_NoFixedDamage.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_NoFixedDamage.Location = new System.Drawing.Point(81, 408);
        CHK_NoFixedDamage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_NoFixedDamage.Name = "CHK_NoFixedDamage";
        CHK_NoFixedDamage.Size = new System.Drawing.Size(350, 23);
        CHK_NoFixedDamage.TabIndex = 332;
        CHK_NoFixedDamage.Text = "No Fixed Damage Moves (Dragon Rage/Sonic Boom)";
        CHK_NoFixedDamage.UseVisualStyleBackColor = true;
        // 
        // CHK_ForceHighPower
        // 
        CHK_ForceHighPower.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        CHK_ForceHighPower.AutoSize = true;
        CHK_ForceHighPower.Location = new System.Drawing.Point(81, 383);
        CHK_ForceHighPower.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_ForceHighPower.Name = "CHK_ForceHighPower";
        CHK_ForceHighPower.Size = new System.Drawing.Size(252, 23);
        CHK_ForceHighPower.TabIndex = 344;
        CHK_ForceHighPower.Text = "Force High-Powered Attacks at Level";
        CHK_ForceHighPower.UseVisualStyleBackColor = true;
        // 
        // NUD_ForceHighPower
        // 
        NUD_ForceHighPower.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        NUD_ForceHighPower.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_ForceHighPower.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_ForceHighPower.Location = new System.Drawing.Point(335, 382);
        NUD_ForceHighPower.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_ForceHighPower.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        NUD_ForceHighPower.Name = "NUD_ForceHighPower";
        NUD_ForceHighPower.Size = new System.Drawing.Size(41, 25);
        NUD_ForceHighPower.TabIndex = 343;
        NUD_ForceHighPower.Value = new decimal(new int[] { 50, 0, 0, 0 });
        // 
        // L_MinPKM
        // 
        L_MinPKM.Location = new System.Drawing.Point(6, 292);
        L_MinPKM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_MinPKM.Name = "L_MinPKM";
        L_MinPKM.Size = new System.Drawing.Size(70, 26);
        L_MinPKM.TabIndex = 348;
        L_MinPKM.Text = "Min PKM:";
        L_MinPKM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // L_MaxPKM
        // 
        L_MaxPKM.Location = new System.Drawing.Point(6, 320);
        L_MaxPKM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_MaxPKM.Name = "L_MaxPKM";
        L_MaxPKM.Size = new System.Drawing.Size(70, 26);
        L_MaxPKM.TabIndex = 347;
        L_MaxPKM.Text = "Max PKM:";
        L_MaxPKM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // NUD_RMin
        // 
        NUD_RMin.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_RMin.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_RMin.Location = new System.Drawing.Point(78, 292);
        NUD_RMin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_RMin.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
        NUD_RMin.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        NUD_RMin.Name = "NUD_RMin";
        NUD_RMin.Size = new System.Drawing.Size(47, 25);
        NUD_RMin.TabIndex = 346;
        NUD_RMin.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // NUD_RMax
        // 
        NUD_RMax.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_RMax.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_RMax.Location = new System.Drawing.Point(78, 322);
        NUD_RMax.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_RMax.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
        NUD_RMax.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        NUD_RMax.Name = "NUD_RMax";
        NUD_RMax.Size = new System.Drawing.Size(47, 25);
        NUD_RMax.TabIndex = 345;
        NUD_RMax.Value = new decimal(new int[] { 6, 0, 0, 0 });
        // 
        // TrainerRand
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        ClientSize = new System.Drawing.Size(468, 671);
        Controls.Add(L_MinPKM);
        Controls.Add(L_MaxPKM);
        Controls.Add(NUD_RMin);
        Controls.Add(NUD_RMax);
        Controls.Add(CHK_ForceHighPower);
        Controls.Add(NUD_ForceHighPower);
        Controls.Add(CHK_NoFixedDamage);
        Controls.Add(L_Moves);
        Controls.Add(CHK_6PKM);
        Controls.Add(CB_Moves);
        Controls.Add(CHK_OnlySingles);
        Controls.Add(GB_Tweak);
        Controls.Add(NUD_GiftPercent);
        Controls.Add(CHK_MaxDiffAI);
        Controls.Add(CHK_MaxDiffPKM);
        Controls.Add(CHK_RandomAbilities);
        Controls.Add(CHK_RandomItems);
        Controls.Add(NUD_Level);
        Controls.Add(CHK_Level);
        Controls.Add(label1);
        Controls.Add(B_Cancel);
        Controls.Add(B_OK);
        Controls.Add(CHK_RandomGift);
        Controls.Add(CHK_RandomPKM);
        Controls.Add(CHK_IgnoreSpecialClass);
        Controls.Add(CHK_RandomClass);
        Controls.Add(NUD_STAB);
        Controls.Add(CHK_STAB);
        Controls.Add(CHK_Damage);
        Controls.Add(NUD_Damage);
        Font = new System.Drawing.Font("Segoe UI", 10F);
        ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "TrainerRand";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Trainer Battle Randomizer";
        ((System.ComponentModel.ISupportInitialize)NUD_GiftPercent).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Level).EndInit();
        GB_Tweak.ResumeLayout(false);
        GB_Tweak.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_ForceFullyEvolved).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Damage).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_STAB).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_ForceHighPower).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_RMin).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_RMax).EndInit();
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private System.Windows.Forms.CheckBox CHK_RandomPKM;
    private System.Windows.Forms.CheckBox CHK_RandomItems;
    private System.Windows.Forms.CheckBox CHK_RandomAbilities;
    private System.Windows.Forms.CheckBox CHK_RandomGift;
    private System.Windows.Forms.CheckBox CHK_RandomClass;
    private System.Windows.Forms.CheckBox CHK_MaxDiffAI;
    private System.Windows.Forms.CheckBox CHK_MaxDiffPKM;
    private System.Windows.Forms.Button B_OK;
    private System.Windows.Forms.Button B_Cancel;
    private System.Windows.Forms.NumericUpDown NUD_GiftPercent;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown NUD_Level;
    private System.Windows.Forms.CheckBox CHK_Level;
    private System.Windows.Forms.GroupBox GB_Tweak;
    private System.Windows.Forms.CheckBox CHK_BST;
    private System.Windows.Forms.CheckBox CHK_E;
    private System.Windows.Forms.CheckBox CHK_L;
    private System.Windows.Forms.CheckBox CHK_G6;
    private System.Windows.Forms.CheckBox CHK_G5;
    private System.Windows.Forms.CheckBox CHK_G4;
    private System.Windows.Forms.CheckBox CHK_G3;
    private System.Windows.Forms.CheckBox CHK_G2;
    private System.Windows.Forms.CheckBox CHK_G1;
    private System.Windows.Forms.CheckBox CHK_TypeTheme;
    private System.Windows.Forms.CheckBox CHK_StoryMEvos;
    private System.Windows.Forms.CheckBox CHK_GymTrainers;
    private System.Windows.Forms.CheckBox CHK_IgnoreSpecialClass;
    private System.Windows.Forms.CheckBox CHK_OnlySingles;
    private System.Windows.Forms.NumericUpDown NUD_Damage;
    private System.Windows.Forms.CheckBox CHK_Damage;
    private System.Windows.Forms.CheckBox CHK_STAB;
    private System.Windows.Forms.NumericUpDown NUD_STAB;
    private System.Windows.Forms.ComboBox CB_Moves;
    private System.Windows.Forms.Label L_Moves;
    private System.Windows.Forms.CheckBox CHK_6PKM;
    private System.Windows.Forms.CheckBox CHK_RandomMegaForm;
    private System.Windows.Forms.CheckBox CHK_GymE4Only;
    private System.Windows.Forms.CheckBox CHK_NoFixedDamage;
    private System.Windows.Forms.NumericUpDown NUD_ForceFullyEvolved;
    private System.Windows.Forms.CheckBox CHK_ForceFullyEvolved;
    private System.Windows.Forms.CheckBox CHK_ForceHighPower;
    private System.Windows.Forms.NumericUpDown NUD_ForceHighPower;
    private System.Windows.Forms.Label L_MinPKM;
    private System.Windows.Forms.Label L_MaxPKM;
    private System.Windows.Forms.NumericUpDown NUD_RMin;
    private System.Windows.Forms.NumericUpDown NUD_RMax;
}
