namespace PKMNED.WinForms;

partial class ItemEditor7
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemEditor7));
        CB_Item = new System.Windows.Forms.ComboBox();
        L_Item = new System.Windows.Forms.Label();
        RTB = new System.Windows.Forms.RichTextBox();
        L_Index = new System.Windows.Forms.Label();
        Grid = new System.Windows.Forms.PropertyGrid();
        B_Table = new System.Windows.Forms.Button();
        panel1 = new System.Windows.Forms.Panel();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // CB_Item
        // 
        CB_Item.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
        CB_Item.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        CB_Item.DropDownWidth = 120;
        CB_Item.FormattingEnabled = true;
        CB_Item.Location = new System.Drawing.Point(65, 14);
        CB_Item.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CB_Item.Name = "CB_Item";
        CB_Item.Size = new System.Drawing.Size(167, 25);
        CB_Item.TabIndex = 1;
        CB_Item.SelectedIndexChanged += ChangeEntry;
        // 
        // L_Item
        // 
        L_Item.Location = new System.Drawing.Point(-4, 14);
        L_Item.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Item.Name = "L_Item";
        L_Item.Size = new System.Drawing.Size(59, 27);
        L_Item.TabIndex = 2;
        L_Item.Text = "Item:";
        L_Item.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // RTB
        // 
        RTB.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        RTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
        RTB.Dock = System.Windows.Forms.DockStyle.Fill;
        RTB.Font = new System.Drawing.Font("Segoe UI", 10F);
        RTB.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        RTB.Location = new System.Drawing.Point(0, 0);
        RTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        RTB.Name = "RTB";
        RTB.ReadOnly = true;
        RTB.Size = new System.Drawing.Size(367, 69);
        RTB.TabIndex = 38;
        RTB.Text = "";
        // 
        // L_Index
        // 
        L_Index.AutoSize = true;
        L_Index.Location = new System.Drawing.Point(271, 18);
        L_Index.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Index.Name = "L_Index";
        L_Index.Size = new System.Drawing.Size(49, 19);
        L_Index.TabIndex = 46;
        L_Index.Text = "Index: ";
        // 
        // Grid
        //
        var bg = System.Drawing.Color.FromArgb(15, 23, 42);
        var surface = System.Drawing.Color.FromArgb(30, 41, 59);
        var surface2 = System.Drawing.Color.FromArgb(36, 50, 73);
        var accent = System.Drawing.Color.FromArgb(56, 189, 248);
        var text = System.Drawing.Color.FromArgb(226, 232, 240);
        var muted = System.Drawing.Color.FromArgb(148, 163, 184);
        var font = new System.Drawing.Font("Segoe UI", 10F);
        var title = new System.Drawing.Font("Segoe UI Semibold", 11F);
        Grid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        Grid.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        Grid.CategoryForeColor = System.Drawing.Color.FromArgb(36, 50, 73);
        Grid.LineColor = System.Drawing.SystemColors.ControlDark;
        Grid.Location = new System.Drawing.Point(14, 139);
        Grid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        Grid.Name = "Grid";
        Grid.Size = new System.Drawing.Size(369, 422);
        Grid.TabIndex = 47;
        Grid.HelpBackColor = surface;
        Grid.HelpBorderColor = surface2;
        Grid.ViewBackColor = surface2;
        Grid.ViewForeColor = text;
        Grid.CategoryForeColor = text;
        Grid.CommandsBorderColor = surface;
        Grid.LineColor = surface;
        Grid.CommandsForeColor = text;
        Grid.HelpForeColor = text;
        // 
        // B_Table
        // 
        B_Table.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_Table.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_Table.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Table.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Table.ForeColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_Table.Location = new System.Drawing.Point(280, 122);
        B_Table.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Table.Name = "B_Table";
        B_Table.Size = new System.Drawing.Size(102, 34);
        B_Table.TabIndex = 48;
        B_Table.Text = "Export Table";
        B_Table.UseVisualStyleBackColor = false;
        B_Table.Click += B_Table_Click;
        // 
        // panel1
        // 
        panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        panel1.Controls.Add(RTB);
        panel1.Location = new System.Drawing.Point(14, 45);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(369, 71);
        panel1.TabIndex = 49;
        // 
        // ItemEditor7
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        ClientSize = new System.Drawing.Size(396, 572);
        Controls.Add(panel1);
        Controls.Add(B_Table);
        Controls.Add(Grid);
        Controls.Add(L_Index);
        Controls.Add(L_Item);
        Controls.Add(CB_Item);
        Font = new System.Drawing.Font("Segoe UI", 10F);
        ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MaximumSize = new System.Drawing.Size(412, 1296);
        MinimumSize = new System.Drawing.Size(412, 538);
        Name = "ItemEditor7";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Item Editor";
        FormClosing += Form_Closing;
        panel1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox CB_Item;
    private System.Windows.Forms.Label L_Item;
    private System.Windows.Forms.RichTextBox RTB;
    private System.Windows.Forms.Label L_Index;
    private System.Windows.Forms.PropertyGrid Grid;
    private System.Windows.Forms.Button B_Table;
    private System.Windows.Forms.Panel panel1;
}
