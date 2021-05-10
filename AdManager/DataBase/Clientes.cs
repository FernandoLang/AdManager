using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdManager.DataBase
{
    public class Clientes
    {
        //Classe responsável por compor a tabela Clientes do banco de dados
        //Será com base nas propriedades dela que o programa irá gerar a tabela
        [Key()]
        public int Id { get; set; }
        public string Name { get; set; }


        //Salva os dados preenchidos no banco de dados após as validações
        public void Save()
        {
            IDbContext db = new IDbContext();
            db.clientes.Add(this);
            db.SaveChanges();
        }
        //Retorna todos os dados do banco de dados
        public static List<Clientes> get_all()
        {
            IDbContext db = new IDbContext();
            return db.clientes.ToList();
        }


    }
}
