using System.Windows.Forms;

namespace PKMNED.WinForms;

partial class MaisonEditor6
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaisonEditor7));
        CB_Trainer = new ComboBox();
        CB_Pokemon = new ComboBox();
        L_Trainer = new Label();
        L_Pokemon = new Label();
        GB_Trainer = new GroupBox();
        L_Class = new Label();
        B_Remove = new Button();
        B_Set = new Button();
        LB_Choices = new ListBox();
        CB_Class = new ComboBox();
        GB_Pokemon = new GroupBox();
        PB_PKM = new PictureBox();
        CHK_Spe = new CheckBox();
        CHK_SpD = new CheckBox();
        CHK_SpA = new CheckBox();
        CHK_DEF = new CheckBox();
        CHK_ATK = new CheckBox();
        CHK_HP = new CheckBox();
        L_Species = new Label();
        L_Item = new Label();
        L_Nature = new Label();
        L_Moves = new Label();
        CB_Item = new ComboBox();
        CB_Nature = new ComboBox();
        CB_Move4 = new ComboBox();
        CB_Move2 = new ComboBox();
        CB_Move3 = new ComboBox();
        CB_Move1 = new ComboBox();
        CB_Species = new ComboBox();
        B_DumpPKs = new Button();
        DumpTRs = new Button();
        GB_Trainer.SuspendLayout();
        GB_Pokemon.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)PB_PKM).BeginInit();
        SuspendLayout();
        // 
        // CB_Trainer
        // 
        CB_Trainer.AutoCompleteMode = AutoCompleteMode.Suggest;
        CB_Trainer.AutoCompleteSource = AutoCompleteSource.ListItems;
        CB_Trainer.FormattingEnabled = true;
        CB_Trainer.Location = new System.Drawing.Point(77, 12);
        CB_Trainer.Margin = new Padding(4, 3, 4, 3);
        CB_Trainer.Name = "CB_Trainer";
        CB_Trainer.Size = new System.Drawing.Size(140, 25);
        CB_Trainer.TabIndex = 0;
        CB_Trainer.SelectedIndexChanged += ChangeTrainer;
        // 
        // CB_Pokemon
        // 
        CB_Pokemon.AutoCompleteMode = AutoCompleteMode.Suggest;
        CB_Pokemon.AutoCompleteSource = AutoCompleteSource.ListItems;
        CB_Pokemon.FormattingEnabled = true;
        CB_Pokemon.Location = new System.Drawing.Point(421, 12);
        CB_Pokemon.Margin = new Padding(4, 3, 4, 3);
        CB_Pokemon.Name = "CB_Pokemon";
        CB_Pokemon.Size = new System.Drawing.Size(123, 25);
        CB_Pokemon.TabIndex = 1;
        CB_Pokemon.SelectedIndexChanged += ChangePokemon;
        // 
        // L_Trainer
        // 
        L_Trainer.AutoSize = true;
        L_Trainer.Location = new System.Drawing.Point(21, 16);
        L_Trainer.Margin = new Padding(4, 0, 4, 0);
        L_Trainer.Name = "L_Trainer";
        L_Trainer.Size = new System.Drawing.Size(53, 19);
        L_Trainer.TabIndex = 2;
        L_Trainer.Text = "Trainer:";
        // 
        // L_Pokemon
        // 
        L_Pokemon.AutoSize = true;
        L_Pokemon.Location = new System.Drawing.Point(350, 15);
        L_Pokemon.Margin = new Padding(4, 0, 4, 0);
        L_Pokemon.Name = "L_Pokemon";
        L_Pokemon.Size = new System.Drawing.Size(69, 19);
        L_Pokemon.TabIndex = 3;
        L_Pokemon.Text = "Pokémon:";
        // 
        // GB_Trainer
        // 
        GB_Trainer.Controls.Add(L_Class);
        GB_Trainer.Controls.Add(B_Remove);
        GB_Trainer.Controls.Add(B_Set);
        GB_Trainer.Controls.Add(LB_Choices);
        GB_Trainer.Controls.Add(CB_Class);
        GB_Trainer.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        GB_Trainer.Location = new System.Drawing.Point(14, 43);
        GB_Trainer.Margin = new Padding(4, 3, 4, 3);
        GB_Trainer.Name = "GB_Trainer";
        GB_Trainer.Padding = new Padding(4, 3, 4, 3);
        GB_Trainer.Size = new System.Drawing.Size(322, 245);
        GB_Trainer.TabIndex = 4;
        GB_Trainer.TabStop = false;
        GB_Trainer.Text = "Trainer Summary";
        // 
        // L_Class
        // 
        L_Class.AutoSize = true;
        L_Class.Location = new System.Drawing.Point(16, 31);
        L_Class.Margin = new Padding(4, 0, 4, 0);
        L_Class.Name = "L_Class";
        L_Class.Size = new System.Drawing.Size(43, 19);
        L_Class.TabIndex = 5;
        L_Class.Text = "Class:";
        // 
        // B_Remove
        // 
        B_Remove.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_Remove.FlatAppearance.BorderColor = System.Drawing.Color.Red;
        B_Remove.FlatStyle = FlatStyle.Flat;
        B_Remove.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Remove.ForeColor = System.Drawing.Color.Red;
        B_Remove.Location = new System.Drawing.Point(212, 206);
        B_Remove.Margin = new Padding(4, 3, 4, 3);
        B_Remove.Name = "B_Remove";
        B_Remove.Size = new System.Drawing.Size(80, 31);
        B_Remove.TabIndex = 4;
        B_Remove.Text = "[X] Delete";
        B_Remove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        B_Remove.UseVisualStyleBackColor = false;
        B_Remove.Click += B_Remove_Click;
        // 
        // B_Set
        // 
        B_Set.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_Set.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(154, 205, 50);
        B_Set.FlatStyle = FlatStyle.Flat;
        B_Set.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_Set.ForeColor = System.Drawing.Color.FromArgb(154, 205, 50);
        B_Set.Location = new System.Drawing.Point(212, 61);
        B_Set.Margin = new Padding(4, 3, 4, 3);
        B_Set.Name = "B_Set";
        B_Set.Size = new System.Drawing.Size(80, 31);
        B_Set.TabIndex = 2;
        B_Set.Text = "[<] Set";
        B_Set.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        B_Set.UseVisualStyleBackColor = false;
        B_Set.Click += B_Set_Click;
        // 
        // LB_Choices
        // 
        LB_Choices.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        LB_Choices.Font = new System.Drawing.Font("Segoe UI", 10F);
        LB_Choices.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        LB_Choices.FormattingEnabled = true;
        LB_Choices.Location = new System.Drawing.Point(10, 61);
        LB_Choices.Margin = new Padding(4, 3, 4, 3);
        LB_Choices.Name = "LB_Choices";
        LB_Choices.Size = new System.Drawing.Size(194, 174);
        LB_Choices.TabIndex = 1;
        LB_Choices.SelectedIndexChanged += B_View_Click;
        // 
        // CB_Class
        // 
        CB_Class.AutoCompleteMode = AutoCompleteMode.Suggest;
        CB_Class.AutoCompleteSource = AutoCompleteSource.ListItems;
        CB_Class.FormattingEnabled = true;
        CB_Class.Location = new System.Drawing.Point(64, 26);
        CB_Class.Margin = new Padding(4, 3, 4, 3);
        CB_Class.Name = "CB_Class";
        CB_Class.Size = new System.Drawing.Size(140, 25);
        CB_Class.TabIndex = 0;
        // 
        // GB_Pokemon
        // 
        GB_Pokemon.Controls.Add(PB_PKM);
        GB_Pokemon.Controls.Add(CHK_Spe);
        GB_Pokemon.Controls.Add(CHK_SpD);
        GB_Pokemon.Controls.Add(CHK_SpA);
        GB_Pokemon.Controls.Add(CHK_DEF);
        GB_Pokemon.Controls.Add(CHK_ATK);
        GB_Pokemon.Controls.Add(CHK_HP);
        GB_Pokemon.Controls.Add(L_Species);
        GB_Pokemon.Controls.Add(L_Item);
        GB_Pokemon.Controls.Add(L_Nature);
        GB_Pokemon.Controls.Add(L_Moves);
        GB_Pokemon.Controls.Add(CB_Item);
        GB_Pokemon.Controls.Add(CB_Nature);
        GB_Pokemon.Controls.Add(CB_Move4);
        GB_Pokemon.Controls.Add(CB_Move2);
        GB_Pokemon.Controls.Add(CB_Move3);
        GB_Pokemon.Controls.Add(CB_Move1);
        GB_Pokemon.Controls.Add(CB_Species);
        GB_Pokemon.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        GB_Pokemon.Location = new System.Drawing.Point(343, 43);
        GB_Pokemon.Margin = new Padding(4, 3, 4, 3);
        GB_Pokemon.Name = "GB_Pokemon";
        GB_Pokemon.Padding = new Padding(4, 3, 4, 3);
        GB_Pokemon.Size = new System.Drawing.Size(321, 245);
        GB_Pokemon.TabIndex = 5;
        GB_Pokemon.TabStop = false;
        GB_Pokemon.Text = "Pokémon Summary";
        // 
        // PB_PKM
        // 
        PB_PKM.Location = new System.Drawing.Point(209, 19);
        PB_PKM.Margin = new Padding(4, 3, 4, 3);
        PB_PKM.Name = "PB_PKM";
        PB_PKM.Size = new System.Drawing.Size(47, 40);
        PB_PKM.TabIndex = 25;
        PB_PKM.TabStop = false;
        // 
        // CHK_Spe
        // 
        CHK_Spe.AutoSize = true;
        CHK_Spe.Location = new System.Drawing.Point(255, 205);
        CHK_Spe.Margin = new Padding(4, 3, 4, 3);
        CHK_Spe.Name = "CHK_Spe";
        CHK_Spe.Size = new System.Drawing.Size(50, 23);
        CHK_Spe.TabIndex = 24;
        CHK_Spe.Text = "Spe";
        CHK_Spe.UseVisualStyleBackColor = true;
        // 
        // CHK_SpD
        // 
        CHK_SpD.AutoSize = true;
        CHK_SpD.Location = new System.Drawing.Point(255, 187);
        CHK_SpD.Margin = new Padding(4, 3, 4, 3);
        CHK_SpD.Name = "CHK_SpD";
        CHK_SpD.Size = new System.Drawing.Size(53, 23);
        CHK_SpD.TabIndex = 23;
        CHK_SpD.Text = "SpD";
        CHK_SpD.UseVisualStyleBackColor = true;
        // 
        // CHK_SpA
        // 
        CHK_SpA.AutoSize = true;
        CHK_SpA.Location = new System.Drawing.Point(255, 169);
        CHK_SpA.Margin = new Padding(4, 3, 4, 3);
        CHK_SpA.Name = "CHK_SpA";
        CHK_SpA.Size = new System.Drawing.Size(52, 23);
        CHK_SpA.TabIndex = 22;
        CHK_SpA.Text = "SpA";
        CHK_SpA.UseVisualStyleBackColor = true;
        // 
        // CHK_DEF
        // 
        CHK_DEF.AutoSize = true;
        CHK_DEF.Location = new System.Drawing.Point(201, 205);
        CHK_DEF.Margin = new Padding(4, 3, 4, 3);
        CHK_DEF.Name = "CHK_DEF";
        CHK_DEF.Size = new System.Drawing.Size(49, 23);
        CHK_DEF.TabIndex = 21;
        CHK_DEF.Text = "Def";
        CHK_DEF.UseVisualStyleBackColor = true;
        // 
        // CHK_ATK
        // 
        CHK_ATK.AutoSize = true;
        CHK_ATK.Location = new System.Drawing.Point(201, 187);
        CHK_ATK.Margin = new Padding(4, 3, 4, 3);
        CHK_ATK.Name = "CHK_ATK";
        CHK_ATK.Size = new System.Drawing.Size(49, 23);
        CHK_ATK.TabIndex = 20;
        CHK_ATK.Text = "Atk";
        CHK_ATK.UseVisualStyleBackColor = true;
        // 
        // CHK_HP
        // 
        CHK_HP.AutoSize = true;
        CHK_HP.Location = new System.Drawing.Point(201, 169);
        CHK_HP.Margin = new Padding(4, 3, 4, 3);
        CHK_HP.Name = "CHK_HP";
        CHK_HP.Size = new System.Drawing.Size(46, 23);
        CHK_HP.TabIndex = 19;
        CHK_HP.Text = "HP";
        CHK_HP.UseVisualStyleBackColor = true;
        // 
        // L_Species
        // 
        L_Species.AutoSize = true;
        L_Species.Location = new System.Drawing.Point(15, 31);
        L_Species.Margin = new Padding(4, 0, 4, 0);
        L_Species.Name = "L_Species";
        L_Species.Size = new System.Drawing.Size(56, 19);
        L_Species.TabIndex = 18;
        L_Species.Text = "Species:";
        // 
        // L_Item
        // 
        L_Item.AutoSize = true;
        L_Item.Location = new System.Drawing.Point(34, 185);
        L_Item.Margin = new Padding(4, 0, 4, 0);
        L_Item.Name = "L_Item";
        L_Item.Size = new System.Drawing.Size(40, 19);
        L_Item.TabIndex = 17;
        L_Item.Text = "Item:";
        // 
        // L_Nature
        // 
        L_Nature.AutoSize = true;
        L_Nature.Location = new System.Drawing.Point(20, 155);
        L_Nature.Margin = new Padding(4, 0, 4, 0);
        L_Nature.Name = "L_Nature";
        L_Nature.Size = new System.Drawing.Size(54, 19);
        L_Nature.TabIndex = 16;
        L_Nature.Text = "Nature:";
        // 
        // L_Moves
        // 
        L_Moves.AutoSize = true;
        L_Moves.Location = new System.Drawing.Point(15, 62);
        L_Moves.Margin = new Padding(4, 0, 4, 0);
        L_Moves.Name = "L_Moves";
        L_Moves.Size = new System.Drawing.Size(53, 19);
        L_Moves.TabIndex = 15;
        L_Moves.Text = "Moves:";
        // 
        // CB_Item
        // 
        CB_Item.AutoCompleteMode = AutoCompleteMode.Suggest;
        CB_Item.AutoCompleteSource = AutoCompleteSource.ListItems;
        CB_Item.FormattingEnabled = true;
        CB_Item.Location = new System.Drawing.Point(76, 180);
        CB_Item.Margin = new Padding(4, 3, 4, 3);
        CB_Item.Name = "CB_Item";
        CB_Item.Size = new System.Drawing.Size(117, 25);
        CB_Item.TabIndex = 14;
        // 
        // CB_Nature
        // 
        CB_Nature.AutoCompleteMode = AutoCompleteMode.Suggest;
        CB_Nature.AutoCompleteSource = AutoCompleteSource.ListItems;
        CB_Nature.FormattingEnabled = true;
        CB_Nature.Location = new System.Drawing.Point(76, 152);
        CB_Nature.Margin = new Padding(4, 3, 4, 3);
        CB_Nature.Name = "CB_Nature";
        CB_Nature.Size = new System.Drawing.Size(117, 25);
        CB_Nature.TabIndex = 13;
        // 
        // CB_Move4
        // 
        CB_Move4.AutoCompleteMode = AutoCompleteMode.Suggest;
        CB_Move4.AutoCompleteSource = AutoCompleteSource.ListItems;
        CB_Move4.FormattingEnabled = true;
        CB_Move4.Location = new System.Drawing.Point(163, 119);
        CB_Move4.Margin = new Padding(4, 3, 4, 3);
        CB_Move4.Name = "CB_Move4";
        CB_Move4.Size = new System.Drawing.Size(140, 25);
        CB_Move4.TabIndex = 12;
        // 
        // CB_Move2
        // 
        CB_Move2.AutoCompleteMode = AutoCompleteMode.Suggest;
        CB_Move2.AutoCompleteSource = AutoCompleteSource.ListItems;
        CB_Move2.FormattingEnabled = true;
        CB_Move2.Location = new System.Drawing.Point(163, 84);
        CB_Move2.Margin = new Padding(4, 3, 4, 3);
        CB_Move2.Name = "CB_Move2";
        CB_Move2.Size = new System.Drawing.Size(140, 25);
        CB_Move2.TabIndex = 11;
        // 
        // CB_Move3
        // 
        CB_Move3.AutoCompleteMode = AutoCompleteMode.Suggest;
        CB_Move3.AutoCompleteSource = AutoCompleteSource.ListItems;
        CB_Move3.FormattingEnabled = true;
        CB_Move3.Location = new System.Drawing.Point(15, 119);
        CB_Move3.Margin = new Padding(4, 3, 4, 3);
        CB_Move3.Name = "CB_Move3";
        CB_Move3.Size = new System.Drawing.Size(140, 25);
        CB_Move3.TabIndex = 10;
        // 
        // CB_Move1
        // 
        CB_Move1.AutoCompleteMode = AutoCompleteMode.Suggest;
        CB_Move1.AutoCompleteSource = AutoCompleteSource.ListItems;
        CB_Move1.FormattingEnabled = true;
        CB_Move1.Location = new System.Drawing.Point(15, 84);
        CB_Move1.Margin = new Padding(4, 3, 4, 3);
        CB_Move1.Name = "CB_Move1";
        CB_Move1.Size = new System.Drawing.Size(140, 25);
        CB_Move1.TabIndex = 9;
        // 
        // CB_Species
        // 
        CB_Species.AutoCompleteMode = AutoCompleteMode.Suggest;
        CB_Species.AutoCompleteSource = AutoCompleteSource.ListItems;
        CB_Species.FormattingEnabled = true;
        CB_Species.Location = new System.Drawing.Point(78, 26);
        CB_Species.Margin = new Padding(4, 3, 4, 3);
        CB_Species.Name = "CB_Species";
        CB_Species.Size = new System.Drawing.Size(123, 25);
        CB_Species.TabIndex = 8;
        CB_Species.SelectedIndexChanged += ChangeSpecies;
        // 
        // B_DumpPKs
        // 
        B_DumpPKs.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        B_DumpPKs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_DumpPKs.FlatStyle = FlatStyle.Flat;
        B_DumpPKs.Font = new System.Drawing.Font("Segoe UI", 10F);
        B_DumpPKs.ForeColor = System.Drawing.Color.FromArgb(56, 189, 248);
        B_DumpPKs.Location = new System.Drawing.Point(576, 9);
        B_DumpPKs.Margin = new Padding(4, 3, 4, 3);
        B_DumpPKs.Name = "B_DumpPKs";
        B_DumpPKs.Size = new System.Drawing.Size(88, 31);
        B_DumpPKs.TabIndex = 6;
        B_DumpPKs.Text = "Dump PKMs";
        B_DumpPKs.UseVisualStyleBackColor = false;
        B_DumpPKs.Click += B_DumpPKs_Click;
        // 
        // DumpTRs
        // 
        DumpTRs.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        DumpTRs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(56, 189, 248);
        DumpTRs.FlatStyle = FlatStyle.Flat;
        DumpTRs.Font = new System.Drawing.Font("Segoe UI", 10F);
        DumpTRs.ForeColor = System.Drawing.Color.FromArgb(56, 189, 248);
        DumpTRs.Location = new System.Drawing.Point(248, 8);
        DumpTRs.Margin = new Padding(4, 3, 4, 3);
        DumpTRs.Name = "DumpTRs";
        DumpTRs.Size = new System.Drawing.Size(88, 31);
        DumpTRs.TabIndex = 7;
        DumpTRs.Text = "Dump TRs";
        DumpTRs.UseVisualStyleBackColor = false;
        DumpTRs.Click += DumpTRs_Click;
        // 
        // MaisonEditor7
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
        ClientSize = new System.Drawing.Size(676, 296);
        Controls.Add(DumpTRs);
        Controls.Add(B_DumpPKs);
        Controls.Add(GB_Pokemon);
        Controls.Add(GB_Trainer);
        Controls.Add(L_Pokemon);
        Controls.Add(L_Trainer);
        Controls.Add(CB_Pokemon);
        Controls.Add(CB_Trainer);
        Font = new System.Drawing.Font("Segoe UI", 10F);
        ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MaximumSize = new System.Drawing.Size(692, 335);
        MinimumSize = new System.Drawing.Size(692, 335);
        Name = "MaisonEditor7";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Royal/Tree Editor";
        FormClosing += Form_Closing;
        GB_Trainer.ResumeLayout(false);
        GB_Trainer.PerformLayout();
        GB_Pokemon.ResumeLayout(false);
        GB_Pokemon.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)PB_PKM).EndInit();
        ResumeLayout(false);
        PerformLayout();


    }

    #endregion

    private System.Windows.Forms.ComboBox CB_Trainer;
    private System.Windows.Forms.ComboBox CB_Pokemon;
    private System.Windows.Forms.Label L_Trainer;
    private System.Windows.Forms.Label L_Pokemon;
    private System.Windows.Forms.GroupBox GB_Trainer;
    private System.Windows.Forms.GroupBox GB_Pokemon;
    private System.Windows.Forms.Button B_DumpPKs;
    private System.Windows.Forms.Button DumpTRs;
    private System.Windows.Forms.Label L_Item;
    private System.Windows.Forms.Label L_Nature;
    private System.Windows.Forms.Label L_Moves;
    private System.Windows.Forms.ComboBox CB_Item;
    private System.Windows.Forms.ComboBox CB_Nature;
    private System.Windows.Forms.ComboBox CB_Move4;
    private System.Windows.Forms.ComboBox CB_Move2;
    private System.Windows.Forms.ComboBox CB_Move3;
    private System.Windows.Forms.ComboBox CB_Move1;
    private System.Windows.Forms.ComboBox CB_Species;
    private System.Windows.Forms.Label L_Species;
    private System.Windows.Forms.CheckBox CHK_Spe;
    private System.Windows.Forms.CheckBox CHK_SpD;
    private System.Windows.Forms.CheckBox CHK_SpA;
    private System.Windows.Forms.CheckBox CHK_DEF;
    private System.Windows.Forms.CheckBox CHK_ATK;
    private System.Windows.Forms.CheckBox CHK_HP;
    private System.Windows.Forms.PictureBox PB_PKM;
    private System.Windows.Forms.Label L_Class;
    private System.Windows.Forms.Button B_Remove;
    private System.Windows.Forms.Button B_Set;
    private System.Windows.Forms.ListBox LB_Choices;
    private System.Windows.Forms.ComboBox CB_Class;
}
