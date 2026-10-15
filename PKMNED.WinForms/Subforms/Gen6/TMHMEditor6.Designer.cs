namespace PKMNED.WinForms;

partial class TMHMEditor6
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TMHMEditor6));
        dgvTM = new System.Windows.Forms.DataGridView();
        L_TM = new System.Windows.Forms.Label();
        dgvHM = new System.Windows.Forms.DataGridView();
        L_HM = new System.Windows.Forms.Label();
        B_RTM = new System.Windows.Forms.Button();
        CHK_RandomizeHM = new System.Windows.Forms.CheckBox();
        CHK_RandomizeField = new System.Windows.Forms.CheckBox();
        groupBox1 = new System.Windows.Forms.GroupBox();
        ((System.ComponentModel.ISupportInitialize)dgvTM).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvHM).BeginInit();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // dgvTM
        // 
        dgvTM.AllowUserToAddRows = false;
        dgvTM.AllowUserToDeleteRows = false;
        dgvTM.AllowUserToResizeColumns = false;
        dgvTM.AllowUserToResizeRows = false;
        dgvTM.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        dgvTM.BackgroundColor = System.Drawing.Color.FromArgb(30, 41, 59);
        dgvTM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvTM.Location = new System.Drawing.Point(10, 58);
        dgvTM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        dgvTM.Name = "dgvTM";
        dgvTM.Size = new System.Drawing.Size(280, 501);
        dgvTM.TabIndex = 1;
        // 
        // L_TM
        // 
        L_TM.AutoSize = true;
        L_TM.Location = new System.Drawing.Point(10, 38);
        L_TM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_TM.Name = "L_TM";
        L_TM.Size = new System.Drawing.Size(32, 19);
        L_TM.TabIndex = 2;
        L_TM.Text = "TM:";
        // 
        // dgvHM
        // 
        dgvHM.AllowUserToAddRows = false;
        dgvHM.AllowUserToDeleteRows = false;
        dgvHM.AllowUserToResizeColumns = false;
        dgvHM.AllowUserToResizeRows = false;
        dgvHM.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        dgvHM.BackgroundColor = System.Drawing.Color.FromArgb(30, 41, 59);
        dgvHM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvHM.Location = new System.Drawing.Point(299, 58);
        dgvHM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        dgvHM.Name = "dgvHM";
        dgvHM.Size = new System.Drawing.Size(280, 412);
        dgvHM.TabIndex = 3;
        // 
        // L_HM
        // 
        L_HM.AutoSize = true;
        L_HM.Location = new System.Drawing.Point(295, 39);
        L_HM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_HM.Name = "L_HM";
        L_HM.Size = new System.Drawing.Size(35, 19);
        L_HM.TabIndex = 4;
        L_HM.Text = "HM:";
        // 
        // B_RTM
        // 
        B_RTM.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_RTM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(166, 136, 210);
        B_RTM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_RTM.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_RTM.ForeColor = System.Drawing.Color.FromArgb(166, 136, 210);
        B_RTM.Location = new System.Drawing.Point(10, 4);
        B_RTM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_RTM.Name = "B_RTM";
        B_RTM.Size = new System.Drawing.Size(88, 31);
        B_RTM.TabIndex = 5;
        B_RTM.Text = "Randomize";
        B_RTM.UseVisualStyleBackColor = false;
        B_RTM.Click += B_RandomTM_Click;
        // 
        // CHK_RandomizeHM
        // 
        CHK_RandomizeHM.AutoSize = true;
        CHK_RandomizeHM.Location = new System.Drawing.Point(15, 25);
        CHK_RandomizeHM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_RandomizeHM.Name = "CHK_RandomizeHM";
        CHK_RandomizeHM.Size = new System.Drawing.Size(128, 23);
        CHK_RandomizeHM.TabIndex = 280;
        CHK_RandomizeHM.Text = "Randomize HMs";
        CHK_RandomizeHM.UseVisualStyleBackColor = true;
        // 
        // CHK_RandomizeField
        // 
        CHK_RandomizeField.AutoSize = true;
        CHK_RandomizeField.Location = new System.Drawing.Point(15, 48);
        CHK_RandomizeField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CHK_RandomizeField.Name = "CHK_RandomizeField";
        CHK_RandomizeField.Size = new System.Drawing.Size(172, 23);
        CHK_RandomizeField.TabIndex = 281;
        CHK_RandomizeField.Text = "Randomize Field Moves";
        CHK_RandomizeField.UseVisualStyleBackColor = true;
        // 
        // groupBox1
        // 
        groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        groupBox1.Controls.Add(CHK_RandomizeHM);
        groupBox1.Controls.Add(CHK_RandomizeField);
        groupBox1.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        groupBox1.Location = new System.Drawing.Point(299, 476);
        groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        groupBox1.Size = new System.Drawing.Size(280, 83);
        groupBox1.TabIndex = 282;
        groupBox1.TabStop = false;
        groupBox1.Text = "Randomization Settings";
        // 
        // TMHMEditor6
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        ClientSize = new System.Drawing.Size(588, 568);
        Controls.Add(groupBox1);
        Controls.Add(B_RTM);
        Controls.Add(L_HM);
        Controls.Add(dgvHM);
        Controls.Add(L_TM);
        Controls.Add(dgvTM);
        Font = new System.Drawing.Font("Segoe UI", 10F);
        ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MaximumSize = new System.Drawing.Size(604, 864);
        MinimumSize = new System.Drawing.Size(604, 472);
        Name = "TMHMEditor6";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "TM / HM Editor";
        FormClosing += Form_Closing;
        ((System.ComponentModel.ISupportInitialize)dgvTM).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvHM).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dgvTM;
    private System.Windows.Forms.Label L_TM;
    private System.Windows.Forms.DataGridView dgvHM;
    private System.Windows.Forms.Label L_HM;
    private System.Windows.Forms.Button B_RTM;
    private System.Windows.Forms.CheckBox CHK_RandomizeHM;
    private System.Windows.Forms.CheckBox CHK_RandomizeField;
    private System.Windows.Forms.GroupBox groupBox1;
}
