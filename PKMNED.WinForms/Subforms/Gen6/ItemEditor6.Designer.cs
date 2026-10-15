namespace PKMNED.WinForms;

partial class ItemEditor6
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemEditor6));
        Grid = new System.Windows.Forms.PropertyGrid();
        L_Index = new System.Windows.Forms.Label();
        RTB = new System.Windows.Forms.RichTextBox();
        L_Item = new System.Windows.Forms.Label();
        CB_Item = new System.Windows.Forms.ComboBox();
        B_Table = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // Grid
        // 
        Grid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        Grid.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        Grid.CategoryForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Grid.CommandsBorderColor = System.Drawing.Color.FromArgb(30, 41, 59);
        Grid.CommandsForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Grid.DisabledItemForeColor = System.Drawing.Color.FromArgb(127, 226, 232, 240);
        Grid.HelpBackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        Grid.HelpBorderColor = System.Drawing.Color.FromArgb(36, 50, 73);
        Grid.HelpForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Grid.LineColor = System.Drawing.Color.FromArgb(30, 41, 59);
        Grid.Location = new System.Drawing.Point(12, 159);
        Grid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        Grid.Name = "Grid";
        Grid.Size = new System.Drawing.Size(369, 328);
        Grid.TabIndex = 47;
        Grid.ViewBackColor = System.Drawing.Color.FromArgb(36, 50, 73);
        Grid.ViewForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        // 
        // L_Index
        // 
        L_Index.AutoSize = true;
        L_Index.Location = new System.Drawing.Point(258, 18);
        L_Index.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Index.Name = "L_Index";
        L_Index.Size = new System.Drawing.Size(49, 19);
        L_Index.TabIndex = 51;
        L_Index.Text = "Index: ";
        // 
        // RTB
        // 
        RTB.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        RTB.BackColor = System.Drawing.Color.FromArgb(36, 50, 73);
        RTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
        RTB.Font = new System.Drawing.Font("Segoe UI", 10F);
        RTB.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        RTB.Location = new System.Drawing.Point(13, 49);
        RTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        RTB.Name = "RTB";
        RTB.ReadOnly = true;
        RTB.Size = new System.Drawing.Size(368, 65);
        RTB.TabIndex = 50;
        RTB.Text = "";
        // 
        // L_Item
        // 
        L_Item.Location = new System.Drawing.Point(14, 14);
        L_Item.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Item.Name = "L_Item";
        L_Item.Size = new System.Drawing.Size(59, 27);
        L_Item.TabIndex = 49;
        L_Item.Text = "Item:";
        L_Item.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // CB_Item
        // 
        CB_Item.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
        CB_Item.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        CB_Item.DropDownWidth = 120;
        CB_Item.FormattingEnabled = true;
        CB_Item.Location = new System.Drawing.Point(83, 14);
        CB_Item.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CB_Item.Name = "CB_Item";
        CB_Item.Size = new System.Drawing.Size(167, 25);
        CB_Item.TabIndex = 48;
        CB_Item.SelectedIndexChanged += ChangeEntry;
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
        B_Table.Text = "Export";
        B_Table.UseVisualStyleBackColor = false;
        B_Table.Click += B_Table_Click;
        // 
        // ItemEditor6
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        ClientSize = new System.Drawing.Size(396, 499);
        Controls.Add(B_Table);
        Controls.Add(Grid);
        Controls.Add(L_Index);
        Controls.Add(RTB);
        Controls.Add(L_Item);
        Controls.Add(CB_Item);
        Font = new System.Drawing.Font("Segoe UI", 10F);
        ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MaximumSize = new System.Drawing.Size(412, 1296);
        MinimumSize = new System.Drawing.Size(412, 538);
        Name = "ItemEditor6";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Item Editor";
        FormClosing += IsFormClosing;
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PropertyGrid Grid;
    private System.Windows.Forms.Label L_Index;
    private System.Windows.Forms.RichTextBox RTB;
    private System.Windows.Forms.Label L_Item;
    private System.Windows.Forms.ComboBox CB_Item;
    private System.Windows.Forms.Button B_Table;
}
