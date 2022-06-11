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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnFecharLog_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrarLog_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txtLog.Text, txtSenhaLog.Text);
            if (controle.tem)
            {
                MessageBox.Show("logado com sucesso");
                Menu men = new Menu();
                men.Show();
            }
            else
            {
                MessageBox.Show("login ou senha incorretos");
            }

        }

        private void btnCadLog_Click(object sender, EventArgs e)
        {
            Cadastro_log cad = new Cadastro_log();
            cad.Show();
            Controle controle = new Controle();
            String mensagem= controle.cadastrar(txtLog.Text, txtSenhaLog.Text);
            if(controle.tem)
            {
                MessageBox.Show(mensagem="cadastro");
            }
            else
            {
                MessageBox.Show(mensagem = "erro no banco de dados");
            }
        }
    }
}
