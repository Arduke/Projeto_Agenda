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
        public void adicionar(Contato c)
        {
            this.lista.Add(c);
        }

        public bool remover(Contato c)
        {
            return this.lista.Remove(c);
        }

        public Contato Pesquisa(Contato c)
        {
            Contato aux = new Contato();

            foreach(Contato ca in Lista)
            {
                if (ca.Equals(c))
                {
                    aux = ca; 
                }

            }
            return aux;
           
        }

        #endregion
    }
}
