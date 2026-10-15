namespace PKMNED.WinForms;

partial class Shuffler
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

        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shuffler));
        CB_a = new System.Windows.Forms.ComboBox();
        CB_b = new System.Windows.Forms.ComboBox();
        CB_c = new System.Windows.Forms.ComboBox();
        L_a = new System.Windows.Forms.Label();
        L_File = new System.Windows.Forms.Label();
        B_Shuffle = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // CB_a
        // 
        CB_a.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        CB_a.FormattingEnabled = true;
        CB_a.Items.AddRange(new object[] { "0", "1", "2", "3" });
        CB_a.Location = new System.Drawing.Point(42, 13);
        CB_a.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CB_a.Name = "CB_a";
        CB_a.Size = new System.Drawing.Size(39, 23);
        CB_a.TabIndex = 0;
        CB_a.SelectedIndexChanged += UpdateLabel;
        // 
        // CB_b
        // 
        CB_b.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        CB_b.FormattingEnabled = true;
        CB_b.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" });
        CB_b.Location = new System.Drawing.Point(89, 13);
        CB_b.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CB_b.Name = "CB_b";
        CB_b.Size = new System.Drawing.Size(39, 23);
        CB_b.TabIndex = 1;
        CB_b.SelectedIndexChanged += UpdateLabel;
        // 
        // CB_c
        // 
        CB_c.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        CB_c.FormattingEnabled = true;
        CB_c.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" });
        CB_c.Location = new System.Drawing.Point(135, 13);
        CB_c.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CB_c.Name = "CB_c";
        CB_c.Size = new System.Drawing.Size(39, 23);
        CB_c.TabIndex = 2;
        CB_c.SelectedIndexChanged += UpdateLabel;
       
        // 
        // L_a
        // 
        L_a.Location = new System.Drawing.Point(14, 10);
        L_a.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_a.Name = "L_a";
        L_a.Size = new System.Drawing.Size(21, 27);
        L_a.TabIndex = 3;
        L_a.Text = "a";
        L_a.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // L_File
        // 
        L_File.Location = new System.Drawing.Point(18, 40);
        L_File.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_File.Name = "L_File";
        L_File.Size = new System.Drawing.Size(158, 27);
        L_File.TabIndex = 4;
        L_File.Text = "FILENAME HERE";
        L_File.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // B_Shuffle
        // 
        B_Shuffle.Location = new System.Drawing.Point(89, 77);
        B_Shuffle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Shuffle.Name = "B_Shuffle";
        B_Shuffle.Size = new System.Drawing.Size(88, 27);
        B_Shuffle.TabIndex = 5;
        B_Shuffle.Text = "Shuffle!";
        B_Shuffle.UseVisualStyleBackColor = true;
        B_Shuffle.Click += B_Shuffle_Click;
        B_Shuffle.ForeColor = accent;
        B_Shuffle.Font = font;
        B_Shuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Shuffle.FlatAppearance.BorderColor = accent;

        // 
        // Shuffler
        //
        BackColor = bg;
        ForeColor = text;
        Font = font;
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(191, 117);
        Controls.Add(B_Shuffle);
        Controls.Add(L_File);
        Controls.Add(L_a);
        Controls.Add(CB_c);
        Controls.Add(CB_b);
        Controls.Add(CB_a);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        MaximumSize = new System.Drawing.Size(207, 156);
        MinimumSize = new System.Drawing.Size(207, 156);
        Name = "Shuffler";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Shuffler";
        ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ComboBox CB_a;
    private System.Windows.Forms.ComboBox CB_b;
    private System.Windows.Forms.ComboBox CB_c;
    private System.Windows.Forms.Label L_a;
    private System.Windows.Forms.Label L_File;
    private System.Windows.Forms.Button B_Shuffle;
}
