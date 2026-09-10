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
            if (_controlCenter == null) return;

            using CreatePilotForm createForm = new CreatePilotForm();

            if (createForm.ShowDialog() == DialogResult.OK && createForm.CreatedPilot != null)
            {
                Pilot newPilot = createForm.CreatedPilot;

                int nextId = await JsonService.GetNextId<Pilot>("pilots.json");

                newPilot.Id = nextId;

                _controlCenter.AddPilot(newPilot);

                await JsonService.AppendToJson("pilots.json", new List<Pilot> { newPilot });
            }
        }

        private async void toolStripMenuWeapon_Click(object sender, EventArgs e)
        {
            if (_controlCenter == null) return;

            using CreateWeaponForm createForm = new CreateWeaponForm();

            if (createForm.ShowDialog() == DialogResult.OK && createForm.CreatedWeapon != null)
            {
                Weapon newWeapon = createForm.CreatedWeapon;

                int nextId = await JsonService.GetNextId<Weapon>("weapons.json");

                newWeapon.Id = nextId;

                _controlCenter.AddWeapon(newWeapon);

                await JsonService.AppendToJson("weapons.json", new List<Weapon> { newWeapon });
            }
        }

        private async void toolStripMenuSquad_Click(object sender, EventArgs e)
        {
            if ( _controlCenter == null) return;

            using CreateSquadForm createForm = new CreateSquadForm(_controlCenter);

            if (createForm.ShowDialog() == DialogResult.OK && createForm.CreatedSquad != null)
            {
                Squad newSquad = createForm.CreatedSquad;

                int nextId = await JsonService.GetNextId<SquadData>("squads.json");

                newSquad.Id = nextId;

                _controlCenter.AddSquad(newSquad);

                await SquadJsonService.AppendSquadsToJson("squads.json", new List<Squad> { newSquad });

                MessageBox.Show($"{newSquad.Name} created successfully.");
            }
        }
    }
}
