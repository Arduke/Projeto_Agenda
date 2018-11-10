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
        public Contato (string _email, string _nome, string _telefone)
        {
            if (EmailValido(_email) &&
                TelefoneValido(_telefone))
            {
                this.email = _email;
                this.telefone = _telefone;
                this.nome = _nome;
            }
            else
            {
                throw new Exception("Dados inválidos");
            }
        }
        public Contato(string email)
        {
            if (email.Contains("@") && email.Contains("."))
                this.email = email;
        }
        public Contato() : this("","","")
        {

        }

        #endregion

        #region Sobreescritas
        public override bool Equals(object obj)
        {
            try
            {
                Contato c = (Contato)obj;
                return this.email.Equals(c.Email) || this.nome.Equals(c.Nome);
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region metodos

        public string dados()
        {
            return " Nome:" + this.nome  + "  " +  " Email: " + this.email + "  " + " Telefone:" +
                this.telefone;
        }

        private bool EmailValido(string email)
        {
            return (email.Contains("@") && email.Contains(".")) || string.IsNullOrEmpty(email);
        }

        private bool TelefoneValido(string telefone)
        {
            double teste;
            string steste = telefone.Replace("(", string.Empty).Replace(")", string.Empty).Replace("-", string.Empty);
            return (double.TryParse(steste, out teste) && steste.Length > 9 && steste.Length <= 11) || string.IsNullOrEmpty(telefone);
        }

        #endregion
    }
}
