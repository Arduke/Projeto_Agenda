using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda
{
    class Contato // MODEL
    {
        #region Atributos
        private string email;
        private string nome;
        private string telefone;


        #endregion

        #region Propriedades
        public string Email { get => email; set => email = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        #endregion

        #region Construtores
        public Contato (string email, string nome, string telefone)
        {
            this.email = email;
            this.nome = nome;
            this.telefone = telefone;

        }
        public Contato(string email)
        {
            this.email = email;
            
        }
        public Contato() : this("","","")
        {

        }

        #endregion

        #region Sobreescritas
        public override bool Equals(object obj)
        {
            Contato c = (Contato)obj;
            return this.email.Equals(c.email);
        }
        #endregion

        #region metodos
        public string dados()
        {
            return " Nome:" + this.nome.ToString()  + "  " +  " Email: " + this.email + "  " + " Telefone:" +
            this.telefone.ToString();
        }

        #endregion
    }
}
