using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace TpSegundoBimestre_2306
{
    public partial class CadastroDeClientes : Form
    {   string nomeCliente;
        int valor = 2, cont=0;

        public CadastroDeClientes()
        {
            InitializeComponent();
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            frmPesquisar form4 = new frmPesquisar(valor);
            form4.ShowDialog();
        }

        private void txtEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && (!Char.IsWhiteSpace(e.KeyChar)) && (!Char.IsControl(e.KeyChar)) && (!Char.IsNumber(e.KeyChar)))

            {
                e.Handled = true;
            }
        }
        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && (!Char.IsWhiteSpace(e.KeyChar)) && (!Char.IsControl(e.KeyChar)) && (!Char.IsNumber(e.KeyChar)))

            {
                e.Handled = true;
            }
        }

        private void txtComplem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && (!Char.IsWhiteSpace(e.KeyChar)) && (!Char.IsControl(e.KeyChar)) && (!Char.IsNumber(e.KeyChar)))

            {
                e.Handled = true;
            }
        }

        private void txtBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && (!Char.IsWhiteSpace(e.KeyChar)) && (!Char.IsControl(e.KeyChar)) && (!Char.IsNumber(e.KeyChar)))

            {
                e.Handled = true;
            }
        }

        private void txtCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && (!Char.IsWhiteSpace(e.KeyChar)) && (!Char.IsControl(e.KeyChar)))

            {
                e.Handled = true;
            }
        }

   
        public void limpando()
        { 
            foreach (Control item in CadastroCliente.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                   
                }
            }
        }

        private void btnConcluido_Click_1(object sender, EventArgs e)
        {
            {
                if (!Directory.Exists("C:\\EmpresaJM"))
                {
                    Directory.CreateDirectory("C:\\EmpresaJM");
                }

                Directory.CreateDirectory("C:\\EmpresaJM\\Clientes");
                nomeCliente = "C:\\EmpresaJM\\Clientes\\EJM" + txtRazaoSocial.Text.ToUpper() + ".txt";



                foreach (Control elemento in this.Controls)
                {
                    if (elemento is TextBox & string.IsNullOrEmpty(elemento.Text))
                    {
                        MessageBox.Show("Favor Preencher o(s) Campo(s) vazio(s)");
                        elemento.Select();

                        return;
                    }
                }
                if (cont == 0 && dtpDataFund.Text != "" && mskTelefone.Text != "" && cbxSituacao.Text != "" && cbxUF.Text != "" && mskCep.Text != "" && mskCnpj.Text != "" && mskInscriçaoMun.Text != "" && mskInscriçaoEst.Text != "")
                {

                    File.WriteAllText(nomeCliente, "\r\nCódigo: " + txtCodigo.Text.ToUpper());
                    File.AppendAllText(nomeCliente, "\r\nRazão Social: " + txtRazaoSocial.Text.ToUpper());
                    File.AppendAllText(nomeCliente, "\r\nAtividade Principal: " + txtAtivPrincipal.Text.ToUpper());
                    File.AppendAllText(nomeCliente, "\r\nNome Fantasia: " + txtNomeFanta.Text.ToUpper());
                    File.AppendAllText(nomeCliente, "\r\nInscrição Estadual: " + mskInscriçaoEst.Text.ToUpper());
                    File.AppendAllText(nomeCliente, "\r\nInscrição Municipal: " + mskInscriçaoMun.Text.ToUpper());
                    File.AppendAllText(nomeCliente, "\r\nCNPJ: " + mskCnpj.Text.ToUpper());
                    File.AppendAllText(nomeCliente, "\r\nEndereço:  " + txtEndereco.Text.ToUpper());
                    File.AppendAllText(nomeCliente, "\r\nNúmero:  " + txtNum.Text.ToUpper());
                    File.AppendAllText(nomeCliente, "\r\nComplemento : " + txtComplem.Text.ToUpper());
                    File.AppendAllText(nomeCliente, "\r\nCEP:: " + mskCep.Text.ToUpper());
                    File.AppendAllText(nomeCliente, "\r\nBairro: " + txtBairro.Text.ToUpper());
                    File.AppendAllText(nomeCliente, "\r\nCidade: " + txtCidade.Text.ToUpper());
                    File.AppendAllText(nomeCliente, "\r\nUF: " + cbxUF.Text.ToUpper());
                    File.AppendAllText(nomeCliente, "\r\nSituação: " + cbxSituacao.Text.ToUpper());
                    File.AppendAllText(nomeCliente, "\r\nTelefone: " + mskTelefone.Text.ToUpper());
                    File.AppendAllText(nomeCliente, "\r\nSite: " + txtSite.Text.ToUpper());
                    File.AppendAllText(nomeCliente, "\r\nE-mail: " + txtEmail.Text.ToUpper());
                    File.AppendAllText(nomeCliente, "\r\nData da Fundação: " + dtpDataFund.Text.ToUpper());
                    File.AppendAllText(nomeCliente, "\r\nObservações: " + txtObs.Text.ToUpper());
                }
            }
        }

        private void txtRazaoSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && (!Char.IsWhiteSpace(e.KeyChar)) && (!Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void txtCidade_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && (!Char.IsWhiteSpace(e.KeyChar)) && (!Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void txtAtivPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && (!Char.IsWhiteSpace(e.KeyChar)) && (!Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void txtNum_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsControl(e.KeyChar)) && (!Char.IsNumber(e.KeyChar)))
                e.Handled = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpando();
        }

    }
}
