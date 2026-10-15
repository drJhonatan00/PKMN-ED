using static System.Net.Mime.MediaTypeNames;

namespace PKMNED.WinForms;

partial class MartEditor7UU
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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MartEditor7UU));
        CB_Location = new System.Windows.Forms.ComboBox();
        dgv = new System.Windows.Forms.DataGridView();
        dgvIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
        dgvItem = new System.Windows.Forms.DataGridViewComboBoxColumn();
        L_Mart = new System.Windows.Forms.Label();
        B_Randomize = new System.Windows.Forms.Button();
        B_Save = new System.Windows.Forms.Button();
        B_Cancel = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        CB_LocationBPItem = new System.Windows.Forms.ComboBox();
        dgvbp = new System.Windows.Forms.DataGridView();
        dgvIndexBP = new System.Windows.Forms.DataGridViewTextBoxColumn();
        dgvItemBP = new System.Windows.Forms.DataGridViewComboBoxColumn();
        dgvPriceBP = new System.Windows.Forms.DataGridViewTextBoxColumn();
        tabControl1 = new System.Windows.Forms.TabControl();
        tabPage1 = new System.Windows.Forms.TabPage();
        tabPage2 = new System.Windows.Forms.TabPage();
        CHK_XItems = new System.Windows.Forms.CheckBox();
        ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvbp).BeginInit();
        tabControl1.SuspendLayout();
        tabPage1.SuspendLayout();
        tabPage2.SuspendLayout();
        SuspendLayout();
        // 
        // CB_Location
        // 
        CB_Location.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        CB_Location.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        CB_Location.FormattingEnabled = true;
        CB_Location.Location = new System.Drawing.Point(70, 3);
        CB_Location.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CB_Location.Name = "CB_Location";
        CB_Location.Size = new System.Drawing.Size(296, 23);
        CB_Location.TabIndex = 0;
        CB_Location.SelectedIndexChanged += ChangeIndexItem;
        // 
        // dgv
        // 
        dgv.AllowUserToAddRows = false;
        dgv.AllowUserToDeleteRows = false;
        dgv.AllowUserToResizeColumns = false;
        dgv.AllowUserToResizeRows = false;
        dgv.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgvIndex, dgvItem });
        dgv.Location = new System.Drawing.Point(0, 31);
        dgv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        dgv.Name = "dgv";
        dgv.Size = new System.Drawing.Size(370, 306);
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
        L_Mart.Location = new System.Drawing.Point(7, 7);
        L_Mart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Mart.Name = "L_Mart";
        L_Mart.Size = new System.Drawing.Size(56, 15);
        L_Mart.TabIndex = 2;
        L_Mart.Text = "Location:";
        // 
        // B_Randomize
        // 
        B_Randomize.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        B_Randomize.Location = new System.Drawing.Point(14, 388);
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
        B_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        B_Save.Location = new System.Drawing.Point(309, 388);
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
        B_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        B_Cancel.Location = new System.Drawing.Point(223, 388);
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
        label1.Location = new System.Drawing.Point(7, 7);
        label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(56, 15);
        label1.TabIndex = 8;
        label1.Text = "Location:";
        // 
        // CB_LocationBPItem
        // 
        CB_LocationBPItem.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        CB_LocationBPItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        CB_LocationBPItem.FormattingEnabled = true;
        CB_LocationBPItem.Location = new System.Drawing.Point(70, 3);
        CB_LocationBPItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CB_LocationBPItem.Name = "CB_LocationBPItem";
        CB_LocationBPItem.Size = new System.Drawing.Size(296, 23);
        CB_LocationBPItem.TabIndex = 6;
        CB_LocationBPItem.SelectedIndexChanged += ChangeIndexBPItem;
        // 
        // dgvbp
        // 
        dgvbp.AllowUserToAddRows = false;
        dgvbp.AllowUserToDeleteRows = false;
        dgvbp.AllowUserToResizeColumns = false;
        dgvbp.AllowUserToResizeRows = false;
        dgvbp.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        dgvbp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvbp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgvIndexBP, dgvItemBP, dgvPriceBP });
        dgvbp.Location = new System.Drawing.Point(0, 31);
        dgvbp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        dgvbp.Name = "dgvbp";
        dgvbp.Size = new System.Drawing.Size(370, 278);
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
        // tabControl1
        // 
        tabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        tabControl1.Controls.Add(tabPage1);
        tabControl1.Controls.Add(tabPage2);
        tabControl1.Location = new System.Drawing.Point(14, 14);
        tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new System.Drawing.Size(379, 367);
        tabControl1.TabIndex = 15;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(L_Mart);
        tabPage1.Controls.Add(CB_Location);
        tabPage1.Controls.Add(dgv);
        tabPage1.Location = new System.Drawing.Point(4, 24);
        tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tabPage1.Size = new System.Drawing.Size(371, 339);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "Poké Mart";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // tabPage2
        // 
        tabPage2.Controls.Add(CB_LocationBPItem);
        tabPage2.Controls.Add(label1);
        tabPage2.Controls.Add(dgvbp);
        tabPage2.Location = new System.Drawing.Point(4, 24);
        tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tabPage2.Size = new System.Drawing.Size(371, 339);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "BP Items";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // CHK_XItems
        // 
        CHK_XItems.AutoSize = true;
        CHK_XItems.Checked = true;
        CHK_XItems.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_XItems.Location = new System.Drawing.Point(15, 420);
        CHK_XItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_XItems.Name = "CHK_XItems";
        CHK_XItems.Size = new System.Drawing.Size(220, 19);
        CHK_XItems.TabIndex = 304;
        CHK_XItems.Text = "Don't Randomize X Items (Speedrun)";
        CHK_XItems.UseVisualStyleBackColor = true;
        // 
        // MartEditor7UU
        //
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

        BackColor = bg;
        ForeColor = text;
        Font = font;

        dgv.ForeColor = System.Drawing.Color.Black;
        dgv.BackgroundColor = surface2;

        dgvbp.ForeColor = System.Drawing.Color.Black;
        dgvbp.BackgroundColor = surface2;

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


        B_Save.ForeColor = midori;
        B_Save.BackColor = bg;
        B_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Save.FlatAppearance.BorderColor = midori;
        B_Save.Font = font;

        tabPage1.BackColor = surface;
        tabPage2.BackColor = surface;

        dgvIndex.Width = 65;
        dgvIndexBP.Width = 65;
        dgvItem.Width = 220;
        dgvItemBP.Width = 150;
        dgvPriceBP.Width = 90;
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(401, 447);
        Controls.Add(CHK_XItems);
        Controls.Add(tabControl1);
        Controls.Add(B_Cancel);
        Controls.Add(B_Save);
        Controls.Add(B_Randomize);
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MinimumSize = new System.Drawing.Size(417, 340);
        Name = "MartEditor7UU";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Mart Editor";
        ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvbp).EndInit();
        tabControl1.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        tabPage1.PerformLayout();
        tabPage2.ResumeLayout(false);
        tabPage2.PerformLayout();
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
    private System.Windows.Forms.ComboBox CB_LocationBPItem;
    private System.Windows.Forms.DataGridViewComboBoxColumn dgvItem;
    private System.Windows.Forms.DataGridViewTextBoxColumn dgvIndex;
    private System.Windows.Forms.DataGridView dgvbp;
    private System.Windows.Forms.DataGridViewTextBoxColumn dgvIndexBP;
    private System.Windows.Forms.DataGridViewComboBoxColumn dgvItemBP;
    private System.Windows.Forms.DataGridViewTextBoxColumn dgvPriceBP;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.CheckBox CHK_XItems;
}
