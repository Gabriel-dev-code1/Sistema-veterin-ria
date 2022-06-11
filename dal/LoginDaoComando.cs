using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.dal
{
    class LoginDaoComando
    {
        public bool tem = false;
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexão con = new Conexão();
        SqlDataReader dr;
        public bool verificarLogin(string login, string senha)
        {
            cmd.CommandText = "select *from logins where nome=@login and senha= @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = con.conectar();
                dr= cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch(SqlException)
            {
                this.mensagem = "erro no banco de dados";
            }
            return tem;
        }
        public string cadatrar(string nome, string senha)
        {
            tem = false;
            if (senha.Equals(senha))
            {


                cmd.CommandText = "insert into logins values(@nome, @senha)";
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@senha", senha);
                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "cadastrado com sucesso";
                    tem = true;
                }
                catch (SqlException)
                {
                    this.mensagem = "erro com banco de dados";
                }
            } else
            {
                this.mensagem = "a senha está incorreta";
            }
            
            return mensagem;
        }
    }
}
