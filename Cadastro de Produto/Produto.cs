using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Produto
{
    internal class Produto
    {
        public string Codigo { get; set; }

        public double PrecoAquisicao { get; set; }

        public double ValorVenda { get; set; }

        public string Descricao { get; set; }

        public double Lucro { get; set; }

       

        public Produto()
        {

        }

        public Produto(string codigo,double precoAquisicao, double valorVenda, string descricao, double lucro)
        {
            Codigo = codigo;
            PrecoAquisicao = precoAquisicao;
            ValorVenda = valorVenda;
            Descricao = descricao;
            Lucro = lucro;

        }
    }
}
