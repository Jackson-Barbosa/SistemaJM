namespace TpSegundoBimestre_2306
{
    partial class frmPesquisar
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
            this.lblNomeConsulta = new System.Windows.Forms.Label();
            this.txtNomeConsulta = new System.Windows.Forms.TextBox();
            this.btnConcluido = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnConsultarNovamente = new System.Windows.Forms.Button();
            this.ofdConsulta = new System.Windows.Forms.OpenFileDialog();
            this.rbtCliente = new System.Windows.Forms.RadioButton();
            this.rbtEmpregado = new System.Windows.Forms.RadioButton();
            this.btnWindows = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomeConsulta
            // 
            this.lblNomeConsulta.AutoSize = true;
            this.lblNomeConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeConsulta.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblNomeConsulta.Location = new System.Drawing.Point(22, 18);
            this.lblNomeConsulta.Name = "lblNomeConsulta";
            this.lblNomeConsulta.Size = new System.Drawing.Size(53, 18);
            this.lblNomeConsulta.TabIndex = 2;
            this.lblNomeConsulta.Text = "Nome:";
            // 
            // txtNomeConsulta
            // 
            this.txtNomeConsulta.Location = new System.Drawing.Point(25, 38);
            this.txtNomeConsulta.Name = "txtNomeConsulta";
            this.txtNomeConsulta.Size = new System.Drawing.Size(148, 20);
            this.txtNomeConsulta.TabIndex = 4;
            this.txtNomeConsulta.TextChanged += new System.EventHandler(this.txtNomeConsulta_TextChanged);
            this.txtNomeConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeConsulta_KeyPress);
            // 
            // btnConcluido
            // 
            this.btnConcluido.Location = new System.Drawing.Point(254, 431);
            this.btnConcluido.Name = "btnConcluido";
            this.btnConcluido.Size = new System.Drawing.Size(100, 23);
            this.btnConcluido.TabIndex = 6;
            this.btnConcluido.Text = "Finalizar";
            this.btnConcluido.UseVisualStyleBackColor = true;
            this.btnConcluido.Click += new System.EventHandler(this.btnConcluido_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(360, 431);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(101, 23);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(200, 12);
            this.txtConsulta.Multiline = true;
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(294, 413);
            this.txtConsulta.TabIndex = 9;
            this.txtConsulta.TextChanged += new System.EventHandler(this.txtConsulta_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(63, 88);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 39);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnConsultarNovamente
            // 
            this.btnConsultarNovamente.Enabled = false;
            this.btnConsultarNovamente.Location = new System.Drawing.Point(42, 231);
            this.btnConsultarNovamente.Name = "btnConsultarNovamente";
            this.btnConsultarNovamente.Size = new System.Drawing.Size(120, 27);
            this.btnConsultarNovamente.TabIndex = 11;
            this.btnConsultarNovamente.Text = "Outra Consulta";
            this.btnConsultarNovamente.UseVisualStyleBackColor = true;
            this.btnConsultarNovamente.Click += new System.EventHandler(this.btnConsultarNovamente_Click);
            // 
            // ofdConsulta
            // 
            this.ofdConsulta.FileName = "openFileDialog1";
            // 
            // rbtCliente
            // 
            this.rbtCliente.AutoSize = true;
            this.rbtCliente.ForeColor = System.Drawing.Color.White;
            this.rbtCliente.Location = new System.Drawing.Point(25, 264);
            this.rbtCliente.Name = "rbtCliente";
            this.rbtCliente.Size = new System.Drawing.Size(57, 17);
            this.rbtCliente.TabIndex = 12;
            this.rbtCliente.TabStop = true;
            this.rbtCliente.Text = "Cliente";
            this.rbtCliente.UseVisualStyleBackColor = true;
            // 
            // rbtEmpregado
            // 
            this.rbtEmpregado.AutoSize = true;
            this.rbtEmpregado.ForeColor = System.Drawing.Color.White;
            this.rbtEmpregado.Location = new System.Drawing.Point(25, 287);
            this.rbtEmpregado.Name = "rbtEmpregado";
            this.rbtEmpregado.Size = new System.Drawing.Size(79, 17);
            this.rbtEmpregado.TabIndex = 13;
            this.rbtEmpregado.TabStop = true;
            this.rbtEmpregado.Text = "Empregado";
            this.rbtEmpregado.UseVisualStyleBackColor = true;
            // 
            // btnWindows
            // 
            this.btnWindows.Location = new System.Drawing.Point(63, 133);
            this.btnWindows.Name = "btnWindows";
            this.btnWindows.Size = new System.Drawing.Size(75, 23);
            this.btnWindows.TabIndex = 14;
            this.btnWindows.Text = "Windows";
            this.btnWindows.UseVisualStyleBackColor = true;
            this.btnWindows.Click += new System.EventHandler(this.btnWindows_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(467, 431);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(27, 22);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.Text = "x";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // frmPesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(506, 467);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnWindows);
            this.Controls.Add(this.rbtEmpregado);
            this.Controls.Add(this.rbtCliente);
            this.Controls.Add(this.btnConsultarNovamente);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnConcluido);
            this.Controls.Add(this.txtNomeConsulta);
            this.Controls.Add(this.lblNomeConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmPesquisar";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Empregado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNomeConsulta;
        private System.Windows.Forms.TextBox txtNomeConsulta;
        private System.Windows.Forms.Button btnConcluido;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnConsultarNovamente;
        private System.Windows.Forms.OpenFileDialog ofdConsulta;
        private System.Windows.Forms.RadioButton rbtCliente;
        private System.Windows.Forms.RadioButton rbtEmpregado;
        private System.Windows.Forms.Button btnWindows;
        private System.Windows.Forms.Button btnExcluir;
    }
}