namespace PKMNED.WinForms;

partial class OWSE7
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OWSE7));
        L_Location = new System.Windows.Forms.Label();
        CB_LocationID = new System.Windows.Forms.ComboBox();
        tabControl1 = new System.Windows.Forms.TabControl();
        tab_7_ZS = new System.Windows.Forms.TabPage();
        L_7_Info = new System.Windows.Forms.Label();
        RTB_7_Parse = new System.Windows.Forms.RichTextBox();
        NUD_7_Count = new System.Windows.Forms.NumericUpDown();
        L_7_Count = new System.Windows.Forms.Label();
        RTB_7_Script = new System.Windows.Forms.RichTextBox();
        RTB_7_Raw = new System.Windows.Forms.RichTextBox();
        tab_8_ZI = new System.Windows.Forms.TabPage();
        L_8_Info = new System.Windows.Forms.Label();
        RTB_8_Parse = new System.Windows.Forms.RichTextBox();
        NUD_8_Count = new System.Windows.Forms.NumericUpDown();
        L_8_Count = new System.Windows.Forms.Label();
        RTB_8_Script = new System.Windows.Forms.RichTextBox();
        RTB_8_Raw = new System.Windows.Forms.RichTextBox();
        tabControl1.SuspendLayout();
        tab_7_ZS.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_7_Count).BeginInit();
        tab_8_ZI.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_8_Count).BeginInit();
        SuspendLayout();
        // 
        // L_Location
        // 
        L_Location.AutoSize = true;
        L_Location.Location = new System.Drawing.Point(14, 10);
        L_Location.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Location.Name = "L_Location";
        L_Location.Size = new System.Drawing.Size(29, 15);
        L_Location.TabIndex = 433;
        L_Location.Text = "Loc:";
        // 
        // CB_LocationID
        // 
        CB_LocationID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
        CB_LocationID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        CB_LocationID.FormattingEnabled = true;
        CB_LocationID.Location = new System.Drawing.Point(54, 7);
        CB_LocationID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CB_LocationID.Name = "CB_LocationID";
        CB_LocationID.Size = new System.Drawing.Size(191, 23);
        CB_LocationID.TabIndex = 432;
        CB_LocationID.SelectedIndexChanged += CB_LocationID_SelectedIndexChanged;
        // 
        // tabControl1
        // 
        tabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        tabControl1.Controls.Add(tab_7_ZS);
        tabControl1.Controls.Add(tab_8_ZI);
        tabControl1.Location = new System.Drawing.Point(18, 38);
        tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new System.Drawing.Size(537, 538);
        tabControl1.TabIndex = 434;
        // 
        // tab_7_ZS
        // 
        tab_7_ZS.Controls.Add(L_7_Info);
        tab_7_ZS.Controls.Add(RTB_7_Parse);
        tab_7_ZS.Controls.Add(NUD_7_Count);
        tab_7_ZS.Controls.Add(L_7_Count);
        tab_7_ZS.Controls.Add(RTB_7_Script);
        tab_7_ZS.Controls.Add(RTB_7_Raw);
        tab_7_ZS.Location = new System.Drawing.Point(4, 24);
        tab_7_ZS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tab_7_ZS.Name = "tab_7_ZS";
        tab_7_ZS.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tab_7_ZS.Size = new System.Drawing.Size(529, 510);
        tab_7_ZS.TabIndex = 0;
        tab_7_ZS.Text = "7.ZS";
        tab_7_ZS.UseVisualStyleBackColor = true;
        // 
        // L_7_Info
        // 
        L_7_Info.AutoSize = true;
        L_7_Info.Location = new System.Drawing.Point(160, 284);
        L_7_Info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_7_Info.Name = "L_7_Info";
        L_7_Info.Size = new System.Drawing.Size(46, 15);
        L_7_Info.TabIndex = 438;
        L_7_Info.Text = "Count7";
        // 
        // RTB_7_Parse
        // 
        RTB_7_Parse.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        RTB_7_Parse.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        RTB_7_Parse.Location = new System.Drawing.Point(243, 239);
        RTB_7_Parse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        RTB_7_Parse.Name = "RTB_7_Parse";
        RTB_7_Parse.ReadOnly = true;
        RTB_7_Parse.Size = new System.Drawing.Size(277, 259);
        RTB_7_Parse.TabIndex = 437;
        RTB_7_Parse.Text = "Script CMDs";
        // 
        // NUD_7_Count
        // 
        NUD_7_Count.Location = new System.Drawing.Point(163, 257);
        NUD_7_Count.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_7_Count.Name = "NUD_7_Count";
        NUD_7_Count.Size = new System.Drawing.Size(72, 23);
        NUD_7_Count.TabIndex = 436;
        NUD_7_Count.ValueChanged += NUD_7_Count_ValueChanged;
        // 
        // L_7_Count
        // 
        L_7_Count.AutoSize = true;
        L_7_Count.Location = new System.Drawing.Point(160, 239);
        L_7_Count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_7_Count.Name = "L_7_Count";
        L_7_Count.Size = new System.Drawing.Size(46, 15);
        L_7_Count.TabIndex = 435;
        L_7_Count.Text = "Count7";
        // 
        // RTB_7_Script
        // 
        RTB_7_Script.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        RTB_7_Script.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        RTB_7_Script.Location = new System.Drawing.Point(7, 239);
        RTB_7_Script.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        RTB_7_Script.Name = "RTB_7_Script";
        RTB_7_Script.ReadOnly = true;
        RTB_7_Script.Size = new System.Drawing.Size(145, 259);
        RTB_7_Script.TabIndex = 431;
        RTB_7_Script.Text = "Script CMDs";
        // 
        // RTB_7_Raw
        // 
        RTB_7_Raw.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        RTB_7_Raw.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        RTB_7_Raw.Location = new System.Drawing.Point(7, 7);
        RTB_7_Raw.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        RTB_7_Raw.Name = "RTB_7_Raw";
        RTB_7_Raw.ReadOnly = true;
        RTB_7_Raw.Size = new System.Drawing.Size(513, 224);
        RTB_7_Raw.TabIndex = 430;
        RTB_7_Raw.Text = "Raw Data";
        // 
        // tab_8_ZI
        // 
        tab_8_ZI.Controls.Add(L_8_Info);
        tab_8_ZI.Controls.Add(RTB_8_Parse);
        tab_8_ZI.Controls.Add(NUD_8_Count);
        tab_8_ZI.Controls.Add(L_8_Count);
        tab_8_ZI.Controls.Add(RTB_8_Script);
        tab_8_ZI.Controls.Add(RTB_8_Raw);
        tab_8_ZI.Location = new System.Drawing.Point(4, 24);
        tab_8_ZI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tab_8_ZI.Name = "tab_8_ZI";
        tab_8_ZI.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tab_8_ZI.Size = new System.Drawing.Size(529, 510);
        tab_8_ZI.TabIndex = 1;
        tab_8_ZI.Text = "8.ZI";
        tab_8_ZI.UseVisualStyleBackColor = true;
        // 
        // L_8_Info
        // 
        L_8_Info.AutoSize = true;
        L_8_Info.Location = new System.Drawing.Point(160, 284);
        L_8_Info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_8_Info.Name = "L_8_Info";
        L_8_Info.Size = new System.Drawing.Size(46, 15);
        L_8_Info.TabIndex = 439;
        L_8_Info.Text = "Count8";
        // 
        // RTB_8_Parse
        // 
        RTB_8_Parse.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        RTB_8_Parse.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        RTB_8_Parse.Location = new System.Drawing.Point(243, 239);
        RTB_8_Parse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        RTB_8_Parse.Name = "RTB_8_Parse";
        RTB_8_Parse.ReadOnly = true;
        RTB_8_Parse.Size = new System.Drawing.Size(277, 259);
        RTB_8_Parse.TabIndex = 438;
        RTB_8_Parse.Text = "Script CMDs";
        // 
        // NUD_8_Count
        // 
        NUD_8_Count.Location = new System.Drawing.Point(163, 257);
        NUD_8_Count.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_8_Count.Name = "NUD_8_Count";
        NUD_8_Count.Size = new System.Drawing.Size(72, 23);
        NUD_8_Count.TabIndex = 435;
        NUD_8_Count.ValueChanged += NUD_8_Count_ValueChanged;
        // 
        // L_8_Count
        // 
        L_8_Count.AutoSize = true;
        L_8_Count.Location = new System.Drawing.Point(160, 239);
        L_8_Count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_8_Count.Name = "L_8_Count";
        L_8_Count.Size = new System.Drawing.Size(46, 15);
        L_8_Count.TabIndex = 434;
        L_8_Count.Text = "Count8";
        // 
        // RTB_8_Script
        // 
        RTB_8_Script.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        RTB_8_Script.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        RTB_8_Script.Location = new System.Drawing.Point(7, 239);
        RTB_8_Script.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        RTB_8_Script.Name = "RTB_8_Script";
        RTB_8_Script.ReadOnly = true;
        RTB_8_Script.Size = new System.Drawing.Size(145, 259);
        RTB_8_Script.TabIndex = 433;
        RTB_8_Script.Text = "Script CMDs";
        // 
        // RTB_8_Raw
        // 
        RTB_8_Raw.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        RTB_8_Raw.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        RTB_8_Raw.Location = new System.Drawing.Point(7, 7);
        RTB_8_Raw.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        RTB_8_Raw.Name = "RTB_8_Raw";
        RTB_8_Raw.ReadOnly = true;
        RTB_8_Raw.Size = new System.Drawing.Size(513, 224);
        RTB_8_Raw.TabIndex = 432;
        RTB_8_Raw.Text = "Raw Data";
        // 
        // OWSE7
        //

        var bg = System.Drawing.Color.FromArgb(15, 23, 42);
        var surface = System.Drawing.Color.FromArgb(30, 41, 59);
        var surface2 = System.Drawing.Color.FromArgb(36, 50, 91);
        var accent = System.Drawing.Color.FromArgb(56, 189, 248);
        var text = System.Drawing.Color.FromArgb(226, 232, 240);
        var muted = System.Drawing.Color.FromArgb(148, 163, 184);
        var font = new System.Drawing.Font("Segoe UI", 10F);
        var title = new System.Drawing.Font("Segoe UI Semibold", 11F);
        var midori = System.Drawing.Color.FromArgb(154, 205, 50);
        var aka = System.Drawing.Color.Red;
        var murasaki = System.Drawing.Color.FromArgb(166, 136, 210);


        BackColor = bg;
        ForeColor = text;
        Font = font;

        tab_7_ZS.BackColor = surface;
        tab_8_ZI.BackColor = surface;

        NUD_7_Count.ForeColor = text;
        NUD_7_Count.BackColor = surface;

        NUD_8_Count.ForeColor = text;
        NUD_8_Count.BackColor = surface;

        RTB_7_Raw.ForeColor = text;
        RTB_7_Raw.BackColor = surface2;
        RTB_7_Raw.BorderStyle = System.Windows.Forms.BorderStyle.None;
        RTB_7_Raw.Font = font;

        RTB_7_Script.ForeColor = text;
        RTB_7_Script.BackColor = surface2;
        RTB_7_Script.BorderStyle = System.Windows.Forms.BorderStyle.None;
        RTB_7_Script.Font = font;

        RTB_7_Parse.ForeColor = text;
        RTB_7_Parse.BackColor = surface2;
        RTB_7_Parse.BorderStyle = System.Windows.Forms.BorderStyle.None;
        RTB_7_Parse.Font = font;

        RTB_8_Raw.ForeColor = text;
        RTB_8_Raw.BackColor = surface2;
        RTB_8_Raw.BorderStyle = System.Windows.Forms.BorderStyle.None;
        RTB_8_Raw.Font = font;

        RTB_8_Script.ForeColor = text;
        RTB_8_Script.BackColor = surface2;
        RTB_8_Script.BorderStyle = System.Windows.Forms.BorderStyle.None;
        RTB_8_Script.Font = font;

        RTB_8_Parse.ForeColor = text;
        RTB_8_Parse.BackColor = surface2;
        RTB_8_Parse.BorderStyle = System.Windows.Forms.BorderStyle.None;
        RTB_8_Parse.Font = font;

        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(565, 590);
        Controls.Add(tabControl1);
        Controls.Add(L_Location);
        Controls.Add(CB_LocationID);
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        Name = "OWSE7";
        Text = "OWSE7";
        tabControl1.ResumeLayout(false);
        tab_7_ZS.ResumeLayout(false);
        tab_7_ZS.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_7_Count).EndInit();
        tab_8_ZI.ResumeLayout(false);
        tab_8_ZI.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_8_Count).EndInit();
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label L_Location;
    private System.Windows.Forms.ComboBox CB_LocationID;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tab_7_ZS;
    private System.Windows.Forms.TabPage tab_8_ZI;
    private System.Windows.Forms.RichTextBox RTB_7_Script;
    private System.Windows.Forms.RichTextBox RTB_7_Raw;
    private System.Windows.Forms.RichTextBox RTB_8_Script;
    private System.Windows.Forms.RichTextBox RTB_8_Raw;
    private System.Windows.Forms.Label L_8_Count;
    private System.Windows.Forms.Label L_7_Count;
    private System.Windows.Forms.NumericUpDown NUD_8_Count;
    private System.Windows.Forms.NumericUpDown NUD_7_Count;
    private System.Windows.Forms.RichTextBox RTB_7_Parse;
    private System.Windows.Forms.RichTextBox RTB_8_Parse;
    private System.Windows.Forms.Label L_7_Info;
    private System.Windows.Forms.Label L_8_Info;
}
