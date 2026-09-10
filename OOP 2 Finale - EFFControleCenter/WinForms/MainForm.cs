using OOP_2_Finale___EFFControleCenter.Data;
using OOP_2_Finale___EFFControleCenter.Models;
using OOP_2_Finale___EFFControleCenter.Services;
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
    public partial class MainForm : Form
    {
        private EFFControlCenter? _controlCenter;

        public MainForm()
        {
            InitializeComponent();

            //dataGridViewUnits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            Load += MainForm_Load;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            _controlCenter = await DataLoader.LoadAllData();

            //RefreshUnitsGrid();
        }

        /*private void RefreshUnitsGrid()
        {
            if (_controlCenter == null) return;

            dataGridViewUnits.DataSource = _controlCenter.Units.Select(unit => new
            {
                unit.Name,
                Type = unit.GetType().Name,
                unit.Health,
                unit.Energy,
                unit.IsAvailable,
                Pilot = unit.AssignedPilot?.Name ?? "None",
                Squad = unit.AssignedSquad?.Name ?? "None"
            })
                .ToList();
        } */

        private async void btnCreateUnit_Click(object sender, EventArgs e)
        {
            contextMenuStripCreate.Show(
            btnCreate,
            new Point(0, btnCreate.Height));
            /* if (_controlCenter == null)
                return;

            using CreateUnitForm createForm = new CreateUnitForm();

            if (createForm.ShowDialog() == DialogResult.OK &&
                createForm.CreatedUnit != null)
            {
                MobileUnit newUnit = createForm.CreatedUnit;

                int nextId = await JsonService.GetNextId<MobileUnitData>("units.json");

                newUnit.Id = nextId;

                _controlCenter.AddUnit(newUnit);

                await UnitJsonService.AppendUnitsToJson("units.json", new List<MobileUnit> { newUnit });

                RefreshUnitsGrid(); 
            } */
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_controlCenter == null)
                return;

            using CreateUnitForm createForm = new CreateUnitForm();

            if (createForm.ShowDialog() == DialogResult.OK &&
                createForm.CreatedUnit != null)
            {
                MobileUnit newUnit = createForm.CreatedUnit;

                int nextId = await JsonService.GetNextId<MobileUnitData>("units.json");

                newUnit.Id = nextId;

                _controlCenter.AddUnit(newUnit);

                await UnitJsonService.AppendUnitsToJson("units.json", new List<MobileUnit> { newUnit });


            }
        }

        private void contextMenuStripCreate_Opening(object sender, CancelEventArgs e)
        {

        }

        private async void toolStripMenuPilot_Click(object sender, EventArgs e)
        {

        }
    }
}
