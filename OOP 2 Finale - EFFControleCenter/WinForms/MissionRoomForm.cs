using OOP_2_Finale___EFFControleCenter.Enums;
using OOP_2_Finale___EFFControleCenter.Models;
using OOP_2_Finale___EFFControleCenter.Services;
using OOP_2_Finale___EFFControleCenter.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOP_2_Finale___EFFControleCenter.WinForms
{
    public partial class MissionRoomForm : Form
    {
        private readonly EFFControlCenter _controlCenter;
        public MissionRoomForm(EFFControlCenter controlcenter)
        {
            InitializeComponent();

            _controlCenter = controlcenter;

            LoadMissions();
        }
        private void MissionCompletedLog(Mission mission)
        {
            AppLogger.Log($"Named callback: Mission {mission.Name} completed.");
        }
        private void LoadMissions()
        {

            var pendingMissions = SearchHelper.Filter(_controlCenter.Missions, mission => mission.Status == MissionStatus.Pending);

            dataGridViewMission.DataSource = pendingMissions.Select(mission => new
            {
                mission.Id,
                mission.Name,
                mission.Location,
                Terrain = mission.Terrain.ToString(),
                ThreatLevel = mission.ThreatLevel.ToString(),
                Status = mission.Status.ToString(),
                Squad = mission.AssignedSquad?.Name ?? "None"
            }).ToList();

            dataGridViewMission.Columns["Id"].Visible = false;
            dataGridViewMission.Columns["Squad"].Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnStartMission_Click(object sender, EventArgs e)
        {
            if (dataGridViewMission.CurrentRow == null)
            {
                MessageBox.Show("Please select a mission."); return;
            }

            int missionId = (int)dataGridViewMission.CurrentRow.Cells["Id"].Value;

            Mission? mission = _controlCenter.FindMissionById(missionId);

            if (mission == null)
            {
                MessageBox.Show("Mission could not be found."); return;
            }


            using SelectSquadForm selectSquadForm = new SelectSquadForm(_controlCenter);

            if (selectSquadForm.ShowDialog() != DialogResult.OK) return;

            Squad? squad = selectSquadForm.SelectedSquad;

            if (squad == null) return;

            try
            {
                _controlCenter.AssignSquadToMission(squad, mission);

                AppLogger.Log($"Squad {squad.Name} assigned to mission {mission.Name}.");

                mission.MissionCompleted += MissionCompletedLog;

                mission.MissionCompleted += completedMission =>
                {
                    AppLogger.Log($"Lambda Callback: Mission {completedMission.Name} completed.");
                };

                AppLogger.Log($"Mission {mission.Name} started.");

                MissionCountdownForm countdownForm = new MissionCountdownForm(mission);
                countdownForm.Show();

                await mission.RunMissionAsync();

                await DataSaver.SaveAllData(_controlCenter);

                LoadMissions();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                AppLogger.Log(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadMissions();
        }
    }
}
