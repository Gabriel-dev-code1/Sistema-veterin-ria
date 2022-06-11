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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DUKE\SQLEXPRESS01;Initial Catalog=cliente;Integrated Security=True");
            String sql = "INSERT INTO cad_cliente(id, nome, altura, cpf, data_nacimento, telefone, endereço) VALUES(@id, @nome, @altura, @cpf, @data_nacimento, @telefone, @endereço)";
            Random numeroID = new Random();
            numeroID.Next();
            try
            {

                SqlCommand c = new SqlCommand(sql, conn);
                c.Parameters.Add(new SqlParameter("@id", numeroID.Next()));
                c.Parameters.Add(new SqlParameter("@nome", this.txtNome.Text));
                c.Parameters.Add(new SqlParameter("@altura", this.txtAltura.Text));
                c.Parameters.Add(new SqlParameter("@cpf", this.txtCpf.Text));
                c.Parameters.Add(new SqlParameter("@data_nacimento", this.txtData.Text));
                c.Parameters.Add(new SqlParameter("@telefone", this.txtTelefone.Text));
                c.Parameters.Add(new SqlParameter("@endereço", this.txtEndereço.Text));

                conn.Open();
                c.ExecuteNonQuery();

                MessageBox.Show("salvo com sucesso");
            }

            catch (SqlException ex)
            {




                MessageBox.Show("houve um erro" + ex);

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
