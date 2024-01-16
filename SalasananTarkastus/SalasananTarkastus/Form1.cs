namespace SalasananTarkastus
{
    public partial class SalasanaForm : Form
    {
        public SalasanaForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VirheviestiLB_TextChanged(object sender, EventArgs e)
        {

        }

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            if (KayttajaTB.Text == "Jyri" && SalasanaTB.Text == "Ja@kk0Ku1ta")
            {
                SalasanaPanel.Visible = false;
                SalasanaOikeinPanel.Visible = true;
            }
            else
            {
                VirheviestiLB.Text = "Käyttäjätunnus tai salasana virheellinen!";
                VirheviestiLB.Visible = true;
            }
        }

        private void SalasanaOikeinPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}