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
    public partial class frmPesquisar : Form
    { string arquivo,deletado;
        int verificador;

        public frmPesquisar()
        {
            InitializeComponent();
            
        }

        public frmPesquisar(int valor)
        {
            InitializeComponent();
            verificador = valor;
        }



        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rbtEmpregado.Checked == true)
                verificador = 1;
            if (rbtCliente.Checked == true)
                verificador = 2;

            if (verificador == 1)
                arquivo = "C:\\EmpresaJM\\Empregados\\EJM" + txtNomeConsulta.Text.ToUpper() + ".txt";
            else
                arquivo = "C:\\EmpresaJM\\Clientes\\EJM" + txtNomeConsulta.Text.ToUpper() + ".txt";


            if (File.Exists(arquivo))
            {
                txtConsulta.Text = File.ReadAllText(arquivo);
            deletado = File.ReadAllText(arquivo); 
            }
            else
            {
                MessageBox.Show("Não soi possível localizar este arquivo!", "Arquivo inexistente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                windows();
            }
            
        }
       
        public void windows()
        {

            if (ofdConsulta.ShowDialog() == DialogResult.OK && ofdConsulta.FileName.IndexOf("EJM") == 24)
            {

                txtNomeConsulta.Text = ofdConsulta.FileName;
                txtConsulta.Text = File.ReadAllText(ofdConsulta.FileName);
                deletado = File.ReadAllText(ofdConsulta.FileName);
            }
        }

        private void btnConsultarNovamente_Click(object sender, EventArgs e)
        {
            txtConsulta.Text = "";
            txtNomeConsulta.Text = "";
            btnOK.Enabled = false;
            btnConsultarNovamente.Enabled = false;
            rbtCliente.Checked = false;
            rbtEmpregado.Checked = false;
        }
        public string lerFoto()
        {
            string[] nomefoto = File.ReadAllLines(arquivo);
            return nomefoto[arquivo.Length - 1];
        }
        private void btnConcluido_Click(object sender, EventArgs e)
        {
            File.WriteAllText(arquivo,txtConsulta.Text);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNomeConsulta_TextChanged(object sender, EventArgs e)
        {
            if (txtNomeConsulta.Text != "")
            {
                btnOK.Enabled = true;
                btnConsultarNovamente.Enabled = true;
            }
        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            if (txtConsulta.Text != "")
                btnConsultarNovamente.Enabled = true;
        }

        private void btnWindows_Click(object sender, EventArgs e)
        {
            windows();
        }

        private void txtNomeConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && (!Char.IsWhiteSpace(e.KeyChar)) && (!Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtNomeConsulta.Text))
            {
              
                File.Delete(txtNomeConsulta.Text);

                txtConsulta.Text = "";
                txtNomeConsulta.Text = "";
                btnOK.Enabled = false;
                btnConsultarNovamente.Enabled = false;
                rbtCliente.Checked = false;
                rbtEmpregado.Checked = false;
            }
        }
    }
}
