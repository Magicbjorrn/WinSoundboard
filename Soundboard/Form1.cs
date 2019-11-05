using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Soundboard
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer wplayer = new WindowsMediaPlayer();

        private string soundDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "soundfiles\\");

        private List<Button> soundButtons = new List<Button>();
        private Button[,] soundButtonsArray;

        public Form1()
        {
            InitializeComponent();

            if (!Directory.Exists(soundDirectory))
            {
                Directory.CreateDirectory(soundDirectory);
            }

            LoadSounds();
        }

        private void LoadSounds()
        {
            pnl_SoundPanel.Controls.Clear();
            soundButtons.Clear();

            string[] fileEntries = Directory.GetFiles(soundDirectory);

            foreach (string fileDirectory in fileEntries) {
                Button newButton = new Button();

                pnl_SoundPanel.Controls.Add(newButton);

                soundButtons.Add(newButton);

                newButton.Text = Path.GetFileName(fileDirectory);
                newButton.Size = new Size(100, 100);
                newButton.Click += new EventHandler(btn_PlaySound_Click);
            }

            ConvertListToTwoDArray();
            SetButtonPosition();
        }

        private void ConvertListToTwoDArray()
        {
            int nButtons = soundButtons.Count;
            int nRows = nButtons / 4 + 1;

            soundButtonsArray = new Button[nRows, 4];

            for (int i = 0; i < soundButtonsArray.GetLength(0); i++)
            {
                for (int j = 0; j < soundButtonsArray.GetLength(1); j++)
                {
                    int index = i * 4 + j;

                    if (soundButtons.Count > index && soundButtons[index] != null)
                    {
                        soundButtonsArray[i, j] = soundButtons[index];
                    }
                }
            }
        }

        private void SetButtonPosition()
        {
            for (int i = 0; i < soundButtonsArray.GetLength(0); i++)
            {
                for (int j = 0; j < soundButtonsArray.GetLength(1); j++)
                {
                    if (soundButtonsArray[i, j] != null)
                    {
                        soundButtonsArray[i, j].Location = new Point(j * 100 + j * 10, i * 100 + i * 10);
                    }
                }
            }
        }
        
        private void btn_AddSound_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                string sourceFileName = dialog.FileName;
                string destinationFileName = Path.Combine(soundDirectory, Path.GetFileName(sourceFileName));

                if (!File.Exists(destinationFileName))
                {
                    File.Copy(sourceFileName, destinationFileName);

                    LoadSounds();
                }
            }
        }

        private void btn_PlaySound_Click(object sender, EventArgs e)
        {
            string fileName = Path.Combine(soundDirectory, (sender as Button).Text);

            wplayer.controls.stop();
            wplayer.URL = fileName;
            wplayer.controls.play();
        }
    }
}
