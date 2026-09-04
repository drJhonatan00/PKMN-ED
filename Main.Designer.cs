namespace pk3DS.WinForms;

sealed partial class Main
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
        TB_Path = new System.Windows.Forms.TextBox();
        L_Game = new System.Windows.Forms.Label();
        pBar1 = new System.Windows.Forms.ProgressBar();
        B_OPower = new System.Windows.Forms.Button();
        B_Pickup = new System.Windows.Forms.Button();
        B_Mart = new System.Windows.Forms.Button();
        B_MoveTutor = new System.Windows.Forms.Button();
        B_TMHM = new System.Windows.Forms.Button();
        RTB_Status = new System.Windows.Forms.RichTextBox();
        menuStrip1 = new System.Windows.Forms.MenuStrip();
        Menu_File = new System.Windows.Forms.ToolStripMenuItem();
        Menu_Open = new System.Windows.Forms.ToolStripMenuItem();
        Menu_Exit = new System.Windows.Forms.ToolStripMenuItem();
        Menu_Tools = new System.Windows.Forms.ToolStripMenuItem();
        Menu_Restore = new System.Windows.Forms.ToolStripMenuItem();
        Menu_Misc = new System.Windows.Forms.ToolStripMenuItem();
        unPackBCLIMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        Menu_BLZ = new System.Windows.Forms.ToolStripMenuItem();
        Menu_LZ11 = new System.Windows.Forms.ToolStripMenuItem();
        Menu_Shuffler = new System.Windows.Forms.ToolStripMenuItem();
        Menu_Extract = new System.Windows.Forms.ToolStripMenuItem();
        Menu_Extract_CXI = new System.Windows.Forms.ToolStripMenuItem();
        Menu_Extract_3DS = new System.Windows.Forms.ToolStripMenuItem();
        Menu_Rebuild = new System.Windows.Forms.ToolStripMenuItem();
        Menu_RomFS = new System.Windows.Forms.ToolStripMenuItem();
        Menu_ExeFS = new System.Windows.Forms.ToolStripMenuItem();
        Menu_CRO = new System.Windows.Forms.ToolStripMenuItem();
        Menu_Trimmed3DS = new System.Windows.Forms.ToolStripMenuItem();
        Menu_3DS = new System.Windows.Forms.ToolStripMenuItem();
        Menu_Patch = new System.Windows.Forms.ToolStripMenuItem();
        Menu_SMDH = new System.Windows.Forms.ToolStripMenuItem();
        randomizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        setInt32SeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        Menu_Options = new System.Windows.Forms.ToolStripMenuItem();
        Menu_Language = new System.Windows.Forms.ToolStripMenuItem();
        CB_Lang = new System.Windows.Forms.ToolStripComboBox();
        Menu_About = new System.Windows.Forms.ToolStripMenuItem();
        Menu_GARCs = new System.Windows.Forms.ToolStripMenuItem();
        TC_RomFS = new System.Windows.Forms.TabControl();
        Tab_RomFS = new System.Windows.Forms.TabPage();
        FLP_RomFS = new System.Windows.Forms.FlowLayoutPanel();
        B_MegaEvo = new System.Windows.Forms.Button();
        B_EggMove = new System.Windows.Forms.Button();
        B_GameText = new System.Windows.Forms.Button();
        B_StoryText = new System.Windows.Forms.Button();
        B_Personal = new System.Windows.Forms.Button();
        B_Evolution = new System.Windows.Forms.Button();
        B_LevelUp = new System.Windows.Forms.Button();
        B_Wild = new System.Windows.Forms.Button();
        B_Trainer = new System.Windows.Forms.Button();
        B_Maison = new System.Windows.Forms.Button();
        B_Royal = new System.Windows.Forms.Button();
        B_Item = new System.Windows.Forms.Button();
        B_Move = new System.Windows.Forms.Button();
        B_TitleScreen = new System.Windows.Forms.Button();
        B_OWSE = new System.Windows.Forms.Button();
        Tab_ExeFS = new System.Windows.Forms.TabPage();
        FLP_ExeFS = new System.Windows.Forms.FlowLayoutPanel();
        B_TM = new System.Windows.Forms.Button();
        B_ShinyRate = new System.Windows.Forms.Button();
        Tab_CRO = new System.Windows.Forms.TabPage();
        FLP_CRO = new System.Windows.Forms.FlowLayoutPanel();
        B_TypeChart = new System.Windows.Forms.Button();
        B_Starter = new System.Windows.Forms.Button();
        B_Gift = new System.Windows.Forms.Button();
        B_Static = new System.Windows.Forms.Button();
        Tab_Output = new System.Windows.Forms.TabPage();
        button1 = new System.Windows.Forms.Button();
        L_Status = new System.Windows.Forms.Label();
        btnExtrair = new System.Windows.Forms.Button();
        menuStrip1.SuspendLayout();
        TC_RomFS.SuspendLayout();
        Tab_RomFS.SuspendLayout();
        FLP_RomFS.SuspendLayout();
        Tab_ExeFS.SuspendLayout();
        FLP_ExeFS.SuspendLayout();
        Tab_CRO.SuspendLayout();
        FLP_CRO.SuspendLayout();
        Tab_Output.SuspendLayout();
        SuspendLayout();
        // 
        // TB_Path
        // 
        TB_Path.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        TB_Path.Location = new System.Drawing.Point(187, 3);
        TB_Path.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        TB_Path.Name = "TB_Path";
        TB_Path.ReadOnly = true;
        TB_Path.Size = new System.Drawing.Size(249, 23);
        TB_Path.TabIndex = 1;
        // 
        // L_Game
        // 
        L_Game.AutoSize = true;
        L_Game.BackColor = System.Drawing.Color.Transparent;
        L_Game.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        L_Game.ForeColor = System.Drawing.Color.DarkRed;
        L_Game.Location = new System.Drawing.Point(183, 27);
        L_Game.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Game.Name = "L_Game";
        L_Game.Size = new System.Drawing.Size(102, 15);
        L_Game.TabIndex = 2;
        L_Game.Text = "No Game Loaded";
        // 
        // pBar1
        // 
        pBar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        pBar1.Location = new System.Drawing.Point(14, 290);
        pBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        pBar1.Name = "pBar1";
        pBar1.Size = new System.Drawing.Size(420, 16);
        pBar1.TabIndex = 6;
        // 
        // B_OPower
        // 
        B_OPower.Location = new System.Drawing.Point(254, 36);
        B_OPower.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_OPower.Name = "B_OPower";
        B_OPower.Size = new System.Drawing.Size(117, 27);
        B_OPower.TabIndex = 4;
        B_OPower.Text = "O-Powers";
        B_OPower.UseVisualStyleBackColor = true;
        B_OPower.Click += B_OPower_Click;
        // 
        // B_Pickup
        // 
        B_Pickup.Location = new System.Drawing.Point(129, 36);
        B_Pickup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Pickup.Name = "B_Pickup";
        B_Pickup.Size = new System.Drawing.Size(117, 27);
        B_Pickup.TabIndex = 0;
        B_Pickup.Text = "Pickup Items";
        B_Pickup.UseVisualStyleBackColor = true;
        B_Pickup.Click += B_Pickup_Click;
        // 
        // B_Mart
        // 
        B_Mart.Location = new System.Drawing.Point(4, 36);
        B_Mart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Mart.Name = "B_Mart";
        B_Mart.Size = new System.Drawing.Size(117, 27);
        B_Mart.TabIndex = 2;
        B_Mart.Text = "Poké Mart";
        B_Mart.UseVisualStyleBackColor = true;
        B_Mart.Click += B_Mart_Click;
        // 
        // B_MoveTutor
        // 
        B_MoveTutor.Location = new System.Drawing.Point(4, 3);
        B_MoveTutor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_MoveTutor.Name = "B_MoveTutor";
        B_MoveTutor.Size = new System.Drawing.Size(117, 27);
        B_MoveTutor.TabIndex = 3;
        B_MoveTutor.Text = "Move Tutors";
        B_MoveTutor.UseVisualStyleBackColor = true;
        B_MoveTutor.Click += B_MoveTutor_Click;
        // 
        // B_TMHM
        // 
        B_TMHM.Location = new System.Drawing.Point(129, 3);
        B_TMHM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_TMHM.Name = "B_TMHM";
        B_TMHM.Size = new System.Drawing.Size(117, 27);
        B_TMHM.TabIndex = 1;
        B_TMHM.Text = "TMs/HMs";
        B_TMHM.UseVisualStyleBackColor = true;
        B_TMHM.Click += B_TMHM_Click;
        // 
        // RTB_Status
        // 
        RTB_Status.Dock = System.Windows.Forms.DockStyle.Fill;
        RTB_Status.Location = new System.Drawing.Point(0, 0);
        RTB_Status.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        RTB_Status.Name = "RTB_Status";
        RTB_Status.ReadOnly = true;
        RTB_Status.Size = new System.Drawing.Size(412, 180);
        RTB_Status.TabIndex = 7;
        RTB_Status.Text = "";
        // 
        // menuStrip1
        // 
        menuStrip1.BackColor = System.Drawing.Color.Transparent;
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { Menu_File, Menu_Tools, Menu_Options });
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
        menuStrip1.Size = new System.Drawing.Size(448, 24);
        menuStrip1.TabIndex = 9;
        menuStrip1.Text = "menuStrip1";
        // 
        // Menu_File
        // 
        Menu_File.BackColor = System.Drawing.Color.Transparent;
        Menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { Menu_Open, Menu_Exit });
        Menu_File.Name = "Menu_File";
        Menu_File.Size = new System.Drawing.Size(37, 20);
        Menu_File.Text = "File";
        // 
        // Menu_Open
        // 
        Menu_Open.Name = "Menu_Open";
        Menu_Open.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O;
        Menu_Open.Size = new System.Drawing.Size(155, 22);
        Menu_Open.Text = "&Open...";
        Menu_Open.Click += B_Open_Click;
        // 
        // Menu_Exit
        // 
        Menu_Exit.Name = "Menu_Exit";
        Menu_Exit.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q;
        Menu_Exit.Size = new System.Drawing.Size(155, 22);
        Menu_Exit.Text = "&Exit";
        Menu_Exit.Click += Menu_Exit_Click;
        // 
        // Menu_Tools
        // 
        Menu_Tools.BackColor = System.Drawing.Color.Transparent;
        Menu_Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { Menu_Restore, Menu_Misc, Menu_Extract, Menu_Rebuild, Menu_SMDH, randomizationToolStripMenuItem });
        Menu_Tools.Name = "Menu_Tools";
        Menu_Tools.Size = new System.Drawing.Size(47, 20);
        Menu_Tools.Text = "Tools";
        // 
        // Menu_Restore
        // 
        Menu_Restore.Enabled = false;
        Menu_Restore.Name = "Menu_Restore";
        Menu_Restore.Size = new System.Drawing.Size(184, 22);
        Menu_Restore.Text = "Restore Original Files";
        Menu_Restore.Click += L_Game_Click;
        // 
        // Menu_Misc
        // 
        Menu_Misc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { unPackBCLIMToolStripMenuItem, Menu_BLZ, Menu_LZ11, Menu_Shuffler });
        Menu_Misc.Name = "Menu_Misc";
        Menu_Misc.Size = new System.Drawing.Size(184, 22);
        Menu_Misc.Text = "Misc Tools";
        // 
        // unPackBCLIMToolStripMenuItem
        // 
        unPackBCLIMToolStripMenuItem.Name = "unPackBCLIMToolStripMenuItem";
        unPackBCLIMToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T;
        unPackBCLIMToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
        unPackBCLIMToolStripMenuItem.Text = "(un)Pack + BCLIM";
        unPackBCLIMToolStripMenuItem.Click += L_SubTools_Click;
        // 
        // Menu_BLZ
        // 
        Menu_BLZ.Name = "Menu_BLZ";
        Menu_BLZ.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B;
        Menu_BLZ.Size = new System.Drawing.Size(216, 22);
        Menu_BLZ.Text = "(de)Compress BLZ";
        Menu_BLZ.Click += Menu_BLZ_Click;
        // 
        // Menu_LZ11
        // 
        Menu_LZ11.Name = "Menu_LZ11";
        Menu_LZ11.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L;
        Menu_LZ11.Size = new System.Drawing.Size(216, 22);
        Menu_LZ11.Text = "(de)Compress LZ11";
        Menu_LZ11.Click += Menu_LZ11_Click;
        // 
        // Menu_Shuffler
        // 
        Menu_Shuffler.Enabled = false;
        Menu_Shuffler.Name = "Menu_Shuffler";
        Menu_Shuffler.Size = new System.Drawing.Size(216, 22);
        Menu_Shuffler.Text = "GARC Shuffler";
        Menu_Shuffler.Click += Menu_Shuffler_Click;
        // 
        // Menu_Extract
        // 
        Menu_Extract.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { Menu_Extract_CXI, Menu_Extract_3DS });
        Menu_Extract.Name = "Menu_Extract";
        Menu_Extract.Size = new System.Drawing.Size(184, 22);
        Menu_Extract.Text = "Extract...";
        // 
        // Menu_Extract_CXI
        // 
        Menu_Extract_CXI.Name = "Menu_Extract_CXI";
        Menu_Extract_CXI.Size = new System.Drawing.Size(97, 22);
        Menu_Extract_CXI.Text = ".CXI";
        Menu_Extract_CXI.Click += B_ExtractCXI_Click;
        // 
        // Menu_Extract_3DS
        // 
        Menu_Extract_3DS.Name = "Menu_Extract_3DS";
        Menu_Extract_3DS.Size = new System.Drawing.Size(97, 22);
        Menu_Extract_3DS.Text = ".3DS";
        Menu_Extract_3DS.Click += B_Extract3DS_Click;
        // 
        // Menu_Rebuild
        // 
        Menu_Rebuild.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { Menu_RomFS, Menu_ExeFS, Menu_CRO, Menu_Trimmed3DS, Menu_3DS, Menu_Patch });
        Menu_Rebuild.Name = "Menu_Rebuild";
        Menu_Rebuild.Size = new System.Drawing.Size(184, 22);
        Menu_Rebuild.Text = "Rebuild...";
        // 
        // Menu_RomFS
        // 
        Menu_RomFS.Enabled = false;
        Menu_RomFS.Name = "Menu_RomFS";
        Menu_RomFS.Size = new System.Drawing.Size(148, 22);
        Menu_RomFS.Text = "RomFS";
        Menu_RomFS.Click += RebuildRomFS;
        // 
        // Menu_ExeFS
        // 
        Menu_ExeFS.Enabled = false;
        Menu_ExeFS.Name = "Menu_ExeFS";
        Menu_ExeFS.Size = new System.Drawing.Size(148, 22);
        Menu_ExeFS.Text = "ExeFS";
        Menu_ExeFS.Click += RebuildExeFS;
        // 
        // Menu_CRO
        // 
        Menu_CRO.Enabled = false;
        Menu_CRO.Name = "Menu_CRO";
        Menu_CRO.Size = new System.Drawing.Size(148, 22);
        Menu_CRO.Text = "CRO";
        Menu_CRO.Click += PatchCRO_CRR;
        // 
        // Menu_Trimmed3DS
        // 
        Menu_Trimmed3DS.Enabled = false;
        Menu_Trimmed3DS.Name = "Menu_Trimmed3DS";
        Menu_Trimmed3DS.Size = new System.Drawing.Size(148, 22);
        Menu_Trimmed3DS.Text = "Trimmed .3DS";
        Menu_Trimmed3DS.Click += B_RebuildTrimmed3DS_Click;
        // 
        // Menu_3DS
        // 
        Menu_3DS.Enabled = false;
        Menu_3DS.Name = "Menu_3DS";
        Menu_3DS.Size = new System.Drawing.Size(148, 22);
        Menu_3DS.Text = ".3DS";
        Menu_3DS.Click += B_Rebuild3DS_Click;
        // 
        // Menu_Patch
        // 
        Menu_Patch.Enabled = false;
        Menu_Patch.Name = "Menu_Patch";
        Menu_Patch.Size = new System.Drawing.Size(148, 22);
        Menu_Patch.Text = "Patch";
        Menu_Patch.Click += B_Patch_Click;
        // 
        // Menu_SMDH
        // 
        Menu_SMDH.Name = "Menu_SMDH";
        Menu_SMDH.Size = new System.Drawing.Size(184, 22);
        Menu_SMDH.Text = "SMDH Editor (Icon)";
        Menu_SMDH.Click += Menu_SMDH_Click;
        // 
        // randomizationToolStripMenuItem
        // 
        randomizationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { setInt32SeedToolStripMenuItem });
        randomizationToolStripMenuItem.Name = "randomizationToolStripMenuItem";
        randomizationToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
        randomizationToolStripMenuItem.Text = "Randomization";
        // 
        // setInt32SeedToolStripMenuItem
        // 
        setInt32SeedToolStripMenuItem.Name = "setInt32SeedToolStripMenuItem";
        setInt32SeedToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
        setInt32SeedToolStripMenuItem.Text = "Set int32 seed";
        setInt32SeedToolStripMenuItem.Click += SetInt32SeedToolStripMenuItem_Click;
        // 
        // Menu_Options
        // 
        Menu_Options.BackColor = System.Drawing.Color.Transparent;
        Menu_Options.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { Menu_Language, Menu_About, Menu_GARCs });
        Menu_Options.Name = "Menu_Options";
        Menu_Options.Size = new System.Drawing.Size(61, 20);
        Menu_Options.Text = "Options";
        // 
        // Menu_Language
        // 
        Menu_Language.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { CB_Lang });
        Menu_Language.Name = "Menu_Language";
        Menu_Language.Size = new System.Drawing.Size(162, 22);
        Menu_Language.Text = "Language";
        // 
        // CB_Lang
        // 
        CB_Lang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        CB_Lang.Items.AddRange(new object[] { "カタカナ", "漢字", "English", "Français", "Italiano", "Deutsch", "Español", "한국", "汉字简化方案", "漢字簡化方案" });
        CB_Lang.Name = "CB_Lang";
        CB_Lang.Size = new System.Drawing.Size(121, 23);
        CB_Lang.SelectedIndexChanged += ChangeLanguage;
        // 
        // Menu_About
        // 
        Menu_About.Name = "Menu_About";
        Menu_About.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B;
        Menu_About.ShowShortcutKeys = false;
        Menu_About.Size = new System.Drawing.Size(162, 22);
        Menu_About.Text = "A&bout PKMN - ED";
        Menu_About.Click += L_About_Click;
        // 
        // Menu_GARCs
        // 
        Menu_GARCs.Name = "Menu_GARCs";
        Menu_GARCs.Size = new System.Drawing.Size(162, 22);
        Menu_GARCs.Text = "About GARCs";
        Menu_GARCs.Click += L_GARCInfo_Click;
        // 
        // TC_RomFS
        // 
        TC_RomFS.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        TC_RomFS.Controls.Add(Tab_RomFS);
        TC_RomFS.Controls.Add(Tab_ExeFS);
        TC_RomFS.Controls.Add(Tab_CRO);
        TC_RomFS.Controls.Add(Tab_Output);
        TC_RomFS.Location = new System.Drawing.Point(14, 45);
        TC_RomFS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        TC_RomFS.Name = "TC_RomFS";
        TC_RomFS.SelectedIndex = 0;
        TC_RomFS.Size = new System.Drawing.Size(420, 208);
        TC_RomFS.TabIndex = 11;
        // 
        // Tab_RomFS
        // 
        Tab_RomFS.BackColor = System.Drawing.Color.Transparent;
        Tab_RomFS.Controls.Add(FLP_RomFS);
        Tab_RomFS.Location = new System.Drawing.Point(4, 24);
        Tab_RomFS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        Tab_RomFS.Name = "Tab_RomFS";
        Tab_RomFS.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        Tab_RomFS.Size = new System.Drawing.Size(412, 180);
        Tab_RomFS.TabIndex = 0;
        Tab_RomFS.Text = "RomFS";
        // 
        // FLP_RomFS
        // 
        FLP_RomFS.AutoScroll = true;
        FLP_RomFS.BackColor = System.Drawing.SystemColors.Control;
        FLP_RomFS.Controls.Add(B_MegaEvo);
        FLP_RomFS.Controls.Add(B_EggMove);
        FLP_RomFS.Controls.Add(B_GameText);
        FLP_RomFS.Controls.Add(B_StoryText);
        FLP_RomFS.Controls.Add(B_Personal);
        FLP_RomFS.Controls.Add(B_Evolution);
        FLP_RomFS.Controls.Add(B_LevelUp);
        FLP_RomFS.Controls.Add(B_Wild);
        FLP_RomFS.Controls.Add(B_Trainer);
        FLP_RomFS.Controls.Add(B_Maison);
        FLP_RomFS.Controls.Add(B_Royal);
        FLP_RomFS.Controls.Add(B_Item);
        FLP_RomFS.Controls.Add(B_Move);
        FLP_RomFS.Controls.Add(B_TitleScreen);
        FLP_RomFS.Controls.Add(B_OWSE);
        FLP_RomFS.Dock = System.Windows.Forms.DockStyle.Fill;
        FLP_RomFS.Location = new System.Drawing.Point(4, 3);
        FLP_RomFS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        FLP_RomFS.Name = "FLP_RomFS";
        FLP_RomFS.Size = new System.Drawing.Size(404, 174);
        FLP_RomFS.TabIndex = 13;
        // 
        // B_MegaEvo
        // 
        B_MegaEvo.Location = new System.Drawing.Point(4, 3);
        B_MegaEvo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_MegaEvo.Name = "B_MegaEvo";
        B_MegaEvo.Size = new System.Drawing.Size(117, 27);
        B_MegaEvo.TabIndex = 7;
        B_MegaEvo.Text = "Mega Evolutions";
        B_MegaEvo.UseVisualStyleBackColor = true;
        B_MegaEvo.Click += B_MegaEvo_Click;
        // 
        // B_EggMove
        // 
        B_EggMove.Location = new System.Drawing.Point(129, 3);
        B_EggMove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_EggMove.Name = "B_EggMove";
        B_EggMove.Size = new System.Drawing.Size(117, 27);
        B_EggMove.TabIndex = 10;
        B_EggMove.Text = "Egg Moves";
        B_EggMove.UseVisualStyleBackColor = true;
        B_EggMove.Click += B_EggMove_Click;
        // 
        // B_GameText
        // 
        B_GameText.Location = new System.Drawing.Point(254, 3);
        B_GameText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_GameText.Name = "B_GameText";
        B_GameText.Size = new System.Drawing.Size(117, 27);
        B_GameText.TabIndex = 0;
        B_GameText.Text = "Game Text";
        B_GameText.UseVisualStyleBackColor = true;
        B_GameText.Click += B_GameText_Click;
        // 
        // B_StoryText
        // 
        B_StoryText.Location = new System.Drawing.Point(4, 36);
        B_StoryText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_StoryText.Name = "B_StoryText";
        B_StoryText.Size = new System.Drawing.Size(117, 27);
        B_StoryText.TabIndex = 1;
        B_StoryText.Text = "Story Text";
        B_StoryText.UseVisualStyleBackColor = true;
        B_StoryText.Click += B_StoryText_Click;
        // 
        // B_Personal
        // 
        B_Personal.Location = new System.Drawing.Point(129, 36);
        B_Personal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Personal.Name = "B_Personal";
        B_Personal.Size = new System.Drawing.Size(117, 27);
        B_Personal.TabIndex = 3;
        B_Personal.Text = "Personal Stats";
        B_Personal.UseVisualStyleBackColor = true;
        B_Personal.Click += B_Personal_Click;
        // 
        // B_Evolution
        // 
        B_Evolution.Location = new System.Drawing.Point(254, 36);
        B_Evolution.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Evolution.Name = "B_Evolution";
        B_Evolution.Size = new System.Drawing.Size(117, 27);
        B_Evolution.TabIndex = 6;
        B_Evolution.Text = "Evolutions";
        B_Evolution.UseVisualStyleBackColor = true;
        B_Evolution.Click += B_Evolution_Click;
        // 
        // B_LevelUp
        // 
        B_LevelUp.Location = new System.Drawing.Point(4, 69);
        B_LevelUp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_LevelUp.Name = "B_LevelUp";
        B_LevelUp.Size = new System.Drawing.Size(117, 27);
        B_LevelUp.TabIndex = 9;
        B_LevelUp.Text = "Level Up Moves";
        B_LevelUp.UseVisualStyleBackColor = true;
        B_LevelUp.Click += B_LevelUp_Click;
        // 
        // B_Wild
        // 
        B_Wild.Location = new System.Drawing.Point(129, 69);
        B_Wild.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Wild.Name = "B_Wild";
        B_Wild.Size = new System.Drawing.Size(117, 27);
        B_Wild.TabIndex = 4;
        B_Wild.Text = "Wild Encounters";
        B_Wild.UseVisualStyleBackColor = true;
        B_Wild.Click += B_Wild_Click;
        // 
        // B_Trainer
        // 
        B_Trainer.Location = new System.Drawing.Point(254, 69);
        B_Trainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Trainer.Name = "B_Trainer";
        B_Trainer.Size = new System.Drawing.Size(117, 27);
        B_Trainer.TabIndex = 2;
        B_Trainer.Text = "Trainers";
        B_Trainer.UseVisualStyleBackColor = true;
        B_Trainer.Click += B_Trainer_Click;
        // 
        // B_Maison
        // 
        B_Maison.Location = new System.Drawing.Point(4, 102);
        B_Maison.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Maison.Name = "B_Maison";
        B_Maison.Size = new System.Drawing.Size(117, 27);
        B_Maison.TabIndex = 5;
        B_Maison.Text = "Battle Maison";
        B_Maison.UseVisualStyleBackColor = true;
        B_Maison.Click += B_Maison_Click;
        // 
        // B_Royal
        // 
        B_Royal.Location = new System.Drawing.Point(129, 102);
        B_Royal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Royal.Name = "B_Royal";
        B_Royal.Size = new System.Drawing.Size(117, 27);
        B_Royal.TabIndex = 14;
        B_Royal.Text = "Battle Royal/Tree";
        B_Royal.UseVisualStyleBackColor = true;
        B_Royal.Click += B_Maison_Click;
        // 
        // B_Item
        // 
        B_Item.Location = new System.Drawing.Point(254, 102);
        B_Item.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Item.Name = "B_Item";
        B_Item.Size = new System.Drawing.Size(117, 27);
        B_Item.TabIndex = 8;
        B_Item.Text = "Item Stats";
        B_Item.UseVisualStyleBackColor = true;
        B_Item.Click += B_Item_Click;
        // 
        // B_Move
        // 
        B_Move.Location = new System.Drawing.Point(4, 135);
        B_Move.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Move.Name = "B_Move";
        B_Move.Size = new System.Drawing.Size(117, 27);
        B_Move.TabIndex = 11;
        B_Move.Text = "Move Stats";
        B_Move.UseVisualStyleBackColor = true;
        B_Move.Click += B_Move_Click;
        // 
        // B_TitleScreen
        // 
        B_TitleScreen.Location = new System.Drawing.Point(129, 135);
        B_TitleScreen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_TitleScreen.Name = "B_TitleScreen";
        B_TitleScreen.Size = new System.Drawing.Size(117, 27);
        B_TitleScreen.TabIndex = 12;
        B_TitleScreen.Text = "Title Screen";
        B_TitleScreen.UseVisualStyleBackColor = true;
        B_TitleScreen.Click += B_TitleScreen_Click;
        // 
        // B_OWSE
        // 
        B_OWSE.Location = new System.Drawing.Point(254, 135);
        B_OWSE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_OWSE.Name = "B_OWSE";
        B_OWSE.Size = new System.Drawing.Size(117, 27);
        B_OWSE.TabIndex = 13;
        B_OWSE.Text = "OWSE [Dev]";
        B_OWSE.UseVisualStyleBackColor = true;
        B_OWSE.Click += B_OWSE_Click;
        // 
        // Tab_ExeFS
        // 
        Tab_ExeFS.BackColor = System.Drawing.SystemColors.Control;
        Tab_ExeFS.Controls.Add(FLP_ExeFS);
        Tab_ExeFS.Location = new System.Drawing.Point(4, 24);
        Tab_ExeFS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        Tab_ExeFS.Name = "Tab_ExeFS";
        Tab_ExeFS.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        Tab_ExeFS.Size = new System.Drawing.Size(412, 180);
        Tab_ExeFS.TabIndex = 1;
        Tab_ExeFS.Text = "ExeFS";
        // 
        // FLP_ExeFS
        // 
        FLP_ExeFS.AutoScroll = true;
        FLP_ExeFS.Controls.Add(B_MoveTutor);
        FLP_ExeFS.Controls.Add(B_TMHM);
        FLP_ExeFS.Controls.Add(B_TM);
        FLP_ExeFS.Controls.Add(B_Mart);
        FLP_ExeFS.Controls.Add(B_Pickup);
        FLP_ExeFS.Controls.Add(B_OPower);
        FLP_ExeFS.Controls.Add(B_ShinyRate);
        FLP_ExeFS.Dock = System.Windows.Forms.DockStyle.Fill;
        FLP_ExeFS.Location = new System.Drawing.Point(4, 3);
        FLP_ExeFS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        FLP_ExeFS.Name = "FLP_ExeFS";
        FLP_ExeFS.Size = new System.Drawing.Size(404, 174);
        FLP_ExeFS.TabIndex = 11;
        // 
        // B_TM
        // 
        B_TM.Location = new System.Drawing.Point(254, 3);
        B_TM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_TM.Name = "B_TM";
        B_TM.Size = new System.Drawing.Size(117, 27);
        B_TM.TabIndex = 6;
        B_TM.Text = "TMs";
        B_TM.UseVisualStyleBackColor = true;
        B_TM.Click += B_TMHM_Click;
        // 
        // B_ShinyRate
        // 
        B_ShinyRate.Location = new System.Drawing.Point(4, 69);
        B_ShinyRate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_ShinyRate.Name = "B_ShinyRate";
        B_ShinyRate.Size = new System.Drawing.Size(117, 27);
        B_ShinyRate.TabIndex = 5;
        B_ShinyRate.Text = "Shiny Rate";
        B_ShinyRate.UseVisualStyleBackColor = true;
        B_ShinyRate.Click += B_ShinyRate_Click;
        // 
        // Tab_CRO
        // 
        Tab_CRO.BackColor = System.Drawing.Color.Transparent;
        Tab_CRO.Controls.Add(FLP_CRO);
        Tab_CRO.Location = new System.Drawing.Point(4, 24);
        Tab_CRO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        Tab_CRO.Name = "Tab_CRO";
        Tab_CRO.Size = new System.Drawing.Size(412, 180);
        Tab_CRO.TabIndex = 2;
        Tab_CRO.Text = "CRO";
        // 
        // FLP_CRO
        // 
        FLP_CRO.Controls.Add(B_TypeChart);
        FLP_CRO.Controls.Add(B_Starter);
        FLP_CRO.Controls.Add(B_Gift);
        FLP_CRO.Controls.Add(B_Static);
        FLP_CRO.Dock = System.Windows.Forms.DockStyle.Fill;
        FLP_CRO.Location = new System.Drawing.Point(0, 0);
        FLP_CRO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        FLP_CRO.Name = "FLP_CRO";
        FLP_CRO.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        FLP_CRO.Size = new System.Drawing.Size(412, 180);
        FLP_CRO.TabIndex = 1;
        // 
        // B_TypeChart
        // 
        B_TypeChart.Location = new System.Drawing.Point(8, 6);
        B_TypeChart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_TypeChart.Name = "B_TypeChart";
        B_TypeChart.Size = new System.Drawing.Size(117, 27);
        B_TypeChart.TabIndex = 0;
        B_TypeChart.Text = "Type Chart";
        B_TypeChart.UseVisualStyleBackColor = true;
        B_TypeChart.Click += B_TypeChart_Click;
        // 
        // B_Starter
        // 
        B_Starter.Location = new System.Drawing.Point(133, 6);
        B_Starter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Starter.Name = "B_Starter";
        B_Starter.Size = new System.Drawing.Size(117, 27);
        B_Starter.TabIndex = 1;
        B_Starter.Text = "Starter Pokémon";
        B_Starter.UseVisualStyleBackColor = true;
        B_Starter.Click += B_Starter_Click;
        // 
        // B_Gift
        // 
        B_Gift.Location = new System.Drawing.Point(258, 6);
        B_Gift.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Gift.Name = "B_Gift";
        B_Gift.Size = new System.Drawing.Size(117, 27);
        B_Gift.TabIndex = 2;
        B_Gift.Text = "Gift Pokémon";
        B_Gift.UseVisualStyleBackColor = true;
        B_Gift.Click += B_Gift_Click;
        // 
        // B_Static
        // 
        B_Static.Location = new System.Drawing.Point(8, 39);
        B_Static.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Static.Name = "B_Static";
        B_Static.Size = new System.Drawing.Size(117, 27);
        B_Static.TabIndex = 3;
        B_Static.Text = "Static Encounters";
        B_Static.UseVisualStyleBackColor = true;
        B_Static.Click += B_Static_Click;
        // 
        // Tab_Output
        // 
        Tab_Output.BackColor = System.Drawing.Color.Transparent;
        Tab_Output.Controls.Add(RTB_Status);
        Tab_Output.Location = new System.Drawing.Point(4, 24);
        Tab_Output.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        Tab_Output.Name = "Tab_Output";
        Tab_Output.Size = new System.Drawing.Size(412, 180);
        Tab_Output.TabIndex = 3;
        Tab_Output.Text = "Output";
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(100, 255);
        button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(117, 27);
        button1.TabIndex = 15;
        button1.Text = "Music";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // L_Status
        // 
        L_Status.BackColor = System.Drawing.SystemColors.Control;
        L_Status.Location = new System.Drawing.Point(238, 43);
        L_Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Status.Name = "L_Status";
        L_Status.Size = new System.Drawing.Size(190, 23);
        L_Status.TabIndex = 14;
        L_Status.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // btnExtrair
        // 
        btnExtrair.Location = new System.Drawing.Point(225, 255);
        btnExtrair.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        btnExtrair.Name = "btnExtrair";
        btnExtrair.Size = new System.Drawing.Size(117, 27);
        btnExtrair.TabIndex = 16;
        btnExtrair.Text = "3D Models";
        btnExtrair.UseVisualStyleBackColor = true;
        btnExtrair.Click += btnExtrair_Click;
        // 
        // Main
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        ClientSize = new System.Drawing.Size(448, 321);
        Controls.Add(btnExtrair);
        Controls.Add(L_Status);
        Controls.Add(TC_RomFS);
        Controls.Add(pBar1);
        Controls.Add(L_Game);
        Controls.Add(button1);
        Controls.Add(TB_Path);
        Controls.Add(menuStrip1);
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MinimumSize = new System.Drawing.Size(464, 329);
        Name = "Main";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "PKMN-ED";
        FormClosing += CloseForm;
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        TC_RomFS.ResumeLayout(false);
        Tab_RomFS.ResumeLayout(false);
        FLP_RomFS.ResumeLayout(false);
        Tab_ExeFS.ResumeLayout(false);
        FLP_ExeFS.ResumeLayout(false);
        Tab_CRO.ResumeLayout(false);
        FLP_CRO.ResumeLayout(false);
        Tab_Output.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox TB_Path;
    private System.Windows.Forms.Label L_Game;
    private System.Windows.Forms.ProgressBar pBar1;
    private System.Windows.Forms.Button B_Pickup;
    private System.Windows.Forms.Button B_Mart;
    private System.Windows.Forms.Button B_MoveTutor;
    private System.Windows.Forms.Button B_TMHM;
    public System.Windows.Forms.RichTextBox RTB_Status;
    private System.Windows.Forms.Button B_OPower;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem Menu_File;
    private System.Windows.Forms.ToolStripMenuItem Menu_Open;
    private System.Windows.Forms.ToolStripMenuItem Menu_Exit;
    private System.Windows.Forms.ToolStripMenuItem Menu_Tools;
    private System.Windows.Forms.ToolStripMenuItem Menu_Restore;
    private System.Windows.Forms.ToolStripMenuItem Menu_Misc;
    private System.Windows.Forms.ToolStripMenuItem unPackBCLIMToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem Menu_BLZ;
    private System.Windows.Forms.ToolStripMenuItem Menu_LZ11;
    private System.Windows.Forms.ToolStripMenuItem Menu_Rebuild;
    private System.Windows.Forms.ToolStripMenuItem Menu_RomFS;
    private System.Windows.Forms.ToolStripMenuItem Menu_ExeFS;
    private System.Windows.Forms.ToolStripMenuItem Menu_3DS;
    private System.Windows.Forms.ToolStripMenuItem Menu_Patch;
    private System.Windows.Forms.ToolStripMenuItem Menu_Options;
    private System.Windows.Forms.ToolStripMenuItem Menu_Language;
    private System.Windows.Forms.ToolStripComboBox CB_Lang;
    private System.Windows.Forms.ToolStripMenuItem Menu_About;
    private System.Windows.Forms.ToolStripMenuItem Menu_GARCs;
    private System.Windows.Forms.ToolStripMenuItem Menu_SMDH;
    private System.Windows.Forms.ToolStripMenuItem Menu_CRO;
    private System.Windows.Forms.ToolStripMenuItem Menu_Shuffler;
    private System.Windows.Forms.TabControl TC_RomFS;
    private System.Windows.Forms.TabPage Tab_RomFS;
    private System.Windows.Forms.TabPage Tab_ExeFS;
    private System.Windows.Forms.TabPage Tab_CRO;
    private System.Windows.Forms.FlowLayoutPanel FLP_ExeFS;
    private System.Windows.Forms.TabPage Tab_Output;
    private System.Windows.Forms.Button B_Static;
    private System.Windows.Forms.Button B_Gift;
    private System.Windows.Forms.Button B_Starter;
    private System.Windows.Forms.Button B_TypeChart;
    private System.Windows.Forms.FlowLayoutPanel FLP_CRO;
    private System.Windows.Forms.Button B_TitleScreen;
    private System.Windows.Forms.Button B_Move;
    private System.Windows.Forms.Button B_Item;
    private System.Windows.Forms.Button B_Maison;
    private System.Windows.Forms.Button B_Trainer;
    private System.Windows.Forms.Button B_EggMove;
    private System.Windows.Forms.Button B_MegaEvo;
    private System.Windows.Forms.Button B_Wild;
    private System.Windows.Forms.Button B_StoryText;
    private System.Windows.Forms.Button B_LevelUp;
    private System.Windows.Forms.Button B_Evolution;
    private System.Windows.Forms.Button B_Personal;
    private System.Windows.Forms.Button B_GameText;
    private System.Windows.Forms.FlowLayoutPanel FLP_RomFS;
    private System.Windows.Forms.Label L_Status;
    private System.Windows.Forms.Button B_OWSE;
    private System.Windows.Forms.Button B_ShinyRate;
    private System.Windows.Forms.Button B_Royal;
    private System.Windows.Forms.Button B_TM;
    private System.Windows.Forms.ToolStripMenuItem randomizationToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem setInt32SeedToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem Menu_Extract;
    private System.Windows.Forms.ToolStripMenuItem Menu_Extract_CXI;
    private System.Windows.Forms.ToolStripMenuItem Menu_Trimmed3DS;
    private System.Windows.Forms.ToolStripMenuItem Menu_Extract_3DS;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button btnExtrair;
}