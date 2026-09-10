using OOP_2_Finale___EFFControleCenter.Models;
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
    public partial class CreateWeaponForm : Form
    {
        public Weapon? CreatedWeapon { get; private set; }
        public CreateWeaponForm()
        {
            InitializeComponent();
        }

        private void btnCancelWeapon_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnCreateWeapon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
                        {
                            MessageBox.Show("Please enter a weapon name");
                            return;
                        }
            if (!int.TryParse(textBoxDmg.Text, out int damage))
            {
                MessageBox.Show("Damage must be a valid number.");
                return;
            }

            if (!int.TryParse(textBoxEC.Text, out int energyCost))
            {
                MessageBox.Show("Energy cost must be a valid number.");
                return;
            }

            try
            {
                CreatedWeapon = new Weapon(
                    textBoxName.Text.Trim(),
                    damage,
                    energyCost);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
