using System.Windows.Forms;

namespace PKMNED.WinForms;

partial class TypeChart6
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypeChart6));
        PB_Chart = new PictureBox();
        B_Cancel = new Button();
        B_Save = new Button();
        L_Hover = new Label();
        ((System.ComponentModel.ISupportInitialize)PB_Chart).BeginInit();
        SuspendLayout();
        // 
        // PB_Chart
        // 
        PB_Chart.BorderStyle = BorderStyle.FixedSingle;
        PB_Chart.Location = new System.Drawing.Point(14, 16);
        PB_Chart.Margin = new Padding(4, 3, 4, 3);
        PB_Chart.Name = "PB_Chart";
        PB_Chart.Size = new System.Drawing.Size(580, 580);
        PB_Chart.TabIndex = 0;
        PB_Chart.TabStop = false;
        PB_Chart.MouseClick += ClickMouse;
        PB_Chart.MouseMove += MoveMouse;
        // 
        // B_Cancel
        // 
        B_Cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        B_Cancel.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
        B_Cancel.FlatStyle = FlatStyle.Flat;
        B_Cancel.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Cancel.ForeColor = System.Drawing.Color.Red;
        B_Cancel.Location = new System.Drawing.Point(14, 648);
        B_Cancel.Margin = new Padding(4, 3, 4, 3);
        B_Cancel.Name = "B_Cancel";
        B_Cancel.Size = new System.Drawing.Size(88, 31);
        B_Cancel.TabIndex = 467;
        B_Cancel.Text = "Cancel";
        B_Cancel.UseVisualStyleBackColor = false;
        B_Cancel.Click += B_Cancel_Click;
        // 
        // B_Save
        // 
        B_Save.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        B_Save.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(154, 205, 50);
        B_Save.FlatStyle = FlatStyle.Flat;
        B_Save.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Save.ForeColor = System.Drawing.Color.FromArgb(154, 205, 50);
        B_Save.Location = new System.Drawing.Point(110, 648);
        B_Save.Margin = new Padding(4, 3, 4, 3);
        B_Save.Name = "B_Save";
        B_Save.Size = new System.Drawing.Size(88, 31);
        B_Save.TabIndex = 466;
        B_Save.Text = "Save";
        B_Save.UseVisualStyleBackColor = false;
        B_Save.Click += B_Save_Click;
        // 
        // L_Hover
        // 
        L_Hover.AutoSize = true;
        L_Hover.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
        L_Hover.ForeColor = System.Drawing.Color.FromArgb(56, 189, 248);
        L_Hover.Location = new System.Drawing.Point(14, 609);
        L_Hover.Margin = new Padding(4, 0, 4, 0);
        L_Hover.Name = "L_Hover";
        L_Hover.Size = new System.Drawing.Size(166, 20);
        L_Hover.TabIndex = 468;
        L_Hover.Text = "Effectiveness Summary";
        // 
        // TypeChart6
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        ClientSize = new System.Drawing.Size(608, 691);
        Controls.Add(L_Hover);
        Controls.Add(B_Cancel);
        Controls.Add(B_Save);
        Controls.Add(PB_Chart);
        Font = new System.Drawing.Font("Segoe UI", 10F);
        ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MinimumSize = new System.Drawing.Size(412, 276);
        Name = "TypeChart6";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Type Chart Editor";
        ((System.ComponentModel.ISupportInitialize)PB_Chart).EndInit();
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox PB_Chart;
    private System.Windows.Forms.Button B_Cancel;
    private System.Windows.Forms.Button B_Save;
    private System.Windows.Forms.Label L_Hover;

}
