namespace PKMNED.WinForms;

partial class ErrorWindow
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorWindow));
        B_Continue = new System.Windows.Forms.Button();
        B_Abort = new System.Windows.Forms.Button();
        B_CopyToClipboard = new System.Windows.Forms.Button();
        L_ProvideInfo = new System.Windows.Forms.Label();
        L_Message = new System.Windows.Forms.Label();
        T_ExceptionDetails = new System.Windows.Forms.TextBox();
        SuspendLayout();
        // 
        // B_Continue
        // 
        B_Continue.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        B_Continue.Location = new System.Drawing.Point(387, 234);
        B_Continue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Continue.Name = "B_Continue";
        B_Continue.Size = new System.Drawing.Size(88, 27);
        B_Continue.TabIndex = 11;
        B_Continue.Text = "Continue";
        B_Continue.UseVisualStyleBackColor = true;
        B_Continue.Click += B_Continue_Click;
        // 
        // B_Abort
        // 
        B_Abort.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        B_Abort.Location = new System.Drawing.Point(482, 234);
        B_Abort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_Abort.Name = "B_Abort";
        B_Abort.Size = new System.Drawing.Size(88, 27);
        B_Abort.TabIndex = 10;
        B_Abort.Text = "Abort";
        B_Abort.UseVisualStyleBackColor = true;
        B_Abort.Click += B_Abort_Click;
        // 
        // B_CopyToClipboard
        // 
        B_CopyToClipboard.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        B_CopyToClipboard.Location = new System.Drawing.Point(15, 234);
        B_CopyToClipboard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        B_CopyToClipboard.Name = "B_CopyToClipboard";
        B_CopyToClipboard.Size = new System.Drawing.Size(191, 27);
        B_CopyToClipboard.TabIndex = 9;
        B_CopyToClipboard.Text = "Copy to Clipboard";
        B_CopyToClipboard.UseVisualStyleBackColor = true;
        B_CopyToClipboard.Click += B_CopyToClipboard_Click;
        // 
        // L_ProvideInfo
        // 
        L_ProvideInfo.AutoSize = true;
        L_ProvideInfo.Location = new System.Drawing.Point(12, 44);
        L_ProvideInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_ProvideInfo.Name = "L_ProvideInfo";
        L_ProvideInfo.Size = new System.Drawing.Size(308, 15);
        L_ProvideInfo.TabIndex = 8;
        L_ProvideInfo.Text = "Please provide this information when reporting this error:";
        // 
        // L_Message
        // 
        L_Message.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        L_Message.Location = new System.Drawing.Point(12, 13);
        L_Message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        L_Message.Name = "L_Message";
        L_Message.Size = new System.Drawing.Size(558, 31);
        L_Message.TabIndex = 7;
        L_Message.Text = "An unknown error has occurred.";
        // 
        // T_ExceptionDetails
        // 
        T_ExceptionDetails.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        T_ExceptionDetails.Location = new System.Drawing.Point(15, 62);
        T_ExceptionDetails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        T_ExceptionDetails.Multiline = true;
        T_ExceptionDetails.Name = "T_ExceptionDetails";
        T_ExceptionDetails.ReadOnly = true;
        T_ExceptionDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        T_ExceptionDetails.Size = new System.Drawing.Size(554, 164);
        T_ExceptionDetails.TabIndex = 6;
        // 
        // ErrorWindow
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
        var kiiro = System.Drawing.Color.FromArgb(255, 216, 1);

        BackColor = bg;
        ForeColor = text;
        Font = font;

        B_Abort.ForeColor = aka;
        B_Abort.Font = font;
        B_Abort.BackColor = bg;
        B_Abort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        B_Abort.FlatAppearance.BorderColor = aka;

        B_Continue.ForeColor = midori;
        B_Continue.Font = font;
        B_Continue.BackColor = bg;
        B_Continue.FlatAppearance.BorderColor = midori;
        B_Continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

        B_CopyToClipboard.ForeColor = accent;
        B_CopyToClipboard.Font = font;
        B_CopyToClipboard.BackColor = bg;
        B_CopyToClipboard.FlatAppearance.BorderColor = accent;
        B_CopyToClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(582, 272);
        Controls.Add(B_Continue);
        Controls.Add(B_Abort);
        Controls.Add(B_CopyToClipboard);
        Controls.Add(L_ProvideInfo);
        Controls.Add(L_Message);
        Controls.Add(T_ExceptionDetails);
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        MinimumSize = new System.Drawing.Size(598, 311);
        Name = "ErrorWindow";
        Text = "Error";
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button B_Continue;
    private System.Windows.Forms.Button B_Abort;
    private System.Windows.Forms.Button B_CopyToClipboard;
    private System.Windows.Forms.Label L_ProvideInfo;
    private System.Windows.Forms.Label L_Message;
    private System.Windows.Forms.TextBox T_ExceptionDetails;
}
