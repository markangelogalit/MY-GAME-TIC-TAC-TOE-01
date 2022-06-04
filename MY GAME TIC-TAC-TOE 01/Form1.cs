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
                if (buttontic1.Text == buttontic4.Text)
                {
                    if (buttontic4.Text == buttontic7.Text)
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
                if (buttontic1.Text == buttontic5.Text)
                {
                    if (buttontic5.Text == buttontic9.Text)
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

        private void buttontic2_Click(object sender, EventArgs e)
        {
            if (buttontic2.Text == "")
            {
                buttontic2.Text = Valuebtntic;
                if (Valuebtntic == "X")
                {
                    Valuebtntic = "O";
                }
                else
                {
                    Valuebtntic = "X";
                }
                if (buttontic2.Text == buttontic3.Text)
                {
                    if (buttontic3.Text == buttontic1.Text)
                    {
                        MessageBox.Show("You are the Winner!" + buttontic2.Text);
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
                if (buttontic2.Text == buttontic5.Text)
                {
                    if (buttontic5.Text == buttontic8.Text)
                    {
                        MessageBox.Show("You are the Winner!" + buttontic2.Text);
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

        private void buttontic3_Click(object sender, EventArgs e)
        {
            if (buttontic3.Text == "")
            {
                buttontic3.Text = Valuebtntic;
                if (Valuebtntic == "X")
                {
                    Valuebtntic = "O";
                }
                else
                {
                    Valuebtntic = "X";
                }
                if (buttontic3.Text == buttontic2.Text)
                {
                    if (buttontic2.Text == buttontic1.Text)
                    {
                        MessageBox.Show("You are the Winner!" + buttontic3.Text);
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
                if (buttontic3.Text == buttontic6.Text)
                {
                    if (buttontic6.Text == buttontic9.Text)
                    {
                        MessageBox.Show("You are the Winner!" + buttontic3.Text);
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

        private void buttontic4_Click(object sender, EventArgs e)
        {
            if (buttontic4.Text == "")
            {
                buttontic4.Text = Valuebtntic;
                if (Valuebtntic == "X")
                {
                    Valuebtntic = "O";
                }
                else
                {
                    Valuebtntic = "X";
                }
                if (buttontic4.Text == buttontic5.Text)
                {
                    if (buttontic5.Text == buttontic6.Text)
                    {
                        MessageBox.Show("You are the Winner!" + buttontic4.Text);
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

        private void buttontic5_Click(object sender, EventArgs e)
        {
            if (buttontic5.Text == "")
            {
                buttontic5.Text = Valuebtntic;
                if (Valuebtntic == "X")
                {
                    Valuebtntic = "O";
                }
                else
                {
                    Valuebtntic = "X";
                }
                if (buttontic5.Text == buttontic6.Text)
                {
                    if (buttontic6.Text == buttontic7.Text)
                    {
                        MessageBox.Show("You are the Winner!" + buttontic5.Text);
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

        private void buttontic6_Click(object sender, EventArgs e)
        {
            if (buttontic6.Text == "")
            {
                buttontic6.Text = Valuebtntic;
                if (Valuebtntic == "X")
                {
                    Valuebtntic = "O";
                }
                else
                {
                    Valuebtntic = "X";
                }
                if (buttontic6.Text == buttontic7.Text)
                {
                    if (buttontic7.Text == buttontic8.Text)
                    {
                        MessageBox.Show("You are the Winner!" + buttontic6.Text);
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

        private void buttontic7_Click(object sender, EventArgs e)
        {
            if (buttontic7.Text == "")
            {
                buttontic7.Text = Valuebtntic;
                if (Valuebtntic == "X")
                {
                    Valuebtntic = "O";
                }
                else
                {
                    Valuebtntic = "X";
                }
                if (buttontic7.Text == buttontic8.Text)
                {
                    if (buttontic8.Text == buttontic9.Text)
                    {
                        MessageBox.Show("You are the Winner!" + buttontic7.Text);
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

