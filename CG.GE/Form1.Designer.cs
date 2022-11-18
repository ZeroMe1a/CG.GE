
namespace CG.GE
{
    partial class FormCasa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCasa));
            this.tvSala = new System.Windows.Forms.PictureBox();
            this.salaLuzSwitch = new System.Windows.Forms.Button();
            this.salaTvSwitch = new System.Windows.Forms.Button();
            this.fatura = new System.Windows.Forms.Label();
            this.dataTimer = new System.Windows.Forms.Timer(this.components);
            this.simuStart = new System.Windows.Forms.Button();
            this.tabAmbientes = new System.Windows.Forms.TabControl();
            this.tabSala = new System.Windows.Forms.TabPage();
            this.luzSala = new System.Windows.Forms.PictureBox();
            this.tabCozinha = new System.Windows.Forms.TabPage();
            this.coziGelo = new System.Windows.Forms.PictureBox();
            this.coziFogo = new System.Windows.Forms.PictureBox();
            this.coziGeloSwitch = new System.Windows.Forms.Button();
            this.coziFogoSwitch = new System.Windows.Forms.Button();
            this.coziLuzSwitch = new System.Windows.Forms.Button();
            this.luzCozi = new System.Windows.Forms.PictureBox();
            this.picPhone = new System.Windows.Forms.PictureBox();
            this.btConfig = new System.Windows.Forms.Button();
            this.kwLabel = new System.Windows.Forms.Label();
            this.advView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tvSala)).BeginInit();
            this.tabAmbientes.SuspendLayout();
            this.tabSala.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luzSala)).BeginInit();
            this.tabCozinha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coziGelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coziFogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luzCozi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // tvSala
            // 
            this.tvSala.BackColor = System.Drawing.Color.Transparent;
            this.tvSala.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tvSala.Image = ((System.Drawing.Image)(resources.GetObject("tvSala.Image")));
            this.tvSala.Location = new System.Drawing.Point(205, 22);
            this.tvSala.Margin = new System.Windows.Forms.Padding(20);
            this.tvSala.Name = "tvSala";
            this.tvSala.Size = new System.Drawing.Size(343, 208);
            this.tvSala.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tvSala.TabIndex = 4;
            this.tvSala.TabStop = false;
            this.tvSala.Visible = false;
            // 
            // salaLuzSwitch
            // 
            this.salaLuzSwitch.BackColor = System.Drawing.Color.Red;
            this.salaLuzSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salaLuzSwitch.Location = new System.Drawing.Point(6, 438);
            this.salaLuzSwitch.Name = "salaLuzSwitch";
            this.salaLuzSwitch.Size = new System.Drawing.Size(125, 30);
            this.salaLuzSwitch.TabIndex = 8;
            this.salaLuzSwitch.Text = "Luz";
            this.salaLuzSwitch.UseVisualStyleBackColor = false;
            this.salaLuzSwitch.Click += new System.EventHandler(this.luzSwitch_Click);
            // 
            // salaTvSwitch
            // 
            this.salaTvSwitch.BackColor = System.Drawing.Color.Red;
            this.salaTvSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salaTvSwitch.Location = new System.Drawing.Point(137, 438);
            this.salaTvSwitch.Name = "salaTvSwitch";
            this.salaTvSwitch.Size = new System.Drawing.Size(125, 30);
            this.salaTvSwitch.TabIndex = 8;
            this.salaTvSwitch.Text = "Televisão";
            this.salaTvSwitch.UseVisualStyleBackColor = false;
            this.salaTvSwitch.Click += new System.EventHandler(this.tvSwitch_Click);
            // 
            // fatura
            // 
            this.fatura.BackColor = System.Drawing.Color.White;
            this.fatura.Font = new System.Drawing.Font("Bebas Neue", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fatura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.fatura.Location = new System.Drawing.Point(799, 202);
            this.fatura.MaximumSize = new System.Drawing.Size(250, 120);
            this.fatura.Name = "fatura";
            this.fatura.Size = new System.Drawing.Size(179, 56);
            this.fatura.TabIndex = 6;
            this.fatura.Text = "R$0,00";
            this.fatura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataTimer
            // 
            this.dataTimer.Tick += new System.EventHandler(this.dataTimer_Tick);
            // 
            // simuStart
            // 
            this.simuStart.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.simuStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.simuStart.Font = new System.Drawing.Font("Segoe MDL2 Assets", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.simuStart.Location = new System.Drawing.Point(815, 325);
            this.simuStart.Name = "simuStart";
            this.simuStart.Size = new System.Drawing.Size(146, 54);
            this.simuStart.TabIndex = 7;
            this.simuStart.Text = "Simular";
            this.simuStart.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.simuStart.UseVisualStyleBackColor = false;
            this.simuStart.Click += new System.EventHandler(this.simuStart_Click);
            // 
            // tabAmbientes
            // 
            this.tabAmbientes.Controls.Add(this.tabSala);
            this.tabAmbientes.Controls.Add(this.tabCozinha);
            this.tabAmbientes.Location = new System.Drawing.Point(5, 4);
            this.tabAmbientes.Name = "tabAmbientes";
            this.tabAmbientes.SelectedIndex = 0;
            this.tabAmbientes.Size = new System.Drawing.Size(760, 502);
            this.tabAmbientes.TabIndex = 8;
            // 
            // tabSala
            // 
            this.tabSala.BackColor = System.Drawing.Color.Transparent;
            this.tabSala.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabSala.BackgroundImage")));
            this.tabSala.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabSala.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabSala.Controls.Add(this.luzSala);
            this.tabSala.Controls.Add(this.salaTvSwitch);
            this.tabSala.Controls.Add(this.tvSala);
            this.tabSala.Controls.Add(this.salaLuzSwitch);
            this.tabSala.Location = new System.Drawing.Point(4, 24);
            this.tabSala.Name = "tabSala";
            this.tabSala.Padding = new System.Windows.Forms.Padding(3);
            this.tabSala.Size = new System.Drawing.Size(752, 474);
            this.tabSala.TabIndex = 0;
            this.tabSala.Text = "Sala";
            // 
            // luzSala
            // 
            this.luzSala.BackColor = System.Drawing.Color.Transparent;
            this.luzSala.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.luzSala.Image = ((System.Drawing.Image)(resources.GetObject("luzSala.Image")));
            this.luzSala.Location = new System.Drawing.Point(-4, 0);
            this.luzSala.Name = "luzSala";
            this.luzSala.Size = new System.Drawing.Size(150, 125);
            this.luzSala.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.luzSala.TabIndex = 9;
            this.luzSala.TabStop = false;
            this.luzSala.Visible = false;
            // 
            // tabCozinha
            // 
            this.tabCozinha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabCozinha.BackgroundImage")));
            this.tabCozinha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabCozinha.Controls.Add(this.coziGelo);
            this.tabCozinha.Controls.Add(this.coziFogo);
            this.tabCozinha.Controls.Add(this.coziGeloSwitch);
            this.tabCozinha.Controls.Add(this.coziFogoSwitch);
            this.tabCozinha.Controls.Add(this.coziLuzSwitch);
            this.tabCozinha.Controls.Add(this.luzCozi);
            this.tabCozinha.Location = new System.Drawing.Point(4, 24);
            this.tabCozinha.Name = "tabCozinha";
            this.tabCozinha.Padding = new System.Windows.Forms.Padding(3);
            this.tabCozinha.Size = new System.Drawing.Size(752, 474);
            this.tabCozinha.TabIndex = 1;
            this.tabCozinha.Text = "Cozinha";
            this.tabCozinha.UseVisualStyleBackColor = true;
            // 
            // coziGelo
            // 
            this.coziGelo.Image = ((System.Drawing.Image)(resources.GetObject("coziGelo.Image")));
            this.coziGelo.Location = new System.Drawing.Point(605, 105);
            this.coziGelo.Name = "coziGelo";
            this.coziGelo.Size = new System.Drawing.Size(141, 38);
            this.coziGelo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coziGelo.TabIndex = 13;
            this.coziGelo.TabStop = false;
            this.coziGelo.Visible = false;
            // 
            // coziFogo
            // 
            this.coziFogo.Image = ((System.Drawing.Image)(resources.GetObject("coziFogo.Image")));
            this.coziFogo.Location = new System.Drawing.Point(321, 260);
            this.coziFogo.Name = "coziFogo";
            this.coziFogo.Size = new System.Drawing.Size(203, 145);
            this.coziFogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coziFogo.TabIndex = 12;
            this.coziFogo.TabStop = false;
            this.coziFogo.Visible = false;
            // 
            // coziGeloSwitch
            // 
            this.coziGeloSwitch.BackColor = System.Drawing.Color.Red;
            this.coziGeloSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coziGeloSwitch.Location = new System.Drawing.Point(268, 438);
            this.coziGeloSwitch.Name = "coziGeloSwitch";
            this.coziGeloSwitch.Size = new System.Drawing.Size(125, 30);
            this.coziGeloSwitch.TabIndex = 11;
            this.coziGeloSwitch.Text = "Geladeira";
            this.coziGeloSwitch.UseVisualStyleBackColor = false;
            this.coziGeloSwitch.Click += new System.EventHandler(this.coziGeloSwitch_Click);
            // 
            // coziFogoSwitch
            // 
            this.coziFogoSwitch.BackColor = System.Drawing.Color.Red;
            this.coziFogoSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coziFogoSwitch.Location = new System.Drawing.Point(137, 438);
            this.coziFogoSwitch.Name = "coziFogoSwitch";
            this.coziFogoSwitch.Size = new System.Drawing.Size(125, 30);
            this.coziFogoSwitch.TabIndex = 10;
            this.coziFogoSwitch.Text = "Fogão";
            this.coziFogoSwitch.UseVisualStyleBackColor = false;
            this.coziFogoSwitch.Click += new System.EventHandler(this.coziFogoSwitch_Click);
            // 
            // coziLuzSwitch
            // 
            this.coziLuzSwitch.BackColor = System.Drawing.Color.Red;
            this.coziLuzSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coziLuzSwitch.Location = new System.Drawing.Point(6, 438);
            this.coziLuzSwitch.Name = "coziLuzSwitch";
            this.coziLuzSwitch.Size = new System.Drawing.Size(125, 30);
            this.coziLuzSwitch.TabIndex = 9;
            this.coziLuzSwitch.Text = "Luz";
            this.coziLuzSwitch.UseVisualStyleBackColor = false;
            this.coziLuzSwitch.Click += new System.EventHandler(this.coziLuzSwitch_Click);
            // 
            // luzCozi
            // 
            this.luzCozi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.luzCozi.Image = ((System.Drawing.Image)(resources.GetObject("luzCozi.Image")));
            this.luzCozi.Location = new System.Drawing.Point(265, -44);
            this.luzCozi.Name = "luzCozi";
            this.luzCozi.Size = new System.Drawing.Size(161, 154);
            this.luzCozi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.luzCozi.TabIndex = 1;
            this.luzCozi.TabStop = false;
            this.luzCozi.Visible = false;
            // 
            // picPhone
            // 
            this.picPhone.BackColor = System.Drawing.Color.Transparent;
            this.picPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picPhone.Image = ((System.Drawing.Image)(resources.GetObject("picPhone.Image")));
            this.picPhone.Location = new System.Drawing.Point(769, 24);
            this.picPhone.Name = "picPhone";
            this.picPhone.Size = new System.Drawing.Size(238, 482);
            this.picPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPhone.TabIndex = 9;
            this.picPhone.TabStop = false;
            // 
            // btConfig
            // 
            this.btConfig.Location = new System.Drawing.Point(823, 385);
            this.btConfig.Name = "btConfig";
            this.btConfig.Size = new System.Drawing.Size(129, 23);
            this.btConfig.TabIndex = 11;
            this.btConfig.Text = "Configurar";
            this.btConfig.UseVisualStyleBackColor = true;
            this.btConfig.Click += new System.EventHandler(this.btConfig_Click);
            // 
            // kwLabel
            // 
            this.kwLabel.BackColor = System.Drawing.Color.White;
            this.kwLabel.Font = new System.Drawing.Font("Bebas Neue", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kwLabel.Location = new System.Drawing.Point(799, 258);
            this.kwLabel.Name = "kwLabel";
            this.kwLabel.Size = new System.Drawing.Size(179, 34);
            this.kwLabel.TabIndex = 12;
            this.kwLabel.Text = "KW/h";
            this.kwLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // advView
            // 
            this.advView.Location = new System.Drawing.Point(819, 438);
            this.advView.Name = "advView";
            this.advView.Size = new System.Drawing.Size(138, 23);
            this.advView.TabIndex = 13;
            this.advView.Text = "Visualização Avançada";
            this.advView.UseVisualStyleBackColor = true;
            this.advView.Click += new System.EventHandler(this.advView_Click);
            // 
            // FormCasa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1013, 507);
            this.Controls.Add(this.advView);
            this.Controls.Add(this.kwLabel);
            this.Controls.Add(this.btConfig);
            this.Controls.Add(this.simuStart);
            this.Controls.Add(this.fatura);
            this.Controls.Add(this.tabAmbientes);
            this.Controls.Add(this.picPhone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCasa";
            this.Text = "Calculadora Gráfica de Gastos Elétricos";
            ((System.ComponentModel.ISupportInitialize)(this.tvSala)).EndInit();
            this.tabAmbientes.ResumeLayout(false);
            this.tabSala.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.luzSala)).EndInit();
            this.tabCozinha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.coziGelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coziFogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luzCozi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox tvSala;
        private System.Windows.Forms.PictureBox luzCozi;
        private System.Windows.Forms.PictureBox luzSala;
        private System.Windows.Forms.PictureBox coziFogo;
        private System.Windows.Forms.PictureBox coziGelo;

        private System.Windows.Forms.Button salaLuzSwitch;
        private System.Windows.Forms.Button salaTvSwitch;
        private System.Windows.Forms.Label fatura;
        private System.Windows.Forms.Timer dataTimer;
        private System.Windows.Forms.Button simuStart;
        private System.Windows.Forms.TabControl tabAmbientes;
        private System.Windows.Forms.TabPage tabSala;
        private System.Windows.Forms.TabPage tabCozinha;
        private System.Windows.Forms.PictureBox picPhone;
        private System.Windows.Forms.Button coziLuzSwitch;
        private System.Windows.Forms.Button coziFogoSwitch;
        private System.Windows.Forms.Button coziGeloSwitch;
        private System.Windows.Forms.Button btConfig;
        private System.Windows.Forms.Label kwLabel;
        private System.Windows.Forms.Button advView;
    }
}

