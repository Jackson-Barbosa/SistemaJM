namespace TpSegundoBimestre_2306
{
    partial class CadastroDeEmpregados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroDeEmpregados));
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnConcluido = new System.Windows.Forms.Button();
            this.dtpDataAdm = new System.Windows.Forms.DateTimePicker();
            this.dtpInicioSec = new System.Windows.Forms.DateTimePicker();
            this.dtpInicioCarg = new System.Windows.Forms.DateTimePicker();
            this.dtpInicioDep = new System.Windows.Forms.DateTimePicker();
            this.txtPreferencia1 = new System.Windows.Forms.TextBox();
            this.txtSecao2 = new System.Windows.Forms.TextBox();
            this.txtSecao1 = new System.Windows.Forms.TextBox();
            this.txtCargo1 = new System.Windows.Forms.TextBox();
            this.txtDepartamento2 = new System.Windows.Forms.TextBox();
            this.txtDepartamento1 = new System.Windows.Forms.TextBox();
            this.txtCarteiraExpedidora = new System.Windows.Forms.ComboBox();
            this.dtpDataEmi = new System.Windows.Forms.DateTimePicker();
            this.txtCarteiraSerie = new System.Windows.Forms.TextBox();
            this.txtCarteiraNumero = new System.Windows.Forms.TextBox();
            this.txtCracha = new System.Windows.Forms.TextBox();
            this.mskPIS = new System.Windows.Forms.MaskedTextBox();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rbtFeminino = new System.Windows.Forms.RadioButton();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.gbxFoto = new System.Windows.Forms.GroupBox();
            this.lblFoto = new System.Windows.Forms.Label();
            this.btnAdicionarFoto = new System.Windows.Forms.Button();
            this.pbxFoto = new System.Windows.Forms.PictureBox();
            this.txtCargo2 = new System.Windows.Forms.TextBox();
            this.txtPreferencia2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.gbxSexo.SuspendLayout();
            this.gbxFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(409, 481);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 23);
            this.btnPesquisar.TabIndex = 48;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click_1);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(303, 480);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 23);
            this.btnLimpar.TabIndex = 47;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click_1);
            // 
            // btnConcluido
            // 
            this.btnConcluido.Location = new System.Drawing.Point(197, 480);
            this.btnConcluido.Name = "btnConcluido";
            this.btnConcluido.Size = new System.Drawing.Size(100, 23);
            this.btnConcluido.TabIndex = 46;
            this.btnConcluido.Text = "Concluído";
            this.btnConcluido.UseVisualStyleBackColor = true;
            this.btnConcluido.Click += new System.EventHandler(this.btnConcluido_Click_1);
            // 
            // dtpDataAdm
            // 
            this.dtpDataAdm.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAdm.Location = new System.Drawing.Point(550, 450);
            this.dtpDataAdm.Name = "dtpDataAdm";
            this.dtpDataAdm.Size = new System.Drawing.Size(99, 20);
            this.dtpDataAdm.TabIndex = 27;
            // 
            // dtpInicioSec
            // 
            this.dtpInicioSec.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicioSec.Location = new System.Drawing.Point(550, 406);
            this.dtpInicioSec.Name = "dtpInicioSec";
            this.dtpInicioSec.Size = new System.Drawing.Size(99, 20);
            this.dtpInicioSec.TabIndex = 26;
            // 
            // dtpInicioCarg
            // 
            this.dtpInicioCarg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicioCarg.Location = new System.Drawing.Point(550, 356);
            this.dtpInicioCarg.Name = "dtpInicioCarg";
            this.dtpInicioCarg.Size = new System.Drawing.Size(99, 20);
            this.dtpInicioCarg.TabIndex = 25;
            // 
            // dtpInicioDep
            // 
            this.dtpInicioDep.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicioDep.Location = new System.Drawing.Point(550, 309);
            this.dtpInicioDep.Name = "dtpInicioDep";
            this.dtpInicioDep.Size = new System.Drawing.Size(99, 20);
            this.dtpInicioDep.TabIndex = 24;
            // 
            // txtPreferencia1
            // 
            this.txtPreferencia1.AcceptsTab = true;
            this.txtPreferencia1.Location = new System.Drawing.Point(6, 453);
            this.txtPreferencia1.Name = "txtPreferencia1";
            this.txtPreferencia1.Size = new System.Drawing.Size(55, 20);
            this.txtPreferencia1.TabIndex = 22;
            this.txtPreferencia1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSecao2
            // 
            this.txtSecao2.AcceptsTab = true;
            this.txtSecao2.Location = new System.Drawing.Point(67, 406);
            this.txtSecao2.Name = "txtSecao2";
            this.txtSecao2.Size = new System.Drawing.Size(449, 20);
            this.txtSecao2.TabIndex = 21;
            // 
            // txtSecao1
            // 
            this.txtSecao1.AcceptsTab = true;
            this.txtSecao1.Location = new System.Drawing.Point(6, 406);
            this.txtSecao1.Name = "txtSecao1";
            this.txtSecao1.Size = new System.Drawing.Size(55, 20);
            this.txtSecao1.TabIndex = 20;
            // 
            // txtCargo1
            // 
            this.txtCargo1.AcceptsTab = true;
            this.txtCargo1.Location = new System.Drawing.Point(6, 359);
            this.txtCargo1.Name = "txtCargo1";
            this.txtCargo1.Size = new System.Drawing.Size(55, 20);
            this.txtCargo1.TabIndex = 18;
            // 
            // txtDepartamento2
            // 
            this.txtDepartamento2.AcceptsTab = true;
            this.txtDepartamento2.Location = new System.Drawing.Point(67, 312);
            this.txtDepartamento2.Name = "txtDepartamento2";
            this.txtDepartamento2.Size = new System.Drawing.Size(449, 20);
            this.txtDepartamento2.TabIndex = 17;
            // 
            // txtDepartamento1
            // 
            this.txtDepartamento1.AcceptsTab = true;
            this.txtDepartamento1.Location = new System.Drawing.Point(6, 312);
            this.txtDepartamento1.Name = "txtDepartamento1";
            this.txtDepartamento1.Size = new System.Drawing.Size(55, 20);
            this.txtDepartamento1.TabIndex = 16;
            // 
            // txtCarteiraExpedidora
            // 
            this.txtCarteiraExpedidora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCarteiraExpedidora.FormattingEnabled = true;
            this.txtCarteiraExpedidora.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.txtCarteiraExpedidora.Location = new System.Drawing.Point(531, 253);
            this.txtCarteiraExpedidora.Name = "txtCarteiraExpedidora";
            this.txtCarteiraExpedidora.Size = new System.Drawing.Size(151, 21);
            this.txtCarteiraExpedidora.TabIndex = 15;
            // 
            // dtpDataEmi
            // 
            this.dtpDataEmi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEmi.Location = new System.Drawing.Point(356, 254);
            this.dtpDataEmi.Name = "dtpDataEmi";
            this.dtpDataEmi.Size = new System.Drawing.Size(156, 20);
            this.dtpDataEmi.TabIndex = 14;
            this.dtpDataEmi.Value = new System.DateTime(2017, 6, 23, 0, 0, 0, 0);
            // 
            // txtCarteiraSerie
            // 
            this.txtCarteiraSerie.AcceptsTab = true;
            this.txtCarteiraSerie.Location = new System.Drawing.Point(195, 253);
            this.txtCarteiraSerie.Name = "txtCarteiraSerie";
            this.txtCarteiraSerie.Size = new System.Drawing.Size(136, 20);
            this.txtCarteiraSerie.TabIndex = 13;
            // 
            // txtCarteiraNumero
            // 
            this.txtCarteiraNumero.AcceptsTab = true;
            this.txtCarteiraNumero.Location = new System.Drawing.Point(26, 253);
            this.txtCarteiraNumero.Name = "txtCarteiraNumero";
            this.txtCarteiraNumero.Size = new System.Drawing.Size(150, 20);
            this.txtCarteiraNumero.TabIndex = 12;
            this.txtCarteiraNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCarteiraNumero_KeyPress_1);
            // 
            // txtCracha
            // 
            this.txtCracha.AcceptsTab = true;
            this.txtCracha.Location = new System.Drawing.Point(466, 164);
            this.txtCracha.Name = "txtCracha";
            this.txtCracha.Size = new System.Drawing.Size(89, 20);
            this.txtCracha.TabIndex = 10;
            this.txtCracha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCracha_KeyPress_1);
            // 
            // mskPIS
            // 
            this.mskPIS.Location = new System.Drawing.Point(582, 164);
            this.mskPIS.Mask = "000.00000.00-0";
            this.mskPIS.Name = "mskPIS";
            this.mskPIS.Size = new System.Drawing.Size(100, 20);
            this.mskPIS.TabIndex = 11;
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbtFeminino);
            this.gbxSexo.Controls.Add(this.rbtMasculino);
            this.gbxSexo.Location = new System.Drawing.Point(339, 150);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(112, 64);
            this.gbxSexo.TabIndex = 33;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // rbtFeminino
            // 
            this.rbtFeminino.AutoSize = true;
            this.rbtFeminino.Location = new System.Drawing.Point(6, 35);
            this.rbtFeminino.Name = "rbtFeminino";
            this.rbtFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbtFeminino.TabIndex = 13;
            this.rbtFeminino.TabStop = true;
            this.rbtFeminino.Text = "Feminino";
            this.rbtFeminino.UseVisualStyleBackColor = true;
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Location = new System.Drawing.Point(6, 15);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtMasculino.TabIndex = 12;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // txtCidade
            // 
            this.txtCidade.AcceptsTab = true;
            this.txtCidade.Location = new System.Drawing.Point(479, 118);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(205, 20);
            this.txtCidade.TabIndex = 8;
            this.txtCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCidade_KeyPress_1);
            // 
            // txtNumero
            // 
            this.txtNumero.AcceptsTab = true;
            this.txtNumero.Location = new System.Drawing.Point(345, 118);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 7;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // txtEndereco
            // 
            this.txtEndereco.AcceptsTab = true;
            this.txtEndereco.Location = new System.Drawing.Point(345, 67);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(338, 20);
            this.txtEndereco.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.AcceptsTab = true;
            this.txtNome.Location = new System.Drawing.Point(346, 20);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(338, 20);
            this.txtNome.TabIndex = 5;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress_1);
            // 
            // txtCodigo
            // 
            this.txtCodigo.AcceptsTab = true;
            this.txtCodigo.Location = new System.Drawing.Point(199, 20);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNasc.Location = new System.Drawing.Point(199, 64);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(99, 20);
            this.dtpDataNasc.TabIndex = 2;
            // 
            // txtBairro
            // 
            this.txtBairro.AcceptsTab = true;
            this.txtBairro.Location = new System.Drawing.Point(199, 118);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(100, 20);
            this.txtBairro.TabIndex = 3;
            // 
            // mskCep
            // 
            this.mskCep.Location = new System.Drawing.Point(199, 165);
            this.mskCep.Mask = "00000-000";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(100, 20);
            this.mskCep.TabIndex = 4;
            // 
            // gbxFoto
            // 
            this.gbxFoto.Controls.Add(this.lblFoto);
            this.gbxFoto.Controls.Add(this.btnAdicionarFoto);
            this.gbxFoto.Controls.Add(this.pbxFoto);
            this.gbxFoto.Location = new System.Drawing.Point(0, 0);
            this.gbxFoto.Name = "gbxFoto";
            this.gbxFoto.Size = new System.Drawing.Size(185, 199);
            this.gbxFoto.TabIndex = 25;
            this.gbxFoto.TabStop = false;
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Location = new System.Drawing.Point(57, 80);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(25, 13);
            this.lblFoto.TabIndex = 9;
            this.lblFoto.Text = "foto";
            // 
            // btnAdicionarFoto
            // 
            this.btnAdicionarFoto.Location = new System.Drawing.Point(137, 19);
            this.btnAdicionarFoto.Name = "btnAdicionarFoto";
            this.btnAdicionarFoto.Size = new System.Drawing.Size(39, 31);
            this.btnAdicionarFoto.TabIndex = 8;
            this.btnAdicionarFoto.Text = "ADD";
            this.btnAdicionarFoto.UseVisualStyleBackColor = true;
            this.btnAdicionarFoto.Click += new System.EventHandler(this.btnAdicionarFoto_Click);
            // 
            // pbxFoto
            // 
            this.pbxFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxFoto.Location = new System.Drawing.Point(6, 13);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(125, 169);
            this.pbxFoto.TabIndex = 8;
            this.pbxFoto.TabStop = false;
            // 
            // txtCargo2
            // 
            this.txtCargo2.AcceptsTab = true;
            this.txtCargo2.Location = new System.Drawing.Point(67, 359);
            this.txtCargo2.Name = "txtCargo2";
            this.txtCargo2.Size = new System.Drawing.Size(449, 20);
            this.txtCargo2.TabIndex = 19;
            // 
            // txtPreferencia2
            // 
            this.txtPreferencia2.AcceptsTab = true;
            this.txtPreferencia2.Location = new System.Drawing.Point(67, 453);
            this.txtPreferencia2.Name = "txtPreferencia2";
            this.txtPreferencia2.Size = new System.Drawing.Size(449, 20);
            this.txtPreferencia2.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Data de Nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Bairro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "CEP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Número:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "Endereço:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(476, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "Cidade:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(463, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "Crachá:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(579, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 58;
            this.label9.Text = "NIT-PIS/PASEP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(343, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 59;
            this.label10.Text = "Nome:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 237);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 60;
            this.label11.Text = "Número:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(192, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 61;
            this.label12.Text = "Série:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(357, 237);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 62;
            this.label13.Text = "Data Emissão:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(528, 237);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 13);
            this.label14.TabIndex = 63;
            this.label14.Text = "UF Expedidora:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(9, 296);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 13);
            this.label15.TabIndex = 64;
            this.label15.Text = "Departamento:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(9, 343);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 65;
            this.label16.Text = "Cargo:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(9, 390);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 66;
            this.label17.Text = "Seção:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(9, 437);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 13);
            this.label18.TabIndex = 67;
            this.label18.Text = "Preferência:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(547, 296);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(145, 13);
            this.label19.TabIndex = 68;
            this.label19.Text = "Data início no departamento:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(547, 343);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(107, 13);
            this.label20.TabIndex = 69;
            this.label20.Text = "Data início no cargo:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(547, 390);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(109, 13);
            this.label21.TabIndex = 70;
            this.label21.Text = "Data início na seção:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(547, 437);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(81, 13);
            this.label22.TabIndex = 71;
            this.label22.Text = "Data Admissão:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label23.Location = new System.Drawing.Point(-5, 217);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(718, 13);
            this.label23.TabIndex = 72;
            this.label23.Text = resources.GetString("label23.Text");
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label24.Location = new System.Drawing.Point(23, 217);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(234, 13);
            this.label24.TabIndex = 73;
            this.label24.Text = "Carteira de Trabalho e Previdência Social-CTPS";
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "openFileDialog1";
            // 
            // CadastroDeEmpregados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 506);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDataEmi);
            this.Controls.Add(this.txtCarteiraExpedidora);
            this.Controls.Add(this.txtCarteiraSerie);
            this.Controls.Add(this.txtCarteiraNumero);
            this.Controls.Add(this.dtpDataAdm);
            this.Controls.Add(this.dtpInicioSec);
            this.Controls.Add(this.dtpInicioCarg);
            this.Controls.Add(this.dtpInicioDep);
            this.Controls.Add(this.txtPreferencia2);
            this.Controls.Add(this.txtPreferencia1);
            this.Controls.Add(this.txtSecao2);
            this.Controls.Add(this.txtCargo2);
            this.Controls.Add(this.txtSecao1);
            this.Controls.Add(this.txtDepartamento2);
            this.Controls.Add(this.txtCargo1);
            this.Controls.Add(this.txtDepartamento1);
            this.Controls.Add(this.mskPIS);
            this.Controls.Add(this.txtCracha);
            this.Controls.Add(this.mskCep);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.dtpDataNasc);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConcluido);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.gbxFoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "CadastroDeEmpregados";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Empregados";
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.gbxFoto.ResumeLayout(false);
            this.gbxFoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnConcluido;
        private System.Windows.Forms.DateTimePicker dtpDataAdm;
        private System.Windows.Forms.DateTimePicker dtpInicioSec;
        private System.Windows.Forms.DateTimePicker dtpInicioCarg;
        private System.Windows.Forms.DateTimePicker dtpInicioDep;
        private System.Windows.Forms.TextBox txtPreferencia1;
        private System.Windows.Forms.TextBox txtSecao2;
        private System.Windows.Forms.TextBox txtSecao1;
        private System.Windows.Forms.TextBox txtCargo1;
        private System.Windows.Forms.TextBox txtDepartamento2;
        private System.Windows.Forms.TextBox txtDepartamento1;
        private System.Windows.Forms.ComboBox txtCarteiraExpedidora;
        private System.Windows.Forms.DateTimePicker dtpDataEmi;
        private System.Windows.Forms.TextBox txtCarteiraSerie;
        private System.Windows.Forms.TextBox txtCarteiraNumero;
        private System.Windows.Forms.TextBox txtCracha;
        private System.Windows.Forms.MaskedTextBox mskPIS;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.RadioButton rbtFeminino;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.GroupBox gbxFoto;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.Button btnAdicionarFoto;
        private System.Windows.Forms.PictureBox pbxFoto;
        private System.Windows.Forms.TextBox txtCargo2;
        private System.Windows.Forms.TextBox txtPreferencia2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
    }
}