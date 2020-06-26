using System;

namespace Interface_26
{
    class Program
    {
        static void Main(string[] args)
        {
           Produto produto = new Produto(); 
           Produto produto0 = new Produto(786,"Galaxy A20",899f);
           Produto produto1 = new Produto(980,"Galaxy A30",1000f);
           Produto produto2 = new Produto(654,"Galaxy A40",1200f);
           Produto produto3 = new Produto(325,"Galaxy A50",1500f);

           Carrinho carrinho = new Carrinho();
           carrinho.cadastrar(produto0);
           carrinho.cadastrar(produto1);
           carrinho.cadastrar(produto2);
           carrinho.cadastrar(produto3);

           carrinho.listar();
        }
    }
}
