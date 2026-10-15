using System.IO;

namespace PKMNED.WinForms;

partial class SMTE
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
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMTE));
        CB_TrainerID = new System.Windows.Forms.ComboBox();
        L_Money = new System.Windows.Forms.Label();
        CB_Money = new System.Windows.Forms.ComboBox();
        L_Trainer_Class = new System.Windows.Forms.Label();
        CB_Trainer_Class = new System.Windows.Forms.ComboBox();
        L_Item_4 = new System.Windows.Forms.Label();
        CB_Item_4 = new System.Windows.Forms.ComboBox();
        L_Item_3 = new System.Windows.Forms.Label();
        CB_Item_3 = new System.Windows.Forms.ComboBox();
        L_Item_2 = new System.Windows.Forms.Label();
        CB_Item_2 = new System.Windows.Forms.ComboBox();
        L_Item_1 = new System.Windows.Forms.Label();
        CB_Item_1 = new System.Windows.Forms.ComboBox();
        L_numPokemon = new System.Windows.Forms.Label();
        L_Team = new System.Windows.Forms.Label();
        PB_Team1 = new System.Windows.Forms.PictureBox();
        mnuVSD = new System.Windows.Forms.ContextMenuStrip(components);
        mnuView = new System.Windows.Forms.ToolStripMenuItem();
        mnuSet = new System.Windows.Forms.ToolStripMenuItem();
        mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
        PB_Team2 = new System.Windows.Forms.PictureBox();
        PB_Team3 = new System.Windows.Forms.PictureBox();
        PB_Team4 = new System.Windows.Forms.PictureBox();
        PB_Team5 = new System.Windows.Forms.PictureBox();
        PB_Team6 = new System.Windows.Forms.PictureBox();
        B_Randomize = new System.Windows.Forms.Button();
        B_Dump = new System.Windows.Forms.Button();
        TC_trpoke = new System.Windows.Forms.TabControl();
        Tab_Main = new System.Windows.Forms.TabPage();
        flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
        FLP_Species = new System.Windows.Forms.FlowLayoutPanel();
        L_Species = new System.Windows.Forms.Label();
        CB_Species = new System.Windows.Forms.ComboBox();
        FLP_Form = new System.Windows.Forms.FlowLayoutPanel();
        L_Forme = new System.Windows.Forms.Label();
        CB_Forme = new System.Windows.Forms.ComboBox();
        flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
        L_Level = new System.Windows.Forms.Label();
        NUD_Level = new System.Windows.Forms.NumericUpDown();
        flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
        L_Ability = new System.Windows.Forms.Label();
        CB_Ability = new System.Windows.Forms.ComboBox();
        flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
        L_Item = new System.Windows.Forms.Label();
        CB_Item = new System.Windows.Forms.ComboBox();
        flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
        L_Nature = new System.Windows.Forms.Label();
        CB_Nature = new System.Windows.Forms.ComboBox();
        flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
        L_Misc = new System.Windows.Forms.Label();
        CHK_Shiny = new System.Windows.Forms.CheckBox();
        flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
        L_Gender = new System.Windows.Forms.Label();
        CB_Gender = new System.Windows.Forms.ComboBox();
        Tab_Stats = new System.Windows.Forms.TabPage();
        FLP_Stats = new System.Windows.Forms.FlowLayoutPanel();
        FLP_StatHeader = new System.Windows.Forms.FlowLayoutPanel();
        FLP_StatsHeaderRight = new System.Windows.Forms.FlowLayoutPanel();
        Label_IVs = new System.Windows.Forms.Label();
        Label_EVs = new System.Windows.Forms.Label();
        Label_Stats = new System.Windows.Forms.Label();
        FLP_HP = new System.Windows.Forms.FlowLayoutPanel();
        Label_HP = new System.Windows.Forms.Label();
        TB_HPIV = new System.Windows.Forms.MaskedTextBox();
        TB_HPEV = new System.Windows.Forms.MaskedTextBox();
        Stat_HP = new System.Windows.Forms.MaskedTextBox();
        FLP_Atk = new System.Windows.Forms.FlowLayoutPanel();
        Label_ATK = new System.Windows.Forms.Label();
        TB_ATKIV = new System.Windows.Forms.MaskedTextBox();
        TB_ATKEV = new System.Windows.Forms.MaskedTextBox();
        Stat_ATK = new System.Windows.Forms.MaskedTextBox();
        FLP_Def = new System.Windows.Forms.FlowLayoutPanel();
        Label_DEF = new System.Windows.Forms.Label();
        TB_DEFIV = new System.Windows.Forms.MaskedTextBox();
        TB_DEFEV = new System.Windows.Forms.MaskedTextBox();
        Stat_DEF = new System.Windows.Forms.MaskedTextBox();
        FLP_SpA = new System.Windows.Forms.FlowLayoutPanel();
        Label_SPA = new System.Windows.Forms.Label();
        TB_SPAIV = new System.Windows.Forms.MaskedTextBox();
        TB_SPAEV = new System.Windows.Forms.MaskedTextBox();
        Stat_SPA = new System.Windows.Forms.MaskedTextBox();
        FLP_SpD = new System.Windows.Forms.FlowLayoutPanel();
        Label_SPD = new System.Windows.Forms.Label();
        TB_SPDIV = new System.Windows.Forms.MaskedTextBox();
        TB_SPDEV = new System.Windows.Forms.MaskedTextBox();
        Stat_SPD = new System.Windows.Forms.MaskedTextBox();
        FLP_Spe = new System.Windows.Forms.FlowLayoutPanel();
        Label_SPE = new System.Windows.Forms.Label();
        TB_SPEIV = new System.Windows.Forms.MaskedTextBox();
        TB_SPEEV = new System.Windows.Forms.MaskedTextBox();
        Stat_SPE = new System.Windows.Forms.MaskedTextBox();
        FLP_StatsTotal = new System.Windows.Forms.FlowLayoutPanel();
        Label_Total = new System.Windows.Forms.Label();
        TB_IVTotal = new System.Windows.Forms.TextBox();
        TB_EVTotal = new System.Windows.Forms.TextBox();
        FLP_HPType = new System.Windows.Forms.FlowLayoutPanel();
        Label_HiddenPowerPrefix = new System.Windows.Forms.Label();
        CB_HPType = new System.Windows.Forms.ComboBox();
        Tab_Moves = new System.Windows.Forms.TabPage();
        B_Clear = new System.Windows.Forms.Button();
        B_CurrentAttack = new System.Windows.Forms.Button();
        B_HighAttack = new System.Windows.Forms.Button();
        GB_Moves = new System.Windows.Forms.GroupBox();
        CB_Move1 = new System.Windows.Forms.ComboBox();
        CB_Move4 = new System.Windows.Forms.ComboBox();
        CB_Move2 = new System.Windows.Forms.ComboBox();
        CB_Move3 = new System.Windows.Forms.ComboBox();
        L_TrainerName = new System.Windows.Forms.Label();
        TB_TrainerName = new System.Windows.Forms.TextBox();
        NUD_NumPoke = new System.Windows.Forms.NumericUpDown();
        TC_trdata = new System.Windows.Forms.TabControl();
        Tab_Trainer = new System.Windows.Forms.TabPage();
        GB_AIBits = new System.Windows.Forms.GroupBox();
        CHK_AI7 = new System.Windows.Forms.CheckBox();
        CHK_AI6 = new System.Windows.Forms.CheckBox();
        CHK_AI5 = new System.Windows.Forms.CheckBox();
        CHK_AI4 = new System.Windows.Forms.CheckBox();
        CHK_AI3 = new System.Windows.Forms.CheckBox();
        CHK_AI2 = new System.Windows.Forms.CheckBox();
        CHK_AI1 = new System.Windows.Forms.CheckBox();
        CHK_AI0 = new System.Windows.Forms.CheckBox();
        L_Mode = new System.Windows.Forms.Label();
        CB_Mode = new System.Windows.Forms.ComboBox();
        CHK_Flag = new System.Windows.Forms.CheckBox();
        Tab_Rand = new System.Windows.Forms.TabPage();
        TC_rand = new System.Windows.Forms.TabControl();
        Tab_PKM1 = new System.Windows.Forms.TabPage();
        L_ShinyPCT = new System.Windows.Forms.Label();
        NUD_Shiny = new System.Windows.Forms.NumericUpDown();
        CHK_RandomShiny = new System.Windows.Forms.CheckBox();
        CHK_E = new System.Windows.Forms.CheckBox();
        CHK_L = new System.Windows.Forms.CheckBox();
        CHK_G7 = new System.Windows.Forms.CheckBox();
        CHK_G6 = new System.Windows.Forms.CheckBox();
        CHK_G5 = new System.Windows.Forms.CheckBox();
        CHK_G4 = new System.Windows.Forms.CheckBox();
        CHK_G3 = new System.Windows.Forms.CheckBox();
        NUD_LevelBoost = new System.Windows.Forms.NumericUpDown();
        CHK_G2 = new System.Windows.Forms.CheckBox();
        CHK_Level = new System.Windows.Forms.CheckBox();
        CHK_G1 = new System.Windows.Forms.CheckBox();
        CHK_BST = new System.Windows.Forms.CheckBox();
        CHK_RandomPKM = new System.Windows.Forms.CheckBox();
        Tab_PKM2 = new System.Windows.Forms.TabPage();
        CHK_ForceHighPower = new System.Windows.Forms.CheckBox();
        NUD_ForceHighPower = new System.Windows.Forms.NumericUpDown();
        CHK_NoFixedDamage = new System.Windows.Forms.CheckBox();
        CHK_MaxAI = new System.Windows.Forms.CheckBox();
        L_Moves = new System.Windows.Forms.Label();
        CB_Moves = new System.Windows.Forms.ComboBox();
        CHK_MaxDiffPKM = new System.Windows.Forms.CheckBox();
        NUD_Damage = new System.Windows.Forms.NumericUpDown();
        CHK_RandomAbilities = new System.Windows.Forms.CheckBox();
        NUD_STAB = new System.Windows.Forms.NumericUpDown();
        CHK_Damage = new System.Windows.Forms.CheckBox();
        CHK_RandomItems = new System.Windows.Forms.CheckBox();
        CHK_STAB = new System.Windows.Forms.CheckBox();
        Tab_Trainer1 = new System.Windows.Forms.TabPage();
        CHK_ReplaceMega = new System.Windows.Forms.CheckBox();
        CHK_6PKM = new System.Windows.Forms.CheckBox();
        NUD_ForceFullyEvolved = new System.Windows.Forms.NumericUpDown();
        L_MinPKM = new System.Windows.Forms.Label();
        L_MaxPKM = new System.Windows.Forms.Label();
        NUD_RMin = new System.Windows.Forms.NumericUpDown();
        NUD_RMax = new System.Windows.Forms.NumericUpDown();
        CHK_RandomMegaForm = new System.Windows.Forms.CheckBox();
        CHK_TypeTheme = new System.Windows.Forms.CheckBox();
        CHK_IgnoreSpecialClass = new System.Windows.Forms.CheckBox();
        CHK_RandomClass = new System.Windows.Forms.CheckBox();
        CHK_ForceFullyEvolved = new System.Windows.Forms.CheckBox();
        ((System.ComponentModel.ISupportInitialize)PB_Team1).BeginInit();
        mnuVSD.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)PB_Team2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PB_Team3).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PB_Team4).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PB_Team5).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PB_Team6).BeginInit();
        TC_trpoke.SuspendLayout();
        Tab_Main.SuspendLayout();
        flowLayoutPanel2.SuspendLayout();
        FLP_Species.SuspendLayout();
        FLP_Form.SuspendLayout();
        flowLayoutPanel3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_Level).BeginInit();
        flowLayoutPanel4.SuspendLayout();
        flowLayoutPanel1.SuspendLayout();
        flowLayoutPanel5.SuspendLayout();
        flowLayoutPanel6.SuspendLayout();
        flowLayoutPanel7.SuspendLayout();
        Tab_Stats.SuspendLayout();
        FLP_Stats.SuspendLayout();
        FLP_StatHeader.SuspendLayout();
        FLP_StatsHeaderRight.SuspendLayout();
        FLP_HP.SuspendLayout();
        FLP_Atk.SuspendLayout();
        FLP_Def.SuspendLayout();
        FLP_SpA.SuspendLayout();
        FLP_SpD.SuspendLayout();
        FLP_Spe.SuspendLayout();
        FLP_StatsTotal.SuspendLayout();
        FLP_HPType.SuspendLayout();
        Tab_Moves.SuspendLayout();
        GB_Moves.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_NumPoke).BeginInit();
        TC_trdata.SuspendLayout();
        Tab_Trainer.SuspendLayout();
        GB_AIBits.SuspendLayout();
        Tab_Rand.SuspendLayout();
        TC_rand.SuspendLayout();
        Tab_PKM1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_Shiny).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_LevelBoost).BeginInit();
        Tab_PKM2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_ForceHighPower).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Damage).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_STAB).BeginInit();
        Tab_Trainer1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_ForceFullyEvolved).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_RMin).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_RMax).BeginInit();
        SuspendLayout();
        // 
        // CB_TrainerID
        // 
        CB_TrainerID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
        CB_TrainerID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        CB_TrainerID.DropDownWidth = 200;
        CB_TrainerID.FormattingEnabled = true;
        CB_TrainerID.Location = new System.Drawing.Point(500, 8);
        CB_TrainerID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CB_TrainerID.MaxDropDownItems = 12;
        CB_TrainerID.Name = "CB_TrainerID";
        CB_TrainerID.Size = new System.Drawing.Size(163, 25);
        CB_TrainerID.TabIndex = 64;
        CB_TrainerID.SelectedIndexChanged += ChangeTrainerIndex;
        // 
        // L_Money
        // 
        L_Money.AutoSize = true;
        L_Money.Location = new System.Drawing.Point(34, 62);
        L_Money.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Money.Name = "L_Money";
        L_Money.Size = new System.Drawing.Size(55, 19);
        L_Money.TabIndex = 53;
        L_Money.Text = "Money:";
        // 
        // CB_Money
        // 
        CB_Money.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
        CB_Money.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        CB_Money.FormattingEnabled = true;
        CB_Money.Location = new System.Drawing.Point(92, 59);
        CB_Money.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CB_Money.Name = "CB_Money";
        CB_Money.Size = new System.Drawing.Size(81, 25);
        CB_Money.TabIndex = 52;
        // 
        // L_Trainer_Class
        // 
        L_Trainer_Class.AutoSize = true;
        L_Trainer_Class.Location = new System.Drawing.Point(3, 36);
        L_Trainer_Class.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Trainer_Class.Name = "L_Trainer_Class";
        L_Trainer_Class.Size = new System.Drawing.Size(88, 19);
        L_Trainer_Class.TabIndex = 49;
        L_Trainer_Class.Text = "Trainer Class:";
        // 
        // CB_Trainer_Class
        // 
        CB_Trainer_Class.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
        CB_Trainer_Class.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        CB_Trainer_Class.DropDownWidth = 165;
        CB_Trainer_Class.FormattingEnabled = true;
        CB_Trainer_Class.Location = new System.Drawing.Point(92, 33);
        CB_Trainer_Class.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CB_Trainer_Class.Name = "CB_Trainer_Class";
        CB_Trainer_Class.Size = new System.Drawing.Size(191, 25);
        CB_Trainer_Class.TabIndex = 48;
        // 
        // L_Item_4
        // 
        L_Item_4.AutoSize = true;
        L_Item_4.Location = new System.Drawing.Point(7, 203);
        L_Item_4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Item_4.Name = "L_Item_4";
        L_Item_4.Size = new System.Drawing.Size(52, 19);
        L_Item_4.TabIndex = 34;
        L_Item_4.Text = "Item 4:";
        // 
        // CB_Item_4
        // 
        CB_Item_4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
        CB_Item_4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        CB_Item_4.FormattingEnabled = true;
        CB_Item_4.Location = new System.Drawing.Point(59, 200);
        CB_Item_4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CB_Item_4.Name = "CB_Item_4";
        CB_Item_4.Size = new System.Drawing.Size(115, 25);
        CB_Item_4.TabIndex = 33;
        // 
        // L_Item_3
        // 
        L_Item_3.AutoSize = true;
        L_Item_3.Location = new System.Drawing.Point(7, 178);
        L_Item_3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Item_3.Name = "L_Item_3";
        L_Item_3.Size = new System.Drawing.Size(52, 19);
        L_Item_3.TabIndex = 32;
        L_Item_3.Text = "Item 3:";
        // 
        // CB_Item_3
        // 
        CB_Item_3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
        CB_Item_3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        CB_Item_3.FormattingEnabled = true;
        CB_Item_3.Location = new System.Drawing.Point(59, 174);
        CB_Item_3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CB_Item_3.Name = "CB_Item_3";
        CB_Item_3.Size = new System.Drawing.Size(115, 25);
        CB_Item_3.TabIndex = 31;
        // 
        // L_Item_2
        // 
        L_Item_2.AutoSize = true;
        L_Item_2.Location = new System.Drawing.Point(7, 152);
        L_Item_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Item_2.Name = "L_Item_2";
        L_Item_2.Size = new System.Drawing.Size(52, 19);
        L_Item_2.TabIndex = 30;
        L_Item_2.Text = "Item 2:";
        // 
        // CB_Item_2
        // 
        CB_Item_2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
        CB_Item_2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        CB_Item_2.FormattingEnabled = true;
        CB_Item_2.Location = new System.Drawing.Point(59, 149);
        CB_Item_2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CB_Item_2.Name = "CB_Item_2";
        CB_Item_2.Size = new System.Drawing.Size(115, 25);
        CB_Item_2.TabIndex = 29;
        // 
        // L_Item_1
        // 
        L_Item_1.AutoSize = true;
        L_Item_1.Location = new System.Drawing.Point(7, 127);
        L_Item_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Item_1.Name = "L_Item_1";
        L_Item_1.Size = new System.Drawing.Size(52, 19);
        L_Item_1.TabIndex = 28;
        L_Item_1.Text = "Item 1:";
        // 
        // CB_Item_1
        // 
        CB_Item_1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
        CB_Item_1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        CB_Item_1.FormattingEnabled = true;
        CB_Item_1.Location = new System.Drawing.Point(59, 123);
        CB_Item_1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CB_Item_1.Name = "CB_Item_1";
        CB_Item_1.Size = new System.Drawing.Size(115, 25);
        CB_Item_1.TabIndex = 27;
        // 
        // L_numPokemon
        // 
        L_numPokemon.AutoSize = true;
        L_numPokemon.Location = new System.Drawing.Point(42, 87);
        L_numPokemon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_numPokemon.Name = "L_numPokemon";
        L_numPokemon.Size = new System.Drawing.Size(49, 19);
        L_numPokemon.TabIndex = 22;
        L_numPokemon.Text = "#PKM:";
        L_numPokemon.Visible = false;
        // 
        // L_Team
        // 
        L_Team.Location = new System.Drawing.Point(-22, 308);
        L_Team.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Team.Name = "L_Team";
        L_Team.Size = new System.Drawing.Size(77, 17);
        L_Team.TabIndex = 445;
        L_Team.Text = "Team:";
        L_Team.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // PB_Team1
        // 
        PB_Team1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        PB_Team1.ContextMenuStrip = mnuVSD;
        PB_Team1.Location = new System.Drawing.Point(58, 282);
        PB_Team1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        PB_Team1.Name = "PB_Team1";
        PB_Team1.Size = new System.Drawing.Size(95, 71);
        PB_Team1.TabIndex = 444;
        PB_Team1.TabStop = false;
        // 
        // mnuVSD
        // 
        mnuVSD.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuView, mnuSet, mnuDelete });
        mnuVSD.Name = "mnuVSD";
        mnuVSD.Size = new System.Drawing.Size(108, 70);
        // 
        // mnuView
        // 
        mnuView.Name = "mnuView";
        mnuView.Size = new System.Drawing.Size(107, 22);
        mnuView.Text = "View";
        // 
        // mnuSet
        // 
        mnuSet.Name = "mnuSet";
        mnuSet.Size = new System.Drawing.Size(107, 22);
        mnuSet.Text = "Set";
        // 
        // mnuDelete
        // 
        mnuDelete.Name = "mnuDelete";
        mnuDelete.Size = new System.Drawing.Size(107, 22);
        mnuDelete.Text = "Delete";
        // 
        // PB_Team2
        // 
        PB_Team2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        PB_Team2.ContextMenuStrip = mnuVSD;
        PB_Team2.Location = new System.Drawing.Point(172, 282);
        PB_Team2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        PB_Team2.Name = "PB_Team2";
        PB_Team2.Size = new System.Drawing.Size(95, 71);
        PB_Team2.TabIndex = 443;
        PB_Team2.TabStop = false;
        // 
        // PB_Team3
        // 
        PB_Team3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        PB_Team3.ContextMenuStrip = mnuVSD;
        PB_Team3.Location = new System.Drawing.Point(285, 282);
        PB_Team3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        PB_Team3.Name = "PB_Team3";
        PB_Team3.Size = new System.Drawing.Size(95, 71);
        PB_Team3.TabIndex = 442;
        PB_Team3.TabStop = false;
        // 
        // PB_Team4
        // 
        PB_Team4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        PB_Team4.ContextMenuStrip = mnuVSD;
        PB_Team4.Location = new System.Drawing.Point(398, 282);
        PB_Team4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        PB_Team4.Name = "PB_Team4";
        PB_Team4.Size = new System.Drawing.Size(95, 71);
        PB_Team4.TabIndex = 441;
        PB_Team4.TabStop = false;
        // 
        // PB_Team5
        // 
        PB_Team5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        PB_Team5.ContextMenuStrip = mnuVSD;
        PB_Team5.Location = new System.Drawing.Point(511, 282);
        PB_Team5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        PB_Team5.Name = "PB_Team5";
        PB_Team5.Size = new System.Drawing.Size(95, 71);
        PB_Team5.TabIndex = 440;
        PB_Team5.TabStop = false;
        // 
        // PB_Team6
        // 
        PB_Team6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        PB_Team6.ContextMenuStrip = mnuVSD;
        PB_Team6.Location = new System.Drawing.Point(624, 282);
        PB_Team6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        PB_Team6.Name = "PB_Team6";
        PB_Team6.Size = new System.Drawing.Size(95, 71);
        PB_Team6.TabIndex = 439;
        PB_Team6.TabStop = false;
        // 
        // B_Randomize
        // 
        B_Randomize.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        B_Randomize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_Randomize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Randomize.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Randomize.ForeColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_Randomize.Location = new System.Drawing.Point(103, 6);
        B_Randomize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Randomize.Name = "B_Randomize";
        B_Randomize.Size = new System.Drawing.Size(108, 27);
        B_Randomize.TabIndex = 447;
        B_Randomize.Text = "Randomize All";
        B_Randomize.UseVisualStyleBackColor = false;
        B_Randomize.Click += B_Randomize_Click;
        // 
        // B_Dump
        // 
        B_Dump.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        B_Dump.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_Dump.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Dump.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Dump.ForeColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_Dump.Location = new System.Drawing.Point(218, 6);
        B_Dump.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Dump.Name = "B_Dump";
        B_Dump.Size = new System.Drawing.Size(108, 27);
        B_Dump.TabIndex = 446;
        B_Dump.Text = "Dump to .TXT";
        B_Dump.UseVisualStyleBackColor = false;
        B_Dump.Click += DumpTxt;
        // 
        // TC_trpoke
        // 
        TC_trpoke.Controls.Add(Tab_Main);
        TC_trpoke.Controls.Add(Tab_Stats);
        TC_trpoke.Controls.Add(Tab_Moves);
        TC_trpoke.Location = new System.Drawing.Point(14, 14);
        TC_trpoke.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        TC_trpoke.Name = "TC_trpoke";
        TC_trpoke.SelectedIndex = 0;
        TC_trpoke.Size = new System.Drawing.Size(271, 260);
        TC_trpoke.TabIndex = 448;
        // 
        // Tab_Main
        // 
        Tab_Main.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        Tab_Main.Controls.Add(flowLayoutPanel2);
        Tab_Main.Location = new System.Drawing.Point(4, 26);
        Tab_Main.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        Tab_Main.Name = "Tab_Main";
        Tab_Main.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        Tab_Main.Size = new System.Drawing.Size(263, 230);
        Tab_Main.TabIndex = 0;
        Tab_Main.Text = "Main";
        // 
        // flowLayoutPanel2
        // 
        flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        flowLayoutPanel2.Controls.Add(FLP_Species);
        flowLayoutPanel2.Controls.Add(FLP_Form);
        flowLayoutPanel2.Controls.Add(flowLayoutPanel3);
        flowLayoutPanel2.Controls.Add(flowLayoutPanel4);
        flowLayoutPanel2.Controls.Add(flowLayoutPanel1);
        flowLayoutPanel2.Controls.Add(flowLayoutPanel5);
        flowLayoutPanel2.Controls.Add(flowLayoutPanel6);
        flowLayoutPanel2.Controls.Add(flowLayoutPanel7);
        flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
        flowLayoutPanel2.Location = new System.Drawing.Point(4, 3);
        flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        flowLayoutPanel2.Name = "flowLayoutPanel2";
        flowLayoutPanel2.Size = new System.Drawing.Size(255, 224);
        flowLayoutPanel2.TabIndex = 2;
        // 
        // FLP_Species
        // 
        FLP_Species.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        FLP_Species.Controls.Add(L_Species);
        FLP_Species.Controls.Add(CB_Species);
        FLP_Species.Location = new System.Drawing.Point(0, 12);
        FLP_Species.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
        FLP_Species.Name = "FLP_Species";
        FLP_Species.Size = new System.Drawing.Size(251, 24);
        FLP_Species.TabIndex = 1;
        // 
        // L_Species
        // 
        L_Species.Location = new System.Drawing.Point(4, 0);
        L_Species.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Species.Name = "L_Species";
        L_Species.Size = new System.Drawing.Size(64, 24);
        L_Species.TabIndex = 0;
        L_Species.Text = "Species:";
        L_Species.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // CB_Species
        // 
        CB_Species.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
        CB_Species.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        CB_Species.FormattingEnabled = true;
        CB_Species.Location = new System.Drawing.Point(72, 0);
        CB_Species.Margin = new System.Windows.Forms.Padding(0);
        CB_Species.Name = "CB_Species";
        CB_Species.Size = new System.Drawing.Size(158, 25);
        CB_Species.TabIndex = 1;
        CB_Species.SelectedIndexChanged += RefreshSpeciesAbility;
        // 
        // FLP_Form
        // 
        FLP_Form.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        FLP_Form.Controls.Add(L_Forme);
        FLP_Form.Controls.Add(CB_Forme);
        FLP_Form.Location = new System.Drawing.Point(0, 36);
        FLP_Form.Margin = new System.Windows.Forms.Padding(0);
        FLP_Form.Name = "FLP_Form";
        FLP_Form.Size = new System.Drawing.Size(251, 24);
        FLP_Form.TabIndex = 2;
        // 
        // L_Forme
        // 
        L_Forme.Location = new System.Drawing.Point(4, 0);
        L_Forme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Forme.Name = "L_Forme";
        L_Forme.Size = new System.Drawing.Size(64, 24);
        L_Forme.TabIndex = 0;
        L_Forme.Text = "Form:";
        L_Forme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // CB_Forme
        // 
        CB_Forme.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
        CB_Forme.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        CB_Forme.FormattingEnabled = true;
        CB_Forme.Location = new System.Drawing.Point(72, 0);
        CB_Forme.Margin = new System.Windows.Forms.Padding(0);
        CB_Forme.Name = "CB_Forme";
        CB_Forme.Size = new System.Drawing.Size(158, 25);
        CB_Forme.TabIndex = 1;
        CB_Forme.SelectedIndexChanged += RefreshFormAbility;
        // 
        // flowLayoutPanel3
        // 
        flowLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        flowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        flowLayoutPanel3.Controls.Add(L_Level);
        flowLayoutPanel3.Controls.Add(NUD_Level);
        flowLayoutPanel3.Location = new System.Drawing.Point(0, 60);
        flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
        flowLayoutPanel3.Name = "flowLayoutPanel3";
        flowLayoutPanel3.Size = new System.Drawing.Size(251, 24);
        flowLayoutPanel3.TabIndex = 3;
        // 
        // L_Level
        // 
        L_Level.Location = new System.Drawing.Point(4, 0);
        L_Level.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Level.Name = "L_Level";
        L_Level.Size = new System.Drawing.Size(64, 24);
        L_Level.TabIndex = 0;
        L_Level.Text = "Level:";
        L_Level.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // NUD_Level
        // 
        NUD_Level.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        NUD_Level.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_Level.Location = new System.Drawing.Point(72, 0);
        NUD_Level.Margin = new System.Windows.Forms.Padding(0);
        NUD_Level.Name = "NUD_Level";
        NUD_Level.Size = new System.Drawing.Size(65, 25);
        NUD_Level.TabIndex = 1;
        NUD_Level.ValueChanged += UpdateStats;
        // 
        // flowLayoutPanel4
        // 
        flowLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        flowLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        flowLayoutPanel4.Controls.Add(L_Ability);
        flowLayoutPanel4.Controls.Add(CB_Ability);
        flowLayoutPanel4.Location = new System.Drawing.Point(0, 84);
        flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
        flowLayoutPanel4.Name = "flowLayoutPanel4";
        flowLayoutPanel4.Size = new System.Drawing.Size(251, 24);
        flowLayoutPanel4.TabIndex = 4;
        // 
        // L_Ability
        // 
        L_Ability.Location = new System.Drawing.Point(4, 0);
        L_Ability.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Ability.Name = "L_Ability";
        L_Ability.Size = new System.Drawing.Size(64, 24);
        L_Ability.TabIndex = 0;
        L_Ability.Text = "Ability:";
        L_Ability.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // CB_Ability
        // 
        CB_Ability.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
        CB_Ability.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        CB_Ability.FormattingEnabled = true;
        CB_Ability.Location = new System.Drawing.Point(72, 0);
        CB_Ability.Margin = new System.Windows.Forms.Padding(0);
        CB_Ability.Name = "CB_Ability";
        CB_Ability.Size = new System.Drawing.Size(158, 25);
        CB_Ability.TabIndex = 2;
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        flowLayoutPanel1.Controls.Add(L_Item);
        flowLayoutPanel1.Controls.Add(CB_Item);
        flowLayoutPanel1.Location = new System.Drawing.Point(0, 108);
        flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new System.Drawing.Size(251, 24);
        flowLayoutPanel1.TabIndex = 5;
        // 
        // L_Item
        // 
        L_Item.Location = new System.Drawing.Point(4, 0);
        L_Item.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Item.Name = "L_Item";
        L_Item.Size = new System.Drawing.Size(64, 24);
        L_Item.TabIndex = 0;
        L_Item.Text = "Item:";
        L_Item.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // CB_Item
        // 
        CB_Item.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
        CB_Item.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        CB_Item.FormattingEnabled = true;
        CB_Item.Location = new System.Drawing.Point(72, 0);
        CB_Item.Margin = new System.Windows.Forms.Padding(0);
        CB_Item.Name = "CB_Item";
        CB_Item.Size = new System.Drawing.Size(158, 25);
        CB_Item.TabIndex = 2;
        // 
        // flowLayoutPanel5
        // 
        flowLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        flowLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        flowLayoutPanel5.Controls.Add(L_Nature);
        flowLayoutPanel5.Controls.Add(CB_Nature);
        flowLayoutPanel5.Location = new System.Drawing.Point(0, 132);
        flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
        flowLayoutPanel5.Name = "flowLayoutPanel5";
        flowLayoutPanel5.Size = new System.Drawing.Size(251, 24);
        flowLayoutPanel5.TabIndex = 6;
        // 
        // L_Nature
        // 
        L_Nature.Location = new System.Drawing.Point(4, 0);
        L_Nature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Nature.Name = "L_Nature";
        L_Nature.Size = new System.Drawing.Size(64, 24);
        L_Nature.TabIndex = 0;
        L_Nature.Text = "Nature:";
        L_Nature.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // CB_Nature
        // 
        CB_Nature.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
        CB_Nature.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        CB_Nature.FormattingEnabled = true;
        CB_Nature.Location = new System.Drawing.Point(72, 0);
        CB_Nature.Margin = new System.Windows.Forms.Padding(0);
        CB_Nature.Name = "CB_Nature";
        CB_Nature.Size = new System.Drawing.Size(158, 25);
        CB_Nature.TabIndex = 2;
        CB_Nature.SelectedIndexChanged += UpdateStats;
        // 
        // flowLayoutPanel6
        // 
        flowLayoutPanel6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        flowLayoutPanel6.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        flowLayoutPanel6.Controls.Add(L_Misc);
        flowLayoutPanel6.Controls.Add(CHK_Shiny);
        flowLayoutPanel6.Location = new System.Drawing.Point(0, 156);
        flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
        flowLayoutPanel6.Name = "flowLayoutPanel6";
        flowLayoutPanel6.Size = new System.Drawing.Size(251, 24);
        flowLayoutPanel6.TabIndex = 7;
        // 
        // L_Misc
        // 
        L_Misc.Location = new System.Drawing.Point(4, 0);
        L_Misc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Misc.Name = "L_Misc";
        L_Misc.Size = new System.Drawing.Size(64, 24);
        L_Misc.TabIndex = 0;
        L_Misc.Text = "Misc:";
        L_Misc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // CHK_Shiny
        // 
        CHK_Shiny.AutoSize = true;
        CHK_Shiny.Location = new System.Drawing.Point(76, 3);
        CHK_Shiny.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_Shiny.Name = "CHK_Shiny";
        CHK_Shiny.Size = new System.Drawing.Size(61, 23);
        CHK_Shiny.TabIndex = 1;
        CHK_Shiny.Text = "Shiny";
        CHK_Shiny.UseVisualStyleBackColor = true;
        // 
        // flowLayoutPanel7
        // 
        flowLayoutPanel7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        flowLayoutPanel7.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        flowLayoutPanel7.Controls.Add(L_Gender);
        flowLayoutPanel7.Controls.Add(CB_Gender);
        flowLayoutPanel7.Location = new System.Drawing.Point(0, 180);
        flowLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
        flowLayoutPanel7.Name = "flowLayoutPanel7";
        flowLayoutPanel7.Size = new System.Drawing.Size(251, 24);
        flowLayoutPanel7.TabIndex = 8;
        // 
        // L_Gender
        // 
        L_Gender.Location = new System.Drawing.Point(4, 0);
        L_Gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Gender.Name = "L_Gender";
        L_Gender.Size = new System.Drawing.Size(64, 24);
        L_Gender.TabIndex = 0;
        L_Gender.Text = "Gender:";
        L_Gender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // CB_Gender
        // 
        CB_Gender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
        CB_Gender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        CB_Gender.FormattingEnabled = true;
        CB_Gender.Location = new System.Drawing.Point(72, 0);
        CB_Gender.Margin = new System.Windows.Forms.Padding(0);
        CB_Gender.Name = "CB_Gender";
        CB_Gender.Size = new System.Drawing.Size(158, 25);
        CB_Gender.TabIndex = 3;
        // 
        // Tab_Stats
        // 
        Tab_Stats.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        Tab_Stats.Controls.Add(FLP_Stats);
        Tab_Stats.Location = new System.Drawing.Point(4, 26);
        Tab_Stats.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        Tab_Stats.Name = "Tab_Stats";
        Tab_Stats.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        Tab_Stats.Size = new System.Drawing.Size(263, 230);
        Tab_Stats.TabIndex = 2;
        Tab_Stats.Text = "Stats";
        // 
        // FLP_Stats
        // 
        FLP_Stats.Controls.Add(FLP_StatHeader);
        FLP_Stats.Controls.Add(FLP_HP);
        FLP_Stats.Controls.Add(FLP_Atk);
        FLP_Stats.Controls.Add(FLP_Def);
        FLP_Stats.Controls.Add(FLP_SpA);
        FLP_Stats.Controls.Add(FLP_SpD);
        FLP_Stats.Controls.Add(FLP_Spe);
        FLP_Stats.Controls.Add(FLP_StatsTotal);
        FLP_Stats.Controls.Add(FLP_HPType);
        FLP_Stats.Location = new System.Drawing.Point(18, 3);
        FLP_Stats.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        FLP_Stats.Name = "FLP_Stats";
        FLP_Stats.Size = new System.Drawing.Size(208, 223);
        FLP_Stats.TabIndex = 450;
        // 
        // FLP_StatHeader
        // 
        FLP_StatHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        FLP_StatHeader.Controls.Add(FLP_StatsHeaderRight);
        FLP_StatHeader.Location = new System.Drawing.Point(0, 0);
        FLP_StatHeader.Margin = new System.Windows.Forms.Padding(0);
        FLP_StatHeader.Name = "FLP_StatHeader";
        FLP_StatHeader.Size = new System.Drawing.Size(201, 25);
        FLP_StatHeader.TabIndex = 122;
        // 
        // FLP_StatsHeaderRight
        // 
        FLP_StatsHeaderRight.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        FLP_StatsHeaderRight.Controls.Add(Label_IVs);
        FLP_StatsHeaderRight.Controls.Add(Label_EVs);
        FLP_StatsHeaderRight.Controls.Add(Label_Stats);
        FLP_StatsHeaderRight.Location = new System.Drawing.Point(72, 0);
        FLP_StatsHeaderRight.Margin = new System.Windows.Forms.Padding(72, 0, 0, 0);
        FLP_StatsHeaderRight.Name = "FLP_StatsHeaderRight";
        FLP_StatsHeaderRight.Size = new System.Drawing.Size(131, 24);
        FLP_StatsHeaderRight.TabIndex = 123;
        // 
        // Label_IVs
        // 
        Label_IVs.Location = new System.Drawing.Point(0, 0);
        Label_IVs.Margin = new System.Windows.Forms.Padding(0);
        Label_IVs.Name = "Label_IVs";
        Label_IVs.Size = new System.Drawing.Size(35, 24);
        Label_IVs.TabIndex = 29;
        Label_IVs.Text = "IVs";
        Label_IVs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Label_EVs
        // 
        Label_EVs.Location = new System.Drawing.Point(35, 0);
        Label_EVs.Margin = new System.Windows.Forms.Padding(0);
        Label_EVs.Name = "Label_EVs";
        Label_EVs.Size = new System.Drawing.Size(41, 24);
        Label_EVs.TabIndex = 27;
        Label_EVs.Text = "EVs";
        Label_EVs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Label_Stats
        // 
        Label_Stats.Location = new System.Drawing.Point(76, 0);
        Label_Stats.Margin = new System.Windows.Forms.Padding(0);
        Label_Stats.Name = "Label_Stats";
        Label_Stats.Size = new System.Drawing.Size(41, 24);
        Label_Stats.TabIndex = 28;
        Label_Stats.Text = "Stats";
        Label_Stats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // FLP_HP
        // 
        FLP_HP.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        FLP_HP.Controls.Add(Label_HP);
        FLP_HP.Controls.Add(TB_HPIV);
        FLP_HP.Controls.Add(TB_HPEV);
        FLP_HP.Controls.Add(Stat_HP);
        FLP_HP.Location = new System.Drawing.Point(0, 25);
        FLP_HP.Margin = new System.Windows.Forms.Padding(0);
        FLP_HP.Name = "FLP_HP";
        FLP_HP.Size = new System.Drawing.Size(201, 24);
        FLP_HP.TabIndex = 123;
        // 
        // Label_HP
        // 
        Label_HP.Location = new System.Drawing.Point(0, 0);
        Label_HP.Margin = new System.Windows.Forms.Padding(0);
        Label_HP.Name = "Label_HP";
        Label_HP.Size = new System.Drawing.Size(76, 24);
        Label_HP.TabIndex = 19;
        Label_HP.Text = "HP:";
        Label_HP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // TB_HPIV
        // 
        TB_HPIV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        TB_HPIV.Location = new System.Drawing.Point(76, 0);
        TB_HPIV.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
        TB_HPIV.Mask = "00";
        TB_HPIV.Name = "TB_HPIV";
        TB_HPIV.Size = new System.Drawing.Size(25, 25);
        TB_HPIV.TabIndex = 46;
        TB_HPIV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        TB_HPIV.TextChanged += UpdateStats;
        // 
        // TB_HPEV
        // 
        TB_HPEV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        TB_HPEV.Location = new System.Drawing.Point(109, 0);
        TB_HPEV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        TB_HPEV.Mask = "000";
        TB_HPEV.Name = "TB_HPEV";
        TB_HPEV.Size = new System.Drawing.Size(32, 25);
        TB_HPEV.TabIndex = 47;
        TB_HPEV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        TB_HPEV.TextChanged += UpdateStats;
        // 
        // Stat_HP
        // 
        Stat_HP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        Stat_HP.Enabled = false;
        Stat_HP.Location = new System.Drawing.Point(149, 0);
        Stat_HP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        Stat_HP.Mask = "00000";
        Stat_HP.Name = "Stat_HP";
        Stat_HP.PromptChar = ' ';
        Stat_HP.Size = new System.Drawing.Size(43, 25);
        Stat_HP.TabIndex = 48;
        Stat_HP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // FLP_Atk
        // 
        FLP_Atk.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        FLP_Atk.Controls.Add(Label_ATK);
        FLP_Atk.Controls.Add(TB_ATKIV);
        FLP_Atk.Controls.Add(TB_ATKEV);
        FLP_Atk.Controls.Add(Stat_ATK);
        FLP_Atk.Location = new System.Drawing.Point(0, 49);
        FLP_Atk.Margin = new System.Windows.Forms.Padding(0);
        FLP_Atk.Name = "FLP_Atk";
        FLP_Atk.Size = new System.Drawing.Size(201, 24);
        FLP_Atk.TabIndex = 124;
        // 
        // Label_ATK
        // 
        Label_ATK.Location = new System.Drawing.Point(0, 0);
        Label_ATK.Margin = new System.Windows.Forms.Padding(0);
        Label_ATK.Name = "Label_ATK";
        Label_ATK.Size = new System.Drawing.Size(76, 24);
        Label_ATK.TabIndex = 20;
        Label_ATK.Text = "Atk:";
        Label_ATK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // TB_ATKIV
        // 
        TB_ATKIV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        TB_ATKIV.Location = new System.Drawing.Point(76, 0);
        TB_ATKIV.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
        TB_ATKIV.Mask = "00";
        TB_ATKIV.Name = "TB_ATKIV";
        TB_ATKIV.Size = new System.Drawing.Size(25, 25);
        TB_ATKIV.TabIndex = 47;
        TB_ATKIV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        TB_ATKIV.TextChanged += UpdateStats;
        // 
        // TB_ATKEV
        // 
        TB_ATKEV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        TB_ATKEV.Location = new System.Drawing.Point(109, 0);
        TB_ATKEV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        TB_ATKEV.Mask = "000";
        TB_ATKEV.Name = "TB_ATKEV";
        TB_ATKEV.Size = new System.Drawing.Size(32, 25);
        TB_ATKEV.TabIndex = 48;
        TB_ATKEV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        TB_ATKEV.TextChanged += UpdateStats;
        // 
        // Stat_ATK
        // 
        Stat_ATK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        Stat_ATK.Enabled = false;
        Stat_ATK.Location = new System.Drawing.Point(149, 0);
        Stat_ATK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        Stat_ATK.Mask = "00000";
        Stat_ATK.Name = "Stat_ATK";
        Stat_ATK.PromptChar = ' ';
        Stat_ATK.Size = new System.Drawing.Size(43, 25);
        Stat_ATK.TabIndex = 49;
        Stat_ATK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // FLP_Def
        // 
        FLP_Def.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        FLP_Def.Controls.Add(Label_DEF);
        FLP_Def.Controls.Add(TB_DEFIV);
        FLP_Def.Controls.Add(TB_DEFEV);
        FLP_Def.Controls.Add(Stat_DEF);
        FLP_Def.Location = new System.Drawing.Point(0, 73);
        FLP_Def.Margin = new System.Windows.Forms.Padding(0);
        FLP_Def.Name = "FLP_Def";
        FLP_Def.Size = new System.Drawing.Size(201, 24);
        FLP_Def.TabIndex = 125;
        // 
        // Label_DEF
        // 
        Label_DEF.Location = new System.Drawing.Point(0, 0);
        Label_DEF.Margin = new System.Windows.Forms.Padding(0);
        Label_DEF.Name = "Label_DEF";
        Label_DEF.Size = new System.Drawing.Size(76, 24);
        Label_DEF.TabIndex = 21;
        Label_DEF.Text = "Def:";
        Label_DEF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // TB_DEFIV
        // 
        TB_DEFIV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        TB_DEFIV.Location = new System.Drawing.Point(76, 0);
        TB_DEFIV.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
        TB_DEFIV.Mask = "00";
        TB_DEFIV.Name = "TB_DEFIV";
        TB_DEFIV.Size = new System.Drawing.Size(25, 25);
        TB_DEFIV.TabIndex = 48;
        TB_DEFIV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        TB_DEFIV.TextChanged += UpdateStats;
        // 
        // TB_DEFEV
        // 
        TB_DEFEV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        TB_DEFEV.Location = new System.Drawing.Point(109, 0);
        TB_DEFEV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        TB_DEFEV.Mask = "000";
        TB_DEFEV.Name = "TB_DEFEV";
        TB_DEFEV.Size = new System.Drawing.Size(32, 25);
        TB_DEFEV.TabIndex = 49;
        TB_DEFEV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        TB_DEFEV.TextChanged += UpdateStats;
        // 
        // Stat_DEF
        // 
        Stat_DEF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        Stat_DEF.Enabled = false;
        Stat_DEF.Location = new System.Drawing.Point(149, 0);
        Stat_DEF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        Stat_DEF.Mask = "00000";
        Stat_DEF.Name = "Stat_DEF";
        Stat_DEF.PromptChar = ' ';
        Stat_DEF.Size = new System.Drawing.Size(43, 25);
        Stat_DEF.TabIndex = 50;
        Stat_DEF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // FLP_SpA
        // 
        FLP_SpA.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        FLP_SpA.Controls.Add(Label_SPA);
        FLP_SpA.Controls.Add(TB_SPAIV);
        FLP_SpA.Controls.Add(TB_SPAEV);
        FLP_SpA.Controls.Add(Stat_SPA);
        FLP_SpA.Location = new System.Drawing.Point(0, 97);
        FLP_SpA.Margin = new System.Windows.Forms.Padding(0);
        FLP_SpA.Name = "FLP_SpA";
        FLP_SpA.Size = new System.Drawing.Size(201, 24);
        FLP_SpA.TabIndex = 126;
        // 
        // Label_SPA
        // 
        Label_SPA.Location = new System.Drawing.Point(0, 0);
        Label_SPA.Margin = new System.Windows.Forms.Padding(0);
        Label_SPA.Name = "Label_SPA";
        Label_SPA.Size = new System.Drawing.Size(76, 24);
        Label_SPA.TabIndex = 51;
        Label_SPA.Text = "SpA:";
        Label_SPA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // TB_SPAIV
        // 
        TB_SPAIV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        TB_SPAIV.Location = new System.Drawing.Point(76, 0);
        TB_SPAIV.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
        TB_SPAIV.Mask = "00";
        TB_SPAIV.Name = "TB_SPAIV";
        TB_SPAIV.Size = new System.Drawing.Size(25, 25);
        TB_SPAIV.TabIndex = 49;
        TB_SPAIV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        TB_SPAIV.TextChanged += UpdateStats;
        // 
        // TB_SPAEV
        // 
        TB_SPAEV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        TB_SPAEV.Location = new System.Drawing.Point(109, 0);
        TB_SPAEV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        TB_SPAEV.Mask = "000";
        TB_SPAEV.Name = "TB_SPAEV";
        TB_SPAEV.Size = new System.Drawing.Size(32, 25);
        TB_SPAEV.TabIndex = 50;
        TB_SPAEV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        TB_SPAEV.TextChanged += UpdateStats;
        // 
        // Stat_SPA
        // 
        Stat_SPA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        Stat_SPA.Enabled = false;
        Stat_SPA.Location = new System.Drawing.Point(149, 0);
        Stat_SPA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        Stat_SPA.Mask = "00000";
        Stat_SPA.Name = "Stat_SPA";
        Stat_SPA.PromptChar = ' ';
        Stat_SPA.Size = new System.Drawing.Size(43, 25);
        Stat_SPA.TabIndex = 52;
        Stat_SPA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // FLP_SpD
        // 
        FLP_SpD.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        FLP_SpD.Controls.Add(Label_SPD);
        FLP_SpD.Controls.Add(TB_SPDIV);
        FLP_SpD.Controls.Add(TB_SPDEV);
        FLP_SpD.Controls.Add(Stat_SPD);
        FLP_SpD.Location = new System.Drawing.Point(0, 121);
        FLP_SpD.Margin = new System.Windows.Forms.Padding(0);
        FLP_SpD.Name = "FLP_SpD";
        FLP_SpD.Size = new System.Drawing.Size(201, 24);
        FLP_SpD.TabIndex = 127;
        // 
        // Label_SPD
        // 
        Label_SPD.Location = new System.Drawing.Point(0, 0);
        Label_SPD.Margin = new System.Windows.Forms.Padding(0);
        Label_SPD.Name = "Label_SPD";
        Label_SPD.Size = new System.Drawing.Size(76, 24);
        Label_SPD.TabIndex = 23;
        Label_SPD.Text = "SpD:";
        Label_SPD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // TB_SPDIV
        // 
        TB_SPDIV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        TB_SPDIV.Location = new System.Drawing.Point(76, 0);
        TB_SPDIV.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
        TB_SPDIV.Mask = "00";
        TB_SPDIV.Name = "TB_SPDIV";
        TB_SPDIV.Size = new System.Drawing.Size(25, 25);
        TB_SPDIV.TabIndex = 5;
        TB_SPDIV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        TB_SPDIV.TextChanged += UpdateStats;
        // 
        // TB_SPDEV
        // 
        TB_SPDEV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        TB_SPDEV.Location = new System.Drawing.Point(109, 0);
        TB_SPDEV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        TB_SPDEV.Mask = "000";
        TB_SPDEV.Name = "TB_SPDEV";
        TB_SPDEV.Size = new System.Drawing.Size(32, 25);
        TB_SPDEV.TabIndex = 11;
        TB_SPDEV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        TB_SPDEV.TextChanged += UpdateStats;
        // 
        // Stat_SPD
        // 
        Stat_SPD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        Stat_SPD.Enabled = false;
        Stat_SPD.Location = new System.Drawing.Point(149, 0);
        Stat_SPD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        Stat_SPD.Mask = "00000";
        Stat_SPD.Name = "Stat_SPD";
        Stat_SPD.PromptChar = ' ';
        Stat_SPD.Size = new System.Drawing.Size(43, 25);
        Stat_SPD.TabIndex = 49;
        Stat_SPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // FLP_Spe
        // 
        FLP_Spe.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        FLP_Spe.Controls.Add(Label_SPE);
        FLP_Spe.Controls.Add(TB_SPEIV);
        FLP_Spe.Controls.Add(TB_SPEEV);
        FLP_Spe.Controls.Add(Stat_SPE);
        FLP_Spe.Location = new System.Drawing.Point(0, 145);
        FLP_Spe.Margin = new System.Windows.Forms.Padding(0);
        FLP_Spe.Name = "FLP_Spe";
        FLP_Spe.Size = new System.Drawing.Size(201, 24);
        FLP_Spe.TabIndex = 128;
        // 
        // Label_SPE
        // 
        Label_SPE.Location = new System.Drawing.Point(0, 0);
        Label_SPE.Margin = new System.Windows.Forms.Padding(0);
        Label_SPE.Name = "Label_SPE";
        Label_SPE.Size = new System.Drawing.Size(76, 24);
        Label_SPE.TabIndex = 24;
        Label_SPE.Text = "Spe:";
        Label_SPE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // TB_SPEIV
        // 
        TB_SPEIV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        TB_SPEIV.Location = new System.Drawing.Point(76, 0);
        TB_SPEIV.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
        TB_SPEIV.Mask = "00";
        TB_SPEIV.Name = "TB_SPEIV";
        TB_SPEIV.Size = new System.Drawing.Size(25, 25);
        TB_SPEIV.TabIndex = 51;
        TB_SPEIV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        TB_SPEIV.TextChanged += UpdateStats;
        // 
        // TB_SPEEV
        // 
        TB_SPEEV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        TB_SPEEV.Location = new System.Drawing.Point(109, 0);
        TB_SPEEV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        TB_SPEEV.Mask = "000";
        TB_SPEEV.Name = "TB_SPEEV";
        TB_SPEEV.Size = new System.Drawing.Size(32, 25);
        TB_SPEEV.TabIndex = 52;
        TB_SPEEV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        TB_SPEEV.TextChanged += UpdateStats;
        // 
        // Stat_SPE
        // 
        Stat_SPE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        Stat_SPE.Enabled = false;
        Stat_SPE.Location = new System.Drawing.Point(149, 0);
        Stat_SPE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        Stat_SPE.Mask = "00000";
        Stat_SPE.Name = "Stat_SPE";
        Stat_SPE.PromptChar = ' ';
        Stat_SPE.Size = new System.Drawing.Size(43, 25);
        Stat_SPE.TabIndex = 53;
        Stat_SPE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // FLP_StatsTotal
        // 
        FLP_StatsTotal.Controls.Add(Label_Total);
        FLP_StatsTotal.Controls.Add(TB_IVTotal);
        FLP_StatsTotal.Controls.Add(TB_EVTotal);
        FLP_StatsTotal.Location = new System.Drawing.Point(0, 169);
        FLP_StatsTotal.Margin = new System.Windows.Forms.Padding(0);
        FLP_StatsTotal.Name = "FLP_StatsTotal";
        FLP_StatsTotal.Size = new System.Drawing.Size(201, 24);
        FLP_StatsTotal.TabIndex = 129;
        // 
        // Label_Total
        // 
        Label_Total.Location = new System.Drawing.Point(0, 0);
        Label_Total.Margin = new System.Windows.Forms.Padding(0);
        Label_Total.Name = "Label_Total";
        Label_Total.Size = new System.Drawing.Size(76, 24);
        Label_Total.TabIndex = 25;
        Label_Total.Text = "Total:";
        Label_Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // TB_IVTotal
        // 
        TB_IVTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        TB_IVTotal.Enabled = false;
        TB_IVTotal.Location = new System.Drawing.Point(76, 0);
        TB_IVTotal.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
        TB_IVTotal.MaxLength = 3;
        TB_IVTotal.Name = "TB_IVTotal";
        TB_IVTotal.Size = new System.Drawing.Size(25, 25);
        TB_IVTotal.TabIndex = 44;
        TB_IVTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // TB_EVTotal
        // 
        TB_EVTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        TB_EVTotal.Enabled = false;
        TB_EVTotal.Location = new System.Drawing.Point(109, 0);
        TB_EVTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        TB_EVTotal.MaxLength = 3;
        TB_EVTotal.Name = "TB_EVTotal";
        TB_EVTotal.Size = new System.Drawing.Size(32, 25);
        TB_EVTotal.TabIndex = 43;
        TB_EVTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // FLP_HPType
        // 
        FLP_HPType.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        FLP_HPType.Controls.Add(Label_HiddenPowerPrefix);
        FLP_HPType.Controls.Add(CB_HPType);
        FLP_HPType.Location = new System.Drawing.Point(0, 193);
        FLP_HPType.Margin = new System.Windows.Forms.Padding(0);
        FLP_HPType.Name = "FLP_HPType";
        FLP_HPType.Size = new System.Drawing.Size(201, 24);
        FLP_HPType.TabIndex = 130;
        // 
        // Label_HiddenPowerPrefix
        // 
        Label_HiddenPowerPrefix.Location = new System.Drawing.Point(0, 0);
        Label_HiddenPowerPrefix.Margin = new System.Windows.Forms.Padding(0);
        Label_HiddenPowerPrefix.Name = "Label_HiddenPowerPrefix";
        Label_HiddenPowerPrefix.Size = new System.Drawing.Size(119, 24);
        Label_HiddenPowerPrefix.TabIndex = 29;
        Label_HiddenPowerPrefix.Text = "Hidden Power:";
        Label_HiddenPowerPrefix.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // CB_HPType
        // 
        CB_HPType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
        CB_HPType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        CB_HPType.DropDownWidth = 80;
        CB_HPType.FormattingEnabled = true;
        CB_HPType.Location = new System.Drawing.Point(119, 0);
        CB_HPType.Margin = new System.Windows.Forms.Padding(0);
        CB_HPType.Name = "CB_HPType";
        CB_HPType.Size = new System.Drawing.Size(81, 25);
        CB_HPType.TabIndex = 44;
        CB_HPType.SelectedIndexChanged += UpdateHPType;
        // 
        // Tab_Moves
        // 
        Tab_Moves.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        Tab_Moves.Controls.Add(B_Clear);
        Tab_Moves.Controls.Add(B_CurrentAttack);
        Tab_Moves.Controls.Add(B_HighAttack);
        Tab_Moves.Controls.Add(GB_Moves);
        Tab_Moves.Location = new System.Drawing.Point(4, 26);
        Tab_Moves.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        Tab_Moves.Name = "Tab_Moves";
        Tab_Moves.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        Tab_Moves.Size = new System.Drawing.Size(263, 230);
        Tab_Moves.TabIndex = 1;
        Tab_Moves.Text = "Moves";
        // 
        // B_Clear
        // 
        B_Clear.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        B_Clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Clear.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Clear.ForeColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_Clear.Location = new System.Drawing.Point(88, 5);
        B_Clear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Clear.Name = "B_Clear";
        B_Clear.Size = new System.Drawing.Size(88, 27);
        B_Clear.TabIndex = 450;
        B_Clear.Text = "Clear";
        B_Clear.UseVisualStyleBackColor = false;
        B_Clear.Click += B_Clear_Click;
        // 
        // B_CurrentAttack
        // 
        B_CurrentAttack.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        B_CurrentAttack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_CurrentAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_CurrentAttack.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_CurrentAttack.ForeColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_CurrentAttack.Location = new System.Drawing.Point(6, 36);
        B_CurrentAttack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_CurrentAttack.Name = "B_CurrentAttack";
        B_CurrentAttack.Size = new System.Drawing.Size(117, 52);
        B_CurrentAttack.TabIndex = 449;
        B_CurrentAttack.Text = "Current Level \r\nLevelup Moves";
        B_CurrentAttack.UseVisualStyleBackColor = false;
        B_CurrentAttack.Click += B_CurrentAttack_Click;
        // 
        // B_HighAttack
        // 
        B_HighAttack.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        B_HighAttack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_HighAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_HighAttack.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_HighAttack.ForeColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_HighAttack.Location = new System.Drawing.Point(127, 37);
        B_HighAttack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_HighAttack.Name = "B_HighAttack";
        B_HighAttack.Size = new System.Drawing.Size(129, 51);
        B_HighAttack.TabIndex = 448;
        B_HighAttack.Text = "High Attacking \r\nLevelup Moves";
        B_HighAttack.UseVisualStyleBackColor = false;
        B_HighAttack.Click += B_HighAttack_Click;
        // 
        // GB_Moves
        // 
        GB_Moves.Controls.Add(CB_Move1);
        GB_Moves.Controls.Add(CB_Move4);
        GB_Moves.Controls.Add(CB_Move2);
        GB_Moves.Controls.Add(CB_Move3);
        GB_Moves.Font = new System.Drawing.Font("Segoe UI", 10F);
        GB_Moves.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        GB_Moves.Location = new System.Drawing.Point(25, 93);
        GB_Moves.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        GB_Moves.Name = "GB_Moves";
        GB_Moves.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        GB_Moves.Size = new System.Drawing.Size(211, 132);
        GB_Moves.TabIndex = 0;
        GB_Moves.TabStop = false;
        GB_Moves.Text = "Moves";
        // 
        // CB_Move1
        // 
        CB_Move1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
        CB_Move1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        CB_Move1.FormattingEnabled = true;
        CB_Move1.Location = new System.Drawing.Point(47, 18);
        CB_Move1.Margin = new System.Windows.Forms.Padding(0);
        CB_Move1.Name = "CB_Move1";
        CB_Move1.Size = new System.Drawing.Size(140, 25);
        CB_Move1.TabIndex = 1;
        // 
        // CB_Move4
        // 
        CB_Move4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
        CB_Move4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        CB_Move4.FormattingEnabled = true;
        CB_Move4.Location = new System.Drawing.Point(47, 95);
        CB_Move4.Margin = new System.Windows.Forms.Padding(0);
        CB_Move4.Name = "CB_Move4";
        CB_Move4.Size = new System.Drawing.Size(140, 25);
        CB_Move4.TabIndex = 4;
        // 
        // CB_Move2
        // 
        CB_Move2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
        CB_Move2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        CB_Move2.FormattingEnabled = true;
        CB_Move2.Location = new System.Drawing.Point(47, 44);
        CB_Move2.Margin = new System.Windows.Forms.Padding(0);
        CB_Move2.Name = "CB_Move2";
        CB_Move2.Size = new System.Drawing.Size(140, 25);
        CB_Move2.TabIndex = 2;
        // 
        // CB_Move3
        // 
        CB_Move3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
        CB_Move3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        CB_Move3.FormattingEnabled = true;
        CB_Move3.Location = new System.Drawing.Point(47, 69);
        CB_Move3.Margin = new System.Windows.Forms.Padding(0);
        CB_Move3.Name = "CB_Move3";
        CB_Move3.Size = new System.Drawing.Size(140, 25);
        CB_Move3.TabIndex = 3;
        // 
        // L_TrainerName
        // 
        L_TrainerName.AutoSize = true;
        L_TrainerName.Location = new System.Drawing.Point(0, 12);
        L_TrainerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_TrainerName.Name = "L_TrainerName";
        L_TrainerName.Size = new System.Drawing.Size(93, 19);
        L_TrainerName.TabIndex = 450;
        L_TrainerName.Text = "Trainer Name:";
        // 
        // TB_TrainerName
        // 
        TB_TrainerName.Location = new System.Drawing.Point(92, 9);
        TB_TrainerName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        TB_TrainerName.MaxLength = 50;
        TB_TrainerName.Name = "TB_TrainerName";
        TB_TrainerName.Size = new System.Drawing.Size(191, 25);
        TB_TrainerName.TabIndex = 35;
        TB_TrainerName.TextChanged += UpdateTrainerName;
        // 
        // NUD_NumPoke
        // 
        NUD_NumPoke.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        NUD_NumPoke.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_NumPoke.Location = new System.Drawing.Point(92, 84);
        NUD_NumPoke.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_NumPoke.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
        NUD_NumPoke.Name = "NUD_NumPoke";
        NUD_NumPoke.Size = new System.Drawing.Size(55, 25);
        NUD_NumPoke.TabIndex = 0;
        NUD_NumPoke.Visible = false;
        NUD_NumPoke.ValueChanged += UpdateNumPokemon;
        // 
        // TC_trdata
        // 
        TC_trdata.Controls.Add(Tab_Trainer);
        TC_trdata.Controls.Add(Tab_Rand);
        TC_trdata.Location = new System.Drawing.Point(292, 15);
        TC_trdata.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        TC_trdata.Name = "TC_trdata";
        TC_trdata.SelectedIndex = 0;
        TC_trdata.Size = new System.Drawing.Size(433, 260);
        TC_trdata.TabIndex = 450;
        // 
        // Tab_Trainer
        // 
        Tab_Trainer.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        Tab_Trainer.Controls.Add(GB_AIBits);
        Tab_Trainer.Controls.Add(L_Mode);
        Tab_Trainer.Controls.Add(CB_Mode);
        Tab_Trainer.Controls.Add(CHK_Flag);
        Tab_Trainer.Controls.Add(TB_TrainerName);
        Tab_Trainer.Controls.Add(L_Trainer_Class);
        Tab_Trainer.Controls.Add(CB_Item_1);
        Tab_Trainer.Controls.Add(CB_Trainer_Class);
        Tab_Trainer.Controls.Add(L_Money);
        Tab_Trainer.Controls.Add(L_TrainerName);
        Tab_Trainer.Controls.Add(CB_Money);
        Tab_Trainer.Controls.Add(L_Item_2);
        Tab_Trainer.Controls.Add(L_Item_4);
        Tab_Trainer.Controls.Add(NUD_NumPoke);
        Tab_Trainer.Controls.Add(L_numPokemon);
        Tab_Trainer.Controls.Add(L_Item_1);
        Tab_Trainer.Controls.Add(CB_Item_2);
        Tab_Trainer.Controls.Add(CB_Item_3);
        Tab_Trainer.Controls.Add(CB_Item_4);
        Tab_Trainer.Controls.Add(L_Item_3);
        Tab_Trainer.Location = new System.Drawing.Point(4, 26);
        Tab_Trainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        Tab_Trainer.Name = "Tab_Trainer";
        Tab_Trainer.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        Tab_Trainer.Size = new System.Drawing.Size(425, 230);
        Tab_Trainer.TabIndex = 0;
        Tab_Trainer.Text = "Trainer";
        // 
        // GB_AIBits
        // 
        GB_AIBits.Controls.Add(CHK_AI7);
        GB_AIBits.Controls.Add(CHK_AI6);
        GB_AIBits.Controls.Add(CHK_AI5);
        GB_AIBits.Controls.Add(CHK_AI4);
        GB_AIBits.Controls.Add(CHK_AI3);
        GB_AIBits.Controls.Add(CHK_AI2);
        GB_AIBits.Controls.Add(CHK_AI1);
        GB_AIBits.Controls.Add(CHK_AI0);
        GB_AIBits.Font = new System.Drawing.Font("Segoe UI", 10F);
        GB_AIBits.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        GB_AIBits.Location = new System.Drawing.Point(291, 2);
        GB_AIBits.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        GB_AIBits.Name = "GB_AIBits";
        GB_AIBits.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        GB_AIBits.Size = new System.Drawing.Size(126, 186);
        GB_AIBits.TabIndex = 464;
        GB_AIBits.TabStop = false;
        GB_AIBits.Text = "AI Bits";
        // 
        // CHK_AI7
        // 
        CHK_AI7.AutoSize = true;
        CHK_AI7.Location = new System.Drawing.Point(15, 153);
        CHK_AI7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_AI7.Name = "CHK_AI7";
        CHK_AI7.Size = new System.Drawing.Size(56, 23);
        CHK_AI7.TabIndex = 459;
        CHK_AI7.Text = "Item";
        CHK_AI7.UseVisualStyleBackColor = true;
        // 
        // CHK_AI6
        // 
        CHK_AI6.AutoSize = true;
        CHK_AI6.Location = new System.Drawing.Point(15, 137);
        CHK_AI6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_AI6.Name = "CHK_AI6";
        CHK_AI6.Size = new System.Drawing.Size(104, 23);
        CHK_AI6.TabIndex = 458;
        CHK_AI6.Text = "PokeChange";
        CHK_AI6.UseVisualStyleBackColor = true;
        // 
        // CHK_AI5
        // 
        CHK_AI5.AutoSize = true;
        CHK_AI5.Location = new System.Drawing.Point(15, 121);
        CHK_AI5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_AI5.Name = "CHK_AI5";
        CHK_AI5.Size = new System.Drawing.Size(96, 23);
        CHK_AI5.TabIndex = 457;
        CHK_AI5.Text = "BattleRoyal";
        CHK_AI5.UseVisualStyleBackColor = true;
        // 
        // CHK_AI4
        // 
        CHK_AI4.AutoSize = true;
        CHK_AI4.Location = new System.Drawing.Point(15, 105);
        CHK_AI4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_AI4.Name = "CHK_AI4";
        CHK_AI4.Size = new System.Drawing.Size(103, 23);
        CHK_AI4.TabIndex = 456;
        CHK_AI4.Text = "NoWhiteout";
        CHK_AI4.UseVisualStyleBackColor = true;
        // 
        // CHK_AI3
        // 
        CHK_AI3.AutoSize = true;
        CHK_AI3.Location = new System.Drawing.Point(15, 89);
        CHK_AI3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_AI3.Name = "CHK_AI3";
        CHK_AI3.Size = new System.Drawing.Size(78, 23);
        CHK_AI3.TabIndex = 455;
        CHK_AI3.Text = "Doubles";
        CHK_AI3.UseVisualStyleBackColor = true;
        // 
        // CHK_AI2
        // 
        CHK_AI2.AutoSize = true;
        CHK_AI2.Location = new System.Drawing.Point(15, 59);
        CHK_AI2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_AI2.Name = "CHK_AI2";
        CHK_AI2.Size = new System.Drawing.Size(66, 23);
        CHK_AI2.TabIndex = 454;
        CHK_AI2.Text = "Expert";
        CHK_AI2.UseVisualStyleBackColor = true;
        // 
        // CHK_AI1
        // 
        CHK_AI1.AutoSize = true;
        CHK_AI1.Location = new System.Drawing.Point(15, 43);
        CHK_AI1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_AI1.Name = "CHK_AI1";
        CHK_AI1.Size = new System.Drawing.Size(69, 23);
        CHK_AI1.TabIndex = 453;
        CHK_AI1.Text = "Strong";
        CHK_AI1.UseVisualStyleBackColor = true;
        // 
        // CHK_AI0
        // 
        CHK_AI0.AutoSize = true;
        CHK_AI0.Location = new System.Drawing.Point(15, 27);
        CHK_AI0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_AI0.Name = "CHK_AI0";
        CHK_AI0.Size = new System.Drawing.Size(58, 23);
        CHK_AI0.TabIndex = 452;
        CHK_AI0.Text = "Basic";
        CHK_AI0.UseVisualStyleBackColor = true;
        // 
        // L_Mode
        // 
        L_Mode.AutoSize = true;
        L_Mode.Location = new System.Drawing.Point(214, 200);
        L_Mode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Mode.Name = "L_Mode";
        L_Mode.Size = new System.Drawing.Size(87, 19);
        L_Mode.TabIndex = 453;
        L_Mode.Text = "Battle Mode:";
        // 
        // CB_Mode
        // 
        CB_Mode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
        CB_Mode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        CB_Mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        CB_Mode.FormattingEnabled = true;
        CB_Mode.Items.AddRange(new object[] { "Single", "Double", "Multi", "3", "4" });
        CB_Mode.Location = new System.Drawing.Point(304, 197);
        CB_Mode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CB_Mode.Name = "CB_Mode";
        CB_Mode.Size = new System.Drawing.Size(109, 25);
        CB_Mode.TabIndex = 452;
        // 
        // CHK_Flag
        // 
        CHK_Flag.AutoSize = true;
        CHK_Flag.Location = new System.Drawing.Point(182, 61);
        CHK_Flag.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_Flag.Name = "CHK_Flag";
        CHK_Flag.Size = new System.Drawing.Size(53, 23);
        CHK_Flag.TabIndex = 451;
        CHK_Flag.Text = "Flag";
        CHK_Flag.UseVisualStyleBackColor = true;
        // 
        // Tab_Rand
        // 
        Tab_Rand.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        Tab_Rand.Controls.Add(TC_rand);
        Tab_Rand.Controls.Add(B_Randomize);
        Tab_Rand.Controls.Add(B_Dump);
        Tab_Rand.Location = new System.Drawing.Point(4, 26);
        Tab_Rand.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        Tab_Rand.Name = "Tab_Rand";
        Tab_Rand.Size = new System.Drawing.Size(425, 230);
        Tab_Rand.TabIndex = 2;
        Tab_Rand.Text = "Randomizer Options";
        // 
        // TC_rand
        // 
        TC_rand.Controls.Add(Tab_PKM1);
        TC_rand.Controls.Add(Tab_PKM2);
        TC_rand.Controls.Add(Tab_Trainer1);
        TC_rand.Location = new System.Drawing.Point(4, 38);
        TC_rand.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        TC_rand.Name = "TC_rand";
        TC_rand.SelectedIndex = 0;
        TC_rand.Size = new System.Drawing.Size(416, 188);
        TC_rand.TabIndex = 448;
        // 
        // Tab_PKM1
        // 
        Tab_PKM1.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        Tab_PKM1.Controls.Add(L_ShinyPCT);
        Tab_PKM1.Controls.Add(NUD_Shiny);
        Tab_PKM1.Controls.Add(CHK_RandomShiny);
        Tab_PKM1.Controls.Add(CHK_E);
        Tab_PKM1.Controls.Add(CHK_L);
        Tab_PKM1.Controls.Add(CHK_G7);
        Tab_PKM1.Controls.Add(CHK_G6);
        Tab_PKM1.Controls.Add(CHK_G5);
        Tab_PKM1.Controls.Add(CHK_G4);
        Tab_PKM1.Controls.Add(CHK_G3);
        Tab_PKM1.Controls.Add(NUD_LevelBoost);
        Tab_PKM1.Controls.Add(CHK_G2);
        Tab_PKM1.Controls.Add(CHK_Level);
        Tab_PKM1.Controls.Add(CHK_G1);
        Tab_PKM1.Controls.Add(CHK_BST);
        Tab_PKM1.Controls.Add(CHK_RandomPKM);
        Tab_PKM1.Location = new System.Drawing.Point(4, 26);
        Tab_PKM1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        Tab_PKM1.Name = "Tab_PKM1";
        Tab_PKM1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        Tab_PKM1.Size = new System.Drawing.Size(408, 158);
        Tab_PKM1.TabIndex = 0;
        Tab_PKM1.Text = "Main";
        // 
        // L_ShinyPCT
        // 
        L_ShinyPCT.AutoSize = true;
        L_ShinyPCT.Location = new System.Drawing.Point(355, 101);
        L_ShinyPCT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_ShinyPCT.Name = "L_ShinyPCT";
        L_ShinyPCT.Size = new System.Drawing.Size(20, 19);
        L_ShinyPCT.TabIndex = 305;
        L_ShinyPCT.Text = "%";
        // 
        // NUD_Shiny
        // 
        NUD_Shiny.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        NUD_Shiny.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_Shiny.Location = new System.Drawing.Point(301, 98);
        NUD_Shiny.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_Shiny.Name = "NUD_Shiny";
        NUD_Shiny.Size = new System.Drawing.Size(50, 25);
        NUD_Shiny.TabIndex = 304;
        NUD_Shiny.Value = new decimal(new int[] { 3, 0, 0, 0 });
        // 
        // CHK_RandomShiny
        // 
        CHK_RandomShiny.AutoSize = true;
        CHK_RandomShiny.Checked = true;
        CHK_RandomShiny.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_RandomShiny.Location = new System.Drawing.Point(180, 99);
        CHK_RandomShiny.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_RandomShiny.Name = "CHK_RandomShiny";
        CHK_RandomShiny.Size = new System.Drawing.Size(125, 23);
        CHK_RandomShiny.TabIndex = 303;
        CHK_RandomShiny.Text = "Random Shinies";
        CHK_RandomShiny.UseVisualStyleBackColor = true;
        CHK_RandomShiny.CheckedChanged += CHK_RandomShiny_CheckedChanged;
        // 
        // CHK_E
        // 
        CHK_E.AutoSize = true;
        CHK_E.Checked = true;
        CHK_E.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_E.Location = new System.Drawing.Point(7, 135);
        CHK_E.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_E.Name = "CHK_E";
        CHK_E.Size = new System.Drawing.Size(117, 23);
        CHK_E.TabIndex = 296;
        CHK_E.Text = "Event Legends";
        CHK_E.UseVisualStyleBackColor = true;
        // 
        // CHK_L
        // 
        CHK_L.AutoSize = true;
        CHK_L.Checked = true;
        CHK_L.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_L.Location = new System.Drawing.Point(7, 119);
        CHK_L.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_L.Name = "CHK_L";
        CHK_L.Size = new System.Drawing.Size(119, 23);
        CHK_L.TabIndex = 295;
        CHK_L.Text = "Game Legends";
        CHK_L.UseVisualStyleBackColor = true;
        // 
        // CHK_G7
        // 
        CHK_G7.AutoSize = true;
        CHK_G7.Checked = true;
        CHK_G7.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_G7.Location = new System.Drawing.Point(7, 103);
        CHK_G7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_G7.Name = "CHK_G7";
        CHK_G7.Size = new System.Drawing.Size(65, 23);
        CHK_G7.TabIndex = 298;
        CHK_G7.Text = "Gen 7";
        CHK_G7.UseVisualStyleBackColor = true;
        // 
        // CHK_G6
        // 
        CHK_G6.AutoSize = true;
        CHK_G6.Checked = true;
        CHK_G6.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_G6.Location = new System.Drawing.Point(7, 87);
        CHK_G6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_G6.Name = "CHK_G6";
        CHK_G6.Size = new System.Drawing.Size(65, 23);
        CHK_G6.TabIndex = 294;
        CHK_G6.Text = "Gen 6";
        CHK_G6.UseVisualStyleBackColor = true;
        // 
        // CHK_G5
        // 
        CHK_G5.AutoSize = true;
        CHK_G5.Checked = true;
        CHK_G5.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_G5.Location = new System.Drawing.Point(7, 70);
        CHK_G5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_G5.Name = "CHK_G5";
        CHK_G5.Size = new System.Drawing.Size(65, 23);
        CHK_G5.TabIndex = 293;
        CHK_G5.Text = "Gen 5";
        CHK_G5.UseVisualStyleBackColor = true;
        // 
        // CHK_G4
        // 
        CHK_G4.AutoSize = true;
        CHK_G4.Checked = true;
        CHK_G4.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_G4.Location = new System.Drawing.Point(7, 54);
        CHK_G4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_G4.Name = "CHK_G4";
        CHK_G4.Size = new System.Drawing.Size(65, 23);
        CHK_G4.TabIndex = 292;
        CHK_G4.Text = "Gen 4";
        CHK_G4.UseVisualStyleBackColor = true;
        // 
        // CHK_G3
        // 
        CHK_G3.AutoSize = true;
        CHK_G3.Checked = true;
        CHK_G3.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_G3.Location = new System.Drawing.Point(7, 38);
        CHK_G3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_G3.Name = "CHK_G3";
        CHK_G3.Size = new System.Drawing.Size(65, 23);
        CHK_G3.TabIndex = 291;
        CHK_G3.Text = "Gen 3";
        CHK_G3.UseVisualStyleBackColor = true;
        // 
        // NUD_LevelBoost
        // 
        NUD_LevelBoost.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        NUD_LevelBoost.DecimalPlaces = 2;
        NUD_LevelBoost.Enabled = false;
        NUD_LevelBoost.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_LevelBoost.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
        NUD_LevelBoost.Location = new System.Drawing.Point(345, 128);
        NUD_LevelBoost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_LevelBoost.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
        NUD_LevelBoost.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
        NUD_LevelBoost.Name = "NUD_LevelBoost";
        NUD_LevelBoost.Size = new System.Drawing.Size(50, 25);
        NUD_LevelBoost.TabIndex = 301;
        NUD_LevelBoost.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // CHK_G2
        // 
        CHK_G2.AutoSize = true;
        CHK_G2.Checked = true;
        CHK_G2.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_G2.Location = new System.Drawing.Point(7, 22);
        CHK_G2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_G2.Name = "CHK_G2";
        CHK_G2.Size = new System.Drawing.Size(65, 23);
        CHK_G2.TabIndex = 290;
        CHK_G2.Text = "Gen 2";
        CHK_G2.UseVisualStyleBackColor = true;
        // 
        // CHK_Level
        // 
        CHK_Level.AutoSize = true;
        CHK_Level.Location = new System.Drawing.Point(180, 129);
        CHK_Level.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_Level.Name = "CHK_Level";
        CHK_Level.Size = new System.Drawing.Size(165, 23);
        CHK_Level.TabIndex = 300;
        CHK_Level.Text = "Multiply PKM Level by";
        CHK_Level.UseVisualStyleBackColor = true;
        CHK_Level.CheckedChanged += CHK_Level_CheckedChanged;
        // 
        // CHK_G1
        // 
        CHK_G1.AutoSize = true;
        CHK_G1.Checked = true;
        CHK_G1.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_G1.Location = new System.Drawing.Point(7, 6);
        CHK_G1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_G1.Name = "CHK_G1";
        CHK_G1.Size = new System.Drawing.Size(65, 23);
        CHK_G1.TabIndex = 289;
        CHK_G1.Text = "Gen 1";
        CHK_G1.UseVisualStyleBackColor = true;
        // 
        // CHK_BST
        // 
        CHK_BST.AutoSize = true;
        CHK_BST.Location = new System.Drawing.Point(180, 27);
        CHK_BST.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_BST.Name = "CHK_BST";
        CHK_BST.Size = new System.Drawing.Size(140, 23);
        CHK_BST.TabIndex = 297;
        CHK_BST.Text = "Randomize by BST";
        CHK_BST.UseVisualStyleBackColor = true;
        // 
        // CHK_RandomPKM
        // 
        CHK_RandomPKM.AutoSize = true;
        CHK_RandomPKM.Checked = true;
        CHK_RandomPKM.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_RandomPKM.Location = new System.Drawing.Point(180, 6);
        CHK_RandomPKM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_RandomPKM.Name = "CHK_RandomPKM";
        CHK_RandomPKM.Size = new System.Drawing.Size(140, 23);
        CHK_RandomPKM.TabIndex = 299;
        CHK_RandomPKM.Text = "Random Pokémon";
        CHK_RandomPKM.UseVisualStyleBackColor = true;
        CHK_RandomPKM.CheckedChanged += CHK_RandomPKM_CheckedChanged;
        // 
        // Tab_PKM2
        // 
        Tab_PKM2.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        Tab_PKM2.Controls.Add(CHK_ForceHighPower);
        Tab_PKM2.Controls.Add(NUD_ForceHighPower);
        Tab_PKM2.Controls.Add(CHK_NoFixedDamage);
        Tab_PKM2.Controls.Add(CHK_MaxAI);
        Tab_PKM2.Controls.Add(L_Moves);
        Tab_PKM2.Controls.Add(CB_Moves);
        Tab_PKM2.Controls.Add(CHK_MaxDiffPKM);
        Tab_PKM2.Controls.Add(NUD_Damage);
        Tab_PKM2.Controls.Add(CHK_RandomAbilities);
        Tab_PKM2.Controls.Add(NUD_STAB);
        Tab_PKM2.Controls.Add(CHK_Damage);
        Tab_PKM2.Controls.Add(CHK_RandomItems);
        Tab_PKM2.Controls.Add(CHK_STAB);
        Tab_PKM2.Location = new System.Drawing.Point(4, 26);
        Tab_PKM2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        Tab_PKM2.Name = "Tab_PKM2";
        Tab_PKM2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        Tab_PKM2.Size = new System.Drawing.Size(408, 158);
        Tab_PKM2.TabIndex = 1;
        Tab_PKM2.Text = "Stats/Moves";
        // 
        // CHK_ForceHighPower
        // 
        CHK_ForceHighPower.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        CHK_ForceHighPower.AutoSize = true;
        CHK_ForceHighPower.Location = new System.Drawing.Point(7, 22);
        CHK_ForceHighPower.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_ForceHighPower.Name = "CHK_ForceHighPower";
        CHK_ForceHighPower.Size = new System.Drawing.Size(252, 23);
        CHK_ForceHighPower.TabIndex = 342;
        CHK_ForceHighPower.Text = "Force High-Powered Attacks at Level";
        CHK_ForceHighPower.UseVisualStyleBackColor = true;
        // 
        // NUD_ForceHighPower
        // 
        NUD_ForceHighPower.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        NUD_ForceHighPower.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        NUD_ForceHighPower.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_ForceHighPower.Location = new System.Drawing.Point(261, 19);
        NUD_ForceHighPower.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_ForceHighPower.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        NUD_ForceHighPower.Name = "NUD_ForceHighPower";
        NUD_ForceHighPower.Size = new System.Drawing.Size(47, 25);
        NUD_ForceHighPower.TabIndex = 341;
        NUD_ForceHighPower.Value = new decimal(new int[] { 50, 0, 0, 0 });
        // 
        // CHK_NoFixedDamage
        // 
        CHK_NoFixedDamage.AutoSize = true;
        CHK_NoFixedDamage.Checked = true;
        CHK_NoFixedDamage.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_NoFixedDamage.Location = new System.Drawing.Point(7, 90);
        CHK_NoFixedDamage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_NoFixedDamage.Name = "CHK_NoFixedDamage";
        CHK_NoFixedDamage.Size = new System.Drawing.Size(350, 23);
        CHK_NoFixedDamage.TabIndex = 340;
        CHK_NoFixedDamage.Text = "No Fixed Damage Moves (Dragon Rage/Sonic Boom)";
        CHK_NoFixedDamage.UseVisualStyleBackColor = true;
        // 
        // CHK_MaxAI
        // 
        CHK_MaxAI.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        CHK_MaxAI.AutoSize = true;
        CHK_MaxAI.Checked = true;
        CHK_MaxAI.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_MaxAI.Location = new System.Drawing.Point(262, 129);
        CHK_MaxAI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_MaxAI.Name = "CHK_MaxAI";
        CHK_MaxAI.Size = new System.Drawing.Size(116, 23);
        CHK_MaxAI.TabIndex = 339;
        CHK_MaxAI.Text = "Max Trainer AI";
        CHK_MaxAI.UseVisualStyleBackColor = true;
        // 
        // L_Moves
        // 
        L_Moves.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        L_Moves.AutoSize = true;
        L_Moves.Location = new System.Drawing.Point(7, 4);
        L_Moves.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Moves.Name = "L_Moves";
        L_Moves.Size = new System.Drawing.Size(53, 19);
        L_Moves.TabIndex = 338;
        L_Moves.Text = "Moves:";
        // 
        // CB_Moves
        // 
        CB_Moves.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        CB_Moves.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        CB_Moves.FormattingEnabled = true;
        CB_Moves.Items.AddRange(new object[] { "Don't Modify", "Randomize All", "Use Levelup Only", "Metronome Mode" });
        CB_Moves.Location = new System.Drawing.Point(61, -2);
        CB_Moves.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CB_Moves.Name = "CB_Moves";
        CB_Moves.Size = new System.Drawing.Size(157, 25);
        CB_Moves.TabIndex = 337;
        CB_Moves.SelectedIndexChanged += CB_Moves_SelectedIndexChanged;
        // 
        // CHK_MaxDiffPKM
        // 
        CHK_MaxDiffPKM.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        CHK_MaxDiffPKM.AutoSize = true;
        CHK_MaxDiffPKM.Checked = true;
        CHK_MaxDiffPKM.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_MaxDiffPKM.Location = new System.Drawing.Point(262, 112);
        CHK_MaxDiffPKM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_MaxDiffPKM.Name = "CHK_MaxDiffPKM";
        CHK_MaxDiffPKM.Size = new System.Drawing.Size(77, 23);
        CHK_MaxDiffPKM.TabIndex = 332;
        CHK_MaxDiffPKM.Text = "Max IVs";
        CHK_MaxDiffPKM.UseVisualStyleBackColor = true;
        // 
        // NUD_Damage
        // 
        NUD_Damage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        NUD_Damage.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        NUD_Damage.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_Damage.Location = new System.Drawing.Point(261, 43);
        NUD_Damage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_Damage.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
        NUD_Damage.Name = "NUD_Damage";
        NUD_Damage.Size = new System.Drawing.Size(41, 25);
        NUD_Damage.TabIndex = 333;
        NUD_Damage.Value = new decimal(new int[] { 2, 0, 0, 0 });
        // 
        // CHK_RandomAbilities
        // 
        CHK_RandomAbilities.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        CHK_RandomAbilities.AutoSize = true;
        CHK_RandomAbilities.Checked = true;
        CHK_RandomAbilities.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_RandomAbilities.Location = new System.Drawing.Point(7, 129);
        CHK_RandomAbilities.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_RandomAbilities.Name = "CHK_RandomAbilities";
        CHK_RandomAbilities.Size = new System.Drawing.Size(233, 23);
        CHK_RandomAbilities.TabIndex = 331;
        CHK_RandomAbilities.Text = "Random Abilities (1, 2, or Hidden)";
        CHK_RandomAbilities.UseVisualStyleBackColor = true;
        // 
        // NUD_STAB
        // 
        NUD_STAB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        NUD_STAB.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        NUD_STAB.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_STAB.Location = new System.Drawing.Point(261, 67);
        NUD_STAB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_STAB.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
        NUD_STAB.Name = "NUD_STAB";
        NUD_STAB.Size = new System.Drawing.Size(41, 25);
        NUD_STAB.TabIndex = 336;
        NUD_STAB.Value = new decimal(new int[] { 2, 0, 0, 0 });
        // 
        // CHK_Damage
        // 
        CHK_Damage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        CHK_Damage.AutoSize = true;
        CHK_Damage.Checked = true;
        CHK_Damage.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_Damage.Location = new System.Drawing.Point(7, 45);
        CHK_Damage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_Damage.Name = "CHK_Damage";
        CHK_Damage.Size = new System.Drawing.Size(241, 23);
        CHK_Damage.TabIndex = 334;
        CHK_Damage.Text = "Ensure at least # Damaging Moves";
        CHK_Damage.UseVisualStyleBackColor = true;
        CHK_Damage.CheckedChanged += CHK_Damage_CheckedChanged;
        // 
        // CHK_RandomItems
        // 
        CHK_RandomItems.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        CHK_RandomItems.AutoSize = true;
        CHK_RandomItems.Checked = true;
        CHK_RandomItems.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_RandomItems.Location = new System.Drawing.Point(7, 111);
        CHK_RandomItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_RandomItems.Name = "CHK_RandomItems";
        CHK_RandomItems.Size = new System.Drawing.Size(149, 23);
        CHK_RandomItems.TabIndex = 330;
        CHK_RandomItems.Text = "Random Held Items";
        CHK_RandomItems.UseVisualStyleBackColor = true;
        // 
        // CHK_STAB
        // 
        CHK_STAB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        CHK_STAB.AutoSize = true;
        CHK_STAB.Checked = true;
        CHK_STAB.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_STAB.Location = new System.Drawing.Point(7, 69);
        CHK_STAB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_STAB.Name = "CHK_STAB";
        CHK_STAB.Size = new System.Drawing.Size(208, 23);
        CHK_STAB.TabIndex = 335;
        CHK_STAB.Text = "Ensure at least # STAB Moves";
        CHK_STAB.UseVisualStyleBackColor = true;
        CHK_STAB.CheckedChanged += CHK_STAB_CheckedChanged;
        // 
        // Tab_Trainer1
        // 
        Tab_Trainer1.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        Tab_Trainer1.Controls.Add(CHK_ReplaceMega);
        Tab_Trainer1.Controls.Add(CHK_6PKM);
        Tab_Trainer1.Controls.Add(NUD_ForceFullyEvolved);
        Tab_Trainer1.Controls.Add(L_MinPKM);
        Tab_Trainer1.Controls.Add(L_MaxPKM);
        Tab_Trainer1.Controls.Add(NUD_RMin);
        Tab_Trainer1.Controls.Add(NUD_RMax);
        Tab_Trainer1.Controls.Add(CHK_RandomMegaForm);
        Tab_Trainer1.Controls.Add(CHK_TypeTheme);
        Tab_Trainer1.Controls.Add(CHK_IgnoreSpecialClass);
        Tab_Trainer1.Controls.Add(CHK_RandomClass);
        Tab_Trainer1.Controls.Add(CHK_ForceFullyEvolved);
        Tab_Trainer1.Location = new System.Drawing.Point(4, 26);
        Tab_Trainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        Tab_Trainer1.Name = "Tab_Trainer1";
        Tab_Trainer1.Size = new System.Drawing.Size(408, 158);
        Tab_Trainer1.TabIndex = 2;
        Tab_Trainer1.Text = "Trainer";
        // 
        // CHK_ReplaceMega
        // 
        CHK_ReplaceMega.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        CHK_ReplaceMega.AutoSize = true;
        CHK_ReplaceMega.Checked = true;
        CHK_ReplaceMega.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_ReplaceMega.Location = new System.Drawing.Point(7, 129);
        CHK_ReplaceMega.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_ReplaceMega.Name = "CHK_ReplaceMega";
        CHK_ReplaceMega.Size = new System.Drawing.Size(247, 23);
        CHK_ReplaceMega.TabIndex = 343;
        CHK_ReplaceMega.Text = "Ensure Post-Game Mega Evolutions";
        CHK_ReplaceMega.UseVisualStyleBackColor = true;
        // 
        // CHK_6PKM
        // 
        CHK_6PKM.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        CHK_6PKM.AutoSize = true;
        CHK_6PKM.Location = new System.Drawing.Point(7, 112);
        CHK_6PKM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_6PKM.Name = "CHK_6PKM";
        CHK_6PKM.Size = new System.Drawing.Size(235, 23);
        CHK_6PKM.TabIndex = 341;
        CHK_6PKM.Text = "6 Pokémon for Important Trainers";
        CHK_6PKM.UseVisualStyleBackColor = true;
        // 
        // NUD_ForceFullyEvolved
        // 
        NUD_ForceFullyEvolved.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        NUD_ForceFullyEvolved.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_ForceFullyEvolved.Location = new System.Drawing.Point(204, 79);
        NUD_ForceFullyEvolved.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_ForceFullyEvolved.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        NUD_ForceFullyEvolved.Name = "NUD_ForceFullyEvolved";
        NUD_ForceFullyEvolved.Size = new System.Drawing.Size(47, 25);
        NUD_ForceFullyEvolved.TabIndex = 340;
        NUD_ForceFullyEvolved.Value = new decimal(new int[] { 50, 0, 0, 0 });
        // 
        // L_MinPKM
        // 
        L_MinPKM.Location = new System.Drawing.Point(274, 3);
        L_MinPKM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_MinPKM.Name = "L_MinPKM";
        L_MinPKM.Size = new System.Drawing.Size(70, 23);
        L_MinPKM.TabIndex = 338;
        L_MinPKM.Text = "Min PKM:";
        L_MinPKM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // L_MaxPKM
        // 
        L_MaxPKM.Location = new System.Drawing.Point(235, 31);
        L_MaxPKM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_MaxPKM.Name = "L_MaxPKM";
        L_MaxPKM.Size = new System.Drawing.Size(108, 23);
        L_MaxPKM.TabIndex = 337;
        L_MaxPKM.Text = "Max PKM:";
        L_MaxPKM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // NUD_RMin
        // 
        NUD_RMin.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        NUD_RMin.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_RMin.Location = new System.Drawing.Point(351, 6);
        NUD_RMin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_RMin.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
        NUD_RMin.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        NUD_RMin.Name = "NUD_RMin";
        NUD_RMin.Size = new System.Drawing.Size(47, 25);
        NUD_RMin.TabIndex = 336;
        NUD_RMin.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // NUD_RMax
        // 
        NUD_RMax.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        NUD_RMax.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_RMax.Location = new System.Drawing.Point(351, 30);
        NUD_RMax.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_RMax.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
        NUD_RMax.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        NUD_RMax.Name = "NUD_RMax";
        NUD_RMax.Size = new System.Drawing.Size(47, 25);
        NUD_RMax.TabIndex = 335;
        NUD_RMax.Value = new decimal(new int[] { 6, 0, 0, 0 });
        // 
        // CHK_RandomMegaForm
        // 
        CHK_RandomMegaForm.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        CHK_RandomMegaForm.AutoSize = true;
        CHK_RandomMegaForm.Location = new System.Drawing.Point(7, 96);
        CHK_RandomMegaForm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_RandomMegaForm.Name = "CHK_RandomMegaForm";
        CHK_RandomMegaForm.Size = new System.Drawing.Size(160, 23);
        CHK_RandomMegaForm.TabIndex = 333;
        CHK_RandomMegaForm.Text = "Random Mega Forms";
        CHK_RandomMegaForm.UseVisualStyleBackColor = true;
        // 
        // CHK_TypeTheme
        // 
        CHK_TypeTheme.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        CHK_TypeTheme.AutoSize = true;
        CHK_TypeTheme.Location = new System.Drawing.Point(7, 30);
        CHK_TypeTheme.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_TypeTheme.Name = "CHK_TypeTheme";
        CHK_TypeTheme.Size = new System.Drawing.Size(152, 23);
        CHK_TypeTheme.TabIndex = 329;
        CHK_TypeTheme.Text = "Type Theme Trainers";
        CHK_TypeTheme.UseVisualStyleBackColor = true;
        // 
        // CHK_IgnoreSpecialClass
        // 
        CHK_IgnoreSpecialClass.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        CHK_IgnoreSpecialClass.AutoSize = true;
        CHK_IgnoreSpecialClass.Checked = true;
        CHK_IgnoreSpecialClass.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_IgnoreSpecialClass.Location = new System.Drawing.Point(7, 14);
        CHK_IgnoreSpecialClass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_IgnoreSpecialClass.Name = "CHK_IgnoreSpecialClass";
        CHK_IgnoreSpecialClass.Size = new System.Drawing.Size(161, 23);
        CHK_IgnoreSpecialClass.TabIndex = 327;
        CHK_IgnoreSpecialClass.Text = "Ignore Special Classes";
        CHK_IgnoreSpecialClass.UseVisualStyleBackColor = true;
        // 
        // CHK_RandomClass
        // 
        CHK_RandomClass.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        CHK_RandomClass.AutoSize = true;
        CHK_RandomClass.Checked = true;
        CHK_RandomClass.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_RandomClass.Location = new System.Drawing.Point(7, -2);
        CHK_RandomClass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_RandomClass.Name = "CHK_RandomClass";
        CHK_RandomClass.Size = new System.Drawing.Size(172, 23);
        CHK_RandomClass.TabIndex = 326;
        CHK_RandomClass.Text = "Random Trainer Classes";
        CHK_RandomClass.UseVisualStyleBackColor = true;
        CHK_RandomClass.CheckedChanged += CHK_RandomClass_CheckedChanged;
        // 
        // CHK_ForceFullyEvolved
        // 
        CHK_ForceFullyEvolved.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        CHK_ForceFullyEvolved.AutoSize = true;
        CHK_ForceFullyEvolved.Location = new System.Drawing.Point(7, 80);
        CHK_ForceFullyEvolved.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_ForceFullyEvolved.Name = "CHK_ForceFullyEvolved";
        CHK_ForceFullyEvolved.Size = new System.Drawing.Size(195, 23);
        CHK_ForceFullyEvolved.TabIndex = 339;
        CHK_ForceFullyEvolved.Text = "Force Fully Evolved at Level";
        CHK_ForceFullyEvolved.UseVisualStyleBackColor = true;
        // 
        // SMTE
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        ClientSize = new System.Drawing.Size(736, 363);
        Controls.Add(TC_trpoke);
        Controls.Add(L_Team);
        Controls.Add(PB_Team1);
        Controls.Add(PB_Team2);
        Controls.Add(PB_Team3);
        Controls.Add(PB_Team4);
        Controls.Add(PB_Team5);
        Controls.Add(PB_Team6);
        Controls.Add(CB_TrainerID);
        Controls.Add(TC_trdata);
        Font = new System.Drawing.Font("Segoe UI", 10F);
        ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        Name = "SMTE";
        Text = "Trainer Editor";
        ((System.ComponentModel.ISupportInitialize)PB_Team1).EndInit();
        mnuVSD.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)PB_Team2).EndInit();
        ((System.ComponentModel.ISupportInitialize)PB_Team3).EndInit();
        ((System.ComponentModel.ISupportInitialize)PB_Team4).EndInit();
        ((System.ComponentModel.ISupportInitialize)PB_Team5).EndInit();
        ((System.ComponentModel.ISupportInitialize)PB_Team6).EndInit();
        TC_trpoke.ResumeLayout(false);
        Tab_Main.ResumeLayout(false);
        flowLayoutPanel2.ResumeLayout(false);
        FLP_Species.ResumeLayout(false);
        FLP_Form.ResumeLayout(false);
        flowLayoutPanel3.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)NUD_Level).EndInit();
        flowLayoutPanel4.ResumeLayout(false);
        flowLayoutPanel1.ResumeLayout(false);
        flowLayoutPanel5.ResumeLayout(false);
        flowLayoutPanel6.ResumeLayout(false);
        flowLayoutPanel6.PerformLayout();
        flowLayoutPanel7.ResumeLayout(false);
        Tab_Stats.ResumeLayout(false);
        FLP_Stats.ResumeLayout(false);
        FLP_StatHeader.ResumeLayout(false);
        FLP_StatsHeaderRight.ResumeLayout(false);
        FLP_HP.ResumeLayout(false);
        FLP_HP.PerformLayout();
        FLP_Atk.ResumeLayout(false);
        FLP_Atk.PerformLayout();
        FLP_Def.ResumeLayout(false);
        FLP_Def.PerformLayout();
        FLP_SpA.ResumeLayout(false);
        FLP_SpA.PerformLayout();
        FLP_SpD.ResumeLayout(false);
        FLP_SpD.PerformLayout();
        FLP_Spe.ResumeLayout(false);
        FLP_Spe.PerformLayout();
        FLP_StatsTotal.ResumeLayout(false);
        FLP_StatsTotal.PerformLayout();
        FLP_HPType.ResumeLayout(false);
        Tab_Moves.ResumeLayout(false);
        GB_Moves.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)NUD_NumPoke).EndInit();
        TC_trdata.ResumeLayout(false);
        Tab_Trainer.ResumeLayout(false);
        Tab_Trainer.PerformLayout();
        GB_AIBits.ResumeLayout(false);
        GB_AIBits.PerformLayout();
        Tab_Rand.ResumeLayout(false);
        TC_rand.ResumeLayout(false);
        Tab_PKM1.ResumeLayout(false);
        Tab_PKM1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_Shiny).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_LevelBoost).EndInit();
        Tab_PKM2.ResumeLayout(false);
        Tab_PKM2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_ForceHighPower).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Damage).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_STAB).EndInit();
        Tab_Trainer1.ResumeLayout(false);
        Tab_Trainer1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_ForceFullyEvolved).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_RMin).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_RMax).EndInit();
        ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.ComboBox CB_TrainerID;
    private System.Windows.Forms.Label L_Money;
    private System.Windows.Forms.ComboBox CB_Money;
    private System.Windows.Forms.Label L_Trainer_Class;
    private System.Windows.Forms.ComboBox CB_Trainer_Class;
    private System.Windows.Forms.Label L_Item_4;
    private System.Windows.Forms.ComboBox CB_Item_4;
    private System.Windows.Forms.Label L_Item_3;
    private System.Windows.Forms.ComboBox CB_Item_3;
    private System.Windows.Forms.Label L_Item_2;
    private System.Windows.Forms.ComboBox CB_Item_2;
    private System.Windows.Forms.Label L_Item_1;
    private System.Windows.Forms.ComboBox CB_Item_1;
    private System.Windows.Forms.Label L_numPokemon;
    private System.Windows.Forms.Label L_Team;
    private System.Windows.Forms.PictureBox PB_Team1;
    private System.Windows.Forms.PictureBox PB_Team2;
    private System.Windows.Forms.PictureBox PB_Team3;
    private System.Windows.Forms.PictureBox PB_Team4;
    private System.Windows.Forms.PictureBox PB_Team5;
    private System.Windows.Forms.PictureBox PB_Team6;
    private System.Windows.Forms.Button B_Randomize;
    private System.Windows.Forms.Button B_Dump;
    private System.Windows.Forms.TabControl TC_trpoke;
    private System.Windows.Forms.TabPage Tab_Main;
    private System.Windows.Forms.TabPage Tab_Moves;
    private System.Windows.Forms.Label L_Species;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    private System.Windows.Forms.FlowLayoutPanel FLP_Species;
    private System.Windows.Forms.ComboBox CB_Species;
    private System.Windows.Forms.FlowLayoutPanel FLP_Form;
    private System.Windows.Forms.Label L_Forme;
    private System.Windows.Forms.ComboBox CB_Forme;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
    private System.Windows.Forms.Label L_Level;
    private System.Windows.Forms.NumericUpDown NUD_Level;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
    private System.Windows.Forms.Label L_Ability;
    private System.Windows.Forms.ComboBox CB_Ability;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private System.Windows.Forms.Label L_Item;
    private System.Windows.Forms.ComboBox CB_Item;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
    private System.Windows.Forms.Label L_Nature;
    private System.Windows.Forms.ComboBox CB_Nature;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
    private System.Windows.Forms.Label L_Misc;
    private System.Windows.Forms.CheckBox CHK_Shiny;
    private System.Windows.Forms.ComboBox CB_Move1;
    private System.Windows.Forms.ComboBox CB_Move2;
    private System.Windows.Forms.ComboBox CB_Move4;
    private System.Windows.Forms.ComboBox CB_Move3;
    private System.Windows.Forms.GroupBox GB_Moves;
    private System.Windows.Forms.NumericUpDown NUD_NumPoke;
    private System.Windows.Forms.TextBox TB_TrainerName;
    private System.Windows.Forms.Label L_TrainerName;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
    private System.Windows.Forms.Label L_Gender;
    private System.Windows.Forms.ComboBox CB_Gender;
    private System.Windows.Forms.FlowLayoutPanel FLP_Stats;
    private System.Windows.Forms.FlowLayoutPanel FLP_StatHeader;
    private System.Windows.Forms.FlowLayoutPanel FLP_StatsHeaderRight;
    private System.Windows.Forms.Label Label_IVs;
    private System.Windows.Forms.Label Label_EVs;
    private System.Windows.Forms.Label Label_Stats;
    private System.Windows.Forms.FlowLayoutPanel FLP_HP;
    private System.Windows.Forms.Label Label_HP;
    private System.Windows.Forms.FlowLayoutPanel FLP_Atk;
    private System.Windows.Forms.Label Label_ATK;
    private System.Windows.Forms.FlowLayoutPanel FLP_Def;
    private System.Windows.Forms.Label Label_DEF;
    private System.Windows.Forms.FlowLayoutPanel FLP_SpA;
    private System.Windows.Forms.FlowLayoutPanel FLP_SpD;
    private System.Windows.Forms.Label Label_SPD;
    private System.Windows.Forms.MaskedTextBox TB_SPDIV;
    private System.Windows.Forms.MaskedTextBox TB_SPDEV;
    private System.Windows.Forms.MaskedTextBox Stat_SPD;
    private System.Windows.Forms.FlowLayoutPanel FLP_Spe;
    private System.Windows.Forms.Label Label_SPE;
    private System.Windows.Forms.FlowLayoutPanel FLP_StatsTotal;
    private System.Windows.Forms.Label Label_Total;
    private System.Windows.Forms.FlowLayoutPanel FLP_HPType;
    private System.Windows.Forms.Label Label_HiddenPowerPrefix;
    private System.Windows.Forms.ComboBox CB_HPType;
    private System.Windows.Forms.TextBox TB_EVTotal;
    private System.Windows.Forms.TextBox TB_IVTotal;
    private System.Windows.Forms.MaskedTextBox Stat_SPE;
    private System.Windows.Forms.MaskedTextBox TB_SPEEV;
    private System.Windows.Forms.MaskedTextBox TB_SPEIV;
    private System.Windows.Forms.MaskedTextBox Stat_DEF;
    private System.Windows.Forms.MaskedTextBox TB_DEFEV;
    private System.Windows.Forms.MaskedTextBox TB_DEFIV;
    private System.Windows.Forms.MaskedTextBox Stat_ATK;
    private System.Windows.Forms.MaskedTextBox TB_ATKEV;
    private System.Windows.Forms.MaskedTextBox TB_ATKIV;
    private System.Windows.Forms.MaskedTextBox Stat_HP;
    private System.Windows.Forms.MaskedTextBox TB_HPEV;
    private System.Windows.Forms.MaskedTextBox TB_HPIV;
    private System.Windows.Forms.MaskedTextBox Stat_SPA;
    private System.Windows.Forms.MaskedTextBox TB_SPAEV;
    private System.Windows.Forms.MaskedTextBox TB_SPAIV;
    private System.Windows.Forms.Label Label_SPA;
    private System.Windows.Forms.TabPage Tab_Stats;
    private System.Windows.Forms.Button B_HighAttack;
    private System.Windows.Forms.Button B_CurrentAttack;
    private System.Windows.Forms.ContextMenuStrip mnuVSD;
    private System.Windows.Forms.ToolStripMenuItem mnuView;
    private System.Windows.Forms.ToolStripMenuItem mnuSet;
    private System.Windows.Forms.ToolStripMenuItem mnuDelete;
    private System.Windows.Forms.Button B_Clear;
    private System.Windows.Forms.TabControl TC_trdata;
    private System.Windows.Forms.TabPage Tab_Trainer;
    private System.Windows.Forms.TabPage Tab_Rand;
    private System.Windows.Forms.CheckBox CHK_RandomClass;
    private System.Windows.Forms.CheckBox CHK_IgnoreSpecialClass;
    private System.Windows.Forms.CheckBox CHK_TypeTheme;
    private System.Windows.Forms.CheckBox CHK_RandomMegaForm;
    private System.Windows.Forms.NumericUpDown NUD_RMax;
    private System.Windows.Forms.NumericUpDown NUD_RMin;
    private System.Windows.Forms.Label L_MaxPKM;
    private System.Windows.Forms.Label L_MinPKM;
    private System.Windows.Forms.TabPage Tab_Trainer1;
    private System.Windows.Forms.CheckBox CHK_STAB;
    private System.Windows.Forms.CheckBox CHK_RandomItems;
    private System.Windows.Forms.NumericUpDown NUD_STAB;
    private System.Windows.Forms.CheckBox CHK_RandomAbilities;
    private System.Windows.Forms.CheckBox CHK_MaxDiffPKM;
    private System.Windows.Forms.ComboBox CB_Moves;
    private System.Windows.Forms.Label L_Moves;
    private System.Windows.Forms.CheckBox CHK_MaxAI;
    private System.Windows.Forms.TabPage Tab_PKM2;
    private System.Windows.Forms.CheckBox CHK_RandomPKM;
    private System.Windows.Forms.CheckBox CHK_BST;
    private System.Windows.Forms.CheckBox CHK_G1;
    private System.Windows.Forms.CheckBox CHK_Level;
    private System.Windows.Forms.CheckBox CHK_G2;
    private System.Windows.Forms.NumericUpDown NUD_LevelBoost;
    private System.Windows.Forms.CheckBox CHK_G3;
    private System.Windows.Forms.CheckBox CHK_G4;
    private System.Windows.Forms.CheckBox CHK_G5;
    private System.Windows.Forms.CheckBox CHK_G6;
    private System.Windows.Forms.CheckBox CHK_G7;
    private System.Windows.Forms.CheckBox CHK_L;
    private System.Windows.Forms.CheckBox CHK_E;
    private System.Windows.Forms.CheckBox CHK_RandomShiny;
    private System.Windows.Forms.NumericUpDown NUD_Shiny;
    private System.Windows.Forms.Label L_ShinyPCT;
    private System.Windows.Forms.TabPage Tab_PKM1;
    private System.Windows.Forms.TabControl TC_rand;
    private System.Windows.Forms.CheckBox CHK_Damage;
    private System.Windows.Forms.NumericUpDown NUD_Damage;
    private System.Windows.Forms.CheckBox CHK_Flag;
    private System.Windows.Forms.CheckBox CHK_NoFixedDamage;
    private System.Windows.Forms.NumericUpDown NUD_ForceFullyEvolved;
    private System.Windows.Forms.CheckBox CHK_ForceFullyEvolved;
    private System.Windows.Forms.CheckBox CHK_6PKM;
    private System.Windows.Forms.CheckBox CHK_ForceHighPower;
    private System.Windows.Forms.NumericUpDown NUD_ForceHighPower;
    private System.Windows.Forms.CheckBox CHK_ReplaceMega;
    private System.Windows.Forms.Label L_Mode;
    private System.Windows.Forms.ComboBox CB_Mode;
    private System.Windows.Forms.GroupBox GB_AIBits;
    private System.Windows.Forms.CheckBox CHK_AI6;
    private System.Windows.Forms.CheckBox CHK_AI5;
    private System.Windows.Forms.CheckBox CHK_AI4;
    private System.Windows.Forms.CheckBox CHK_AI3;
    private System.Windows.Forms.CheckBox CHK_AI2;
    private System.Windows.Forms.CheckBox CHK_AI1;
    private System.Windows.Forms.CheckBox CHK_AI0;
    private System.Windows.Forms.CheckBox CHK_AI7;
}
