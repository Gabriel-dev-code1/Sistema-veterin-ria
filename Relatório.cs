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
    public partial class Relatório : Form
    {
        public Relatório()
        {
            InitializeComponent();
        }

        private void Relatório_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'petDataSet.cad_pet'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_petTableAdapter.Fill(this.petDataSet.cad_pet);
            // TODO: esta linha de código carrega dados na tabela 'clienteDataSet.cad_cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_clienteTableAdapter.Fill(this.clienteDataSet.cad_cliente);

        }
    }
}
