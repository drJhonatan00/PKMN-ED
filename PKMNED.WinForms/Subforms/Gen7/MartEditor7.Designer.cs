namespace PKMNED.WinForms;

partial class MartEditor7
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
        var midori = System.Drawing.Color.FromArgb(154, 205, 50);
        var aka = System.Drawing.Color.Red;
        var murasaki = System.Drawing.Color.FromArgb(166, 136, 210);

        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MartEditor7));
        CB_Location = new System.Windows.Forms.ComboBox();
        dgv = new System.Windows.Forms.DataGridView();
        dgvIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
        dgvItem = new System.Windows.Forms.DataGridViewComboBoxColumn();
        L_Mart = new System.Windows.Forms.Label();
        B_Randomize = new System.Windows.Forms.Button();
        B_Save = new System.Windows.Forms.Button();
        B_Cancel = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        CB_LocationBP = new System.Windows.Forms.ComboBox();
        B_RandomizeBP = new System.Windows.Forms.Button();
        dgvbp = new System.Windows.Forms.DataGridView();
        dgvIndexBP = new System.Windows.Forms.DataGridViewTextBoxColumn();
        dgvItemBP = new System.Windows.Forms.DataGridViewComboBoxColumn();
        dgvPriceBP = new System.Windows.Forms.DataGridViewTextBoxColumn();
        CHK_XItems = new System.Windows.Forms.CheckBox();
        ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvbp).BeginInit();
        SuspendLayout();
        // 
        // CB_Location
        // 
        CB_Location.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        CB_Location.FormattingEnabled = true;
        CB_Location.Location = new System.Drawing.Point(80, 7);
        CB_Location.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CB_Location.Name = "CB_Location";
        CB_Location.Size = new System.Drawing.Size(283, 23);
        CB_Location.TabIndex = 0;
        CB_Location.SelectedIndexChanged += ChangeIndex;
        // 
        // dgv
        // 
        dgv.AllowUserToAddRows = false;
        dgv.AllowUserToDeleteRows = false;
        dgv.AllowUserToResizeColumns = false;
        dgv.AllowUserToResizeRows = false;
        dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgvIndex, dgvItem });
        dgv.Location = new System.Drawing.Point(14, 38);
        dgv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        dgv.Name = "dgv";
        dgv.Size = new System.Drawing.Size(350, 328);
        dgv.TabIndex = 1;
        // 
        // dgvIndex
        // 
        dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
        dgvIndex.DefaultCellStyle = dataGridViewCellStyle1;
        dgvIndex.HeaderText = "Index";
        dgvIndex.Name = "dgvIndex";
        dgvIndex.ReadOnly = true;
        dgvIndex.Width = 45;
        // 
        // dgvItem
        // 
        dgvItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        dgvItem.HeaderText = "Item";
        dgvItem.Name = "dgvItem";
        dgvItem.Width = 135;
        // 
        // L_Mart
        // 
        L_Mart.AutoSize = true;
        L_Mart.Location = new System.Drawing.Point(14, 10);
        L_Mart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Mart.Name = "L_Mart";
        L_Mart.Size = new System.Drawing.Size(56, 15);
        L_Mart.TabIndex = 2;
        L_Mart.Text = "Location:";
        // 
        // B_Randomize
        // 
        B_Randomize.Location = new System.Drawing.Point(14, 376);
        B_Randomize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Randomize.Name = "B_Randomize";
        B_Randomize.Size = new System.Drawing.Size(102, 27);
        B_Randomize.TabIndex = 3;
        B_Randomize.Text = "Randomize";
        B_Randomize.UseVisualStyleBackColor = true;
        B_Randomize.Click += B_Randomize_Click;
        // 
        // B_Save
        // 
        B_Save.Location = new System.Drawing.Point(652, 376);
        B_Save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Save.Name = "B_Save";
        B_Save.Size = new System.Drawing.Size(79, 27);
        B_Save.TabIndex = 4;
        B_Save.Text = "Save";
        B_Save.UseVisualStyleBackColor = true;
        B_Save.Click += B_Save_Click;
        // 
        // B_Cancel
        // 
        B_Cancel.Location = new System.Drawing.Point(566, 376);
        B_Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Cancel.Name = "B_Cancel";
        B_Cancel.Size = new System.Drawing.Size(79, 27);
        B_Cancel.TabIndex = 5;
        B_Cancel.Text = "Cancel";
        B_Cancel.UseVisualStyleBackColor = true;
        B_Cancel.Click += B_Cancel_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new System.Drawing.Point(382, 10);
        label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(56, 15);
        label1.TabIndex = 8;
        label1.Text = "Location:";
        // 
        // CB_LocationBP
        // 
        CB_LocationBP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        CB_LocationBP.FormattingEnabled = true;
        CB_LocationBP.Location = new System.Drawing.Point(448, 7);
        CB_LocationBP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CB_LocationBP.Name = "CB_LocationBP";
        CB_LocationBP.Size = new System.Drawing.Size(283, 23);
        CB_LocationBP.TabIndex = 6;
        CB_LocationBP.SelectedIndexChanged += ChangeIndexBP;
        // 
        // B_RandomizeBP
        // 
        B_RandomizeBP.Location = new System.Drawing.Point(382, 376);
        B_RandomizeBP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_RandomizeBP.Name = "B_RandomizeBP";
        B_RandomizeBP.Size = new System.Drawing.Size(102, 27);
        B_RandomizeBP.TabIndex = 9;
        B_RandomizeBP.Text = "Randomize";
        B_RandomizeBP.UseVisualStyleBackColor = true;
        B_RandomizeBP.Click += B_RandomizeBP_Click;
        // 
        // dgvbp
        // 
        dgvbp.AllowUserToAddRows = false;
        dgvbp.AllowUserToDeleteRows = false;
        dgvbp.AllowUserToResizeColumns = false;
        dgvbp.AllowUserToResizeRows = false;
        dgvbp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvbp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgvIndexBP, dgvItemBP, dgvPriceBP });
        dgvbp.Location = new System.Drawing.Point(382, 38);
        dgvbp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        dgvbp.Name = "dgvbp";
        dgvbp.Size = new System.Drawing.Size(350, 328);
        dgvbp.TabIndex = 10;
        // 
        // dgvIndexBP
        // 
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
        dgvIndexBP.DefaultCellStyle = dataGridViewCellStyle2;
        dgvIndexBP.HeaderText = "Index";
        dgvIndexBP.MaxInputLength = 3;
        dgvIndexBP.Name = "dgvIndexBP";
        dgvIndexBP.ReadOnly = true;
        dgvIndexBP.Width = 45;
        // 
        // dgvItemBP
        // 
        dgvItemBP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        dgvItemBP.HeaderText = "Item";
        dgvItemBP.Name = "dgvItemBP";
        dgvItemBP.Width = 135;
        // 
        // dgvPriceBP
        // 
        dgvPriceBP.HeaderText = "Price";
        dgvPriceBP.MaxInputLength = 3;
        dgvPriceBP.Name = "dgvPriceBP";
        dgvPriceBP.Width = 65;
        // 
        // CHK_XItems
        // 
        CHK_XItems.AutoSize = true;
        CHK_XItems.Checked = true;
        CHK_XItems.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_XItems.Location = new System.Drawing.Point(124, 381);
        CHK_XItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_XItems.Name = "CHK_XItems";
        CHK_XItems.Size = new System.Drawing.Size(220, 19);
        CHK_XItems.TabIndex = 304;
        CHK_XItems.Text = "Don't Randomize X Items (Speedrun)";
        CHK_XItems.UseVisualStyleBackColor = true;
        // 
        // MartEditor7
        //
        BackColor = bg;
        ForeColor = text;
        Font = font;

        dgv.ForeColor = System.Drawing.Color.Black;
        dgv.BackgroundColor = surface;

        dgvbp.ForeColor = System.Drawing.Color.Black;
        dgvbp.BackgroundColor = surface;

        B_Cancel.ForeColor = aka;
        B_Cancel.Font = font;
        B_Cancel.FlatAppearance.BorderColor = aka;
        B_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Cancel.BackColor = bg;

        B_Randomize.ForeColor = murasaki;
        B_Randomize.Font = font;
        B_Randomize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Randomize.FlatAppearance.BorderColor = murasaki;
        B_Randomize.BackColor = bg;

        B_RandomizeBP.ForeColor = murasaki;
        B_RandomizeBP.Font = font;
        B_RandomizeBP.FlatAppearance.BorderColor = murasaki;
        B_RandomizeBP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_RandomizeBP.BackColor = bg;

        B_Save.ForeColor = midori;
        B_Save.BackColor = bg;
        B_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Save.FlatAppearance.BorderColor = midori;
        B_Save.Font = font;

        dgvIndex.Width = 65;
        dgvIndexBP.Width = 65;
        dgvItem.Width = 220;
        dgvItemBP.Width = 150;
        dgvPriceBP.Width = 90;

        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(746, 417);
        Controls.Add(CHK_XItems);
        Controls.Add(dgvbp);
        Controls.Add(B_RandomizeBP);
        Controls.Add(label1);
        Controls.Add(CB_LocationBP);
        Controls.Add(B_Cancel);
        Controls.Add(B_Save);
        Controls.Add(B_Randomize);
        Controls.Add(L_Mart);
        Controls.Add(dgv);
        Controls.Add(CB_Location);
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MinimumSize = new System.Drawing.Size(394, 456);
        Name = "MartEditor7";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Mart Editor";
        ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvbp).EndInit();
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox CB_Location;
    private System.Windows.Forms.DataGridView dgv;
    private System.Windows.Forms.Label L_Mart;
    private System.Windows.Forms.Button B_Randomize;
    private System.Windows.Forms.Button B_Save;
    private System.Windows.Forms.Button B_Cancel;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox CB_LocationBP;
    private System.Windows.Forms.Button B_RandomizeBP;
    private System.Windows.Forms.DataGridViewComboBoxColumn dgvItem;
    private System.Windows.Forms.DataGridViewTextBoxColumn dgvIndex;
    private System.Windows.Forms.DataGridView dgvbp;
    private System.Windows.Forms.DataGridViewTextBoxColumn dgvIndexBP;
    private System.Windows.Forms.DataGridViewComboBoxColumn dgvItemBP;
    private System.Windows.Forms.DataGridViewTextBoxColumn dgvPriceBP;
    private System.Windows.Forms.CheckBox CHK_XItems;
}
