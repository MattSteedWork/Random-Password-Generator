namespace Password_Gen
{
    public partial class RndPass : Form
    {

        public RndPass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rndLC = new Random();
            Random rndUC = new Random();
            Random rndNN = new Random();
            Random rndSP = new Random();
            string pass = "";

            for (int i = 0; i < 10; i++)
            {
                label1.Text = "";
                char randomChar = (char)rndLC.Next('a', 'z');
                pass += randomChar;
                char randomChar2 = (char)rndUC.Next('A', 'Z');
                pass += randomChar2;
                char randomCharN = (char)rndNN.Next('0', '9');
                pass += randomCharN;
                char randomCharS = (char)rndSP.Next('!', '+');
                pass += randomCharS;
                label1.Text += pass;
            }
        }

    }
}
