using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Func_cad : Form
    {
        public Func_cad()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarFunc_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DUKE\SQLEXPRESS01;Initial Catalog=funcionario;Integrated Security=True");
            string sql = "INSERT INTO func_cad(id, nome, cpf, cargo, telefone, endereço, data_nascimento)VALUES(@id, @nome, @cpf, @cargo, @telefone, @endereço, @data_nascimento)";
            Random numeroId = new Random();
            numeroId.Next();

            try
            {
                SqlCommand c = new SqlCommand(sql, conn);
                c.Parameters.Add(new SqlParameter("@id", numeroId.Next()));
                c.Parameters.Add(new SqlParameter("@nome",this.txtNomeFunc.Text));
                c.Parameters.Add(new SqlParameter("@cpf", this.txtFuncCpf.Text));
                c.Parameters.Add(new SqlParameter("@cargo",this.txtCargo.Text));
                c.Parameters.Add(new SqlParameter("@telefone",this.txtTelefoneFunc.Text));
                c.Parameters.Add(new SqlParameter("@endereço", this.txtEndereçoFunc.Text));
                c.Parameters.Add(new SqlParameter("@data_nascimento",this.txtNascFunc.Text));

                conn.Open();
                c.ExecuteNonQuery();
                MessageBox.Show("cadastrado com sucesso");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("erro no banco" +ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
