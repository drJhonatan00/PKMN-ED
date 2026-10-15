namespace PKMNED.WinForms;

partial class TextEditor
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor));
        CB_Entry = new System.Windows.Forms.ComboBox();
        dgv = new System.Windows.Forms.DataGridView();
        B_AddLine = new System.Windows.Forms.Button();
        B_RemoveLine = new System.Windows.Forms.Button();
        B_Export = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        B_Import = new System.Windows.Forms.Button();
        B_Randomize = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
        SuspendLayout();
        // 
        // CB_Entry
        // 
        CB_Entry.FormattingEnabled = true;
        CB_Entry.Location = new System.Drawing.Point(79, 8);
        CB_Entry.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CB_Entry.Name = "CB_Entry";
        CB_Entry.Size = new System.Drawing.Size(93, 23);
        CB_Entry.TabIndex = 5;
        CB_Entry.SelectedIndexChanged += ChangeEntry;
        // 
        // dgv
        // 
        dgv.AllowUserToAddRows = false;
        dgv.AllowUserToDeleteRows = false;
        dgv.AllowUserToResizeRows = false;
        dgv.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        dgv.BackgroundColor = System.Drawing.Color.FromArgb(15, 23, 42);
        dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv.Font = new System.Drawing.Font("Segoe UI", 10F);
        dgv.Location = new System.Drawing.Point(14, 38);
        dgv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        dgv.Name = "dgv";
        dgv.RowHeadersVisible = false;
        dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
        dgv.ShowEditingIcon = false;
        dgv.Size = new System.Drawing.Size(955, 374);
        dgv.TabIndex = 0;
        // 
        // B_AddLine
        // 
        B_AddLine.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        B_AddLine.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_AddLine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(192, 255, 192);
        B_AddLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_AddLine.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_AddLine.ForeColor = System.Drawing.Color.FromArgb(192, 255, 192);
        B_AddLine.Location = new System.Drawing.Point(753, 7);
        B_AddLine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_AddLine.Name = "B_AddLine";
        B_AddLine.Size = new System.Drawing.Size(105, 27);
        B_AddLine.TabIndex = 6;
        B_AddLine.Text = "Add Line After";
        B_AddLine.UseVisualStyleBackColor = false;
        B_AddLine.Click += B_AddLine_Click;
        // 
        // B_RemoveLine
        // 
        B_RemoveLine.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        B_RemoveLine.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_RemoveLine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(255, 128, 128);
        B_RemoveLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_RemoveLine.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_RemoveLine.ForeColor = System.Drawing.Color.FromArgb(255, 128, 128);
        B_RemoveLine.Location = new System.Drawing.Point(865, 7);
        B_RemoveLine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_RemoveLine.Name = "B_RemoveLine";
        B_RemoveLine.Size = new System.Drawing.Size(105, 27);
        B_RemoveLine.TabIndex = 7;
        B_RemoveLine.Text = "Remove Line";
        B_RemoveLine.UseVisualStyleBackColor = false;
        B_RemoveLine.Click += B_RemoveLine_Click;
        // 
        // B_Export
        // 
        B_Export.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_Export.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Export.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Export.ForeColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_Export.Location = new System.Drawing.Point(180, 7);
        B_Export.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Export.Name = "B_Export";
        B_Export.Size = new System.Drawing.Size(105, 27);
        B_Export.TabIndex = 8;
        B_Export.Text = "Export All (.txt)";
        B_Export.UseVisualStyleBackColor = false;
        B_Export.Click += B_Export_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new System.Drawing.Font("Segoe UI", 10F);
        label1.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        label1.Location = new System.Drawing.Point(14, 12);
        label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(60, 19);
        label1.TabIndex = 9;
        label1.Text = "Text File:";
        // 
        // B_Import
        // 
        B_Import.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_Import.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_Import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Import.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Import.ForeColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_Import.Location = new System.Drawing.Point(292, 7);
        B_Import.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Import.Name = "B_Import";
        B_Import.Size = new System.Drawing.Size(105, 27);
        B_Import.TabIndex = 10;
        B_Import.Text = "Import All (.txt)";
        B_Import.UseVisualStyleBackColor = false;
        B_Import.Click += B_Import_Click;
        // 
        // B_Randomize
        // 
        B_Randomize.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_Randomize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(192, 192, 255);
        B_Randomize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Randomize.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Randomize.ForeColor = System.Drawing.Color.FromArgb(192, 192, 255);
        B_Randomize.Location = new System.Drawing.Point(535, 7);
        B_Randomize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Randomize.Name = "B_Randomize";
        B_Randomize.Size = new System.Drawing.Size(100, 27);
        B_Randomize.TabIndex = 11;
        B_Randomize.Text = "Randomize";
        B_Randomize.UseVisualStyleBackColor = false;
        B_Randomize.Click += B_Randomize_Click;
        // 
        // TextEditor
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        ClientSize = new System.Drawing.Size(983, 426);
        Controls.Add(B_Randomize);
        Controls.Add(B_Import);
        Controls.Add(label1);
        Controls.Add(B_Export);
        Controls.Add(B_RemoveLine);
        Controls.Add(B_AddLine);
        Controls.Add(dgv);
        Controls.Add(CB_Entry);
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        MinimumSize = new System.Drawing.Size(464, 340);
        Name = "TextEditor";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Text Editor";
        FormClosing += TextEditor_FormClosing;
        Load += TextEditor_Load;
        ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox CB_Entry;
    private System.Windows.Forms.DataGridView dgv;
    private System.Windows.Forms.Button B_AddLine;
    private System.Windows.Forms.Button B_RemoveLine;
    private System.Windows.Forms.Button B_Export;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button B_Import;
    private System.Windows.Forms.Button B_Randomize;
}
