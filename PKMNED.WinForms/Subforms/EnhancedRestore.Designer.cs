namespace PKMNED.WinForms;

partial class EnhancedRestore
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnhancedRestore));
        tabControl1 = new System.Windows.Forms.TabControl();
        tabPage1 = new System.Windows.Forms.TabPage();
        tabPage2 = new System.Windows.Forms.TabPage();
        tabPage3 = new System.Windows.Forms.TabPage();
        B_Go = new System.Windows.Forms.Button();
        B_All = new System.Windows.Forms.Button();
        panel1 = new System.Windows.Forms.Panel();
        tabControl1.SuspendLayout();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // tabControl1
        // 
        tabControl1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        tabControl1.Controls.Add(tabPage1);
        tabControl1.Controls.Add(tabPage2);
        tabControl1.Controls.Add(tabPage3);
        tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
        tabControl1.Location = new System.Drawing.Point(0, -2);
        tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new System.Drawing.Size(346, 433);
        tabControl1.TabIndex = 0;
        // 
        // tabPage1
        // 
        tabPage1.Font = new System.Drawing.Font("Segoe UI", 10F);
        tabPage1.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        tabPage1.Location = new System.Drawing.Point(4, 26);
        tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tabPage1.Size = new System.Drawing.Size(338, 403);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "GARC";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // tabPage2
        // 
        tabPage2.Font = new System.Drawing.Font("Segoe UI", 10F);
        tabPage2.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        tabPage2.Location = new System.Drawing.Point(4, 26);
        tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tabPage2.Size = new System.Drawing.Size(338, 403);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "ExeFS";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // tabPage3
        // 
        tabPage3.Font = new System.Drawing.Font("Segoe UI", 10F);
        tabPage3.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        tabPage3.Location = new System.Drawing.Point(4, 26);
        tabPage3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tabPage3.Name = "tabPage3";
        tabPage3.Size = new System.Drawing.Size(338, 403);
        tabPage3.TabIndex = 2;
        tabPage3.Text = "CRO";
        tabPage3.UseVisualStyleBackColor = true;
        // 
        // B_Go
        // 
        B_Go.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_Go.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_Go.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Go.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        B_Go.ForeColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_Go.Location = new System.Drawing.Point(182, 5);
        B_Go.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Go.Name = "B_Go";
        B_Go.Size = new System.Drawing.Size(55, 31);
        B_Go.TabIndex = 0;
        B_Go.Text = "OK";
        B_Go.UseVisualStyleBackColor = false;
        B_Go.Click += B_Go_Click;
        // 
        // B_All
        // 
        B_All.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_All.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_All.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_All.ForeColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_All.Location = new System.Drawing.Point(103, 5);
        B_All.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_All.Name = "B_All";
        B_All.Size = new System.Drawing.Size(52, 31);
        B_All.TabIndex = 1;
        B_All.Text = "All";
        B_All.UseVisualStyleBackColor = false;
        B_All.Click += B_All_Click;
        // 
        // panel1
        // 
        panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        panel1.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        panel1.Controls.Add(B_Go);
        panel1.Controls.Add(B_All);
        panel1.Location = new System.Drawing.Point(-2, 432);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(348, 42);
        panel1.TabIndex = 2;
        // 
        // EnhancedRestore
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        ClientSize = new System.Drawing.Size(345, 471);
        Controls.Add(panel1);
        Controls.Add(tabControl1);
        Font = new System.Drawing.Font("Segoe UI", 10F);
        ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "EnhancedRestore";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "File Restore";
        tabControl1.ResumeLayout(false);
        panel1.ResumeLayout(false);
        ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.Button B_Go;
    private System.Windows.Forms.Button B_All;
    private System.Windows.Forms.Panel panel1;
}
