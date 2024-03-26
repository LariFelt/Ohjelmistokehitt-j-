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

        private void poistuBT_Click(object sender, EventArgs e)
        {
            DialogResult sulje;
            sulje = MessageBox.Show("Haluatko varmasti lopettaa tilaamisen ja poistua?", "Tilauksen lopettaminen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sulje == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void kassaBT_Click(object sender, EventArgs e)
        {
            
                Form kassa = new kassaForm();
                kassa.Show();
                this.Hide();

        }
    }
}
