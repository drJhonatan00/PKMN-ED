using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pk3DS.WinForms
{
    public partial class Master : Form
    {
        public Master()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();    
            Main form = new Main();
            form.ShowDialog();
            this.Close();
        }
    }
}
