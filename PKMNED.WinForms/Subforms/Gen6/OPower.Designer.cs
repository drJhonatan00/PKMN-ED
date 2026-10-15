namespace PKMNED.WinForms;

partial class OPower
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OPower));
        RTB = new System.Windows.Forms.RichTextBox();
        TB_Name = new System.Windows.Forms.TextBox();
        TB_Type = new System.Windows.Forms.TextBox();
        NUD_PlayerCost = new System.Windows.Forms.NumericUpDown();
        NUD_OtherCost = new System.Windows.Forms.NumericUpDown();
        NUD_Stage = new System.Windows.Forms.NumericUpDown();
        NUD_LevelUp = new System.Windows.Forms.NumericUpDown();
        CB_Item = new System.Windows.Forms.ComboBox();
        NUD_Duration = new System.Windows.Forms.NumericUpDown();
        NUD_Efficacy = new System.Windows.Forms.NumericUpDown();
        L_PlayerCost = new System.Windows.Forms.Label();
        L_OtherCost = new System.Windows.Forms.Label();
        L_Stage = new System.Windows.Forms.Label();
        L_LevelUp = new System.Windows.Forms.Label();
        L_Duration = new System.Windows.Forms.Label();
        L_Efficacy = new System.Windows.Forms.Label();
        TB_Mini = new System.Windows.Forms.TextBox();
        TB_Quality = new System.Windows.Forms.TextBox();
        NUD_2 = new System.Windows.Forms.NumericUpDown();
        NUD_Usability = new System.Windows.Forms.NumericUpDown();
        L_2 = new System.Windows.Forms.Label();
        CB_SortOrder = new System.Windows.Forms.ComboBox();
        L_UsabilityText = new System.Windows.Forms.Label();
        L_Usability = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)NUD_PlayerCost).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_OtherCost).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Stage).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_LevelUp).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Duration).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Efficacy).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Usability).BeginInit();
        SuspendLayout();
        // 
        // RTB
        // 
        RTB.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        RTB.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        RTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
        RTB.Font = new System.Drawing.Font("Segoe UI", 10F);
        RTB.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        RTB.Location = new System.Drawing.Point(14, 111);
        RTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        RTB.Name = "RTB";
        RTB.ReadOnly = true;
        RTB.Size = new System.Drawing.Size(275, 80);
        RTB.TabIndex = 38;
        RTB.Text = "";
        // 
        // TB_Name
        // 
        TB_Name.Location = new System.Drawing.Point(74, 15);
        TB_Name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        TB_Name.Name = "TB_Name";
        TB_Name.ReadOnly = true;
        TB_Name.Size = new System.Drawing.Size(157, 25);
        TB_Name.TabIndex = 39;
        // 
        // TB_Type
        // 
        TB_Type.Location = new System.Drawing.Point(14, 49);
        TB_Type.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        TB_Type.Name = "TB_Type";
        TB_Type.ReadOnly = true;
        TB_Type.Size = new System.Drawing.Size(157, 25);
        TB_Type.TabIndex = 40;
        // 
        // NUD_PlayerCost
        // 
        NUD_PlayerCost.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        NUD_PlayerCost.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_PlayerCost.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_PlayerCost.Location = new System.Drawing.Point(382, 16);
        NUD_PlayerCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_PlayerCost.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
        NUD_PlayerCost.Name = "NUD_PlayerCost";
        NUD_PlayerCost.Size = new System.Drawing.Size(52, 25);
        NUD_PlayerCost.TabIndex = 42;
        // 
        // NUD_OtherCost
        // 
        NUD_OtherCost.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        NUD_OtherCost.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_OtherCost.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_OtherCost.Location = new System.Drawing.Point(382, 50);
        NUD_OtherCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_OtherCost.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
        NUD_OtherCost.Name = "NUD_OtherCost";
        NUD_OtherCost.Size = new System.Drawing.Size(52, 25);
        NUD_OtherCost.TabIndex = 43;
        // 
        // NUD_Stage
        // 
        NUD_Stage.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        NUD_Stage.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_Stage.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_Stage.Location = new System.Drawing.Point(382, 84);
        NUD_Stage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_Stage.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
        NUD_Stage.Name = "NUD_Stage";
        NUD_Stage.Size = new System.Drawing.Size(52, 25);
        NUD_Stage.TabIndex = 44;
        // 
        // NUD_LevelUp
        // 
        NUD_LevelUp.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        NUD_LevelUp.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_LevelUp.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_LevelUp.Location = new System.Drawing.Point(382, 118);
        NUD_LevelUp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_LevelUp.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
        NUD_LevelUp.Name = "NUD_LevelUp";
        NUD_LevelUp.Size = new System.Drawing.Size(52, 25);
        NUD_LevelUp.TabIndex = 45;
        // 
        // CB_Item
        // 
        CB_Item.FormattingEnabled = true;
        CB_Item.Location = new System.Drawing.Point(14, 15);
        CB_Item.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CB_Item.Name = "CB_Item";
        CB_Item.Size = new System.Drawing.Size(52, 25);
        CB_Item.TabIndex = 46;
        CB_Item.SelectedIndexChanged += ChangeEntry;
        // 
        // NUD_Duration
        // 
        NUD_Duration.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        NUD_Duration.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_Duration.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_Duration.Location = new System.Drawing.Point(382, 152);
        NUD_Duration.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_Duration.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
        NUD_Duration.Name = "NUD_Duration";
        NUD_Duration.Size = new System.Drawing.Size(52, 25);
        NUD_Duration.TabIndex = 47;
        // 
        // NUD_Efficacy
        // 
        NUD_Efficacy.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        NUD_Efficacy.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_Efficacy.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_Efficacy.Location = new System.Drawing.Point(382, 186);
        NUD_Efficacy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_Efficacy.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
        NUD_Efficacy.Name = "NUD_Efficacy";
        NUD_Efficacy.Size = new System.Drawing.Size(52, 25);
        NUD_Efficacy.TabIndex = 48;
        // 
        // L_PlayerCost
        // 
        L_PlayerCost.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        L_PlayerCost.Location = new System.Drawing.Point(258, 11);
        L_PlayerCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_PlayerCost.Name = "L_PlayerCost";
        L_PlayerCost.Size = new System.Drawing.Size(117, 31);
        L_PlayerCost.TabIndex = 49;
        L_PlayerCost.Text = "Player Cost:";
        L_PlayerCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // L_OtherCost
        // 
        L_OtherCost.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        L_OtherCost.Location = new System.Drawing.Point(258, 45);
        L_OtherCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_OtherCost.Name = "L_OtherCost";
        L_OtherCost.Size = new System.Drawing.Size(117, 31);
        L_OtherCost.TabIndex = 50;
        L_OtherCost.Text = "Other Cost:";
        L_OtherCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // L_Stage
        // 
        L_Stage.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        L_Stage.Location = new System.Drawing.Point(258, 79);
        L_Stage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Stage.Name = "L_Stage";
        L_Stage.Size = new System.Drawing.Size(117, 31);
        L_Stage.TabIndex = 51;
        L_Stage.Text = "Stage:";
        L_Stage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // L_LevelUp
        // 
        L_LevelUp.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        L_LevelUp.Location = new System.Drawing.Point(258, 113);
        L_LevelUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_LevelUp.Name = "L_LevelUp";
        L_LevelUp.Size = new System.Drawing.Size(117, 31);
        L_LevelUp.TabIndex = 52;
        L_LevelUp.Text = "Level Up:";
        L_LevelUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // L_Duration
        // 
        L_Duration.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        L_Duration.Location = new System.Drawing.Point(258, 147);
        L_Duration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Duration.Name = "L_Duration";
        L_Duration.Size = new System.Drawing.Size(117, 31);
        L_Duration.TabIndex = 53;
        L_Duration.Text = "Duration:";
        L_Duration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // L_Efficacy
        // 
        L_Efficacy.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        L_Efficacy.Location = new System.Drawing.Point(258, 181);
        L_Efficacy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Efficacy.Name = "L_Efficacy";
        L_Efficacy.Size = new System.Drawing.Size(117, 31);
        L_Efficacy.TabIndex = 54;
        L_Efficacy.Text = "Efficacy:";
        L_Efficacy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // TB_Mini
        // 
        TB_Mini.Location = new System.Drawing.Point(178, 49);
        TB_Mini.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        TB_Mini.Name = "TB_Mini";
        TB_Mini.ReadOnly = true;
        TB_Mini.Size = new System.Drawing.Size(52, 25);
        TB_Mini.TabIndex = 55;
        // 
        // TB_Quality
        // 
        TB_Quality.Location = new System.Drawing.Point(14, 77);
        TB_Quality.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        TB_Quality.Name = "TB_Quality";
        TB_Quality.ReadOnly = true;
        TB_Quality.Size = new System.Drawing.Size(157, 25);
        TB_Quality.TabIndex = 57;
        // 
        // NUD_2
        // 
        NUD_2.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_2.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_2.Location = new System.Drawing.Point(228, 197);
        NUD_2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_2.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
        NUD_2.Name = "NUD_2";
        NUD_2.ReadOnly = true;
        NUD_2.Size = new System.Drawing.Size(52, 25);
        NUD_2.TabIndex = 58;
        // 
        // NUD_Usability
        // 
        NUD_Usability.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        NUD_Usability.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        NUD_Usability.Location = new System.Drawing.Point(104, 199);
        NUD_Usability.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        NUD_Usability.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
        NUD_Usability.Name = "NUD_Usability";
        NUD_Usability.Size = new System.Drawing.Size(52, 25);
        NUD_Usability.TabIndex = 59;
        // 
        // L_2
        // 
        L_2.AutoSize = true;
        L_2.Location = new System.Drawing.Point(210, 200);
        L_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_2.Name = "L_2";
        L_2.Size = new System.Drawing.Size(17, 19);
        L_2.TabIndex = 63;
        L_2.Text = "2";
        // 
        // CB_SortOrder
        // 
        CB_SortOrder.Enabled = false;
        CB_SortOrder.FormattingEnabled = true;
        CB_SortOrder.Location = new System.Drawing.Point(178, 77);
        CB_SortOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        CB_SortOrder.Name = "CB_SortOrder";
        CB_SortOrder.Size = new System.Drawing.Size(52, 25);
        CB_SortOrder.TabIndex = 64;
        // 
        // L_UsabilityText
        // 
        L_UsabilityText.AutoSize = true;
        L_UsabilityText.Location = new System.Drawing.Point(4, 233);
        L_UsabilityText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_UsabilityText.Name = "L_UsabilityText";
        L_UsabilityText.Size = new System.Drawing.Size(222, 19);
        L_UsabilityText.TabIndex = 65;
        L_UsabilityText.Text = "254 - Nobody, 0 - Self, 2 - Anyone";
        // 
        // L_Usability
        // 
        L_Usability.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        L_Usability.Location = new System.Drawing.Point(-21, 194);
        L_Usability.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Usability.Name = "L_Usability";
        L_Usability.Size = new System.Drawing.Size(117, 31);
        L_Usability.TabIndex = 66;
        L_Usability.Text = "Usability(?):";
        L_Usability.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // OPower
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        ClientSize = new System.Drawing.Size(448, 254);
        Controls.Add(L_UsabilityText);
        Controls.Add(CB_SortOrder);
        Controls.Add(TB_Name);
        Controls.Add(L_2);
        Controls.Add(NUD_Usability);
        Controls.Add(NUD_2);
        Controls.Add(TB_Quality);
        Controls.Add(TB_Mini);
        Controls.Add(L_Stage);
        Controls.Add(L_OtherCost);
        Controls.Add(L_PlayerCost);
        Controls.Add(NUD_Efficacy);
        Controls.Add(NUD_Duration);
        Controls.Add(CB_Item);
        Controls.Add(NUD_LevelUp);
        Controls.Add(NUD_Stage);
        Controls.Add(NUD_OtherCost);
        Controls.Add(NUD_PlayerCost);
        Controls.Add(TB_Type);
        Controls.Add(RTB);
        Controls.Add(L_Efficacy);
        Controls.Add(L_Duration);
        Controls.Add(L_LevelUp);
        Controls.Add(L_Usability);
        Font = new System.Drawing.Font("Segoe UI", 10F);
        ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "OPower";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "O-Power Editor";
        FormClosing += Form_Closing;
        ((System.ComponentModel.ISupportInitialize)NUD_PlayerCost).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_OtherCost).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Stage).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_LevelUp).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Duration).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Efficacy).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_2).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Usability).EndInit();
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private System.Windows.Forms.RichTextBox RTB;
    private System.Windows.Forms.TextBox TB_Name;
    private System.Windows.Forms.TextBox TB_Type;
    private System.Windows.Forms.NumericUpDown NUD_PlayerCost;
    private System.Windows.Forms.NumericUpDown NUD_OtherCost;
    private System.Windows.Forms.NumericUpDown NUD_Stage;
    private System.Windows.Forms.NumericUpDown NUD_LevelUp;
    private System.Windows.Forms.ComboBox CB_Item;
    private System.Windows.Forms.NumericUpDown NUD_Duration;
    private System.Windows.Forms.NumericUpDown NUD_Efficacy;
    private System.Windows.Forms.Label L_PlayerCost;
    private System.Windows.Forms.Label L_OtherCost;
    private System.Windows.Forms.Label L_Stage;
    private System.Windows.Forms.Label L_LevelUp;
    private System.Windows.Forms.Label L_Duration;
    private System.Windows.Forms.Label L_Efficacy;
    private System.Windows.Forms.TextBox TB_Mini;
    private System.Windows.Forms.TextBox TB_Quality;
    private System.Windows.Forms.NumericUpDown NUD_2;
    private System.Windows.Forms.NumericUpDown NUD_Usability;
    private System.Windows.Forms.Label L_2;
    private System.Windows.Forms.ComboBox CB_SortOrder;
    private System.Windows.Forms.Label L_UsabilityText;
    private System.Windows.Forms.Label L_Usability;
}
