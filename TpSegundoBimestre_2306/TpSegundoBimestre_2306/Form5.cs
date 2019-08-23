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
    public partial class Inicializacao : Form
    {  


        public Inicializacao()
        {
            InitializeComponent();
            desaparecer();
        
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool ativo = true;
            if (ativo && this.Opacity > 0.7)
            {
                this.Opacity -= 0.0035D;

            }
            else {
                this.Opacity -= 0.1D;
            }
            if (this.Opacity==0)  
            {        
                ativo = false;
                timer1.Enabled = false;               
                Principal mudando = new Principal();
                mudando.ShowDialog();
                this.Close();        
            }
           
        }
        public void desaparecer()
        {
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
            this.Opacity = 1;
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
