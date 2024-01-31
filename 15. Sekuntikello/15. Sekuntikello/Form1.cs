using System.Diagnostics;
namespace _15._Sekuntikello
{
    public partial class SekuntikelloForm : Form
    {
        private Stopwatch sekkari = new Stopwatch();
        public SekuntikelloForm()
        {
            InitializeComponent();
        }

        private void kaynnistaBT_Click(object sender, EventArgs e)
        {
            sekkari.Start();
        }

        private void pysaytaBT_Click(object sender, EventArgs e)
        {
            sekkari.Stop();
        }

        private void nollaaBT_Click(object sender, EventArgs e)
        {
            sekkari.Reset();
        }

        private void ajastinTM_Tick(object sender, EventArgs e)
        {
            SekkariLB.Text = String.Format("{0:hh\\:mm\\:ss\\:fff}", sekkari.Elapsed);
        }
    }
}