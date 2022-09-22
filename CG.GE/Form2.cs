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
    public partial class configForm : Form
    {
        public float selectedFlag { get; set; }
        public int timeInterval { get; set; }

        FormCasa mainForm = new FormCasa();

        public configForm(float oldFlag, int oldInterval)
        {
            InitializeComponent();
            comboBoxBandeiras.SelectedItem = mainForm.flagsValues.FirstOrDefault(x => x.Value == oldFlag).Key.ToString();

            delaySetting.Text = oldInterval.ToString(); 
            
        }

        private void configForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            selectedFlag = mainForm.flagsValues[comboBoxBandeiras.SelectedItem.ToString()];
            timeInterval = Convert.ToInt32(delaySetting.Text);

            try
            {
                timeInterval = Convert.ToInt32(delaySetting.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Coloque um número válido!", "Erro Detectado!");
                this.DialogResult = DialogResult.None;
            }
            
        }
    }
}
