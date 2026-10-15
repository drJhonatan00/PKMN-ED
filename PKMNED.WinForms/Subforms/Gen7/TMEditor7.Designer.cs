namespace PKMNED.WinForms;

partial class TMEditor7
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TMEditor7));
        dgvTM = new System.Windows.Forms.DataGridView();
        L_TM = new System.Windows.Forms.Label();
        B_RTM = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)dgvTM).BeginInit();
        SuspendLayout();
        // 
        // dgvTM
        // 
        dgvTM.AllowUserToAddRows = false;
        dgvTM.AllowUserToDeleteRows = false;
        dgvTM.AllowUserToResizeColumns = false;
        dgvTM.AllowUserToResizeRows = false;
        dgvTM.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        dgvTM.BackgroundColor = System.Drawing.Color.FromArgb(30, 41, 59);
        dgvTM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvTM.Location = new System.Drawing.Point(10, 44);
        dgvTM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        dgvTM.Name = "dgvTM";
        dgvTM.Size = new System.Drawing.Size(280, 377);
        dgvTM.TabIndex = 1;
        // 
        // L_TM
        // 
        L_TM.AutoSize = true;
        L_TM.Location = new System.Drawing.Point(10, 11);
        L_TM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_TM.Name = "L_TM";
        L_TM.Size = new System.Drawing.Size(32, 19);
        L_TM.TabIndex = 2;
        L_TM.Text = "TM:";
        // 
        // B_RTM
        // 
        B_RTM.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_RTM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_RTM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_RTM.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_RTM.ForeColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_RTM.Location = new System.Drawing.Point(50, 7);
        B_RTM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_RTM.Name = "B_RTM";
        B_RTM.Size = new System.Drawing.Size(88, 31);
        B_RTM.TabIndex = 5;
        B_RTM.Text = "Randomize";
        B_RTM.UseVisualStyleBackColor = false;
        B_RTM.Click += B_RandomTM_Click;
        // 
        // TMEditor7
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        ClientSize = new System.Drawing.Size(302, 433);
        Controls.Add(B_RTM);
        Controls.Add(L_TM);
        Controls.Add(dgvTM);
        Font = new System.Drawing.Font("Segoe UI", 10F);
        L_TM.ForeColor = ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        dgvTM.ForeColor = System.Drawing.Color.Black;
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MaximumSize = new System.Drawing.Size(604, 864);
        MinimumSize = new System.Drawing.Size(318, 472);
        Name = "TMEditor7";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "TM Editor";
        FormClosing += Form_Closing;
        Load += TMEditor7_Load;
        ((System.ComponentModel.ISupportInitialize)dgvTM).EndInit();
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dgvTM;
    private System.Windows.Forms.Label L_TM;
    private System.Windows.Forms.Button B_RTM;
}
