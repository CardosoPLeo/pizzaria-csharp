namespace PizzariaCSharp.Controller.Interfaces
{
    public interface ICrudController<T>
    {
        T Adicionar(T modelo);
         List<T> ObterTodas();
         T ObterPorId(int id);
         T Atualizar(int id, T modelo);
         void Remover(int id);
    }
}