using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpSegundoBimestre_2306
{
    public partial class Principal : Form
    {

        public Principal()
        {
            InitializeComponent();
         
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            CadastroDeClientes form3 = new CadastroDeClientes();
            form3.ShowDialog();
        }

        private void btnEmpregado_Click(object sender, EventArgs e)
        {
            CadastroDeEmpregados form2 = new CadastroDeEmpregados();
            form2.ShowDialog();
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do programa?", "Saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
            else
                btnCliente.Focus();

        }

        private void btnComentarios_Click(object sender, EventArgs e)
        {
            MessageBox.Show("        Os comentários foram desativados no momento pela gerência.\n Caso queira entrar em contato com a empresa ligue para (XX) XXXX-4154","Indisponível");
        }

        private void btnGerencia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prazer meu nome é Jackson Barbosa responsável por um terço da empresa JM.\nJunto a mim está a Mariana Duarte e Maykon Santana que possuem os outros dois terços(cada um com um claro).\nSomos alunos do INSTITUTO FEDERAL DE SÃO PAULO - CAMPUS CUBATÃO e para entrar em contato conosco basta ligar para (XX) XXXX-4154 ou mandar um e-mail para gerenciajm@gmail.com\nTenha um bom dia!","Contato Primário");
        }



        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroDeClientes formClientes = new CadastroDeClientes();
            formClientes.ShowDialog();

        }
        private void empregadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroDeEmpregados formEmpregados = new CadastroDeEmpregados();
            formEmpregados.ShowDialog();
        }
        private void comentáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquisar Comentários = new frmPesquisar();
            Comentários.ShowDialog();
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do programa?", "Saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
            else
                btnCliente.Focus();
        }
        private void gerênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prazer meu nome é Jackson Barbosa responsável por um terço da empresa JM.\nJunto a mim está a Mariana Duarte e Maykon Santana que possuem os outros dois terços(cada um com um claro).\nSomos alunos do INSTITUTO FEDERAL DE SÃO PAULO - CAMPUS CUBATÃO e para entrar em contato conosco basta ligar para (XX) XXXX-4154 ou mandar um e-mail para gerenciajm@gmail.com\nTenha um bom dia!", "Contato Primário");
        }

    }
}
