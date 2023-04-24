using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Loan
{
    public partial class FormPictureViewer : Form
    {
        public FormPictureViewer()
        {
            InitializeComponent();
        }

        private void pictureKnicks_Click(object sender, EventArgs e)
        {
            FormKnicks formknicks = new FormKnicks();
            formknicks.Show();
        }

        private void pictureBoxRaptors_Click(object sender, EventArgs e)
        {
            FormRaptors formRaptors = new FormRaptors();
            formRaptors.Show();
        }

        private void pictureBoxHeat_Click(object sender, EventArgs e)
        {
            FormHeat formHeat = new FormHeat();
            formHeat.Show();
        }

        private void pictureCavaliers_Click(object sender, EventArgs e)
        {
            FormCavaliers formCavaliers = new FormCavaliers();
            formCavaliers.Show();
        }

        private void pictureBoxHawks_Click(object sender, EventArgs e)
        {
            FormHawks formHawks = new FormHawks();
            formHawks.Show();
        }

        private void pictureBox76ers_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxBucks_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxBulls_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxCeltics_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxHornets_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxMagic_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxNets_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxPacers_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxPistons_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxWizards_Click(object sender, EventArgs e)
        {

        }
    }
}
