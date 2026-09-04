using pk3DS.Core;
using pk3DS.Core.CTR;
using System;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;

namespace pk3DS.WinForms
{
    public partial class _3DModelExtractor : Form
    {
        int ark = 0;
        int x = 0;
        int y = 0;
        public _3DModelExtractor()
        {
            InitializeComponent();
        }
        public void Number()
        {

        }
        private void _3DModelExtractor_Load(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = 1;
            numericUpDown1.Value = 1;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pokemonIndex = (int)numericUpDown1.Value;

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Model 3DS (.bch;.bin)|.bch;.bin|All Files (.)|.";
                sfd.FileName = $"Pokemon_{pokemonIndex:D3}.bch";
                sfd.Title = "Select where save the model";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    bool sucesso = ExtrairModeloPokemon(pokemonIndex, sfd.FileName);

                    if (sucesso)
                    {
                        MessageBox.Show($"Model #{pokemonIndex} successfully extracted!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private bool ExtrairModeloPokemon(int index, string outputPath)
        {
            try
            {
                string romfsPath = Main.RomFSPath;
                string garcRelativePath = Directory.Exists(Path.Combine(romfsPath, "a", "0", "9"))
                    ? Path.Combine("a", "0", "9", "4")
                    : Path.Combine("a", "0", "0", "8");

                string garcFullPath = Path.Combine(romfsPath, garcRelativePath);
                byte[] rawContainerData = null;


                if (Directory.Exists(garcFullPath))
                {
                    string[] arquivos = Directory.GetFiles(garcFullPath, ".", SearchOption.TopDirectoryOnly);
                    if (index >= arquivos.Length) return false;
                    rawContainerData = File.ReadAllBytes(arquivos[index]);
                }
                else if (File.Exists(garcFullPath))
                {
                    byte[] garcBytes = File.ReadAllBytes(garcFullPath);
                    var garc = new pk3DS.Core.CTR.GARC.MemGARC(garcBytes);
                    if (index >= garc.FileCount) return false;
                    rawContainerData = garc.GetFile(index);
                }

                if (rawContainerData == null || rawContainerData.Length == 0)
                {
                    MessageBox.Show("Model data empty or not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }


                byte[] unpackedData;
                try
                {
                    using (MemoryStream inStream = new MemoryStream(rawContainerData))
                    using (MemoryStream outStream = new MemoryStream())
                    {

                        pk3DS.Core.CTR.LZSS.Decompress(inStream, rawContainerData.Length, outStream);
                        unpackedData = outStream.ToArray();
                    }
                }
                catch
                {
                    unpackedData = rawContainerData;
                }

                byte[] bchFinal = ObterSubArquivoBCH(unpackedData);

                if (bchFinal != null)
                {
                    File.WriteAllBytes(outputPath, bchFinal);
                    return true;
                }
                File.WriteAllBytes(outputPath, unpackedData);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to extract the model:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Procura a assinatura do cabeçalho BCH (BCH\0 ou 'B''C''H') nos dados descompactados
        /// </summary>
        private byte[] ObterSubArquivoBCH(byte[] data)
        {
            if (data.Length < 4) return null;

            if (data[0] == 'B' && data[1] == 'C' && data[2] == 'H')
            {
                return data;
            }

            for (int i = 0; i < data.Length - 4; i += 4)
            {
                if (data[i] == 'B' && data[i + 1] == 'C' && data[i + 2] == 'H' && data[i + 3] == 0x00)
                {
                    byte[] bchBuffer = new byte[data.Length - i];
                    Buffer.BlockCopy(data, i, bchBuffer, 0, bchBuffer.Length);
                    return bchBuffer;
                }
            }

            return null;
        }
        private int ObterIndiceGarcPorPokedex(int pokedexNum)
        {
            int tamanhoBloco = 9;
            int offsetInicial = 1; 

            return ((pokedexNum - 1) * tamanhoBloco) + offsetInicial;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            label6.Text = ((((int)numericUpDown2.Value * 9) + 1) -9).ToString();
        }
    }
}
