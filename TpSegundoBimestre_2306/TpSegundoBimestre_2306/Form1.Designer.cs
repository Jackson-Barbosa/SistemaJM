namespace TpSegundoBimestre_2306
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnComentarios = new System.Windows.Forms.Button();
            this.btnGerencia = new System.Windows.Forms.Button();
            this.btnEmpregado = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.mnuAjuda = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empregadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comentáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.mnuAjuda.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxLogo.BackgroundImage")));
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxLogo.Enabled = false;
            this.pbxLogo.Location = new System.Drawing.Point(186, 47);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(356, 183);
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // btnComentarios
            // 
            this.btnComentarios.BackColor = System.Drawing.Color.Transparent;
            this.btnComentarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnComentarios.BackgroundImage")));
            this.btnComentarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnComentarios.Location = new System.Drawing.Point(558, 301);
            this.btnComentarios.Name = "btnComentarios";
            this.btnComentarios.Size = new System.Drawing.Size(112, 146);
            this.btnComentarios.TabIndex = 5;
            this.btnComentarios.Text = "COMENTÁRIOS";
            this.btnComentarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnComentarios.UseVisualStyleBackColor = false;
            this.btnComentarios.Click += new System.EventHandler(this.btnComentarios_Click);
            // 
            // btnGerencia
            // 
            this.btnGerencia.BackColor = System.Drawing.Color.Transparent;
            this.btnGerencia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGerencia.BackgroundImage")));
            this.btnGerencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGerencia.Location = new System.Drawing.Point(395, 301);
            this.btnGerencia.Name = "btnGerencia";
            this.btnGerencia.Size = new System.Drawing.Size(112, 146);
            this.btnGerencia.TabIndex = 6;
            this.btnGerencia.Text = "GERÊNCIA";
            this.btnGerencia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGerencia.UseVisualStyleBackColor = false;
            this.btnGerencia.Click += new System.EventHandler(this.btnGerencia_Click);
            // 
            // btnEmpregado
            // 
            this.btnEmpregado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmpregado.BackgroundImage")));
            this.btnEmpregado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEmpregado.Location = new System.Drawing.Point(237, 301);
            this.btnEmpregado.Name = "btnEmpregado";
            this.btnEmpregado.Size = new System.Drawing.Size(106, 146);
            this.btnEmpregado.TabIndex = 7;
            this.btnEmpregado.Text = "EMPREGADOS";
            this.btnEmpregado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmpregado.UseVisualStyleBackColor = true;
            this.btnEmpregado.Click += new System.EventHandler(this.btnEmpregado_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCliente.BackgroundImage")));
            this.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCliente.Location = new System.Drawing.Point(59, 301);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(112, 146);
            this.btnCliente.TabIndex = 8;
            this.btnCliente.Text = "CLIENTES";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // mnuAjuda
            // 
            this.mnuAjuda.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.mnuAjuda.Location = new System.Drawing.Point(0, 0);
            this.mnuAjuda.Name = "mnuAjuda";
            this.mnuAjuda.Size = new System.Drawing.Size(723, 24);
            this.mnuAjuda.TabIndex = 9;
            this.mnuAjuda.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.empregadosToolStripMenuItem,
            this.gerênciaToolStripMenuItem,
            this.comentáriosToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // empregadosToolStripMenuItem
            // 
            this.empregadosToolStripMenuItem.Name = "empregadosToolStripMenuItem";
            this.empregadosToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.empregadosToolStripMenuItem.Text = "Empregados";
            // 
            // gerênciaToolStripMenuItem
            // 
            this.gerênciaToolStripMenuItem.Name = "gerênciaToolStripMenuItem";
            this.gerênciaToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.gerênciaToolStripMenuItem.Text = "Gerência";
            // 
            // comentáriosToolStripMenuItem
            // 
            this.comentáriosToolStripMenuItem.Name = "comentáriosToolStripMenuItem";
            this.comentáriosToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.comentáriosToolStripMenuItem.Text = "Comentários";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.sobreToolStripMenuItem.Text = "Sobre...";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.BackColor = System.Drawing.Color.White;
            this.lblEmpresa.Enabled = false;
            this.lblEmpresa.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.Location = new System.Drawing.Point(253, 226);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(223, 43);
            this.lblEmpresa.TabIndex = 10;
            this.lblEmpresa.Text = "EMPRESA JM";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(697, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(26, 24);
            this.btnFechar.TabIndex = 11;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(723, 479);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnEmpregado);
            this.Controls.Add(this.btnGerencia);
            this.Controls.Add(this.btnComentarios);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.mnuAjuda);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.mnuAjuda.ResumeLayout(false);
            this.mnuAjuda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnComentarios;
        private System.Windows.Forms.Button btnGerencia;
        private System.Windows.Forms.Button btnEmpregado;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.MenuStrip mnuAjuda;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empregadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerênciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comentáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Button btnFechar;
    }
}

