namespace PKMNED.WinForms;

partial class About
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
        var kiiro = System.Drawing.Color.FromArgb(255, 216, 1);

        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
        B_Close = new System.Windows.Forms.Button();
        RTB = new System.Windows.Forms.RichTextBox();
        L_Thanks = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // B_Close
        // 
        B_Close.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        B_Close.Location = new System.Drawing.Point(481, 392);
        B_Close.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Close.Name = "B_Close";
        B_Close.Size = new System.Drawing.Size(88, 27);
        B_Close.TabIndex = 0;
        B_Close.Text = "Close";
        B_Close.UseVisualStyleBackColor = true;
        B_Close.Click += B_Close_Click;
        // 
        // RTB
        // 
        RTB.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        RTB.Location = new System.Drawing.Point(8, 10);
        RTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        RTB.Name = "RTB";
        RTB.ReadOnly = true;
        RTB.Size = new System.Drawing.Size(559, 371);
        RTB.TabIndex = 1;
        RTB.Text = "";
        RTB.WordWrap = false;
        RTB.TextChanged += RTB_TextChanged;
        // 
        // L_Thanks
        // 
        L_Thanks.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        L_Thanks.AutoSize = true;
        L_Thanks.Location = new System.Drawing.Point(14, 398);
        L_Thanks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Thanks.Name = "L_Thanks";
        L_Thanks.Size = new System.Drawing.Size(209, 15);
        L_Thanks.TabIndex = 2;
        L_Thanks.Text = "Thanks to all devs of PKMNED and SPICA";
        // 
        // About
        //
        BackColor = bg;
        ForeColor = text;
        Font = font;

        RTB.BackColor = surface;
        RTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
        RTB.Font = font;
        RTB.ForeColor = text;

        B_Close.ForeColor = accent;
        B_Close.BackColor = bg;
        B_Close.Font = font;
        B_Close.FlatAppearance.BorderColor = accent;
        B_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(576, 429);
        Controls.Add(L_Thanks);
        Controls.Add(RTB);
        Controls.Add(B_Close);
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MaximumSize = new System.Drawing.Size(1059, 813);
        MinimizeBox = false;
        MinimumSize = new System.Drawing.Size(592, 467);
        Name = "About";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "About";
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button B_Close;
    private System.Windows.Forms.RichTextBox RTB;
    private System.Windows.Forms.Label L_Thanks;
}
