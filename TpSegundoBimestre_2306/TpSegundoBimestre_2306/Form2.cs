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
    public partial class CadastroDeEmpregados : Form
    {
        string sexo="", nomeEmpregado,nomefoto;
        int valor = 1;

        public CadastroDeEmpregados()
        {
            InitializeComponent();

        }
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && (!Char.IsWhiteSpace(e.KeyChar)) && (!Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void txtEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && (!Char.IsWhiteSpace(e.KeyChar)) && (!Char.IsControl(e.KeyChar)) && (!Char.IsNumber(e.KeyChar)))
                e.Handled = true;
        }

        private void txtBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && (!Char.IsWhiteSpace(e.KeyChar)) && (!Char.IsControl(e.KeyChar)) && (!Char.IsNumber(e.KeyChar)))
                e.Handled = true;
        }

        private void txtCracha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && (!Char.IsWhiteSpace(e.KeyChar)) && (!Char.IsControl(e.KeyChar)) && (!Char.IsNumber(e.KeyChar)))
                e.Handled = true;
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && (!Char.IsWhiteSpace(e.KeyChar)) && (!Char.IsControl(e.KeyChar)) && (!Char.IsNumber(e.KeyChar)))
                e.Handled = true;

        }

        private void txtCarteiraNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsWhiteSpace(e.KeyChar) && (!Char.IsControl(e.KeyChar)) && (!Char.IsNumber(e.KeyChar)))
                e.Handled = true;
        }
        private void txtCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && (!Char.IsWhiteSpace(e.KeyChar)) && (!Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            limpando();
        }

        private void btnConcluido_Click_1(object sender, EventArgs e)
        {
            if (rbtMasculino.Checked == true)
                sexo = "MASCULINO";

            if (rbtFeminino.Checked == true)
                sexo = "FEMININO";


            if (!Directory.Exists("C:\\EmpresaJM"))
                Directory.CreateDirectory("C:\\EmpresaJM");

            if (!Directory.Exists("C:\\EmpresaJM\\Empregados"))
                Directory.CreateDirectory("C:\\EmpresaJM\\Empregados");

                foreach (Control elemento in this.Controls)
                {
                    if(elemento is TextBox & string.IsNullOrEmpty(elemento.Text))
                    {
                        MessageBox.Show("Favor Preencher o(s) Campo(s) vazio(s)");
                        elemento.Select();
                    return;
              
                    }

                }


            if (sexo != "" || txtCarteiraExpedidora.Text=="")
            {
                nomeEmpregado = "C:\\EmpresaJM\\Empregados\\EJM" + txtNome.Text.ToUpper() + ".txt";
                File.WriteAllText(nomeEmpregado, "\r\nCódigo: " + txtCodigo.Text.ToUpper());
                File.AppendAllText(nomeEmpregado, "\r\nData de Nascimento: " + dtpDataNasc.Text.ToUpper());
                File.AppendAllText(nomeEmpregado, "\r\nBairro: " + txtBairro.Text.ToUpper());
                File.AppendAllText(nomeEmpregado, "\r\nCEP: " + mskCep.Text.ToUpper());
                File.AppendAllText(nomeEmpregado, "\r\nNome: " + txtNome.Text.ToUpper());
                File.AppendAllText(nomeEmpregado, "\r\nEndereço: " + txtEndereco.Text.ToUpper());
                File.AppendAllText(nomeEmpregado, "\r\nNúmero: " + txtNumero.Text.ToUpper());
                File.AppendAllText(nomeEmpregado, "\r\nCidade: " + txtCidade.Text.ToUpper());
                File.AppendAllText(nomeEmpregado, "\r\nSexo: " + sexo);
                File.AppendAllText(nomeEmpregado, "\r\nCrachá: " + txtCracha.Text.ToUpper());
                File.AppendAllText(nomeEmpregado, "\r\nPIS: " + mskPIS.Text.ToUpper());
                File.AppendAllText(nomeEmpregado, "\r\nNúmero da Carteira: " + txtCarteiraNumero.Text.ToUpper());
                File.AppendAllText(nomeEmpregado, "\r\nNúmero de Série da Carteira: " + txtCarteiraSerie.Text.ToUpper());
                File.AppendAllText(nomeEmpregado, "\r\nData de Emissão da carteira: " + dtpDataEmi.Text.ToUpper());
                File.AppendAllText(nomeEmpregado, "\r\nExpedidora da Carteira: " + txtCarteiraExpedidora.Text.ToUpper());
                File.AppendAllText(nomeEmpregado, "\r\nDepartamento:" + txtDepartamento1.Text.ToUpper());
                File.AppendAllText(nomeEmpregado, " -" + txtDepartamento2.Text.ToUpper());
                File.AppendAllText(nomeEmpregado, "\r\nCargo: " + txtCargo1.Text.ToUpper());
                File.AppendAllText(nomeEmpregado, "-" + txtCargo2.Text.ToUpper());
                File.AppendAllText(nomeEmpregado, "\r\nSeção: " + txtSecao1.Text.ToUpper());
                File.AppendAllText(nomeEmpregado, "-" + txtSecao2.Text.ToUpper());
                File.AppendAllText(nomeEmpregado, "\r\nPreferências do emprego: " + txtPreferencia1.Text.ToUpper());
                File.AppendAllText(nomeEmpregado, "-" + txtPreferencia2.Text.ToUpper());
                File.AppendAllText(nomeEmpregado, "\r\nData do início no departamento: " + dtpInicioDep.Text.ToUpper());
                File.AppendAllText(nomeEmpregado, "\r\nData do início no cargo: " + dtpInicioCarg.Text.ToUpper());
                File.AppendAllText(nomeEmpregado, "\r\nData do início na seção: " + dtpInicioSec.Text.ToUpper());
                File.AppendAllText(nomeEmpregado, "\r\nData da Admissão: " + dtpDataAdm.Text.ToUpper());
                File.AppendAllText(nomeEmpregado, "\r\nCaminho da FOTO:\r\n" + nomefoto);
                limpando();
            }
            else {
                MessageBox.Show("Favor Preencher o(s) Campo(s) vazio(s)");
            }
        
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {

            frmPesquisar form4 = new frmPesquisar(valor);
            form4.ShowDialog();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsControl(e.KeyChar)) && (!Char.IsNumber(e.KeyChar)))
                e.Handled = true;
        }

        private void txtCarteiraNumero_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsControl(e.KeyChar)) && (!Char.IsNumber(e.KeyChar)))
                e.Handled = true;
        }

        private void txtCidade_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && (!Char.IsWhiteSpace(e.KeyChar)) && (!Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void txtCracha_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsControl(e.KeyChar)) && (!Char.IsNumber(e.KeyChar)))
                e.Handled = true;
        }

        private void txtNome_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && (!Char.IsWhiteSpace(e.KeyChar)) && (!Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void btnAdicionarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "jpg|*.jpg";
            if (file.ShowDialog() == DialogResult.OK)
            {
                pbxFoto.ImageLocation = file.FileName;
                nomefoto = file.FileName;
                lblFoto.Visible = false;
            }
        }

        public void limpando()
        {
            rbtFeminino.Checked = false;
            rbtMasculino.Checked = false;
            txtCodigo.Text = "";
            dtpDataNasc.Text = "";
            txtBairro.Text = "";
            mskCep.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtNumero.Text = "";
            txtCidade.Text = "";
            sexo = "";
            txtCracha.Text = "";
            mskPIS.Text = "";
            txtCarteiraNumero.Text = "";
            txtCarteiraSerie.Text = "";
            dtpDataEmi.Text = "";
            txtCarteiraExpedidora.Text = "";
            txtDepartamento1.Text = "";
            txtDepartamento2.Text = "";
            txtCargo1.Text = "";
            txtCargo2.Text = "";
            txtSecao1.Text = "";
            txtSecao2.Text = "";
            txtPreferencia1.Text = "";
            txtPreferencia2.Text = "";
            dtpInicioDep.Text = "";
            dtpInicioCarg.Text = "";
            dtpInicioSec.Text = "";
            dtpDataAdm.Text = "";
            lblFoto.Visible = true;
            pbxFoto.ImageLocation = null;
        }
    }
}
