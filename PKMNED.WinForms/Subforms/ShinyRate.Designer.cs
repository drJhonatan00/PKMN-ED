namespace PKMNED.WinForms;

partial class ShinyRate
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShinyRate));
        L_Note = new System.Windows.Forms.Label();
        NUD_Rerolls = new System.Windows.Forms.NumericUpDown();
        L_Overall = new System.Windows.Forms.Label();
        B_Cancel = new System.Windows.Forms.Button();
        B_Save = new System.Windows.Forms.Button();
        L_Rerolls = new System.Windows.Forms.Label();
        B_RestoreOriginal = new System.Windows.Forms.Button();
        NUD_Rate = new System.Windows.Forms.NumericUpDown();
        L_RerollCount = new System.Windows.Forms.Label();
        L_RerollOverall = new System.Windows.Forms.Label();
        GB_RerollHelper = new System.Windows.Forms.GroupBox();
        GB_Rerolls = new System.Windows.Forms.GroupBox();
        label1 = new System.Windows.Forms.Label();
        CHK_EverythingShiny = new System.Windows.Forms.CheckBox();
        ((System.ComponentModel.ISupportInitialize)NUD_Rerolls).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Rate).BeginInit();
        GB_RerollHelper.SuspendLayout();
        GB_Rerolls.SuspendLayout();
        SuspendLayout();
        // 
        // L_Note
        // 
        L_Note.AutoSize = true;
        L_Note.Location = new System.Drawing.Point(14, 11);
        L_Note.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Note.Name = "L_Note";
        L_Note.Size = new System.Drawing.Size(456, 133);
        L_Note.TabIndex = 0;
        L_Note.Text = resources.GetString("L_Note.Text");
        // 
        // NUD_Rerolls
        // 
        NUD_Rerolls.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_Rerolls.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_Rerolls.Location = new System.Drawing.Point(63, 27);
        NUD_Rerolls.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_Rerolls.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
        NUD_Rerolls.Name = "NUD_Rerolls";
        NUD_Rerolls.Size = new System.Drawing.Size(76, 25);
        NUD_Rerolls.TabIndex = 1;
        NUD_Rerolls.Value = new decimal(new int[] { 125, 0, 0, 0 });
        NUD_Rerolls.ValueChanged += ChangeRerolls;
        // 
        // L_Overall
        // 
        L_Overall.AutoSize = true;
        L_Overall.ForeColor = System.Drawing.SystemColors.ControlText;
        L_Overall.Location = new System.Drawing.Point(142, 31);
        L_Overall.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Overall.Name = "L_Overall";
        L_Overall.Size = new System.Drawing.Size(33, 19);
        L_Overall.TabIndex = 2;
        L_Overall.Text = "PCT";
        // 
        // B_Cancel
        // 
        B_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        B_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
        B_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Cancel.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Cancel.ForeColor = System.Drawing.Color.Red;
        B_Cancel.Location = new System.Drawing.Point(304, 369);
        B_Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Cancel.Name = "B_Cancel";
        B_Cancel.Size = new System.Drawing.Size(88, 31);
        B_Cancel.TabIndex = 4;
        B_Cancel.Text = "Cancel";
        B_Cancel.UseVisualStyleBackColor = true;
        B_Cancel.Click += B_Cancel_Click;
        // 
        // B_Save
        // 
        B_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        B_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(154, 205, 50);
        B_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Save.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Save.ForeColor = System.Drawing.Color.FromArgb(154, 205, 50);
        B_Save.Location = new System.Drawing.Point(398, 369);
        B_Save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Save.Name = "B_Save";
        B_Save.Size = new System.Drawing.Size(88, 31);
        B_Save.TabIndex = 3;
        B_Save.Text = "Save";
        B_Save.UseVisualStyleBackColor = true;
        B_Save.Click += B_Save_Click;
        // 
        // L_Rerolls
        // 
        L_Rerolls.AutoSize = true;
        L_Rerolls.Font = new System.Drawing.Font("Segoe UI", 10F);
        L_Rerolls.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        L_Rerolls.Location = new System.Drawing.Point(7, 31);
        L_Rerolls.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Rerolls.Name = "L_Rerolls";
        L_Rerolls.Size = new System.Drawing.Size(52, 19);
        L_Rerolls.TabIndex = 5;
        L_Rerolls.Text = "Rerolls:";
        // 
        // B_RestoreOriginal
        // 
        B_RestoreOriginal.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        B_RestoreOriginal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_RestoreOriginal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_RestoreOriginal.ForeColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_RestoreOriginal.Location = new System.Drawing.Point(18, 369);
        B_RestoreOriginal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_RestoreOriginal.Name = "B_RestoreOriginal";
        B_RestoreOriginal.Size = new System.Drawing.Size(196, 31);
        B_RestoreOriginal.TabIndex = 6;
        B_RestoreOriginal.Text = "Restore Original Rate";
        B_RestoreOriginal.UseVisualStyleBackColor = true;
        B_RestoreOriginal.Click += B_RestoreOriginal_Click;
        // 
        // NUD_Rate
        // 
        NUD_Rate.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_Rate.DecimalPlaces = 2;
        NUD_Rate.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_Rate.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
        NUD_Rate.Location = new System.Drawing.Point(94, 17);
        NUD_Rate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_Rate.Name = "NUD_Rate";
        NUD_Rate.Size = new System.Drawing.Size(76, 25);
        NUD_Rate.TabIndex = 7;
        NUD_Rate.ValueChanged += ChangePercent;
        // 
        // L_RerollCount
        // 
        L_RerollCount.AutoSize = true;
        L_RerollCount.Location = new System.Drawing.Point(54, 48);
        L_RerollCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_RerollCount.Name = "L_RerollCount";
        L_RerollCount.Size = new System.Drawing.Size(62, 19);
        L_RerollCount.TabIndex = 8;
        L_RerollCount.Text = "Count: 0";
        // 
        // L_RerollOverall
        // 
        L_RerollOverall.AutoSize = true;
        L_RerollOverall.Location = new System.Drawing.Point(28, 19);
        L_RerollOverall.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_RerollOverall.Name = "L_RerollOverall";
        L_RerollOverall.Size = new System.Drawing.Size(66, 19);
        L_RerollOverall.TabIndex = 9;
        L_RerollOverall.Text = "Overall%:";
        // 
        // GB_RerollHelper
        // 
        GB_RerollHelper.Controls.Add(NUD_Rate);
        GB_RerollHelper.Controls.Add(L_RerollOverall);
        GB_RerollHelper.Controls.Add(L_RerollCount);
        GB_RerollHelper.Font = new System.Drawing.Font("Segoe UI", 10F);
        GB_RerollHelper.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        GB_RerollHelper.Location = new System.Drawing.Point(268, 163);
        GB_RerollHelper.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        GB_RerollHelper.Name = "GB_RerollHelper";
        GB_RerollHelper.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        GB_RerollHelper.Size = new System.Drawing.Size(182, 69);
        GB_RerollHelper.TabIndex = 11;
        GB_RerollHelper.TabStop = false;
        GB_RerollHelper.Text = "Reroll Helper";
        // 
        // GB_Rerolls
        // 
        GB_Rerolls.Controls.Add(NUD_Rerolls);
        GB_Rerolls.Controls.Add(L_Rerolls);
        GB_Rerolls.Controls.Add(L_Overall);
        GB_Rerolls.ForeColor = System.Drawing.Color.Red;
        GB_Rerolls.Location = new System.Drawing.Point(39, 163);
        GB_Rerolls.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        GB_Rerolls.Name = "GB_Rerolls";
        GB_Rerolls.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        GB_Rerolls.Size = new System.Drawing.Size(200, 69);
        GB_Rerolls.TabIndex = 12;
        GB_Rerolls.TabStop = false;
        GB_Rerolls.Text = "PID Generation Loop Rerolls";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new System.Drawing.Point(7, 265);
        label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(340, 76);
        label1.TabIndex = 13;
        label1.Text = "Note:\r\nThe above reroll count will overwrite the existing code.\r\n\r\nTo revert changes, use the button below.";
        // 
        // CHK_EverythingShiny
        // 
        CHK_EverythingShiny.AutoSize = true;
        CHK_EverythingShiny.Location = new System.Drawing.Point(379, 288);
        CHK_EverythingShiny.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_EverythingShiny.Name = "CHK_EverythingShiny";
        CHK_EverythingShiny.Size = new System.Drawing.Size(108, 42);
        CHK_EverythingShiny.TabIndex = 14;
        CHK_EverythingShiny.Text = "EVERYTHING\r\nSHINY";
        CHK_EverythingShiny.UseVisualStyleBackColor = true;
        // 
        // ShinyRate
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        ClientSize = new System.Drawing.Size(500, 416);
        Controls.Add(CHK_EverythingShiny);
        Controls.Add(label1);
        Controls.Add(GB_Rerolls);
        Controls.Add(GB_RerollHelper);
        Controls.Add(B_RestoreOriginal);
        Controls.Add(B_Cancel);
        Controls.Add(B_Save);
        Controls.Add(L_Note);
        Font = new System.Drawing.Font("Segoe UI", 10F);
        ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "ShinyRate";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Shiny Rate Editor";
        ((System.ComponentModel.ISupportInitialize)NUD_Rerolls).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Rate).EndInit();
        GB_RerollHelper.ResumeLayout(false);
        GB_RerollHelper.PerformLayout();
        GB_Rerolls.ResumeLayout(false);
        GB_Rerolls.PerformLayout();
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label L_Note;
    private System.Windows.Forms.NumericUpDown NUD_Rerolls;
    private System.Windows.Forms.Label L_Overall;
    private System.Windows.Forms.Button B_Cancel;
    private System.Windows.Forms.Button B_Save;
    private System.Windows.Forms.Label L_Rerolls;
    private System.Windows.Forms.Button B_RestoreOriginal;
    private System.Windows.Forms.NumericUpDown NUD_Rate;
    private System.Windows.Forms.Label L_RerollCount;
    private System.Windows.Forms.Label L_RerollOverall;
    private System.Windows.Forms.GroupBox GB_RerollHelper;
    private System.Windows.Forms.GroupBox GB_Rerolls;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.CheckBox CHK_EverythingShiny;
}
