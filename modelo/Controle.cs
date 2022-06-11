using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.dal;

namespace WindowsFormsApp1.modelo
{
    public class Controle
    {
        public bool tem;
        public string mensagem;
        public bool acessar(string login, string senha)
        {
            LoginDaoComando loginDao = new LoginDaoComando();
            tem=loginDao.verificarLogin(login, senha);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }

        internal void cadastrar(string text)
        {
            throw new NotImplementedException();
        }

        public string cadastrar(string nome, string senha)
        {
            LoginDaoComando loginDao = new LoginDaoComando();
            this.mensagem=loginDao.cadatrar(nome, senha);
            if (loginDao.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
