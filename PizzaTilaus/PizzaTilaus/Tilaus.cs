using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaTilaus
{
    public partial class TilausForm : Form
    {
        public TilausForm()
        {
            InitializeComponent();
        }
        private void kassaBT_Click(object sender, EventArgs e)
        {
            Form Kassa = new kassaForm();
            Kassa.Show();
            this.Hide();
        }

        private void tyhjennaBT_Click(object sender, EventArgs e)
        {
            Form tilaus = new TilausForm();
            tilaus.Show();
            this.Hide();
        }

        private void poistuBT_Click(object sender, EventArgs e)
        {
            DialogResult sulje;
            sulje = MessageBox.Show("Haluatko varmasti lopettaa tilaamisen ja poistua?", "Tilauksen lopettaminen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sulje == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void kinkkuCB_CheckedChanged(object sender, EventArgs e)
        {
            LaskeSumma();
        }

        private void salamiCB_CheckedChanged(object sender, EventArgs e)
        {
            LaskeSumma();
        }

        private void pepperoniCB_CheckedChanged(object sender, EventArgs e)
        {
            LaskeSumma();
        }

        private void jauhelihaCB_CheckedChanged(object sender, EventArgs e)
        {
            LaskeSumma();
        }

        private void pekoniCB_CheckedChanged(object sender, EventArgs e)
        {
            LaskeSumma();
        }

        private void kebabCB_CheckedChanged(object sender, EventArgs e)
        {
            LaskeSumma();
        }

        private void tonnikalaCB_CheckedChanged(object sender, EventArgs e)
        {
            LaskeSumma();
        }

        private void kanaCB_CheckedChanged(object sender, EventArgs e)
        {
            LaskeSumma();
        }

        private void katkarapuCB_CheckedChanged(object sender, EventArgs e)
        {
            LaskeSumma();
        }

        private void poroCB_CheckedChanged(object sender, EventArgs e)
        {
            LaskeSumma();
        }

        private void ananasCB_CheckedChanged(object sender, EventArgs e)
        {
            LaskeSumma();
        }

        private void avokadoCB_CheckedChanged(object sender, EventArgs e)
        {
            LaskeSumma();
        }

        private void sieniCB_CheckedChanged(object sender, EventArgs e)
        {
            LaskeSumma();
        }

        private void jalapenoCB_CheckedChanged(object sender, EventArgs e)
        {
            LaskeSumma();
        }

        private void tomaattiCB_CheckedChanged(object sender, EventArgs e)
        {
            LaskeSumma();
        }

        private void oliiviCB_CheckedChanged(object sender, EventArgs e)
        {
            LaskeSumma();
        }

        private void sipaliCB_CheckedChanged(object sender, EventArgs e)
        {
            LaskeSumma();
        }

        private void paprikaCB_CheckedChanged(object sender, EventArgs e)
        {
            LaskeSumma();
        }

        private void salaattiCB_CheckedChanged(object sender, EventArgs e)
        {
            LaskeSumma();
        }

        private void rucolaCB_CheckedChanged(object sender, EventArgs e)
        {
            LaskeSumma();
        }

        private void auraCB_CheckedChanged(object sender, EventArgs e)
        {
            LaskeSumma();
        }

        private void FetaCB_CheckedChanged(object sender, EventArgs e)
        {
            LaskeSumma();
        }

        private void juustoCB_CheckedChanged(object sender, EventArgs e)
        {
            LaskeSumma();
        }

        private void parmeCB_CheckedChanged(object sender, EventArgs e)
        {
            LaskeSumma();
        }

        private void mozzaCB_CheckedChanged(object sender, EventArgs e)
        {
            LaskeSumma();
        }

        private void valkoCB_CheckedChanged(object sender, EventArgs e)
        {
            LaskeSumma();
        }

        private void LaskeSumma()
        {
            decimal summa = 0;

            foreach (Control control in this.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    if (decimal.TryParse((string)checkBox.Tag, out decimal arvo))
                    {
                        summa += arvo;
                        Console.WriteLine($"{checkBox.Name}: {arvo}"); // Tulosta checkboxin nimi ja arvo
                    }
                }
            }

            summaTB.Text = summa.ToString("F2");
        }

        private void summaTB_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void smallCB_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}