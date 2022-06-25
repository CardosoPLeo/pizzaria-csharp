using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Repository
{
    public class PizzaRepository : ICrudRepository<Pizza>
    {
        private List<Pizza> _pizzas;
        
        private int _ultimoId = 0;
        
        public PizzaRepository()
        {
            _pizzas = new List<Pizza>();
        }

        public Pizza Adicionar(Pizza pizza)
        {
            _ultimoId ++;
            pizza.Id = _ultimoId;
            _pizzas.Add(pizza);
            return pizza;
        }

        public Pizza Atualizar(Pizza pizza)
        {
            var pizzaExiste = _pizzas.Where(b => b.Id == pizza.Id).FirstOrDefault();

            if (pizzaExiste == null)
            {
                throw new Exception("Não possível atualizar uma pizza inexistente");
            }
            _pizzas.Remove(pizzaExiste);
            _pizzas.Add(pizza);

            return pizza;
        }

        public Pizza ObterPorId(int id)
        {
            return _pizzas.Where(p => p.Id == id).FirstOrDefault();
        }

        public List<Pizza> ObterTodas()
        {
            return _pizzas;
        }

        public void Remover(int id)
        {
            var pizza = ObterPorId(id);

            if (pizza == null)
            {
                throw new Exception("Não foi encontrado uma pizza para remover");
            }

            _pizzas.Remove(pizza);
        }
    }
}