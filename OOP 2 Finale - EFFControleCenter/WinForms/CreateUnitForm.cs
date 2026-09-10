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
    public partial class CreateUnitForm : Form
    {
        public MobileUnit? CreatedUnit { get; private set; }

        public CreateUnitForm()
        {

            InitializeComponent();

            comboBoxUnitType.Items.AddRange(new object[]
            {
                "GM",
                "GunCannon",
                "AquaGM",
                "Gundam",
                "ZetaGundam"
            });

            comboBoxUnitType.SelectedIndex = 0;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string name = txtUnitName.Text.Trim();
            
            if (string.IsNullOrWhiteSpace(txtUnitName.Text))
            {
                MessageBox.Show("Please enter a name for the unit.");
                return;
            }

            MobileUnit unit = comboBoxUnitType.SelectedItem?.ToString() switch
            {
                "GM" => new GM(name),
                "GunCannon" => new GunCannon(name),
                "AquaGM" => new AquaGM(name),
                "Gundam" => new Gundam(name),
                "ZetaGundam" => new ZetaGundam(name),

                _ => throw new InvalidOperationException("Please select a valid unit type.")
            };

            unit.Name = txtUnitName.Text.Trim();

            CreatedUnit = unit;

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
