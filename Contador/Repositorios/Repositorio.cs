using ContadorBasquete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContadorBasquete.Repositorios
{
    public class Repositorio
    {
        private ApplicationContext contexto;

        public Repositorio()
        {
            this.contexto = new ApplicationContext();
        }

        public void Lancar(LancarPontos lancarPontos)
        {
            contexto.LancarPontos.Add(lancarPontos);
            contexto.SaveChanges();

        }

        public IList<LancarPontos> ListarPontos()
        {

            return contexto.LancarPontos.ToList(); 
        }
        
    }
}
