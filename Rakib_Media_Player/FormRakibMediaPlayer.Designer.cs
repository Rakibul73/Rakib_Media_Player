namespace Rakib_Media_Player
{
    partial class FormRakibMediaPlayer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRakibMediaPlayer));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.guna2ToggleSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.pictureBoxOpenMedium = new System.Windows.Forms.PictureBox();
            this.pictureBoxNext = new System.Windows.Forms.PictureBox();
            this.pictureBoxStop = new System.Windows.Forms.PictureBox();
            this.pictureBoxPrevious = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlay = new System.Windows.Forms.PictureBox();
            this.pictureBoxPause = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBoxMaximize = new System.Windows.Forms.PictureBox();
            this.pictureBoxRestoreDown = new System.Windows.Forms.PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.guna2TrackBarVolume = new Guna.UI2.WinForms.Guna2TrackBar();
            this.labelEnd = new System.Windows.Forms.Label();
            this.guna2TrackBarVideo = new Guna.UI2.WinForms.Guna2TrackBar();
            this.labelStart = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2GroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.listBoxMedia = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.WindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenMedium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestoreDown)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 31);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rakib Media Player";
            // 
            // guna2HtmlToolTip1
            // 
            this.guna2HtmlToolTip1.AllowLinksHandling = true;
            this.guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // guna2ToggleSwitch
            // 
            this.guna2ToggleSwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ToggleSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ToggleSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch.Location = new System.Drawing.Point(242, 44);
            this.guna2ToggleSwitch.Name = "guna2ToggleSwitch";
            this.guna2ToggleSwitch.Size = new System.Drawing.Size(35, 20);
            this.guna2ToggleSwitch.TabIndex = 16;
            this.guna2HtmlToolTip1.SetToolTip(this.guna2ToggleSwitch, "Toggle Playlist");
            this.guna2ToggleSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch_CheckedChanged);
            // 
            // pictureBoxOpenMedium
            // 
            this.pictureBoxOpenMedium.Image = global::Rakib_Media_Player.Properties.Resources.folder;
            this.pictureBoxOpenMedium.Location = new System.Drawing.Point(206, 38);
            this.pictureBoxOpenMedium.Name = "pictureBoxOpenMedium";
            this.pictureBoxOpenMedium.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxOpenMedium.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOpenMedium.TabIndex = 15;
            this.pictureBoxOpenMedium.TabStop = false;
            this.guna2HtmlToolTip1.SetToolTip(this.pictureBoxOpenMedium, "Open Medium");
            this.pictureBoxOpenMedium.Click += new System.EventHandler(this.pictureBoxOpenMedium_Click);
            // 
            // pictureBoxNext
            // 
            this.pictureBoxNext.Image = global::Rakib_Media_Player.Properties.Resources.icons8_next_64;
            this.pictureBoxNext.Location = new System.Drawing.Point(148, 38);
            this.pictureBoxNext.Name = "pictureBoxNext";
            this.pictureBoxNext.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNext.TabIndex = 14;
            this.pictureBoxNext.TabStop = false;
            this.guna2HtmlToolTip1.SetToolTip(this.pictureBoxNext, "Next");
            this.pictureBoxNext.Click += new System.EventHandler(this.pictureBoxNext_Click);
            // 
            // pictureBoxStop
            // 
            this.pictureBoxStop.Image = global::Rakib_Media_Player.Properties.Resources.stop;
            this.pictureBoxStop.Location = new System.Drawing.Point(115, 38);
            this.pictureBoxStop.Name = "pictureBoxStop";
            this.pictureBoxStop.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStop.TabIndex = 13;
            this.pictureBoxStop.TabStop = false;
            this.guna2HtmlToolTip1.SetToolTip(this.pictureBoxStop, "Stop");
            this.pictureBoxStop.Click += new System.EventHandler(this.pictureBoxStop_Click);
            // 
            // pictureBoxPrevious
            // 
            this.pictureBoxPrevious.Image = global::Rakib_Media_Player.Properties.Resources.icons8_previous_48;
            this.pictureBoxPrevious.Location = new System.Drawing.Point(82, 38);
            this.pictureBoxPrevious.Name = "pictureBoxPrevious";
            this.pictureBoxPrevious.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPrevious.TabIndex = 12;
            this.pictureBoxPrevious.TabStop = false;
            this.guna2HtmlToolTip1.SetToolTip(this.pictureBoxPrevious, "Previous");
            this.pictureBoxPrevious.Click += new System.EventHandler(this.pictureBoxPrevious_Click);
            // 
            // pictureBoxPlay
            // 
            this.pictureBoxPlay.Image = global::Rakib_Media_Player.Properties.Resources.play;
            this.pictureBoxPlay.Location = new System.Drawing.Point(14, 32);
            this.pictureBoxPlay.Name = "pictureBoxPlay";
            this.pictureBoxPlay.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPlay.TabIndex = 11;
            this.pictureBoxPlay.TabStop = false;
            this.guna2HtmlToolTip1.SetToolTip(this.pictureBoxPlay, "Play");
            this.pictureBoxPlay.Click += new System.EventHandler(this.pictureBoxPlay_Click);
            // 
            // pictureBoxPause
            // 
            this.pictureBoxPause.Image = global::Rakib_Media_Player.Properties.Resources.pause;
            this.pictureBoxPause.Location = new System.Drawing.Point(14, 32);
            this.pictureBoxPause.Name = "pictureBoxPause";
            this.pictureBoxPause.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPause.TabIndex = 10;
            this.pictureBoxPause.TabStop = false;
            this.guna2HtmlToolTip1.SetToolTip(this.pictureBoxPause, "Pause");
            this.pictureBoxPause.Click += new System.EventHandler(this.pictureBoxPause_Click);
            // 
            // pictureBoxMinimize
            // 
            this.pictureBoxMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMinimize.Image = global::Rakib_Media_Player.Properties.Resources.minimize__1_;
            this.pictureBoxMinimize.Location = new System.Drawing.Point(638, 0);
            this.pictureBoxMinimize.Name = "pictureBoxMinimize";
            this.pictureBoxMinimize.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimize.TabIndex = 6;
            this.pictureBoxMinimize.TabStop = false;
            this.guna2HtmlToolTip1.SetToolTip(this.pictureBoxMinimize, "Minimize");
            this.pictureBoxMinimize.Click += new System.EventHandler(this.pictureBoxMinimize_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxClose.Image = global::Rakib_Media_Player.Properties.Resources.remove_button;
            this.pictureBoxClose.Location = new System.Drawing.Point(702, 0);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 3;
            this.pictureBoxClose.TabStop = false;
            this.guna2HtmlToolTip1.SetToolTip(this.pictureBoxClose, "Close");
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // pictureBoxMaximize
            // 
            this.pictureBoxMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMaximize.Image = global::Rakib_Media_Player.Properties.Resources.maximize__1_;
            this.pictureBoxMaximize.Location = new System.Drawing.Point(670, 0);
            this.pictureBoxMaximize.Name = "pictureBoxMaximize";
            this.pictureBoxMaximize.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMaximize.TabIndex = 4;
            this.pictureBoxMaximize.TabStop = false;
            this.guna2HtmlToolTip1.SetToolTip(this.pictureBoxMaximize, "Maximize");
            this.pictureBoxMaximize.Click += new System.EventHandler(this.pictureBoxMaximize_Click);
            // 
            // pictureBoxRestoreDown
            // 
            this.pictureBoxRestoreDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRestoreDown.Image = global::Rakib_Media_Player.Properties.Resources.minimize__1_;
            this.pictureBoxRestoreDown.Location = new System.Drawing.Point(670, 0);
            this.pictureBoxRestoreDown.Name = "pictureBoxRestoreDown";
            this.pictureBoxRestoreDown.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxRestoreDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRestoreDown.TabIndex = 5;
            this.pictureBoxRestoreDown.TabStop = false;
            this.guna2HtmlToolTip1.SetToolTip(this.pictureBoxRestoreDown, "Restore Down");
            this.pictureBoxRestoreDown.Click += new System.EventHandler(this.pictureBoxRestoreDown_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label);
            this.panel2.Controls.Add(this.labelVolume);
            this.panel2.Controls.Add(this.guna2TrackBarVolume);
            this.panel2.Controls.Add(this.guna2ToggleSwitch);
            this.panel2.Controls.Add(this.pictureBoxOpenMedium);
            this.panel2.Controls.Add(this.pictureBoxNext);
            this.panel2.Controls.Add(this.pictureBoxStop);
            this.panel2.Controls.Add(this.pictureBoxPrevious);
            this.panel2.Controls.Add(this.pictureBoxPlay);
            this.panel2.Controls.Add(this.pictureBoxPause);
            this.panel2.Controls.Add(this.labelEnd);
            this.panel2.Controls.Add(this.guna2TrackBarVideo);
            this.panel2.Controls.Add(this.labelStart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 471);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 105);
            this.panel2.TabIndex = 7;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 83);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(256, 16);
            this.label.TabIndex = 19;
            this.label.Text = "Md. Rakibul Islam. All Right reserved 2023";
            // 
            // labelVolume
            // 
            this.labelVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(683, 45);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(33, 16);
            this.labelVolume.TabIndex = 18;
            this.labelVolume.Text = "50%";
            // 
            // guna2TrackBarVolume
            // 
            this.guna2TrackBarVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TrackBarVolume.Location = new System.Drawing.Point(549, 41);
            this.guna2TrackBarVolume.Name = "guna2TrackBarVolume";
            this.guna2TrackBarVolume.Size = new System.Drawing.Size(127, 23);
            this.guna2TrackBarVolume.TabIndex = 17;
            this.guna2TrackBarVolume.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.guna2TrackBarVolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.guna2TrackBarVolume_Scroll);
            // 
            // labelEnd
            // 
            this.labelEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(682, 8);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(38, 16);
            this.labelEnd.TabIndex = 9;
            this.labelEnd.Text = "00:00";
            // 
            // guna2TrackBarVideo
            // 
            this.guna2TrackBarVideo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TrackBarVideo.Location = new System.Drawing.Point(57, 3);
            this.guna2TrackBarVideo.Name = "guna2TrackBarVideo";
            this.guna2TrackBarVideo.Size = new System.Drawing.Size(619, 23);
            this.guna2TrackBarVideo.TabIndex = 8;
            this.guna2TrackBarVideo.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.guna2TrackBarVideo.Value = 0;
            // 
            // labelStart
            // 
            this.labelStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(17, 8);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(38, 16);
            this.labelStart.TabIndex = 8;
            this.labelStart.Text = "00:00";
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox.BackColor = System.Drawing.Color.Black;
            this.pictureBox.Image = global::Rakib_Media_Player.Properties.Resources.media_player1;
            this.pictureBox.Location = new System.Drawing.Point(304, 186);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(127, 127);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 9;
            this.pictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rakib_Media_Player.Properties.Resources.media_player;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // guna2GroupBox
            // 
            this.guna2GroupBox.BorderRadius = 10;
            this.guna2GroupBox.Controls.Add(this.listBoxMedia);
            this.guna2GroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2GroupBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox.Location = new System.Drawing.Point(0, 277);
            this.guna2GroupBox.Name = "guna2GroupBox";
            this.guna2GroupBox.Size = new System.Drawing.Size(735, 194);
            this.guna2GroupBox.TabIndex = 10;
            this.guna2GroupBox.Text = "Playlist";
            // 
            // listBoxMedia
            // 
            this.listBoxMedia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxMedia.FormattingEnabled = true;
            this.listBoxMedia.ItemHeight = 23;
            this.listBoxMedia.Location = new System.Drawing.Point(0, 56);
            this.listBoxMedia.Name = "listBoxMedia";
            this.listBoxMedia.Size = new System.Drawing.Size(735, 138);
            this.listBoxMedia.TabIndex = 0;
            this.listBoxMedia.SelectedIndexChanged += new System.EventHandler(this.listBoxMedia_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // WindowsMediaPlayer
            // 
            this.WindowsMediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WindowsMediaPlayer.Enabled = true;
            this.WindowsMediaPlayer.Location = new System.Drawing.Point(0, 31);
            this.WindowsMediaPlayer.Name = "WindowsMediaPlayer";
            this.WindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayer.OcxState")));
            this.WindowsMediaPlayer.Size = new System.Drawing.Size(735, 440);
            this.WindowsMediaPlayer.TabIndex = 11;
            // 
            // FormRakibMediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 576);
            this.Controls.Add(this.guna2GroupBox);
            this.Controls.Add(this.WindowsMediaPlayer);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBoxMinimize);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxMaximize);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxRestoreDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRakibMediaPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rakib Media Player";
            this.Load += new System.EventHandler(this.FormRakibMediaPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenMedium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestoreDown)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2GroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxMaximize;
        private System.Windows.Forms.PictureBox pictureBoxRestoreDown;
        private System.Windows.Forms.PictureBox pictureBoxMinimize;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxPause;
        private System.Windows.Forms.Label labelEnd;
        private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBarVideo;
        private System.Windows.Forms.PictureBox pictureBoxPlay;
        private System.Windows.Forms.PictureBox pictureBoxPrevious;
        private System.Windows.Forms.PictureBox pictureBoxStop;
        private System.Windows.Forms.PictureBox pictureBoxNext;
        private System.Windows.Forms.PictureBox pictureBoxOpenMedium;
        private System.Windows.Forms.Label labelVolume;
        private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBarVolume;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox pictureBox;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox;
        private System.Windows.Forms.ListBox listBoxMedia;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayer;
    }
}

