using PizzariaCSharp.Controller.Interfaces;
using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Controller
{
    public class PizzaController : ICrudController<Pizza>
    {
         private ICrudRepository<Pizza> _repositoryPizza;

        public PizzaController(ICrudRepository<Pizza> repositoryPizza)
        {
            _repositoryPizza = repositoryPizza;
        }

        public Pizza Adicionar(Pizza pizza)
        {
            return _repositoryPizza.Adicionar(pizza);
        }

        public Pizza Atualizar(int id, Pizza pizza)
        {
            pizza.Id = id;
            return _repositoryPizza.Atualizar(pizza);
        }

        public Pizza ObterPorId(int id)
        {
            return _repositoryPizza.ObterPorId(id);
        }

        public List<Pizza> ObterTodas()
        {
            return _repositoryPizza.ObterTodas();
        }

        public void Remover(int id)
        {
            _repositoryPizza.Remover(id);
        }
    }
}