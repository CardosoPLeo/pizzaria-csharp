namespace PizzariaCSharp.Repository.Interfaces
{
    public interface ICrudRepository<T>
    {
         T Adcionar(T modelo);
         List<T> ObterTodas();
         T ObterPorId(int id);
         T Atualizar(T modelo);
         void Remover(int id);
    }
}