using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rakib_Media_Player
{
    public partial class FormRakibMediaPlayer : Form
    {
        string[] paths, files;

        public FormRakibMediaPlayer()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void pictureBoxMaximize_Click(object sender, EventArgs e)
        {
            pictureBoxMaximize.Hide();
            pictureBoxRestoreDown.Show();
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBoxRestoreDown_Click(object sender, EventArgs e)
        {
            pictureBoxRestoreDown.Hide();
            pictureBoxMaximize.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void guna2ToggleSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if(guna2ToggleSwitch.Checked)
            {
                guna2GroupBox.Show();
            }
            else
            {
                guna2GroupBox.Hide();
            }
        }

        private void FormRakibMediaPlayer_Load(object sender, EventArgs e)
        {
            guna2GroupBox.Hide();
        }

        private void pictureBoxPlay_Click(object sender, EventArgs e)
        {
            pictureBoxPlay.Hide();
            pictureBoxPause.Show();
            WindowsMediaPlayer.Ctlcontrols.play();
        }

        private void pictureBoxOpenMedium_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                files = openFileDialog1.SafeFileNames;
                paths = openFileDialog1.FileNames;
                listBoxMedia.Items.Clear();
                for (int i = 0; i < files.Length; i++)
                {
                    listBoxMedia.Items.Add(files[i]);
                }
                pictureBox.Hide();
                listBoxMedia.SelectedIndex = 0;
                WindowsMediaPlayer.URL = paths[listBoxMedia.SelectedIndex];
                WindowsMediaPlayer.Ctlcontrols.play();
                label.Text = listBoxMedia.GetItemText(listBoxMedia.SelectedItem);
                pictureBoxPlay.Hide();
                timer1.Start();
                pictureBoxPause.Show();


            }
        }

        private void guna2TrackBarVolume_Scroll(object sender, ScrollEventArgs e)
        {
            WindowsMediaPlayer.settings.volume = guna2TrackBarVolume.Value;
            labelVolume.Text = guna2TrackBarVolume.Value.ToString() + "%";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(WindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                guna2TrackBarVideo.Maximum = (int)WindowsMediaPlayer.Ctlcontrols.currentItem.duration;
                guna2TrackBarVideo.Value = (int)WindowsMediaPlayer.Ctlcontrols.currentPosition;
            }
            labelStart.Text = WindowsMediaPlayer.Ctlcontrols.currentPositionString;
            labelEnd.Text = WindowsMediaPlayer.Ctlcontrols.currentItem.durationString.ToString();
            if(guna2TrackBarVideo.Maximum == guna2TrackBarVideo.Value)
            {
                timer1.Stop();
                pictureBox.Show();
                pictureBoxPause.Hide();
                pictureBoxPlay.Show();
                guna2TrackBarVideo.Value = 0;
                labelStart.Text = "00:00";
                labelEnd.Text = "00:00";

            }
        }

        private void pictureBoxPrevious_Click(object sender, EventArgs e)
        {
            if(listBoxMedia.SelectedIndex > 0)
            {
                listBoxMedia.SelectedIndex = listBoxMedia.SelectedIndex - 1;
            }
        }

        private void listBoxMedia_SelectedIndexChanged(object sender, EventArgs e)
        {
            WindowsMediaPlayer.URL = paths[listBoxMedia.SelectedIndex];
            WindowsMediaPlayer.Ctlcontrols.play();
            label.Text = listBoxMedia.GetItemText(listBoxMedia.SelectedItem);
            pictureBox.Hide();

        }

        private void pictureBoxNext_Click(object sender, EventArgs e)
        {
            if(listBoxMedia.SelectedIndex < listBoxMedia.Items.Count - 1)
            {
                listBoxMedia.SelectedIndex = listBoxMedia.SelectedIndex + 1;
            }
        }

        private void pictureBoxStop_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer.Ctlcontrols.stop();
            pictureBox.Show();
            label.Text = "Md. Rakibul Islam. All Right reserved 2023";
            listBoxMedia.Items.Clear();
            timer1.Stop();
            guna2TrackBarVideo.Value = 0;
            labelStart.Text = "00:00";
            labelEnd.Text = "00:00";
        }

        private void WindowsMediaPlayer_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBoxPause_Click(object sender, EventArgs e)
        {
            pictureBoxPause.Hide();
            pictureBoxPlay.Show();
            WindowsMediaPlayer.Ctlcontrols.pause();
        }
    }
}
