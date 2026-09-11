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

        private readonly TimeSpan _totalDuration;
        private TimeSpan _remainingTime;

        private readonly System.Windows.Forms.Timer _timer;

        private int _startX;
        private int _endX;
        public MissionCountdownForm(Mission mission)
        {
            InitializeComponent();

            _mission = mission;

            _totalDuration = mission.Duration;
            _remainingTime = mission.Duration;

            label1.Text = mission.Name;

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            _startX = ClientSize.Width - pictureBox1.Width - 10;

            _endX = 10;

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

            if (_remainingTime <= TimeSpan.Zero)
            {
                _remainingTime = TimeSpan.Zero;

                pictureBox1.Left = _endX;

                label2.Text = "MISSION COMPLETE";

                _timer.Stop();

                return;
            }

            UpdateCountdown();

            UpdateGundamPosition();
        }

        private void UpdateCountdown()
        {
            label2.Text =$"{_remainingTime.Minutes:D2}:{_remainingTime.Seconds:D2}";
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
    }
}
