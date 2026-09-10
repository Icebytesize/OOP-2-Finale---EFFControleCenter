using OOP_2_Finale___EFFControleCenter.Models;
using OOP_2_Finale___EFFControleCenter.Units;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OOP_2_Finale___EFFControleCenter.WinForms
{
    public partial class CreateSquadForm : Form
    {
        private readonly EFFControlCenter _controlCenter;
        public Squad? CreatedSquad { get; private set; }
        public CreateSquadForm(EFFControlCenter controlCenter)
        {
            InitializeComponent();

            _controlCenter = controlCenter;

            foreach (MobileUnit unit in _controlCenter.Units)
            {
                if (unit.AssignedSquad == null && unit.IsAvailable)
                {
                    checkedListBoxUnits.Items.Add(unit);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateSquad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNameSquad.Text))
            {
                MessageBox.Show("Please enter a squad name."); return;
            }

            if (checkedListBoxUnits.CheckedItems.Count > 4)
            {
                MessageBox.Show("A squad can contain a maximum of 4 units."); return;
            }

            Squad squad = new Squad(txtNameSquad.Text.Trim());

            foreach (MobileUnit unit in checkedListBoxUnits.CheckedItems)
            {
                squad.AddUnit(unit);
            }

            CreatedSquad = squad;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelSquad_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
