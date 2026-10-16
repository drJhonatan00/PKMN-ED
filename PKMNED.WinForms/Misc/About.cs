using System;
using System.Windows.Forms;

namespace PKMNED.WinForms;

public partial class About : Form
{
    public About()
    {
        InitializeComponent();
        RTB.Text = "Based on SPICA and PKMNED projects.\n\nRedeveloped by drJhonatan00\n\n2026 - Nihon\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\nGozonjideshou ka sekai wa ima masani kawaritsutsu arimasu.\nSore ga masshirona sekai ni naru no ka soretomo makkurona sekai ni naru no ka\nanatagata ni wa tōtei shiruyoshi mo arimasen......\nsonotoki ga kimashita......";
    }

    private void B_Close_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void RTB_TextChanged(object sender, EventArgs e)
    {

    }
}
