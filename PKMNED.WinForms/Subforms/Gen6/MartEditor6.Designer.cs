namespace PKMNED.WinForms;

partial class MartEditor6
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MartEditor6));
        CB_Location = new System.Windows.Forms.ComboBox();
        dgv = new System.Windows.Forms.DataGridView();
        L_Mart = new System.Windows.Forms.Label();
        B_Randomize = new System.Windows.Forms.Button();
        B_Save = new System.Windows.Forms.Button();
        B_Cancel = new System.Windows.Forms.Button();
        CHK_XItems = new System.Windows.Forms.CheckBox();
        ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
        SuspendLayout();
        // 
        // CB_Location
        // 
        CB_Location.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        CB_Location.FormattingEnabled = true;
        CB_Location.Location = new System.Drawing.Point(80, 8);
        CB_Location.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CB_Location.Name = "CB_Location";
        CB_Location.Size = new System.Drawing.Size(283, 25);
        CB_Location.TabIndex = 0;
        CB_Location.SelectedIndexChanged += ChangeIndex;
        // 
        // dgv
        // 
        dgv.AllowUserToAddRows = false;
        dgv.AllowUserToDeleteRows = false;
        dgv.AllowUserToResizeColumns = false;
        dgv.AllowUserToResizeRows = false;
        dgv.BackgroundColor = System.Drawing.Color.FromArgb(30, 41, 59);
        dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv.Location = new System.Drawing.Point(14, 43);
        dgv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        dgv.Name = "dgv";
        dgv.Size = new System.Drawing.Size(350, 372);
        dgv.TabIndex = 1;
        // 
        // L_Mart
        // 
        L_Mart.AutoSize = true;
        L_Mart.Location = new System.Drawing.Point(14, 11);
        L_Mart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Mart.Name = "L_Mart";
        L_Mart.Size = new System.Drawing.Size(64, 19);
        L_Mart.TabIndex = 2;
        L_Mart.Text = "Location:";
        // 
        // B_Randomize
        // 
        B_Randomize.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_Randomize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(166, 136, 210);
        B_Randomize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Randomize.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Randomize.ForeColor = System.Drawing.Color.FromArgb(166, 136, 210);
        B_Randomize.Location = new System.Drawing.Point(14, 426);
        B_Randomize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Randomize.Name = "B_Randomize";
        B_Randomize.Size = new System.Drawing.Size(102, 31);
        B_Randomize.TabIndex = 3;
        B_Randomize.Text = "Randomize";
        B_Randomize.UseVisualStyleBackColor = false;
        B_Randomize.Click += B_Randomize_Click;
        // 
        // B_Save
        // 
        B_Save.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(154, 205, 50);
        B_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Save.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Save.ForeColor = System.Drawing.Color.FromArgb(154, 205, 50);
        B_Save.Location = new System.Drawing.Point(284, 426);
        B_Save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Save.Name = "B_Save";
        B_Save.Size = new System.Drawing.Size(79, 31);
        B_Save.TabIndex = 4;
        B_Save.Text = "Save";
        B_Save.UseVisualStyleBackColor = false;
        B_Save.Click += B_Save_Click;
        // 
        // B_Cancel
        // 
        B_Cancel.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
        B_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Cancel.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Cancel.ForeColor = System.Drawing.Color.Red;
        B_Cancel.Location = new System.Drawing.Point(198, 426);
        B_Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Cancel.Name = "B_Cancel";
        B_Cancel.Size = new System.Drawing.Size(79, 31);
        B_Cancel.TabIndex = 5;
        B_Cancel.Text = "Cancel";
        B_Cancel.UseVisualStyleBackColor = false;
        B_Cancel.Click += B_Cancel_Click;
        // 
        // CHK_XItems
        // 
        CHK_XItems.AutoSize = true;
        CHK_XItems.Checked = true;
        CHK_XItems.CheckState = System.Windows.Forms.CheckState.Checked;
        CHK_XItems.Location = new System.Drawing.Point(60, 479);
        CHK_XItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_XItems.Name = "CHK_XItems";
        CHK_XItems.Size = new System.Drawing.Size(253, 23);
        CHK_XItems.TabIndex = 304;
        CHK_XItems.Text = "Don't Randomize X Items (Speedrun)";
        CHK_XItems.UseVisualStyleBackColor = true;
        // 
        // MartEditor6
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        ClientSize = new System.Drawing.Size(378, 514);
        Controls.Add(CHK_XItems);
        Controls.Add(B_Cancel);
        Controls.Add(B_Save);
        Controls.Add(B_Randomize);
        Controls.Add(L_Mart);
        Controls.Add(dgv);
        Controls.Add(CB_Location);
        Font = new System.Drawing.Font("Segoe UI", 10F);
        ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MinimumSize = new System.Drawing.Size(394, 512);
        Name = "MartEditor6";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Mart Editor";
        ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
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
    private System.Windows.Forms.CheckBox CHK_XItems;
}
