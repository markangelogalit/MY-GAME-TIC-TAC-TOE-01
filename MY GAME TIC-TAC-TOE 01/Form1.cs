namespace MY_GAME_TIC_TAC_TOE_01
{
    public partial class Form1 : Form
    {
        string Valuebtntic = "X";
        public Form1()
        {
            InitializeComponent();
        }

        private void buttontic1_Click(object sender, EventArgs e)
        {
            if (buttontic1.Text == "")
            {
                buttontic1.Text = Valuebtntic;
                if (Valuebtntic == "X")
                {
                    Valuebtntic = "O";
                }
                else
                {
                    Valuebtntic = "X";
                }
            }
        }
    }
}