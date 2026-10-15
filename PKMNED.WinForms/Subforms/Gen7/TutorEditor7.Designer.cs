namespace PKMNED.WinForms;

partial class TutorEditor7
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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TutorEditor7));
        B_Randomize = new System.Windows.Forms.Button();
        B_Save = new System.Windows.Forms.Button();
        B_Cancel = new System.Windows.Forms.Button();
        tabPage3 = new System.Windows.Forms.TabPage();
        dgvmv = new System.Windows.Forms.DataGridView();
        dgvmvIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
        dgvmvMove = new System.Windows.Forms.DataGridViewComboBoxColumn();
        dgvmvBP = new System.Windows.Forms.DataGridViewTextBoxColumn();
        label2 = new System.Windows.Forms.Label();
        CB_LocationBPMove = new System.Windows.Forms.ComboBox();
        tabControl1 = new System.Windows.Forms.TabControl();
        tabPage3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvmv).BeginInit();
        tabControl1.SuspendLayout();
        SuspendLayout();
        // 
        // B_Randomize
        // 
        B_Randomize.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        B_Randomize.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_Randomize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(166, 136, 210);
        B_Randomize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Randomize.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Randomize.ForeColor = System.Drawing.Color.FromArgb(166, 136, 210);
        B_Randomize.Location = new System.Drawing.Point(14, 597);
        B_Randomize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Randomize.Name = "B_Randomize";
        B_Randomize.Size = new System.Drawing.Size(102, 31);
        B_Randomize.TabIndex = 3;
        B_Randomize.Text = "Randomize";
        B_Randomize.UseVisualStyleBackColor = false;
        B_Randomize.Click += B_Randomize_Click;
        // 
        // B_Save
        // 
        B_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        B_Save.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(154, 205, 50);
        B_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Save.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Save.ForeColor = System.Drawing.Color.FromArgb(154, 205, 50);
        B_Save.Location = new System.Drawing.Point(309, 597);
        B_Save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Save.Name = "B_Save";
        B_Save.Size = new System.Drawing.Size(79, 31);
        B_Save.TabIndex = 4;
        B_Save.Text = "Save";
        B_Save.UseVisualStyleBackColor = false;
        B_Save.Click += B_Save_Click;
        // 
        // B_Cancel
        // 
        B_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        B_Cancel.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
        B_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Cancel.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Cancel.ForeColor = System.Drawing.Color.Red;
        B_Cancel.Location = new System.Drawing.Point(223, 597);
        B_Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Cancel.Name = "B_Cancel";
        B_Cancel.Size = new System.Drawing.Size(79, 31);
        B_Cancel.TabIndex = 5;
        B_Cancel.Text = "Cancel";
        B_Cancel.UseVisualStyleBackColor = false;
        B_Cancel.Click += B_Cancel_Click;
        // 
        // tabPage3
        // 
        tabPage3.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        tabPage3.Controls.Add(dgvmv);
        tabPage3.Controls.Add(label2);
        tabPage3.Controls.Add(CB_LocationBPMove);
        tabPage3.Location = new System.Drawing.Point(4, 26);
        tabPage3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tabPage3.Name = "tabPage3";
        tabPage3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tabPage3.Size = new System.Drawing.Size(371, 540);
        tabPage3.TabIndex = 2;
        tabPage3.Text = "Move Tutors";
        // 
        // dgvmv
        // 
        dgvmv.AllowUserToAddRows = false;
        dgvmv.AllowUserToDeleteRows = false;
        dgvmv.AllowUserToResizeColumns = false;
        dgvmv.AllowUserToResizeRows = false;
        dgvmv.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        dgvmv.BackgroundColor = System.Drawing.Color.FromArgb(36, 50, 73);
        dgvmv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvmv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgvmvIndex, dgvmvMove, dgvmvBP });
        dgvmv.Location = new System.Drawing.Point(0, 35);
        dgvmv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        dgvmv.Name = "dgvmv";
        dgvmv.Size = new System.Drawing.Size(370, 500);
        dgvmv.TabIndex = 14;
        // 
        // dgvmvIndex
        // 
        dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
        dgvmvIndex.DefaultCellStyle = dataGridViewCellStyle1;
        dgvmvIndex.HeaderText = "Index";
        dgvmvIndex.MaxInputLength = 3;
        dgvmvIndex.Name = "dgvmvIndex";
        dgvmvIndex.ReadOnly = true;
        dgvmvIndex.Width = 55;
        // 
        // dgvmvMove
        // 
        dgvmvMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        dgvmvMove.HeaderText = "Move";
        dgvmvMove.Name = "dgvmvMove";
        dgvmvMove.Width = 150;
        // 
        // dgvmvBP
        // 
        dgvmvBP.HeaderText = "Price";
        dgvmvBP.MaxInputLength = 3;
        dgvmvBP.Name = "dgvmvBP";
        dgvmvBP.Width = 75;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new System.Drawing.Point(4, 5);
        label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(64, 19);
        label2.TabIndex = 12;
        label2.Text = "Location:";
        // 
        // CB_LocationBPMove
        // 
        CB_LocationBPMove.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        CB_LocationBPMove.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        CB_LocationBPMove.FormattingEnabled = true;
        CB_LocationBPMove.Location = new System.Drawing.Point(70, 3);
        CB_LocationBPMove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CB_LocationBPMove.Name = "CB_LocationBPMove";
        CB_LocationBPMove.Size = new System.Drawing.Size(296, 25);
        CB_LocationBPMove.TabIndex = 11;
        CB_LocationBPMove.SelectedIndexChanged += ChangeIndexBPMove;
        // 
        // tabControl1
        // 
        tabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        tabControl1.Controls.Add(tabPage3);
        tabControl1.Location = new System.Drawing.Point(14, 16);
        tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new System.Drawing.Size(379, 570);
        tabControl1.TabIndex = 15;
        // 
        // TutorEditor7
        //

        dgvmv.ForeColor = System.Drawing.Color.Black;

        AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        ClientSize = new System.Drawing.Size(401, 643);
        Controls.Add(tabControl1);
        Controls.Add(B_Cancel);
        Controls.Add(B_Save);
        Controls.Add(B_Randomize);
        Font = new System.Drawing.Font("Segoe UI", 10F);
        ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MinimumSize = new System.Drawing.Size(417, 380);
        Name = "TutorEditor7";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Tutor Editor";
        tabPage3.ResumeLayout(false);
        tabPage3.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvmv).EndInit();
        tabControl1.ResumeLayout(false);
        ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Button B_Randomize;
    private System.Windows.Forms.Button B_Save;
    private System.Windows.Forms.Button B_Cancel;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.DataGridView dgvmv;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox CB_LocationBPMove;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dgvmvIndex;
    private System.Windows.Forms.DataGridViewComboBoxColumn dgvmvMove;
    private System.Windows.Forms.DataGridViewTextBoxColumn dgvmvBP;
}
