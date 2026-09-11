using OOP_2_Finale___EFFControleCenter.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOP_2_Finale___EFFControleCenter.WinForms
{
    public partial class MissionCountdownForm : Form
    {
        private readonly Mission _mission;
        private int _animationTimer = 0;
        private Image _img1;
        private Image _img2;
        private Image _imgCompelte;
        private bool _useFirstImage = true;

        private readonly TimeSpan _totalDuration;
        private TimeSpan _remainingTime;

        private readonly System.Windows.Forms.Timer _timer;

        private int _startX;
        private int _endX;
        public MissionCountdownForm(Mission mission)
        {
            InitializeComponent();
            string imageFolder = Path.Combine(AppContext.BaseDirectory,"Image");

            _img1 = Image.FromFile(Path.Combine(imageFolder, "Gundam1.png"));

            _img2 = Image.FromFile(Path.Combine(imageFolder, "Gundam2.png"));

            _imgCompelte = Image.FromFile(Path.Combine(imageFolder, "GundamComplete.png"));

            pictureBox1.Image = _img1;

            _mission = mission;

            _totalDuration = mission.Duration;
            _remainingTime = mission.Duration;

            label1.Text = mission.Name;

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            _startX =  10;

            _endX = ClientSize.Width - pictureBox1.Width - 10;

            pictureBox1.Left = _startX;

            UpdateCountdown();

            _timer = new System.Windows.Forms.Timer();

            _timer.Interval = 50;

            _timer.Tick += Timer_Tick;

            _timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            _remainingTime -= TimeSpan.FromMilliseconds(_timer.Interval);

            _animationTimer++;

            if (_animationTimer >= 4)
            {
                _useFirstImage = !_useFirstImage;
                pictureBox1.Image = _useFirstImage ? _img1 : _img2;
                _animationTimer = 0;
            }

           

            if (_remainingTime <= TimeSpan.Zero)
            {
                _remainingTime = TimeSpan.Zero;

                _timer.Stop();

                label2.Text = "MISSION COMPLETE";

                pictureBox1.Image = _imgCompelte;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                pictureBox1.Dock = DockStyle.Fill;



                return;
            }

            UpdateCountdown();

            UpdateGundamPosition();
        }

        private void UpdateCountdown()
        {
            label2.Text = $"{_remainingTime.Minutes:D2}:{_remainingTime.Seconds:D2}";
        }

        private void UpdateGundamPosition()
        {
            double elapsedMilliseconds =
                _totalDuration.TotalMilliseconds -
                _remainingTime.TotalMilliseconds;

            double progress =
                elapsedMilliseconds /
                _totalDuration.TotalMilliseconds;

            int newX =
                _startX +
                (int)((_endX - _startX) * progress);

            pictureBox1.Left = newX;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
