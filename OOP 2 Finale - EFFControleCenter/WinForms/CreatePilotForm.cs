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
    public partial class CreatePilotForm : Form
    {
        public Pilot? CreatedPilot { get; private set; }

        public CreatePilotForm()
        {
            InitializeComponent();
        }





        private void btnCreatePilot_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a pilot name.");
                return;
            }

            try
            {
                CreatedPilot = new Pilot(txtName.Text.Trim());

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelPilot_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
