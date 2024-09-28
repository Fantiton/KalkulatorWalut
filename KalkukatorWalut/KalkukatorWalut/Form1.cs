namespace KalkukatorWalut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double uspl = 3.82;
        double usus = 1;
        double useu = 0.89;
        double usru = 93.33;
        double usbt = 32.36;

        private void button1_Click(object sender, EventArgs e)
        {
            decimal input = numInput.Value;

            double ctu = ((double)input * TRadioCheck());
            double res = ((double)ctu / CRadioCheck());

            label5.Text = res.ToString();
        }

        double CRadioCheck()
        {
            if (radioButton6.Checked)
            {
                return uspl;
            } else if (radioButton7.Checked)
            {
                return usus;
            }
            else if (radioButton8.Checked)
            {
                return useu;
            }
            else if (radioButton9.Checked)
            {
                return usru;
            }
            else if (radioButton10.Checked)
            {
                return usbt;
            }else 
            {
                return 0;
            }
        }
        double TRadioCheck()
        {
            if (radioButton1.Checked)
            {
                return uspl;
            }
            else if (radioButton2.Checked)
            {
                return usus;
            }
            else if (radioButton3.Checked)
            {
                return useu;
            }
            else if (radioButton4.Checked)
            {
                return usru;
            }
            else if (radioButton5.Checked)
            {
                return usbt;
            }
            else
            {
                return 0;
            }
        }
    }
}
