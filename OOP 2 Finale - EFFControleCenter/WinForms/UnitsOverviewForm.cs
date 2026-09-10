using OOP_2_Finale___EFFControleCenter.Models;
using OOP_2_Finale___EFFControleCenter.Units;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOP_2_Finale___EFFControleCenter.WinForms
{
    public partial class UnitsOverviewForm : Form
    {
        private readonly EFFControlCenter _controlCenter;
        public UnitsOverviewForm(EFFControlCenter controlCenter)
        {
            InitializeComponent();

            _controlCenter = controlCenter;

            dataGridViewUnits.ReadOnly = true;
            dataGridViewUnits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUnits.MultiSelect = false;
            dataGridViewUnits.AutoSizeColumnsMode =DataGridViewAutoSizeColumnsMode.Fill;

            RefreshUnitsGrid();
        }

        private void RefreshUnitsGrid()
        {
            dataGridViewUnits.DataSource = _controlCenter.Units.Select(unit => new
            {
                unit.Name,
                Type = unit.GetType().Name,
                unit.Health,
                unit.Energy,
                unit.IsAvailable,
                Pilot = unit.AssignedPilot?.Name ?? "none",
                Squad = unit.AssignedSquad.Name ?? "none"
            }).ToList();
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (dataGridViewUnits.CurrentRow == null) return;

            int id = (int)dataGridViewUnits.CurrentRow.Cells["Id"].Value;

            MobileUnit? unit = _controlCenter.FindUnitById(id);

            if (unit == null) return;

            using UnitDetailsForm form = new UnitDetailsForm(_controlCenter, unit);

            form.ShowDialog();

            RefreshUnitsGrid();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
