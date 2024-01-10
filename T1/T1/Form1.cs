namespace T1
{
    public partial class T1form : Form
    {
        public T1form()
        {
            InitializeComponent();
        }
        int laskuri = 0;
        private void vaihdabt_Click(object sender, EventArgs e)
        {
            
            if (otsikkolb.Text == "Otsikko")
            {
                otsikkolb.Text = "Heippa maailma!";
            }
            else
            {
                otsikkolb.Text = "Otsikko";
            }
            laskuri++;
            laskurilb.Text = laskuri.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}