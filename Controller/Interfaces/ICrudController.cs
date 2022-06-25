namespace PizzariaCSharp.Controller.Interfaces
{
    public interface ICrudController<T>
    {
        T Adcionar(T modelo);
         List<T> ObterTodas();
         T ObterPorId(int id);
         T Atualizar(int id, T modelo);
         void Remover(int id);
    }
}