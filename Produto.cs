using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foursys_teste
{
    class Produto
    {
        //Declarando as variveis e determinando os métodos get e set
        public string name { get; set; }
        public Double preco { get; set; }

        //Declarando o método Produto e seus parametros
        public Produto(string nomeProduto, double precoProduto)
        {
            //Resgatando retorno de nome e preço dos produtos
            this.name = nomeProduto;
            this.preco = precoProduto;
        }

   
    }
}
