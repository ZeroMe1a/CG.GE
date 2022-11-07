using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG.GE
{
    public partial class FormCasa : Form
    {
        // eletronic struct
        struct eletron
        {
            public bool state;
            public int volt;

            public eletron(bool s, int v)
            {
                this.state = s;
                this.volt = v;
            }
        }

        // calc values
        const float fpu = 1.028690f;
        public float flagSum { get; set; }
        public int interval { get; set; }

        float kwh = 0;
        float total = 0;

        // uma lâmpada LED de 3W demora ~333 HORAS pra gastar 1 kW
        // uma TV LED 4K de 60" demora ~5 horas pra gastar 1 kW (https://www.fastshop.com.br/wcsstore/FastShopCAS/manuais/VD/Samsung/SGUN55KU6500.pdf)

        // https://www.ovoenergy.com/guides/energy-guides/what-is-a-kwh-kw-and-kwh-explained


        Dictionary<string, eletron> eletros = new Dictionary<string, eletron>();
        public Dictionary<string, float> flagsValues = new Dictionary<string, float>();

        public FormCasa()
        {
            flagSum = 0;

            // populating eletronic dictionary
            eletros.Add("luzSala",      new eletron(false, 3));
            eletros.Add("tvSala",       new eletron(false, 140));
            eletros.Add("coziFogo",    new eletron(false, 25));
            eletros.Add("coziGelo",    new eletron(false, 500));
            eletros.Add("luzCozi",      new eletron(false, 3));

            // populating flag dictionary
            flagsValues.Add("Verde",               0);
            flagsValues.Add("Amarela",            0.01874f);
            flagsValues.Add("Vermelha - 1°",    0.03971f);
            flagsValues.Add("Vermelha - 2°",    0.09492f);

            interval = 1;

            InitializeComponent();
        }

        //
        // SWITCHES
        //

        private void switchState(Button switcher, PictureBox target)
        {
            switcher.BackColor = eletros[target.Name].state ? Color.Red : Color.Green;
            target.Visible = !eletros[target.Name].state;
            eletros[target.Name] = new eletron(!eletros[target.Name].state, eletros[target.Name].volt);
        }

        private void luzSwitch_Click(object sender, EventArgs e) { switchState(salaLuzSwitch, luzSala); }

        private void tvSwitch_Click(object sender, EventArgs e) { switchState(salaTvSwitch, tvSala); }

        private void coziLuzSwitch_Click(object sender, EventArgs e) { switchState(coziLuzSwitch, luzCozi); }

        private void coziFogoSwitch_Click(object sender, EventArgs e) { switchState(coziFogoSwitch, coziFogo); }

        private void coziGeloSwitch_Click(object sender, EventArgs e) { switchState(coziGeloSwitch, coziGelo); }

        private void simuStart_Click(object sender, EventArgs e)
        {
            if (dataTimer.Enabled)
            { 
                dataTimer.Stop(); 
            } 
            
            else
            {
                total = 0;
                kwh = 0;

                fatura.Text = "R$" + 0.ToString("F2");
                kwLabel.Text = 0.ToString("F1") + " KWh";

                dataTimer.Interval = 1000/interval;
                
                // tabela p converter certo

                // ITERAÇÃO POR SEGUNDO

                // 1000 -> 1 HORA
                // 500   -> 2 HORAS
                // 250   -> 4 HORAS
                // 125   -> 8 HORAS
                // 100   -> 10 HORAS
                // 41     -> 24 HORAS

                dataTimer.Start();
            }
        }

        private void dataTimer_Tick(object sender, EventArgs e)
        {

            foreach (KeyValuePair<string, eletron> x in eletros)
            {
                if (x.Value.state) { 
                    total += (x.Value.volt * fpu / 1000f) + flagSum;
                    kwh += x.Value.volt / 1000f;
                }
            } 

            fatura.Text = "R$" + total.ToString("F2");
            kwLabel.Text = kwh.ToString("F1") + " KWh";
        }

        private void btConfig_Click(object sender, EventArgs e)
        {
            configForm config = new configForm(flagSum, interval);
            config.ShowDialog();

            flagSum = config.selectedFlag;
            interval = config.timeInterval;
        }
    }
}
