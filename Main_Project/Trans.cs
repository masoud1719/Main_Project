using System;
using System.Windows.Forms;

namespace trans_1
{
    public partial class SinglePhaseTransformer : Form
    {
        private double rating;
        private double voltagePerTurn;
        private double highVoltage;
        private double lowVoltage;
        private double frequency;
        private double fluxDensity;
        private double delta;
        private double temperatureRise;
        private double anTemperature;
        private double wI;
        private double aI;
        private double giPerGcu;
        private double lmtPerLi;
        private double gcuPergi;
        private double ciPerCu;
        private double x;
        private double dPera;
        private double acuPerAi;
        private double ks;
        private double kc;
        private double kw;
        private double kFactor;
        private double sf;

        public SinglePhaseTransformer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getvalues();

        }

        private void getvalues()
        {
            rating = Double.Parse(txt_raiting.Text);
            voltagePerTurn = Double.Parse(txt_voltageperturnvalue.Text);
            highVoltage = Double.Parse(txt_HighVoltage.Text);
            lowVoltage = Double.Parse(txt_LowVoltage.Text);


        }
    }
}