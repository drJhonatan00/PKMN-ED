namespace PKMNED.WinForms;

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

        var bg = System.Drawing.Color.FromArgb(15, 23, 42);
        var surface = System.Drawing.Color.FromArgb(30, 41, 59);
        var surface2 = System.Drawing.Color.FromArgb(36, 50, 73);
        var accent = System.Drawing.Color.FromArgb(56, 189, 248);
        var text = System.Drawing.Color.FromArgb(226, 232, 240);
        var muted = System.Drawing.Color.FromArgb(148, 163, 184);
        var font = new System.Drawing.Font("Segoe UI", 10F);
        var title = new System.Drawing.Font("Segoe UI Semibold", 11F);

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
        Tab_ExeFS = new System.Windows.Forms.TabPage();
        Tab_CRO = new System.Windows.Forms.TabPage();
        Tab_Output = new System.Windows.Forms.TabPage();
        B_MegaEvo = new System.Windows.Forms.Button();
        B_EggMove = new System.Windows.Forms.Button();
        B_GameText = new System.Windows.Forms.Button();
        B_StoryText = new System.Windows.Forms.Button();
        B_Personal = new System.Windows.Forms.Button();
        button1 = new System.Windows.Forms.Button();
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
        btnExtrair = new System.Windows.Forms.Button();
        B_TM = new System.Windows.Forms.Button();
        B_ShinyRate = new System.Windows.Forms.Button();
        B_TypeChart = new System.Windows.Forms.Button();
        B_Starter = new System.Windows.Forms.Button();
        B_Gift = new System.Windows.Forms.Button();
        B_Static = new System.Windows.Forms.Button();
        L_Status = new System.Windows.Forms.Label();
        panel1 = new System.Windows.Forms.Panel();
        panel2 = new System.Windows.Forms.Panel();
        panel3 = new System.Windows.Forms.Panel();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        panel4 = new System.Windows.Forms.Panel();
        menuStrip1.SuspendLayout();
        TC_RomFS.SuspendLayout();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        panel3.SuspendLayout();
        panel4.SuspendLayout();
        SuspendLayout();
        // 
        // TB_Path
        // 
        TB_Path.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        TB_Path.BackColor = System.Drawing.Color.FromArgb(215, 223, 242);
        TB_Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        TB_Path.Font = new System.Drawing.Font("Segoe UI", 10F);
        TB_Path.Location = new System.Drawing.Point(187, 3);
        TB_Path.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        TB_Path.Name = "TB_Path";
        TB_Path.ReadOnly = true;
        TB_Path.Size = new System.Drawing.Size(311, 25);
        TB_Path.TabIndex = 1;
        // 
        // L_Game
        // 
        L_Game.AutoSize = true;
        L_Game.BackColor = System.Drawing.Color.Transparent;
        L_Game.Font = new System.Drawing.Font("Segoe UI", 10F);
        L_Game.ForeColor = System.Drawing.Color.DarkRed;
        L_Game.Location = new System.Drawing.Point(382, 31);
        L_Game.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Game.Name = "L_Game";
        L_Game.Size = new System.Drawing.Size(116, 19);
        L_Game.TabIndex = 2;
        L_Game.Text = "No Game Loaded";
        // 
        // pBar1
        // 
        pBar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        pBar1.BackColor = System.Drawing.Color.FromArgb(56, 189, 248);
        pBar1.Location = new System.Drawing.Point(14, 395);
        pBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        pBar1.Name = "pBar1";
        pBar1.Size = new System.Drawing.Size(484, 16);
        pBar1.TabIndex = 6;
        // 
        // B_OPower
        // 
        B_OPower.BackColor = System.Drawing.Color.Transparent;
        B_OPower.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_OPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_OPower.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_OPower.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_OPower.Location = new System.Drawing.Point(25, 38);
        B_OPower.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_OPower.Name = "B_OPower";
        B_OPower.Size = new System.Drawing.Size(117, 31);
        B_OPower.TabIndex = 0;
        B_OPower.Text = "O-Powers";
        B_OPower.UseVisualStyleBackColor = false;
        B_OPower.Click += B_OPower_Click;
        // 
        // B_Pickup
        // 
        B_Pickup.BackColor = System.Drawing.Color.Transparent;
        B_Pickup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_Pickup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Pickup.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Pickup.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_Pickup.Location = new System.Drawing.Point(148, 155);
        B_Pickup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Pickup.Name = "B_Pickup";
        B_Pickup.Size = new System.Drawing.Size(117, 31);
        B_Pickup.TabIndex = 0;
        B_Pickup.Text = "Pickup Items";
        B_Pickup.UseVisualStyleBackColor = false;
        B_Pickup.Click += B_Pickup_Click;
        // 
        // B_Mart
        // 
        B_Mart.BackColor = System.Drawing.Color.Transparent;
        B_Mart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_Mart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Mart.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Mart.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_Mart.Location = new System.Drawing.Point(148, 383);
        B_Mart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Mart.Name = "B_Mart";
        B_Mart.Size = new System.Drawing.Size(117, 31);
        B_Mart.TabIndex = 0;
        B_Mart.Text = "Poké Mart";
        B_Mart.UseVisualStyleBackColor = false;
        B_Mart.Click += B_Mart_Click;
        // 
        // B_MoveTutor
        // 
        B_MoveTutor.BackColor = System.Drawing.Color.Transparent;
        B_MoveTutor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_MoveTutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_MoveTutor.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_MoveTutor.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_MoveTutor.Location = new System.Drawing.Point(148, 307);
        B_MoveTutor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_MoveTutor.Name = "B_MoveTutor";
        B_MoveTutor.Size = new System.Drawing.Size(117, 31);
        B_MoveTutor.TabIndex = 0;
        B_MoveTutor.Text = "Move Tutors";
        B_MoveTutor.UseVisualStyleBackColor = false;
        B_MoveTutor.Click += B_MoveTutor_Click;
        // 
        // B_TMHM
        // 
        B_TMHM.BackColor = System.Drawing.Color.Transparent;
        B_TMHM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_TMHM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_TMHM.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_TMHM.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_TMHM.Location = new System.Drawing.Point(13, 307);
        B_TMHM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_TMHM.Name = "B_TMHM";
        B_TMHM.Size = new System.Drawing.Size(117, 31);
        B_TMHM.TabIndex = 0;
        B_TMHM.Text = "TMs/HMs";
        B_TMHM.UseVisualStyleBackColor = false;
        B_TMHM.Click += B_TMHM_Click;
        // 
        // RTB_Status
        // 
        RTB_Status.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        RTB_Status.BorderStyle = System.Windows.Forms.BorderStyle.None;
        RTB_Status.Dock = System.Windows.Forms.DockStyle.Fill;
        RTB_Status.Font = new System.Drawing.Font("Segoe UI", 10F);
        RTB_Status.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
        RTB_Status.Location = new System.Drawing.Point(0, 0);
        RTB_Status.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        RTB_Status.Name = "RTB_Status";
        RTB_Status.ReadOnly = true;
        RTB_Status.Size = new System.Drawing.Size(482, 99);
        RTB_Status.TabIndex = 7;
        RTB_Status.Text = "";
        // 
        // menuStrip1
        // 
        menuStrip1.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
        menuStrip1.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { Menu_File, Menu_Tools, Menu_Options });
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
        menuStrip1.Size = new System.Drawing.Size(801, 27);
        menuStrip1.TabIndex = 9;
        menuStrip1.Text = "menuStrip1";
        // 
        // Menu_File
        // 
        Menu_File.BackColor = System.Drawing.Color.FromArgb(36, 50, 73);
        Menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { Menu_Open, Menu_Exit });
        Menu_File.Name = "Menu_File";
        Menu_File.Size = new System.Drawing.Size(41, 23);
        Menu_File.Text = "File";
        // 
        // Menu_Open
        // 
        Menu_Open.BackColor = System.Drawing.Color.FromArgb(36, 50, 73);
        Menu_Open.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Menu_Open.Name = "Menu_Open";
        Menu_Open.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O;
        Menu_Open.Size = new System.Drawing.Size(173, 24);
        Menu_Open.Text = "&Open...";
        Menu_Open.Click += B_Open_Click;
        // 
        // Menu_Exit
        // 
        Menu_Exit.BackColor = System.Drawing.Color.FromArgb(36, 50, 73);
        Menu_Exit.Font = new System.Drawing.Font("Segoe UI", 10F);
        Menu_Exit.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Menu_Exit.Name = "Menu_Exit";
        Menu_Exit.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q;
        Menu_Exit.Size = new System.Drawing.Size(173, 24);
        Menu_Exit.Text = "&Exit";
        Menu_Exit.Click += Menu_Exit_Click;
        // 
        // Menu_Tools
        // 
        Menu_Tools.BackColor = System.Drawing.Color.FromArgb(36, 50, 73);
        Menu_Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { Menu_Restore, Menu_Misc, Menu_Extract, Menu_Rebuild, Menu_SMDH, randomizationToolStripMenuItem });
        Menu_Tools.Font = new System.Drawing.Font("Segoe UI", 10F);
        Menu_Tools.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Menu_Tools.Name = "Menu_Tools";
        Menu_Tools.Size = new System.Drawing.Size(52, 23);
        Menu_Tools.Text = "Tools";
        // 
        // Menu_Restore
        // 
        Menu_Restore.BackColor = System.Drawing.Color.FromArgb(36, 50, 73);
        Menu_Restore.Enabled = false;
        Menu_Restore.Font = new System.Drawing.Font("Segoe UI", 10F);
        Menu_Restore.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Menu_Restore.Name = "Menu_Restore";
        Menu_Restore.Size = new System.Drawing.Size(206, 24);
        Menu_Restore.Text = "Restore Original Files";
        Menu_Restore.Click += L_Game_Click;
        // 
        // Menu_Misc
        // 
        Menu_Misc.BackColor = System.Drawing.Color.FromArgb(36, 50, 73);
        Menu_Misc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { unPackBCLIMToolStripMenuItem, Menu_BLZ, Menu_LZ11, Menu_Shuffler });
        Menu_Misc.Font = new System.Drawing.Font("Segoe UI", 10F);
        Menu_Misc.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Menu_Misc.Name = "Menu_Misc";
        Menu_Misc.Size = new System.Drawing.Size(206, 24);
        Menu_Misc.Text = "Misc Tools";
        // 
        // unPackBCLIMToolStripMenuItem
        // 
        unPackBCLIMToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(36, 50, 73);
        unPackBCLIMToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
        unPackBCLIMToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        unPackBCLIMToolStripMenuItem.Name = "unPackBCLIMToolStripMenuItem";
        unPackBCLIMToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T;
        unPackBCLIMToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
        unPackBCLIMToolStripMenuItem.Text = "(un)Pack + BCLIM";
        unPackBCLIMToolStripMenuItem.Click += L_SubTools_Click;
        // 
        // Menu_BLZ
        // 
        Menu_BLZ.BackColor = System.Drawing.Color.FromArgb(36, 50, 73);
        Menu_BLZ.Font = new System.Drawing.Font("Segoe UI", 10F);
        Menu_BLZ.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Menu_BLZ.Name = "Menu_BLZ";
        Menu_BLZ.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B;
        Menu_BLZ.Size = new System.Drawing.Size(245, 24);
        Menu_BLZ.Text = "(de)Compress BLZ";
        Menu_BLZ.Click += Menu_BLZ_Click;
        // 
        // Menu_LZ11
        // 
        Menu_LZ11.BackColor = System.Drawing.Color.FromArgb(36, 50, 73);
        Menu_LZ11.Font = new System.Drawing.Font("Segoe UI", 10F);
        Menu_LZ11.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Menu_LZ11.Name = "Menu_LZ11";
        Menu_LZ11.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L;
        Menu_LZ11.Size = new System.Drawing.Size(245, 24);
        Menu_LZ11.Text = "(de)Compress LZ11";
        Menu_LZ11.Click += Menu_LZ11_Click;
        // 
        // Menu_Shuffler
        // 
        Menu_Shuffler.BackColor = System.Drawing.Color.FromArgb(36, 50, 73);
        Menu_Shuffler.Enabled = false;
        Menu_Shuffler.Font = new System.Drawing.Font("Segoe UI", 10F);
        Menu_Shuffler.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Menu_Shuffler.Name = "Menu_Shuffler";
        Menu_Shuffler.Size = new System.Drawing.Size(245, 24);
        Menu_Shuffler.Text = "GARC Shuffler";
        Menu_Shuffler.Click += Menu_Shuffler_Click;
        // 
        // Menu_Extract
        // 
        Menu_Extract.BackColor = System.Drawing.Color.FromArgb(36, 50, 73);
        Menu_Extract.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { Menu_Extract_CXI, Menu_Extract_3DS });
        Menu_Extract.Font = new System.Drawing.Font("Segoe UI", 10F);
        Menu_Extract.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Menu_Extract.Name = "Menu_Extract";
        Menu_Extract.Size = new System.Drawing.Size(206, 24);
        Menu_Extract.Text = "Extract...";
        // 
        // Menu_Extract_CXI
        // 
        Menu_Extract_CXI.BackColor = System.Drawing.Color.FromArgb(36, 50, 73);
        Menu_Extract_CXI.Font = new System.Drawing.Font("Segoe UI", 10F);
        Menu_Extract_CXI.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Menu_Extract_CXI.Name = "Menu_Extract_CXI";
        Menu_Extract_CXI.Size = new System.Drawing.Size(106, 24);
        Menu_Extract_CXI.Text = ".CXI";
        Menu_Extract_CXI.Click += B_ExtractCXI_Click;
        // 
        // Menu_Extract_3DS
        // 
        Menu_Extract_3DS.BackColor = System.Drawing.Color.FromArgb(36, 50, 73);
        Menu_Extract_3DS.Font = new System.Drawing.Font("Segoe UI", 10F);
        Menu_Extract_3DS.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Menu_Extract_3DS.Name = "Menu_Extract_3DS";
        Menu_Extract_3DS.Size = new System.Drawing.Size(106, 24);
        Menu_Extract_3DS.Text = ".3DS";
        Menu_Extract_3DS.Click += B_Extract3DS_Click;
        // 
        // Menu_Rebuild
        // 
        Menu_Rebuild.BackColor = System.Drawing.Color.FromArgb(36, 50, 73);
        Menu_Rebuild.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { Menu_RomFS, Menu_ExeFS, Menu_CRO, Menu_Trimmed3DS, Menu_3DS, Menu_Patch });
        Menu_Rebuild.Font = new System.Drawing.Font("Segoe UI", 10F);
        Menu_Rebuild.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Menu_Rebuild.Name = "Menu_Rebuild";
        Menu_Rebuild.Size = new System.Drawing.Size(206, 24);
        Menu_Rebuild.Text = "Rebuild...";
        // 
        // Menu_RomFS
        // 
        Menu_RomFS.BackColor = System.Drawing.Color.FromArgb(36, 50, 73);
        Menu_RomFS.Enabled = false;
        Menu_RomFS.Font = new System.Drawing.Font("Segoe UI", 10F);
        Menu_RomFS.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Menu_RomFS.Name = "Menu_RomFS";
        Menu_RomFS.Size = new System.Drawing.Size(163, 24);
        Menu_RomFS.Text = "RomFS";
        Menu_RomFS.Click += RebuildRomFS;
        // 
        // Menu_ExeFS
        // 
        Menu_ExeFS.BackColor = System.Drawing.Color.FromArgb(36, 50, 73);
        Menu_ExeFS.Enabled = false;
        Menu_ExeFS.Font = new System.Drawing.Font("Segoe UI", 10F);
        Menu_ExeFS.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Menu_ExeFS.Name = "Menu_ExeFS";
        Menu_ExeFS.Size = new System.Drawing.Size(163, 24);
        Menu_ExeFS.Text = "ExeFS";
        Menu_ExeFS.Click += RebuildExeFS;
        // 
        // Menu_CRO
        // 
        Menu_CRO.BackColor = System.Drawing.Color.FromArgb(36, 50, 73);
        Menu_CRO.Enabled = false;
        Menu_CRO.Font = new System.Drawing.Font("Segoe UI", 10F);
        Menu_CRO.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Menu_CRO.Name = "Menu_CRO";
        Menu_CRO.Size = new System.Drawing.Size(163, 24);
        Menu_CRO.Text = "CRO";
        Menu_CRO.Click += PatchCRO_CRR;
        // 
        // Menu_Trimmed3DS
        // 
        Menu_Trimmed3DS.BackColor = System.Drawing.Color.FromArgb(36, 50, 73);
        Menu_Trimmed3DS.Enabled = false;
        Menu_Trimmed3DS.Font = new System.Drawing.Font("Segoe UI", 10F);
        Menu_Trimmed3DS.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Menu_Trimmed3DS.Name = "Menu_Trimmed3DS";
        Menu_Trimmed3DS.Size = new System.Drawing.Size(163, 24);
        Menu_Trimmed3DS.Text = "Trimmed .3DS";
        Menu_Trimmed3DS.Click += B_RebuildTrimmed3DS_Click;
        // 
        // Menu_3DS
        // 
        Menu_3DS.BackColor = System.Drawing.Color.FromArgb(36, 50, 73);
        Menu_3DS.Enabled = false;
        Menu_3DS.Font = new System.Drawing.Font("Segoe UI", 10F);
        Menu_3DS.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Menu_3DS.Name = "Menu_3DS";
        Menu_3DS.Size = new System.Drawing.Size(163, 24);
        Menu_3DS.Text = ".3DS";
        Menu_3DS.Click += B_Rebuild3DS_Click;
        // 
        // Menu_Patch
        // 
        Menu_Patch.BackColor = System.Drawing.Color.FromArgb(36, 50, 73);
        Menu_Patch.Enabled = false;
        Menu_Patch.Font = new System.Drawing.Font("Segoe UI", 10F);
        Menu_Patch.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Menu_Patch.Name = "Menu_Patch";
        Menu_Patch.Size = new System.Drawing.Size(163, 24);
        Menu_Patch.Text = "Patch";
        Menu_Patch.Click += B_Patch_Click;
        // 
        // Menu_SMDH
        // 
        Menu_SMDH.BackColor = System.Drawing.Color.FromArgb(36, 50, 73);
        Menu_SMDH.Font = new System.Drawing.Font("Segoe UI", 10F);
        Menu_SMDH.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Menu_SMDH.Name = "Menu_SMDH";
        Menu_SMDH.Size = new System.Drawing.Size(206, 24);
        Menu_SMDH.Text = "SMDH Editor (Icon)";
        Menu_SMDH.Click += Menu_SMDH_Click;
        // 
        // randomizationToolStripMenuItem
        // 
        randomizationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(36, 50, 73);
        randomizationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { setInt32SeedToolStripMenuItem });
        randomizationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
        randomizationToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        randomizationToolStripMenuItem.Name = "randomizationToolStripMenuItem";
        randomizationToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
        randomizationToolStripMenuItem.Text = "Randomization";
        // 
        // setInt32SeedToolStripMenuItem
        // 
        setInt32SeedToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(36, 50, 73);
        setInt32SeedToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
        setInt32SeedToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        setInt32SeedToolStripMenuItem.Name = "setInt32SeedToolStripMenuItem";
        setInt32SeedToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
        setInt32SeedToolStripMenuItem.Text = "Set int32 seed";
        setInt32SeedToolStripMenuItem.Click += SetInt32SeedToolStripMenuItem_Click;
        // 
        // Menu_Options
        // 
        Menu_Options.BackColor = System.Drawing.Color.FromArgb(36, 50, 73);
        Menu_Options.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { Menu_Language, Menu_About, Menu_GARCs });
        Menu_Options.Font = new System.Drawing.Font("Segoe UI", 10F);
        Menu_Options.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Menu_Options.Name = "Menu_Options";
        Menu_Options.Size = new System.Drawing.Size(70, 23);
        Menu_Options.Text = "Options";
        // 
        // Menu_Language
        // 
        Menu_Language.BackColor = System.Drawing.Color.FromArgb(36, 50, 73);
        Menu_Language.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { CB_Lang });
        Menu_Language.Font = new System.Drawing.Font("Segoe UI", 10F);
        Menu_Language.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Menu_Language.Name = "Menu_Language";
        Menu_Language.Size = new System.Drawing.Size(181, 24);
        Menu_Language.Text = "Language";
        // 
        // CB_Lang
        // 
        CB_Lang.BackColor = System.Drawing.Color.FromArgb(36, 50, 73);
        CB_Lang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        CB_Lang.Font = new System.Drawing.Font("Segoe UI", 10F);
        CB_Lang.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        CB_Lang.Items.AddRange(new object[] { "カタカナ", "漢字", "English", "Français", "Italiano", "Deutsch", "Español", "한국", "汉字简化方案", "漢字簡化方案" });
        CB_Lang.Name = "CB_Lang";
        CB_Lang.Size = new System.Drawing.Size(121, 27);
        CB_Lang.SelectedIndexChanged += ChangeLanguage;
        // 
        // Menu_About
        // 
        Menu_About.BackColor = System.Drawing.Color.FromArgb(36, 50, 73);
        Menu_About.Font = new System.Drawing.Font("Segoe UI", 10F);
        Menu_About.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Menu_About.Name = "Menu_About";
        Menu_About.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B;
        Menu_About.ShowShortcutKeys = false;
        Menu_About.Size = new System.Drawing.Size(181, 24);
        Menu_About.Text = "A&bout PKMN - ED";
        Menu_About.Click += L_About_Click;
        // 
        // Menu_GARCs
        // 
        Menu_GARCs.BackColor = System.Drawing.Color.FromArgb(36, 50, 73);
        Menu_GARCs.Font = new System.Drawing.Font("Segoe UI", 10F);
        Menu_GARCs.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Menu_GARCs.Name = "Menu_GARCs";
        Menu_GARCs.Size = new System.Drawing.Size(181, 24);
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
        TC_RomFS.Location = new System.Drawing.Point(1252, 199);
        TC_RomFS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        TC_RomFS.Name = "TC_RomFS";
        TC_RomFS.SelectedIndex = 0;
        TC_RomFS.Size = new System.Drawing.Size(0, 155);
        TC_RomFS.TabIndex = 11;
        TC_RomFS.Visible = false;
        // 
        // Tab_RomFS
        // 
        Tab_RomFS.BackColor = System.Drawing.Color.Transparent;
        Tab_RomFS.Location = new System.Drawing.Point(4, 24);
        Tab_RomFS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        Tab_RomFS.Name = "Tab_RomFS";
        Tab_RomFS.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        Tab_RomFS.Size = new System.Drawing.Size(0, 127);
        Tab_RomFS.TabIndex = 0;
        Tab_RomFS.Text = "RomFS";
        // 
        // Tab_ExeFS
        // 
        Tab_ExeFS.BackColor = System.Drawing.SystemColors.Control;
        Tab_ExeFS.Location = new System.Drawing.Point(4, 24);
        Tab_ExeFS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        Tab_ExeFS.Name = "Tab_ExeFS";
        Tab_ExeFS.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        Tab_ExeFS.Size = new System.Drawing.Size(0, 127);
        Tab_ExeFS.TabIndex = 1;
        Tab_ExeFS.Text = "ExeFS";
        // 
        // Tab_CRO
        // 
        Tab_CRO.BackColor = System.Drawing.Color.Transparent;
        Tab_CRO.Location = new System.Drawing.Point(4, 24);
        Tab_CRO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        Tab_CRO.Name = "Tab_CRO";
        Tab_CRO.Size = new System.Drawing.Size(0, 127);
        Tab_CRO.TabIndex = 2;
        Tab_CRO.Text = "CRO";
        // 
        // Tab_Output
        // 
        Tab_Output.BackColor = System.Drawing.Color.Transparent;
        Tab_Output.Location = new System.Drawing.Point(4, 24);
        Tab_Output.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        Tab_Output.Name = "Tab_Output";
        Tab_Output.Size = new System.Drawing.Size(0, 127);
        Tab_Output.TabIndex = 3;
        Tab_Output.Text = "Output";
        // 
        // B_MegaEvo
        // 
        B_MegaEvo.BackColor = System.Drawing.Color.Transparent;
        B_MegaEvo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_MegaEvo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_MegaEvo.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_MegaEvo.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_MegaEvo.Location = new System.Drawing.Point(148, 267);
        B_MegaEvo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_MegaEvo.Name = "B_MegaEvo";
        B_MegaEvo.Size = new System.Drawing.Size(117, 31);
        B_MegaEvo.TabIndex = 0;
        B_MegaEvo.Text = "Mega Evolutions";
        B_MegaEvo.UseVisualStyleBackColor = false;
        B_MegaEvo.Click += B_MegaEvo_Click;
        // 
        // B_EggMove
        // 
        B_EggMove.BackColor = System.Drawing.Color.Transparent;
        B_EggMove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_EggMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_EggMove.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_EggMove.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_EggMove.Location = new System.Drawing.Point(148, 116);
        B_EggMove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_EggMove.Name = "B_EggMove";
        B_EggMove.Size = new System.Drawing.Size(117, 31);
        B_EggMove.TabIndex = 0;
        B_EggMove.Text = "Egg Moves";
        B_EggMove.UseVisualStyleBackColor = false;
        B_EggMove.Click += B_EggMove_Click;
        // 
        // B_GameText
        // 
        B_GameText.BackColor = System.Drawing.Color.Transparent;
        B_GameText.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_GameText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_GameText.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_GameText.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_GameText.Location = new System.Drawing.Point(13, 45);
        B_GameText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_GameText.Name = "B_GameText";
        B_GameText.Size = new System.Drawing.Size(117, 31);
        B_GameText.TabIndex = 0;
        B_GameText.Text = "Game Text";
        B_GameText.UseVisualStyleBackColor = false;
        B_GameText.Click += B_GameText_Click;
        // 
        // B_StoryText
        // 
        B_StoryText.BackColor = System.Drawing.Color.Transparent;
        B_StoryText.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_StoryText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_StoryText.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_StoryText.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_StoryText.Location = new System.Drawing.Point(13, 82);
        B_StoryText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_StoryText.Name = "B_StoryText";
        B_StoryText.Size = new System.Drawing.Size(117, 31);
        B_StoryText.TabIndex = 0;
        B_StoryText.Text = "Story Text";
        B_StoryText.UseVisualStyleBackColor = false;
        B_StoryText.Click += B_StoryText_Click;
        // 
        // B_Personal
        // 
        B_Personal.BackColor = System.Drawing.Color.Transparent;
        B_Personal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_Personal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Personal.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Personal.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_Personal.Location = new System.Drawing.Point(148, 10);
        B_Personal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Personal.Name = "B_Personal";
        B_Personal.Size = new System.Drawing.Size(117, 31);
        B_Personal.TabIndex = 0;
        B_Personal.Text = "Personal Stats";
        B_Personal.UseVisualStyleBackColor = false;
        B_Personal.Click += B_Personal_Click;
        // 
        // button1
        // 
        button1.BackColor = System.Drawing.Color.Transparent;
        button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        button1.Font = new System.Drawing.Font("Segoe UI", 10F);
        button1.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        button1.Location = new System.Drawing.Point(148, 79);
        button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(117, 31);
        button1.TabIndex = 0;
        button1.Text = "Music";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // B_Evolution
        // 
        B_Evolution.BackColor = System.Drawing.Color.Transparent;
        B_Evolution.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_Evolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Evolution.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Evolution.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_Evolution.Location = new System.Drawing.Point(13, 119);
        B_Evolution.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Evolution.Name = "B_Evolution";
        B_Evolution.Size = new System.Drawing.Size(117, 31);
        B_Evolution.TabIndex = 6;
        B_Evolution.Text = "Evolutions";
        B_Evolution.UseVisualStyleBackColor = false;
        B_Evolution.Click += B_Evolution_Click;
        // 
        // B_LevelUp
        // 
        B_LevelUp.BackColor = System.Drawing.Color.Transparent;
        B_LevelUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_LevelUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_LevelUp.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_LevelUp.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_LevelUp.Location = new System.Drawing.Point(148, 345);
        B_LevelUp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_LevelUp.Name = "B_LevelUp";
        B_LevelUp.Size = new System.Drawing.Size(117, 31);
        B_LevelUp.TabIndex = 0;
        B_LevelUp.Text = "Level Up Moves";
        B_LevelUp.UseVisualStyleBackColor = false;
        B_LevelUp.Click += B_LevelUp_Click;
        // 
        // B_Wild
        // 
        B_Wild.BackColor = System.Drawing.Color.Transparent;
        B_Wild.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_Wild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Wild.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Wild.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_Wild.Location = new System.Drawing.Point(13, 383);
        B_Wild.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Wild.Name = "B_Wild";
        B_Wild.Size = new System.Drawing.Size(117, 31);
        B_Wild.TabIndex = 0;
        B_Wild.Text = "Wild Encounters";
        B_Wild.UseVisualStyleBackColor = false;
        B_Wild.Click += B_Wild_Click;
        // 
        // B_Trainer
        // 
        B_Trainer.BackColor = System.Drawing.Color.Transparent;
        B_Trainer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_Trainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Trainer.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Trainer.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_Trainer.Location = new System.Drawing.Point(13, 268);
        B_Trainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Trainer.Name = "B_Trainer";
        B_Trainer.Size = new System.Drawing.Size(117, 31);
        B_Trainer.TabIndex = 0;
        B_Trainer.Text = "Trainers";
        B_Trainer.UseVisualStyleBackColor = false;
        B_Trainer.Click += B_Trainer_Click;
        // 
        // B_Maison
        // 
        B_Maison.BackColor = System.Drawing.Color.Transparent;
        B_Maison.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_Maison.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Maison.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Maison.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_Maison.Location = new System.Drawing.Point(25, 74);
        B_Maison.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Maison.Name = "B_Maison";
        B_Maison.Size = new System.Drawing.Size(117, 31);
        B_Maison.TabIndex = 0;
        B_Maison.Text = "Battle Maison";
        B_Maison.UseVisualStyleBackColor = false;
        B_Maison.Click += B_Maison_Click;
        // 
        // B_Royal
        // 
        B_Royal.BackColor = System.Drawing.Color.Transparent;
        B_Royal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_Royal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Royal.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Royal.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_Royal.Location = new System.Drawing.Point(27, 109);
        B_Royal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Royal.Name = "B_Royal";
        B_Royal.Size = new System.Drawing.Size(117, 31);
        B_Royal.TabIndex = 0;
        B_Royal.Text = "Royal/Tree";
        B_Royal.UseVisualStyleBackColor = false;
        B_Royal.Click += B_Maison_Click;
        // 
        // B_Item
        // 
        B_Item.BackColor = System.Drawing.Color.Transparent;
        B_Item.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_Item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Item.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Item.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_Item.Location = new System.Drawing.Point(148, 45);
        B_Item.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Item.Name = "B_Item";
        B_Item.Size = new System.Drawing.Size(117, 31);
        B_Item.TabIndex = 0;
        B_Item.Text = "Item Stats";
        B_Item.UseVisualStyleBackColor = false;
        B_Item.Click += B_Item_Click;
        // 
        // B_Move
        // 
        B_Move.BackColor = System.Drawing.Color.Transparent;
        B_Move.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_Move.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Move.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Move.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_Move.Location = new System.Drawing.Point(148, 193);
        B_Move.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Move.Name = "B_Move";
        B_Move.Size = new System.Drawing.Size(117, 31);
        B_Move.TabIndex = 0;
        B_Move.Text = "Move Stats";
        B_Move.UseVisualStyleBackColor = false;
        B_Move.Click += B_Move_Click;
        // 
        // B_TitleScreen
        // 
        B_TitleScreen.BackColor = System.Drawing.Color.Transparent;
        B_TitleScreen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_TitleScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_TitleScreen.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_TitleScreen.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_TitleScreen.Location = new System.Drawing.Point(25, 144);
        B_TitleScreen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_TitleScreen.Name = "B_TitleScreen";
        B_TitleScreen.Size = new System.Drawing.Size(117, 31);
        B_TitleScreen.TabIndex = 0;
        B_TitleScreen.Text = "Title Screen";
        B_TitleScreen.UseVisualStyleBackColor = false;
        B_TitleScreen.Click += B_TitleScreen_Click;
        // 
        // B_OWSE
        // 
        B_OWSE.BackColor = System.Drawing.Color.Transparent;
        B_OWSE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_OWSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_OWSE.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_OWSE.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_OWSE.Location = new System.Drawing.Point(148, 229);
        B_OWSE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_OWSE.Name = "B_OWSE";
        B_OWSE.Size = new System.Drawing.Size(117, 31);
        B_OWSE.TabIndex = 0;
        B_OWSE.Text = "OWSE";
        B_OWSE.UseVisualStyleBackColor = false;
        B_OWSE.Click += B_OWSE_Click;
        // 
        // btnExtrair
        // 
        btnExtrair.BackColor = System.Drawing.Color.Transparent;
        btnExtrair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        btnExtrair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnExtrair.Font = new System.Drawing.Font("Segoe UI", 10F);
        btnExtrair.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        btnExtrair.Location = new System.Drawing.Point(13, 10);
        btnExtrair.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        btnExtrair.Name = "btnExtrair";
        btnExtrair.Size = new System.Drawing.Size(117, 31);
        btnExtrair.TabIndex = 0;
        btnExtrair.Text = "3D Models";
        btnExtrair.UseVisualStyleBackColor = false;
        btnExtrair.Click += btnExtrair_Click;
        // 
        // B_TM
        // 
        B_TM.BackColor = System.Drawing.Color.Transparent;
        B_TM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_TM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_TM.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_TM.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_TM.Location = new System.Drawing.Point(13, 346);
        B_TM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_TM.Name = "B_TM";
        B_TM.Size = new System.Drawing.Size(117, 31);
        B_TM.TabIndex = 0;
        B_TM.Text = "TMs";
        B_TM.UseVisualStyleBackColor = false;
        B_TM.Click += B_TMHM_Click;
        // 
        // B_ShinyRate
        // 
        B_ShinyRate.BackColor = System.Drawing.Color.Transparent;
        B_ShinyRate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_ShinyRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_ShinyRate.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_ShinyRate.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_ShinyRate.Location = new System.Drawing.Point(13, 230);
        B_ShinyRate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_ShinyRate.Name = "B_ShinyRate";
        B_ShinyRate.Size = new System.Drawing.Size(117, 31);
        B_ShinyRate.TabIndex = 0;
        B_ShinyRate.Text = "Shiny Rate";
        B_ShinyRate.UseVisualStyleBackColor = false;
        B_ShinyRate.Click += B_ShinyRate_Click;
        // 
        // B_TypeChart
        // 
        B_TypeChart.BackColor = System.Drawing.Color.Transparent;
        B_TypeChart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_TypeChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_TypeChart.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_TypeChart.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_TypeChart.Location = new System.Drawing.Point(13, 192);
        B_TypeChart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_TypeChart.Name = "B_TypeChart";
        B_TypeChart.Size = new System.Drawing.Size(117, 31);
        B_TypeChart.TabIndex = 0;
        B_TypeChart.Text = "Type Chart";
        B_TypeChart.UseVisualStyleBackColor = false;
        B_TypeChart.Click += B_TypeChart_Click;
        // 
        // B_Starter
        // 
        B_Starter.BackColor = System.Drawing.Color.Transparent;
        B_Starter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_Starter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Starter.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Starter.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_Starter.Location = new System.Drawing.Point(25, 109);
        B_Starter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Starter.Name = "B_Starter";
        B_Starter.Size = new System.Drawing.Size(117, 31);
        B_Starter.TabIndex = 0;
        B_Starter.Text = "Starter Pokémon";
        B_Starter.UseVisualStyleBackColor = false;
        B_Starter.Click += B_Starter_Click;
        // 
        // B_Gift
        // 
        B_Gift.BackColor = System.Drawing.Color.Transparent;
        B_Gift.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_Gift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Gift.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Gift.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_Gift.Location = new System.Drawing.Point(25, 179);
        B_Gift.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Gift.Name = "B_Gift";
        B_Gift.Size = new System.Drawing.Size(117, 31);
        B_Gift.TabIndex = 0;
        B_Gift.Text = "Gift Pokémon";
        B_Gift.UseVisualStyleBackColor = false;
        B_Gift.Click += B_Gift_Click;
        // 
        // B_Static
        // 
        B_Static.BackColor = System.Drawing.Color.Transparent;
        B_Static.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_Static.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Static.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Static.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        B_Static.Location = new System.Drawing.Point(13, 156);
        B_Static.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Static.Name = "B_Static";
        B_Static.Size = new System.Drawing.Size(117, 31);
        B_Static.TabIndex = 0;
        B_Static.Text = "Static Encounters";
        B_Static.UseVisualStyleBackColor = false;
        B_Static.Click += B_Static_Click;
        // 
        // L_Status
        // 
        L_Status.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        L_Status.Location = new System.Drawing.Point(152, 49);
        L_Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Status.Name = "L_Status";
        L_Status.Size = new System.Drawing.Size(190, 23);
        L_Status.TabIndex = 14;
        L_Status.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // panel1
        // 
        panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        panel1.Controls.Add(B_OPower);
        panel1.Controls.Add(label1);
        panel1.Controls.Add(B_Maison);
        panel1.Controls.Add(B_Starter);
        panel1.Controls.Add(B_TitleScreen);
        panel1.Controls.Add(B_Gift);
        panel1.Location = new System.Drawing.Point(14, 34);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(175, 232);
        panel1.TabIndex = 17;
        // 
        // panel2
        // 
        panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        panel2.Controls.Add(B_Royal);
        panel2.Controls.Add(label2);
        panel2.Location = new System.Drawing.Point(197, 34);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(175, 232);
        panel2.TabIndex = 18;
        // 
        // panel3
        // 
        panel3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        panel3.BackColor = System.Drawing.Color.FromArgb(25, 43, 62);
        panel3.Controls.Add(B_StoryText);
        panel3.Controls.Add(B_GameText);
        panel3.Controls.Add(B_Static);
        panel3.Controls.Add(B_TM);
        panel3.Controls.Add(B_MoveTutor);
        panel3.Controls.Add(B_TMHM);
        panel3.Controls.Add(B_TypeChart);
        panel3.Controls.Add(B_Trainer);
        panel3.Controls.Add(B_Mart);
        panel3.Controls.Add(B_Wild);
        panel3.Controls.Add(B_Pickup);
        panel3.Controls.Add(B_LevelUp);
        panel3.Controls.Add(btnExtrair);
        panel3.Controls.Add(B_ShinyRate);
        panel3.Controls.Add(B_OWSE);
        panel3.Controls.Add(B_MegaEvo);
        panel3.Controls.Add(B_Move);
        panel3.Controls.Add(B_Evolution);
        panel3.Controls.Add(B_EggMove);
        panel3.Controls.Add(B_Item);
        panel3.Controls.Add(B_Personal);
        panel3.Controls.Add(button1);
        panel3.Location = new System.Drawing.Point(514, 0);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(298, 430);
        panel3.TabIndex = 19;
        // 
        // label1
        // 
        label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        label1.AutoSize = true;
        label1.BackColor = System.Drawing.Color.Transparent;
        label1.Font = new System.Drawing.Font("Segoe UI", 10F);
        label1.ForeColor = System.Drawing.Color.DarkGray;
        label1.Location = new System.Drawing.Point(31, 6);
        label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(103, 19);
        label1.TabIndex = 20;
        label1.Text = "6 Gen Exclusive";
        // 
        // label2
        // 
        label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        label2.AutoSize = true;
        label2.BackColor = System.Drawing.Color.Transparent;
        label2.Font = new System.Drawing.Font("Segoe UI", 10F);
        label2.ForeColor = System.Drawing.Color.DarkGray;
        label2.Location = new System.Drawing.Point(33, 6);
        label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(103, 19);
        label2.TabIndex = 21;
        label2.Text = "7 Gen Exclusive";
        // 
        // panel4
        // 
        panel4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        panel4.Controls.Add(RTB_Status);
        panel4.Location = new System.Drawing.Point(14, 276);
        panel4.Name = "panel4";
        panel4.Size = new System.Drawing.Size(484, 101);
        panel4.TabIndex = 22;
        // 
        // Main
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        ClientSize = new System.Drawing.Size(801, 426);
        Controls.Add(panel4);
        Controls.Add(panel3);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Controls.Add(L_Status);
        Controls.Add(TC_RomFS);
        Controls.Add(pBar1);
        Controls.Add(L_Game);
        Controls.Add(TB_Path);
        Controls.Add(menuStrip1);
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MinimumSize = new System.Drawing.Size(464, 329);
        Name = "Main";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "PKMNED";
        FormClosing += CloseForm;
        Load += Main_Load;
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        TC_RomFS.ResumeLayout(false);
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        panel3.ResumeLayout(false);
        panel4.ResumeLayout(false);
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
    private System.Windows.Forms.TabPage Tab_Output;
    private System.Windows.Forms.Button B_Static;
    private System.Windows.Forms.Button B_Gift;
    private System.Windows.Forms.Button B_Starter;
    private System.Windows.Forms.Button B_TypeChart;
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
    private System.Windows.Forms.Label L_Status;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Panel panel4;
}


























































































































































































//Watashi wa watashi sore dake
