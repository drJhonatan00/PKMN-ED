namespace PKMNED.WinForms;

partial class PickupEditor6
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PickupEditor6));
        dgvCommon = new System.Windows.Forms.DataGridView();
        L_TM = new System.Windows.Forms.Label();
        dgvRare = new System.Windows.Forms.DataGridView();
        L_HM = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        B_Save = new System.Windows.Forms.Button();
        B_Cancel = new System.Windows.Forms.Button();
        B_Randomize = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)dgvCommon).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvRare).BeginInit();
        SuspendLayout();
        // 
        // dgvCommon
        // 
        dgvCommon.AllowUserToAddRows = false;
        dgvCommon.AllowUserToDeleteRows = false;
        dgvCommon.AllowUserToResizeColumns = false;
        dgvCommon.AllowUserToResizeRows = false;
        dgvCommon.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        dgvCommon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvCommon.Location = new System.Drawing.Point(10, 29);
        dgvCommon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        dgvCommon.Name = "dgvCommon";
        dgvCommon.Size = new System.Drawing.Size(280, 346);
        dgvCommon.TabIndex = 1;
        // 
        // L_TM
        // 
        L_TM.AutoSize = true;
        L_TM.Location = new System.Drawing.Point(10, 10);
        L_TM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_TM.Name = "L_TM";
        L_TM.Size = new System.Drawing.Size(115, 15);
        L_TM.TabIndex = 2;
        L_TM.Text = "Common (30%-4%):";
        // 
        // dgvRare
        // 
        dgvRare.AllowUserToAddRows = false;
        dgvRare.AllowUserToDeleteRows = false;
        dgvRare.AllowUserToResizeColumns = false;
        dgvRare.AllowUserToResizeRows = false;
        dgvRare.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        dgvRare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvRare.Location = new System.Drawing.Point(299, 29);
        dgvRare.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        dgvRare.Name = "dgvRare";
        dgvRare.Size = new System.Drawing.Size(280, 346);
        dgvRare.TabIndex = 3;
        // 
        // L_HM
        // 
        L_HM.AutoSize = true;
        L_HM.Location = new System.Drawing.Point(295, 10);
        L_HM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_HM.Name = "L_HM";
        L_HM.Size = new System.Drawing.Size(60, 15);
        L_HM.TabIndex = 4;
        L_HM.Text = "Rare (1%):";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new System.Drawing.Point(131, 10);
        label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(107, 15);
        label1.TabIndex = 5;
        label1.Text = "(level-1)/10, take 9.";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new System.Drawing.Point(368, 10);
        label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(107, 15);
        label2.TabIndex = 6;
        label2.Text = "(level-1)/10, take 2.";
        // 
        // B_Save
        // 
        B_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        B_Save.Location = new System.Drawing.Point(491, 382);
        B_Save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Save.Name = "B_Save";
        B_Save.Size = new System.Drawing.Size(88, 27);
        B_Save.TabIndex = 7;
        B_Save.Text = "Save";
        B_Save.UseVisualStyleBackColor = true;
        B_Save.Click += B_Save_Click;
        B_Save.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(154, 205, 50);
        B_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Save.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Save.ForeColor = System.Drawing.Color.FromArgb(154, 205, 50);
        // 
        // B_Cancel
        // 
        B_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        B_Cancel.Location = new System.Drawing.Point(397, 382);
        B_Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Cancel.Name = "B_Cancel";
        B_Cancel.Size = new System.Drawing.Size(88, 27);
        B_Cancel.TabIndex = 8;
        B_Cancel.Text = "Cancel";
        B_Cancel.UseVisualStyleBackColor = true;
        B_Cancel.Click += B_Cancel_Click;
        B_Cancel.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
        B_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Cancel.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Cancel.ForeColor = System.Drawing.Color.Red;
        // 
        // B_Randomize
        // 
        B_Randomize.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        B_Randomize.Location = new System.Drawing.Point(10, 382);
        B_Randomize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Randomize.Name = "B_Randomize";
        B_Randomize.Size = new System.Drawing.Size(88, 27);
        B_Randomize.TabIndex = 9;
        B_Randomize.Text = "Randomize";
        B_Randomize.UseVisualStyleBackColor = true;
        B_Randomize.Click += B_Randomize_Click;
        B_Randomize.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_Randomize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_Randomize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Randomize.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Randomize.ForeColor = System.Drawing.Color.FromArgb(56, 189, 248);
        // 
        // PickupEditor6
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
        ForeColor = text;
        dgvCommon.BackgroundColor = surface;
        dgvCommon.ForeColor = System.Drawing.Color.Black;
        dgvCommon.Font = font;
        dgvRare.BackgroundColor = surface;
        dgvRare.ForeColor = System.Drawing.Color.Black;
        dgvRare.Font = font;
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        ClientSize = new System.Drawing.Size(793, 473);
        Controls.Add(dgvCommon);
        Controls.Add(B_Randomize);
        Controls.Add(B_Cancel);
        Controls.Add(B_Save);
        Font = new System.Drawing.Font("Segoe UI", 10F);
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MinimumSize = new System.Drawing.Size(697, 512);
        Name = "PickupEditor7";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Pickup Editor";
        ((System.ComponentModel.ISupportInitialize)dgvCommon).EndInit();
        ResumeLayout(false);
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(588, 417);
        Controls.Add(B_Randomize);
        Controls.Add(B_Cancel);
        Controls.Add(B_Save);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(L_HM);
        Controls.Add(dgvRare);
        Controls.Add(L_TM);
        Controls.Add(dgvCommon);
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MaximumSize = new System.Drawing.Size(604, 767);
        MinimumSize = new System.Drawing.Size(604, 456);
        Name = "PickupEditor6";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Pickup Editor";
        ((System.ComponentModel.ISupportInitialize)dgvCommon).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvRare).EndInit();
        ResumeLayout(false);
        PerformLayout();



    }

    #endregion

    private System.Windows.Forms.DataGridView dgvCommon;
    private System.Windows.Forms.Label L_TM;
    private System.Windows.Forms.DataGridView dgvRare;
    private System.Windows.Forms.Label L_HM;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button B_Save;
    private System.Windows.Forms.Button B_Cancel;
    private System.Windows.Forms.Button B_Randomize;
}
