using Microsoft.VisualBasic.ApplicationServices;
using System.IO;
namespace Paivakirja
{
    public partial class PaivakirjaForm : Form
    {
        public PaivakirjaForm()
        {
            InitializeComponent();
            string teksti = File.ReadAllText("C:\\Users\\lari.felt\\source\\repos\\Ohjelmistokehittaja\\Paivakirja\\Paivakirja\\Demo.txt");
            SyottoTB.Text = teksti;
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = "";
            teksti += SyottoTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            TextWriter text = new StreamWriter("C:\\Users\\lari.felt\\source\\repos\\Ohjelmistokehittaja\\Paivakirja\\Paivakirja\\Demo.txt");
            text.Write(teksti);
            text.Close();
            Application.Exit();
        }
    }
}