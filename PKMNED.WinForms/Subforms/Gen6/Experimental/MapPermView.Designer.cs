namespace PKMNED.WinForms;

partial class MapPermView
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapPermView));
        L_MapCoord = new System.Windows.Forms.Label();
        PAN_MAP = new System.Windows.Forms.Panel();
        PB_Map = new System.Windows.Forms.PictureBox();
        CHK_AutoDraw = new System.Windows.Forms.CheckBox();
        B_Redraw = new System.Windows.Forms.Button();
        L_Scale = new System.Windows.Forms.Label();
        NUD_Scale = new System.Windows.Forms.NumericUpDown();
        L_Flavor = new System.Windows.Forms.Label();
        NUD_Flavor = new System.Windows.Forms.NumericUpDown();
        PAN_MAP.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)PB_Map).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Scale).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Flavor).BeginInit();
        SuspendLayout();
        // 
        // L_MapCoord
        // 
        L_MapCoord.Font = new System.Drawing.Font("Segoe UI", 10F);
        L_MapCoord.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        L_MapCoord.Location = new System.Drawing.Point(454, 2);
        L_MapCoord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_MapCoord.Name = "L_MapCoord";
        L_MapCoord.Size = new System.Drawing.Size(102, 48);
        L_MapCoord.TabIndex = 20;
        L_MapCoord.Text = "V:0x00000000\r\nX:  1  Y:  1";
        L_MapCoord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // PAN_MAP
        // 
        PAN_MAP.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        PAN_MAP.AutoScroll = true;
        PAN_MAP.Controls.Add(PB_Map);
        PAN_MAP.Location = new System.Drawing.Point(10, 53);
        PAN_MAP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        PAN_MAP.Name = "PAN_MAP";
        PAN_MAP.Size = new System.Drawing.Size(548, 479);
        PAN_MAP.TabIndex = 19;
        // 
        // PB_Map
        // 
        PB_Map.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        PB_Map.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        PB_Map.Location = new System.Drawing.Point(0, 0);
        PB_Map.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        PB_Map.Name = "PB_Map";
        PB_Map.Size = new System.Drawing.Size(470, 430);
        PB_Map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
        PB_Map.TabIndex = 2;
        PB_Map.TabStop = false;
        PB_Map.DoubleClick += DclickMap;
        PB_Map.MouseEnter += FocusPanel;
        PB_Map.MouseMove += HoverMap;
        // 
        // CHK_AutoDraw
        // 
        CHK_AutoDraw.AutoSize = true;
        CHK_AutoDraw.Font = new System.Drawing.Font("Segoe UI", 10F);
        CHK_AutoDraw.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        CHK_AutoDraw.Location = new System.Drawing.Point(332, 15);
        CHK_AutoDraw.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_AutoDraw.Name = "CHK_AutoDraw";
        CHK_AutoDraw.Size = new System.Drawing.Size(96, 23);
        CHK_AutoDraw.TabIndex = 18;
        CHK_AutoDraw.Text = "Auto-Draw";
        CHK_AutoDraw.UseVisualStyleBackColor = true;
        // 
        // B_Redraw
        // 
        B_Redraw.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        B_Redraw.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_Redraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Redraw.ForeColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_Redraw.Location = new System.Drawing.Point(227, 13);
        B_Redraw.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Redraw.Name = "B_Redraw";
        B_Redraw.Size = new System.Drawing.Size(88, 27);
        B_Redraw.TabIndex = 17;
        B_Redraw.Text = "Redraw";
        B_Redraw.UseVisualStyleBackColor = false;
        B_Redraw.Click += B_Redraw_Click;
        // 
        // L_Scale
        // 
        L_Scale.AutoSize = true;
        L_Scale.Font = new System.Drawing.Font("Segoe UI", 10F);
        L_Scale.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        L_Scale.Location = new System.Drawing.Point(117, 17);
        L_Scale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Scale.Name = "L_Scale";
        L_Scale.Size = new System.Drawing.Size(42, 19);
        L_Scale.TabIndex = 16;
        L_Scale.Text = "Scale:";
        // 
        // NUD_Scale
        // 
        NUD_Scale.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_Scale.Font = new System.Drawing.Font("Segoe UI", 10F);
        NUD_Scale.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_Scale.Location = new System.Drawing.Point(167, 15);
        NUD_Scale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_Scale.Maximum = new decimal(new int[] { 16, 0, 0, 0 });
        NUD_Scale.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        NUD_Scale.Name = "NUD_Scale";
        NUD_Scale.Size = new System.Drawing.Size(43, 25);
        NUD_Scale.TabIndex = 15;
        NUD_Scale.Value = new decimal(new int[] { 8, 0, 0, 0 });
        // 
        // L_Flavor
        // 
        L_Flavor.AutoSize = true;
        L_Flavor.Font = new System.Drawing.Font("Segoe UI", 10F);
        L_Flavor.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        L_Flavor.Location = new System.Drawing.Point(14, 17);
        L_Flavor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Flavor.Name = "L_Flavor";
        L_Flavor.Size = new System.Drawing.Size(49, 19);
        L_Flavor.TabIndex = 14;
        L_Flavor.Text = "Flavor:";
        // 
        // NUD_Flavor
        // 
        NUD_Flavor.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_Flavor.Font = new System.Drawing.Font("Segoe UI", 10F);
        NUD_Flavor.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_Flavor.Location = new System.Drawing.Point(66, 15);
        NUD_Flavor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_Flavor.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        NUD_Flavor.Name = "NUD_Flavor";
        NUD_Flavor.Size = new System.Drawing.Size(43, 25);
        NUD_Flavor.TabIndex = 13;
        NUD_Flavor.Value = new decimal(new int[] { 5, 0, 0, 0 });
        // 
        // MapPermView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        ClientSize = new System.Drawing.Size(570, 539);
        Controls.Add(L_MapCoord);
        Controls.Add(PAN_MAP);
        Controls.Add(CHK_AutoDraw);
        Controls.Add(B_Redraw);
        Controls.Add(L_Scale);
        Controls.Add(NUD_Scale);
        Controls.Add(L_Flavor);
        Controls.Add(NUD_Flavor);
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        MinimumSize = new System.Drawing.Size(586, 577);
        Name = "MapPermView";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Map Viewer";
        FormClosing += MapPermView_FormClosing;
        PAN_MAP.ResumeLayout(false);
        PAN_MAP.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)PB_Map).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Scale).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Flavor).EndInit();
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label L_MapCoord;
    private System.Windows.Forms.Panel PAN_MAP;
    private System.Windows.Forms.PictureBox PB_Map;
    private System.Windows.Forms.CheckBox CHK_AutoDraw;
    private System.Windows.Forms.Button B_Redraw;
    private System.Windows.Forms.Label L_Scale;
    private System.Windows.Forms.NumericUpDown NUD_Scale;
    private System.Windows.Forms.Label L_Flavor;
    private System.Windows.Forms.NumericUpDown NUD_Flavor;

}
