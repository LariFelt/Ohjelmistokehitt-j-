using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace PizzaTilaus
{
    public partial class TilausForm : Form
    {
        private List<CheckBox> _pienijuomaCBs = new List<CheckBox>();
        private List<CheckBox> _isojuomaCBs = new List<CheckBox>();
        private double _summa = 0.00;

        public double Summa
        {
            get { return _summa; }
            set
            {
                _summa = value;
                summaTB.Text = _summa.ToString("C", _fiNumberFormat);
            }
        }
        // Valuuttamuotoilu sekoilut
        private readonly NumberFormatInfo _fiNumberFormat = new NumberFormatInfo { CurrencySymbol = "€" };

        public TilausForm()
        {

            InitializeComponent();
            pizzaKokoCB.SelectedIndex = 0;

            foreach (Control control in pienijuomaGB.Controls)
            {
                if (control is CheckBox)
                {
                    _pienijuomaCBs.Add((CheckBox)control);
                    ((CheckBox)control).CheckedChanged += PienijuomaCB_CheckedChanged;
                }
            }
            foreach (Control control in isojuomaGB.Controls)
            {
                if (control is CheckBox)
                {
                    _isojuomaCBs.Add((CheckBox)control);
                    ((CheckBox)control).CheckedChanged += isojuomaCB_CheckedChanged;
                }
            }
            //CheckedChanged-tapahtuma jokaiselle checkboxille tayteBG groupboxissa
            foreach (Control control in tayteGB.Controls)
            {
                if (control is CheckBox)
                {
                    ((CheckBox)control).CheckedChanged += CheckBox_CheckedChanged;
                }
            }
        }
        private double GetPizzaKokoHinta()
        {
            switch (pizzaKokoCB.SelectedItem)
            {
                case "Medium 10,00€":
                    return 10.00;
                case "Large 15,00€":
                    return 15.00;
                default:
                    return 7.00;
            }
        }
        private double GetPienijuomaHinta()
        {
            double hinta = 0.00;
            foreach (CheckBox cb in _pienijuomaCBs)
            {
                if (cb.Checked)
                {
                    hinta += 2.50;
                }
            }
            return hinta;
        }
        private double GetIsojuomaHinta()
        {
            double hinta = 0.00;
            foreach (Control control in _isojuomaCBs)
            {
                if (control is CheckBox)
                {
                    if (((CheckBox)control).Checked)
                    {
                        hinta += 5.50;
                    }
                }
            }
            return hinta;
        }
        private void PienijuomaCB_CheckedChanged(object sender, EventArgs e)
        {
            Summa = GetPizzaKokoHinta() + GetPienijuomaHinta() + GetIsojuomaHinta();
        }

        private void isojuomaCB_CheckedChanged(object sender, EventArgs e)
        {
            Summa = GetPizzaKokoHinta() + GetPienijuomaHinta() + GetIsojuomaHinta();
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Lasketaan valittujen täytteiden lukumäärä
            int count = 0;
            foreach (Control control in tayteGB.Controls)
            {
                if (control is CheckBox)
                {
                    if (((CheckBox)control).Checked)
                    {
                        count++;
                    }
                }
            }

            Summa = count + GetPizzaKokoHinta() + GetPienijuomaHinta() + GetIsojuomaHinta();
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

        private void pienijuomaGB_Enter(object sender, EventArgs e)
        {

        }

        private void pizzaKokoCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pizzaKokoCB.SelectedIndex == 0)
            {
                pizzaKokoCB.Text = "Small";
            }
        }

        private void kkCB_CheckedChanged(object sender, EventArgs e)
        {
            if (kkCB.Checked)
            {
                Summa += 5.00;
                ttGB.Visible = true;
            }
            else
            {
                Summa -= 5.00;
                ttGB.Visible = false;
            }
        }

        private void tilausBT_Click(object sender, EventArgs e)
        {
            if (kkCB.Checked)
            {
                // Hae osoitetiedot ttBG:stä
                string katu = katuTB.Text;
                string ptp = ptpTB.Text;
                string pnro = pnroTB.Text;

                // Laske toimitusaika (30 minuuttia)
                TimeSpan toimitusaika = TimeSpan.FromMinutes(30);

                // Luo ilmoitusteksti
                string ilmoitus = $"Kiitos tilauksestasi!\n" +
                                  $"Tilaus toimitetaan osoitteeseen:\n" +
                                  $"{katu} {ptp} {pnro}\n" +
                                  $"Toimitusaika: noin {toimitusaika.TotalMinutes} minuuttia";

                // Näytä ilmoitus
                MessageBox.Show(ilmoitus, "Tilaus vahvistettu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Laske noutoaika (20 minuuttia)
                TimeSpan noutoaika = TimeSpan.FromMinutes(20);

                // Luo ilmoitusteksti
                string ilmoitus = $"Kiitos tilauksestasi!\n" +
                                  $"Tilauksesi on noudettavissa noin {noutoaika.TotalMinutes} minuutin kuluttua";

                // Näytä ilmoitus
                MessageBox.Show(ilmoitus, "Tilaus vahvistettu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

