namespace PKMNED.WinForms;

partial class TutorEditor6
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TutorEditor6));
        CB_Location = new System.Windows.Forms.ComboBox();
        dgv = new System.Windows.Forms.DataGridView();
        L_Mart = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
        SuspendLayout();
        // 
        // CB_Location
        // 
        CB_Location.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        CB_Location.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        CB_Location.FormattingEnabled = true;
        CB_Location.Location = new System.Drawing.Point(80, 7);
        CB_Location.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CB_Location.Name = "CB_Location";
        CB_Location.Size = new System.Drawing.Size(283, 23);
        CB_Location.TabIndex = 0;
        CB_Location.SelectedIndexChanged += ChangeIndex;
        // 
        // dgv
        // 
        dgv.AllowUserToAddRows = false;
        dgv.AllowUserToDeleteRows = false;
        dgv.AllowUserToResizeColumns = false;
        dgv.AllowUserToResizeRows = false;
        dgv.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv.Location = new System.Drawing.Point(14, 38);
        dgv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        dgv.Name = "dgv";
        dgv.Size = new System.Drawing.Size(350, 366);
        dgv.TabIndex = 1;
        // 
        // L_Mart
        // 
        L_Mart.AutoSize = true;
        L_Mart.Location = new System.Drawing.Point(14, 10);
        L_Mart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Mart.Name = "L_Mart";
        L_Mart.Size = new System.Drawing.Size(56, 15);
        L_Mart.TabIndex = 2;
        L_Mart.Text = "Location:";
        // 
        // TutorEditor6
        //
        BackColor = bg;
        ForeColor = text;
        Font = font;
        dgv.ForeColor = System.Drawing.Color.Black;
        dgv.BackgroundColor = surface;
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(378, 418);
        Controls.Add(L_Mart);
        Controls.Add(dgv);
        Controls.Add(CB_Location);
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MaximumSize = new System.Drawing.Size(394, 686);
        MinimumSize = new System.Drawing.Size(394, 456);
        Name = "TutorEditor6";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Move Tutor Editor";
        FormClosing += Form_Closing;
        ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox CB_Location;
    private System.Windows.Forms.DataGridView dgv;
    private System.Windows.Forms.Label L_Mart;
}
