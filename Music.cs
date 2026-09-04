using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using VGAudio.Containers.NintendoWare; // BcstmReader
using VGAudio.Containers.NintendoWare.Structures;
using VGAudio.Containers.Wave;         // WaveWriter
using VGAudio.Formats;
using VGAudio.Containers.Adx;
using VGAudio.Containers;

namespace pk3DS.WinForms
{

    public partial class Music : Form
    {
        private string currentFolderPath = string.Empty;
        private string tempWavPath = string.Empty;

        // Extensões de áudio suportadas
        private readonly string[] supportedExtensions = { ".bcstm", ".bfstm", ".bcwav", ".mp3", ".wav" };

        public Music()
        {
            InitializeComponent();
        }

        private void LoadAudioFilesFromDirectory(string folderPath)
        {
            listBox1.Items.Clear();

            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show($"Directory not found:\n{folderPath}", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            currentFolderPath = folderPath;

            // Busca todos os arquivos do diretório antes do filtro
            var audioFiles = Directory.GetFiles(folderPath, ".", SearchOption.TopDirectoryOnly)
                .Where(file => supportedExtensions.Contains(Path.GetExtension(file).ToLower()))
                .Select(Path.GetFileName)
                .ToArray();

            if (audioFiles.Length > 0)
            {
                foreach (string file in audioFiles)
                {
                    listBox1.Items.Add(file);
                }
            }
            else
            {
                MessageBox.Show($"No supported audio files (.bcstm, .bfstm, .mp3, .wav) found in:\n{folderPath}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SelectUserFolder()
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Select the folder containing game audio files (.bcstm / .mp3)";
                fbd.UseDescriptionForTitle = true;

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    LoadAudioFilesFromDirectory(fbd.SelectedPath);
                }
            }
        }

        private string Convert3DSAudioToWav(string inputFilePath)
        {
            try
            {
                byte[] inputData = File.ReadAllBytes(inputFilePath);

                // 1. Usa a classe correta da DLL: BCfstmReader
                BCFstmReader reader = new BCFstmReader();
                AudioData audioData = reader.Read(inputData);

                // 2. Converte para o formato WAV
                WaveWriter writer = new WaveWriter();
                byte[] wavBytes = writer.GetFile(audioData);

                // 3. Salva no diretório temporário
                string tempPath = Path.Combine(Path.GetTempPath(), $"pk3DS_{Guid.NewGuid().ToString().Substring(0, 8)}.wav");
                File.WriteAllBytes(tempPath, wavBytes);

                return tempPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to convert 3DS audio file:\n{ex.Message}", "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void button1_Click(object sender, EventArgs e) => SelectUserFolder();

        private void button2_Click(object sender, EventArgs e)
        {
            string defaultPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "assets", "XY");
            if (Directory.Exists(defaultPath))
                LoadAudioFilesFromDirectory(defaultPath);
            else
                SelectUserFolder();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string defaultPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "assets", "AO");
            if (Directory.Exists(defaultPath))
                LoadAudioFilesFromDirectory(defaultPath);
            else
                SelectUserFolder();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string defaultPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "assets", "SM");
            if (Directory.Exists(defaultPath))
                LoadAudioFilesFromDirectory(defaultPath);
            else
                SelectUserFolder();
        }

        private void button4_Click(object sender, EventArgs e) => button3_Click(sender, e);
        private void button6_Click(object sender, EventArgs e) => button5_Click(sender, e);
        private void button7_Click(object sender, EventArgs e) => button5_Click(sender, e);
        private void button8_Click(object sender, EventArgs e) => button5_Click(sender, e);

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null || string.IsNullOrEmpty(currentFolderPath))
                return;

            string selectedFile = listBox1.SelectedItem.ToString();
            string fullPath = Path.Combine(currentFolderPath, selectedFile);

            if (!File.Exists(fullPath))
            {
                MessageBox.Show("The selected file does not exist on disk.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string extension = Path.GetExtension(fullPath).ToLower();
            string playbackPath = fullPath;

            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer1.URL = string.Empty;

            if (!string.IsNullOrEmpty(tempWavPath) && File.Exists(tempWavPath))
            {
                try { File.Delete(tempWavPath); } catch { }
            }

            if (extension == ".bcstm" || extension == ".bfstm" || extension == ".bcwav")
            {
                playbackPath = Convert3DSAudioToWav(fullPath);
                tempWavPath = playbackPath;
            }

            if (!string.IsNullOrEmpty(playbackPath) && File.Exists(playbackPath))
            {
                axWindowsMediaPlayer1.URL = playbackPath;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            try
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                axWindowsMediaPlayer1.URL = string.Empty;

                if (!string.IsNullOrEmpty(tempWavPath) && File.Exists(tempWavPath))
                {
                    File.Delete(tempWavPath);
                }
            }
            catch
            {
                // Ignora erros ao fechar
            }
        }
    }
}
