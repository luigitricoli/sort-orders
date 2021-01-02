using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foursys_teste
{
    class Program
    {
        //Declarando as variáveis e setando os seus valores
        static List<Produto> carrinho;
        static double maior = 0;
        static double menor = maior;

        static void Main(string[] args)
        {

            //Instanciando uma nova lista de produtos
            carrinho = new List<Produto>();
            
            //Adicionando os produtos ao List
            carrinho.Add(new Produto("Liquidificador", 250.0));
            carrinho.Add(new Produto("Geladeira", 450.0));
            carrinho.Add(new Produto("Jogo de pratos", 70.0));
     
            //Exibindo mensagem de listagem
            Console.WriteLine("{{ LISTAGEM DE PRODUTOS }}\n\n");

            foreach (Produto p in carrinho)
            {
                //Exibindo cada item do carrinho e o seu determinado preço
                Console.WriteLine("Nome: " + p.name + " - " + "Preço: " + p.preco);
           
                //Definindo qual é o maior e o menor valor e armazenando nas suas respectivas variáveis
                if (p.preco > maior)
                {
                    maior = p.preco;

                }else if (p.preco < maior)
                {
                    menor = p.preco;
                }
            }

            //Determinando quantos itens existem dentro do carrinho
            Console.WriteLine("\n\nO carrinho tem " + carrinho.Count + " produtos.");

            //Exibindo o maior e o menor valor
            Console.Write("\n\nO maior valor é: " + maior);
            Console.Write("\n\nO menor valor é: " + menor);

            //Exibindo mensagem de finalização
            Console.Write("\n\nPressione ENTER para encerrar");
            Console.ReadLine();
         
        }
    }
}
