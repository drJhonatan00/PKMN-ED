namespace PKMNED.WinForms;

partial class TypeChart7
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypeChart7));
        PB_Chart = new System.Windows.Forms.PictureBox();
        B_Cancel = new System.Windows.Forms.Button();
        B_Save = new System.Windows.Forms.Button();
        L_Hover = new System.Windows.Forms.Label();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)PB_Chart).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // PB_Chart
        // 
        PB_Chart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        PB_Chart.Location = new System.Drawing.Point(14, 16);
        PB_Chart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        PB_Chart.Name = "PB_Chart";
        PB_Chart.Size = new System.Drawing.Size(580, 580);
        PB_Chart.TabIndex = 0;
        PB_Chart.TabStop = false;
        PB_Chart.MouseClick += ClickMouse;
        PB_Chart.MouseMove += MoveMouse;
        // 
        // B_Cancel
        // 
        B_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        B_Cancel.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
        B_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Cancel.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Cancel.ForeColor = System.Drawing.Color.Red;
        B_Cancel.Location = new System.Drawing.Point(386, 745);
        B_Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Cancel.Name = "B_Cancel";
        B_Cancel.Size = new System.Drawing.Size(88, 31);
        B_Cancel.TabIndex = 467;
        B_Cancel.Text = "Cancel";
        B_Cancel.UseVisualStyleBackColor = false;
        B_Cancel.Click += B_Cancel_Click;
        // 
        // B_Save
        // 
        B_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        B_Save.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(154, 205, 50);
        B_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Save.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Save.ForeColor = System.Drawing.Color.FromArgb(154, 205, 50);
        B_Save.Location = new System.Drawing.Point(482, 745);
        B_Save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
        L_Hover.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Hover.Name = "L_Hover";
        L_Hover.Size = new System.Drawing.Size(166, 20);
        L_Hover.TabIndex = 468;
        L_Hover.Text = "Effectiveness Summary";
        // 
        // pictureBox1
        // 
        pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
        pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        pictureBox1.Location = new System.Drawing.Point(13, 683);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(25, 150);
        pictureBox1.TabIndex = 469;
        pictureBox1.TabStop = false;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new System.Drawing.Point(45, 689);
        label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(110, 19);
        label1.TabIndex = 470;
        label1.Text = "Regular Damage";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new System.Drawing.Point(45, 730);
        label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(153, 19);
        label2.TabIndex = 471;
        label2.Text = "Super Effective Damage";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new System.Drawing.Point(45, 770);
        label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(141, 19);
        label3.TabIndex = 472;
        label3.Text = "Not Effective Damage";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new System.Drawing.Point(45, 809);
        label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(95, 19);
        label4.TabIndex = 473;
        label4.Text = "Doesn't Affect";
        // 
        // TypeChart7
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        ClientSize = new System.Drawing.Size(608, 843);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(pictureBox1);
        Controls.Add(L_Hover);
        Controls.Add(B_Cancel);
        Controls.Add(B_Save);
        Controls.Add(PB_Chart);
        Font = new System.Drawing.Font("Segoe UI", 10F);
        ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MinimumSize = new System.Drawing.Size(412, 276);
        Name = "TypeChart7";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Type Chart Editor";
        ((System.ComponentModel.ISupportInitialize)PB_Chart).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox PB_Chart;
    private System.Windows.Forms.Button B_Cancel;
    private System.Windows.Forms.Button B_Save;
    private System.Windows.Forms.Label L_Hover;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
}
