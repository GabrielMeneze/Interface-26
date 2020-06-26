namespace Interface_26
{
    public interface ICarrinho
    {
         
         void Alterar(int _cod, Produto produtoAlterado);
         void cadastrar(Produto produto);
         void Deletar(Produto produto);
         void listar();
    }
}