using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdManager.DataBase
{
    public class IDbContext:DbContext
    {
        //Contexto do banco de dados, todas as classes adicionadas aqui serão mapeadas e uma tabela para cada
        //será criada.
        public IDbContext() : base("AdManager") { }

        public DbContext create()
        {
            return new IDbContext();
        }
        public DbSet<Anuncio> anuncios { get; set; }
        public DbSet<Clientes> clientes { get; set; }


    }
}
