namespace PKMNED.WinForms;

partial class Patch
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patch));
        CHKLB_GARCs = new System.Windows.Forms.CheckedListBox();
        textBox1 = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        B_PatchCIA = new System.Windows.Forms.Button();
        CHK_Lang = new System.Windows.Forms.CheckBox();
        RTB_GARCs = new System.Windows.Forms.RichTextBox();
        label2 = new System.Windows.Forms.Label();
        B_CheckAll = new System.Windows.Forms.Button();
        B_CheckNone = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // CHKLB_GARCs
        // 
        CHKLB_GARCs.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        CHKLB_GARCs.FormattingEnabled = true;
        CHKLB_GARCs.Location = new System.Drawing.Point(14, 14);
        CHKLB_GARCs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHKLB_GARCs.Name = "CHKLB_GARCs";
        CHKLB_GARCs.Size = new System.Drawing.Size(174, 292);
        CHKLB_GARCs.TabIndex = 0;
        // 
        // textBox1
        // 
        textBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        textBox1.Location = new System.Drawing.Point(196, 32);
        textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        textBox1.Name = "textBox1";
        textBox1.ReadOnly = true;
        textBox1.Size = new System.Drawing.Size(121, 20);
        textBox1.TabIndex = 1;
        textBox1.Text = "a/#/* -> a#/*";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new System.Drawing.Point(196, 14);
        label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(114, 15);
        label1.TabIndex = 2;
        label1.Text = "ExeFS Path Override:";
        // 
        // B_PatchCIA
        // 
        B_PatchCIA.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        B_PatchCIA.Location = new System.Drawing.Point(196, 321);
        B_PatchCIA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_PatchCIA.Name = "B_PatchCIA";
        B_PatchCIA.Size = new System.Drawing.Size(121, 27);
        B_PatchCIA.TabIndex = 3;
        B_PatchCIA.Text = "Redirect [CIA]";
        B_PatchCIA.UseVisualStyleBackColor = true;
        B_PatchCIA.Click += B_PatchCIA_Click;
        // 
        // CHK_Lang
        // 
        CHK_Lang.AutoSize = true;
        CHK_Lang.Location = new System.Drawing.Point(200, 62);
        CHK_Lang.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_Lang.Name = "CHK_Lang";
        CHK_Lang.Size = new System.Drawing.Size(116, 19);
        CHK_Lang.TabIndex = 4;
        CHK_Lang.Text = "Patch Languages";
        CHK_Lang.UseVisualStyleBackColor = true;
        // 
        // RTB_GARCs
        // 
        RTB_GARCs.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        RTB_GARCs.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        RTB_GARCs.Location = new System.Drawing.Point(196, 104);
        RTB_GARCs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        RTB_GARCs.Name = "RTB_GARCs";
        RTB_GARCs.Size = new System.Drawing.Size(87, 208);
        RTB_GARCs.TabIndex = 5;
        RTB_GARCs.Text = "";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new System.Drawing.Point(192, 85);
        label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(74, 15);
        label2.TabIndex = 6;
        label2.Text = "Extra GARCs:";
        // 
        // B_CheckAll
        // 
        B_CheckAll.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        B_CheckAll.Location = new System.Drawing.Point(14, 321);
        B_CheckAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_CheckAll.Name = "B_CheckAll";
        B_CheckAll.Size = new System.Drawing.Size(88, 27);
        B_CheckAll.TabIndex = 7;
        B_CheckAll.Text = "Check All";
        B_CheckAll.UseVisualStyleBackColor = true;
        B_CheckAll.Click += B_CheckAll_Click;
        // 
        // B_CheckNone
        // 
        B_CheckNone.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        B_CheckNone.Location = new System.Drawing.Point(102, 321);
        B_CheckNone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_CheckNone.Name = "B_CheckNone";
        B_CheckNone.Size = new System.Drawing.Size(88, 27);
        B_CheckNone.TabIndex = 8;
        B_CheckNone.Text = "Check None";
        B_CheckNone.UseVisualStyleBackColor = true;
        B_CheckNone.Click += B_CheckNone_Click;
        // 
        // Patch
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(331, 360);
        Controls.Add(B_CheckNone);
        Controls.Add(B_CheckAll);
        Controls.Add(label2);
        Controls.Add(RTB_GARCs);
        Controls.Add(CHK_Lang);
        Controls.Add(B_PatchCIA);
        Controls.Add(label1);
        Controls.Add(textBox1);
        Controls.Add(CHKLB_GARCs);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "Patch";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Patch Manager";
        FormClosing += SavePatch;
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private System.Windows.Forms.CheckedListBox CHKLB_GARCs;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button B_PatchCIA;
    private System.Windows.Forms.CheckBox CHK_Lang;
    private System.Windows.Forms.RichTextBox RTB_GARCs;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button B_CheckAll;
    private System.Windows.Forms.Button B_CheckNone;
}