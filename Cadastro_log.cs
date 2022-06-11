using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.modelo;

namespace WindowsFormsApp1
{
    public partial class Cadastro_log : Form
    {
        public Cadastro_log()
        {
            InitializeComponent();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            Controle controli = new Controle();
            String mensagem=controli.cadastrar(txtnomeCadLog.Text, txtSenhaCadLog.Text);
            if (controli.tem)
            {
                MessageBox.Show(mensagem, "cadastro");
            }
            else
            {
                MessageBox.Show(controli.mensagem);
            }

            
        }

        private void Cadastro_log_Load(object sender, EventArgs e)
        {

        }
    }
}
