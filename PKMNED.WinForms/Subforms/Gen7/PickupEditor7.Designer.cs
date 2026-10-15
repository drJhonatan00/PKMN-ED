namespace PKMNED.WinForms;

partial class PickupEditor7
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PickupEditor7));
        B_Save = new System.Windows.Forms.Button();
        B_Cancel = new System.Windows.Forms.Button();
        B_Randomize = new System.Windows.Forms.Button();
        dgvCommon = new System.Windows.Forms.DataGridView();
        B_AddRow = new System.Windows.Forms.Button();
        B_DeleteRow = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)dgvCommon).BeginInit();
        SuspendLayout();
        // 
        // B_Save
        //
        B_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        B_Save.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(154, 205, 50);
        B_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Save.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Save.ForeColor = System.Drawing.Color.FromArgb(154, 205, 50);
        B_Save.Location = new System.Drawing.Point(696, 433);
        B_Save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Save.Name = "B_Save";
        B_Save.Size = new System.Drawing.Size(88, 31);
        B_Save.TabIndex = 7;
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
        B_Cancel.Location = new System.Drawing.Point(602, 433);
        B_Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Cancel.Name = "B_Cancel";
        B_Cancel.Size = new System.Drawing.Size(88, 31);
        B_Cancel.TabIndex = 8;
        B_Cancel.Text = "Cancel";
        B_Cancel.UseVisualStyleBackColor = false;
        B_Cancel.Click += B_Cancel_Click;
        // 
        // B_Randomize
        // 
        B_Randomize.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        B_Randomize.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_Randomize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_Randomize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Randomize.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Randomize.ForeColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_Randomize.Location = new System.Drawing.Point(10, 433);
        B_Randomize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Randomize.Name = "B_Randomize";
        B_Randomize.Size = new System.Drawing.Size(88, 31);
        B_Randomize.TabIndex = 9;
        B_Randomize.Text = "Randomize";
        B_Randomize.UseVisualStyleBackColor = false;
        B_Randomize.Click += B_Randomize_Click;
        // 
        // dgvCommon
        // 
        dgvCommon.AllowUserToResizeColumns = false;
        dgvCommon.AllowUserToResizeRows = false;
        dgvCommon.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        dgvCommon.BackgroundColor = System.Drawing.Color.FromArgb(30, 41, 59);
        dgvCommon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvCommon.Location = new System.Drawing.Point(14, 16);
        dgvCommon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        dgvCommon.Name = "dgvCommon";
        dgvCommon.Size = new System.Drawing.Size(765, 392);
        dgvCommon.TabIndex = 10;
        dgvCommon.CellContentClick += dgvCommon_CellContentClick;
        // 
        // B_AddRow
        // 
        B_AddRow.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        B_AddRow.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_AddRow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_AddRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_AddRow.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_AddRow.ForeColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_AddRow.Location = new System.Drawing.Point(105, 433);
        B_AddRow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_AddRow.Name = "B_AddRow";
        B_AddRow.Size = new System.Drawing.Size(88, 31);
        B_AddRow.TabIndex = 11;
        B_AddRow.Text = "Add Row";
        B_AddRow.UseVisualStyleBackColor = false;
        B_AddRow.Click += B_AddRow_Click;
        // 
        // B_DeleteRow
        // 
        B_DeleteRow.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        B_DeleteRow.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_DeleteRow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_DeleteRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_DeleteRow.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_DeleteRow.ForeColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_DeleteRow.Location = new System.Drawing.Point(200, 433);
        B_DeleteRow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_DeleteRow.Name = "B_DeleteRow";
        B_DeleteRow.Size = new System.Drawing.Size(88, 31);
        B_DeleteRow.TabIndex = 12;
        B_DeleteRow.Text = "Delete Row";
        B_DeleteRow.UseVisualStyleBackColor = false;
        B_DeleteRow.Click += B_DeleteRow_Click;
        // 
        // PickupEditor7
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        ClientSize = new System.Drawing.Size(793, 473);
        Controls.Add(B_DeleteRow);
        Controls.Add(B_AddRow);
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

    }

    #endregion
    private System.Windows.Forms.Button B_Save;
    private System.Windows.Forms.Button B_Cancel;
    private System.Windows.Forms.Button B_Randomize;
    private System.Windows.Forms.DataGridView dgvCommon;
    private System.Windows.Forms.Button B_AddRow;
    private System.Windows.Forms.Button B_DeleteRow;
}
