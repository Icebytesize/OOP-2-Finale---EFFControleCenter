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

        private void LoadMissions()
        {
            dataGridViewMission.DataSource = _controlCenter.Missions.Select(mission => new
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

            try
            {
                Squad assignedSquad = _controlCenter.AssignSquadToMission(mission);

                AppLogger.Log($"Squad {assignedSquad.Name} assigned to mission {mission.Name}.");

                mission.MissionCompleted += completedMission =>
                {
                    AppLogger.Log($"Mission {completedMission.Name} completed.");
                };

                AppLogger.Log($"Mission {mission.Name} started.");

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
    }
}
