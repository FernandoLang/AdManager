using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdManager.Bll
{
    public class Calc
    {
        public double max_range(double value, double coeficient, int Share_Coeficient, int days)
        {
            //Retorna o alcance máxito tendo em vista:
            //1 -> A cada 1 real o valor coeficient(padrão é 30 e pode ser alterado pelo usuário) de pessoas veem o anúncio:
            //2 -> O anuncio pode ser compartilhado 4 vezes(pode ser alterado pelo usuário) em sequência
            //3 -> O valor será multiplicado pelo número de dias que o anúncio ficará no ar
            double range = Math.Floor(((value * coeficient) * Share_Coeficient) * days);
            return range;
        }
        public double Get_range(double value, double coeficient,int days)
        {
            //Retorna apenas o alcance primário sem compartilhamentos
            double range = Math.Floor((value * coeficient) * days);
            return range;
        }
        public double Get_Clicks(double range, double coeficient)
        {
            //Retorna o número de cliques baseado em um coeficiente padrão definido pelo usuário
            //o padrão é 8
            double Clicks = Math.Floor(range / coeficient);
            return Clicks;
        }



    }
}
