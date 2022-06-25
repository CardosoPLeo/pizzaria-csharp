using PizzariaCSharp.Controller.Interfaces;
using PizzariaCSharp.Model;

namespace PizzariaCSharp.Controller
{
    public class PizzaController : ICrudController<Pizza>
    {
        public Pizza Adicionar(Pizza modelo)
        {
            throw new NotImplementedException();
        }

        public Pizza Atualizar(int id, Pizza modelo)
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