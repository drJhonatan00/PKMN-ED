namespace PKMNED.WinForms;

sealed partial class OWSE
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OWSE));
        CB_LocationID = new System.Windows.Forms.ComboBox();
        L_Location = new System.Windows.Forms.Label();
        RTB_ZD = new System.Windows.Forms.RichTextBox();
        tb_Zone = new System.Windows.Forms.TabControl();
        tb_ZoneData = new System.Windows.Forms.TabPage();
        L_MapInfoTabData = new System.Windows.Forms.Label();
        tb_OWSC = new System.Windows.Forms.TabPage();
        B_ResetOverworlds = new System.Windows.Forms.Button();
        CHK_EditRAW = new System.Windows.Forms.CheckBox();
        NUD_UnkCount = new System.Windows.Forms.NumericUpDown();
        L_Unk = new System.Windows.Forms.Label();
        L_OWEntities = new System.Windows.Forms.Label();
        NUD_TrigCount = new System.Windows.Forms.NumericUpDown();
        L_TriggerCount = new System.Windows.Forms.Label();
        NUD_WarpCount = new System.Windows.Forms.NumericUpDown();
        L_WarpCount = new System.Windows.Forms.Label();
        NUD_FurnCount = new System.Windows.Forms.NumericUpDown();
        L_FurnitureCount = new System.Windows.Forms.Label();
        tc_OWSC = new System.Windows.Forms.TabControl();
        tb_Furniture = new System.Windows.Forms.TabPage();
        GB_F = new System.Windows.Forms.GroupBox();
        B_ResetFurniture = new System.Windows.Forms.Button();
        NUD_FWY = new System.Windows.Forms.NumericUpDown();
        L_FWY = new System.Windows.Forms.Label();
        NUD_FWX = new System.Windows.Forms.NumericUpDown();
        L_FWX = new System.Windows.Forms.Label();
        NUD_FY = new System.Windows.Forms.NumericUpDown();
        L_FY = new System.Windows.Forms.Label();
        NUD_FX = new System.Windows.Forms.NumericUpDown();
        L_FX = new System.Windows.Forms.Label();
        RTB_F = new System.Windows.Forms.RichTextBox();
        NUD_FE = new System.Windows.Forms.NumericUpDown();
        L_FE = new System.Windows.Forms.Label();
        tb_NPC = new System.Windows.Forms.TabPage();
        GB_N = new System.Windows.Forms.GroupBox();
        B_ResetNPC = new System.Windows.Forms.Button();
        NUD_NMove2 = new System.Windows.Forms.NumericUpDown();
        L_Move2 = new System.Windows.Forms.Label();
        NUD_NMove1 = new System.Windows.Forms.NumericUpDown();
        L_Move1 = new System.Windows.Forms.Label();
        TB_Leash = new System.Windows.Forms.TextBox();
        L_LeashInfo = new System.Windows.Forms.Label();
        L_NDeg = new System.Windows.Forms.Label();
        TB_NDeg = new System.Windows.Forms.TextBox();
        NUD_NRange = new System.Windows.Forms.NumericUpDown();
        L_Range = new System.Windows.Forms.Label();
        L_ModelAsHex = new System.Windows.Forms.Label();
        NUD_NFlag = new System.Windows.Forms.NumericUpDown();
        L_NFlag = new System.Windows.Forms.Label();
        NUD_NScript = new System.Windows.Forms.NumericUpDown();
        L_NScript = new System.Windows.Forms.Label();
        NUD_NFace = new System.Windows.Forms.NumericUpDown();
        L_NFaceDirection = new System.Windows.Forms.Label();
        NUD_NY = new System.Windows.Forms.NumericUpDown();
        L_NY = new System.Windows.Forms.Label();
        NUD_NX = new System.Windows.Forms.NumericUpDown();
        L_NX = new System.Windows.Forms.Label();
        NUD_NModel = new System.Windows.Forms.NumericUpDown();
        L_NModel = new System.Windows.Forms.Label();
        RTB_N = new System.Windows.Forms.RichTextBox();
        NUD_NID = new System.Windows.Forms.NumericUpDown();
        L_NID = new System.Windows.Forms.Label();
        NUD_NE = new System.Windows.Forms.NumericUpDown();
        L_NE = new System.Windows.Forms.Label();
        tb_Warp = new System.Windows.Forms.TabPage();
        GB_W = new System.Windows.Forms.GroupBox();
        B_ResetWarp = new System.Windows.Forms.Button();
        L_WpY = new System.Windows.Forms.Label();
        L_WpX = new System.Windows.Forms.Label();
        NUD_WY = new System.Windows.Forms.NumericUpDown();
        L_WY = new System.Windows.Forms.Label();
        NUD_WX = new System.Windows.Forms.NumericUpDown();
        L_WX = new System.Windows.Forms.Label();
        RTB_W = new System.Windows.Forms.RichTextBox();
        L_WarpDest = new System.Windows.Forms.Label();
        L_DestMap = new System.Windows.Forms.Label();
        NUD_WTile = new System.Windows.Forms.NumericUpDown();
        L_DestWarpTile = new System.Windows.Forms.Label();
        NUD_WMap = new System.Windows.Forms.NumericUpDown();
        NUD_WE = new System.Windows.Forms.NumericUpDown();
        L_WE = new System.Windows.Forms.Label();
        tb_Trigger1 = new System.Windows.Forms.TabPage();
        GB_T1 = new System.Windows.Forms.GroupBox();
        B_ResetTrigger1 = new System.Windows.Forms.Button();
        NUD_T1Y = new System.Windows.Forms.NumericUpDown();
        L_T1Y = new System.Windows.Forms.Label();
        NUD_T1X = new System.Windows.Forms.NumericUpDown();
        L_T1X = new System.Windows.Forms.Label();
        RTB_T1 = new System.Windows.Forms.RichTextBox();
        NUD_TE = new System.Windows.Forms.NumericUpDown();
        L_TE = new System.Windows.Forms.Label();
        tb_Trigger2 = new System.Windows.Forms.TabPage();
        GB_T2 = new System.Windows.Forms.GroupBox();
        B_ResetTrigger2 = new System.Windows.Forms.Button();
        NUD_T2Y = new System.Windows.Forms.NumericUpDown();
        L_T2Y = new System.Windows.Forms.Label();
        NUD_T2X = new System.Windows.Forms.NumericUpDown();
        L_T2X = new System.Windows.Forms.Label();
        RTB_T2 = new System.Windows.Forms.RichTextBox();
        NUD_UE = new System.Windows.Forms.NumericUpDown();
        L_UE = new System.Windows.Forms.Label();
        tb_Script = new System.Windows.Forms.TabPage();
        RTB_OSP = new System.Windows.Forms.RichTextBox();
        RTB_OS = new System.Windows.Forms.RichTextBox();
        L_OWSCDesc = new System.Windows.Forms.Label();
        RTB_OWSCMD = new System.Windows.Forms.RichTextBox();
        NUD_NPCCount = new System.Windows.Forms.NumericUpDown();
        L_NPCCount = new System.Windows.Forms.Label();
        tb_MSC = new System.Windows.Forms.TabPage();
        RTB_MSP = new System.Windows.Forms.RichTextBox();
        RTB_MSCMD = new System.Windows.Forms.RichTextBox();
        L_MSSCDesc = new System.Windows.Forms.Label();
        RTB_MS = new System.Windows.Forms.RichTextBox();
        tb_Encounters = new System.Windows.Forms.TabPage();
        L_Encounters = new System.Windows.Forms.Label();
        tb_File5 = new System.Windows.Forms.TabPage();
        L_File5TabData = new System.Windows.Forms.Label();
        tb_RAW = new System.Windows.Forms.TabPage();
        L_ZD = new System.Windows.Forms.Label();
        L_File3 = new System.Windows.Forms.Label();
        L_ZDMaster = new System.Windows.Forms.Label();
        L_File5 = new System.Windows.Forms.Label();
        L_File4 = new System.Windows.Forms.Label();
        L_File2 = new System.Windows.Forms.Label();
        L_File1 = new System.Windows.Forms.Label();
        RTB_ZDMaster = new System.Windows.Forms.RichTextBox();
        RTB_File5 = new System.Windows.Forms.RichTextBox();
        RTB_OWSC = new System.Windows.Forms.RichTextBox();
        RTB_Encounter = new System.Windows.Forms.RichTextBox();
        RTB_MapSC = new System.Windows.Forms.RichTextBox();
        tb_Dev = new System.Windows.Forms.TabPage();
        B_DumpZD = new System.Windows.Forms.Button();
        L_DeComp = new System.Windows.Forms.Label();
        RTB_CompressedScript = new System.Windows.Forms.RichTextBox();
        RTB_DecompressedScript = new System.Windows.Forms.RichTextBox();
        L_Comp = new System.Windows.Forms.Label();
        B_DumpMaps = new System.Windows.Forms.Button();
        B_DumpUnk = new System.Windows.Forms.Button();
        B_DumpTrigger = new System.Windows.Forms.Button();
        B_DumpWarp = new System.Windows.Forms.Button();
        B_DumpNPC = new System.Windows.Forms.Button();
        B_DumpFurniture = new System.Windows.Forms.Button();
        B_Map = new System.Windows.Forms.Button();
        L_ZDPreview = new System.Windows.Forms.Label();
        B_HLCMD = new System.Windows.Forms.Button();
        tb_Zone.SuspendLayout();
        tb_ZoneData.SuspendLayout();
        tb_OWSC.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_UnkCount).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_TrigCount).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_WarpCount).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_FurnCount).BeginInit();
        tc_OWSC.SuspendLayout();
        tb_Furniture.SuspendLayout();
        GB_F.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_FWY).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_FWX).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_FY).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_FX).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_FE).BeginInit();
        tb_NPC.SuspendLayout();
        GB_N.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_NMove2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_NMove1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_NRange).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_NFlag).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_NScript).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_NFace).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_NY).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_NX).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_NModel).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_NID).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_NE).BeginInit();
        tb_Warp.SuspendLayout();
        GB_W.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_WY).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_WX).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_WTile).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_WMap).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_WE).BeginInit();
        tb_Trigger1.SuspendLayout();
        GB_T1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_T1Y).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_T1X).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_TE).BeginInit();
        tb_Trigger2.SuspendLayout();
        GB_T2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_T2Y).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_T2X).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_UE).BeginInit();
        tb_Script.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_NPCCount).BeginInit();
        tb_MSC.SuspendLayout();
        tb_Encounters.SuspendLayout();
        tb_File5.SuspendLayout();
        tb_RAW.SuspendLayout();
        tb_Dev.SuspendLayout();
        SuspendLayout();
        // 
        // CB_LocationID
        // 
        CB_LocationID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
        CB_LocationID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        CB_LocationID.Enabled = false;
        CB_LocationID.FormattingEnabled = true;
        CB_LocationID.Location = new System.Drawing.Point(54, 6);
        CB_LocationID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CB_LocationID.Name = "CB_LocationID";
        CB_LocationID.Size = new System.Drawing.Size(191, 23);
        CB_LocationID.TabIndex = 407;
        CB_LocationID.SelectedIndexChanged += CB_LocationID_SelectedIndexChanged;
        // 
        // L_Location
        // 
        L_Location.AutoSize = true;
        L_Location.Location = new System.Drawing.Point(14, 9);
        L_Location.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Location.Name = "L_Location";
        L_Location.Size = new System.Drawing.Size(29, 15);
        L_Location.TabIndex = 411;
        L_Location.Text = "Loc:";
        // 
        // RTB_ZD
        // 
        RTB_ZD.Font = new System.Drawing.Font("Courier New", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        RTB_ZD.Location = new System.Drawing.Point(253, 3);
        RTB_ZD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        RTB_ZD.Name = "RTB_ZD";
        RTB_ZD.ReadOnly = true;
        RTB_ZD.Size = new System.Drawing.Size(310, 41);
        RTB_ZD.TabIndex = 412;
        RTB_ZD.Text = "00 11 22 33 44 55 66 77 88 99 AA BB CC DD EE FF";
        // 
        // tb_Zone
        // 
        tb_Zone.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        tb_Zone.Controls.Add(tb_ZoneData);
        tb_Zone.Controls.Add(tb_OWSC);
        tb_Zone.Controls.Add(tb_MSC);
        tb_Zone.Controls.Add(tb_Encounters);
        tb_Zone.Controls.Add(tb_File5);
        tb_Zone.Controls.Add(tb_RAW);
        tb_Zone.Controls.Add(tb_Dev);
        tb_Zone.Location = new System.Drawing.Point(14, 37);
        tb_Zone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tb_Zone.Name = "tb_Zone";
        tb_Zone.SelectedIndex = 0;
        tb_Zone.Size = new System.Drawing.Size(576, 573);
        tb_Zone.TabIndex = 417;
        // 
        // tb_ZoneData
        // 
        tb_ZoneData.Controls.Add(L_MapInfoTabData);
        tb_ZoneData.Location = new System.Drawing.Point(4, 24);
        tb_ZoneData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tb_ZoneData.Name = "tb_ZoneData";
        tb_ZoneData.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tb_ZoneData.Size = new System.Drawing.Size(568, 545);
        tb_ZoneData.TabIndex = 0;
        tb_ZoneData.Text = "ZoneData";
        tb_ZoneData.UseVisualStyleBackColor = true;
        // 
        // L_MapInfoTabData
        // 
        L_MapInfoTabData.AutoSize = true;
        L_MapInfoTabData.Location = new System.Drawing.Point(30, 30);
        L_MapInfoTabData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_MapInfoTabData.Name = "L_MapInfoTabData";
        L_MapInfoTabData.Size = new System.Drawing.Size(248, 15);
        L_MapInfoTabData.TabIndex = 2;
        L_MapInfoTabData.Text = "Functionality unknown. See RAW tab for data.";
        // 
        // tb_OWSC
        // 
        tb_OWSC.Controls.Add(B_ResetOverworlds);
        tb_OWSC.Controls.Add(CHK_EditRAW);
        tb_OWSC.Controls.Add(NUD_UnkCount);
        tb_OWSC.Controls.Add(L_Unk);
        tb_OWSC.Controls.Add(L_OWEntities);
        tb_OWSC.Controls.Add(NUD_TrigCount);
        tb_OWSC.Controls.Add(L_TriggerCount);
        tb_OWSC.Controls.Add(NUD_WarpCount);
        tb_OWSC.Controls.Add(L_WarpCount);
        tb_OWSC.Controls.Add(NUD_FurnCount);
        tb_OWSC.Controls.Add(L_FurnitureCount);
        tb_OWSC.Controls.Add(tc_OWSC);
        tb_OWSC.Controls.Add(NUD_NPCCount);
        tb_OWSC.Controls.Add(L_NPCCount);
        tb_OWSC.Location = new System.Drawing.Point(4, 24);
        tb_OWSC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tb_OWSC.Name = "tb_OWSC";
        tb_OWSC.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tb_OWSC.Size = new System.Drawing.Size(568, 545);
        tb_OWSC.TabIndex = 1;
        tb_OWSC.Text = "OW & SC";
        tb_OWSC.UseVisualStyleBackColor = true;
        // 
        // B_ResetOverworlds
        // 
        B_ResetOverworlds.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        B_ResetOverworlds.Location = new System.Drawing.Point(482, 181);
        B_ResetOverworlds.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_ResetOverworlds.Name = "B_ResetOverworlds";
        B_ResetOverworlds.Size = new System.Drawing.Size(72, 48);
        B_ResetOverworlds.TabIndex = 467;
        B_ResetOverworlds.Text = "Reset\r\nAll";
        B_ResetOverworlds.UseVisualStyleBackColor = true;
        B_ResetOverworlds.Click += B_ResetOverworlds_Click;
        // 
        // CHK_EditRAW
        // 
        CHK_EditRAW.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        CHK_EditRAW.AutoSize = true;
        CHK_EditRAW.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
        CHK_EditRAW.Location = new System.Drawing.Point(456, 155);
        CHK_EditRAW.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_EditRAW.Name = "CHK_EditRAW";
        CHK_EditRAW.Size = new System.Drawing.Size(98, 19);
        CHK_EditRAW.TabIndex = 430;
        CHK_EditRAW.Text = "Edit Raw Data";
        CHK_EditRAW.UseVisualStyleBackColor = true;
        CHK_EditRAW.CheckedChanged += ChangeRAWCheck;
        // 
        // NUD_UnkCount
        // 
        NUD_UnkCount.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        NUD_UnkCount.Location = new System.Drawing.Point(492, 125);
        NUD_UnkCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_UnkCount.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
        NUD_UnkCount.Name = "NUD_UnkCount";
        NUD_UnkCount.Size = new System.Drawing.Size(62, 23);
        NUD_UnkCount.TabIndex = 428;
        NUD_UnkCount.ValueChanged += ChangeUnkCount;
        // 
        // L_Unk
        // 
        L_Unk.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        L_Unk.Location = new System.Drawing.Point(408, 125);
        L_Unk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Unk.Name = "L_Unk";
        L_Unk.Size = new System.Drawing.Size(77, 17);
        L_Unk.TabIndex = 429;
        L_Unk.Text = "Unk:";
        L_Unk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // L_OWEntities
        // 
        L_OWEntities.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        L_OWEntities.AutoSize = true;
        L_OWEntities.Location = new System.Drawing.Point(416, 15);
        L_OWEntities.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_OWEntities.Name = "L_OWEntities";
        L_OWEntities.Size = new System.Drawing.Size(134, 15);
        L_OWEntities.TabIndex = 423;
        L_OWEntities.Text = "Overworld Entity Count:";
        // 
        // NUD_TrigCount
        // 
        NUD_TrigCount.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        NUD_TrigCount.Location = new System.Drawing.Point(492, 102);
        NUD_TrigCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_TrigCount.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
        NUD_TrigCount.Name = "NUD_TrigCount";
        NUD_TrigCount.Size = new System.Drawing.Size(62, 23);
        NUD_TrigCount.TabIndex = 421;
        NUD_TrigCount.ValueChanged += ChangeTriggerCount;
        // 
        // L_TriggerCount
        // 
        L_TriggerCount.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        L_TriggerCount.Location = new System.Drawing.Point(408, 102);
        L_TriggerCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_TriggerCount.Name = "L_TriggerCount";
        L_TriggerCount.Size = new System.Drawing.Size(77, 17);
        L_TriggerCount.TabIndex = 422;
        L_TriggerCount.Text = "Trigger:";
        L_TriggerCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // NUD_WarpCount
        // 
        NUD_WarpCount.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        NUD_WarpCount.Location = new System.Drawing.Point(492, 78);
        NUD_WarpCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_WarpCount.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
        NUD_WarpCount.Name = "NUD_WarpCount";
        NUD_WarpCount.Size = new System.Drawing.Size(62, 23);
        NUD_WarpCount.TabIndex = 419;
        NUD_WarpCount.ValueChanged += ChangeWarpCount;
        // 
        // L_WarpCount
        // 
        L_WarpCount.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        L_WarpCount.Location = new System.Drawing.Point(408, 78);
        L_WarpCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_WarpCount.Name = "L_WarpCount";
        L_WarpCount.Size = new System.Drawing.Size(77, 17);
        L_WarpCount.TabIndex = 420;
        L_WarpCount.Text = "Warp:";
        L_WarpCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // NUD_FurnCount
        // 
        NUD_FurnCount.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        NUD_FurnCount.Location = new System.Drawing.Point(492, 32);
        NUD_FurnCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_FurnCount.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
        NUD_FurnCount.Name = "NUD_FurnCount";
        NUD_FurnCount.Size = new System.Drawing.Size(62, 23);
        NUD_FurnCount.TabIndex = 417;
        NUD_FurnCount.ValueChanged += ChangeFurnitureCount;
        // 
        // L_FurnitureCount
        // 
        L_FurnitureCount.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        L_FurnitureCount.Location = new System.Drawing.Point(408, 32);
        L_FurnitureCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_FurnitureCount.Name = "L_FurnitureCount";
        L_FurnitureCount.Size = new System.Drawing.Size(77, 17);
        L_FurnitureCount.TabIndex = 418;
        L_FurnitureCount.Text = "Furniture:";
        L_FurnitureCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // tc_OWSC
        // 
        tc_OWSC.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        tc_OWSC.Controls.Add(tb_Furniture);
        tc_OWSC.Controls.Add(tb_NPC);
        tc_OWSC.Controls.Add(tb_Warp);
        tc_OWSC.Controls.Add(tb_Trigger1);
        tc_OWSC.Controls.Add(tb_Trigger2);
        tc_OWSC.Controls.Add(tb_Script);
        tc_OWSC.Location = new System.Drawing.Point(7, 7);
        tc_OWSC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tc_OWSC.Name = "tc_OWSC";
        tc_OWSC.SelectedIndex = 0;
        tc_OWSC.Size = new System.Drawing.Size(402, 533);
        tc_OWSC.TabIndex = 415;
        // 
        // tb_Furniture
        // 
        tb_Furniture.Controls.Add(GB_F);
        tb_Furniture.Controls.Add(NUD_FE);
        tb_Furniture.Controls.Add(L_FE);
        tb_Furniture.Location = new System.Drawing.Point(4, 24);
        tb_Furniture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tb_Furniture.Name = "tb_Furniture";
        tb_Furniture.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tb_Furniture.Size = new System.Drawing.Size(394, 505);
        tb_Furniture.TabIndex = 0;
        tb_Furniture.Text = "Furniture";
        tb_Furniture.UseVisualStyleBackColor = true;
        // 
        // GB_F
        // 
        GB_F.Controls.Add(B_ResetFurniture);
        GB_F.Controls.Add(NUD_FWY);
        GB_F.Controls.Add(L_FWY);
        GB_F.Controls.Add(NUD_FWX);
        GB_F.Controls.Add(L_FWX);
        GB_F.Controls.Add(NUD_FY);
        GB_F.Controls.Add(L_FY);
        GB_F.Controls.Add(NUD_FX);
        GB_F.Controls.Add(L_FX);
        GB_F.Controls.Add(RTB_F);
        GB_F.Location = new System.Drawing.Point(7, 46);
        GB_F.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        GB_F.Name = "GB_F";
        GB_F.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        GB_F.Size = new System.Drawing.Size(379, 373);
        GB_F.TabIndex = 437;
        GB_F.TabStop = false;
        GB_F.Text = "Info:";
        // 
        // B_ResetFurniture
        // 
        B_ResetFurniture.Location = new System.Drawing.Point(300, 317);
        B_ResetFurniture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_ResetFurniture.Name = "B_ResetFurniture";
        B_ResetFurniture.Size = new System.Drawing.Size(72, 48);
        B_ResetFurniture.TabIndex = 470;
        B_ResetFurniture.Text = "Reset\r\nFurniture";
        B_ResetFurniture.UseVisualStyleBackColor = true;
        B_ResetFurniture.Click += B_ResetFurniture_Click;
        // 
        // NUD_FWY
        // 
        NUD_FWY.Location = new System.Drawing.Point(146, 249);
        NUD_FWY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_FWY.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
        NUD_FWY.Name = "NUD_FWY";
        NUD_FWY.Size = new System.Drawing.Size(62, 23);
        NUD_FWY.TabIndex = 469;
        // 
        // L_FWY
        // 
        L_FWY.Location = new System.Drawing.Point(50, 249);
        L_FWY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_FWY.Name = "L_FWY";
        L_FWY.Size = new System.Drawing.Size(89, 18);
        L_FWY.TabIndex = 468;
        L_FWY.Text = "FwY:";
        L_FWY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // NUD_FWX
        // 
        NUD_FWX.Location = new System.Drawing.Point(146, 219);
        NUD_FWX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_FWX.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
        NUD_FWX.Name = "NUD_FWX";
        NUD_FWX.Size = new System.Drawing.Size(62, 23);
        NUD_FWX.TabIndex = 467;
        // 
        // L_FWX
        // 
        L_FWX.Location = new System.Drawing.Point(50, 219);
        L_FWX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_FWX.Name = "L_FWX";
        L_FWX.Size = new System.Drawing.Size(89, 18);
        L_FWX.TabIndex = 466;
        L_FWX.Text = "FwX:";
        L_FWX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // NUD_FY
        // 
        NUD_FY.Location = new System.Drawing.Point(146, 189);
        NUD_FY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_FY.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
        NUD_FY.Name = "NUD_FY";
        NUD_FY.Size = new System.Drawing.Size(62, 23);
        NUD_FY.TabIndex = 463;
        // 
        // L_FY
        // 
        L_FY.Location = new System.Drawing.Point(50, 189);
        L_FY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_FY.Name = "L_FY";
        L_FY.Size = new System.Drawing.Size(89, 18);
        L_FY.TabIndex = 462;
        L_FY.Text = "Y Coordinate:";
        L_FY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // NUD_FX
        // 
        NUD_FX.Location = new System.Drawing.Point(146, 159);
        NUD_FX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_FX.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
        NUD_FX.Name = "NUD_FX";
        NUD_FX.Size = new System.Drawing.Size(62, 23);
        NUD_FX.TabIndex = 461;
        // 
        // L_FX
        // 
        L_FX.Location = new System.Drawing.Point(50, 159);
        L_FX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_FX.Name = "L_FX";
        L_FX.Size = new System.Drawing.Size(89, 18);
        L_FX.TabIndex = 460;
        L_FX.Text = "X Coordinate:";
        L_FX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // RTB_F
        // 
        RTB_F.Font = new System.Drawing.Font("Courier New", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        RTB_F.Location = new System.Drawing.Point(7, 317);
        RTB_F.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        RTB_F.Name = "RTB_F";
        RTB_F.Size = new System.Drawing.Size(285, 48);
        RTB_F.TabIndex = 425;
        RTB_F.Text = "00 11 22 33 44 55 66 77 88 99 AA BB CC DD EE FF 00 11 22 33 44 55 66 77 88 99 AA BB CC DD EE FF 00 11 22 33 44 55 66 77 88 99 AA BB CC DD EE FF ";
        RTB_F.Visible = false;
        RTB_F.TextChanged += ChangeRAW_F;
        // 
        // NUD_FE
        // 
        NUD_FE.Location = new System.Drawing.Point(88, 13);
        NUD_FE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_FE.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
        NUD_FE.Name = "NUD_FE";
        NUD_FE.Size = new System.Drawing.Size(62, 23);
        NUD_FE.TabIndex = 423;
        NUD_FE.ValueChanged += ChangeFurniture;
        // 
        // L_FE
        // 
        L_FE.Location = new System.Drawing.Point(4, 13);
        L_FE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_FE.Name = "L_FE";
        L_FE.Size = new System.Drawing.Size(77, 17);
        L_FE.TabIndex = 424;
        L_FE.Text = "Entry:";
        L_FE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // tb_NPC
        // 
        tb_NPC.Controls.Add(GB_N);
        tb_NPC.Controls.Add(NUD_NE);
        tb_NPC.Controls.Add(L_NE);
        tb_NPC.Location = new System.Drawing.Point(4, 24);
        tb_NPC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tb_NPC.Name = "tb_NPC";
        tb_NPC.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tb_NPC.Size = new System.Drawing.Size(394, 505);
        tb_NPC.TabIndex = 1;
        tb_NPC.Text = "NPC";
        tb_NPC.UseVisualStyleBackColor = true;
        // 
        // GB_N
        // 
        GB_N.Controls.Add(B_ResetNPC);
        GB_N.Controls.Add(NUD_NMove2);
        GB_N.Controls.Add(L_Move2);
        GB_N.Controls.Add(NUD_NMove1);
        GB_N.Controls.Add(L_Move1);
        GB_N.Controls.Add(TB_Leash);
        GB_N.Controls.Add(L_LeashInfo);
        GB_N.Controls.Add(L_NDeg);
        GB_N.Controls.Add(TB_NDeg);
        GB_N.Controls.Add(NUD_NRange);
        GB_N.Controls.Add(L_Range);
        GB_N.Controls.Add(L_ModelAsHex);
        GB_N.Controls.Add(NUD_NFlag);
        GB_N.Controls.Add(L_NFlag);
        GB_N.Controls.Add(NUD_NScript);
        GB_N.Controls.Add(L_NScript);
        GB_N.Controls.Add(NUD_NFace);
        GB_N.Controls.Add(L_NFaceDirection);
        GB_N.Controls.Add(NUD_NY);
        GB_N.Controls.Add(L_NY);
        GB_N.Controls.Add(NUD_NX);
        GB_N.Controls.Add(L_NX);
        GB_N.Controls.Add(NUD_NModel);
        GB_N.Controls.Add(L_NModel);
        GB_N.Controls.Add(RTB_N);
        GB_N.Controls.Add(NUD_NID);
        GB_N.Controls.Add(L_NID);
        GB_N.Location = new System.Drawing.Point(7, 46);
        GB_N.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        GB_N.Name = "GB_N";
        GB_N.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        GB_N.Size = new System.Drawing.Size(379, 373);
        GB_N.TabIndex = 436;
        GB_N.TabStop = false;
        GB_N.Text = "Info:";
        // 
        // B_ResetNPC
        // 
        B_ResetNPC.Location = new System.Drawing.Point(300, 317);
        B_ResetNPC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_ResetNPC.Name = "B_ResetNPC";
        B_ResetNPC.Size = new System.Drawing.Size(72, 48);
        B_ResetNPC.TabIndex = 458;
        B_ResetNPC.Text = "Reset\r\nNPC";
        B_ResetNPC.UseVisualStyleBackColor = true;
        B_ResetNPC.Click += B_ResetNPC_Click;
        // 
        // NUD_NMove2
        // 
        NUD_NMove2.Location = new System.Drawing.Point(273, 168);
        NUD_NMove2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_NMove2.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
        NUD_NMove2.Name = "NUD_NMove2";
        NUD_NMove2.Size = new System.Drawing.Size(62, 23);
        NUD_NMove2.TabIndex = 457;
        // 
        // L_Move2
        // 
        L_Move2.Location = new System.Drawing.Point(177, 168);
        L_Move2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Move2.Name = "L_Move2";
        L_Move2.Size = new System.Drawing.Size(89, 18);
        L_Move2.TabIndex = 456;
        L_Move2.Text = "Move2:";
        L_Move2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // NUD_NMove1
        // 
        NUD_NMove1.Location = new System.Drawing.Point(273, 138);
        NUD_NMove1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_NMove1.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
        NUD_NMove1.Name = "NUD_NMove1";
        NUD_NMove1.Size = new System.Drawing.Size(62, 23);
        NUD_NMove1.TabIndex = 455;
        // 
        // L_Move1
        // 
        L_Move1.Location = new System.Drawing.Point(177, 138);
        L_Move1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Move1.Name = "L_Move1";
        L_Move1.Size = new System.Drawing.Size(89, 18);
        L_Move1.TabIndex = 454;
        L_Move1.Text = "Move1:";
        L_Move1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // TB_Leash
        // 
        TB_Leash.Location = new System.Drawing.Point(108, 288);
        TB_Leash.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        TB_Leash.Name = "TB_Leash";
        TB_Leash.ReadOnly = true;
        TB_Leash.Size = new System.Drawing.Size(184, 23);
        TB_Leash.TabIndex = 453;
        // 
        // L_LeashInfo
        // 
        L_LeashInfo.Location = new System.Drawing.Point(13, 290);
        L_LeashInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_LeashInfo.Name = "L_LeashInfo";
        L_LeashInfo.Size = new System.Drawing.Size(89, 18);
        L_LeashInfo.TabIndex = 452;
        L_LeashInfo.Text = "Leash Info:";
        L_LeashInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // L_NDeg
        // 
        L_NDeg.Location = new System.Drawing.Point(13, 260);
        L_NDeg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_NDeg.Name = "L_NDeg";
        L_NDeg.Size = new System.Drawing.Size(89, 18);
        L_NDeg.TabIndex = 451;
        L_NDeg.Text = "Degrees (?):";
        L_NDeg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // TB_NDeg
        // 
        TB_NDeg.Location = new System.Drawing.Point(108, 258);
        TB_NDeg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        TB_NDeg.Name = "TB_NDeg";
        TB_NDeg.ReadOnly = true;
        TB_NDeg.Size = new System.Drawing.Size(61, 23);
        TB_NDeg.TabIndex = 437;
        // 
        // NUD_NRange
        // 
        NUD_NRange.Location = new System.Drawing.Point(108, 168);
        NUD_NRange.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_NRange.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
        NUD_NRange.Name = "NUD_NRange";
        NUD_NRange.Size = new System.Drawing.Size(62, 23);
        NUD_NRange.TabIndex = 450;
        // 
        // L_Range
        // 
        L_Range.Location = new System.Drawing.Point(13, 168);
        L_Range.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Range.Name = "L_Range";
        L_Range.Size = new System.Drawing.Size(89, 18);
        L_Range.TabIndex = 449;
        L_Range.Text = "Sight Range:";
        L_Range.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // L_ModelAsHex
        // 
        L_ModelAsHex.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        L_ModelAsHex.AutoSize = true;
        L_ModelAsHex.Location = new System.Drawing.Point(177, 51);
        L_ModelAsHex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_ModelAsHex.Name = "L_ModelAsHex";
        L_ModelAsHex.Size = new System.Drawing.Size(29, 15);
        L_ModelAsHex.TabIndex = 448;
        L_ModelAsHex.Text = "HEX";
        // 
        // NUD_NFlag
        // 
        NUD_NFlag.Location = new System.Drawing.Point(108, 78);
        NUD_NFlag.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_NFlag.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
        NUD_NFlag.Name = "NUD_NFlag";
        NUD_NFlag.Size = new System.Drawing.Size(62, 23);
        NUD_NFlag.TabIndex = 447;
        // 
        // L_NFlag
        // 
        L_NFlag.Location = new System.Drawing.Point(13, 78);
        L_NFlag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_NFlag.Name = "L_NFlag";
        L_NFlag.Size = new System.Drawing.Size(89, 18);
        L_NFlag.TabIndex = 446;
        L_NFlag.Text = "Spawn Flag:";
        L_NFlag.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // NUD_NScript
        // 
        NUD_NScript.Location = new System.Drawing.Point(108, 108);
        NUD_NScript.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_NScript.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
        NUD_NScript.Name = "NUD_NScript";
        NUD_NScript.Size = new System.Drawing.Size(62, 23);
        NUD_NScript.TabIndex = 445;
        // 
        // L_NScript
        // 
        L_NScript.Location = new System.Drawing.Point(13, 108);
        L_NScript.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_NScript.Name = "L_NScript";
        L_NScript.Size = new System.Drawing.Size(89, 18);
        L_NScript.TabIndex = 444;
        L_NScript.Text = "Script:";
        L_NScript.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // NUD_NFace
        // 
        NUD_NFace.Location = new System.Drawing.Point(108, 138);
        NUD_NFace.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_NFace.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
        NUD_NFace.Name = "NUD_NFace";
        NUD_NFace.Size = new System.Drawing.Size(62, 23);
        NUD_NFace.TabIndex = 443;
        // 
        // L_NFaceDirection
        // 
        L_NFaceDirection.Location = new System.Drawing.Point(13, 138);
        L_NFaceDirection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_NFaceDirection.Name = "L_NFaceDirection";
        L_NFaceDirection.Size = new System.Drawing.Size(89, 18);
        L_NFaceDirection.TabIndex = 442;
        L_NFaceDirection.Text = "Facing:";
        L_NFaceDirection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // NUD_NY
        // 
        NUD_NY.Location = new System.Drawing.Point(108, 228);
        NUD_NY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_NY.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
        NUD_NY.Name = "NUD_NY";
        NUD_NY.Size = new System.Drawing.Size(62, 23);
        NUD_NY.TabIndex = 441;
        // 
        // L_NY
        // 
        L_NY.Location = new System.Drawing.Point(13, 228);
        L_NY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_NY.Name = "L_NY";
        L_NY.Size = new System.Drawing.Size(89, 18);
        L_NY.TabIndex = 440;
        L_NY.Text = "Y Coordinate:";
        L_NY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // NUD_NX
        // 
        NUD_NX.Location = new System.Drawing.Point(108, 198);
        NUD_NX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_NX.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
        NUD_NX.Name = "NUD_NX";
        NUD_NX.Size = new System.Drawing.Size(62, 23);
        NUD_NX.TabIndex = 439;
        // 
        // L_NX
        // 
        L_NX.Location = new System.Drawing.Point(13, 198);
        L_NX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_NX.Name = "L_NX";
        L_NX.Size = new System.Drawing.Size(89, 18);
        L_NX.TabIndex = 438;
        L_NX.Text = "X Coordinate:";
        L_NX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // NUD_NModel
        // 
        NUD_NModel.Location = new System.Drawing.Point(108, 48);
        NUD_NModel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_NModel.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
        NUD_NModel.Name = "NUD_NModel";
        NUD_NModel.Size = new System.Drawing.Size(62, 23);
        NUD_NModel.TabIndex = 437;
        NUD_NModel.ValueChanged += ChangeNPC_Model;
        // 
        // L_NModel
        // 
        L_NModel.Location = new System.Drawing.Point(13, 48);
        L_NModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_NModel.Name = "L_NModel";
        L_NModel.Size = new System.Drawing.Size(89, 18);
        L_NModel.TabIndex = 436;
        L_NModel.Text = "Model:";
        L_NModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // RTB_N
        // 
        RTB_N.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        RTB_N.Font = new System.Drawing.Font("Courier New", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        RTB_N.Location = new System.Drawing.Point(7, 317);
        RTB_N.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        RTB_N.Name = "RTB_N";
        RTB_N.Size = new System.Drawing.Size(285, 48);
        RTB_N.TabIndex = 414;
        RTB_N.Text = "00 11 22 33 44 55 66 77 88 99 AA BB CC DD EE FF 00 11 22 33 44 55 66 77 88 99 AA BB CC DD EE FF 00 11 22 33 44 55 66 77 88 99 AA BB CC DD EE FF ";
        RTB_N.Visible = false;
        RTB_N.TextChanged += ChangeRAW_N;
        // 
        // NUD_NID
        // 
        NUD_NID.Location = new System.Drawing.Point(108, 18);
        NUD_NID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_NID.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
        NUD_NID.Name = "NUD_NID";
        NUD_NID.Size = new System.Drawing.Size(62, 23);
        NUD_NID.TabIndex = 435;
        NUD_NID.ValueChanged += ChangeNPC_ID;
        // 
        // L_NID
        // 
        L_NID.Location = new System.Drawing.Point(13, 18);
        L_NID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_NID.Name = "L_NID";
        L_NID.Size = new System.Drawing.Size(89, 18);
        L_NID.TabIndex = 433;
        L_NID.Text = "Entity ID:";
        L_NID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // NUD_NE
        // 
        NUD_NE.Location = new System.Drawing.Point(88, 13);
        NUD_NE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_NE.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
        NUD_NE.Name = "NUD_NE";
        NUD_NE.Size = new System.Drawing.Size(62, 23);
        NUD_NE.TabIndex = 425;
        NUD_NE.ValueChanged += ChangeNPC;
        // 
        // L_NE
        // 
        L_NE.Location = new System.Drawing.Point(4, 13);
        L_NE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_NE.Name = "L_NE";
        L_NE.Size = new System.Drawing.Size(77, 17);
        L_NE.TabIndex = 426;
        L_NE.Text = "Entry:";
        L_NE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // tb_Warp
        // 
        tb_Warp.Controls.Add(GB_W);
        tb_Warp.Controls.Add(NUD_WE);
        tb_Warp.Controls.Add(L_WE);
        tb_Warp.Location = new System.Drawing.Point(4, 24);
        tb_Warp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tb_Warp.Name = "tb_Warp";
        tb_Warp.Size = new System.Drawing.Size(394, 505);
        tb_Warp.TabIndex = 2;
        tb_Warp.Text = "Warp";
        tb_Warp.UseVisualStyleBackColor = true;
        // 
        // GB_W
        // 
        GB_W.Controls.Add(B_ResetWarp);
        GB_W.Controls.Add(L_WpY);
        GB_W.Controls.Add(L_WpX);
        GB_W.Controls.Add(NUD_WY);
        GB_W.Controls.Add(L_WY);
        GB_W.Controls.Add(NUD_WX);
        GB_W.Controls.Add(L_WX);
        GB_W.Controls.Add(RTB_W);
        GB_W.Controls.Add(L_WarpDest);
        GB_W.Controls.Add(L_DestMap);
        GB_W.Controls.Add(NUD_WTile);
        GB_W.Controls.Add(L_DestWarpTile);
        GB_W.Controls.Add(NUD_WMap);
        GB_W.Location = new System.Drawing.Point(7, 46);
        GB_W.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        GB_W.Name = "GB_W";
        GB_W.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        GB_W.Size = new System.Drawing.Size(379, 373);
        GB_W.TabIndex = 438;
        GB_W.TabStop = false;
        GB_W.Text = "Info:";
        // 
        // B_ResetWarp
        // 
        B_ResetWarp.Location = new System.Drawing.Point(299, 317);
        B_ResetWarp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_ResetWarp.Name = "B_ResetWarp";
        B_ResetWarp.Size = new System.Drawing.Size(72, 48);
        B_ResetWarp.TabIndex = 466;
        B_ResetWarp.Text = "Reset\r\nWarp";
        B_ResetWarp.UseVisualStyleBackColor = true;
        B_ResetWarp.Click += B_ResetWarp_Click;
        // 
        // L_WpY
        // 
        L_WpY.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        L_WpY.AutoSize = true;
        L_WpY.Location = new System.Drawing.Point(295, 220);
        L_WpY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_WpY.Name = "L_WpY";
        L_WpY.Size = new System.Drawing.Size(31, 15);
        L_WpY.TabIndex = 465;
        L_WpY.Text = "#/18";
        // 
        // L_WpX
        // 
        L_WpX.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        L_WpX.AutoSize = true;
        L_WpX.Location = new System.Drawing.Point(295, 190);
        L_WpX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_WpX.Name = "L_WpX";
        L_WpX.Size = new System.Drawing.Size(31, 15);
        L_WpX.TabIndex = 464;
        L_WpX.Text = "#/18";
        // 
        // NUD_WY
        // 
        NUD_WY.Increment = new decimal(new int[] { 18, 0, 0, 0 });
        NUD_WY.Location = new System.Drawing.Point(146, 218);
        NUD_WY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_WY.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
        NUD_WY.Name = "NUD_WY";
        NUD_WY.Size = new System.Drawing.Size(62, 23);
        NUD_WY.TabIndex = 463;
        NUD_WY.ValueChanged += ChangeWarp_Y;
        // 
        // L_WY
        // 
        L_WY.Location = new System.Drawing.Point(50, 218);
        L_WY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_WY.Name = "L_WY";
        L_WY.Size = new System.Drawing.Size(89, 18);
        L_WY.TabIndex = 462;
        L_WY.Text = "Y Coordinate:";
        L_WY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // NUD_WX
        // 
        NUD_WX.Increment = new decimal(new int[] { 18, 0, 0, 0 });
        NUD_WX.Location = new System.Drawing.Point(146, 188);
        NUD_WX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_WX.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
        NUD_WX.Name = "NUD_WX";
        NUD_WX.Size = new System.Drawing.Size(62, 23);
        NUD_WX.TabIndex = 461;
        NUD_WX.ValueChanged += ChangeWarp_X;
        // 
        // L_WX
        // 
        L_WX.Location = new System.Drawing.Point(50, 188);
        L_WX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_WX.Name = "L_WX";
        L_WX.Size = new System.Drawing.Size(89, 18);
        L_WX.TabIndex = 460;
        L_WX.Text = "X Coordinate:";
        L_WX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // RTB_W
        // 
        RTB_W.Font = new System.Drawing.Font("Courier New", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        RTB_W.Location = new System.Drawing.Point(7, 317);
        RTB_W.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        RTB_W.Name = "RTB_W";
        RTB_W.Size = new System.Drawing.Size(285, 48);
        RTB_W.TabIndex = 425;
        RTB_W.Text = "00 11 22 33 44 55 66 77 88 99 AA BB CC DD EE FF 00 11 22 33 44 55 66 77 88 99 AA BB CC DD EE FF 00 11 22 33 44 55 66 77 88 99 AA BB CC DD EE FF ";
        RTB_W.Visible = false;
        RTB_W.TextChanged += ChangeRAW_W;
        // 
        // L_WarpDest
        // 
        L_WarpDest.Location = new System.Drawing.Point(68, 36);
        L_WarpDest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_WarpDest.Name = "L_WarpDest";
        L_WarpDest.Size = new System.Drawing.Size(140, 17);
        L_WarpDest.TabIndex = 432;
        L_WarpDest.Text = "Dest:";
        L_WarpDest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        L_WarpDest.DoubleClick += DclickDestMap;
        // 
        // L_DestMap
        // 
        L_DestMap.Location = new System.Drawing.Point(-1, 58);
        L_DestMap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_DestMap.Name = "L_DestMap";
        L_DestMap.Size = new System.Drawing.Size(140, 17);
        L_DestMap.TabIndex = 428;
        L_DestMap.Text = "Destination Map:";
        L_DestMap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // NUD_WTile
        // 
        NUD_WTile.Location = new System.Drawing.Point(146, 81);
        NUD_WTile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_WTile.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
        NUD_WTile.Name = "NUD_WTile";
        NUD_WTile.Size = new System.Drawing.Size(62, 23);
        NUD_WTile.TabIndex = 431;
        // 
        // L_DestWarpTile
        // 
        L_DestWarpTile.Location = new System.Drawing.Point(-1, 82);
        L_DestWarpTile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_DestWarpTile.Name = "L_DestWarpTile";
        L_DestWarpTile.Size = new System.Drawing.Size(140, 17);
        L_DestWarpTile.TabIndex = 429;
        L_DestWarpTile.Text = "Destination WarpTile:";
        L_DestWarpTile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // NUD_WMap
        // 
        NUD_WMap.Location = new System.Drawing.Point(146, 57);
        NUD_WMap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_WMap.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
        NUD_WMap.Name = "NUD_WMap";
        NUD_WMap.Size = new System.Drawing.Size(62, 23);
        NUD_WMap.TabIndex = 430;
        // 
        // NUD_WE
        // 
        NUD_WE.Location = new System.Drawing.Point(88, 13);
        NUD_WE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_WE.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
        NUD_WE.Name = "NUD_WE";
        NUD_WE.Size = new System.Drawing.Size(62, 23);
        NUD_WE.TabIndex = 425;
        NUD_WE.ValueChanged += ChangeWarp;
        // 
        // L_WE
        // 
        L_WE.Location = new System.Drawing.Point(4, 13);
        L_WE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_WE.Name = "L_WE";
        L_WE.Size = new System.Drawing.Size(77, 17);
        L_WE.TabIndex = 426;
        L_WE.Text = "Entry:";
        L_WE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // tb_Trigger1
        // 
        tb_Trigger1.Controls.Add(GB_T1);
        tb_Trigger1.Controls.Add(NUD_TE);
        tb_Trigger1.Controls.Add(L_TE);
        tb_Trigger1.Location = new System.Drawing.Point(4, 24);
        tb_Trigger1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tb_Trigger1.Name = "tb_Trigger1";
        tb_Trigger1.Size = new System.Drawing.Size(394, 505);
        tb_Trigger1.TabIndex = 3;
        tb_Trigger1.Text = "Trigger1";
        tb_Trigger1.UseVisualStyleBackColor = true;
        // 
        // GB_T1
        // 
        GB_T1.Controls.Add(B_ResetTrigger1);
        GB_T1.Controls.Add(NUD_T1Y);
        GB_T1.Controls.Add(L_T1Y);
        GB_T1.Controls.Add(NUD_T1X);
        GB_T1.Controls.Add(L_T1X);
        GB_T1.Controls.Add(RTB_T1);
        GB_T1.Location = new System.Drawing.Point(7, 46);
        GB_T1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        GB_T1.Name = "GB_T1";
        GB_T1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        GB_T1.Size = new System.Drawing.Size(379, 373);
        GB_T1.TabIndex = 439;
        GB_T1.TabStop = false;
        GB_T1.Text = "Info:";
        // 
        // B_ResetTrigger1
        // 
        B_ResetTrigger1.Location = new System.Drawing.Point(300, 317);
        B_ResetTrigger1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_ResetTrigger1.Name = "B_ResetTrigger1";
        B_ResetTrigger1.Size = new System.Drawing.Size(72, 48);
        B_ResetTrigger1.TabIndex = 467;
        B_ResetTrigger1.Text = "Reset\r\nTrigger1";
        B_ResetTrigger1.UseVisualStyleBackColor = true;
        B_ResetTrigger1.Click += B_ResetTrigger1_Click;
        // 
        // NUD_T1Y
        // 
        NUD_T1Y.Location = new System.Drawing.Point(167, 189);
        NUD_T1Y.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_T1Y.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
        NUD_T1Y.Name = "NUD_T1Y";
        NUD_T1Y.Size = new System.Drawing.Size(62, 23);
        NUD_T1Y.TabIndex = 445;
        // 
        // L_T1Y
        // 
        L_T1Y.Location = new System.Drawing.Point(71, 189);
        L_T1Y.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_T1Y.Name = "L_T1Y";
        L_T1Y.Size = new System.Drawing.Size(89, 18);
        L_T1Y.TabIndex = 444;
        L_T1Y.Text = "Y Coordinate:";
        L_T1Y.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // NUD_T1X
        // 
        NUD_T1X.Location = new System.Drawing.Point(167, 159);
        NUD_T1X.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_T1X.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
        NUD_T1X.Name = "NUD_T1X";
        NUD_T1X.Size = new System.Drawing.Size(62, 23);
        NUD_T1X.TabIndex = 443;
        // 
        // L_T1X
        // 
        L_T1X.Location = new System.Drawing.Point(71, 159);
        L_T1X.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_T1X.Name = "L_T1X";
        L_T1X.Size = new System.Drawing.Size(89, 18);
        L_T1X.TabIndex = 442;
        L_T1X.Text = "X Coordinate:";
        L_T1X.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // RTB_T1
        // 
        RTB_T1.Font = new System.Drawing.Font("Courier New", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        RTB_T1.Location = new System.Drawing.Point(7, 317);
        RTB_T1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        RTB_T1.Name = "RTB_T1";
        RTB_T1.Size = new System.Drawing.Size(285, 48);
        RTB_T1.TabIndex = 425;
        RTB_T1.Text = "00 11 22 33 44 55 66 77 88 99 AA BB CC DD EE FF 00 11 22 33 44 55 66 77 88 99 AA BB CC DD EE FF 00 11 22 33 44 55 66 77 88 99 AA BB CC DD EE FF ";
        RTB_T1.Visible = false;
        RTB_T1.TextChanged += ChangeRAW_T1;
        // 
        // NUD_TE
        // 
        NUD_TE.Location = new System.Drawing.Point(88, 13);
        NUD_TE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_TE.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
        NUD_TE.Name = "NUD_TE";
        NUD_TE.Size = new System.Drawing.Size(62, 23);
        NUD_TE.TabIndex = 425;
        NUD_TE.ValueChanged += ChangeTrigger1;
        // 
        // L_TE
        // 
        L_TE.Location = new System.Drawing.Point(4, 13);
        L_TE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_TE.Name = "L_TE";
        L_TE.Size = new System.Drawing.Size(77, 17);
        L_TE.TabIndex = 426;
        L_TE.Text = "Entry:";
        L_TE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // tb_Trigger2
        // 
        tb_Trigger2.Controls.Add(GB_T2);
        tb_Trigger2.Controls.Add(NUD_UE);
        tb_Trigger2.Controls.Add(L_UE);
        tb_Trigger2.Location = new System.Drawing.Point(4, 24);
        tb_Trigger2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tb_Trigger2.Name = "tb_Trigger2";
        tb_Trigger2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tb_Trigger2.Size = new System.Drawing.Size(394, 505);
        tb_Trigger2.TabIndex = 5;
        tb_Trigger2.Text = "Trigger2";
        tb_Trigger2.UseVisualStyleBackColor = true;
        // 
        // GB_T2
        // 
        GB_T2.Controls.Add(B_ResetTrigger2);
        GB_T2.Controls.Add(NUD_T2Y);
        GB_T2.Controls.Add(L_T2Y);
        GB_T2.Controls.Add(NUD_T2X);
        GB_T2.Controls.Add(L_T2X);
        GB_T2.Controls.Add(RTB_T2);
        GB_T2.Location = new System.Drawing.Point(7, 46);
        GB_T2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        GB_T2.Name = "GB_T2";
        GB_T2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        GB_T2.Size = new System.Drawing.Size(379, 373);
        GB_T2.TabIndex = 440;
        GB_T2.TabStop = false;
        GB_T2.Text = "Info:";
        // 
        // B_ResetTrigger2
        // 
        B_ResetTrigger2.Location = new System.Drawing.Point(300, 317);
        B_ResetTrigger2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_ResetTrigger2.Name = "B_ResetTrigger2";
        B_ResetTrigger2.Size = new System.Drawing.Size(72, 48);
        B_ResetTrigger2.TabIndex = 467;
        B_ResetTrigger2.Text = "Reset\r\nTrigger2";
        B_ResetTrigger2.UseVisualStyleBackColor = true;
        B_ResetTrigger2.Click += B_ResetTrigger2_Click;
        // 
        // NUD_T2Y
        // 
        NUD_T2Y.Location = new System.Drawing.Point(167, 189);
        NUD_T2Y.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_T2Y.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
        NUD_T2Y.Name = "NUD_T2Y";
        NUD_T2Y.Size = new System.Drawing.Size(62, 23);
        NUD_T2Y.TabIndex = 445;
        // 
        // L_T2Y
        // 
        L_T2Y.Location = new System.Drawing.Point(71, 189);
        L_T2Y.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_T2Y.Name = "L_T2Y";
        L_T2Y.Size = new System.Drawing.Size(89, 18);
        L_T2Y.TabIndex = 444;
        L_T2Y.Text = "Y Coordinate:";
        L_T2Y.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // NUD_T2X
        // 
        NUD_T2X.Location = new System.Drawing.Point(167, 159);
        NUD_T2X.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_T2X.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
        NUD_T2X.Name = "NUD_T2X";
        NUD_T2X.Size = new System.Drawing.Size(62, 23);
        NUD_T2X.TabIndex = 443;
        // 
        // L_T2X
        // 
        L_T2X.Location = new System.Drawing.Point(71, 159);
        L_T2X.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_T2X.Name = "L_T2X";
        L_T2X.Size = new System.Drawing.Size(89, 18);
        L_T2X.TabIndex = 442;
        L_T2X.Text = "X Coordinate:";
        L_T2X.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // RTB_T2
        // 
        RTB_T2.Font = new System.Drawing.Font("Courier New", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        RTB_T2.Location = new System.Drawing.Point(7, 317);
        RTB_T2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        RTB_T2.Name = "RTB_T2";
        RTB_T2.Size = new System.Drawing.Size(285, 48);
        RTB_T2.TabIndex = 425;
        RTB_T2.Text = "00 11 22 33 44 55 66 77 88 99 AA BB CC DD EE FF 00 11 22 33 44 55 66 77 88 99 AA BB CC DD EE FF 00 11 22 33 44 55 66 77 88 99 AA BB CC DD EE FF ";
        RTB_T2.Visible = false;
        RTB_T2.TextChanged += ChangeRAW_T2;
        // 
        // NUD_UE
        // 
        NUD_UE.Location = new System.Drawing.Point(88, 13);
        NUD_UE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_UE.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
        NUD_UE.Name = "NUD_UE";
        NUD_UE.Size = new System.Drawing.Size(62, 23);
        NUD_UE.TabIndex = 427;
        NUD_UE.ValueChanged += ChangeTrigger2;
        // 
        // L_UE
        // 
        L_UE.Location = new System.Drawing.Point(4, 13);
        L_UE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_UE.Name = "L_UE";
        L_UE.Size = new System.Drawing.Size(77, 17);
        L_UE.TabIndex = 428;
        L_UE.Text = "Entry:";
        L_UE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // tb_Script
        // 
        tb_Script.Controls.Add(RTB_OSP);
        tb_Script.Controls.Add(RTB_OS);
        tb_Script.Controls.Add(L_OWSCDesc);
        tb_Script.Controls.Add(RTB_OWSCMD);
        tb_Script.Location = new System.Drawing.Point(4, 24);
        tb_Script.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tb_Script.Name = "tb_Script";
        tb_Script.Size = new System.Drawing.Size(394, 505);
        tb_Script.TabIndex = 4;
        tb_Script.Text = "Script";
        tb_Script.UseVisualStyleBackColor = true;
        // 
        // RTB_OSP
        // 
        RTB_OSP.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        RTB_OSP.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        RTB_OSP.Location = new System.Drawing.Point(7, 270);
        RTB_OSP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        RTB_OSP.Name = "RTB_OSP";
        RTB_OSP.ReadOnly = true;
        RTB_OSP.Size = new System.Drawing.Size(386, 230);
        RTB_OSP.TabIndex = 425;
        RTB_OSP.Text = "Parse Output";
        // 
        // RTB_OS
        // 
        RTB_OS.Font = new System.Drawing.Font("Courier New", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        RTB_OS.Location = new System.Drawing.Point(113, 3);
        RTB_OS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        RTB_OS.Name = "RTB_OS";
        RTB_OS.ReadOnly = true;
        RTB_OS.Size = new System.Drawing.Size(98, 259);
        RTB_OS.TabIndex = 424;
        RTB_OS.Text = "Raw Data";
        // 
        // L_OWSCDesc
        // 
        L_OWSCDesc.AutoSize = true;
        L_OWSCDesc.Location = new System.Drawing.Point(219, 3);
        L_OWSCDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_OWSCDesc.Name = "L_OWSCDesc";
        L_OWSCDesc.Size = new System.Drawing.Size(83, 15);
        L_OWSCDesc.TabIndex = 423;
        L_OWSCDesc.Text = "Script Analysis";
        // 
        // RTB_OWSCMD
        // 
        RTB_OWSCMD.Font = new System.Drawing.Font("Courier New", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        RTB_OWSCMD.Location = new System.Drawing.Point(7, 3);
        RTB_OWSCMD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        RTB_OWSCMD.Name = "RTB_OWSCMD";
        RTB_OWSCMD.ReadOnly = true;
        RTB_OWSCMD.Size = new System.Drawing.Size(98, 259);
        RTB_OWSCMD.TabIndex = 422;
        RTB_OWSCMD.Text = "Script CMDs";
        // 
        // NUD_NPCCount
        // 
        NUD_NPCCount.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        NUD_NPCCount.Location = new System.Drawing.Point(492, 55);
        NUD_NPCCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_NPCCount.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
        NUD_NPCCount.Name = "NUD_NPCCount";
        NUD_NPCCount.Size = new System.Drawing.Size(62, 23);
        NUD_NPCCount.TabIndex = 415;
        NUD_NPCCount.ValueChanged += ChangeNPCCount;
        // 
        // L_NPCCount
        // 
        L_NPCCount.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        L_NPCCount.Location = new System.Drawing.Point(408, 55);
        L_NPCCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_NPCCount.Name = "L_NPCCount";
        L_NPCCount.Size = new System.Drawing.Size(77, 17);
        L_NPCCount.TabIndex = 416;
        L_NPCCount.Text = "NPC:";
        L_NPCCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // tb_MSC
        // 
        tb_MSC.Controls.Add(RTB_MSP);
        tb_MSC.Controls.Add(RTB_MSCMD);
        tb_MSC.Controls.Add(L_MSSCDesc);
        tb_MSC.Controls.Add(RTB_MS);
        tb_MSC.Location = new System.Drawing.Point(4, 24);
        tb_MSC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tb_MSC.Name = "tb_MSC";
        tb_MSC.Size = new System.Drawing.Size(568, 545);
        tb_MSC.TabIndex = 2;
        tb_MSC.Text = "Map SC";
        tb_MSC.UseVisualStyleBackColor = true;
        // 
        // RTB_MSP
        // 
        RTB_MSP.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        RTB_MSP.Font = new System.Drawing.Font("Courier New", 8.25F);
        RTB_MSP.Location = new System.Drawing.Point(4, 270);
        RTB_MSP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        RTB_MSP.Name = "RTB_MSP";
        RTB_MSP.ReadOnly = true;
        RTB_MSP.Size = new System.Drawing.Size(563, 273);
        RTB_MSP.TabIndex = 428;
        RTB_MSP.Text = "Parse Output";
        // 
        // RTB_MSCMD
        // 
        RTB_MSCMD.Font = new System.Drawing.Font("Courier New", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        RTB_MSCMD.Location = new System.Drawing.Point(4, 3);
        RTB_MSCMD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        RTB_MSCMD.Name = "RTB_MSCMD";
        RTB_MSCMD.ReadOnly = true;
        RTB_MSCMD.Size = new System.Drawing.Size(98, 259);
        RTB_MSCMD.TabIndex = 427;
        RTB_MSCMD.Text = "Script CMDs";
        // 
        // L_MSSCDesc
        // 
        L_MSSCDesc.AutoSize = true;
        L_MSSCDesc.Location = new System.Drawing.Point(216, 3);
        L_MSSCDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_MSSCDesc.Name = "L_MSSCDesc";
        L_MSSCDesc.Size = new System.Drawing.Size(83, 15);
        L_MSSCDesc.TabIndex = 426;
        L_MSSCDesc.Text = "Script Analysis";
        // 
        // RTB_MS
        // 
        RTB_MS.Font = new System.Drawing.Font("Courier New", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        RTB_MS.Location = new System.Drawing.Point(110, 3);
        RTB_MS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        RTB_MS.Name = "RTB_MS";
        RTB_MS.ReadOnly = true;
        RTB_MS.Size = new System.Drawing.Size(98, 259);
        RTB_MS.TabIndex = 425;
        RTB_MS.Text = "Raw Data";
        // 
        // tb_Encounters
        // 
        tb_Encounters.Controls.Add(L_Encounters);
        tb_Encounters.Location = new System.Drawing.Point(4, 24);
        tb_Encounters.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tb_Encounters.Name = "tb_Encounters";
        tb_Encounters.Size = new System.Drawing.Size(568, 545);
        tb_Encounters.TabIndex = 3;
        tb_Encounters.Text = "Encounters";
        tb_Encounters.UseVisualStyleBackColor = true;
        // 
        // L_Encounters
        // 
        L_Encounters.AutoSize = true;
        L_Encounters.Location = new System.Drawing.Point(30, 30);
        L_Encounters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Encounters.Name = "L_Encounters";
        L_Encounters.Size = new System.Drawing.Size(268, 15);
        L_Encounters.TabIndex = 0;
        L_Encounters.Text = "Encounters are handled in the regular Wild Editor.";
        // 
        // tb_File5
        // 
        tb_File5.Controls.Add(L_File5TabData);
        tb_File5.Location = new System.Drawing.Point(4, 24);
        tb_File5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tb_File5.Name = "tb_File5";
        tb_File5.Size = new System.Drawing.Size(568, 545);
        tb_File5.TabIndex = 4;
        tb_File5.Text = "File 5";
        tb_File5.UseVisualStyleBackColor = true;
        // 
        // L_File5TabData
        // 
        L_File5TabData.AutoSize = true;
        L_File5TabData.Location = new System.Drawing.Point(30, 30);
        L_File5TabData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_File5TabData.Name = "L_File5TabData";
        L_File5TabData.Size = new System.Drawing.Size(248, 15);
        L_File5TabData.TabIndex = 1;
        L_File5TabData.Text = "Functionality unknown. See RAW tab for data.";
        // 
        // tb_RAW
        // 
        tb_RAW.Controls.Add(L_ZD);
        tb_RAW.Controls.Add(L_File3);
        tb_RAW.Controls.Add(L_ZDMaster);
        tb_RAW.Controls.Add(L_File5);
        tb_RAW.Controls.Add(L_File4);
        tb_RAW.Controls.Add(L_File2);
        tb_RAW.Controls.Add(L_File1);
        tb_RAW.Controls.Add(RTB_ZDMaster);
        tb_RAW.Controls.Add(RTB_ZD);
        tb_RAW.Controls.Add(RTB_File5);
        tb_RAW.Controls.Add(RTB_OWSC);
        tb_RAW.Controls.Add(RTB_Encounter);
        tb_RAW.Controls.Add(RTB_MapSC);
        tb_RAW.Location = new System.Drawing.Point(4, 24);
        tb_RAW.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tb_RAW.Name = "tb_RAW";
        tb_RAW.Size = new System.Drawing.Size(568, 545);
        tb_RAW.TabIndex = 5;
        tb_RAW.Text = "RAW";
        tb_RAW.UseVisualStyleBackColor = true;
        // 
        // L_ZD
        // 
        L_ZD.AutoSize = true;
        L_ZD.Font = new System.Drawing.Font("Courier New", 8.25F);
        L_ZD.Location = new System.Drawing.Point(163, 399);
        L_ZD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_ZD.Name = "L_ZD";
        L_ZD.Size = new System.Drawing.Size(35, 28);
        L_ZD.TabIndex = 430;
        L_ZD.Text = "X: ~\r\nY: ~";
        // 
        // L_File3
        // 
        L_File3.Location = new System.Drawing.Point(82, 96);
        L_File3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_File3.Name = "L_File3";
        L_File3.Size = new System.Drawing.Size(164, 27);
        L_File3.TabIndex = 429;
        L_File3.Text = "Map Environment [3]:";
        L_File3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // L_ZDMaster
        // 
        L_ZDMaster.Location = new System.Drawing.Point(-5, 320);
        L_ZDMaster.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_ZDMaster.Name = "L_ZDMaster";
        L_ZDMaster.Size = new System.Drawing.Size(164, 27);
        L_ZDMaster.TabIndex = 428;
        L_ZDMaster.Text = "Master ZoneData Table:";
        L_ZDMaster.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // L_File5
        // 
        L_File5.Location = new System.Drawing.Point(82, 193);
        L_File5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_File5.Name = "L_File5";
        L_File5.Size = new System.Drawing.Size(164, 27);
        L_File5.TabIndex = 427;
        L_File5.Text = "Unknown [5]:";
        L_File5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // L_File4
        // 
        L_File4.Location = new System.Drawing.Point(82, 144);
        L_File4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_File4.Name = "L_File4";
        L_File4.Size = new System.Drawing.Size(164, 27);
        L_File4.TabIndex = 426;
        L_File4.Text = "Encounter Data [4]:";
        L_File4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // L_File2
        // 
        L_File2.Location = new System.Drawing.Point(82, 47);
        L_File2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_File2.Name = "L_File2";
        L_File2.Size = new System.Drawing.Size(164, 27);
        L_File2.TabIndex = 424;
        L_File2.Text = "Overworlds [2]:";
        L_File2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // L_File1
        // 
        L_File1.Location = new System.Drawing.Point(82, -1);
        L_File1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_File1.Name = "L_File1";
        L_File1.Size = new System.Drawing.Size(164, 27);
        L_File1.TabIndex = 423;
        L_File1.Text = "ZoneData [1]:";
        L_File1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // RTB_ZDMaster
        // 
        RTB_ZDMaster.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        RTB_ZDMaster.Location = new System.Drawing.Point(167, 322);
        RTB_ZDMaster.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        RTB_ZDMaster.Name = "RTB_ZDMaster";
        RTB_ZDMaster.ReadOnly = true;
        RTB_ZDMaster.Size = new System.Drawing.Size(396, 73);
        RTB_ZDMaster.TabIndex = 422;
        RTB_ZDMaster.Text = "00 11 22 33 44 55 66 77 88 99 AA BB CC DD EE FF 00 11 22 33 44 55 66 77 88 99 AA BB CC DD EE FF 00 11 22 33 44 55 66 77 88 99 AA BB CC DD EE FF 00 11 22 33 44 55 66 77 88 99 AA BB CC DD EE FF";
        // 
        // RTB_File5
        // 
        RTB_File5.Font = new System.Drawing.Font("Courier New", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        RTB_File5.Location = new System.Drawing.Point(253, 197);
        RTB_File5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        RTB_File5.Name = "RTB_File5";
        RTB_File5.ReadOnly = true;
        RTB_File5.Size = new System.Drawing.Size(310, 41);
        RTB_File5.TabIndex = 421;
        RTB_File5.Text = "00 11 22 33 44 55 66 77 88 99 AA BB CC DD EE FF";
        // 
        // RTB_OWSC
        // 
        RTB_OWSC.Font = new System.Drawing.Font("Courier New", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        RTB_OWSC.Location = new System.Drawing.Point(253, 52);
        RTB_OWSC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        RTB_OWSC.Name = "RTB_OWSC";
        RTB_OWSC.ReadOnly = true;
        RTB_OWSC.Size = new System.Drawing.Size(310, 41);
        RTB_OWSC.TabIndex = 418;
        RTB_OWSC.Text = "00 11 22 33 44 55 66 77 88 99 AA BB CC DD EE FF";
        // 
        // RTB_Encounter
        // 
        RTB_Encounter.Font = new System.Drawing.Font("Courier New", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        RTB_Encounter.Location = new System.Drawing.Point(253, 149);
        RTB_Encounter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        RTB_Encounter.Name = "RTB_Encounter";
        RTB_Encounter.ReadOnly = true;
        RTB_Encounter.Size = new System.Drawing.Size(310, 41);
        RTB_Encounter.TabIndex = 420;
        RTB_Encounter.Text = "00 11 22 33 44 55 66 77 88 99 AA BB CC DD EE FF";
        // 
        // RTB_MapSC
        // 
        RTB_MapSC.Font = new System.Drawing.Font("Courier New", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        RTB_MapSC.Location = new System.Drawing.Point(253, 100);
        RTB_MapSC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        RTB_MapSC.Name = "RTB_MapSC";
        RTB_MapSC.ReadOnly = true;
        RTB_MapSC.Size = new System.Drawing.Size(310, 41);
        RTB_MapSC.TabIndex = 419;
        RTB_MapSC.Text = "00 11 22 33 44 55 66 77 88 99 AA BB CC DD EE FF";
        // 
        // tb_Dev
        // 
        tb_Dev.Controls.Add(B_DumpZD);
        tb_Dev.Controls.Add(L_DeComp);
        tb_Dev.Controls.Add(RTB_CompressedScript);
        tb_Dev.Controls.Add(RTB_DecompressedScript);
        tb_Dev.Controls.Add(L_Comp);
        tb_Dev.Controls.Add(B_DumpMaps);
        tb_Dev.Controls.Add(B_DumpUnk);
        tb_Dev.Controls.Add(B_DumpTrigger);
        tb_Dev.Controls.Add(B_DumpWarp);
        tb_Dev.Controls.Add(B_DumpNPC);
        tb_Dev.Controls.Add(B_DumpFurniture);
        tb_Dev.Location = new System.Drawing.Point(4, 24);
        tb_Dev.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tb_Dev.Name = "tb_Dev";
        tb_Dev.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tb_Dev.Size = new System.Drawing.Size(568, 545);
        tb_Dev.TabIndex = 7;
        tb_Dev.Text = "Dev";
        tb_Dev.UseVisualStyleBackColor = true;
        // 
        // B_DumpZD
        // 
        B_DumpZD.Location = new System.Drawing.Point(174, 59);
        B_DumpZD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_DumpZD.Name = "B_DumpZD";
        B_DumpZD.Size = new System.Drawing.Size(104, 45);
        B_DumpZD.TabIndex = 431;
        B_DumpZD.Text = "Dump all ZD";
        B_DumpZD.UseVisualStyleBackColor = true;
        B_DumpZD.Click += B_DumpZD_Click;
        // 
        // L_DeComp
        // 
        L_DeComp.AutoSize = true;
        L_DeComp.Location = new System.Drawing.Point(461, 258);
        L_DeComp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_DeComp.Name = "L_DeComp";
        L_DeComp.Size = new System.Drawing.Size(85, 15);
        L_DeComp.TabIndex = 430;
        L_DeComp.Text = "Decompressed";
        // 
        // RTB_CompressedScript
        // 
        RTB_CompressedScript.Font = new System.Drawing.Font("Courier New", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        RTB_CompressedScript.Location = new System.Drawing.Point(355, 277);
        RTB_CompressedScript.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        RTB_CompressedScript.Name = "RTB_CompressedScript";
        RTB_CompressedScript.Size = new System.Drawing.Size(98, 259);
        RTB_CompressedScript.TabIndex = 429;
        RTB_CompressedScript.Text = "Script CMDs";
        RTB_CompressedScript.TextChanged += PasteScript;
        // 
        // RTB_DecompressedScript
        // 
        RTB_DecompressedScript.Font = new System.Drawing.Font("Courier New", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        RTB_DecompressedScript.Location = new System.Drawing.Point(461, 277);
        RTB_DecompressedScript.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        RTB_DecompressedScript.Name = "RTB_DecompressedScript";
        RTB_DecompressedScript.ReadOnly = true;
        RTB_DecompressedScript.Size = new System.Drawing.Size(98, 259);
        RTB_DecompressedScript.TabIndex = 428;
        RTB_DecompressedScript.Text = "Raw Data";
        // 
        // L_Comp
        // 
        L_Comp.AutoSize = true;
        L_Comp.Location = new System.Drawing.Point(351, 258);
        L_Comp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Comp.Name = "L_Comp";
        L_Comp.Size = new System.Drawing.Size(73, 15);
        L_Comp.TabIndex = 426;
        L_Comp.Text = "Compressed";
        // 
        // B_DumpMaps
        // 
        B_DumpMaps.Location = new System.Drawing.Point(174, 7);
        B_DumpMaps.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_DumpMaps.Name = "B_DumpMaps";
        B_DumpMaps.Size = new System.Drawing.Size(104, 45);
        B_DumpMaps.TabIndex = 425;
        B_DumpMaps.Text = "Dump all Maps";
        B_DumpMaps.UseVisualStyleBackColor = true;
        B_DumpMaps.Click += B_DumpMaps_Click;
        // 
        // B_DumpUnk
        // 
        B_DumpUnk.Location = new System.Drawing.Point(7, 215);
        B_DumpUnk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_DumpUnk.Name = "B_DumpUnk";
        B_DumpUnk.Size = new System.Drawing.Size(104, 45);
        B_DumpUnk.TabIndex = 424;
        B_DumpUnk.Text = "Dump all\r\nUnk";
        B_DumpUnk.UseVisualStyleBackColor = true;
        B_DumpUnk.Click += B_DumpUnk_Click;
        // 
        // B_DumpTrigger
        // 
        B_DumpTrigger.Location = new System.Drawing.Point(7, 163);
        B_DumpTrigger.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_DumpTrigger.Name = "B_DumpTrigger";
        B_DumpTrigger.Size = new System.Drawing.Size(104, 45);
        B_DumpTrigger.TabIndex = 423;
        B_DumpTrigger.Text = "Dump all\r\nTriggers";
        B_DumpTrigger.UseVisualStyleBackColor = true;
        B_DumpTrigger.Click += B_DumpTrigger_Click;
        // 
        // B_DumpWarp
        // 
        B_DumpWarp.Location = new System.Drawing.Point(7, 111);
        B_DumpWarp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_DumpWarp.Name = "B_DumpWarp";
        B_DumpWarp.Size = new System.Drawing.Size(104, 45);
        B_DumpWarp.TabIndex = 422;
        B_DumpWarp.Text = "Dump all\r\nWarp Bytes";
        B_DumpWarp.UseVisualStyleBackColor = true;
        B_DumpWarp.Click += B_DumpWarp_Click;
        // 
        // B_DumpNPC
        // 
        B_DumpNPC.Location = new System.Drawing.Point(7, 59);
        B_DumpNPC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_DumpNPC.Name = "B_DumpNPC";
        B_DumpNPC.Size = new System.Drawing.Size(104, 45);
        B_DumpNPC.TabIndex = 421;
        B_DumpNPC.Text = "Dump all\r\nNPC Bytes";
        B_DumpNPC.UseVisualStyleBackColor = true;
        B_DumpNPC.Click += B_DumpNPC_Click;
        // 
        // B_DumpFurniture
        // 
        B_DumpFurniture.Location = new System.Drawing.Point(7, 7);
        B_DumpFurniture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_DumpFurniture.Name = "B_DumpFurniture";
        B_DumpFurniture.Size = new System.Drawing.Size(104, 45);
        B_DumpFurniture.TabIndex = 420;
        B_DumpFurniture.Text = "Dump all\r\nFurniture Bytes";
        B_DumpFurniture.UseVisualStyleBackColor = true;
        B_DumpFurniture.Click += B_DumpFurniture_Click;
        // 
        // B_Map
        // 
        B_Map.Location = new System.Drawing.Point(371, 6);
        B_Map.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Map.Name = "B_Map";
        B_Map.Size = new System.Drawing.Size(104, 27);
        B_Map.TabIndex = 420;
        B_Map.Text = "Show Map";
        B_Map.UseVisualStyleBackColor = true;
        B_Map.Click += B_Map_Click;
        // 
        // L_ZDPreview
        // 
        L_ZDPreview.AutoSize = true;
        L_ZDPreview.Location = new System.Drawing.Point(252, 3);
        L_ZDPreview.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_ZDPreview.Name = "L_ZDPreview";
        L_ZDPreview.Size = new System.Drawing.Size(55, 30);
        L_ZDPreview.TabIndex = 418;
        L_ZDPreview.Text = "Text File:\r\nMap File:";
        // 
        // B_HLCMD
        // 
        B_HLCMD.Location = new System.Drawing.Point(482, 6);
        B_HLCMD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_HLCMD.Name = "B_HLCMD";
        B_HLCMD.Size = new System.Drawing.Size(104, 27);
        B_HLCMD.TabIndex = 419;
        B_HLCMD.Text = "HL **CMD**";
        B_HLCMD.UseVisualStyleBackColor = true;
        B_HLCMD.Click += B_HLCMD_Click;
        // 
        // OWSE
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(600, 620);
        Controls.Add(B_Map);
        Controls.Add(B_HLCMD);
        Controls.Add(L_ZDPreview);
        Controls.Add(tb_Zone);
        Controls.Add(L_Location);
        Controls.Add(CB_LocationID);
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MinimumSize = new System.Drawing.Size(616, 657);
        Name = "OWSE";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Overworld Editor";
        FormClosing += ClosingForm;
        tb_Zone.ResumeLayout(false);
        tb_ZoneData.ResumeLayout(false);
        tb_ZoneData.PerformLayout();
        tb_OWSC.ResumeLayout(false);
        tb_OWSC.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_UnkCount).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_TrigCount).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_WarpCount).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_FurnCount).EndInit();
        tc_OWSC.ResumeLayout(false);
        tb_Furniture.ResumeLayout(false);
        GB_F.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)NUD_FWY).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_FWX).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_FY).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_FX).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_FE).EndInit();
        tb_NPC.ResumeLayout(false);
        GB_N.ResumeLayout(false);
        GB_N.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_NMove2).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_NMove1).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_NRange).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_NFlag).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_NScript).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_NFace).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_NY).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_NX).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_NModel).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_NID).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_NE).EndInit();
        tb_Warp.ResumeLayout(false);
        GB_W.ResumeLayout(false);
        GB_W.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_WY).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_WX).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_WTile).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_WMap).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_WE).EndInit();
        tb_Trigger1.ResumeLayout(false);
        GB_T1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)NUD_T1Y).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_T1X).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_TE).EndInit();
        tb_Trigger2.ResumeLayout(false);
        GB_T2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)NUD_T2Y).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_T2X).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_UE).EndInit();
        tb_Script.ResumeLayout(false);
        tb_Script.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_NPCCount).EndInit();
        tb_MSC.ResumeLayout(false);
        tb_MSC.PerformLayout();
        tb_Encounters.ResumeLayout(false);
        tb_Encounters.PerformLayout();
        tb_File5.ResumeLayout(false);
        tb_File5.PerformLayout();
        tb_RAW.ResumeLayout(false);
        tb_RAW.PerformLayout();
        tb_Dev.ResumeLayout(false);
        tb_Dev.PerformLayout();
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox CB_LocationID;
    private System.Windows.Forms.Label L_Location;
    private System.Windows.Forms.RichTextBox RTB_ZD;
    private System.Windows.Forms.TabControl tb_Zone;
    private System.Windows.Forms.TabPage tb_ZoneData;
    private System.Windows.Forms.TabPage tb_OWSC;
    private System.Windows.Forms.TabPage tb_MSC;
    private System.Windows.Forms.TabPage tb_Encounters;
    private System.Windows.Forms.TabPage tb_File5;
    private System.Windows.Forms.TabControl tc_OWSC;
    private System.Windows.Forms.TabPage tb_Furniture;
    private System.Windows.Forms.TabPage tb_NPC;
    private System.Windows.Forms.RichTextBox RTB_N;
    private System.Windows.Forms.TabPage tb_Warp;
    private System.Windows.Forms.TabPage tb_Trigger1;
    private System.Windows.Forms.RichTextBox RTB_OWSC;
    private System.Windows.Forms.RichTextBox RTB_MapSC;
    private System.Windows.Forms.RichTextBox RTB_Encounter;
    private System.Windows.Forms.RichTextBox RTB_File5;
    private System.Windows.Forms.NumericUpDown NUD_TrigCount;
    private System.Windows.Forms.Label L_TriggerCount;
    private System.Windows.Forms.NumericUpDown NUD_WarpCount;
    private System.Windows.Forms.Label L_WarpCount;
    private System.Windows.Forms.NumericUpDown NUD_FurnCount;
    private System.Windows.Forms.Label L_FurnitureCount;
    private System.Windows.Forms.NumericUpDown NUD_NPCCount;
    private System.Windows.Forms.Label L_NPCCount;
    private System.Windows.Forms.NumericUpDown NUD_FE;
    private System.Windows.Forms.Label L_FE;
    private System.Windows.Forms.NumericUpDown NUD_NE;
    private System.Windows.Forms.Label L_NE;
    private System.Windows.Forms.NumericUpDown NUD_WE;
    private System.Windows.Forms.Label L_WE;
    private System.Windows.Forms.NumericUpDown NUD_TE;
    private System.Windows.Forms.Label L_TE;
    private System.Windows.Forms.TabPage tb_Script;
    private System.Windows.Forms.RichTextBox RTB_ZDMaster;
    private System.Windows.Forms.RichTextBox RTB_F;
    private System.Windows.Forms.RichTextBox RTB_OWSCMD;
    private System.Windows.Forms.NumericUpDown NUD_WTile;
    private System.Windows.Forms.NumericUpDown NUD_WMap;
    private System.Windows.Forms.Label L_DestWarpTile;
    private System.Windows.Forms.Label L_DestMap;
    private System.Windows.Forms.Label L_OWSCDesc;
    private System.Windows.Forms.TabPage tb_RAW;
    private System.Windows.Forms.Label L_MSSCDesc;
    private System.Windows.Forms.RichTextBox RTB_MS;
    private System.Windows.Forms.Label L_WarpDest;
    private System.Windows.Forms.NumericUpDown NUD_NID;
    private System.Windows.Forms.Label L_NID;
    private System.Windows.Forms.Label L_ZDPreview;
    private System.Windows.Forms.RichTextBox RTB_OS;
    private System.Windows.Forms.RichTextBox RTB_MSCMD;
    private System.Windows.Forms.Label L_Encounters;
    private System.Windows.Forms.Label L_ZDMaster;
    private System.Windows.Forms.Label L_File5;
    private System.Windows.Forms.Label L_File4;
    private System.Windows.Forms.Label L_File2;
    private System.Windows.Forms.Label L_File1;
    private System.Windows.Forms.Label L_File3;
    private System.Windows.Forms.Label L_MapInfoTabData;
    private System.Windows.Forms.Label L_File5TabData;
    private System.Windows.Forms.Label L_OWEntities;
    private System.Windows.Forms.RichTextBox RTB_OSP;
    private System.Windows.Forms.RichTextBox RTB_MSP;
    private System.Windows.Forms.Button B_HLCMD;
    private System.Windows.Forms.GroupBox GB_N;
    private System.Windows.Forms.NumericUpDown NUD_NModel;
    private System.Windows.Forms.Label L_NModel;
    private System.Windows.Forms.NumericUpDown NUD_NY;
    private System.Windows.Forms.Label L_NY;
    private System.Windows.Forms.NumericUpDown NUD_NX;
    private System.Windows.Forms.Label L_NX;
    private System.Windows.Forms.NumericUpDown NUD_NFace;
    private System.Windows.Forms.Label L_NFaceDirection;
    private System.Windows.Forms.NumericUpDown NUD_NScript;
    private System.Windows.Forms.Label L_NScript;
    private System.Windows.Forms.NumericUpDown NUD_NFlag;
    private System.Windows.Forms.Label L_NFlag;
    private System.Windows.Forms.NumericUpDown NUD_UnkCount;
    private System.Windows.Forms.Label L_Unk;
    private System.Windows.Forms.TabPage tb_Trigger2;
    private System.Windows.Forms.NumericUpDown NUD_UE;
    private System.Windows.Forms.Label L_UE;
    private System.Windows.Forms.Label L_ModelAsHex;
    private System.Windows.Forms.GroupBox GB_F;
    private System.Windows.Forms.GroupBox GB_W;
    private System.Windows.Forms.RichTextBox RTB_W;
    private System.Windows.Forms.GroupBox GB_T1;
    private System.Windows.Forms.RichTextBox RTB_T1;
    private System.Windows.Forms.GroupBox GB_T2;
    private System.Windows.Forms.RichTextBox RTB_T2;
    private System.Windows.Forms.TabPage tb_Dev;
    private System.Windows.Forms.Button B_DumpUnk;
    private System.Windows.Forms.Button B_DumpTrigger;
    private System.Windows.Forms.Button B_DumpWarp;
    private System.Windows.Forms.Button B_DumpNPC;
    private System.Windows.Forms.Button B_DumpFurniture;
    private System.Windows.Forms.Button B_DumpMaps;
    private System.Windows.Forms.Label L_Comp;
    private System.Windows.Forms.Label L_DeComp;
    private System.Windows.Forms.RichTextBox RTB_CompressedScript;
    private System.Windows.Forms.RichTextBox RTB_DecompressedScript;
    private System.Windows.Forms.NumericUpDown NUD_NRange;
    private System.Windows.Forms.Label L_Range;
    private System.Windows.Forms.TextBox TB_NDeg;
    private System.Windows.Forms.Label L_NDeg;
    private System.Windows.Forms.TextBox TB_Leash;
    private System.Windows.Forms.Label L_LeashInfo;
    private System.Windows.Forms.NumericUpDown NUD_NMove2;
    private System.Windows.Forms.Label L_Move2;
    private System.Windows.Forms.NumericUpDown NUD_NMove1;
    private System.Windows.Forms.Label L_Move1;
    private System.Windows.Forms.Label L_WpY;
    private System.Windows.Forms.Label L_WpX;
    private System.Windows.Forms.NumericUpDown NUD_WY;
    private System.Windows.Forms.Label L_WY;
    private System.Windows.Forms.NumericUpDown NUD_WX;
    private System.Windows.Forms.Label L_WX;
    private System.Windows.Forms.NumericUpDown NUD_FWY;
    private System.Windows.Forms.Label L_FWY;
    private System.Windows.Forms.NumericUpDown NUD_FWX;
    private System.Windows.Forms.Label L_FWX;
    private System.Windows.Forms.NumericUpDown NUD_FY;
    private System.Windows.Forms.Label L_FY;
    private System.Windows.Forms.NumericUpDown NUD_FX;
    private System.Windows.Forms.Label L_FX;
    private System.Windows.Forms.NumericUpDown NUD_T1Y;
    private System.Windows.Forms.Label L_T1Y;
    private System.Windows.Forms.NumericUpDown NUD_T1X;
    private System.Windows.Forms.Label L_T1X;
    private System.Windows.Forms.NumericUpDown NUD_T2Y;
    private System.Windows.Forms.Label L_T2Y;
    private System.Windows.Forms.NumericUpDown NUD_T2X;
    private System.Windows.Forms.Label L_T2X;
    private System.Windows.Forms.Button B_Map;
    private System.Windows.Forms.Label L_ZD;
    private System.Windows.Forms.Button B_DumpZD;
    private System.Windows.Forms.CheckBox CHK_EditRAW;
    private System.Windows.Forms.Button B_ResetNPC;
    private System.Windows.Forms.Button B_ResetOverworlds;
    private System.Windows.Forms.Button B_ResetFurniture;
    private System.Windows.Forms.Button B_ResetWarp;
    private System.Windows.Forms.Button B_ResetTrigger1;
    private System.Windows.Forms.Button B_ResetTrigger2;
}
