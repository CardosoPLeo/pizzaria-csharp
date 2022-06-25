using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Repository
{
    public class PizzaRepository : ICrudRepository<Pizza>
    {
        public Pizza Adcionar(Pizza modelo)
        {
            throw new NotImplementedException();
        }

        public Pizza Atualizar(Pizza modelo)
        {
            throw new NotImplementedException();
        }

        public Pizza ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pizza> ObterTodas()
        {
            throw new NotImplementedException();
        }

        public void Remover(int id)
        {
            throw new NotImplementedException();
        }
    }
}