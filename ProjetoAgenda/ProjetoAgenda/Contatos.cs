using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda
{
    class Contatos
    {
        
        #region atributos
        private List<Contato> lista;
        #endregion

        #region Propriedades ONLYREAD
        public List<Contato> Lista
        {
            get { return lista; }
        }
        #endregion

        #region Contrutor Basico
        public Contatos()
        {
            this.lista = new List<Contato>();
        }
        #endregion

        #region Métodos
        public Contato Pesquisa(Contato c)
        {
            return lista.FirstOrDefault(x => x.Equals(c));
        }

        public bool adicionar(Contato c)
        {
            if (Pesquisa(c) == null)
            {
                lista.Add(c);
                return true;
            }
            return false;
        }

        public bool alterar(Contato c)
        {
            var x = Pesquisa(c);
            if (x != null)
            {
                if (!string.IsNullOrEmpty(c.Nome) && c.Nome != x.Nome)
                    x.Nome = c.Nome;
                if (!string.IsNullOrEmpty(c.Email) && c.Email != x.Email)
                    x.Email = c.Email;
                if (!string.IsNullOrEmpty(c.Telefone) && c.Telefone != x.Telefone)
                    x.Telefone = c.Telefone;
                return true;
            }
            return false;
        }

        public bool remover(Contato c)
        {
            if (Pesquisa(c) != null)
            {
                lista.Remove(lista.First(x => x.Equals(c)));
                return true;
            }
            return false;
        }
        #endregion
    }
}
