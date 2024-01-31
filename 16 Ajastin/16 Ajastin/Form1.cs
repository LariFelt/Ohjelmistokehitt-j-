using System.Diagnostics;
namespace _16_Ajastin
{
    public partial class ajastinForm : Form
    {
        private int kokonaisaika;
        public ajastinForm()
        {
            InitializeComponent();
        }
        private void ajastinForm_Load(object sender, EventArgs e)
        {
            pysaytaBT.Enabled = false;
            for(int i=0; i < 60; i++) 
            {
                minuutitCB.Items.Add(i.ToString());
                sekunnitCB.Items.Add(i.ToString()); 
            }
            minuutitCB.SelectedIndex = 30;
            sekunnitCB.SelectedIndex = 0;
        }


        private void kaynnistaBT_Click(object sender, EventArgs e)
        {
            kaynnistaBT.Enabled = false;
            pysaytaBT.Enabled = true;
            int minuutit = int.Parse(minuutitCB.SelectedItem.ToString());   
            int sekunnit = int.Parse(sekunnitCB.SelectedItem.ToString());
            kokonaisaika = (minuutit *60) + sekunnit;
            timer1.Enabled = true;
        }

        private void pysaytaBT_Click(object sender, EventArgs e)
        {
            kaynnistaBT.Enabled = true;
            pysaytaBT.Enabled = false;
            kokonaisaika = 0;
            timer1.Enabled = false;
            aikaLB.Text = "00:00";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(kokonaisaika > 0) 
            {
                kokonaisaika--;
                int minuutit = kokonaisaika / 60;
                int sekunnit = kokonaisaika - (minuutit * 60);
                aikaLB.Text = minuutit.ToString() + ":" + sekunnit.ToString();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Aikasi loppui!");
            }
        }
        private void sekuntiLB_Click(object sender, EventArgs e)
        {

        }


    }
}