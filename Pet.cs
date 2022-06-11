using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System;
using System.Data.SqlClient;



namespace WindowsFormsApp1
{
    public partial class Pet : Form
    {
        public Pet()
        {
            InitializeComponent();
        }

        

        private void btnSalvarPet_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DUKE\SQLEXPRESS01;Initial Catalog=pet;Integrated Security=True");


            
            String sql =    "INSERT INTO cad_pet(id, nome_pet, peso, idade, raça)VALUES(@id, @nome_pet, @peso, @idade, @raça)";


            Random numeroID = new Random();
            numeroID.Next();
            try
            {
                
                SqlCommand c = new SqlCommand(sql, conn);
                c.Parameters.Add(new SqlParameter("@id", numeroID.Next()));
                c.Parameters.Add(new SqlParameter("@nome_pet", this.txtnome_pet.Text));
                c.Parameters.Add(new SqlParameter("@peso", this.txtpeso.Text));
                c.Parameters.Add(new SqlParameter("@idade", this.txtIdade.Text));
                c.Parameters.Add(new SqlParameter("@raça", this.txtRaça.Text ));



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

