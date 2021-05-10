using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdManager.DataBase
{
    public class Anuncio
    {
        //Classe responsável por compor a tabela Anuncio do banco de dados
        //Será com base nas propriedades dela que o programa irá gerar a tabela
        [Key()]
        public int Id { get; set; }
        public string Name { get; set; }

        //Relacionamento com a classe cliente de um pra muitos (um cliente pode ter vários anuncios mas um anúncio só pode ter um
        //cliente, ao ser mapeada o banco de dados irá relacionar a tabela que foi criada de anúncios com a tabela de clientes.
        [ForeignKey("Clientes")]
        public int Client_Id { get; set; }
        public virtual Clientes Clientes { get; set; }

        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public double Value_per_day { get; set; }


        //Salva os dados preenchidos no banco de dados após as validações
        public void Save()
        {
            IDbContext db = new IDbContext();
            db.anuncios.Add(this);
            db.SaveChanges();
        }
        //Retorna todos os dados do banco de dados
        public static List<Anuncio> get_all()
        {
            IDbContext db = new IDbContext();
            return db.anuncios.ToList();
        }
        



    }
}
