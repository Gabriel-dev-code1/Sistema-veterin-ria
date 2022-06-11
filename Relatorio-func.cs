using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Relatorio_func : Form
    {
        public Relatorio_func()
        {
            InitializeComponent();
        }

        private void Relatorio_func_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'funcionarioDataSet.func_cad'. Você pode movê-la ou removê-la conforme necessário.
            this.func_cadTableAdapter.Fill(this.funcionarioDataSet.func_cad);

        }
    }
}
