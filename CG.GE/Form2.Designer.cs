
namespace CG.GE
{
    partial class configForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.delaySetting = new System.Windows.Forms.TextBox();
            this.labelDelay = new System.Windows.Forms.Label();
            this.comboBoxBandeiras = new System.Windows.Forms.ComboBox();
            this.labelBandeira = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // delaySetting
            // 
            this.delaySetting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.delaySetting.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delaySetting.Location = new System.Drawing.Point(10, 8);
            this.delaySetting.Name = "delaySetting";
            this.delaySetting.Size = new System.Drawing.Size(27, 33);
            this.delaySetting.TabIndex = 0;
            this.delaySetting.Text = "1";
            // 
            // labelDelay
            // 
            this.labelDelay.AutoSize = true;
            this.labelDelay.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDelay.Location = new System.Drawing.Point(40, 11);
            this.labelDelay.Name = "labelDelay";
            this.labelDelay.Size = new System.Drawing.Size(183, 25);
            this.labelDelay.TabIndex = 1;
            this.labelDelay.Text = "horas em 1 segundo";
            // 
            // comboBoxBandeiras
            // 
            this.comboBoxBandeiras.FormattingEnabled = true;
            this.comboBoxBandeiras.Items.AddRange(new object[] {
            "Verde",
            "Amarela",
            "Vermelha - 1°",
            "Vermelha - 2°"});
            this.comboBoxBandeiras.Location = new System.Drawing.Point(107, 59);
            this.comboBoxBandeiras.Name = "comboBoxBandeiras";
            this.comboBoxBandeiras.Size = new System.Drawing.Size(104, 23);
            this.comboBoxBandeiras.TabIndex = 2;
            // 
            // labelBandeira
            // 
            this.labelBandeira.AutoSize = true;
            this.labelBandeira.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBandeira.Location = new System.Drawing.Point(10, 57);
            this.labelBandeira.Name = "labelBandeira";
            this.labelBandeira.Size = new System.Drawing.Size(91, 25);
            this.labelBandeira.TabIndex = 3;
            this.labelBandeira.Text = "Bandeira:";
            // 
            // configForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(234, 112);
            this.Controls.Add(this.labelBandeira);
            this.Controls.Add(this.comboBoxBandeiras);
            this.Controls.Add(this.labelDelay);
            this.Controls.Add(this.delaySetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "configForm";
            this.Text = "Configurar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.configForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox delaySetting;
        private System.Windows.Forms.Label labelDelay;
        private System.Windows.Forms.ComboBox comboBoxBandeiras;
        private System.Windows.Forms.Label labelBandeira;
    }
}