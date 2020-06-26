using System.Collections.Generic;

namespace Interface_26
{
    public class Carrinho : ICarrinho
    {
        List<Produto> carri = new List<Produto>();

        public void Alterar(int _cod, Produto produto )
        {
            carri.Find(b => b.Codigo == _cod).Nome = produto.Nome;
            carri.Find(b => b.Codigo == _cod).Preco = produto.Preco;
        }

        public void cadastrar(Produto produto)
        {
           carri.Add(produto);
        }

        public void Deletar(Produto produto)
        {
            carri.Remove(produto);
        }

        public void listar()
        {
            foreach(Produto c in carri){
                System.Console.WriteLine($"{c.Nome} - {c.Preco:c}");
            }
        }

    }
}