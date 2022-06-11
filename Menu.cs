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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            pet.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Func_cad func = new Func_cad();
            func.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cliente client = new Cliente();
            client.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Relatório relat = new Relatório();
            relat.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Relatorio_func relat_func = new Relatorio_func();
            relat_func.Show();
        }
    }
}
