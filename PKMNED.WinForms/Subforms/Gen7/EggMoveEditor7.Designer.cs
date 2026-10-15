namespace PKMNED.WinForms;

partial class EggMoveEditor7
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EggMoveEditor7));
        dgv = new System.Windows.Forms.DataGridView();
        CB_Species = new System.Windows.Forms.ComboBox();
        L_Species = new System.Windows.Forms.Label();
        B_RandAll = new System.Windows.Forms.Button();
        B_Dump = new System.Windows.Forms.Button();
        groupBox1 = new System.Windows.Forms.GroupBox();
        L_Moves = new System.Windows.Forms.Label();
        NUD_Moves = new System.Windows.Forms.NumericUpDown();
        CHK_Expand = new System.Windows.Forms.CheckBox();
        L_STAB = new System.Windows.Forms.Label();
        NUD_STAB = new System.Windows.Forms.NumericUpDown();
        CHK_STAB = new System.Windows.Forms.CheckBox();
        PB_MonSprite = new System.Windows.Forms.PictureBox();
        NUD_FormTable = new System.Windows.Forms.NumericUpDown();
        label1 = new System.Windows.Forms.Label();
        B_Goto = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_Moves).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_STAB).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PB_MonSprite).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_FormTable).BeginInit();
        SuspendLayout();
        // 
        // dgv
        // 
        dgv.AllowUserToResizeColumns = false;
        dgv.AllowUserToResizeRows = false;
        dgv.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        dgv.BackgroundColor = System.Drawing.Color.FromArgb(30, 41, 59);
        dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv.Location = new System.Drawing.Point(14, 53);
        dgv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        dgv.Name = "dgv";
        dgv.Size = new System.Drawing.Size(329, 469);
        dgv.TabIndex = 0;
        // 
        // CB_Species
        // 
        CB_Species.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
        CB_Species.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        CB_Species.FormattingEnabled = true;
        CB_Species.Location = new System.Drawing.Point(77, 16);
        CB_Species.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CB_Species.Name = "CB_Species";
        CB_Species.Size = new System.Drawing.Size(140, 25);
        CB_Species.TabIndex = 1;
        CB_Species.SelectedIndexChanged += ChangeEntry;
        // 
        // L_Species
        // 
        L_Species.AutoSize = true;
        L_Species.Location = new System.Drawing.Point(14, 19);
        L_Species.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Species.Name = "L_Species";
        L_Species.Size = new System.Drawing.Size(56, 19);
        L_Species.TabIndex = 2;
        L_Species.Text = "Species:";
        // 
        // B_RandAll
        // 
        B_RandAll.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_RandAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_RandAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_RandAll.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_RandAll.ForeColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_RandAll.Location = new System.Drawing.Point(350, 493);
        B_RandAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_RandAll.Name = "B_RandAll";
        B_RandAll.Size = new System.Drawing.Size(111, 31);
        B_RandAll.TabIndex = 4;
        B_RandAll.Text = "Randomize!";
        B_RandAll.UseVisualStyleBackColor = false;
        B_RandAll.Click += B_RandAll_Click;
        // 
        // B_Dump
        // 
        B_Dump.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_Dump.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_Dump.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Dump.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Dump.ForeColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_Dump.Location = new System.Drawing.Point(350, 203);
        B_Dump.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Dump.Name = "B_Dump";
        B_Dump.Size = new System.Drawing.Size(111, 31);
        B_Dump.TabIndex = 5;
        B_Dump.Text = "Dump All";
        B_Dump.UseVisualStyleBackColor = false;
        B_Dump.Click += B_Dump_Click;
        // 
        // groupBox1
        // 
        groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        groupBox1.Controls.Add(L_Moves);
        groupBox1.Controls.Add(NUD_Moves);
        groupBox1.Controls.Add(CHK_Expand);
        groupBox1.Controls.Add(L_STAB);
        groupBox1.Controls.Add(NUD_STAB);
        groupBox1.Controls.Add(CHK_STAB);
        groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
        groupBox1.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        groupBox1.Location = new System.Drawing.Point(350, 240);
        groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        groupBox1.Size = new System.Drawing.Size(111, 245);
        groupBox1.TabIndex = 7;
        groupBox1.TabStop = false;
        groupBox1.Text = "Options";
        // 
        // L_Moves
        // 
        L_Moves.AutoSize = true;
        L_Moves.Location = new System.Drawing.Point(5, 170);
        L_Moves.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Moves.Name = "L_Moves";
        L_Moves.Size = new System.Drawing.Size(53, 19);
        L_Moves.TabIndex = 10;
        L_Moves.Text = "Moves:";
        // 
        // NUD_Moves
        // 
        NUD_Moves.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_Moves.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_Moves.Location = new System.Drawing.Point(62, 168);
        NUD_Moves.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_Moves.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
        NUD_Moves.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
        NUD_Moves.Name = "NUD_Moves";
        NUD_Moves.Size = new System.Drawing.Size(42, 25);
        NUD_Moves.TabIndex = 9;
        NUD_Moves.Value = new decimal(new int[] { 18, 0, 0, 0 });
        // 
        // CHK_Expand
        // 
        CHK_Expand.AutoSize = true;
        CHK_Expand.Location = new System.Drawing.Point(6, 144);
        CHK_Expand.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_Expand.Name = "CHK_Expand";
        CHK_Expand.Size = new System.Drawing.Size(102, 23);
        CHK_Expand.TabIndex = 8;
        CHK_Expand.Text = "Expand Pool";
        CHK_Expand.UseVisualStyleBackColor = true;
        // 
        // L_STAB
        // 
        L_STAB.AutoSize = true;
        L_STAB.Location = new System.Drawing.Point(4, 96);
        L_STAB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_STAB.Name = "L_STAB";
        L_STAB.Size = new System.Drawing.Size(54, 19);
        L_STAB.TabIndex = 3;
        L_STAB.Text = "% STAB";
        // 
        // NUD_STAB
        // 
        NUD_STAB.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_STAB.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_STAB.Location = new System.Drawing.Point(62, 94);
        NUD_STAB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_STAB.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
        NUD_STAB.Name = "NUD_STAB";
        NUD_STAB.Size = new System.Drawing.Size(42, 25);
        NUD_STAB.TabIndex = 2;
        NUD_STAB.Value = new decimal(new int[] { 32, 0, 0, 0 });
        // 
        // CHK_STAB
        // 
        CHK_STAB.AutoSize = true;
        CHK_STAB.Location = new System.Drawing.Point(6, 70);
        CHK_STAB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_STAB.Name = "CHK_STAB";
        CHK_STAB.Size = new System.Drawing.Size(103, 23);
        CHK_STAB.TabIndex = 1;
        CHK_STAB.Text = "Bias by Type";
        CHK_STAB.UseVisualStyleBackColor = true;
        // 
        // PB_MonSprite
        // 
        PB_MonSprite.Location = new System.Drawing.Point(225, 7);
        PB_MonSprite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        PB_MonSprite.Name = "PB_MonSprite";
        PB_MonSprite.Size = new System.Drawing.Size(47, 40);
        PB_MonSprite.TabIndex = 91;
        PB_MonSprite.TabStop = false;
        // 
        // NUD_FormTable
        // 
        NUD_FormTable.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_FormTable.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_FormTable.Location = new System.Drawing.Point(356, 55);
        NUD_FormTable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_FormTable.Name = "NUD_FormTable";
        NUD_FormTable.Size = new System.Drawing.Size(55, 25);
        NUD_FormTable.TabIndex = 92;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new System.Drawing.Point(317, 26);
        label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(130, 19);
        label1.TabIndex = 93;
        label1.Text = "FormTableReference";
        // 
        // B_Goto
        // 
        B_Goto.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_Goto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_Goto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Goto.ForeColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_Goto.Location = new System.Drawing.Point(356, 86);
        B_Goto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Goto.Name = "B_Goto";
        B_Goto.Size = new System.Drawing.Size(55, 32);
        B_Goto.TabIndex = 94;
        B_Goto.Text = "Goto!";
        B_Goto.UseVisualStyleBackColor = false;
        B_Goto.Click += B_Goto_Click;
        // 
        // EggMoveEditor7
        //
        dgv.ForeColor = System.Drawing.Color.Black;
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        ClientSize = new System.Drawing.Size(471, 538);
        Controls.Add(B_Goto);
        Controls.Add(label1);
        Controls.Add(NUD_FormTable);
        Controls.Add(PB_MonSprite);
        Controls.Add(groupBox1);
        Controls.Add(B_Dump);
        Controls.Add(B_RandAll);
        Controls.Add(L_Species);
        Controls.Add(CB_Species);
        Controls.Add(dgv);
        Font = new System.Drawing.Font("Segoe UI", 10F);
        ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MinimumSize = new System.Drawing.Size(373, 576);
        Name = "EggMoveEditor7";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Egg Move Editor";
        FormClosing += Form_Closing;
        ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_Moves).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_STAB).EndInit();
        ((System.ComponentModel.ISupportInitialize)PB_MonSprite).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_FormTable).EndInit();
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dgv;
    private System.Windows.Forms.ComboBox CB_Species;
    private System.Windows.Forms.Label L_Species;
    private System.Windows.Forms.Button B_RandAll;
    private System.Windows.Forms.Button B_Dump;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label L_Moves;
    private System.Windows.Forms.NumericUpDown NUD_Moves;
    private System.Windows.Forms.CheckBox CHK_Expand;
    private System.Windows.Forms.Label L_STAB;
    private System.Windows.Forms.NumericUpDown NUD_STAB;
    private System.Windows.Forms.CheckBox CHK_STAB;
    private System.Windows.Forms.PictureBox PB_MonSprite;
    private System.Windows.Forms.NumericUpDown NUD_FormTable;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button B_Goto;
}
