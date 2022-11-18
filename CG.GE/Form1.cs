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
            public bool state; // estado do aparelho
            public int volt; // voltagem do aparelho
            public int totaltime; // tempo total de execução do aparelho

            public eletron(bool s, int v, int tt)
            {
                this.state = s;
                this.volt = v;
                this.totaltime = tt;
            }
        }

        // calc values

        // Fatura por Unidade (Taxas e impostos incluídos)
        const float fpu = 1.028690f;

        // Bandeira atual
        public float flagSum { get; set; }

        // Intervalo de tempo usado para a simulação
        public int interval { get; set; }

        int tempo;
        float kwh = 0;
        float total = 0;

        // uma lâmpada LED de 3W demora ~333 HORAS pra gastar 1 kW
        // uma TV LED 4K de 60" demora ~5 horas pra gastar 1 kW (https://www.fastshop.com.br/wcsstore/FastShopCAS/manuais/VD/Samsung/SGUN55KU6500.pdf)

        // https://www.ovoenergy.com/guides/energy-guides/what-is-a-kwh-kw-and-kwh-explained


        Dictionary<string, eletron> eletros = new Dictionary<string, eletron>();
        public Dictionary<string, float> flagsValues = new Dictionary<string, float>();

        public FormCasa()
        {
            init();
            InitializeComponent();
        }

        //
        // SWITCHES
        // Estas são as funções responsáveis por ligar/desligar dispositivos

        private void init()
        {
            flagSum = 0;

            // Preenchendo dicionário de dispositivos eletrônicos disponiveis
            // eletros.Add("NOME PictureBox", new eletron(ESTADO, VOLTAGEM));
 

            eletros.Add("luzSala", new eletron(false, 3, 0));
            eletros.Add("tvSala", new eletron(false, 140, 0));
            eletros.Add("coziFogo", new eletron(false, 25, 0));
            eletros.Add("coziGelo", new eletron(false, 500, 0));
            eletros.Add("luzCozi", new eletron(false, 3, 0));

            // Preenchendo dicionário de bandeiras e suas devidas faturas
            // Bandeira -> Fatura
            flagsValues.Add("Verde", 0);
            flagsValues.Add("Amarela", 0.01874f);
            flagsValues.Add("Vermelha - 1°", 0.03971f);
            flagsValues.Add("Vermelha - 2°", 0.09492f);

            interval = 1;
        }

        private void switchState(Button switcher, PictureBox target)
        {
            switcher.BackColor = eletros[target.Name].state ? Color.Red : Color.Green;
            target.Visible = !eletros[target.Name].state;

            eletros[target.Name] = new eletron(!eletros[target.Name].state, eletros[target.Name].volt, eletros[target.Name].totaltime);
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
            // dada a passagem de um intervalo, este bloco de código vai ser executado
            tempo++;

            // loop de cálculo para cada eletrônico
            // caso o dispositivo esteja ligado:

            // calcule (volt*fatura / 1000) + bandeira e some ao total da fatura
            // calcule volt/1000 e some ao total de kWh gastos
            foreach (KeyValuePair<string, eletron> x in eletros)
            {
                if (x.Value.state) { 
                    total += (x.Value.volt * fpu / 1000f) + flagSum;
                    kwh += x.Value.volt / 1000f;
                    eletros[x.Key] = new eletron(x.Value.state, x.Value.volt, x.Value.totaltime+1);
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

        private void advView_Click(object sender, EventArgs e)
        {
            string info = "";

            // para cada eletrônico, calcule seu gasto total de kWh dado seu tempo ativo
            foreach (KeyValuePair<string, eletron> x in eletros)
            {
                info += x.Key.ToString()+": "+(x.Value.volt/1000f * x.Value.totaltime).ToString("F2")+" kWh\n";
            }

            MessageBox.Show(info);
        }
    }
}
