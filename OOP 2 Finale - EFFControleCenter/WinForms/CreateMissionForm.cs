using OOP_2_Finale___EFFControleCenter.Enums;
using OOP_2_Finale___EFFControleCenter.Models;
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
    public partial class CreateMissionForm : Form
    {
        private readonly EFFControlCenter _controlCenter;
        public Mission? CreatedMission {  get; private set; }
        public CreateMissionForm(EFFControlCenter controlCenter)
        {
            InitializeComponent();

            _controlCenter = _controlCenter;

            comboBoxTerrain.DataSource = Enum.GetValues<TerrainType>();

            comboBoxThreat.DataSource = Enum.GetValues<ThreatLevel>();

            numericDuration.Minimum = 1;
            numericDuration.Maximum = 3600;
            numericDuration.Value = 30;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text)) { MessageBox.Show("Please enter a mission name."); return; }

            if (string.IsNullOrWhiteSpace(txtDesc.Text)) { MessageBox.Show("Please enter a mission description."); return; }

            if (comboBoxTerrain.SelectedItem is not TerrainType terrain) { MessageBox.Show("Please select a terrain."); return; }

            if (comboBoxThreat.SelectedItem is not ThreatLevel threatLevel)  { MessageBox.Show("Please select a threat level."); return; }

            CreatedMission = new Mission(txtName.Text.Trim(), txtDesc.Text.Trim(), txtLocation.Text.Trim(), threatLevel , terrain, TimeSpan.FromSeconds((double)numericDuration.Value));

            AppLogger.Log($"Mission created {CreatedMission.Name}");

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
