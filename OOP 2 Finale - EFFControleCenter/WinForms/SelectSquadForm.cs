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
    public partial class SelectSquadForm : Form
    {
        private readonly EFFControlCenter _controlCenter;

        public Squad? SelectedSquad { get; private set; }

        public SelectSquadForm(EFFControlCenter controlCenter)
        {
            InitializeComponent();

            _controlCenter = controlCenter;

            var readySquads = _controlCenter.Squads.Where(squad => squad.IsReadyForMission()).ToList();

            comboBox1.DataSource = readySquads;
        }

        private void btnStartMission_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is not Squad squad)
            {
                MessageBox.Show("Please select a squad.");
                return;
            }

            SelectedSquad = squad;

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
