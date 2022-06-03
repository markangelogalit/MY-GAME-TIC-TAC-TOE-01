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
                if (buttontic1.Text == buttontic2.Text)
                {
                    if (buttontic2.Text == buttontic3.Text)
                    {
                        MessageBox.Show("You are the Winner!" + buttontic1.Text);
                        buttontic1.Text = "";
                        buttontic2.Text = "";
                        buttontic3.Text = "";
                        buttontic4.Text = "";
                        buttontic5.Text = "";
                        buttontic6.Text = "";
                        buttontic7.Text = "";
                        buttontic8.Text = "";
                        buttontic9.Text = "";
                    }
                }
            }
        }
    }
}