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
    public partial class UnitDetailsForm : Form
    {
        private readonly EFFControlCenter _controlCenter;
        private readonly MobileUnit _unit;

        public UnitDetailsForm(EFFControlCenter controlCenter, MobileUnit unit)
        {
            InitializeComponent();
            _controlCenter = controlCenter;
            _unit = unit;

            LoadUnitInfo();
        }

        private void LoadUnitInfo()
        {
            lblName.Text = _unit.Name;
            lblType.Text = _unit.GetType().Name;
            lblHealth.Text = _unit.Health.ToString();
            lblEnergy.Text = _unit.Energy.ToString();
            lblAvailable.Text = _unit.IsAvailable ? "Available" : "Deployed";

            comboBoxPilot.Items.Clear();
            comboBoxPilot.Items.Add("None");

            foreach (Pilot pilot in _controlCenter.Pilots)
            {
                if (pilot.AssignedUnit == null || pilot.AssignedUnit == _unit)
                {
                    comboBoxPilot.Items.Add(pilot);
                }
            }

            if (_unit.AssignedPilot != null) comboBoxPilot.SelectedItem = _unit.AssignedPilot;
            else comboBoxPilot.SelectedIndex = 0;


            checkedListBoxWeapons.Items.Clear();

            foreach (Weapon weapon in _controlCenter.Weapons)
            {
                bool isEquipped = false;

                if (_unit is MobileWeapon mobileWeapon) isEquipped = mobileWeapon.Loadout.Contains(weapon);


                checkedListBoxWeapons.Items.Add(weapon, isEquipped);
            }
        }
        private void SavePilotAssignment()
        {
            if (_unit.AssignedPilot != null) _unit.RemovePilot();

            if (comboBoxPilot.SelectedItem is Pilot pilot) _unit.AssignPilot(pilot);

        }

        private void SaveWeaponLoadout()
        {
            if (_unit is not MobileWeapon mobileWeapon) return;

            foreach (Weapon weapon in mobileWeapon.Loadout.ToList()) mobileWeapon.RemoveWeapon(weapon);


            foreach (Weapon weapon in checkedListBoxWeapons.CheckedItems) mobileWeapon.AddWeapon(weapon);

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (_unit is MobileWeapon && checkedListBoxWeapons.CheckedItems.Count > 3)
            {
                MessageBox.Show("A mobile weapon can carry a maximum of 3 weapons.");
                return;
            }
            

            SavePilotAssignment();
            SaveWeaponLoadout();

            await DataSaver.SaveAllData(_controlCenter);

            MessageBox.Show("Unit updated successfully.");

            Close();
        }

        private async void btnRemoveUnit_Click(object sender, EventArgs e)
        {
            if (!_unit.IsAvailable) { MessageBox.Show("A deployed unit cannot be removed."); return; }

            DialogResult result = MessageBox.Show(
                $"Remove {_unit.Name}?",
                "Confirm removal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) return;

            _controlCenter.RemoveUnitById(_unit.Id);

            await DataSaver.SaveAllData(_controlCenter);

            Close();
        }
    }
}
